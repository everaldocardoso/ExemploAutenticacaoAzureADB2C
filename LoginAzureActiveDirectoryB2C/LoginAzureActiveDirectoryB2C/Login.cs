
using Microsoft.Identity.Client;
using System.Net.Http.Headers;

namespace LoginAzureActiveDirectoryB2C
{
    public partial class Login : Form
    {
        private IPublicClientApplication PublicClientApplication;
        private string tipoDeToken = "Bearer";
        private string clientId = "1f3f441f-5ee1-4573-993c-4ede45736b21";
        private string tenantId = "b63d9676-b87d-487c-88b7-16c78cb62a3e";
        private string urlRedirecionamento = "http://localhost";        
        private string urlWebApiClientesRestritos = "https://localhost:5001/api/v1/Teste";
        private string urlEscopo = "https://fibrasiltn.onmicrosoft.com/fibrasil-it-sit-frontend-portal-tenants/user_impersonation";
        private string urlAutoridade = "https://login.microsoftonline.com/{0}/oauth2/v2.0/";

        public Login()
        {
            InitializeComponent();

            PublicClientApplication = PublicClientApplicationBuilder
                .Create(clientId)
                .WithB2CAuthority(string.Format(urlAutoridade, tenantId))
                .WithRedirectUri(urlRedirecionamento)
                .WithDefaultRedirectUri()
                .Build();
        }

        private async Task<AuthenticationResult> SingIn()
        {
            return await PublicClientApplication
                    .AcquireTokenInteractive(new List<string>() { urlEscopo }.ToList())
                    .ExecuteAsync();
        }

        private async Task<HttpResponseMessage> ObterDadosAPIPropria(string token)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tipoDeToken, token);
            return await httpClient.GetAsync(urlWebApiClientesRestritos);
        }

        private async void btnFazerLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var authResult = await SingIn();
                var httpResponse = await ObterDadosAPIPropria(authResult.AccessToken);
                txtRetorno.Text = httpResponse.StatusCode.ToString();
                txtRetorno.Text += "\n\n" + httpResponse.Content.ReadAsStringAsync().Result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
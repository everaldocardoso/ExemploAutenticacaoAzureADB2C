
using Microsoft.Identity.Client;
using System.Net.Http.Headers;

namespace LoginAzureActiveDirectoryB2C
{
    public partial class Login : Form
    {
        public static IPublicClientApplication PublicClientApplication;

        private string clientIdWebApi = "fb847f62-7817-461d-b480-73df2e68749c";
        private string clientId = "c5ad8d9b-011f-4f24-ae5c-83df61f4ea05";
        private string tenantId = "cd5fe627-0485-4ba7-ae92-ff8ecbf9b336";
        private string tenantName = "newsolucoesemsoftware";
        private string policy = "B2C_1_susi";
        private string urlRedirecionamento = "http://localhost";
        private string tipoDeToken = "Bearer";
        private string urlWebApiClientesRestritos = "https://localhost:7220/api/ClientesRestritos";

        public Login()
        {
            InitializeComponent();

            PublicClientApplication = PublicClientApplicationBuilder
                .Create(clientId)
                .WithB2CAuthority($"https://{tenantName}.b2clogin.com/tfp/{tenantId}/{policy}")                  
                .WithRedirectUri(urlRedirecionamento)
                .WithDefaultRedirectUri()                
                .Build();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task<AuthenticationResult> SingIn()
        {
            return await PublicClientApplication
                    .AcquireTokenInteractive(ObterEscopos())
                    .ExecuteAsync();
        }

        private async Task<HttpResponseMessage> ObterDadosAPIPropria(string token)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tipoDeToken, token);
            return await httpClient.GetAsync(urlWebApiClientesRestritos);            
        }

        private List<string> ObterEscopos()
        {
            var urlbase = $"https://{tenantName}.onmicrosoft.com/{clientIdWebApi}";
            return new List<string>()
            {
                $"{urlbase}/read",
                $"{urlbase}/write"
            }.ToList();
        }
    }
}

using Microsoft.Identity.Client;

namespace LoginAzureActiveDirectoryB2C
{
    public partial class Login : Form
    {
        private string clientId = "1f3f441f-5ee1-4573-993c-4ede45736b21";
        private string tenantId = "b63d9676-b87d-487c-88b7-16c78cb62a3e";
        private string urlRedirecionamento = "http://localhost";        
        private string urlEscopo = "https://fibrasiltn.onmicrosoft.com/fibrasil-it-sit-frontend-portal-tenants/user_impersonation";
        private string urlAutoridade = "https://login.microsoftonline.com/{0}/oauth2/v2.0/";

        public Login()
        {
            InitializeComponent();

            txtClienteId.Text = clientId;
            txtTenantID.Text = tenantId;
            txtURLRedirecionamento.Text = urlRedirecionamento;
            txtAutoridade.Text = urlAutoridade;
            txtEscopo.Text = urlEscopo;                    
        }

        private async Task<AuthenticationResult> SingIn()
        {
            var PublicClientApplication = PublicClientApplicationBuilder
               .Create(txtClienteId.Text)
               .WithB2CAuthority(string.Format(txtAutoridade.Text, txtTenantID.Text))
               .WithRedirectUri(txtURLRedirecionamento.Text)
               .WithDefaultRedirectUri()               
               .Build();

            return await PublicClientApplication
                    .AcquireTokenInteractive(new List<string>() { txtEscopo.Text }.ToList())
                    .ExecuteAsync();
        }

        private async void btnFazerLogin_Click(object sender, EventArgs e)
        {
            Enabled = false;
            Cursor = Cursors.WaitCursor;            
            try
            {
                txtRetorno.Clear();
                var authResult = await SingIn();                
                txtRetorno.Text = authResult.AccessToken;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                Enabled = true;
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRetorno.Text)) return;
            Clipboard.SetText(txtRetorno.Text);
            btnCopiar.Text = "COPIADO!";
            Application.DoEvents();
            Thread.Sleep(3000);
            btnCopiar.Text = "COPIAR";
            Application.DoEvents();
        }
    }
}
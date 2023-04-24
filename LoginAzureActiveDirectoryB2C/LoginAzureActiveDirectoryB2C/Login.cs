
using LoginAzureActiveDirectoryB2C.Model;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace LoginAzureActiveDirectoryB2C
{
    public partial class Login : Form
    {
        private int timer = 0;

        public Login()
        {
            InitializeComponent();
            cboEnviroment.DataSource = LoadingDataEnviroment();
            lblTempo.Text = nudTimer.Value.ToString();
        }

        private List<Ambiente> LoadingDataEnviroment()
        {
            return new List<Ambiente>
            {
                new Ambiente
                {
                    Description = "SIT - Staging",
                    ClienteId = "1f3f441f-5ee1-4573-993c-4ede45736b21",
                    TenantId = "b63d9676-b87d-487c-88b7-16c78cb62a3e",
                    UrlRedirecionamento = "http://localhost",
                    UrlEscopo = "https://fibrasiltn.onmicrosoft.com/fibrasil-it-sit-frontend-portal-tenants/user_impersonation",
                    UrlAutoridade = "https://login.microsoftonline.com/{0}/oauth2/v2.0/",
                    Active = true
                },
                new Ambiente
                {
                    Description = "UAT - Release (Inativo)",
                    ClienteId = "1f3f441f-5ee1-4573-993c-4ede45736b21",
                    TenantId = "b63d9676-b87d-487c-88b7-16c78cb62a3e",
                    UrlRedirecionamento = "http://localhost",
                    UrlEscopo = "https://fibrasiltn.onmicrosoft.com/fibrasil-it-uat-frontend-portal-tenants/user_impersonation",
                    UrlAutoridade = "https://login.microsoftonline.com/{0}/oauth2/v2.0/",
                    Active = false
                },
                new Ambiente
                {
                    Description = "PROD - Production (Inativo)",
                    ClienteId = "38a32969-7528-4ac4-a8d9-388f36ce43ba",
                    TenantId = "b63d9676-b87d-487c-88b7-16c78cb62a3e",
                    UrlRedirecionamento = "http://localhost",
                    UrlEscopo = "https://fibrasiltn.onmicrosoft.com/fibrasil-it-prd-frontend-portal-tenants/user_impersonation",
                    UrlAutoridade = "https://login.microsoftonline.com/{0}/oauth2/v2.0/",
                    Active = false
                }
            };
        }

        private async Task<AuthenticationResult> SingIn(Ambiente enviroment)
        {
            timer = Convert.ToInt32((nudTimer.Value));
            tmrTickTac.Interval = 1000;
            tmrTickTac.Start();
            try
            {
                var cancellationToken = new CancellationTokenSource();
                cancellationToken.CancelAfter(Convert.ToInt32(nudTimer.Value * 1000m));

                var publicClientApplication = PublicClientApplicationBuilder
                   .Create(enviroment.ClienteId)
                   .WithB2CAuthority(string.Format(enviroment.UrlAutoridade, enviroment.TenantId))
                   .WithRedirectUri(enviroment.UrlRedirecionamento)
                   .WithDefaultRedirectUri()
                   .Build();

                return await publicClientApplication
                        .AcquireTokenInteractive(new List<string>() { enviroment.UrlEscopo }.ToList())
                        .ExecuteAsync(cancellationToken.Token);

                tmrTickTac.Stop();
            }
            catch (OperationCanceledException ex)
            {
                tmrTickTac.Stop();
                MessageBox.Show("Operação cancelada por atingir o tempo limite.");

            }
            catch (Exception ex)
            {
                tmrTickTac.Stop();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tmrTickTac.Dispose();
                lblTempo.Text = nudTimer.Value.ToString();
            }

            return null;
        }

        private async void btnFazerLogin_Click(object sender, EventArgs e)
        {
            Enabled = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                var enviroment = (Ambiente)cboEnviroment.SelectedValue;

                if (enviroment is null || !enviroment.Active)
                {
                    MessageBox.Show("Ambiente inválido ou inativo.");
                    return;
                }

                txtRetorno.Clear();
                var authResult = await SingIn(enviroment);
                txtRetorno.Text = authResult?.AccessToken;

                if (string.IsNullOrEmpty(txtRetorno.Text))
                {
                    try
                    {
                        txtRetornoDetalhes.Text = new JwtSecurityTokenHandler().ReadToken(txtRetorno.Text).ToString();
                    }
                    catch
                    {
                    }
                }
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
            if (string.IsNullOrEmpty(txtRetorno.Text))
            {
                MessageBox.Show("Não há dados para copiar.");
                return;
            }

            Clipboard.SetText(txtRetorno.Text);
            btnCopiar.Text = "COPIADO!";
            Application.DoEvents();
            Thread.Sleep(3000);
            btnCopiar.Text = "COPIAR";
            Application.DoEvents();
        }

        private void btnCopiarDetalhes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRetornoDetalhes.Text))
            {
                MessageBox.Show("Não há dados para copiar.");
                return;
            }

            Clipboard.SetText(txtRetornoDetalhes.Text);
            btnCopiarDetalhes.Text = "COPIADO!";
            Application.DoEvents();
            Thread.Sleep(3000);
            btnCopiarDetalhes.Text = "COPIAR";
            Application.DoEvents();
        }

        private void nudTimer_ValueChanged(object sender, EventArgs e)
        {
            lblTempo.Text = nudTimer.Value.ToString();
        }

        private void tmrTickTac_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = (--timer).ToString();
            Application.DoEvents();
        }

        private void txtRetorno_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRetorno.Text))
            {
                txtRetornoDetalhes.Clear();
            }
            else
            {
                try
                {
                    txtRetornoDetalhes.Text = new JwtSecurityTokenHandler().ReadToken(txtRetorno.Text).ToString();
                }
                catch
                {
                }
            }           
        }

        private void chkHabilitarEdicao_CheckedChanged(object sender, EventArgs e)
        {
            txtRetorno.ReadOnly = !chkHabilitarEdicao.Checked;
            txtRetorno.Clear();
            txtRetornoDetalhes.Clear();
        }
    }
}
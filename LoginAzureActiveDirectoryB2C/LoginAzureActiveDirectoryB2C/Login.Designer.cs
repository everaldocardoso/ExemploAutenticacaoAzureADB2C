namespace LoginAzureActiveDirectoryB2C
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFazerLogin = new System.Windows.Forms.Button();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURLRedirecionamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEscopo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAutoridade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFazerLogin
            // 
            this.btnFazerLogin.BackColor = System.Drawing.Color.White;
            this.btnFazerLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFazerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazerLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFazerLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFazerLogin.Location = new System.Drawing.Point(9, 113);
            this.btnFazerLogin.Name = "btnFazerLogin";
            this.btnFazerLogin.Size = new System.Drawing.Size(718, 29);
            this.btnFazerLogin.TabIndex = 0;
            this.btnFazerLogin.Text = "FAZER LOGIN";
            this.btnFazerLogin.UseVisualStyleBackColor = false;
            this.btnFazerLogin.Click += new System.EventHandler(this.btnFazerLogin_Click);
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(9, 148);
            this.txtRetorno.Multiline = true;
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRetorno.Size = new System.Drawing.Size(948, 347);
            this.txtRetorno.TabIndex = 2;
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.White;
            this.btnCopiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopiar.Location = new System.Drawing.Point(733, 113);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(224, 29);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.Text = "COPIAR";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(9, 33);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(222, 23);
            this.txtClienteId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tenant ID";
            // 
            // txtTenantID
            // 
            this.txtTenantID.Location = new System.Drawing.Point(237, 33);
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.Size = new System.Drawing.Size(230, 23);
            this.txtTenantID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "URL Redirecionamento";
            // 
            // txtURLRedirecionamento
            // 
            this.txtURLRedirecionamento.Location = new System.Drawing.Point(473, 33);
            this.txtURLRedirecionamento.Name = "txtURLRedirecionamento";
            this.txtURLRedirecionamento.Size = new System.Drawing.Size(484, 23);
            this.txtURLRedirecionamento.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Escopo";
            // 
            // txtEscopo
            // 
            this.txtEscopo.Location = new System.Drawing.Point(473, 81);
            this.txtEscopo.Name = "txtEscopo";
            this.txtEscopo.Size = new System.Drawing.Size(484, 23);
            this.txtEscopo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Autoridade";
            // 
            // txtAutoridade
            // 
            this.txtAutoridade.Location = new System.Drawing.Point(9, 81);
            this.txtAutoridade.Name = "txtAutoridade";
            this.txtAutoridade.Size = new System.Drawing.Size(458, 23);
            this.txtAutoridade.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAutoridade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEscopo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtURLRedirecionamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenantID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txtRetorno);
            this.Controls.Add(this.btnFazerLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obter Token Azure AD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFazerLogin;
        private TextBox txtRetorno;
        private Button btnCopiar;
        private TextBox txtClienteId;
        private Label label1;
        private Label label2;
        private TextBox txtTenantID;
        private Label label3;
        private TextBox txtURLRedirecionamento;
        private Label label4;
        private TextBox txtEscopo;
        private Label label5;
        private TextBox txtAutoridade;
    }
}
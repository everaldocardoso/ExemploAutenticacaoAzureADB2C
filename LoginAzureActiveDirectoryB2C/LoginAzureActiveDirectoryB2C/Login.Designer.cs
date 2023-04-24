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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnFazerLogin = new System.Windows.Forms.Button();
            this.txtRetorno = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.cboEnviroment = new System.Windows.Forms.ComboBox();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmrTickTac = new System.Windows.Forms.Timer(this.components);
            this.txtRetornoDetalhes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkHabilitarEdicao = new System.Windows.Forms.CheckBox();
            this.btnCopiarDetalhes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFazerLogin
            // 
            this.btnFazerLogin.BackColor = System.Drawing.Color.White;
            this.btnFazerLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFazerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazerLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFazerLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFazerLogin.Location = new System.Drawing.Point(768, 19);
            this.btnFazerLogin.Name = "btnFazerLogin";
            this.btnFazerLogin.Size = new System.Drawing.Size(206, 29);
            this.btnFazerLogin.TabIndex = 0;
            this.btnFazerLogin.Text = "FAZER LOGIN";
            this.btnFazerLogin.UseVisualStyleBackColor = false;
            this.btnFazerLogin.Click += new System.EventHandler(this.btnFazerLogin_Click);
            // 
            // txtRetorno
            // 
            this.txtRetorno.Location = new System.Drawing.Point(11, 45);
            this.txtRetorno.Multiline = true;
            this.txtRetorno.Name = "txtRetorno";
            this.txtRetorno.ReadOnly = true;
            this.txtRetorno.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRetorno.Size = new System.Drawing.Size(944, 264);
            this.txtRetorno.TabIndex = 2;
            this.txtRetorno.TextChanged += new System.EventHandler(this.txtRetorno_TextChanged);
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.White;
            this.btnCopiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopiar.Location = new System.Drawing.Point(863, 19);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(92, 25);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.Text = "COPIAR";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tempo  de espera para cancelamento (segundos):";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(297, 653);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(19, 15);
            this.lblTempo.TabIndex = 5;
            this.lblTempo.Text = "30";
            // 
            // cboEnviroment
            // 
            this.cboEnviroment.FormattingEnabled = true;
            this.cboEnviroment.Location = new System.Drawing.Point(9, 25);
            this.cboEnviroment.Name = "cboEnviroment";
            this.cboEnviroment.Size = new System.Drawing.Size(466, 23);
            this.cboEnviroment.TabIndex = 6;
            // 
            // nudTimer
            // 
            this.nudTimer.Location = new System.Drawing.Point(481, 25);
            this.nudTimer.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.Size = new System.Drawing.Size(159, 23);
            this.nudTimer.TabIndex = 7;
            this.nudTimer.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTimer.ValueChanged += new System.EventHandler(this.nudTimer_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(481, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aguardar por (segundos):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ambiente:";
            // 
            // tmrTickTac
            // 
            this.tmrTickTac.Tick += new System.EventHandler(this.tmrTickTac_Tick);
            // 
            // txtRetornoDetalhes
            // 
            this.txtRetornoDetalhes.Location = new System.Drawing.Point(20, 385);
            this.txtRetornoDetalhes.Multiline = true;
            this.txtRetornoDetalhes.Name = "txtRetornoDetalhes";
            this.txtRetornoDetalhes.ReadOnly = true;
            this.txtRetornoDetalhes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRetornoDetalhes.Size = new System.Drawing.Size(944, 264);
            this.txtRetornoDetalhes.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Token - Detalhes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Token:";
            // 
            // chkHabilitarEdicao
            // 
            this.chkHabilitarEdicao.AutoSize = true;
            this.chkHabilitarEdicao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkHabilitarEdicao.Location = new System.Drawing.Point(363, 6);
            this.chkHabilitarEdicao.Name = "chkHabilitarEdicao";
            this.chkHabilitarEdicao.Size = new System.Drawing.Size(112, 19);
            this.chkHabilitarEdicao.TabIndex = 13;
            this.chkHabilitarEdicao.Text = "Habilitar edição";
            this.chkHabilitarEdicao.UseVisualStyleBackColor = true;
            this.chkHabilitarEdicao.CheckedChanged += new System.EventHandler(this.chkHabilitarEdicao_CheckedChanged);
            // 
            // btnCopiarDetalhes
            // 
            this.btnCopiarDetalhes.BackColor = System.Drawing.Color.White;
            this.btnCopiarDetalhes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopiarDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarDetalhes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopiarDetalhes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopiarDetalhes.Location = new System.Drawing.Point(863, 312);
            this.btnCopiarDetalhes.Name = "btnCopiarDetalhes";
            this.btnCopiarDetalhes.Size = new System.Drawing.Size(92, 25);
            this.btnCopiarDetalhes.TabIndex = 14;
            this.btnCopiarDetalhes.Text = "COPIAR";
            this.btnCopiarDetalhes.UseVisualStyleBackColor = false;
            this.btnCopiarDetalhes.Click += new System.EventHandler(this.btnCopiarDetalhes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCopiarDetalhes);
            this.groupBox1.Controls.Add(this.btnCopiar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRetorno);
            this.groupBox1.Location = new System.Drawing.Point(9, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 631);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.BackColor = System.Drawing.Color.White;
            this.btnRecarregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecarregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRecarregar.Location = new System.Drawing.Point(646, 19);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(116, 29);
            this.btnRecarregar.TabIndex = 16;
            this.btnRecarregar.Text = "RECARREGAR";
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 682);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.chkHabilitarEdicao);
            this.Controls.Add(this.txtRetornoDetalhes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTimer);
            this.Controls.Add(this.cboEnviroment);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnFazerLogin);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obter Token Azure AD";
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFazerLogin;
        private TextBox txtRetorno;
        private Button btnCopiar;
        private Label label1;
        private Label lblTempo;
        private ComboBox cboEnviroment;
        private NumericUpDown nudTimer;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer tmrTickTac;
        private TextBox txtRetornoDetalhes;
        private Label label2;
        private Label label5;
        private CheckBox chkHabilitarEdicao;
        private Button btnCopiarDetalhes;
        private GroupBox groupBox1;
        private Button btnRecarregar;
    }
}
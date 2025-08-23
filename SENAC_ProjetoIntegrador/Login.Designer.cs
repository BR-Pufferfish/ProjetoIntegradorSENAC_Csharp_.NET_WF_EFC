namespace SENAC_ProjetoIntegrador
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResponsavel = new Label();
            lblEmissor = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            groupBox1 = new GroupBox();
            btnFechar = new Button();
            btnEntrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI", 30F);
            lblResponsavel.ForeColor = SystemColors.ActiveCaption;
            lblResponsavel.Location = new Point(693, 240);
            lblResponsavel.Margin = new Padding(6, 0, 6, 0);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(131, 54);
            lblResponsavel.TabIndex = 4;
            lblResponsavel.Text = "Senha";
            // 
            // lblEmissor
            // 
            lblEmissor.AutoSize = true;
            lblEmissor.Font = new Font("Segoe UI", 30F);
            lblEmissor.ForeColor = SystemColors.ActiveCaption;
            lblEmissor.Location = new Point(677, 65);
            lblEmissor.Margin = new Padding(6, 0, 6, 0);
            lblEmissor.Name = "lblEmissor";
            lblEmissor.Size = new Size(157, 54);
            lblEmissor.TabIndex = 5;
            lblEmissor.Text = "Usuário";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(539, 326);
            txtSenha.Margin = new Padding(6, 6, 6, 6);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(442, 78);
            txtSenha.TabIndex = 2;
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(539, 135);
            txtUsuario.Margin = new Padding(6, 6, 6, 6);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(442, 78);
            txtUsuario.TabIndex = 3;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(lblResponsavel);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(lblEmissor);
            groupBox1.Font = new Font("Segoe UI", 40F);
            groupBox1.Location = new Point(29, 74);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(1491, 858);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1477, 13);
            btnFechar.Margin = new Padding(4, 4, 4, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(43, 51);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 22F);
            btnEntrar.Location = new Point(561, 535);
            btnEntrar.Margin = new Padding(4, 4, 4, 4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(381, 94);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1550, 900);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblResponsavel;
        private Label lblEmissor;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private GroupBox groupBox1;
        private Button btnFechar;
        private Button btnEntrar;
    }
}
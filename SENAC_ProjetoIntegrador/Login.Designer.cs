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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResponsavel.ForeColor = SystemColors.ActiveCaption;
            lblResponsavel.Location = new Point(30, 100);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(53, 21);
            lblResponsavel.TabIndex = 4;
            lblResponsavel.Text = "Senha";
            // 
            // lblEmissor
            // 
            lblEmissor.AutoSize = true;
            lblEmissor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmissor.ForeColor = SystemColors.ActiveCaption;
            lblEmissor.Location = new Point(30, 40);
            lblEmissor.Name = "lblEmissor";
            lblEmissor.Size = new Size(64, 21);
            lblEmissor.TabIndex = 5;
            lblEmissor.Text = "Usuário";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(30, 120);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(240, 23);
            txtSenha.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(30, 60);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(240, 23);
            txtUsuario.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(lblResponsavel);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(lblEmissor);
            groupBox1.Location = new Point(110, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 170);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(510, 10);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(30, 30);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 400);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}
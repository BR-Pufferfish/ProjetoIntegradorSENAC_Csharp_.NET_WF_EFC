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
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblEmissor = new Label();
            btnEntrar = new Button();
            btnFechar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.MediumAquamarine;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(619, 447);
            txtSenha.Margin = new Padding(6);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(442, 49);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.MediumAquamarine;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(619, 295);
            txtUsuario.Margin = new Padding(6);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(442, 49);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuário";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(647, 458);
            label5.Name = "label5";
            label5.Size = new Size(80, 32);
            label5.TabIndex = 9;
            label5.Text = "Senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 305);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 8;
            label4.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(630, 451);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(431, 54);
            label3.TabIndex = 7;
            label3.Text = "________________________";
            // 
            // lblEmissor
            // 
            lblEmissor.AutoSize = true;
            lblEmissor.Font = new Font("Segoe UI", 30F);
            lblEmissor.ForeColor = Color.White;
            lblEmissor.Location = new Point(629, 298);
            lblEmissor.Margin = new Padding(6, 0, 6, 0);
            lblEmissor.Name = "lblEmissor";
            lblEmissor.Size = new Size(431, 54);
            lblEmissor.TabIndex = 0;
            lblEmissor.Text = "________________________";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.White;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 22F);
            btnEntrar.ForeColor = SystemColors.ControlText;
            btnEntrar.Location = new Point(647, 654);
            btnEntrar.Margin = new Padding(4);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(381, 94);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1480, 23);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 42);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 60F);
            label1.Location = new Point(619, 48);
            label1.Name = "label1";
            label1.Size = new Size(422, 97);
            label1.TabIndex = 10;
            label1.Text = "TechPoint";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(334, 129);
            label2.Name = "label2";
            label2.Size = new Size(994, 32);
            label2.TabIndex = 11;
            label2.Text = "__________________________________________________________________________________________________";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(1550, 900);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnFechar);
            Controls.Add(label3);
            Controls.Add(btnEntrar);
            Controls.Add(lblEmissor);
            Controls.Add(label4);
            Controls.Add(label5);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Button btnFechar;
        private Button btnEntrar;
        private Label lblEmissor;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label2;
    }
}
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
            btnFechar = new Button();
            label1 = new Label();
            btnEntrar12 = new CuoreUI.Controls.cuiButton();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.LightSkyBlue;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.White;
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
            txtUsuario.BackColor = Color.LightSkyBlue;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.White;
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
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(255, 128, 128);
            btnFechar.Location = new Point(1480, 23);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 42);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 60F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(696, 48);
            label1.Name = "label1";
            label1.Size = new Size(258, 97);
            label1.TabIndex = 10;
            label1.Text = "Login";
            // 
            // btnEntrar12
            // 
            btnEntrar12.CheckButton = false;
            btnEntrar12.Checked = false;
            btnEntrar12.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnEntrar12.CheckedForeColor = Color.White;
            btnEntrar12.CheckedImageTint = Color.White;
            btnEntrar12.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnEntrar12.Content = "Entrar";
            btnEntrar12.DialogResult = DialogResult.None;
            btnEntrar12.Font = new Font("Verdana", 20F);
            btnEntrar12.ForeColor = Color.Black;
            btnEntrar12.HoverBackground = Color.Gray;
            btnEntrar12.HoverForeColor = Color.White;
            btnEntrar12.HoverImageTint = Color.White;
            btnEntrar12.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnEntrar12.Image = null;
            btnEntrar12.ImageAutoCenter = true;
            btnEntrar12.ImageExpand = new Point(0, 0);
            btnEntrar12.ImageOffset = new Point(0, 0);
            btnEntrar12.Location = new Point(685, 642);
            btnEntrar12.Name = "btnEntrar12";
            btnEntrar12.NormalBackground = Color.White;
            btnEntrar12.NormalForeColor = Color.Black;
            btnEntrar12.NormalImageTint = Color.White;
            btnEntrar12.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnEntrar12.OutlineThickness = 1F;
            btnEntrar12.PressedBackground = Color.WhiteSmoke;
            btnEntrar12.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnEntrar12.PressedImageTint = Color.White;
            btnEntrar12.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnEntrar12.Rounding = new Padding(8);
            btnEntrar12.Size = new Size(297, 94);
            btnEntrar12.TabIndex = 12;
            btnEntrar12.TextAlignment = StringAlignment.Center;
            btnEntrar12.TextOffset = new Point(0, 0);
            btnEntrar12.Click += btnEntrar_Click;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(0, -1);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.FromArgb(255, 106, 0);
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.FromArgb(255, 106, 0);
            cuiGradientPanel1.PanelOutlineColor2 = Color.FromArgb(255, 106, 0);
            cuiGradientPanel1.Rounding = new Padding(8);
            cuiGradientPanel1.Size = new Size(545, 901);
            cuiGradientPanel1.TabIndex = 13;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(cuiGradientPanel1);
            Controls.Add(btnEntrar12);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnFechar);
            Controls.Add(label3);
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
        private Label lblEmissor;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private CuoreUI.Controls.cuiButton btnEntrar12;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
    }
}
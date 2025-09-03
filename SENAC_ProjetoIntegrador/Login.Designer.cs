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
            btnFechar1 = new Button();
            label1 = new Label();
            btnEntrar12 = new CuoreUI.Controls.cuiButton();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            txtUsuario = new CuoreUI.Controls.cuiTextBox();
            txtSenha = new CuoreUI.Controls.cuiTextBox();
            SuspendLayout();
            // 
            // btnFechar1
            // 
            btnFechar1.BackColor = Color.Transparent;
            btnFechar1.FlatAppearance.BorderSize = 0;
            btnFechar1.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnFechar1.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar1.FlatStyle = FlatStyle.Flat;
            btnFechar1.Font = new Font("Segoe UI", 18F);
            btnFechar1.ForeColor = Color.Black;
            btnFechar1.Location = new Point(1462, 37);
            btnFechar1.Margin = new Padding(4);
            btnFechar1.Name = "btnFechar1";
            btnFechar1.Size = new Size(65, 43);
            btnFechar1.TabIndex = 1;
            btnFechar1.Text = "X";
            btnFechar1.UseVisualStyleBackColor = false;
            btnFechar1.Click += btnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Verdana", 60F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(663, 48);
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
            btnEntrar12.Location = new Point(652, 642);
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
            btnEntrar12.Rounding = new Padding(15);
            btnEntrar12.Size = new Size(297, 94);
            btnEntrar12.TabIndex = 12;
            btnEntrar12.TextAlignment = StringAlignment.Center;
            btnEntrar12.TextOffset = new Point(0, 0);
            btnEntrar12.Click += btnEntrar_Click;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.BackColor = Color.Transparent;
            cuiGradientPanel1.ForeColor = Color.Transparent;
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(0, -1);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(2);
            cuiGradientPanel1.Size = new Size(682, 901);
            cuiGradientPanel1.TabIndex = 13;
            // 
            // txtUsuario
            // 
            txtUsuario.BackgroundColor = Color.White;
            txtUsuario.Content = "Usuário";
            txtUsuario.FocusBackgroundColor = Color.White;
            txtUsuario.FocusImageTint = Color.White;
            txtUsuario.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtUsuario.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Image = null;
            txtUsuario.ImageExpand = new Point(0, 0);
            txtUsuario.ImageOffset = new Point(0, 0);
            txtUsuario.Location = new Point(586, 274);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.NormalImageTint = Color.White;
            txtUsuario.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtUsuario.Padding = new Padding(49, 16, 49, 0);
            txtUsuario.PasswordChar = false;
            txtUsuario.PlaceholderColor = SystemColors.WindowText;
            txtUsuario.PlaceholderText = "";
            txtUsuario.Rounding = new Padding(35);
            txtUsuario.Size = new Size(431, 80);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextOffset = new Size(0, 0);
            txtUsuario.UnderlinedStyle = true;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtSenha
            // 
            txtSenha.BackgroundColor = Color.White;
            txtSenha.Content = "Senha";
            txtSenha.FocusBackgroundColor = Color.White;
            txtSenha.FocusImageTint = Color.White;
            txtSenha.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtSenha.Font = new Font("Verdana", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.Gray;
            txtSenha.Image = null;
            txtSenha.ImageExpand = new Point(0, 0);
            txtSenha.ImageOffset = new Point(0, 0);
            txtSenha.Location = new Point(586, 435);
            txtSenha.Margin = new Padding(4);
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.NormalImageTint = Color.White;
            txtSenha.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtSenha.Padding = new Padding(49, 16, 49, 0);
            txtSenha.PasswordChar = false;
            txtSenha.PlaceholderColor = SystemColors.WindowText;
            txtSenha.PlaceholderText = "";
            txtSenha.Rounding = new Padding(35);
            txtSenha.Size = new Size(431, 80);
            txtSenha.TabIndex = 1;
            txtSenha.TextOffset = new Size(0, 0);
            txtSenha.UnderlinedStyle = true;
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnEntrar12);
            Controls.Add(label1);
            Controls.Add(btnFechar1);
            Controls.Add(cuiGradientPanel1);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFechar1;
        private Label label1;
        private CuoreUI.Controls.cuiButton btnEntrar12;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private CuoreUI.Controls.cuiTextBox txtUsuario;
        private CuoreUI.Controls.cuiTextBox txtSenha;
    }
}
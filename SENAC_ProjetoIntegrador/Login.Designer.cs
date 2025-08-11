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
            txtResponsavel = new TextBox();
            txtEmissor = new TextBox();
            groupBox1 = new GroupBox();
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
            // txtResponsavel
            // 
            txtResponsavel.Location = new Point(30, 120);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(240, 23);
            txtResponsavel.TabIndex = 2;
            // 
            // txtEmissor
            // 
            txtEmissor.Location = new Point(30, 60);
            txtEmissor.Name = "txtEmissor";
            txtEmissor.Size = new Size(240, 23);
            txtEmissor.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmissor);
            groupBox1.Controls.Add(lblResponsavel);
            groupBox1.Controls.Add(txtResponsavel);
            groupBox1.Controls.Add(lblEmissor);
            groupBox1.Location = new Point(110, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 170);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
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
        private TextBox txtResponsavel;
        private TextBox txtEmissor;
        private GroupBox groupBox1;
    }
}
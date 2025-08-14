namespace SENAC_ProjetoIntegrador
{
    partial class Menu
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
            btnFechar = new Button();
            lblMenuPrincipal = new Label();
            btnOrdemServico = new Button();
            btnPessoa = new Button();
            btnEquipamento = new Button();
            btnPecaItem = new Button();
            btnServico = new Button();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(760, 10);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(30, 30);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblMenuPrincipal
            // 
            lblMenuPrincipal.AutoSize = true;
            lblMenuPrincipal.Location = new Point(330, 20);
            lblMenuPrincipal.Name = "lblMenuPrincipal";
            lblMenuPrincipal.Size = new Size(87, 15);
            lblMenuPrincipal.TabIndex = 6;
            lblMenuPrincipal.Text = "Menu Principal";
            // 
            // btnOrdemServico
            // 
            btnOrdemServico.Location = new Point(10, 90);
            btnOrdemServico.Name = "btnOrdemServico";
            btnOrdemServico.Size = new Size(200, 70);
            btnOrdemServico.TabIndex = 7;
            btnOrdemServico.Text = "Ordem de Serviço";
            btnOrdemServico.UseVisualStyleBackColor = true;
            // 
            // btnPessoa
            // 
            btnPessoa.Location = new Point(10, 160);
            btnPessoa.Name = "btnPessoa";
            btnPessoa.Size = new Size(200, 70);
            btnPessoa.TabIndex = 7;
            btnPessoa.Text = "Pessoa";
            btnPessoa.UseVisualStyleBackColor = true;
            // 
            // btnEquipamento
            // 
            btnEquipamento.Location = new Point(10, 230);
            btnEquipamento.Name = "btnEquipamento";
            btnEquipamento.Size = new Size(200, 70);
            btnEquipamento.TabIndex = 7;
            btnEquipamento.Text = "Equipamento";
            btnEquipamento.UseVisualStyleBackColor = true;
            // 
            // btnPecaItem
            // 
            btnPecaItem.Location = new Point(10, 300);
            btnPecaItem.Name = "btnPecaItem";
            btnPecaItem.Size = new Size(200, 70);
            btnPecaItem.TabIndex = 7;
            btnPecaItem.Text = "PecaItem";
            btnPecaItem.UseVisualStyleBackColor = true;
            // 
            // btnServico
            // 
            btnServico.Location = new Point(10, 370);
            btnServico.Name = "btnServico";
            btnServico.Size = new Size(200, 70);
            btnServico.TabIndex = 7;
            btnServico.Text = "Serviço";
            btnServico.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnServico);
            Controls.Add(btnPecaItem);
            Controls.Add(btnEquipamento);
            Controls.Add(btnPessoa);
            Controls.Add(btnOrdemServico);
            Controls.Add(lblMenuPrincipal);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private Label lblMenuPrincipal;
        private Button btnOrdemServico;
        private Button btnPessoa;
        private Button btnEquipamento;
        private Button btnPecaItem;
        private Button btnServico;
    }
}

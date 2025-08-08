namespace SENAC_ProjetoIntegrador
{
    partial class EquipamentoManutencao
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
            lblTelaDeManutencao = new Label();
            groupBox1 = new GroupBox();
            btnNomeUsuarioLogado = new Button();
            btnSalvar = new Button();
            btnRemover = new Button();
            txtPesquisar = new TextBox();
            btnIncluir = new Button();
            lblPesquisar = new Label();
            dataGridView1 = new DataGridView();
            lblManutencaoDeMenu = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTelaDeManutencao
            // 
            lblTelaDeManutencao.AutoSize = true;
            lblTelaDeManutencao.Location = new Point(460, 11);
            lblTelaDeManutencao.Name = "lblTelaDeManutencao";
            lblTelaDeManutencao.Size = new Size(204, 25);
            lblTelaDeManutencao.TabIndex = 0;
            lblTelaDeManutencao.Text = "TELA DE MANUTENÇÃO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNomeUsuarioLogado);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(txtPesquisar);
            groupBox1.Controls.Add(btnIncluir);
            groupBox1.Controls.Add(lblPesquisar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(lblManutencaoDeMenu);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1083, 615);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnNomeUsuarioLogado
            // 
            btnNomeUsuarioLogado.Location = new Point(21, 540);
            btnNomeUsuarioLogado.Name = "btnNomeUsuarioLogado";
            btnNomeUsuarioLogado.Size = new Size(256, 51);
            btnNomeUsuarioLogado.TabIndex = 7;
            btnNomeUsuarioLogado.Text = "Nome do Usuário Logado";
            btnNomeUsuarioLogado.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(920, 540);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(145, 51);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(768, 540);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(145, 51);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(21, 125);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(482, 31);
            txtPesquisar.TabIndex = 4;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(21, 168);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(112, 34);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(21, 95);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(86, 25);
            lblPesquisar.TabIndex = 2;
            lblPesquisar.Text = "Pesquisar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1044, 294);
            dataGridView1.TabIndex = 1;
            // 
            // lblManutencaoDeMenu
            // 
            lblManutencaoDeMenu.AutoSize = true;
            lblManutencaoDeMenu.Location = new Point(448, 49);
            lblManutencaoDeMenu.Name = "lblManutencaoDeMenu";
            lblManutencaoDeMenu.Size = new Size(195, 25);
            lblManutencaoDeMenu.TabIndex = 0;
            lblManutencaoDeMenu.Text = "Manutenção de [menu]";
            // 
            // EquipamentoManutencao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 676);
            Controls.Add(groupBox1);
            Controls.Add(lblTelaDeManutencao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EquipamentoManutencao";
            Text = "EquipamentoManutencao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTelaDeManutencao;
        private GroupBox groupBox1;
        private Label lblManutencaoDeMenu;
        private Button btnNomeUsuarioLogado;
        private Button btnSalvar;
        private Button btnRemover;
        private TextBox txtPesquisar;
        private Button btnIncluir;
        private Label lblPesquisar;
        private DataGridView dataGridView1;
    }
}
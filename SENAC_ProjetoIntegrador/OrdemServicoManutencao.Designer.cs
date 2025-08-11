namespace SENAC_ProjetoIntegrador
{
    partial class OrdemServicoManutencao
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
            groupBox1 = new GroupBox();
            btnNomeUsuarioLogado = new Button();
            btnSalvar = new Button();
            btnRemover = new Button();
            txtPesquisar = new TextBox();
            btnIncluir = new Button();
            lblPesquisar = new Label();
            dataGridView1 = new DataGridView();
            lblManutencaoOS = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            groupBox1.Location = new Point(20, 40);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(758, 369);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnNomeUsuarioLogado
            // 
            btnNomeUsuarioLogado.Location = new Point(15, 324);
            btnNomeUsuarioLogado.Margin = new Padding(2);
            btnNomeUsuarioLogado.Name = "btnNomeUsuarioLogado";
            btnNomeUsuarioLogado.Size = new Size(179, 31);
            btnNomeUsuarioLogado.TabIndex = 7;
            btnNomeUsuarioLogado.Text = "Nome do Usuário Logado";
            btnNomeUsuarioLogado.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(644, 324);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(102, 31);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(538, 324);
            btnRemover.Margin = new Padding(2);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(102, 31);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(15, 75);
            txtPesquisar.Margin = new Padding(2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(339, 23);
            txtPesquisar.TabIndex = 4;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(15, 101);
            btnIncluir.Margin = new Padding(2);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(78, 20);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(14, 56);
            lblPesquisar.Margin = new Padding(2, 0, 2, 0);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 2;
            lblPesquisar.Text = "Pesquisar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 134);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(731, 176);
            dataGridView1.TabIndex = 1;
            // 
            // lblManutencaoOS
            // 
            lblManutencaoOS.AutoSize = true;
            lblManutencaoOS.Location = new Point(310, 20);
            lblManutencaoOS.Margin = new Padding(2, 0, 2, 0);
            lblManutencaoOS.Name = "lblManutencaoOS";
            lblManutencaoOS.Size = new Size(187, 15);
            lblManutencaoOS.TabIndex = 2;
            lblManutencaoOS.Text = "Manutenção de Ordem de Serviço";
            // 
            // OrdemServicoManutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(lblManutencaoOS);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrdemServicoManutencao";
            Text = "OrdemServicoManutencao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnNomeUsuarioLogado;
        private Button btnSalvar;
        private Button btnRemover;
        private TextBox txtPesquisar;
        private Button btnIncluir;
        private Label lblPesquisar;
        private DataGridView dataGridView1;
        private Label lblManutencaoOS;
    }
}
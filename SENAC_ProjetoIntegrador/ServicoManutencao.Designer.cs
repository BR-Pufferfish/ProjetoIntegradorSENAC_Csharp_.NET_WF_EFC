namespace SENAC_ProjetoIntegrador
{
    partial class ServicoManutencao
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
            lblManutencaoServico = new Label();
            btnFechar = new Button();
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
            groupBox1.Location = new Point(30, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1083, 615);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnNomeUsuarioLogado
            // 
            btnNomeUsuarioLogado.Location = new Point(21, 540);
            btnNomeUsuarioLogado.Name = "btnNomeUsuarioLogado";
            btnNomeUsuarioLogado.Size = new Size(256, 52);
            btnNomeUsuarioLogado.TabIndex = 7;
            btnNomeUsuarioLogado.Text = "Nome do Usuário Logado";
            btnNomeUsuarioLogado.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(920, 540);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(146, 52);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(769, 540);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(146, 52);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(21, 125);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(483, 31);
            txtPesquisar.TabIndex = 4;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(21, 168);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(111, 33);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(19, 92);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(86, 25);
            lblPesquisar.TabIndex = 2;
            lblPesquisar.Text = "Pesquisar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1044, 293);
            dataGridView1.TabIndex = 1;
            // 
            // lblManutencaoServico
            // 
            lblManutencaoServico.AutoSize = true;
            lblManutencaoServico.Location = new Point(471, 50);
            lblManutencaoServico.Name = "lblManutencaoServico";
            lblManutencaoServico.Size = new Size(197, 25);
            lblManutencaoServico.TabIndex = 4;
            lblManutencaoServico.Text = "Manutenção de Serviço";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1081, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(50, 34);
            btnFechar.TabIndex = 42;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // ServicoManutencao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(lblManutencaoServico);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ServicoManutencao";
            Text = "ServicoManutencao";
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
        private Label lblManutencaoServico;
        private Button btnFechar;
    }
}
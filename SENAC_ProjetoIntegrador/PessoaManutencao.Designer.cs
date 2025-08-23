namespace SENAC_ProjetoIntegrador
{
    partial class PessoaManutencao
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
            btnEditar = new Button();
            btnRemover = new Button();
            txtPesquisar = new TextBox();
            btnIncluir = new Button();
            lblPesquisar = new Label();
            dataGridView1 = new DataGridView();
            lblTitulo = new Label();
            btnFechar = new Button();
            lblTelaDeManutencao = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNomeUsuarioLogado);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(txtPesquisar);
            groupBox1.Controls.Add(btnIncluir);
            groupBox1.Controls.Add(lblPesquisar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(lblTitulo);
            groupBox1.Location = new Point(20, 107);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(1517, 945);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnNomeUsuarioLogado
            // 
            btnNomeUsuarioLogado.Location = new Point(28, 681);
            btnNomeUsuarioLogado.Margin = new Padding(4, 4, 4, 4);
            btnNomeUsuarioLogado.Name = "btnNomeUsuarioLogado";
            btnNomeUsuarioLogado.Size = new Size(332, 66);
            btnNomeUsuarioLogado.TabIndex = 7;
            btnNomeUsuarioLogado.Text = "Nome do Usuário Logado";
            btnNomeUsuarioLogado.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(1309, 681);
            btnEditar.Margin = new Padding(4, 4, 4, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(189, 66);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(1112, 681);
            btnRemover.Margin = new Padding(4, 4, 4, 4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(189, 66);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(28, 179);
            txtPesquisar.Margin = new Padding(4, 4, 4, 4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(626, 39);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(28, 252);
            btnIncluir.Margin = new Padding(4, 4, 4, 4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(145, 43);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(26, 119);
            lblPesquisar.Margin = new Padding(4, 0, 4, 0);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(113, 32);
            lblPesquisar.TabIndex = 2;
            lblPesquisar.Text = "Pesquisar";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 343);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1470, 316);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(581, 60);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Manutenção de Pessoa";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1472, 13);
            btnFechar.Margin = new Padding(4, 4, 4, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 43);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblTelaDeManutencao
            // 
            lblTelaDeManutencao.AutoSize = true;
            lblTelaDeManutencao.Font = new Font("Segoe UI", 30F);
            lblTelaDeManutencao.Location = new Point(674, 26);
            lblTelaDeManutencao.Margin = new Padding(4, 0, 4, 0);
            lblTelaDeManutencao.Name = "lblTelaDeManutencao";
            lblTelaDeManutencao.Size = new Size(142, 54);
            lblTelaDeManutencao.TabIndex = 3;
            lblTelaDeManutencao.Text = "Pessoa";
            // 
            // PessoaManutencao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1550, 900);
            Controls.Add(btnFechar);
            Controls.Add(lblTelaDeManutencao);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "PessoaManutencao";
            Text = "PessoaManutencao";
            Load += PessoaManutencao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnNomeUsuarioLogado;
        private Button btnEditar;
        private Button btnRemover;
        private TextBox txtPesquisar;
        private Button btnIncluir;
        private Label lblPesquisar;
        private DataGridView dataGridView1;
        private Label lblTitulo;
        private Button btnFechar;
        private Label lblTelaDeManutencao;
    }
}
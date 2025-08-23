namespace SENAC_ProjetoIntegrador
{
    partial class VendaManutencao
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
            btnFechar = new Button();
            lblTelaDeManutencao = new Label();
            groupBox1 = new GroupBox();
            btnNomeUsuarioLogado = new Button();
            btnEditar = new Button();
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
            // btnFechar
            // 
            btnFechar.Location = new Point(734, 9);
            btnFechar.Margin = new Padding(2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(35, 20);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblTelaDeManutencao
            // 
            lblTelaDeManutencao.AutoSize = true;
            lblTelaDeManutencao.Location = new Point(335, 9);
            lblTelaDeManutencao.Margin = new Padding(2, 0, 2, 0);
            lblTelaDeManutencao.Name = "lblTelaDeManutencao";
            lblTelaDeManutencao.Size = new Size(135, 15);
            lblTelaDeManutencao.TabIndex = 3;
            lblTelaDeManutencao.Text = "TELA DE MANUTENÇÃO";
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
            groupBox1.Controls.Add(lblManutencaoDeMenu);
            groupBox1.Location = new Point(11, 33);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(758, 443);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnNomeUsuarioLogado
            // 
            btnNomeUsuarioLogado.Location = new Point(15, 397);
            btnNomeUsuarioLogado.Margin = new Padding(2);
            btnNomeUsuarioLogado.Name = "btnNomeUsuarioLogado";
            btnNomeUsuarioLogado.Size = new Size(179, 31);
            btnNomeUsuarioLogado.TabIndex = 7;
            btnNomeUsuarioLogado.Text = "Nome do Usuário Logado";
            btnNomeUsuarioLogado.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(644, 397);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 31);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(538, 398);
            btnRemover.Margin = new Padding(2);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(102, 31);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(15, 84);
            txtPesquisar.Margin = new Padding(2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(339, 23);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(15, 118);
            btnIncluir.Margin = new Padding(2);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(78, 20);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 161);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(731, 203);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblManutencaoDeMenu
            // 
            lblManutencaoDeMenu.AutoSize = true;
            lblManutencaoDeMenu.Location = new Point(313, 28);
            lblManutencaoDeMenu.Margin = new Padding(2, 0, 2, 0);
            lblManutencaoDeMenu.Name = "lblManutencaoDeMenu";
            lblManutencaoDeMenu.Size = new Size(132, 15);
            lblManutencaoDeMenu.TabIndex = 0;
            lblManutencaoDeMenu.Text = "Manutenção de [menu]";
            // 
            // VendaManutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 488);
            Controls.Add(groupBox1);
            Controls.Add(btnFechar);
            Controls.Add(lblTelaDeManutencao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VendaManutencao";
            Text = "VendaManutencao";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private Label lblTelaDeManutencao;
        private GroupBox groupBox1;
        private Button btnNomeUsuarioLogado;
        private Button btnEditar;
        private Button btnRemover;
        private TextBox txtPesquisar;
        private Button btnIncluir;
        private Label lblPesquisar;
        private DataGridView dataGridView1;
        private Label lblManutencaoDeMenu;
    }
}
namespace SENAC_ProjetoIntegrador
{
    partial class PecaItemManutencao
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
            PecaItem = new GroupBox();
            btnIncluir = new Button();
            btnEditar = new Button();
            BtnRemover = new Button();
            BtnUsuarioLogado = new Button();
            dataGridView1 = new DataGridView();
            txtPesquisar = new TextBox();
            Pesquisar = new Label();
            txtManutencaoPecas = new TextBox();
            btnFechar = new Button();
            PecaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PecaItem
            // 
            PecaItem.Controls.Add(btnIncluir);
            PecaItem.Controls.Add(btnEditar);
            PecaItem.Controls.Add(BtnRemover);
            PecaItem.Controls.Add(BtnUsuarioLogado);
            PecaItem.Controls.Add(dataGridView1);
            PecaItem.Controls.Add(txtPesquisar);
            PecaItem.Controls.Add(Pesquisar);
            PecaItem.Location = new Point(8, 65);
            PecaItem.Margin = new Padding(2, 2, 2, 2);
            PecaItem.Name = "PecaItem";
            PecaItem.Padding = new Padding(2, 2, 2, 2);
            PecaItem.Size = new Size(755, 394);
            PecaItem.TabIndex = 0;
            PecaItem.TabStop = false;
            // 
            // btnIncluir
            // 
            btnIncluir.Font = new Font("Segoe UI", 12F);
            btnIncluir.Location = new Point(20, 80);
            btnIncluir.Margin = new Padding(2, 2, 2, 2);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(102, 31);
            btnIncluir.TabIndex = 5;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.Location = new Point(630, 349);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 31);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // BtnRemover
            // 
            BtnRemover.Font = new Font("Segoe UI", 12F);
            BtnRemover.Location = new Point(524, 349);
            BtnRemover.Margin = new Padding(2, 2, 2, 2);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(102, 31);
            BtnRemover.TabIndex = 5;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = true;
            // 
            // BtnUsuarioLogado
            // 
            BtnUsuarioLogado.Font = new Font("Segoe UI", 12F);
            BtnUsuarioLogado.Location = new Point(24, 349);
            BtnUsuarioLogado.Margin = new Padding(2, 2, 2, 2);
            BtnUsuarioLogado.Name = "BtnUsuarioLogado";
            BtnUsuarioLogado.Size = new Size(178, 28);
            BtnUsuarioLogado.TabIndex = 4;
            BtnUsuarioLogado.Text = "Usuario Logado";
            BtnUsuarioLogado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 126);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(731, 184);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtPesquisar
            // 
            txtPesquisar.AcceptsReturn = true;
            txtPesquisar.BackColor = SystemColors.Window;
            txtPesquisar.Location = new Point(20, 55);
            txtPesquisar.Margin = new Padding(2, 2, 2, 2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(323, 23);
            txtPesquisar.TabIndex = 1;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // Pesquisar
            // 
            Pesquisar.AutoSize = true;
            Pesquisar.Font = new Font("Segoe UI", 12F);
            Pesquisar.Location = new Point(20, 30);
            Pesquisar.Margin = new Padding(2, 0, 2, 0);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(79, 21);
            Pesquisar.TabIndex = 0;
            Pesquisar.Text = "Pesquisar:";
            // 
            // txtManutencaoPecas
            // 
            txtManutencaoPecas.BorderStyle = BorderStyle.None;
            txtManutencaoPecas.Font = new Font("Segoe UI", 22F);
            txtManutencaoPecas.Location = new Point(174, 20);
            txtManutencaoPecas.Margin = new Padding(2, 2, 2, 2);
            txtManutencaoPecas.Name = "textBox1";
            txtManutencaoPecas.Size = new Size(453, 40);
            txtManutencaoPecas.TabIndex = 1;
            txtManutencaoPecas.Text = "Manutencao De Pecas";
            txtManutencaoPecas.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(728, 5);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(35, 20);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // PecaItemManutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(777, 504);
            Controls.Add(btnFechar);
            Controls.Add(txtManutencaoPecas);
            Controls.Add(PecaItem);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "PecaItemManutencao";
            Text = "PecaItemManutencao";
            Load += PecaItemManutencao_Load;
            PecaItem.ResumeLayout(false);
            PecaItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox PecaItem;
        private TextBox txtManutencaoPecas;
        private TextBox txtPesquisar;
        private Label Pesquisar;
        private Button btnEditar;
        private Button BtnRemover;
        private Button BtnUsuarioLogado;
        private DataGridView dataGridView1;
        private Button btnFechar;
        private Button btnIncluir;
    }
}
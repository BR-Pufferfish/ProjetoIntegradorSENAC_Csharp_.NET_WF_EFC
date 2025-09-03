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
            PecaItem.Controls.Add(dataGridView1);
            PecaItem.Controls.Add(txtPesquisar);
            PecaItem.Controls.Add(Pesquisar);
            PecaItem.Font = new Font("Segoe UI", 18F);
            PecaItem.Location = new Point(8, 81);
            PecaItem.Margin = new Padding(2);
            PecaItem.Name = "PecaItem";
            PecaItem.Padding = new Padding(2);
            PecaItem.Size = new Size(1517, 772);
            PecaItem.TabIndex = 0;
            PecaItem.TabStop = false;
            // 
            // btnIncluir
            // 
            btnIncluir.Font = new Font("Segoe UI", 18F);
            btnIncluir.Location = new Point(20, 186);
            btnIncluir.Margin = new Padding(2);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(140, 50);
            btnIncluir.TabIndex = 5;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 18F);
            btnEditar.Location = new Point(1359, 719);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 50);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // BtnRemover
            // 
            BtnRemover.Font = new Font("Segoe UI", 18F);
            BtnRemover.Location = new Point(1202, 719);
            BtnRemover.Margin = new Padding(2);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(140, 50);
            BtnRemover.TabIndex = 5;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 300);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1479, 374);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtPesquisar
            // 
            txtPesquisar.AcceptsReturn = true;
            txtPesquisar.BackColor = SystemColors.Window;
            txtPesquisar.Location = new Point(20, 98);
            txtPesquisar.Margin = new Padding(2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(323, 39);
            txtPesquisar.TabIndex = 1;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // Pesquisar
            // 
            Pesquisar.AutoSize = true;
            Pesquisar.Font = new Font("Segoe UI", 18F);
            Pesquisar.Location = new Point(20, 30);
            Pesquisar.Margin = new Padding(2, 0, 2, 0);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(118, 32);
            Pesquisar.TabIndex = 0;
            Pesquisar.Text = "Pesquisar:";
            // 
            // txtManutencaoPecas
            // 
            txtManutencaoPecas.BorderStyle = BorderStyle.None;
            txtManutencaoPecas.Font = new Font("Segoe UI", 30F);
            txtManutencaoPecas.Location = new Point(532, 23);
            txtManutencaoPecas.Margin = new Padding(2);
            txtManutencaoPecas.Name = "txtManutencaoPecas";
            txtManutencaoPecas.Size = new Size(453, 54);
            txtManutencaoPecas.TabIndex = 1;
            txtManutencaoPecas.Text = "Manutencao De Pecas";
            txtManutencaoPecas.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1475, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(50, 34);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // PecaItemManutencao
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1550, 900);
            Controls.Add(btnFechar);
            Controls.Add(txtManutencaoPecas);
            Controls.Add(PecaItem);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
        private DataGridView dataGridView1;
        private Button btnFechar;
        private Button btnIncluir;
    }
}
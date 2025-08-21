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
            textBox1 = new TextBox();
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
            PecaItem.Location = new Point(11, 108);
            PecaItem.Name = "PecaItem";
            PecaItem.Size = new Size(1079, 657);
            PecaItem.TabIndex = 0;
            PecaItem.TabStop = false;
            // 
            // btnIncluir
            // 
            btnIncluir.Font = new Font("Segoe UI", 12F);
            btnIncluir.Location = new Point(29, 133);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(146, 52);
            btnIncluir.TabIndex = 5;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.Location = new Point(900, 581);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(146, 52);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // BtnRemover
            // 
            BtnRemover.Font = new Font("Segoe UI", 12F);
            BtnRemover.Location = new Point(748, 581);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(146, 52);
            BtnRemover.TabIndex = 5;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = true;
            // 
            // BtnUsuarioLogado
            // 
            BtnUsuarioLogado.Font = new Font("Segoe UI", 12F);
            BtnUsuarioLogado.Location = new Point(34, 581);
            BtnUsuarioLogado.Name = "BtnUsuarioLogado";
            BtnUsuarioLogado.Size = new Size(254, 47);
            BtnUsuarioLogado.TabIndex = 4;
            BtnUsuarioLogado.Text = "Usuario Logado";
            BtnUsuarioLogado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1044, 307);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtPesquisar
            // 
            txtPesquisar.AcceptsReturn = true;
            txtPesquisar.BackColor = SystemColors.Window;
            txtPesquisar.Location = new Point(29, 91);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(460, 31);
            txtPesquisar.TabIndex = 1;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // Pesquisar
            // 
            Pesquisar.AutoSize = true;
            Pesquisar.Font = new Font("Segoe UI", 12F);
            Pesquisar.Location = new Point(29, 50);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(118, 32);
            Pesquisar.TabIndex = 0;
            Pesquisar.Text = "Pesquisar:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 22F);
            textBox1.Location = new Point(248, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(647, 59);
            textBox1.TabIndex = 1;
            textBox1.Text = "Manutencao De Pecas";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1040, 8);
            btnFechar.Margin = new Padding(4, 5, 4, 5);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(50, 34);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // PecaItemManutencao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1110, 840);
            Controls.Add(btnFechar);
            Controls.Add(textBox1);
            Controls.Add(PecaItem);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox textBox1;
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
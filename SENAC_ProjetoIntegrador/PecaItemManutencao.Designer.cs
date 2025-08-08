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
            textBox1 = new TextBox();
            Pesquisar = new Label();
            TxtPesquisarPecas = new TextBox();
            Incluir = new ComboBox();
            dataGridView1 = new DataGridView();
            BtnUsuarioLogado = new Button();
            BtnRemover = new Button();
            BtnSalvar = new Button();
            PecaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PecaItem
            // 
            PecaItem.Controls.Add(BtnSalvar);
            PecaItem.Controls.Add(BtnRemover);
            PecaItem.Controls.Add(BtnUsuarioLogado);
            PecaItem.Controls.Add(dataGridView1);
            PecaItem.Controls.Add(Incluir);
            PecaItem.Controls.Add(TxtPesquisarPecas);
            PecaItem.Controls.Add(Pesquisar);
            PecaItem.Location = new Point(12, 59);
            PecaItem.Name = "PecaItem";
            PecaItem.Size = new Size(976, 447);
            PecaItem.TabIndex = 0;
            PecaItem.TabStop = false;
            PecaItem.Text = "groupBox1";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(121, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(647, 24);
            textBox1.TabIndex = 1;
            textBox1.Text = "Manutencao De Pecas";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Pesquisar
            // 
            Pesquisar.AutoSize = true;
            Pesquisar.Location = new Point(24, 36);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(90, 25);
            Pesquisar.TabIndex = 0;
            Pesquisar.Text = "Pesquisar:";
            // 
            // TxtPesquisarPecas
            // 
            TxtPesquisarPecas.AcceptsReturn = true;
            TxtPesquisarPecas.BackColor = SystemColors.HotTrack;
            TxtPesquisarPecas.Location = new Point(24, 64);
            TxtPesquisarPecas.Name = "TxtPesquisarPecas";
            TxtPesquisarPecas.Size = new Size(460, 31);
            TxtPesquisarPecas.TabIndex = 1;
            // 
            // Incluir
            // 
            Incluir.Font = new Font("Segoe UI", 14F);
            Incluir.FormattingEnabled = true;
            Incluir.Items.AddRange(new object[] { "Itens" });
            Incluir.Location = new Point(24, 131);
            Incluir.Name = "Incluir";
            Incluir.Size = new Size(182, 46);
            Incluir.TabIndex = 2;
            Incluir.Text = "Incluir";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(922, 180);
            dataGridView1.TabIndex = 3;
            // 
            // BtnUsuarioLogado
            // 
            BtnUsuarioLogado.Font = new Font("Segoe UI", 12F);
            BtnUsuarioLogado.Location = new Point(34, 378);
            BtnUsuarioLogado.Name = "BtnUsuarioLogado";
            BtnUsuarioLogado.Size = new Size(254, 47);
            BtnUsuarioLogado.TabIndex = 4;
            BtnUsuarioLogado.Text = "Usuario Logado";
            BtnUsuarioLogado.UseVisualStyleBackColor = true;
            // 
            // BtnRemover
            // 
            BtnRemover.Location = new Point(660, 384);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(112, 34);
            BtnRemover.TabIndex = 5;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(778, 384);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(112, 34);
            BtnSalvar.TabIndex = 5;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // PecaItemManutencao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 518);
            Controls.Add(textBox1);
            Controls.Add(PecaItem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PecaItemManutencao";
            Text = "PecaItemManutencao";
            PecaItem.ResumeLayout(false);
            PecaItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox PecaItem;
        private TextBox textBox1;
        private ComboBox Incluir;
        private TextBox TxtPesquisarPecas;
        private Label Pesquisar;
        private Button BtnSalvar;
        private Button BtnRemover;
        private Button BtnUsuarioLogado;
        private DataGridView dataGridView1;
    }
}
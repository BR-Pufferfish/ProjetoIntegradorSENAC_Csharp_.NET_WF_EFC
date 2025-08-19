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
            BtnSalvar = new Button();
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
            PecaItem.Controls.Add(BtnSalvar);
            PecaItem.Controls.Add(BtnRemover);
            PecaItem.Controls.Add(BtnUsuarioLogado);
            PecaItem.Controls.Add(dataGridView1);
            PecaItem.Controls.Add(txtPesquisar);
            PecaItem.Controls.Add(Pesquisar);
            PecaItem.Location = new Point(8, 35);
            PecaItem.Margin = new Padding(2);
            PecaItem.Name = "PecaItem";
            PecaItem.Padding = new Padding(2);
            PecaItem.Size = new Size(683, 268);
            PecaItem.TabIndex = 0;
            PecaItem.TabStop = false;
            PecaItem.Text = "groupBox1";
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(20, 70);
            btnIncluir.Margin = new Padding(2);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(90, 30);
            btnIncluir.TabIndex = 5;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(545, 230);
            BtnSalvar.Margin = new Padding(2);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(78, 20);
            BtnSalvar.TabIndex = 5;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnRemover
            // 
            BtnRemover.Location = new Point(462, 230);
            BtnRemover.Margin = new Padding(2);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(78, 20);
            BtnRemover.TabIndex = 5;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = true;
            // 
            // BtnUsuarioLogado
            // 
            BtnUsuarioLogado.Font = new Font("Segoe UI", 12F);
            BtnUsuarioLogado.Location = new Point(24, 227);
            BtnUsuarioLogado.Margin = new Padding(2);
            BtnUsuarioLogado.Name = "BtnUsuarioLogado";
            BtnUsuarioLogado.Size = new Size(178, 28);
            BtnUsuarioLogado.TabIndex = 4;
            BtnUsuarioLogado.Text = "Usuario Logado";
            BtnUsuarioLogado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 110);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(645, 108);
            dataGridView1.TabIndex = 3;
            // 
            // txtPesquisar
            // 
            txtPesquisar.AcceptsReturn = true;
            txtPesquisar.BackColor = SystemColors.Window;
            txtPesquisar.Location = new Point(17, 38);
            txtPesquisar.Margin = new Padding(2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(323, 23);
            txtPesquisar.TabIndex = 1;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // Pesquisar
            // 
            Pesquisar.AutoSize = true;
            Pesquisar.Location = new Point(17, 22);
            Pesquisar.Margin = new Padding(2, 0, 2, 0);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(60, 15);
            Pesquisar.TabIndex = 0;
            Pesquisar.Text = "Pesquisar:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(85, 15);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(453, 16);
            textBox1.TabIndex = 1;
            textBox1.Text = "Manutencao De Pecas";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(668, 5);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(30, 30);
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
            ClientSize = new Size(710, 311);
            Controls.Add(btnFechar);
            Controls.Add(textBox1);
            Controls.Add(PecaItem);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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
        private TextBox txtPesquisar;
        private Label Pesquisar;
        private Button BtnSalvar;
        private Button BtnRemover;
        private Button BtnUsuarioLogado;
        private DataGridView dataGridView1;
        private Button btnFechar;
        private Button btnIncluir;
    }
}
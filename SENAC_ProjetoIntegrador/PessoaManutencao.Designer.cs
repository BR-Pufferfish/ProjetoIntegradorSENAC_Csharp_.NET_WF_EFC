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
            btnEditar = new Button();
            btnRemover = new Button();
            txtPesquisar = new TextBox();
            btnIncluir = new Button();
            lblPesquisar = new Label();
            dataGridView1 = new DataGridView();
            btnFechar = new Button();
            lblTelaDeManutencao = new Label();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            cuiGradientPanel2 = new CuoreUI.Controls.cuiGradientPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cuiGradientPanel1.SuspendLayout();
            cuiGradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 128);
            btnEditar.Enabled = false;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(1325, 764);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(189, 66);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(255, 128, 128);
            btnRemover.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Location = new Point(1120, 764);
            btnRemover.Margin = new Padding(4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(189, 66);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(30, 90);
            txtPesquisar.Margin = new Padding(4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(626, 39);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.FromArgb(128, 255, 128);
            btnIncluir.Location = new Point(670, 90);
            btnIncluir.Margin = new Padding(4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(150, 40);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.Transparent;
            lblPesquisar.Location = new Point(38, 41);
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 392);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1470, 316);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(1462, 37);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 43);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblTelaDeManutencao
            // 
            lblTelaDeManutencao.AutoSize = true;
            lblTelaDeManutencao.BackColor = Color.Transparent;
            lblTelaDeManutencao.Font = new Font("Segoe UI", 40F);
            lblTelaDeManutencao.Location = new Point(560, 100);
            lblTelaDeManutencao.Margin = new Padding(4, 0, 4, 0);
            lblTelaDeManutencao.Name = "lblTelaDeManutencao";
            lblTelaDeManutencao.Size = new Size(579, 72);
            lblTelaDeManutencao.TabIndex = 3;
            lblTelaDeManutencao.Text = "Manutenção de Pessoa";
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(lblTelaDeManutencao);
            cuiGradientPanel1.Controls.Add(cuiGradientPanel2);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-10, -10);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(8);
            cuiGradientPanel1.Size = new Size(1530, 920);
            cuiGradientPanel1.TabIndex = 7;
            // 
            // cuiGradientPanel2
            // 
            cuiGradientPanel2.Controls.Add(lblPesquisar);
            cuiGradientPanel2.Controls.Add(btnIncluir);
            cuiGradientPanel2.Controls.Add(txtPesquisar);
            cuiGradientPanel2.GradientAngle = 0F;
            cuiGradientPanel2.Location = new Point(32, 249);
            cuiGradientPanel2.Name = "cuiGradientPanel2";
            cuiGradientPanel2.OutlineThickness = 1F;
            cuiGradientPanel2.PanelColor1 = Color.White;
            cuiGradientPanel2.PanelColor2 = Color.White;
            cuiGradientPanel2.PanelOutlineColor1 = Color.White;
            cuiGradientPanel2.PanelOutlineColor2 = Color.White;
            cuiGradientPanel2.Rounding = new Padding(8);
            cuiGradientPanel2.Size = new Size(1496, 501);
            cuiGradientPanel2.TabIndex = 3;
            // 
            // PessoaManutencao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(btnEditar);
            Controls.Add(btnFechar);
            Controls.Add(btnRemover);
            Controls.Add(dataGridView1);
            Controls.Add(cuiGradientPanel1);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "PessoaManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PessoaManutencao";
            Load += PessoaManutencao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cuiGradientPanel1.ResumeLayout(false);
            cuiGradientPanel1.PerformLayout();
            cuiGradientPanel2.ResumeLayout(false);
            cuiGradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEditar;
        private Button btnRemover;
        private TextBox txtPesquisar;
        private Button btnIncluir;
        private Label lblPesquisar;
        private DataGridView dataGridView1;
        private Button btnFechar;
        private Label lblTelaDeManutencao;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel2;
    }
}
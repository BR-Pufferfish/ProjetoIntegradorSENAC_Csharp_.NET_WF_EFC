namespace SENAC_ProjetoIntegrador
{
    partial class EquipamentoManutencao
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
            txtPesquisar = new TextBox();
            btnIncluir = new Button();
            dataGridView1 = new DataGridView();
            btnFechar = new Button();
            cuiGradientPanel2 = new CuoreUI.Controls.cuiGradientPanel();
            lblPesquisar = new Label();
            btnRemover = new Button();
            lblManutencao = new Label();
            btnEditar = new Button();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cuiGradientPanel2.SuspendLayout();
            cuiGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(48, 244);
            txtPesquisar.Margin = new Padding(4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(626, 39);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.FromArgb(128, 255, 128);
            btnIncluir.FlatAppearance.MouseDownBackColor = Color.OliveDrab;
            btnIncluir.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnIncluir.FlatStyle = FlatStyle.Flat;
            btnIncluir.Location = new Point(698, 232);
            btnIncluir.Margin = new Padding(4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(184, 64);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 308);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1463, 433);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            btnFechar.TabIndex = 2;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // cuiGradientPanel2
            // 
            cuiGradientPanel2.Controls.Add(lblPesquisar);
            cuiGradientPanel2.GradientAngle = 0F;
            cuiGradientPanel2.Location = new Point(36, 186);
            cuiGradientPanel2.Name = "cuiGradientPanel2";
            cuiGradientPanel2.OutlineThickness = 1F;
            cuiGradientPanel2.PanelColor1 = Color.White;
            cuiGradientPanel2.PanelColor2 = Color.White;
            cuiGradientPanel2.PanelOutlineColor1 = Color.White;
            cuiGradientPanel2.PanelOutlineColor2 = Color.White;
            cuiGradientPanel2.Rounding = new Padding(8);
            cuiGradientPanel2.Size = new Size(1505, 588);
            cuiGradientPanel2.TabIndex = 14;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.Transparent;
            lblPesquisar.Font = new Font("Segoe UI", 20F);
            lblPesquisar.Location = new Point(16, 11);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(128, 37);
            lblPesquisar.TabIndex = 13;
            lblPesquisar.Text = "Pesquisar";
            lblPesquisar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(255, 128, 128);
            btnRemover.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Location = new Point(1129, 781);
            btnRemover.Margin = new Padding(4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(184, 64);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // lblManutencao
            // 
            lblManutencao.AutoSize = true;
            lblManutencao.BackColor = Color.Transparent;
            lblManutencao.Font = new Font("Segoe UI", 40F);
            lblManutencao.Location = new Point(412, 18);
            lblManutencao.Name = "lblManutencao";
            lblManutencao.Size = new Size(849, 72);
            lblManutencao.TabIndex = 12;
            lblManutencao.Text = "MANUNTEÇÃO DE EQUIPAMENTO";
            lblManutencao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 128);
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(1326, 781);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(184, 64);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(btnEditar);
            cuiGradientPanel1.Controls.Add(lblManutencao);
            cuiGradientPanel1.Controls.Add(btnRemover);
            cuiGradientPanel1.Controls.Add(cuiGradientPanel2);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-4, -3);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(8);
            cuiGradientPanel1.Size = new Size(1550, 900);
            cuiGradientPanel1.TabIndex = 7;
            // 
            // EquipamentoManutencao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(btnFechar);
            Controls.Add(dataGridView1);
            Controls.Add(txtPesquisar);
            Controls.Add(btnIncluir);
            Controls.Add(cuiGradientPanel1);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "EquipamentoManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EquipamentoManutencao";
            Load += EquipamentoManutencao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cuiGradientPanel2.ResumeLayout(false);
            cuiGradientPanel2.PerformLayout();
            cuiGradientPanel1.ResumeLayout(false);
            cuiGradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPesquisar;
        private Button btnIncluir;
        private DataGridView dataGridView1;
        private Button btnFechar;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel2;
        private Label lblPesquisar;
        private Button btnRemover;
        private Label lblManutencao;
        private Button btnEditar;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PecaItemManutencao));
            btnIncluir = new Button();
            btnEditar = new Button();
            BtnRemover = new Button();
            dataGridView1 = new DataGridView();
            txtPesquisar = new TextBox();
            Pesquisar = new Label();
            btnFechar = new Button();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            txtManutencaoPecas = new Label();
            cuiGradientPanel2 = new CuoreUI.Controls.cuiGradientPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cuiGradientPanel1.SuspendLayout();
            cuiGradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.FromArgb(128, 255, 128);
            btnIncluir.FlatAppearance.MouseDownBackColor = Color.OliveDrab;
            btnIncluir.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnIncluir.FlatStyle = FlatStyle.Flat;
            btnIncluir.Font = new Font("Segoe UI", 18F);
            btnIncluir.Location = new Point(380, 55);
            btnIncluir.Margin = new Padding(2);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(184, 64);
            btnIncluir.TabIndex = 5;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 128);
            btnEditar.Enabled = false;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 18F);
            btnEditar.Location = new Point(1338, 745);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(184, 64);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // BtnRemover
            // 
            BtnRemover.BackColor = Color.FromArgb(255, 128, 128);
            BtnRemover.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            BtnRemover.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            BtnRemover.FlatStyle = FlatStyle.Flat;
            BtnRemover.Font = new Font("Segoe UI", 18F);
            BtnRemover.Location = new Point(1129, 745);
            BtnRemover.Margin = new Padding(2);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(184, 64);
            BtnRemover.TabIndex = 5;
            BtnRemover.Text = "Remover";
            BtnRemover.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 337);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1455, 374);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtPesquisar
            // 
            txtPesquisar.AcceptsReturn = true;
            txtPesquisar.BackColor = SystemColors.Window;
            txtPesquisar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisar.Location = new Point(35, 66);
            txtPesquisar.Margin = new Padding(2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(323, 39);
            txtPesquisar.TabIndex = 1;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // Pesquisar
            // 
            Pesquisar.AutoSize = true;
            Pesquisar.BackColor = Color.Transparent;
            Pesquisar.Font = new Font("Segoe UI", 18F);
            Pesquisar.Location = new Point(35, 20);
            Pesquisar.Margin = new Padding(2, 0, 2, 0);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(113, 32);
            Pesquisar.TabIndex = 0;
            Pesquisar.Text = "Pesquisar";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 18F);
            btnFechar.Location = new Point(1462, 37);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 43);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(txtManutencaoPecas);
            cuiGradientPanel1.Controls.Add(btnEditar);
            cuiGradientPanel1.Controls.Add(BtnRemover);
            cuiGradientPanel1.Controls.Add(dataGridView1);
            cuiGradientPanel1.Controls.Add(cuiGradientPanel2);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-4, -4);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(8);
            cuiGradientPanel1.Size = new Size(1542, 908);
            cuiGradientPanel1.TabIndex = 7;
            // 
            // txtManutencaoPecas
            // 
            txtManutencaoPecas.AutoSize = true;
            txtManutencaoPecas.BackColor = Color.Transparent;
            txtManutencaoPecas.Font = new Font("Segoe UI", 40F);
            txtManutencaoPecas.Location = new Point(513, 76);
            txtManutencaoPecas.Name = "txtManutencaoPecas";
            txtManutencaoPecas.Size = new Size(642, 72);
            txtManutencaoPecas.TabIndex = 11;
            txtManutencaoPecas.Text = "MANUTENÇÃO DE PEÇAS";
            txtManutencaoPecas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cuiGradientPanel2
            // 
            cuiGradientPanel2.Controls.Add(Pesquisar);
            cuiGradientPanel2.Controls.Add(btnIncluir);
            cuiGradientPanel2.Controls.Add(txtPesquisar);
            cuiGradientPanel2.GradientAngle = 0F;
            cuiGradientPanel2.Location = new Point(16, 206);
            cuiGradientPanel2.Name = "cuiGradientPanel2";
            cuiGradientPanel2.OutlineThickness = 1F;
            cuiGradientPanel2.PanelColor1 = Color.White;
            cuiGradientPanel2.PanelColor2 = Color.White;
            cuiGradientPanel2.PanelOutlineColor1 = Color.White;
            cuiGradientPanel2.PanelOutlineColor2 = Color.White;
            cuiGradientPanel2.Rounding = new Padding(8);
            cuiGradientPanel2.Size = new Size(1515, 529);
            cuiGradientPanel2.TabIndex = 12;
            // 
            // PecaItemManutencao
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(btnFechar);
            Controls.Add(cuiGradientPanel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "PecaItemManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PecaItemManutencao";
            Load += PecaItemManutencao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cuiGradientPanel1.ResumeLayout(false);
            cuiGradientPanel1.PerformLayout();
            cuiGradientPanel2.ResumeLayout(false);
            cuiGradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtPesquisar;
        private Label Pesquisar;
        private Button btnEditar;
        private Button BtnRemover;
        private DataGridView dataGridView1;
        private Button btnFechar;
        private Button btnIncluir;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private Label txtManutencaoPecas;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel2;
    }
}
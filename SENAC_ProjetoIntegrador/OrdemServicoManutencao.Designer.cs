namespace SENAC_ProjetoIntegrador
{
    partial class OrdemServicoManutencao
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
            btnEncerrar = new Button();
            btnRemover = new Button();
            txtPesquisar = new TextBox();
            btnIncluir = new Button();
            dataGridView1 = new DataGridView();
            btnFechar = new Button();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            lblManutencaoOS = new Label();
            cuiGradientPanel2 = new CuoreUI.Controls.cuiGradientPanel();
            lblPesquisar = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cuiGradientPanel1.SuspendLayout();
            cuiGradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 128);
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Goldenrod;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 18F);
            btnEditar.Location = new Point(1332, 943);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(189, 66);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEncerrar
            // 
            btnEncerrar.BackColor = Color.FromArgb(255, 128, 0);
            btnEncerrar.FlatAppearance.MouseDownBackColor = Color.Brown;
            btnEncerrar.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnEncerrar.FlatStyle = FlatStyle.Flat;
            btnEncerrar.Font = new Font("Segoe UI", 18F);
            btnEncerrar.Location = new Point(1332, 390);
            btnEncerrar.Margin = new Padding(4);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(189, 66);
            btnEncerrar.TabIndex = 5;
            btnEncerrar.Text = "Encerrar";
            btnEncerrar.UseVisualStyleBackColor = false;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(255, 128, 128);
            btnRemover.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI", 18F);
            btnRemover.Location = new Point(1123, 943);
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
            txtPesquisar.Location = new Point(37, 400);
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
            btnIncluir.Font = new Font("Segoe UI", 18F);
            btnIncluir.Location = new Point(689, 390);
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
            dataGridView1.Location = new Point(37, 473);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1484, 393);
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
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(lblManutencaoOS);
            cuiGradientPanel1.Controls.Add(btnEditar);
            cuiGradientPanel1.Controls.Add(btnFechar);
            cuiGradientPanel1.Controls.Add(btnRemover);
            cuiGradientPanel1.Controls.Add(btnEncerrar);
            cuiGradientPanel1.Controls.Add(dataGridView1);
            cuiGradientPanel1.Controls.Add(btnIncluir);
            cuiGradientPanel1.Controls.Add(txtPesquisar);
            cuiGradientPanel1.Controls.Add(cuiGradientPanel2);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-6, -3);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(1);
            cuiGradientPanel1.Size = new Size(1544, 1067);
            cuiGradientPanel1.TabIndex = 6;
            // 
            // lblManutencaoOS
            // 
            lblManutencaoOS.AutoSize = true;
            lblManutencaoOS.BackColor = Color.Transparent;
            lblManutencaoOS.Font = new Font("Segoe UI", 40F);
            lblManutencaoOS.Location = new Point(334, 129);
            lblManutencaoOS.Name = "lblManutencaoOS";
            lblManutencaoOS.Size = new Size(978, 72);
            lblManutencaoOS.TabIndex = 13;
            lblManutencaoOS.Text = "MANUTENÇÃO DE ORDEM DE SERVIÇO";
            lblManutencaoOS.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cuiGradientPanel2
            // 
            cuiGradientPanel2.Controls.Add(lblPesquisar);
            cuiGradientPanel2.GradientAngle = 0F;
            cuiGradientPanel2.Location = new Point(18, 292);
            cuiGradientPanel2.Name = "cuiGradientPanel2";
            cuiGradientPanel2.OutlineThickness = 1F;
            cuiGradientPanel2.PanelColor1 = Color.White;
            cuiGradientPanel2.PanelColor2 = Color.White;
            cuiGradientPanel2.PanelOutlineColor1 = Color.White;
            cuiGradientPanel2.PanelOutlineColor2 = Color.White;
            cuiGradientPanel2.Rounding = new Padding(8);
            cuiGradientPanel2.Size = new Size(1523, 609);
            cuiGradientPanel2.TabIndex = 12;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.Transparent;
            lblPesquisar.Font = new Font("Segoe UI", 20F);
            lblPesquisar.Location = new Point(19, 23);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(128, 37);
            lblPesquisar.TabIndex = 11;
            lblPesquisar.Text = "Pesquisar";
            lblPesquisar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OrdemServicoManutencao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1550, 1061);
            Controls.Add(cuiGradientPanel1);
            Font = new Font("Segoe UI", 18F);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "OrdemServicoManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdemServicoManutencao";
            Load += OrdemServicoManutencao_Load;
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
        private DataGridView dataGridView1;
        private Button btnFechar;
        private Button btnEncerrar;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private Label lblPesquisar;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel2;
        private Label lblManutencaoOS;
    }
}
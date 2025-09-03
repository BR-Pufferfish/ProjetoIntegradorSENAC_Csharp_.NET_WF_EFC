namespace SENAC_ProjetoIntegrador
{
    partial class ServicoManutencao
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
            dataGridView1 = new DataGridView();
            btnFechar = new Button();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            lblPesquisar = new Label();
            cuiGradientPanel2 = new CuoreUI.Controls.cuiGradientPanel();
            lblManutencaoServico = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cuiGradientPanel1.SuspendLayout();
            cuiGradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Location = new Point(1325, 764);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(171, 49);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.White;
            btnRemover.Location = new Point(1135, 764);
            btnRemover.Margin = new Padding(2);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(171, 49);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Segoe UI", 18F);
            txtPesquisar.Location = new Point(49, 327);
            txtPesquisar.Margin = new Padding(2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(339, 39);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.White;
            btnIncluir.Location = new Point(416, 319);
            btnIncluir.Margin = new Padding(2);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(146, 51);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 392);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1447, 330);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1479, 18);
            btnFechar.Margin = new Padding(2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(50, 34);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(lblManutencaoServico);
            cuiGradientPanel1.Controls.Add(btnEditar);
            cuiGradientPanel1.Controls.Add(btnFechar);
            cuiGradientPanel1.Controls.Add(btnRemover);
            cuiGradientPanel1.Controls.Add(txtPesquisar);
            cuiGradientPanel1.Controls.Add(dataGridView1);
            cuiGradientPanel1.Controls.Add(btnIncluir);
            cuiGradientPanel1.Controls.Add(cuiGradientPanel2);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-5, -7);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(1);
            cuiGradientPanel1.Size = new Size(1531, 910);
            cuiGradientPanel1.TabIndex = 7;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.Transparent;
            lblPesquisar.Font = new Font("Segoe UI", 20F);
            lblPesquisar.Location = new Point(17, 23);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(128, 37);
            lblPesquisar.TabIndex = 11;
            lblPesquisar.Text = "Pesquisar";
            lblPesquisar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cuiGradientPanel2
            // 
            cuiGradientPanel2.Controls.Add(lblPesquisar);
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
            cuiGradientPanel2.TabIndex = 12;
            // 
            // lblManutencaoServico
            // 
            lblManutencaoServico.AutoSize = true;
            lblManutencaoServico.BackColor = Color.Transparent;
            lblManutencaoServico.Font = new Font("Segoe UI", 40F);
            lblManutencaoServico.Location = new Point(466, 18);
            lblManutencaoServico.Name = "lblManutencaoServico";
            lblManutencaoServico.Size = new Size(697, 72);
            lblManutencaoServico.TabIndex = 13;
            lblManutencaoServico.Text = "MANUTENÇÃO DE SERVIÇO";
            lblManutencaoServico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ServicoManutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(cuiGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServicoManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ServicoManutencao";
            Load += ServicoManutencao_Load;
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
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private Label lblPesquisar;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel2;
        private Label lblManutencaoServico;
    }
}
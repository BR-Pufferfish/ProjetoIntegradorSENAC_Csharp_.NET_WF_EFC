namespace SENAC_ProjetoIntegrador
{
    partial class VendaManutencao
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
            btnFechar = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            txtPesquisar = new TextBox();
            btnIncluir = new Button();
            dataGridView1 = new DataGridView();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            cuiGradientPanel2 = new CuoreUI.Controls.cuiGradientPanel();
            lblPesquisar = new Label();
            lblTelaDeManutencao = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            cuiGradientPanel1.SuspendLayout();
            cuiGradientPanel2.SuspendLayout();
            SuspendLayout();
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
            // btnEditar
            // 
            btnEditar.Location = new Point(1275, 812);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(189, 66);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(1078, 812);
            btnRemover.Margin = new Padding(4);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(189, 66);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(19, 59);
            txtPesquisar.Margin = new Padding(4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(626, 39);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(667, 57);
            btnIncluir.Margin = new Padding(4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(145, 43);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 317);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1412, 447);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(cuiGradientPanel2);
            cuiGradientPanel1.Controls.Add(btnEditar);
            cuiGradientPanel1.Controls.Add(btnRemover);
            cuiGradientPanel1.Controls.Add(lblTelaDeManutencao);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-2, -8);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(1);
            cuiGradientPanel1.Size = new Size(1550, 900);
            cuiGradientPanel1.TabIndex = 7;
            // 
            // cuiGradientPanel2
            // 
            cuiGradientPanel2.Controls.Add(lblPesquisar);
            cuiGradientPanel2.Controls.Add(txtPesquisar);
            cuiGradientPanel2.Controls.Add(btnIncluir);
            cuiGradientPanel2.GradientAngle = 0F;
            cuiGradientPanel2.Location = new Point(33, 192);
            cuiGradientPanel2.Name = "cuiGradientPanel2";
            cuiGradientPanel2.OutlineThickness = 1F;
            cuiGradientPanel2.PanelColor1 = Color.White;
            cuiGradientPanel2.PanelColor2 = Color.White;
            cuiGradientPanel2.PanelOutlineColor1 = Color.White;
            cuiGradientPanel2.PanelOutlineColor2 = Color.White;
            cuiGradientPanel2.Rounding = new Padding(8);
            cuiGradientPanel2.Size = new Size(1452, 613);
            cuiGradientPanel2.TabIndex = 11;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.Transparent;
            lblPesquisar.Font = new Font("Segoe UI", 20F);
            lblPesquisar.Location = new Point(19, 18);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(128, 37);
            lblPesquisar.TabIndex = 10;
            lblPesquisar.Text = "Pesquisar";
            lblPesquisar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelaDeManutencao
            // 
            lblTelaDeManutencao.AutoSize = true;
            lblTelaDeManutencao.BackColor = Color.Transparent;
            lblTelaDeManutencao.Font = new Font("Segoe UI", 40F);
            lblTelaDeManutencao.Location = new Point(509, 27);
            lblTelaDeManutencao.Name = "lblTelaDeManutencao";
            lblTelaDeManutencao.Size = new Size(661, 72);
            lblTelaDeManutencao.TabIndex = 10;
            lblTelaDeManutencao.Text = "MANUTENÇÃO DE VENDA";
            lblTelaDeManutencao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // VendaManutencao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(dataGridView1);
            Controls.Add(btnFechar);
            Controls.Add(cuiGradientPanel1);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "VendaManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VendaManutencao";
            Load += VendaManutencao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            cuiGradientPanel1.ResumeLayout(false);
            cuiGradientPanel1.PerformLayout();
            cuiGradientPanel2.ResumeLayout(false);
            cuiGradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFechar;
        private Button btnEditar;
        private Button btnRemover;
        private TextBox txtPesquisar;
        private Button btnIncluir;
        private DataGridView dataGridView1;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private Label lblTelaDeManutencao;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel2;
        private Label lblPesquisar;
    }
}
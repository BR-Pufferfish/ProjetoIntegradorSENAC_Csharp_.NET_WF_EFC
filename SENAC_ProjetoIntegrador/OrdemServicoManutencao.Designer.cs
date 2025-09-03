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
            groupBox1 = new GroupBox();
            btnEditar = new Button();
            btnEncerrar = new Button();
            btnRemover = new Button();
            txtPesquisar = new TextBox();
            btnIncluir = new Button();
            lblPesquisar = new Label();
            dataGridView1 = new DataGridView();
            lblManutencaoOS = new Label();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnEncerrar);
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(txtPesquisar);
            groupBox1.Controls.Add(btnIncluir);
            groupBox1.Controls.Add(lblPesquisar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(19, 124);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1518, 913);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(128, 255, 128);
            btnEditar.Font = new Font("Segoe UI", 18F);
            btnEditar.Location = new Point(1321, 821);
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
            btnEncerrar.Font = new Font("Segoe UI", 18F);
            btnEncerrar.Location = new Point(1310, 250);
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
            btnRemover.Font = new Font("Segoe UI", 18F);
            btnRemover.Location = new Point(1114, 821);
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
            txtPesquisar.Location = new Point(28, 126);
            txtPesquisar.Margin = new Padding(4);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(626, 39);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // btnIncluir
            // 
            btnIncluir.BackColor = Color.FromArgb(255, 255, 128);
            btnIncluir.Font = new Font("Segoe UI", 18F);
            btnIncluir.Location = new Point(28, 190);
            btnIncluir.Margin = new Padding(4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(184, 64);
            btnIncluir.TabIndex = 3;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = false;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Font = new Font("Segoe UI", 18F);
            lblPesquisar.Location = new Point(26, 58);
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
            dataGridView1.Location = new Point(26, 333);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1484, 393);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblManutencaoOS
            // 
            lblManutencaoOS.AutoSize = true;
            lblManutencaoOS.Font = new Font("Segoe UI", 30F);
            lblManutencaoOS.Location = new Point(443, 52);
            lblManutencaoOS.Margin = new Padding(4, 0, 4, 0);
            lblManutencaoOS.Name = "lblManutencaoOS";
            lblManutencaoOS.Size = new Size(627, 54);
            lblManutencaoOS.TabIndex = 2;
            lblManutencaoOS.Text = "Manutenção de Ordem de Serviço";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1472, 13);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 43);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // OrdemServicoManutencao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1550, 1061);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(lblManutencaoOS);
            Font = new Font("Segoe UI", 18F);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "OrdemServicoManutencao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdemServicoManutencao";
            Load += OrdemServicoManutencao_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnEditar;
        private Button btnRemover;
        private TextBox txtPesquisar;
        private Button btnIncluir;
        private Label lblPesquisar;
        private DataGridView dataGridView1;
        private Label lblManutencaoOS;
        private Button btnFechar;
        private Button btnEncerrar;
    }
}
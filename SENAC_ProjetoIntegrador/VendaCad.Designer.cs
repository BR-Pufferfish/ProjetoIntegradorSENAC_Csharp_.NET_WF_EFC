namespace SENAC_ProjetoIntegrador
{
    partial class VendaCad
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
            btnAddVenda = new Button();
            btnRemVenda = new Button();
            dgvEquipamento = new DataGridView();
            btnCancelar = new Button();
            btnSalvar = new Button();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            btnFechar = new Button();
            txtSequencia = new TextBox();
            txtValorTotal = new TextBox();
            TxtDtInclusao = new TextBox();
            cbbEquipamento = new ComboBox();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            cbbCpfcnpj = new ComboBox();
            cbbCliente = new ComboBox();
            dtInclusao = new Label();
            lblCpfCnpj = new Label();
            lblCliente = new Label();
            lvlValorServico = new Label();
            lblEquipamento = new Label();
            lblVenda = new Label();
            lblSequencia = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamento).BeginInit();
            cuiGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddVenda
            // 
            btnAddVenda.Location = new Point(983, 411);
            btnAddVenda.Margin = new Padding(4);
            btnAddVenda.Name = "btnAddVenda";
            btnAddVenda.Size = new Size(214, 53);
            btnAddVenda.TabIndex = 8;
            btnAddVenda.Text = "Adicionar";
            btnAddVenda.UseVisualStyleBackColor = true;
            btnAddVenda.Click += btnAddVenda_Click;
            // 
            // btnRemVenda
            // 
            btnRemVenda.Location = new Point(1205, 411);
            btnRemVenda.Margin = new Padding(4);
            btnRemVenda.Name = "btnRemVenda";
            btnRemVenda.Size = new Size(214, 53);
            btnRemVenda.TabIndex = 8;
            btnRemVenda.Text = "Remover";
            btnRemVenda.UseVisualStyleBackColor = true;
            btnRemVenda.Click += btnRemVenda_Click;
            // 
            // dgvEquipamento
            // 
            dgvEquipamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvEquipamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipamento.Location = new Point(82, 482);
            dgvEquipamento.Margin = new Padding(4);
            dgvEquipamento.Name = "dgvEquipamento";
            dgvEquipamento.RowHeadersWidth = 62;
            dgvEquipamento.Size = new Size(1348, 305);
            dgvEquipamento.TabIndex = 9;
            dgvEquipamento.CellClick += dgvEquipamento_CellClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1086, 834);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(214, 53);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1308, 834);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(214, 53);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
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
            btnFechar.TabIndex = 10;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtSequencia
            // 
            txtSequencia.Enabled = false;
            txtSequencia.Location = new Point(90, 210);
            txtSequencia.Margin = new Padding(4);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(193, 39);
            txtSequencia.TabIndex = 11;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Enabled = false;
            txtValorTotal.Location = new Point(82, 841);
            txtValorTotal.Margin = new Padding(4);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(602, 39);
            txtValorTotal.TabIndex = 11;
            // 
            // TxtDtInclusao
            // 
            TxtDtInclusao.Enabled = false;
            TxtDtInclusao.Location = new Point(1100, 210);
            TxtDtInclusao.Margin = new Padding(4);
            TxtDtInclusao.Name = "TxtDtInclusao";
            TxtDtInclusao.Size = new Size(303, 39);
            TxtDtInclusao.TabIndex = 11;
            TxtDtInclusao.Text = " ";
            // 
            // cbbEquipamento
            // 
            cbbEquipamento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbEquipamento.FormattingEnabled = true;
            cbbEquipamento.Location = new Point(80, 420);
            cbbEquipamento.Name = "cbbEquipamento";
            cbbEquipamento.Size = new Size(610, 40);
            cbbEquipamento.TabIndex = 12;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(cbbCpfcnpj);
            cuiGradientPanel1.Controls.Add(cbbCliente);
            cuiGradientPanel1.Controls.Add(TxtDtInclusao);
            cuiGradientPanel1.Controls.Add(dtInclusao);
            cuiGradientPanel1.Controls.Add(txtSequencia);
            cuiGradientPanel1.Controls.Add(lblCpfCnpj);
            cuiGradientPanel1.Controls.Add(lblCliente);
            cuiGradientPanel1.Controls.Add(lvlValorServico);
            cuiGradientPanel1.Controls.Add(lblEquipamento);
            cuiGradientPanel1.Controls.Add(lblVenda);
            cuiGradientPanel1.Controls.Add(lblSequencia);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-8, -4);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(1);
            cuiGradientPanel1.Size = new Size(1477, 908);
            cuiGradientPanel1.TabIndex = 13;
            // 
            // cbbCpfcnpj
            // 
            cbbCpfcnpj.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCpfcnpj.FormattingEnabled = true;
            cbbCpfcnpj.Location = new Point(900, 310);
            cbbCpfcnpj.Name = "cbbCpfcnpj";
            cbbCpfcnpj.Size = new Size(530, 40);
            cbbCpfcnpj.TabIndex = 12;
            // 
            // cbbCliente
            // 
            cbbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCliente.FormattingEnabled = true;
            cbbCliente.Location = new Point(90, 310);
            cbbCliente.Name = "cbbCliente";
            cbbCliente.Size = new Size(770, 40);
            cbbCliente.TabIndex = 12;
            cbbCliente.SelectedIndexChanged += cbbCliente_SelectedIndexChanged;
            // 
            // dtInclusao
            // 
            dtInclusao.AutoSize = true;
            dtInclusao.BackColor = Color.Transparent;
            dtInclusao.Font = new Font("Segoe UI", 18F);
            dtInclusao.Location = new Point(1100, 170);
            dtInclusao.Name = "dtInclusao";
            dtInclusao.Size = new Size(101, 32);
            dtInclusao.TabIndex = 11;
            dtInclusao.Text = "Inclusão";
            dtInclusao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.BackColor = Color.Transparent;
            lblCpfCnpj.Font = new Font("Segoe UI", 18F);
            lblCpfCnpj.Location = new Point(900, 280);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(116, 32);
            lblCpfCnpj.TabIndex = 11;
            lblCpfCnpj.Text = "CPF/CNPJ";
            lblCpfCnpj.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Segoe UI", 18F);
            lblCliente.Location = new Point(90, 278);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(89, 32);
            lblCliente.TabIndex = 11;
            lblCliente.Text = "Cliente";
            lblCliente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lvlValorServico
            // 
            lvlValorServico.AutoSize = true;
            lvlValorServico.BackColor = Color.Transparent;
            lvlValorServico.Font = new Font("Segoe UI", 18F);
            lvlValorServico.Location = new Point(90, 803);
            lvlValorServico.Name = "lvlValorServico";
            lvlValorServico.Size = new Size(244, 32);
            lvlValorServico.TabIndex = 11;
            lvlValorServico.Text = "Valor Total do Serviço";
            lvlValorServico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEquipamento
            // 
            lblEquipamento.AutoSize = true;
            lblEquipamento.BackColor = Color.Transparent;
            lblEquipamento.Font = new Font("Segoe UI", 18F);
            lblEquipamento.Location = new Point(88, 380);
            lblEquipamento.Name = "lblEquipamento";
            lblEquipamento.Size = new Size(156, 32);
            lblEquipamento.TabIndex = 11;
            lblEquipamento.Text = "Equipamento";
            lblEquipamento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.BackColor = Color.Transparent;
            lblVenda.Font = new Font("Segoe UI", 40F);
            lblVenda.Location = new Point(480, 150);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(484, 72);
            lblVenda.TabIndex = 11;
            lblVenda.Text = "ORDEM DE VENDA";
            lblVenda.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.BackColor = Color.Transparent;
            lblSequencia.Font = new Font("Segoe UI", 18F);
            lblSequencia.Location = new Point(90, 170);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(124, 32);
            lblSequencia.TabIndex = 11;
            lblSequencia.Text = "Sequência";
            lblSequencia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // VendaCad
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(cbbEquipamento);
            Controls.Add(txtValorTotal);
            Controls.Add(btnFechar);
            Controls.Add(dgvEquipamento);
            Controls.Add(btnSalvar);
            Controls.Add(btnRemVenda);
            Controls.Add(btnCancelar);
            Controls.Add(btnAddVenda);
            Controls.Add(cuiGradientPanel1);
            Font = new Font("Segoe UI", 18F);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "VendaCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tipo Pessoa";
            Load += VendaCad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipamento).EndInit();
            cuiGradientPanel1.ResumeLayout(false);
            cuiGradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEmissor1;
        private Label lblTipoPessoa1;
        //private Label dtInclusao;
        private Label lblCpfCnpj;
        //private Label lblPagamento;
        private Button btnAddVenda;
        private Button btnRemVenda;
        private DataGridView dgvEquipamento;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblEquipamento;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Button btnFechar;
        private TextBox txtSequencia;
        private TextBox txtValorTotal;
        private TextBox TxtDtInclusao;
        private ComboBox cbbEquipamento;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label lblVenda;
        private Label lblSequencia;
        private Label lblCliente;
        private Label lvlValorServico;
        private Label dtInclusao;
        private ComboBox cbbCpfcnpj;
        private ComboBox cbbCliente;
    }
}
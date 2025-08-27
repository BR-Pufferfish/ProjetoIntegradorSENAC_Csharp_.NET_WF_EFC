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
            lblVenda = new Label();
            lblEmissor = new Label();
            lblTipoPessoa = new Label();
            dtInclusao = new Label();
            lblCliente = new Label();
            lblCpfCnpj = new Label();
            lvlValorServico = new Label();
            lblSequencia = new Label();
            lblPagamento = new Label();
            btnAddVenda = new Button();
            btnRemVenda = new Button();
            dgvEquipamento = new DataGridView();
            btnCancelar = new Button();
            btnSalvar = new Button();
            lblEquipamento = new Label();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            btnFechar = new Button();
            lblRazaoSocial = new Label();
            txtSequencia = new TextBox();
            txtEmissor = new TextBox();
            txtCliente = new TextBox();
            txtTipoPessoa = new TextBox();
            txtRazaoSocial = new TextBox();
            txtCpfCnpj = new TextBox();
            txtPagamento = new TextBox();
            txtValorTotal = new TextBox();
            TxtDTInclusao = new TextBox();
            cbbEquipamento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamento).BeginInit();
            SuspendLayout();
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.Font = new Font("Segoe UI", 30F);
            lblVenda.Location = new Point(599, 23);
            lblVenda.Margin = new Padding(4, 0, 4, 0);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(323, 54);
            lblVenda.TabIndex = 1;
            lblVenda.Text = "Ordem de Venda";
            // 
            // lblEmissor
            // 
            lblEmissor.AutoSize = true;
            lblEmissor.Location = new Point(82, 114);
            lblEmissor.Margin = new Padding(4, 0, 4, 0);
            lblEmissor.Name = "lblEmissor";
            lblEmissor.Size = new Size(95, 32);
            lblEmissor.TabIndex = 3;
            lblEmissor.Text = "Emissor";
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(82, 291);
            lblTipoPessoa.Margin = new Padding(4, 0, 4, 0);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(139, 32);
            lblTipoPessoa.TabIndex = 4;
            lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // dtInclusao
            // 
            dtInclusao.AutoSize = true;
            dtInclusao.Location = new Point(1098, 24);
            dtInclusao.Margin = new Padding(4, 0, 4, 0);
            dtInclusao.Name = "dtInclusao";
            dtInclusao.Size = new Size(137, 32);
            dtInclusao.TabIndex = 5;
            dtInclusao.Text = "DT Inclusão";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(82, 199);
            lblCliente.Margin = new Padding(4, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(89, 32);
            lblCliente.TabIndex = 7;
            lblCliente.Text = "Cliente";
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(810, 203);
            lblCpfCnpj.Margin = new Padding(4, 0, 4, 0);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(116, 32);
            lblCpfCnpj.TabIndex = 7;
            lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // lvlValorServico
            // 
            lvlValorServico.AutoSize = true;
            lvlValorServico.Location = new Point(80, 800);
            lvlValorServico.Margin = new Padding(4, 0, 4, 0);
            lvlValorServico.Name = "lvlValorServico";
            lvlValorServico.Size = new Size(244, 32);
            lvlValorServico.TabIndex = 7;
            lvlValorServico.Text = "Valor Total do Serviço";
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.Location = new Point(82, 24);
            lblSequencia.Margin = new Padding(4, 0, 4, 0);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(124, 32);
            lblSequencia.TabIndex = 7;
            lblSequencia.Text = "Sequência";
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Location = new Point(390, 294);
            lblPagamento.Margin = new Padding(4, 0, 4, 0);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(134, 32);
            lblPagamento.TabIndex = 7;
            lblPagamento.Text = "Pagamento";
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
            // lblEquipamento
            // 
            lblEquipamento.AutoSize = true;
            lblEquipamento.Location = new Point(80, 380);
            lblEquipamento.Margin = new Padding(4, 0, 4, 0);
            lblEquipamento.Name = "lblEquipamento";
            lblEquipamento.Size = new Size(156, 32);
            lblEquipamento.TabIndex = 7;
            lblEquipamento.Text = "Equipamento";
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1461, 13);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(61, 43);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Location = new Point(810, 284);
            lblRazaoSocial.Margin = new Padding(4, 0, 4, 0);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(146, 32);
            lblRazaoSocial.TabIndex = 4;
            lblRazaoSocial.Text = "Razão Social";
            // 
            // txtSequencia
            // 
            txtSequencia.Location = new Point(82, 60);
            txtSequencia.Margin = new Padding(4);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(193, 39);
            txtSequencia.TabIndex = 11;
            // 
            // txtEmissor
            // 
            txtEmissor.Location = new Point(82, 151);
            txtEmissor.Margin = new Padding(4);
            txtEmissor.Name = "txtEmissor";
            txtEmissor.Size = new Size(383, 39);
            txtEmissor.TabIndex = 11;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(82, 235);
            txtCliente.Margin = new Padding(4);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(608, 39);
            txtCliente.TabIndex = 11;
            // 
            // txtTipoPessoa
            // 
            txtTipoPessoa.Location = new Point(82, 327);
            txtTipoPessoa.Margin = new Padding(4);
            txtTipoPessoa.Name = "txtTipoPessoa";
            txtTipoPessoa.Size = new Size(248, 39);
            txtTipoPessoa.TabIndex = 11;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(810, 320);
            txtRazaoSocial.Margin = new Padding(4);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(610, 39);
            txtRazaoSocial.TabIndex = 11;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(810, 240);
            txtCpfCnpj.Margin = new Padding(4);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(610, 39);
            txtCpfCnpj.TabIndex = 11;
            // 
            // txtPagamento
            // 
            txtPagamento.Location = new Point(390, 330);
            txtPagamento.Margin = new Padding(4);
            txtPagamento.Name = "txtPagamento";
            txtPagamento.Size = new Size(303, 39);
            txtPagamento.TabIndex = 11;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(82, 841);
            txtValorTotal.Margin = new Padding(4);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(602, 39);
            txtValorTotal.TabIndex = 11;
            // 
            // TxtDTInclusao
            // 
            TxtDTInclusao.Location = new Point(1098, 60);
            TxtDTInclusao.Margin = new Padding(4);
            TxtDTInclusao.Name = "TxtDTInclusao";
            TxtDTInclusao.Size = new Size(303, 39);
            TxtDTInclusao.TabIndex = 11;
            // 
            // cbbEquipamento
            // 
            cbbEquipamento.FormattingEnabled = true;
            cbbEquipamento.Location = new Point(80, 420);
            cbbEquipamento.Name = "cbbEquipamento";
            cbbEquipamento.Size = new Size(610, 40);
            cbbEquipamento.TabIndex = 12;
            // 
            // VendaCad
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1550, 900);
            Controls.Add(cbbEquipamento);
            Controls.Add(txtValorTotal);
            Controls.Add(TxtDTInclusao);
            Controls.Add(txtCpfCnpj);
            Controls.Add(txtPagamento);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtTipoPessoa);
            Controls.Add(txtCliente);
            Controls.Add(txtEmissor);
            Controls.Add(txtSequencia);
            Controls.Add(btnFechar);
            Controls.Add(dgvEquipamento);
            Controls.Add(btnSalvar);
            Controls.Add(btnRemVenda);
            Controls.Add(btnCancelar);
            Controls.Add(btnAddVenda);
            Controls.Add(lblCpfCnpj);
            Controls.Add(lblSequencia);
            Controls.Add(lblPagamento);
            Controls.Add(lblEquipamento);
            Controls.Add(lvlValorServico);
            Controls.Add(lblCliente);
            Controls.Add(dtInclusao);
            Controls.Add(lblRazaoSocial);
            Controls.Add(lblTipoPessoa);
            Controls.Add(lblEmissor);
            Controls.Add(lblVenda);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "VendaCad";
            Text = "Tipo Pessoa";
            Load += VendaCad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblVenda;
        private Label lblEmissor;
        private Label lblTipoPessoa;
        private Label dtInclusao;
        private Label lblCliente;
        private Label lblCpfCnpj;
        private Label lvlValorServico;
        private Label lblSequencia;
        private Label lblPagamento;
        private Button btnAddVenda;
        private Button btnRemVenda;
        private DataGridView dgvEquipamento;
        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblEquipamento;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Button btnFechar;
        private Label lblRazaoSocial;
        private TextBox txtSequencia;
        private TextBox txtEmissor;
        private TextBox txtCliente;
        private TextBox txtTipoPessoa;
        private TextBox txtRazaoSocial;
        private TextBox txtCpfCnpj;
        private TextBox txtPagamento;
        private TextBox txtValorTotal;
        private TextBox TxtDTInclusao;
        private ComboBox cbbEquipamento;
    }
}
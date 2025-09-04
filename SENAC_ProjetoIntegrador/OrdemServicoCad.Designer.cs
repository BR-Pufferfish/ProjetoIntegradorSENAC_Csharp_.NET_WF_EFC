namespace SENAC_ProjetoIntegrador
{
    partial class OrdemServicoCad
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
            txtSequencia = new TextBox();
            lblSequencia = new Label();
            txtDtInclusao = new TextBox();
            lblDtInclusao = new Label();
            lblSituacao = new Label();
            txtDtEncerramento = new TextBox();
            lblEncerramento = new Label();
            cbbCpfcnpj = new ComboBox();
            cbbEquipamento = new ComboBox();
            cbbCliente = new ComboBox();
            label11 = new Label();
            txtModelo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            gpbServicos = new GroupBox();
            cbbServico = new ComboBox();
            dgvServico = new DataGridView();
            btnRemServico = new Button();
            btnAddServico = new Button();
            gpbDescricaoGeral = new GroupBox();
            rtxDescricaoGeral = new RichTextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            gpbPecaItem = new GroupBox();
            cbbPecaItem = new ComboBox();
            dgvPecaItem = new DataGridView();
            btnRemPecaItem = new Button();
            btnAddPecaItem = new Button();
            txtValorTotal = new TextBox();
            btnValorTotal = new Button();
            gpbDescricaoEncerramento = new GroupBox();
            rtxDescricaoEncerramento = new RichTextBox();
            btnFechar = new Button();
            cbbSituacaoOS = new ComboBox();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            lblTitulo = new Label();
            gpbServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServico).BeginInit();
            gpbDescricaoGeral.SuspendLayout();
            gpbPecaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPecaItem).BeginInit();
            gpbDescricaoEncerramento.SuspendLayout();
            cuiGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSequencia
            // 
            txtSequencia.Enabled = false;
            txtSequencia.Location = new Point(31, 91);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(100, 23);
            txtSequencia.TabIndex = 0;
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.BackColor = Color.Transparent;
            lblSequencia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSequencia.ForeColor = SystemColors.ActiveCaption;
            lblSequencia.Location = new Point(31, 61);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(81, 21);
            lblSequencia.TabIndex = 1;
            lblSequencia.Text = "Sequência";
            // 
            // txtDtInclusao
            // 
            txtDtInclusao.Enabled = false;
            txtDtInclusao.Location = new Point(841, 81);
            txtDtInclusao.Name = "txtDtInclusao";
            txtDtInclusao.Size = new Size(110, 23);
            txtDtInclusao.TabIndex = 0;
            // 
            // lblDtInclusao
            // 
            lblDtInclusao.AutoSize = true;
            lblDtInclusao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDtInclusao.ForeColor = SystemColors.ActiveCaption;
            lblDtInclusao.Location = new Point(841, 56);
            lblDtInclusao.Name = "lblDtInclusao";
            lblDtInclusao.Size = new Size(67, 21);
            lblDtInclusao.TabIndex = 1;
            lblDtInclusao.Text = "Inclusão";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.BackColor = Color.Transparent;
            lblSituacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSituacao.ForeColor = SystemColors.ActiveCaption;
            lblSituacao.Location = new Point(34, 117);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(69, 21);
            lblSituacao.TabIndex = 1;
            lblSituacao.Text = "Situação";
            // 
            // txtDtEncerramento
            // 
            txtDtEncerramento.Enabled = false;
            txtDtEncerramento.Location = new Point(844, 141);
            txtDtEncerramento.Name = "txtDtEncerramento";
            txtDtEncerramento.Size = new Size(110, 23);
            txtDtEncerramento.TabIndex = 0;
            // 
            // lblEncerramento
            // 
            lblEncerramento.AutoSize = true;
            lblEncerramento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEncerramento.ForeColor = SystemColors.ActiveCaption;
            lblEncerramento.Location = new Point(841, 117);
            lblEncerramento.Name = "lblEncerramento";
            lblEncerramento.Size = new Size(107, 21);
            lblEncerramento.TabIndex = 1;
            lblEncerramento.Text = "Encerramento";
            // 
            // cbbCpfcnpj
            // 
            cbbCpfcnpj.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCpfcnpj.FormattingEnabled = true;
            cbbCpfcnpj.Location = new Point(539, 314);
            cbbCpfcnpj.Name = "cbbCpfcnpj";
            cbbCpfcnpj.Size = new Size(410, 23);
            cbbCpfcnpj.TabIndex = 7;
            // 
            // cbbEquipamento
            // 
            cbbEquipamento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbEquipamento.FormattingEnabled = true;
            cbbEquipamento.Location = new Point(29, 258);
            cbbEquipamento.Name = "cbbEquipamento";
            cbbEquipamento.Size = new Size(410, 23);
            cbbEquipamento.TabIndex = 7;
            // 
            // cbbCliente
            // 
            cbbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCliente.FormattingEnabled = true;
            cbbCliente.Location = new Point(29, 314);
            cbbCliente.Name = "cbbCliente";
            cbbCliente.Size = new Size(410, 23);
            cbbCliente.TabIndex = 7;
            cbbCliente.SelectedIndexChanged += cbbCliente_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaption;
            label11.Location = new Point(539, 284);
            label11.Name = "label11";
            label11.Size = new Size(87, 21);
            label11.TabIndex = 1;
            label11.Text = "CPF / CNPJ";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(536, 258);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(410, 23);
            txtModelo.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(539, 225);
            label10.Name = "label10";
            label10.Size = new Size(63, 21);
            label10.TabIndex = 1;
            label10.Text = "Modelo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(29, 284);
            label9.Name = "label9";
            label9.Size = new Size(58, 21);
            label9.TabIndex = 1;
            label9.Text = "Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(29, 225);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 1;
            label8.Text = "Equipamento";
            // 
            // gpbServicos
            // 
            gpbServicos.BackColor = Color.Transparent;
            gpbServicos.Controls.Add(cbbServico);
            gpbServicos.Controls.Add(dgvServico);
            gpbServicos.Controls.Add(btnRemServico);
            gpbServicos.Controls.Add(btnAddServico);
            gpbServicos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbServicos.ForeColor = SystemColors.ActiveCaption;
            gpbServicos.Location = new Point(14, 360);
            gpbServicos.Name = "gpbServicos";
            gpbServicos.Size = new Size(470, 270);
            gpbServicos.TabIndex = 3;
            gpbServicos.TabStop = false;
            gpbServicos.Text = "Serviços";
            // 
            // cbbServico
            // 
            cbbServico.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbServico.FormattingEnabled = true;
            cbbServico.Location = new Point(20, 40);
            cbbServico.Name = "cbbServico";
            cbbServico.Size = new Size(310, 29);
            cbbServico.TabIndex = 7;
            // 
            // dgvServico
            // 
            dgvServico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServico.Location = new Point(20, 80);
            dgvServico.Name = "dgvServico";
            dgvServico.Size = new Size(430, 180);
            dgvServico.TabIndex = 5;
            dgvServico.CellClick += dgvServico_CellClick;
            // 
            // btnRemServico
            // 
            btnRemServico.ForeColor = SystemColors.ActiveCaptionText;
            btnRemServico.Location = new Point(400, 40);
            btnRemServico.Name = "btnRemServico";
            btnRemServico.Size = new Size(50, 30);
            btnRemServico.TabIndex = 4;
            btnRemServico.Text = "Rem";
            btnRemServico.UseVisualStyleBackColor = true;
            btnRemServico.Click += btnRemServico_Click;
            // 
            // btnAddServico
            // 
            btnAddServico.ForeColor = SystemColors.ActiveCaptionText;
            btnAddServico.Location = new Point(340, 40);
            btnAddServico.Name = "btnAddServico";
            btnAddServico.Size = new Size(50, 30);
            btnAddServico.TabIndex = 4;
            btnAddServico.Text = "Add";
            btnAddServico.UseVisualStyleBackColor = true;
            btnAddServico.Click += btnAddServico_Click;
            // 
            // gpbDescricaoGeral
            // 
            gpbDescricaoGeral.BackColor = Color.Transparent;
            gpbDescricaoGeral.Controls.Add(rtxDescricaoGeral);
            gpbDescricaoGeral.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDescricaoGeral.ForeColor = SystemColors.ActiveCaption;
            gpbDescricaoGeral.Location = new Point(14, 650);
            gpbDescricaoGeral.Name = "gpbDescricaoGeral";
            gpbDescricaoGeral.Size = new Size(470, 140);
            gpbDescricaoGeral.TabIndex = 2;
            gpbDescricaoGeral.TabStop = false;
            gpbDescricaoGeral.Text = "Descrição Geral";
            // 
            // rtxDescricaoGeral
            // 
            rtxDescricaoGeral.Location = new Point(20, 40);
            rtxDescricaoGeral.Name = "rtxDescricaoGeral";
            rtxDescricaoGeral.Size = new Size(430, 80);
            rtxDescricaoGeral.TabIndex = 2;
            rtxDescricaoGeral.Text = "";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(770, 810);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 30);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(880, 810);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 30);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // gpbPecaItem
            // 
            gpbPecaItem.BackColor = Color.Transparent;
            gpbPecaItem.Controls.Add(cbbPecaItem);
            gpbPecaItem.Controls.Add(dgvPecaItem);
            gpbPecaItem.Controls.Add(btnRemPecaItem);
            gpbPecaItem.Controls.Add(btnAddPecaItem);
            gpbPecaItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbPecaItem.ForeColor = SystemColors.ActiveCaption;
            gpbPecaItem.Location = new Point(504, 360);
            gpbPecaItem.Name = "gpbPecaItem";
            gpbPecaItem.Size = new Size(470, 270);
            gpbPecaItem.TabIndex = 3;
            gpbPecaItem.TabStop = false;
            gpbPecaItem.Text = "Peça / Item";
            // 
            // cbbPecaItem
            // 
            cbbPecaItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbPecaItem.FormattingEnabled = true;
            cbbPecaItem.Location = new Point(20, 40);
            cbbPecaItem.Name = "cbbPecaItem";
            cbbPecaItem.Size = new Size(310, 29);
            cbbPecaItem.TabIndex = 7;
            // 
            // dgvPecaItem
            // 
            dgvPecaItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvPecaItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPecaItem.Location = new Point(20, 80);
            dgvPecaItem.Name = "dgvPecaItem";
            dgvPecaItem.Size = new Size(430, 180);
            dgvPecaItem.TabIndex = 5;
            dgvPecaItem.CellClick += dgvPecaItem_CellClick;
            // 
            // btnRemPecaItem
            // 
            btnRemPecaItem.ForeColor = SystemColors.ActiveCaptionText;
            btnRemPecaItem.Location = new Point(400, 40);
            btnRemPecaItem.Name = "btnRemPecaItem";
            btnRemPecaItem.Size = new Size(50, 30);
            btnRemPecaItem.TabIndex = 4;
            btnRemPecaItem.Text = "Rem";
            btnRemPecaItem.UseVisualStyleBackColor = true;
            btnRemPecaItem.Click += btnRemPecaItem_Click;
            // 
            // btnAddPecaItem
            // 
            btnAddPecaItem.ForeColor = SystemColors.ActiveCaptionText;
            btnAddPecaItem.Location = new Point(340, 40);
            btnAddPecaItem.Name = "btnAddPecaItem";
            btnAddPecaItem.Size = new Size(50, 30);
            btnAddPecaItem.TabIndex = 4;
            btnAddPecaItem.Text = "Add";
            btnAddPecaItem.UseVisualStyleBackColor = true;
            btnAddPecaItem.Click += btnAddPecaItem_Click;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Enabled = false;
            txtValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorTotal.Location = new Point(160, 810);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(320, 29);
            txtValorTotal.TabIndex = 0;
            // 
            // btnValorTotal
            // 
            btnValorTotal.Enabled = false;
            btnValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValorTotal.Location = new Point(10, 810);
            btnValorTotal.Name = "btnValorTotal";
            btnValorTotal.Size = new Size(140, 30);
            btnValorTotal.TabIndex = 6;
            btnValorTotal.Text = "Valor Total R$:";
            btnValorTotal.UseVisualStyleBackColor = true;
            // 
            // gpbDescricaoEncerramento
            // 
            gpbDescricaoEncerramento.BackColor = Color.Transparent;
            gpbDescricaoEncerramento.Controls.Add(rtxDescricaoEncerramento);
            gpbDescricaoEncerramento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDescricaoEncerramento.ForeColor = SystemColors.ActiveCaption;
            gpbDescricaoEncerramento.Location = new Point(504, 653);
            gpbDescricaoEncerramento.Name = "gpbDescricaoEncerramento";
            gpbDescricaoEncerramento.Size = new Size(470, 140);
            gpbDescricaoEncerramento.TabIndex = 2;
            gpbDescricaoEncerramento.TabStop = false;
            gpbDescricaoEncerramento.Text = "Descrição Encerramento";
            // 
            // rtxDescricaoEncerramento
            // 
            rtxDescricaoEncerramento.Enabled = false;
            rtxDescricaoEncerramento.Location = new Point(20, 40);
            rtxDescricaoEncerramento.Name = "rtxDescricaoEncerramento";
            rtxDescricaoEncerramento.Size = new Size(430, 80);
            rtxDescricaoEncerramento.TabIndex = 2;
            rtxDescricaoEncerramento.Text = "";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(954, 1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(30, 30);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // cbbSituacaoOS
            // 
            cbbSituacaoOS.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbSituacaoOS.Enabled = false;
            cbbSituacaoOS.FormattingEnabled = true;
            cbbSituacaoOS.Location = new Point(34, 147);
            cbbSituacaoOS.Name = "cbbSituacaoOS";
            cbbSituacaoOS.Size = new Size(100, 23);
            cbbSituacaoOS.TabIndex = 7;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(lblTitulo);
            cuiGradientPanel1.Controls.Add(cbbCpfcnpj);
            cuiGradientPanel1.Controls.Add(cbbCliente);
            cuiGradientPanel1.Controls.Add(label11);
            cuiGradientPanel1.Controls.Add(gpbPecaItem);
            cuiGradientPanel1.Controls.Add(gpbDescricaoEncerramento);
            cuiGradientPanel1.Controls.Add(txtSequencia);
            cuiGradientPanel1.Controls.Add(gpbDescricaoGeral);
            cuiGradientPanel1.Controls.Add(label9);
            cuiGradientPanel1.Controls.Add(gpbServicos);
            cuiGradientPanel1.Controls.Add(cbbEquipamento);
            cuiGradientPanel1.Controls.Add(lblSequencia);
            cuiGradientPanel1.Controls.Add(btnFechar);
            cuiGradientPanel1.Controls.Add(txtModelo);
            cuiGradientPanel1.Controls.Add(label10);
            cuiGradientPanel1.Controls.Add(cbbSituacaoOS);
            cuiGradientPanel1.Controls.Add(lblSituacao);
            cuiGradientPanel1.Controls.Add(label8);
            cuiGradientPanel1.Controls.Add(txtDtEncerramento);
            cuiGradientPanel1.Controls.Add(txtDtInclusao);
            cuiGradientPanel1.Controls.Add(lblDtInclusao);
            cuiGradientPanel1.Controls.Add(lblEncerramento);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-4, 0);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(0);
            cuiGradientPanel1.Size = new Size(991, 862);
            cuiGradientPanel1.TabIndex = 12;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 40F);
            lblTitulo.Location = new Point(241, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(520, 72);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "ORDEM DE SERVIÇO";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OrdemServicoCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(980, 854);
            Controls.Add(btnValorTotal);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtValorTotal);
            Controls.Add(cuiGradientPanel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrdemServicoCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdemServicoCad";
            Load += OrdemServicoCad_Load;
            gpbServicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServico).EndInit();
            gpbDescricaoGeral.ResumeLayout(false);
            gpbPecaItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPecaItem).EndInit();
            gpbDescricaoEncerramento.ResumeLayout(false);
            cuiGradientPanel1.ResumeLayout(false);
            cuiGradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSequencia;
        private Label lblSequencia;
        private TextBox txtDtInclusao;
        private Label lblDtInclusao;
        private Label lblSituacao;
        private TextBox txtDtEncerramento;
        private Label lblEncerramento;
        private Label label11;
        private TextBox txtModelo;
        private Label label10;
        private Label label9;
        private Label label8;
        private GroupBox gpbServicos;
        private DataGridView dgvServico;
        private Button btnAddServico;
        private GroupBox gpbDescricaoGeral;
        private Button btnCancelar;
        private Button btnSalvar;
        private GroupBox gpbPecaItem;
        private DataGridView dgvPecaItem;
        private Button btnAddPecaItem;
        private TextBox txtValorTotal;
        private Button btnValorTotal;
        private RichTextBox rtxDescricaoGeral;
        private GroupBox gpbDescricaoEncerramento;
        private RichTextBox rtxDescricaoEncerramento;
        private ComboBox cbbServico;
        private ComboBox cbbPecaItem;
        private ComboBox cbbCpfcnpj;
        private ComboBox cbbEquipamento;
        private ComboBox cbbCliente;
        private Button btnFechar;
        private Button btnRemServico;
        private Button btnRemPecaItem;
        private ComboBox cbbSituacaoOS;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private Label lblTitulo;
    }
}
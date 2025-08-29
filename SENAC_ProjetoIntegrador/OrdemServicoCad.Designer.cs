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
            txtDtAlteracao = new TextBox();
            lblSituacao = new Label();
            txtDtEncerramento = new TextBox();
            lblEncerramento = new Label();
            gpbInformacoes = new GroupBox();
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
            lblTitulo = new Label();
            gpbInformacoes.SuspendLayout();
            gpbServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServico).BeginInit();
            gpbDescricaoGeral.SuspendLayout();
            gpbPecaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPecaItem).BeginInit();
            gpbDescricaoEncerramento.SuspendLayout();
            SuspendLayout();
            // 
            // txtSequencia
            // 
            txtSequencia.Location = new Point(20, 40);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(100, 23);
            txtSequencia.TabIndex = 0;
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSequencia.ForeColor = SystemColors.ActiveCaption;
            lblSequencia.Location = new Point(20, 20);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(81, 21);
            lblSequencia.TabIndex = 1;
            lblSequencia.Text = "Sequência";
            // 
            // txtDtInclusao
            // 
            txtDtInclusao.Location = new Point(840, 40);
            txtDtInclusao.Name = "txtDtInclusao";
            txtDtInclusao.Size = new Size(110, 23);
            txtDtInclusao.TabIndex = 0;
            // 
            // lblDtInclusao
            // 
            lblDtInclusao.AutoSize = true;
            lblDtInclusao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDtInclusao.ForeColor = SystemColors.ActiveCaption;
            lblDtInclusao.Location = new Point(840, 20);
            lblDtInclusao.Name = "lblDtInclusao";
            lblDtInclusao.Size = new Size(67, 21);
            lblDtInclusao.TabIndex = 1;
            lblDtInclusao.Text = "Inclusão";
            // 
            // txtDtAlteracao
            // 
            txtDtAlteracao.Location = new Point(20, 100);
            txtDtAlteracao.Name = "txtDtAlteracao";
            txtDtAlteracao.Size = new Size(100, 23);
            txtDtAlteracao.TabIndex = 0;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSituacao.ForeColor = SystemColors.ActiveCaption;
            lblSituacao.Location = new Point(20, 80);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(69, 21);
            lblSituacao.TabIndex = 1;
            lblSituacao.Text = "Situação";
            // 
            // txtDtEncerramento
            // 
            txtDtEncerramento.Location = new Point(840, 100);
            txtDtEncerramento.Name = "txtDtEncerramento";
            txtDtEncerramento.Size = new Size(110, 23);
            txtDtEncerramento.TabIndex = 0;
            // 
            // lblEncerramento
            // 
            lblEncerramento.AutoSize = true;
            lblEncerramento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEncerramento.ForeColor = SystemColors.ActiveCaption;
            lblEncerramento.Location = new Point(840, 80);
            lblEncerramento.Name = "lblEncerramento";
            lblEncerramento.Size = new Size(107, 21);
            lblEncerramento.TabIndex = 1;
            lblEncerramento.Text = "Encerramento";
            // 
            // gpbInformacoes
            // 
            gpbInformacoes.Controls.Add(cbbCpfcnpj);
            gpbInformacoes.Controls.Add(cbbEquipamento);
            gpbInformacoes.Controls.Add(cbbCliente);
            gpbInformacoes.Controls.Add(label11);
            gpbInformacoes.Controls.Add(txtModelo);
            gpbInformacoes.Controls.Add(label10);
            gpbInformacoes.Controls.Add(label9);
            gpbInformacoes.Controls.Add(label8);
            gpbInformacoes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbInformacoes.ForeColor = SystemColors.ActiveCaption;
            gpbInformacoes.Location = new Point(10, 160);
            gpbInformacoes.Name = "gpbInformacoes";
            gpbInformacoes.Size = new Size(960, 180);
            gpbInformacoes.TabIndex = 2;
            gpbInformacoes.TabStop = false;
            gpbInformacoes.Text = "Informações";
            // 
            // cbbCpfcnpj
            // 
            cbbCpfcnpj.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCpfcnpj.FormattingEnabled = true;
            cbbCpfcnpj.Location = new Point(530, 140);
            cbbCpfcnpj.Name = "cbbCpfcnpj";
            cbbCpfcnpj.Size = new Size(410, 29);
            cbbCpfcnpj.TabIndex = 7;
            // 
            // cbbEquipamento
            // 
            cbbEquipamento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbEquipamento.FormattingEnabled = true;
            cbbEquipamento.Location = new Point(20, 70);
            cbbEquipamento.Name = "cbbEquipamento";
            cbbEquipamento.Size = new Size(410, 29);
            cbbEquipamento.TabIndex = 7;
            // 
            // cbbCliente
            // 
            cbbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCliente.FormattingEnabled = true;
            cbbCliente.Location = new Point(20, 140);
            cbbCliente.Name = "cbbCliente";
            cbbCliente.Size = new Size(410, 29);
            cbbCliente.TabIndex = 7;
            cbbCliente.SelectedIndexChanged += cbbCliente_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaption;
            label11.Location = new Point(530, 110);
            label11.Name = "label11";
            label11.Size = new Size(87, 21);
            label11.TabIndex = 1;
            label11.Text = "CPF / CNPJ";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(530, 60);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(410, 29);
            txtModelo.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(530, 40);
            label10.Name = "label10";
            label10.Size = new Size(63, 21);
            label10.TabIndex = 1;
            label10.Text = "Modelo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(20, 110);
            label9.Name = "label9";
            label9.Size = new Size(58, 21);
            label9.TabIndex = 1;
            label9.Text = "Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(20, 40);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 1;
            label8.Text = "Equipamento";
            // 
            // gpbServicos
            // 
            gpbServicos.Controls.Add(cbbServico);
            gpbServicos.Controls.Add(dgvServico);
            gpbServicos.Controls.Add(btnRemServico);
            gpbServicos.Controls.Add(btnAddServico);
            gpbServicos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbServicos.ForeColor = SystemColors.ActiveCaption;
            gpbServicos.Location = new Point(10, 360);
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
            gpbDescricaoGeral.Controls.Add(rtxDescricaoGeral);
            gpbDescricaoGeral.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDescricaoGeral.ForeColor = SystemColors.ActiveCaption;
            gpbDescricaoGeral.Location = new Point(10, 650);
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
            gpbPecaItem.Controls.Add(cbbPecaItem);
            gpbPecaItem.Controls.Add(dgvPecaItem);
            gpbPecaItem.Controls.Add(btnRemPecaItem);
            gpbPecaItem.Controls.Add(btnAddPecaItem);
            gpbPecaItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbPecaItem.ForeColor = SystemColors.ActiveCaption;
            gpbPecaItem.Location = new Point(500, 360);
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
            txtValorTotal.Location = new Point(130, 810);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(350, 29);
            txtValorTotal.TabIndex = 0;
            // 
            // btnValorTotal
            // 
            btnValorTotal.Enabled = false;
            btnValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValorTotal.Location = new Point(10, 810);
            btnValorTotal.Name = "btnValorTotal";
            btnValorTotal.Size = new Size(110, 30);
            btnValorTotal.TabIndex = 6;
            btnValorTotal.Text = "Valor Total";
            btnValorTotal.UseVisualStyleBackColor = true;
            // 
            // gpbDescricaoEncerramento
            // 
            gpbDescricaoEncerramento.Controls.Add(rtxDescricaoEncerramento);
            gpbDescricaoEncerramento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDescricaoEncerramento.ForeColor = SystemColors.ActiveCaption;
            gpbDescricaoEncerramento.Location = new Point(500, 650);
            gpbDescricaoEncerramento.Name = "gpbDescricaoEncerramento";
            gpbDescricaoEncerramento.Size = new Size(470, 140);
            gpbDescricaoEncerramento.TabIndex = 2;
            gpbDescricaoEncerramento.TabStop = false;
            gpbDescricaoEncerramento.Text = "Descrição Encerramento";
            // 
            // rtxDescricaoEncerramento
            // 
            rtxDescricaoEncerramento.Location = new Point(20, 40);
            rtxDescricaoEncerramento.Name = "rtxDescricaoEncerramento";
            rtxDescricaoEncerramento.Size = new Size(430, 80);
            rtxDescricaoEncerramento.TabIndex = 2;
            rtxDescricaoEncerramento.Text = "";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(950, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(30, 30);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F);
            lblTitulo.ForeColor = SystemColors.ActiveCaption;
            lblTitulo.Location = new Point(350, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(275, 45);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Ordem de Serviço";
            // 
            // OrdemServicoCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(980, 854);
            Controls.Add(lblTitulo);
            Controls.Add(btnValorTotal);
            Controls.Add(btnSalvar);
            Controls.Add(btnFechar);
            Controls.Add(btnCancelar);
            Controls.Add(gpbPecaItem);
            Controls.Add(txtValorTotal);
            Controls.Add(gpbServicos);
            Controls.Add(gpbDescricaoEncerramento);
            Controls.Add(gpbDescricaoGeral);
            Controls.Add(gpbInformacoes);
            Controls.Add(lblEncerramento);
            Controls.Add(lblSituacao);
            Controls.Add(lblDtInclusao);
            Controls.Add(lblSequencia);
            Controls.Add(txtDtEncerramento);
            Controls.Add(txtDtAlteracao);
            Controls.Add(txtDtInclusao);
            Controls.Add(txtSequencia);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrdemServicoCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdemServicoCad";
            Load += OrdemServicoCad_Load;
            gpbInformacoes.ResumeLayout(false);
            gpbInformacoes.PerformLayout();
            gpbServicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServico).EndInit();
            gpbDescricaoGeral.ResumeLayout(false);
            gpbPecaItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPecaItem).EndInit();
            gpbDescricaoEncerramento.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSequencia;
        private Label lblSequencia;
        private TextBox txtDtInclusao;
        private Label lblDtInclusao;
        private TextBox txtDtAlteracao;
        private Label lblSituacao;
        private TextBox txtDtEncerramento;
        private Label lblEncerramento;
        private GroupBox gpbInformacoes;
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
        private Label lblTitulo;
    }
}
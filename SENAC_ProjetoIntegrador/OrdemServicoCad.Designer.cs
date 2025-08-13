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
            txtEmissor = new TextBox();
            lblEmissor = new Label();
            txtDtInclusao = new TextBox();
            lblDtInclusao = new Label();
            txtDtAlteracao = new TextBox();
            lblDtAlteracao = new Label();
            txtDtEncerramento = new TextBox();
            lblEncerramento = new Label();
            txtResponsavel = new TextBox();
            lblResponsavel = new Label();
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
            btnValorServico = new Button();
            dataGridView1 = new DataGridView();
            btnAddServico = new Button();
            textBox12 = new TextBox();
            gpbDescricaoGeral = new GroupBox();
            richTextBox1 = new RichTextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            gpbPecaItem = new GroupBox();
            cbbPecaItem = new ComboBox();
            btnValorPecaitem = new Button();
            dataGridView2 = new DataGridView();
            btnAddPecaItem = new Button();
            textBox13 = new TextBox();
            textBox15 = new TextBox();
            btnValorTotal = new Button();
            gpbDescricaoEncerramento = new GroupBox();
            richTextBox2 = new RichTextBox();
            lblTitulo = new Label();
            btnFechar = new Button();
            gpbInformacoes.SuspendLayout();
            gpbServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gpbDescricaoGeral.SuspendLayout();
            gpbPecaItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            gpbDescricaoEncerramento.SuspendLayout();
            SuspendLayout();
            // 
            // txtSequencia
            // 
            txtSequencia.Location = new Point(20, 50);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(100, 23);
            txtSequencia.TabIndex = 0;
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSequencia.ForeColor = SystemColors.ActiveCaption;
            lblSequencia.Location = new Point(20, 30);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(81, 21);
            lblSequencia.TabIndex = 1;
            lblSequencia.Text = "Sequência";
            // 
            // txtEmissor
            // 
            txtEmissor.Location = new Point(20, 100);
            txtEmissor.Name = "txtEmissor";
            txtEmissor.Size = new Size(240, 23);
            txtEmissor.TabIndex = 0;
            // 
            // lblEmissor
            // 
            lblEmissor.AutoSize = true;
            lblEmissor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmissor.ForeColor = SystemColors.ActiveCaption;
            lblEmissor.Location = new Point(20, 80);
            lblEmissor.Name = "lblEmissor";
            lblEmissor.Size = new Size(65, 21);
            lblEmissor.TabIndex = 1;
            lblEmissor.Text = "Emissor";
            // 
            // txtDtInclusao
            // 
            txtDtInclusao.Location = new Point(850, 40);
            txtDtInclusao.Name = "txtDtInclusao";
            txtDtInclusao.Size = new Size(100, 23);
            txtDtInclusao.TabIndex = 0;
            // 
            // lblDtInclusao
            // 
            lblDtInclusao.AutoSize = true;
            lblDtInclusao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDtInclusao.ForeColor = SystemColors.ActiveCaption;
            lblDtInclusao.Location = new Point(850, 20);
            lblDtInclusao.Name = "lblDtInclusao";
            lblDtInclusao.Size = new Size(67, 21);
            lblDtInclusao.TabIndex = 1;
            lblDtInclusao.Text = "Inclusão";
            // 
            // txtDtAlteracao
            // 
            txtDtAlteracao.Location = new Point(850, 90);
            txtDtAlteracao.Name = "txtDtAlteracao";
            txtDtAlteracao.Size = new Size(100, 23);
            txtDtAlteracao.TabIndex = 0;
            // 
            // lblDtAlteracao
            // 
            lblDtAlteracao.AutoSize = true;
            lblDtAlteracao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDtAlteracao.ForeColor = SystemColors.ActiveCaption;
            lblDtAlteracao.Location = new Point(850, 70);
            lblDtAlteracao.Name = "lblDtAlteracao";
            lblDtAlteracao.Size = new Size(75, 21);
            lblDtAlteracao.TabIndex = 1;
            lblDtAlteracao.Text = "Alteração";
            // 
            // txtDtEncerramento
            // 
            txtDtEncerramento.Location = new Point(850, 140);
            txtDtEncerramento.Name = "txtDtEncerramento";
            txtDtEncerramento.Size = new Size(100, 23);
            txtDtEncerramento.TabIndex = 0;
            // 
            // lblEncerramento
            // 
            lblEncerramento.AutoSize = true;
            lblEncerramento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEncerramento.ForeColor = SystemColors.ActiveCaption;
            lblEncerramento.Location = new Point(850, 120);
            lblEncerramento.Name = "lblEncerramento";
            lblEncerramento.Size = new Size(107, 21);
            lblEncerramento.TabIndex = 1;
            lblEncerramento.Text = "Encerramento";
            // 
            // txtResponsavel
            // 
            txtResponsavel.Location = new Point(20, 150);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(240, 23);
            txtResponsavel.TabIndex = 0;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResponsavel.ForeColor = SystemColors.ActiveCaption;
            lblResponsavel.Location = new Point(20, 130);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(97, 21);
            lblResponsavel.TabIndex = 1;
            lblResponsavel.Text = "Responsável";
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
            gpbInformacoes.Location = new Point(10, 190);
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
            gpbServicos.Controls.Add(btnValorServico);
            gpbServicos.Controls.Add(dataGridView1);
            gpbServicos.Controls.Add(btnAddServico);
            gpbServicos.Controls.Add(textBox12);
            gpbServicos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbServicos.ForeColor = SystemColors.ActiveCaption;
            gpbServicos.Location = new Point(10, 380);
            gpbServicos.Name = "gpbServicos";
            gpbServicos.Size = new Size(470, 310);
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
            cbbServico.Size = new Size(370, 29);
            cbbServico.TabIndex = 7;
            // 
            // btnValorServico
            // 
            btnValorServico.Location = new Point(20, 270);
            btnValorServico.Name = "btnValorServico";
            btnValorServico.Size = new Size(70, 30);
            btnValorServico.TabIndex = 6;
            btnValorServico.Text = "Valor";
            btnValorServico.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(430, 180);
            dataGridView1.TabIndex = 5;
            // 
            // btnAddServico
            // 
            btnAddServico.Location = new Point(400, 40);
            btnAddServico.Name = "btnAddServico";
            btnAddServico.Size = new Size(50, 30);
            btnAddServico.TabIndex = 4;
            btnAddServico.Text = "Add";
            btnAddServico.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(100, 270);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(350, 29);
            textBox12.TabIndex = 0;
            // 
            // gpbDescricaoGeral
            // 
            gpbDescricaoGeral.Controls.Add(richTextBox1);
            gpbDescricaoGeral.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDescricaoGeral.ForeColor = SystemColors.ActiveCaption;
            gpbDescricaoGeral.Location = new Point(10, 700);
            gpbDescricaoGeral.Name = "gpbDescricaoGeral";
            gpbDescricaoGeral.Size = new Size(470, 140);
            gpbDescricaoGeral.TabIndex = 2;
            gpbDescricaoGeral.TabStop = false;
            gpbDescricaoGeral.Text = "Descrição Geral";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(20, 40);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(430, 80);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(770, 850);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 30);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(880, 850);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 30);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // gpbPecaItem
            // 
            gpbPecaItem.Controls.Add(cbbPecaItem);
            gpbPecaItem.Controls.Add(btnValorPecaitem);
            gpbPecaItem.Controls.Add(dataGridView2);
            gpbPecaItem.Controls.Add(btnAddPecaItem);
            gpbPecaItem.Controls.Add(textBox13);
            gpbPecaItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbPecaItem.ForeColor = SystemColors.ActiveCaption;
            gpbPecaItem.Location = new Point(500, 380);
            gpbPecaItem.Name = "gpbPecaItem";
            gpbPecaItem.Size = new Size(470, 310);
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
            cbbPecaItem.Size = new Size(370, 29);
            cbbPecaItem.TabIndex = 7;
            // 
            // btnValorPecaitem
            // 
            btnValorPecaitem.Location = new Point(20, 270);
            btnValorPecaitem.Name = "btnValorPecaitem";
            btnValorPecaitem.Size = new Size(70, 30);
            btnValorPecaitem.TabIndex = 6;
            btnValorPecaitem.Text = "Valor";
            btnValorPecaitem.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(20, 80);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(430, 180);
            dataGridView2.TabIndex = 5;
            // 
            // btnAddPecaItem
            // 
            btnAddPecaItem.Location = new Point(400, 40);
            btnAddPecaItem.Name = "btnAddPecaItem";
            btnAddPecaItem.Size = new Size(50, 30);
            btnAddPecaItem.TabIndex = 4;
            btnAddPecaItem.Text = "Add";
            btnAddPecaItem.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(100, 270);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(350, 29);
            textBox13.TabIndex = 0;
            // 
            // textBox15
            // 
            textBox15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox15.Location = new Point(130, 850);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(350, 29);
            textBox15.TabIndex = 0;
            // 
            // btnValorTotal
            // 
            btnValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValorTotal.Location = new Point(10, 850);
            btnValorTotal.Name = "btnValorTotal";
            btnValorTotal.Size = new Size(110, 30);
            btnValorTotal.TabIndex = 6;
            btnValorTotal.Text = "Valor Total";
            btnValorTotal.UseVisualStyleBackColor = true;
            // 
            // gpbDescricaoEncerramento
            // 
            gpbDescricaoEncerramento.Controls.Add(richTextBox2);
            gpbDescricaoEncerramento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbDescricaoEncerramento.ForeColor = SystemColors.ActiveCaption;
            gpbDescricaoEncerramento.Location = new Point(500, 700);
            gpbDescricaoEncerramento.Name = "gpbDescricaoEncerramento";
            gpbDescricaoEncerramento.Size = new Size(470, 140);
            gpbDescricaoEncerramento.TabIndex = 2;
            gpbDescricaoEncerramento.TabStop = false;
            gpbDescricaoEncerramento.Text = "Descrição Encerramento";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(20, 40);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(430, 80);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaption;
            lblTitulo.Location = new Point(430, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(135, 21);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Ordem de Serviço";
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
            // OrdemServicoCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(980, 900);
            Controls.Add(lblTitulo);
            Controls.Add(btnValorTotal);
            Controls.Add(btnSalvar);
            Controls.Add(btnFechar);
            Controls.Add(btnCancelar);
            Controls.Add(gpbPecaItem);
            Controls.Add(textBox15);
            Controls.Add(gpbServicos);
            Controls.Add(gpbDescricaoEncerramento);
            Controls.Add(gpbDescricaoGeral);
            Controls.Add(gpbInformacoes);
            Controls.Add(lblEncerramento);
            Controls.Add(lblDtAlteracao);
            Controls.Add(lblDtInclusao);
            Controls.Add(lblResponsavel);
            Controls.Add(lblEmissor);
            Controls.Add(lblSequencia);
            Controls.Add(txtDtEncerramento);
            Controls.Add(txtDtAlteracao);
            Controls.Add(txtDtInclusao);
            Controls.Add(txtResponsavel);
            Controls.Add(txtEmissor);
            Controls.Add(txtSequencia);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrdemServicoCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdemServicoCad";
            Load += OrdemServicoCad_Load;
            gpbInformacoes.ResumeLayout(false);
            gpbInformacoes.PerformLayout();
            gpbServicos.ResumeLayout(false);
            gpbServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gpbDescricaoGeral.ResumeLayout(false);
            gpbPecaItem.ResumeLayout(false);
            gpbPecaItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            gpbDescricaoEncerramento.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSequencia;
        private Label lblSequencia;
        private TextBox txtEmissor;
        private Label lblEmissor;
        private TextBox txtDtInclusao;
        private Label lblDtInclusao;
        private TextBox txtDtAlteracao;
        private Label lblDtAlteracao;
        private TextBox txtDtEncerramento;
        private Label lblEncerramento;
        private TextBox txtResponsavel;
        private Label lblResponsavel;
        private GroupBox gpbInformacoes;
        private Label label11;
        private TextBox txtModelo;
        private Label label10;
        private Label label9;
        private Label label8;
        private GroupBox gpbServicos;
        private DataGridView dataGridView1;
        private Button btnAddServico;
        private TextBox textBox12;
        private GroupBox gpbDescricaoGeral;
        private Button btnCancelar;
        private Button btnSalvar;
        private Button btnValorServico;
        private GroupBox gpbPecaItem;
        private Button btnValorPecaitem;
        private DataGridView dataGridView2;
        private Button btnAddPecaItem;
        private TextBox textBox13;
        private TextBox textBox15;
        private Button btnValorTotal;
        private RichTextBox richTextBox1;
        private GroupBox gpbDescricaoEncerramento;
        private RichTextBox richTextBox2;
        private Label lblTitulo;
        private ComboBox cbbServico;
        private ComboBox cbbPecaItem;
        private ComboBox cbbCpfcnpj;
        private ComboBox cbbEquipamento;
        private ComboBox cbbCliente;
        private Button btnFechar;
    }
}
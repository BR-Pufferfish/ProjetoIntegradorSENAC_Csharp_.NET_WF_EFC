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
            btnAdicionarVenda = new Button();
            btnRemoverVenda = new Button();
            dataGridView1 = new DataGridView();
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
            txtEquipamento = new TextBox();
            txtCpfCnpj = new TextBox();
            txtPagamento = new TextBox();
            txtValorServico = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.Font = new Font("Segoe UI", 16F);
            lblVenda.Location = new Point(253, 32);
            lblVenda.Margin = new Padding(2, 0, 2, 0);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(180, 30);
            lblVenda.TabIndex = 1;
            lblVenda.Text = "Ordem de Venda";
            // 
            // lblEmissor
            // 
            lblEmissor.AutoSize = true;
            lblEmissor.Location = new Point(37, 71);
            lblEmissor.Margin = new Padding(2, 0, 2, 0);
            lblEmissor.Name = "lblEmissor";
            lblEmissor.Size = new Size(48, 15);
            lblEmissor.TabIndex = 3;
            lblEmissor.Text = "Emissor";
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(36, 167);
            lblTipoPessoa.Margin = new Padding(2, 0, 2, 0);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(69, 15);
            lblTipoPessoa.TabIndex = 4;
            lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // dtInclusao
            // 
            dtInclusao.AutoSize = true;
            dtInclusao.Location = new Point(568, 26);
            dtInclusao.Margin = new Padding(2, 0, 2, 0);
            dtInclusao.Name = "dtInclusao";
            dtInclusao.Size = new Size(67, 15);
            dtInclusao.TabIndex = 5;
            dtInclusao.Text = "DT Inclusão";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(38, 119);
            lblCliente.Margin = new Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 7;
            lblCliente.Text = "Cliente";
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(434, 119);
            lblCpfCnpj.Margin = new Padding(2, 0, 2, 0);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(60, 15);
            lblCpfCnpj.TabIndex = 7;
            lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // lvlValorServico
            // 
            lvlValorServico.AutoSize = true;
            lvlValorServico.Location = new Point(38, 401);
            lvlValorServico.Margin = new Padding(2, 0, 2, 0);
            lvlValorServico.Name = "lvlValorServico";
            lvlValorServico.Size = new Size(119, 15);
            lvlValorServico.TabIndex = 7;
            lvlValorServico.Text = "Valor Total do Serviço";
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.Location = new Point(36, 26);
            lblSequencia.Margin = new Padding(2, 0, 2, 0);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(61, 15);
            lblSequencia.TabIndex = 7;
            lblSequencia.Text = "Sequência";
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Location = new Point(434, 167);
            lblPagamento.Margin = new Padding(2, 0, 2, 0);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(68, 15);
            lblPagamento.TabIndex = 7;
            lblPagamento.Text = "Pagamento";
            // 
            // btnAdicionarVenda
            // 
            btnAdicionarVenda.Location = new Point(401, 235);
            btnAdicionarVenda.Margin = new Padding(2);
            btnAdicionarVenda.Name = "btnAdicionarVenda";
            btnAdicionarVenda.Size = new Size(115, 25);
            btnAdicionarVenda.TabIndex = 8;
            btnAdicionarVenda.Text = "Adicionar";
            btnAdicionarVenda.UseVisualStyleBackColor = true;
            // 
            // btnRemoverVenda
            // 
            btnRemoverVenda.Location = new Point(530, 235);
            btnRemoverVenda.Margin = new Padding(2);
            btnRemoverVenda.Name = "btnRemoverVenda";
            btnRemoverVenda.Size = new Size(115, 25);
            btnRemoverVenda.TabIndex = 8;
            btnRemoverVenda.Text = "Remover";
            btnRemoverVenda.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 264);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(604, 135);
            dataGridView1.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(404, 417);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 25);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(530, 416);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 25);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblEquipamento
            // 
            lblEquipamento.AutoSize = true;
            lblEquipamento.Location = new Point(37, 218);
            lblEquipamento.Margin = new Padding(2, 0, 2, 0);
            lblEquipamento.Name = "lblEquipamento";
            lblEquipamento.Size = new Size(78, 15);
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
            btnFechar.Location = new Point(626, 7);
            btnFechar.Margin = new Padding(2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(33, 20);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Location = new Point(156, 167);
            lblRazaoSocial.Margin = new Padding(2, 0, 2, 0);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(72, 15);
            lblRazaoSocial.TabIndex = 4;
            lblRazaoSocial.Text = "Razão Social";
            // 
            // txtSequencia
            // 
            txtSequencia.Location = new Point(40, 50);
            txtSequencia.Margin = new Padding(2);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(106, 23);
            txtSequencia.TabIndex = 11;
            // 
            // txtEmissor
            // 
            txtEmissor.Location = new Point(40, 90);
            txtEmissor.Margin = new Padding(2);
            txtEmissor.Name = "txtEmissor";
            txtEmissor.Size = new Size(208, 23);
            txtEmissor.TabIndex = 11;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(40, 140);
            txtCliente.Margin = new Padding(2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(208, 23);
            txtCliente.TabIndex = 11;
            // 
            // txtTipoPessoa
            // 
            txtTipoPessoa.Location = new Point(40, 180);
            txtTipoPessoa.Margin = new Padding(2);
            txtTipoPessoa.Name = "txtTipoPessoa";
            txtTipoPessoa.Size = new Size(93, 23);
            txtTipoPessoa.TabIndex = 11;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(156, 187);
            txtRazaoSocial.Margin = new Padding(2);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(165, 23);
            txtRazaoSocial.TabIndex = 11;
            // 
            // txtEquipamento
            // 
            txtEquipamento.Location = new Point(38, 235);
            txtEquipamento.Margin = new Padding(2);
            txtEquipamento.Name = "txtEquipamento";
            txtEquipamento.Size = new Size(326, 23);
            txtEquipamento.TabIndex = 11;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(499, 119);
            txtCpfCnpj.Margin = new Padding(2);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(165, 23);
            txtCpfCnpj.TabIndex = 11;
            // 
            // txtPagamento
            // 
            txtPagamento.Location = new Point(502, 163);
            txtPagamento.Margin = new Padding(2);
            txtPagamento.Name = "txtPagamento";
            txtPagamento.Size = new Size(165, 23);
            txtPagamento.TabIndex = 11;
            // 
            // txtValorServico
            // 
            txtValorServico.Location = new Point(36, 421);
            txtValorServico.Margin = new Padding(2);
            txtValorServico.Name = "txtValorServico";
            txtValorServico.Size = new Size(326, 23);
            txtValorServico.TabIndex = 11;
            // 
            // VendaCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 448);
            Controls.Add(txtValorServico);
            Controls.Add(txtEquipamento);
            Controls.Add(txtCpfCnpj);
            Controls.Add(txtPagamento);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtTipoPessoa);
            Controls.Add(txtCliente);
            Controls.Add(txtEmissor);
            Controls.Add(txtSequencia);
            Controls.Add(btnFechar);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalvar);
            Controls.Add(btnRemoverVenda);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionarVenda);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "VendaCad";
            Text = "Tipo Pessoa";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btnAdicionarVenda;
        private Button btnRemoverVenda;
        private DataGridView dataGridView1;
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
        private TextBox txtEquipamento;
        private TextBox txtCpfCnpj;
        private TextBox txtPagamento;
        private TextBox txtValorServico;
    }
}
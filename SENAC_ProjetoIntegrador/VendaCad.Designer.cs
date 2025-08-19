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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BtnAdicionarVenda = new Button();
            BtnRemoverVenda = new Button();
            dataGridView1 = new DataGridView();
            button10 = new Button();
            button11 = new Button();
            label9 = new Label();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            BtnFecharVenda = new Button();
            label10 = new Label();
            TxtSequencia = new TextBox();
            TxtEmissor = new TextBox();
            TxtCliente = new TextBox();
            TxtTipoPessoa = new TextBox();
            TxtRazaoSocial = new TextBox();
            TxtEquipamento = new TextBox();
            TxtCPFCNPJ = new TextBox();
            TxtPagamento = new TextBox();
            TxtValorServico = new TextBox();
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
            lblVenda.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 71);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Emissor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 167);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Tipo Pessoa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(568, 26);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "DT Inclusão";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 119);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 7;
            label4.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 119);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "CPF/CNPJ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 401);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 7;
            label6.Text = "Valor Total do Serviço";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 26);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 7;
            label7.Text = "Sequência";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(434, 167);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 7;
            label8.Text = "Pagamento";
            // 
            // BtnAdicionarVenda
            // 
            BtnAdicionarVenda.Location = new Point(401, 235);
            BtnAdicionarVenda.Margin = new Padding(2, 2, 2, 2);
            BtnAdicionarVenda.Name = "BtnAdicionarVenda";
            BtnAdicionarVenda.Size = new Size(115, 25);
            BtnAdicionarVenda.TabIndex = 8;
            BtnAdicionarVenda.Text = "Adicionar";
            BtnAdicionarVenda.UseVisualStyleBackColor = true;
            // 
            // BtnRemoverVenda
            // 
            BtnRemoverVenda.Location = new Point(530, 235);
            BtnRemoverVenda.Margin = new Padding(2, 2, 2, 2);
            BtnRemoverVenda.Name = "BtnRemoverVenda";
            BtnRemoverVenda.Size = new Size(115, 25);
            BtnRemoverVenda.TabIndex = 8;
            BtnRemoverVenda.Text = "Remover";
            BtnRemoverVenda.UseVisualStyleBackColor = true;
            BtnRemoverVenda.Click += BtnRemoverVenda_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 264);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(604, 135);
            dataGridView1.TabIndex = 9;
            // 
            // button10
            // 
            button10.Location = new Point(404, 417);
            button10.Margin = new Padding(2, 2, 2, 2);
            button10.Name = "button10";
            button10.Size = new Size(115, 25);
            button10.TabIndex = 8;
            button10.Text = "Cancelar";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(530, 416);
            button11.Margin = new Padding(2, 2, 2, 2);
            button11.Name = "button11";
            button11.Size = new Size(115, 25);
            button11.TabIndex = 8;
            button11.Text = "Salvar";
            button11.UseVisualStyleBackColor = true;
            button11.Click += BtnRemoverVenda_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 218);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 7;
            label9.Text = "Equipamento";
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // BtnFecharVenda
            // 
            BtnFecharVenda.Location = new Point(626, 7);
            BtnFecharVenda.Margin = new Padding(2, 2, 2, 2);
            BtnFecharVenda.Name = "BtnFecharVenda";
            BtnFecharVenda.Size = new Size(33, 20);
            BtnFecharVenda.TabIndex = 10;
            BtnFecharVenda.Text = "X";
            BtnFecharVenda.UseVisualStyleBackColor = true;
            BtnFecharVenda.Click += BtnFecharVenda_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(156, 167);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 4;
            label10.Text = "Razão Social";
            label10.Click += label10_Click;
            // 
            // TxtSequencia
            // 
            TxtSequencia.Location = new Point(40, 50);
            TxtSequencia.Margin = new Padding(2, 2, 2, 2);
            TxtSequencia.Name = "TxtSequencia";
            TxtSequencia.Size = new Size(106, 23);
            TxtSequencia.TabIndex = 11;
            // 
            // TxtEmissor
            // 
            TxtEmissor.Location = new Point(40, 90);
            TxtEmissor.Margin = new Padding(2, 2, 2, 2);
            TxtEmissor.Name = "TxtEmissor";
            TxtEmissor.Size = new Size(208, 23);
            TxtEmissor.TabIndex = 11;
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(40, 140);
            TxtCliente.Margin = new Padding(2, 2, 2, 2);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(208, 23);
            TxtCliente.TabIndex = 11;
            // 
            // TxtTipoPessoa
            // 
            TxtTipoPessoa.Location = new Point(40, 180);
            TxtTipoPessoa.Margin = new Padding(2, 2, 2, 2);
            TxtTipoPessoa.Name = "TxtTipoPessoa";
            TxtTipoPessoa.Size = new Size(93, 23);
            TxtTipoPessoa.TabIndex = 11;
            // 
            // TxtRazaoSocial
            // 
            TxtRazaoSocial.Location = new Point(156, 187);
            TxtRazaoSocial.Margin = new Padding(2, 2, 2, 2);
            TxtRazaoSocial.Name = "TxtRazaoSocial";
            TxtRazaoSocial.Size = new Size(165, 23);
            TxtRazaoSocial.TabIndex = 11;
            TxtRazaoSocial.TextChanged += TxtRazaoSocial_TextChanged;
            // 
            // TxtEquipamento
            // 
            TxtEquipamento.Location = new Point(38, 235);
            TxtEquipamento.Margin = new Padding(2, 2, 2, 2);
            TxtEquipamento.Name = "TxtEquipamento";
            TxtEquipamento.Size = new Size(326, 23);
            TxtEquipamento.TabIndex = 11;
            TxtEquipamento.TextChanged += textBox1_TextChanged;
            // 
            // TxtCPFCNPJ
            // 
            TxtCPFCNPJ.Location = new Point(499, 119);
            TxtCPFCNPJ.Margin = new Padding(2, 2, 2, 2);
            TxtCPFCNPJ.Name = "TxtCPFCNPJ";
            TxtCPFCNPJ.Size = new Size(165, 23);
            TxtCPFCNPJ.TabIndex = 11;
            TxtCPFCNPJ.TextChanged += TxtRazaoSocial_TextChanged;
            // 
            // TxtPagamento
            // 
            TxtPagamento.Location = new Point(502, 163);
            TxtPagamento.Margin = new Padding(2, 2, 2, 2);
            TxtPagamento.Name = "TxtPagamento";
            TxtPagamento.Size = new Size(165, 23);
            TxtPagamento.TabIndex = 11;
            TxtPagamento.TextChanged += TxtRazaoSocial_TextChanged;
            // 
            // TxtValorServico
            // 
            TxtValorServico.Location = new Point(36, 421);
            TxtValorServico.Margin = new Padding(2, 2, 2, 2);
            TxtValorServico.Name = "TxtValorServico";
            TxtValorServico.Size = new Size(326, 23);
            TxtValorServico.TabIndex = 11;
            // 
            // VendaCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 448);
            Controls.Add(TxtValorServico);
            Controls.Add(TxtEquipamento);
            Controls.Add(TxtCPFCNPJ);
            Controls.Add(TxtPagamento);
            Controls.Add(TxtRazaoSocial);
            Controls.Add(TxtTipoPessoa);
            Controls.Add(TxtCliente);
            Controls.Add(TxtEmissor);
            Controls.Add(TxtSequencia);
            Controls.Add(BtnFecharVenda);
            Controls.Add(dataGridView1);
            Controls.Add(button11);
            Controls.Add(BtnRemoverVenda);
            Controls.Add(button10);
            Controls.Add(BtnAdicionarVenda);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblVenda);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "VendaCad";
            Text = "Tipo Pessoa";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblVenda;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button BtnAdicionarVenda;
        private Button BtnRemoverVenda;
        private DataGridView dataGridView1;
        private Button button10;
        private Button button11;
        private Label label9;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Button BtnFecharVenda;
        private Label label10;
        private TextBox TxtSequencia;
        private TextBox TxtEmissor;
        private TextBox TxtCliente;
        private TextBox TxtTipoPessoa;
        private TextBox TxtRazaoSocial;
        private TextBox TxtEquipamento;
        private TextBox TxtCPFCNPJ;
        private TextBox TxtPagamento;
        private TextBox TxtValorServico;
    }
}
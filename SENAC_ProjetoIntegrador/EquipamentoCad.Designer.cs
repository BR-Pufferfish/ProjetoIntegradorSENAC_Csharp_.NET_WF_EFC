namespace SENAC_ProjetoIntegrador
{
    partial class EquipamentoCad
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
            groupBox5 = new GroupBox();
            txtDescricao = new RichTextBox();
            txtLucro = new TextBox();
            txtValor = new TextBox();
            txtCusto = new TextBox();
            lblDescricao = new Label();
            lblLucro = new Label();
            lblValor = new Label();
            lblCusto = new Label();
            groupBox4 = new GroupBox();
            cbbTipoEquipamento = new ComboBox();
            txtNCM = new TextBox();
            txtCodigodeBarra = new TextBox();
            txtAno = new TextBox();
            txtModelo = new TextBox();
            txtNome = new TextBox();
            lblNCM = new Label();
            lblCodigodeBarra = new Label();
            lblAno = new Label();
            lblTipoEquipamento = new Label();
            lblModelo = new Label();
            lblNome = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            groupBox3 = new GroupBox();
            lblSituacao = new Label();
            txtSituacao = new TextBox();
            txtAlteracao = new TextBox();
            txtInclusao = new TextBox();
            lblAlteracao = new Label();
            lblDtInclusao = new Label();
            groupBox2 = new GroupBox();
            txtUsuarioAlteracao = new TextBox();
            txtUsuarioInclusao = new TextBox();
            txtSequencia = new TextBox();
            lblUsuarioAltercao = new Label();
            lblUsuarioInclusao = new Label();
            lblSequencia = new Label();
            lblEquipamento = new Label();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(7, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1094, 630);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtDescricao);
            groupBox5.Controls.Add(txtLucro);
            groupBox5.Controls.Add(txtValor);
            groupBox5.Controls.Add(txtCusto);
            groupBox5.Controls.Add(lblDescricao);
            groupBox5.Controls.Add(lblLucro);
            groupBox5.Controls.Add(lblValor);
            groupBox5.Controls.Add(lblCusto);
            groupBox5.Location = new Point(8, 383);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1080, 193);
            groupBox5.TabIndex = 41;
            groupBox5.TabStop = false;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(18, 95);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1042, 80);
            txtDescricao.TabIndex = 43;
            txtDescricao.Text = "";
            // 
            // txtLucro
            // 
            txtLucro.Location = new Point(355, 32);
            txtLucro.Name = "txtLucro";
            txtLucro.Size = new Size(128, 31);
            txtLucro.TabIndex = 42;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(191, 33);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(128, 31);
            txtValor.TabIndex = 41;
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(27, 32);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(128, 31);
            txtCusto.TabIndex = 40;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(24, 69);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(88, 25);
            lblDescricao.TabIndex = 39;
            lblDescricao.Text = "Descrição";
            // 
            // lblLucro
            // 
            lblLucro.AutoSize = true;
            lblLucro.Location = new Point(357, 8);
            lblLucro.Name = "lblLucro";
            lblLucro.Size = new Size(55, 25);
            lblLucro.TabIndex = 38;
            lblLucro.Text = "Lucro";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(191, 7);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(52, 25);
            lblValor.TabIndex = 37;
            lblValor.Text = "Valor";
            // 
            // lblCusto
            // 
            lblCusto.AutoSize = true;
            lblCusto.Location = new Point(25, 7);
            lblCusto.Name = "lblCusto";
            lblCusto.Size = new Size(58, 25);
            lblCusto.TabIndex = 36;
            lblCusto.Text = "Custo";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbbTipoEquipamento);
            groupBox4.Controls.Add(txtNCM);
            groupBox4.Controls.Add(txtCodigodeBarra);
            groupBox4.Controls.Add(txtAno);
            groupBox4.Controls.Add(txtModelo);
            groupBox4.Controls.Add(txtNome);
            groupBox4.Controls.Add(lblNCM);
            groupBox4.Controls.Add(lblCodigodeBarra);
            groupBox4.Controls.Add(lblAno);
            groupBox4.Controls.Add(lblTipoEquipamento);
            groupBox4.Controls.Add(lblModelo);
            groupBox4.Controls.Add(lblNome);
            groupBox4.Location = new Point(6, 234);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1082, 143);
            groupBox4.TabIndex = 40;
            groupBox4.TabStop = false;
            // 
            // cbbTipoEquipamento
            // 
            cbbTipoEquipamento.FormattingEnabled = true;
            cbbTipoEquipamento.Location = new Point(891, 44);
            cbbTipoEquipamento.Name = "cbbTipoEquipamento";
            cbbTipoEquipamento.Size = new Size(171, 33);
            cbbTipoEquipamento.TabIndex = 44;
            // 
            // txtNCM
            // 
            txtNCM.Location = new Point(618, 104);
            txtNCM.Name = "txtNCM";
            txtNCM.Size = new Size(444, 31);
            txtNCM.TabIndex = 43;
            // 
            // txtCodigodeBarra
            // 
            txtCodigodeBarra.Location = new Point(165, 104);
            txtCodigodeBarra.Name = "txtCodigodeBarra";
            txtCodigodeBarra.Size = new Size(431, 31);
            txtCodigodeBarra.TabIndex = 42;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(1, 104);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(128, 31);
            txtAno.TabIndex = 41;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(509, 44);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(355, 31);
            txtModelo.TabIndex = 40;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(2, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(470, 31);
            txtNome.TabIndex = 39;
            // 
            // lblNCM
            // 
            lblNCM.AutoSize = true;
            lblNCM.Location = new Point(619, 76);
            lblNCM.Name = "lblNCM";
            lblNCM.Size = new Size(52, 25);
            lblNCM.TabIndex = 38;
            lblNCM.Text = "NCM";
            // 
            // lblCodigodeBarra
            // 
            lblCodigodeBarra.AutoSize = true;
            lblCodigodeBarra.Location = new Point(165, 76);
            lblCodigodeBarra.Name = "lblCodigodeBarra";
            lblCodigodeBarra.Size = new Size(141, 25);
            lblCodigodeBarra.TabIndex = 37;
            lblCodigodeBarra.Text = "Código de Barra";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(1, 76);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(45, 25);
            lblAno.TabIndex = 36;
            lblAno.Text = "Ano";
            // 
            // lblTipoEquipamento
            // 
            lblTipoEquipamento.AutoSize = true;
            lblTipoEquipamento.Location = new Point(891, 16);
            lblTipoEquipamento.Name = "lblTipoEquipamento";
            lblTipoEquipamento.Size = new Size(158, 25);
            lblTipoEquipamento.TabIndex = 35;
            lblTipoEquipamento.Text = "Tipo Equipamento";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(509, 17);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(74, 25);
            lblModelo.TabIndex = 34;
            lblModelo.Text = "Modelo";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(1, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 33;
            lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(917, 582);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(160, 42);
            btnSalvar.TabIndex = 37;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(751, 582);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 42);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblSituacao);
            groupBox3.Controls.Add(txtSituacao);
            groupBox3.Controls.Add(txtAlteracao);
            groupBox3.Controls.Add(txtInclusao);
            groupBox3.Controls.Add(lblAlteracao);
            groupBox3.Controls.Add(lblDtInclusao);
            groupBox3.Location = new Point(956, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(132, 205);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(27, 134);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(79, 25);
            lblSituacao.TabIndex = 26;
            lblSituacao.Text = "Situação";
            // 
            // txtSituacao
            // 
            txtSituacao.Location = new Point(20, 162);
            txtSituacao.Name = "txtSituacao";
            txtSituacao.Size = new Size(92, 31);
            txtSituacao.TabIndex = 30;
            // 
            // txtAlteracao
            // 
            txtAlteracao.Location = new Point(21, 103);
            txtAlteracao.Name = "txtAlteracao";
            txtAlteracao.Size = new Size(91, 31);
            txtAlteracao.TabIndex = 29;
            // 
            // txtInclusao
            // 
            txtInclusao.Location = new Point(20, 40);
            txtInclusao.Name = "txtInclusao";
            txtInclusao.Size = new Size(92, 31);
            txtInclusao.TabIndex = 28;
            // 
            // lblAlteracao
            // 
            lblAlteracao.AutoSize = true;
            lblAlteracao.Location = new Point(11, 75);
            lblAlteracao.Name = "lblAlteracao";
            lblAlteracao.Size = new Size(110, 25);
            lblAlteracao.TabIndex = 27;
            lblAlteracao.Text = "Dt Alteração";
            // 
            // lblDtInclusao
            // 
            lblDtInclusao.AutoSize = true;
            lblDtInclusao.Location = new Point(11, 12);
            lblDtInclusao.Name = "lblDtInclusao";
            lblDtInclusao.Size = new Size(101, 25);
            lblDtInclusao.TabIndex = 25;
            lblDtInclusao.Text = "Dt Inclusão";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtUsuarioAlteracao);
            groupBox2.Controls.Add(txtUsuarioInclusao);
            groupBox2.Controls.Add(txtSequencia);
            groupBox2.Controls.Add(lblUsuarioAltercao);
            groupBox2.Controls.Add(lblUsuarioInclusao);
            groupBox2.Controls.Add(lblSequencia);
            groupBox2.Location = new Point(6, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(511, 205);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            // 
            // txtUsuarioAlteracao
            // 
            txtUsuarioAlteracao.Location = new Point(13, 160);
            txtUsuarioAlteracao.Name = "txtUsuarioAlteracao";
            txtUsuarioAlteracao.Size = new Size(470, 31);
            txtUsuarioAlteracao.TabIndex = 27;
            // 
            // txtUsuarioInclusao
            // 
            txtUsuarioInclusao.Location = new Point(14, 99);
            txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            txtUsuarioInclusao.Size = new Size(469, 31);
            txtUsuarioInclusao.TabIndex = 26;
            // 
            // txtSequencia
            // 
            txtSequencia.Location = new Point(14, 40);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(91, 31);
            txtSequencia.TabIndex = 25;
            // 
            // lblUsuarioAltercao
            // 
            lblUsuarioAltercao.AutoSize = true;
            lblUsuarioAltercao.Location = new Point(13, 133);
            lblUsuarioAltercao.Name = "lblUsuarioAltercao";
            lblUsuarioAltercao.Size = new Size(151, 25);
            lblUsuarioAltercao.TabIndex = 24;
            lblUsuarioAltercao.Text = "Usuário Alteração";
            // 
            // lblUsuarioInclusao
            // 
            lblUsuarioInclusao.AutoSize = true;
            lblUsuarioInclusao.Location = new Point(13, 73);
            lblUsuarioInclusao.Name = "lblUsuarioInclusao";
            lblUsuarioInclusao.Size = new Size(142, 25);
            lblUsuarioInclusao.TabIndex = 23;
            lblUsuarioInclusao.Text = "Usuário Inclusão";
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.Location = new Point(13, 14);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(92, 25);
            lblSequencia.TabIndex = 22;
            lblSequencia.Text = "Sequência";
            // 
            // lblEquipamento
            // 
            lblEquipamento.AutoSize = true;
            lblEquipamento.Location = new Point(500, 20);
            lblEquipamento.Name = "lblEquipamento";
            lblEquipamento.Size = new Size(133, 25);
            lblEquipamento.TabIndex = 2;
            lblEquipamento.Text = "EQUIPAMENTO";
            // 
            // EquipamentoCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 690);
            Controls.Add(groupBox1);
            Controls.Add(lblEquipamento);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EquipamentoCad";
            Text = "EquipamentoCad";
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private RichTextBox txtDescricao;
        private TextBox txtLucro;
        private TextBox txtValor;
        private TextBox txtCusto;
        private Label lblDescricao;
        private Label lblLucro;
        private Label lblValor;
        private Label lblCusto;
        private GroupBox groupBox4;
        private ComboBox cbbTipoEquipamento;
        private TextBox txtNCM;
        private TextBox txtCodigodeBarra;
        private TextBox txtAno;
        private TextBox txtModelo;
        private TextBox txtNome;
        private Label lblNCM;
        private Label lblCodigodeBarra;
        private Label lblAno;
        private Label lblTipoEquipamento;
        private Label lblModelo;
        private Label lblNome;
        private Button btnSalvar;
        private Button btnCancelar;
        private GroupBox groupBox3;
        private Label lblSituacao;
        private TextBox txtSituacao;
        private TextBox txtAlteracao;
        private TextBox txtInclusao;
        private Label lblAlteracao;
        private Label lblDtInclusao;
        private GroupBox groupBox2;
        private TextBox txtUsuarioAlteracao;
        private TextBox txtUsuarioInclusao;
        private TextBox txtSequencia;
        private Label lblUsuarioAltercao;
        private Label lblUsuarioInclusao;
        private Label lblSequencia;
        private Label lblEquipamento;
    }
}
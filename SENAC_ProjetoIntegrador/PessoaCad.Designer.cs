namespace SENAC_ProjetoIntegrador
{
    partial class PessoaCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PessoaCad));
            cbbSituacao = new ComboBox();
            lblSituacao = new Label();
            lblDtInclusao = new Label();
            label26 = new Label();
            lblSequencia = new Label();
            DTAlteracao = new TextBox();
            txtSequencia = new TextBox();
            btnFechar = new Button();
            lblNome = new Label();
            lblCpfCnpj = new Label();
            lblCargo = new Label();
            lblAno = new Label();
            lblTipoPessoa = new Label();
            lblGenero = new Label();
            lblRazaoSoc = new Label();
            txtNome = new TextBox();
            txtCpfCnpj = new TextBox();
            txtCargo = new TextBox();
            txtRazaoSoc = new TextBox();
            cbbGenero = new ComboBox();
            cbbTipoPessoa = new ComboBox();
            txtSenha = new TextBox();
            txtAnoNasc = new TextBox();
            lblSenha = new Label();
            txtEstado = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtEmail = new TextBox();
            txtFone = new TextBox();
            txtCelular = new TextBox();
            txtPais = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtDDD = new TextBox();
            txtEndereco = new TextBox();
            txtCep = new TextBox();
            lblCep = new Label();
            lblBairro = new Label();
            lblCidade = new Label();
            lblEstado = new Label();
            lblPais = new Label();
            lblNumero = new Label();
            lblComplemento = new Label();
            lblEmail = new Label();
            lblFone = new Label();
            lblCelular = new Label();
            lblDdd = new Label();
            lblEndereco = new Label();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            cuiGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbbSituacao
            // 
            cbbSituacao.FormattingEnabled = true;
            cbbSituacao.Location = new Point(60, 130);
            cbbSituacao.Name = "cbbSituacao";
            cbbSituacao.Size = new Size(190, 40);
            cbbSituacao.TabIndex = 16;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.BackColor = Color.Transparent;
            lblSituacao.Font = new Font("Segoe UI", 18F);
            lblSituacao.Location = new Point(60, 100);
            lblSituacao.Margin = new Padding(2, 0, 2, 0);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(104, 32);
            lblSituacao.TabIndex = 10;
            lblSituacao.Text = "Situação";
            // 
            // lblDtInclusao
            // 
            lblDtInclusao.AutoSize = true;
            lblDtInclusao.BackColor = Color.Transparent;
            lblDtInclusao.Font = new Font("Segoe UI", 18F);
            lblDtInclusao.Location = new Point(1200, 40);
            lblDtInclusao.Margin = new Padding(2, 0, 2, 0);
            lblDtInclusao.Name = "lblDtInclusao";
            lblDtInclusao.Size = new Size(137, 32);
            lblDtInclusao.TabIndex = 8;
            lblDtInclusao.Text = "DT Inclusão";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Segoe UI", 40F);
            label26.Location = new Point(690, 40);
            label26.Margin = new Padding(2, 0, 2, 0);
            label26.Name = "label26";
            label26.Size = new Size(191, 72);
            label26.TabIndex = 1;
            label26.Text = "Pessoa";
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.BackColor = Color.Transparent;
            lblSequencia.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSequencia.Location = new Point(60, 20);
            lblSequencia.Margin = new Padding(2, 0, 2, 0);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(124, 32);
            lblSequencia.TabIndex = 1;
            lblSequencia.Text = "Sequência";
            // 
            // DTAlteracao
            // 
            DTAlteracao.Enabled = false;
            DTAlteracao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTAlteracao.Location = new Point(1185, 84);
            DTAlteracao.Margin = new Padding(4);
            DTAlteracao.Name = "DTAlteracao";
            DTAlteracao.Size = new Size(247, 39);
            DTAlteracao.TabIndex = 15;
            // 
            // txtSequencia
            // 
            txtSequencia.Enabled = false;
            txtSequencia.Location = new Point(60, 50);
            txtSequencia.Margin = new Padding(2, 4, 2, 4);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(193, 39);
            txtSequencia.TabIndex = 0;
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
            btnFechar.TabIndex = 13;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 18F);
            lblNome.Location = new Point(60, 220);
            lblNome.Margin = new Padding(2, 0, 2, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(80, 32);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome";
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.BackColor = Color.Transparent;
            lblCpfCnpj.Font = new Font("Segoe UI", 18F);
            lblCpfCnpj.Location = new Point(60, 300);
            lblCpfCnpj.Margin = new Padding(2, 0, 2, 0);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(116, 32);
            lblCpfCnpj.TabIndex = 8;
            lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.BackColor = Color.Transparent;
            lblCargo.Font = new Font("Segoe UI", 18F);
            lblCargo.Location = new Point(1130, 300);
            lblCargo.Margin = new Padding(2, 0, 2, 0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(77, 32);
            lblCargo.TabIndex = 8;
            lblCargo.Text = "Cargo";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.BackColor = Color.Transparent;
            lblAno.Font = new Font("Segoe UI", 18F);
            lblAno.Location = new Point(300, 390);
            lblAno.Margin = new Padding(2, 0, 2, 0);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(191, 32);
            lblAno.TabIndex = 8;
            lblAno.Text = "Ano Nascimento";
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.BackColor = Color.Transparent;
            lblTipoPessoa.Font = new Font("Segoe UI", 18F);
            lblTipoPessoa.Location = new Point(480, 300);
            lblTipoPessoa.Margin = new Padding(2, 0, 2, 0);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(139, 32);
            lblTipoPessoa.TabIndex = 8;
            lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = Color.Transparent;
            lblGenero.Font = new Font("Segoe UI", 18F);
            lblGenero.Location = new Point(810, 300);
            lblGenero.Margin = new Padding(2, 0, 2, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(92, 32);
            lblGenero.TabIndex = 8;
            lblGenero.Text = "Gênero";
            // 
            // lblRazaoSoc
            // 
            lblRazaoSoc.AutoSize = true;
            lblRazaoSoc.BackColor = Color.Transparent;
            lblRazaoSoc.Font = new Font("Segoe UI", 18F);
            lblRazaoSoc.Location = new Point(810, 220);
            lblRazaoSoc.Margin = new Padding(2, 0, 2, 0);
            lblRazaoSoc.Name = "lblRazaoSoc";
            lblRazaoSoc.Size = new Size(146, 32);
            lblRazaoSoc.TabIndex = 8;
            lblRazaoSoc.Text = "Razão Social";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(60, 260);
            txtNome.Margin = new Padding(2, 4, 2, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(720, 39);
            txtNome.TabIndex = 2;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(60, 340);
            txtCpfCnpj.Margin = new Padding(2, 4, 2, 4);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(379, 39);
            txtCpfCnpj.TabIndex = 2;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(1130, 340);
            txtCargo.Margin = new Padding(2, 4, 2, 4);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(380, 39);
            txtCargo.TabIndex = 2;
            // 
            // txtRazaoSoc
            // 
            txtRazaoSoc.Location = new Point(810, 260);
            txtRazaoSoc.Margin = new Padding(2, 4, 2, 4);
            txtRazaoSoc.Name = "txtRazaoSoc";
            txtRazaoSoc.Size = new Size(700, 39);
            txtRazaoSoc.TabIndex = 2;
            // 
            // cbbGenero
            // 
            cbbGenero.FormattingEnabled = true;
            cbbGenero.Location = new Point(810, 340);
            cbbGenero.Name = "cbbGenero";
            cbbGenero.Size = new Size(290, 40);
            cbbGenero.TabIndex = 10;
            // 
            // cbbTipoPessoa
            // 
            cbbTipoPessoa.FormattingEnabled = true;
            cbbTipoPessoa.Location = new Point(470, 340);
            cbbTipoPessoa.Name = "cbbTipoPessoa";
            cbbTipoPessoa.Size = new Size(310, 40);
            cbbTipoPessoa.TabIndex = 10;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(60, 420);
            txtSenha.Margin = new Padding(2, 4, 2, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(201, 39);
            txtSenha.TabIndex = 2;
            // 
            // txtAnoNasc
            // 
            txtAnoNasc.Location = new Point(300, 420);
            txtAnoNasc.Margin = new Padding(2, 4, 2, 4);
            txtAnoNasc.Name = "txtAnoNasc";
            txtAnoNasc.Size = new Size(201, 39);
            txtAnoNasc.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Segoe UI", 18F);
            lblSenha.Location = new Point(60, 380);
            lblSenha.Margin = new Padding(2, 0, 2, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(80, 32);
            lblSenha.TabIndex = 8;
            lblSenha.Text = "Senha";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(530, 610);
            txtEstado.Margin = new Padding(2, 4, 2, 4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(90, 39);
            txtEstado.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(1100, 610);
            txtBairro.Margin = new Padding(2, 4, 2, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(410, 39);
            txtBairro.TabIndex = 3;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(650, 610);
            txtCidade.Margin = new Padding(2, 4, 2, 4);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(420, 39);
            txtCidade.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(60, 780);
            txtEmail.Margin = new Padding(2, 4, 2, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(606, 39);
            txtEmail.TabIndex = 3;
            // 
            // txtFone
            // 
            txtFone.Location = new Point(1090, 780);
            txtFone.Margin = new Padding(2, 4, 2, 4);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(383, 39);
            txtFone.TabIndex = 3;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(810, 780);
            txtCelular.Margin = new Padding(2, 4, 2, 4);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(249, 39);
            txtCelular.TabIndex = 3;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(320, 610);
            txtPais.Margin = new Padding(2, 4, 2, 4);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(174, 39);
            txtPais.TabIndex = 3;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(320, 690);
            txtComplemento.Margin = new Padding(2, 4, 2, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(300, 39);
            txtComplemento.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(60, 690);
            txtNumero.Margin = new Padding(2, 4, 2, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(230, 39);
            txtNumero.TabIndex = 3;
            // 
            // txtDDD
            // 
            txtDDD.Location = new Point(710, 780);
            txtDDD.Margin = new Padding(2, 4, 2, 4);
            txtDDD.Name = "txtDDD";
            txtDDD.Size = new Size(70, 39);
            txtDDD.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(650, 690);
            txtEndereco.Margin = new Padding(2, 4, 2, 4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(860, 39);
            txtEndereco.TabIndex = 3;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(60, 610);
            txtCep.Margin = new Padding(2, 4, 2, 4);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(227, 39);
            txtCep.TabIndex = 3;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.BackColor = Color.Transparent;
            lblCep.Font = new Font("Segoe UI", 18F);
            lblCep.Location = new Point(60, 570);
            lblCep.Margin = new Padding(2, 0, 2, 0);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(54, 32);
            lblCep.TabIndex = 8;
            lblCep.Text = "CEP";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.BackColor = Color.Transparent;
            lblBairro.Font = new Font("Segoe UI", 18F);
            lblBairro.Location = new Point(1100, 570);
            lblBairro.Margin = new Padding(2, 0, 2, 0);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(76, 32);
            lblBairro.TabIndex = 8;
            lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.BackColor = Color.Transparent;
            lblCidade.Font = new Font("Segoe UI", 18F);
            lblCidade.Location = new Point(650, 570);
            lblCidade.Margin = new Padding(2, 0, 2, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(88, 32);
            lblCidade.TabIndex = 8;
            lblCidade.Text = "Cidade";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Segoe UI", 18F);
            lblEstado.Location = new Point(530, 570);
            lblEstado.Margin = new Padding(2, 0, 2, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(84, 32);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.BackColor = Color.Transparent;
            lblPais.Font = new Font("Segoe UI", 18F);
            lblPais.Location = new Point(320, 570);
            lblPais.Margin = new Padding(2, 0, 2, 0);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(54, 32);
            lblPais.TabIndex = 8;
            lblPais.Text = "País";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.Transparent;
            lblNumero.Location = new Point(60, 650);
            lblNumero.Margin = new Padding(2, 0, 2, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(102, 32);
            lblNumero.TabIndex = 8;
            lblNumero.Text = "Número";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.BackColor = Color.Transparent;
            lblComplemento.Location = new Point(320, 650);
            lblComplemento.Margin = new Padding(2, 0, 2, 0);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(167, 32);
            lblComplemento.TabIndex = 8;
            lblComplemento.Text = "Complemento";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 18F);
            lblEmail.Location = new Point(60, 750);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // lblFone
            // 
            lblFone.AutoSize = true;
            lblFone.BackColor = Color.Transparent;
            lblFone.Font = new Font("Segoe UI", 18F);
            lblFone.Location = new Point(1090, 740);
            lblFone.Margin = new Padding(2, 0, 2, 0);
            lblFone.Name = "lblFone";
            lblFone.Size = new Size(67, 32);
            lblFone.TabIndex = 8;
            lblFone.Text = "Fone";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.BackColor = Color.Transparent;
            lblCelular.Font = new Font("Segoe UI", 18F);
            lblCelular.Location = new Point(810, 740);
            lblCelular.Margin = new Padding(2, 0, 2, 0);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(88, 32);
            lblCelular.TabIndex = 8;
            lblCelular.Text = "Celular";
            // 
            // lblDdd
            // 
            lblDdd.AutoSize = true;
            lblDdd.BackColor = Color.Transparent;
            lblDdd.Font = new Font("Segoe UI", 18F);
            lblDdd.Location = new Point(710, 740);
            lblDdd.Margin = new Padding(2, 0, 2, 0);
            lblDdd.Name = "lblDdd";
            lblDdd.Size = new Size(65, 32);
            lblDdd.TabIndex = 8;
            lblDdd.Text = "DDD";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.BackColor = Color.Transparent;
            lblEndereco.Font = new Font("Segoe UI", 18F);
            lblEndereco.Location = new Point(650, 650);
            lblEndereco.Margin = new Padding(2, 0, 2, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(113, 32);
            lblEndereco.TabIndex = 8;
            lblEndereco.Text = "Endereço";
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            BtnCancelar.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            BtnCancelar.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Location = new Point(1120, 827);
            BtnCancelar.Margin = new Padding(2, 4, 2, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(189, 66);
            BtnCancelar.TabIndex = 12;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.FromArgb(128, 255, 128);
            BtnSalvar.FlatAppearance.MouseDownBackColor = Color.OliveDrab;
            BtnSalvar.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            BtnSalvar.FlatStyle = FlatStyle.Flat;
            BtnSalvar.Location = new Point(1325, 827);
            BtnSalvar.Margin = new Padding(2, 4, 2, 4);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(189, 66);
            BtnSalvar.TabIndex = 12;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(txtFone);
            cuiGradientPanel1.Controls.Add(txtEstado);
            cuiGradientPanel1.Controls.Add(txtCelular);
            cuiGradientPanel1.Controls.Add(txtAnoNasc);
            cuiGradientPanel1.Controls.Add(lblNome);
            cuiGradientPanel1.Controls.Add(txtDDD);
            cuiGradientPanel1.Controls.Add(txtBairro);
            cuiGradientPanel1.Controls.Add(txtEndereco);
            cuiGradientPanel1.Controls.Add(txtPais);
            cuiGradientPanel1.Controls.Add(cbbGenero);
            cuiGradientPanel1.Controls.Add(lblCpfCnpj);
            cuiGradientPanel1.Controls.Add(lblCargo);
            cuiGradientPanel1.Controls.Add(txtCep);
            cuiGradientPanel1.Controls.Add(lblSenha);
            cuiGradientPanel1.Controls.Add(lblRazaoSoc);
            cuiGradientPanel1.Controls.Add(txtCidade);
            cuiGradientPanel1.Controls.Add(lblAno);
            cuiGradientPanel1.Controls.Add(txtRazaoSoc);
            cuiGradientPanel1.Controls.Add(cbbTipoPessoa);
            cuiGradientPanel1.Controls.Add(label26);
            cuiGradientPanel1.Controls.Add(txtEmail);
            cuiGradientPanel1.Controls.Add(lblSequencia);
            cuiGradientPanel1.Controls.Add(lblDtInclusao);
            cuiGradientPanel1.Controls.Add(txtSenha);
            cuiGradientPanel1.Controls.Add(txtComplemento);
            cuiGradientPanel1.Controls.Add(cbbSituacao);
            cuiGradientPanel1.Controls.Add(txtNumero);
            cuiGradientPanel1.Controls.Add(lblSituacao);
            cuiGradientPanel1.Controls.Add(lblEstado);
            cuiGradientPanel1.Controls.Add(lblTipoPessoa);
            cuiGradientPanel1.Controls.Add(lblGenero);
            cuiGradientPanel1.Controls.Add(lblPais);
            cuiGradientPanel1.Controls.Add(lblBairro);
            cuiGradientPanel1.Controls.Add(lblFone);
            cuiGradientPanel1.Controls.Add(lblCep);
            cuiGradientPanel1.Controls.Add(lblCelular);
            cuiGradientPanel1.Controls.Add(lblComplemento);
            cuiGradientPanel1.Controls.Add(lblCidade);
            cuiGradientPanel1.Controls.Add(lblNumero);
            cuiGradientPanel1.Controls.Add(lblEmail);
            cuiGradientPanel1.Controls.Add(txtCargo);
            cuiGradientPanel1.Controls.Add(lblEndereco);
            cuiGradientPanel1.Controls.Add(lblDdd);
            cuiGradientPanel1.Controls.Add(txtNome);
            cuiGradientPanel1.Controls.Add(txtCpfCnpj);
            cuiGradientPanel1.Controls.Add(txtSequencia);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-10, 0);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(8);
            cuiGradientPanel1.Size = new Size(1540, 900);
            cuiGradientPanel1.TabIndex = 17;
            // 
            // PessoaCad
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(btnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnCancelar);
            Controls.Add(DTAlteracao);
            Controls.Add(cuiGradientPanel1);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            Name = "PessoaCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PessoaCad";
            Load += PessoaCad_Load;
            cuiGradientPanel1.ResumeLayout(false);
            cuiGradientPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSequencia;
        private Label lblSituacao;
        private Label lblDtInclusao;
        private Label lblSequencia;
        private TextBox DTAlteracao;
        private Label lblNome;
        private Label lblCpfCnpj;
        private Label lblCargo;
        private Label lblAno;
        private Label lblTipoPessoa;
        private Label lblGenero;
        private Label lblRazaoSoc;
        private TextBox txtNome;
        private TextBox txtCpfCnpj;
        private TextBox txtCargo;
        private TextBox txtRazaoSoc;
        private TextBox txtPais;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtDDD;
        private TextBox txtEndereco;
        private TextBox txtCep;
        private TextBox txtEstado;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtEmail;
        private TextBox txtFone;
        private TextBox txtCelular;
        private Label lblCep;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblEstado;
        private Label lblPais;
        private Label lblNumero;
        private Label lblComplemento;
        private Label lblEmail;
        private Label lblFone;
        private Label lblCelular;
        private Label lblDdd;
        private Label lblEndereco;
        private Button BtnCancelar;
        private Button BtnSalvar;
        private Label label26;
        private Button btnFechar;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox txtSenha;
        private Label lblSenha;
        private ComboBox cbbTipoPessoa;
        private TextBox txtAnoNasc;
        private ComboBox cbbSituacao;
        private ComboBox cbbGenero;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
    }
}
namespace SENAC_ProjetoIntegrador
{
    partial class ServicoCad
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
            btnSalvar = new Button();
            btnCancelar = new Button();
            txtDescricao = new RichTextBox();
            groupBox2 = new GroupBox();
            cbbTipo = new ComboBox();
            label11 = new Label();
            label14 = new Label();
            label17 = new Label();
            label9 = new Label();
            txtCategoria = new TextBox();
            txtNome = new TextBox();
            txtValor = new TextBox();
            txtUsuarioAlteracao = new TextBox();
            txtUsuarioInclusao = new TextBox();
            txtSituacao = new TextBox();
            txtAlteracao = new TextBox();
            txtDtInclusao = new TextBox();
            txtSequencia = new TextBox();
            lblAlteracaoDeUsuario = new Label();
            lblInclusaoDeUsuario = new Label();
            lblDescricao = new Label();
            lblSituacao = new Label();
            lblDtAlteracao = new Label();
            lblDtInclusao = new Label();
            lblSequencia = new Label();
            lblServico = new Label();
            groupBox1 = new GroupBox();
            btnFechar = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(650, 470);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(78, 20);
            btnSalvar.TabIndex = 39;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(556, 470);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 20);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(30, 400);
            txtDescricao.Margin = new Padding(2);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(706, 57);
            txtDescricao.TabIndex = 37;
            txtDescricao.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbbTipo);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtCategoria);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(txtValor);
            groupBox2.Location = new Point(30, 240);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(706, 130);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Relacao";
            // 
            // cbbTipo
            // 
            cbbTipo.FormattingEnabled = true;
            cbbTipo.Location = new Point(26, 90);
            cbbTipo.Margin = new Padding(2);
            cbbTipo.Name = "cbbTipo";
            cbbTipo.Size = new Size(55, 23);
            cbbTipo.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 73);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 1;
            label11.Text = "Tipo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(119, 73);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 1;
            label14.Text = "Valor";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(400, 20);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(58, 15);
            label17.TabIndex = 1;
            label17.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 20);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 1;
            label9.Text = "Nome";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(400, 40);
            txtCategoria.Margin = new Padding(2);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(280, 23);
            txtCategoria.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(30, 40);
            txtNome.Margin = new Padding(2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(310, 23);
            txtNome.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(120, 90);
            txtValor.Margin = new Padding(2);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(69, 23);
            txtValor.TabIndex = 9;
            // 
            // txtUsuarioAlteracao
            // 
            txtUsuarioAlteracao.Location = new Point(20, 140);
            txtUsuarioAlteracao.Margin = new Padding(2);
            txtUsuarioAlteracao.Name = "txtUsuarioAlteracao";
            txtUsuarioAlteracao.Size = new Size(186, 23);
            txtUsuarioAlteracao.TabIndex = 33;
            // 
            // txtUsuarioInclusao
            // 
            txtUsuarioInclusao.Location = new Point(20, 90);
            txtUsuarioInclusao.Margin = new Padding(2);
            txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            txtUsuarioInclusao.Size = new Size(186, 23);
            txtUsuarioInclusao.TabIndex = 31;
            // 
            // txtSituacao
            // 
            txtSituacao.Location = new Point(590, 137);
            txtSituacao.Margin = new Padding(2);
            txtSituacao.Name = "txtSituacao";
            txtSituacao.Size = new Size(102, 23);
            txtSituacao.TabIndex = 36;
            // 
            // txtAlteracao
            // 
            txtAlteracao.Location = new Point(590, 93);
            txtAlteracao.Margin = new Padding(2);
            txtAlteracao.Name = "txtAlteracao";
            txtAlteracao.Size = new Size(102, 23);
            txtAlteracao.TabIndex = 35;
            // 
            // txtDtInclusao
            // 
            txtDtInclusao.Location = new Point(590, 46);
            txtDtInclusao.Margin = new Padding(2);
            txtDtInclusao.Name = "txtDtInclusao";
            txtDtInclusao.Size = new Size(102, 23);
            txtDtInclusao.TabIndex = 34;
            // 
            // txtSequencia
            // 
            txtSequencia.Location = new Point(20, 40);
            txtSequencia.Margin = new Padding(2);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(102, 23);
            txtSequencia.TabIndex = 27;
            // 
            // lblAlteracaoDeUsuario
            // 
            lblAlteracaoDeUsuario.AutoSize = true;
            lblAlteracaoDeUsuario.Location = new Point(19, 123);
            lblAlteracaoDeUsuario.Margin = new Padding(2, 0, 2, 0);
            lblAlteracaoDeUsuario.Name = "lblAlteracaoDeUsuario";
            lblAlteracaoDeUsuario.Size = new Size(116, 15);
            lblAlteracaoDeUsuario.TabIndex = 28;
            lblAlteracaoDeUsuario.Text = "Alteração de Usuário";
            // 
            // lblInclusaoDeUsuario
            // 
            lblInclusaoDeUsuario.AutoSize = true;
            lblInclusaoDeUsuario.Location = new Point(21, 73);
            lblInclusaoDeUsuario.Margin = new Padding(2, 0, 2, 0);
            lblInclusaoDeUsuario.Name = "lblInclusaoDeUsuario";
            lblInclusaoDeUsuario.Size = new Size(110, 15);
            lblInclusaoDeUsuario.TabIndex = 29;
            lblInclusaoDeUsuario.Text = "Inclusão de Usuário";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(30, 380);
            lblDescricao.Margin = new Padding(2, 0, 2, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 25;
            lblDescricao.Text = "Descricao";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(590, 120);
            lblSituacao.Margin = new Padding(2, 0, 2, 0);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 24;
            lblSituacao.Text = "Situação";
            // 
            // lblDtAlteracao
            // 
            lblDtAlteracao.AutoSize = true;
            lblDtAlteracao.Location = new Point(590, 76);
            lblDtAlteracao.Margin = new Padding(2, 0, 2, 0);
            lblDtAlteracao.Name = "lblDtAlteracao";
            lblDtAlteracao.Size = new Size(69, 15);
            lblDtAlteracao.TabIndex = 23;
            lblDtAlteracao.Text = "DtAlteracão";
            // 
            // lblDtInclusao
            // 
            lblDtInclusao.AutoSize = true;
            lblDtInclusao.Location = new Point(590, 29);
            lblDtInclusao.Margin = new Padding(2, 0, 2, 0);
            lblDtInclusao.Name = "lblDtInclusao";
            lblDtInclusao.Size = new Size(63, 15);
            lblDtInclusao.TabIndex = 22;
            lblDtInclusao.Text = "DtInclusão";
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.Location = new Point(20, 23);
            lblSequencia.Margin = new Padding(2, 0, 2, 0);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(61, 15);
            lblSequencia.TabIndex = 26;
            lblSequencia.Text = "Sequência";
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Font = new Font("Segoe UI", 16F);
            lblServico.Location = new Point(320, 30);
            lblServico.Margin = new Padding(2, 0, 2, 0);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(84, 30);
            lblServico.TabIndex = 21;
            lblServico.Text = "Serviço";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblInclusaoDeUsuario);
            groupBox1.Controls.Add(lblSequencia);
            groupBox1.Controls.Add(lblAlteracaoDeUsuario);
            groupBox1.Controls.Add(txtSequencia);
            groupBox1.Controls.Add(txtUsuarioInclusao);
            groupBox1.Controls.Add(txtSituacao);
            groupBox1.Controls.Add(txtUsuarioAlteracao);
            groupBox1.Controls.Add(txtAlteracao);
            groupBox1.Controls.Add(txtDtInclusao);
            groupBox1.Controls.Add(lblServico);
            groupBox1.Controls.Add(lblSituacao);
            groupBox1.Controls.Add(lblDtInclusao);
            groupBox1.Controls.Add(lblDtAlteracao);
            groupBox1.Location = new Point(30, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(710, 180);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(720, 10);
            btnFechar.Margin = new Padding(2);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(20, 20);
            btnFechar.TabIndex = 41;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // ServicoCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 532);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescricao);
            Controls.Add(groupBox2);
            Controls.Add(lblDescricao);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ServicoCad";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnCancelar;
        private RichTextBox txtDescricao;
        private GroupBox groupBox2;
        private ComboBox cbbTipo;
        private Label label11;
        private Label label14;
        private Label label17;
        private Label label9;
        private TextBox txtCategoria;
        private TextBox txtNome;
        private TextBox txtValor;
        private TextBox txtUsuarioAlteracao;
        private TextBox txtUsuarioInclusao;
        private TextBox txtSituacao;
        private TextBox txtAlteracao;
        private TextBox txtDtInclusao;
        private TextBox txtSequencia;
        private Label lblAlteracaoDeUsuario;
        private Label lblInclusaoDeUsuario;
        private Label lblDescricao;
        private Label lblSituacao;
        private Label lblDtAlteracao;
        private Label lblDtInclusao;
        private Label lblSequencia;
        private Label lblServico;
        private GroupBox groupBox1;
        private Button btnFechar;
    }
}
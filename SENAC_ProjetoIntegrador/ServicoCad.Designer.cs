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
            label11 = new Label();
            label14 = new Label();
            label17 = new Label();
            label9 = new Label();
            txtCategoria = new TextBox();
            txtNome = new TextBox();
            txtValor = new TextBox();
            cbbSituacao = new ComboBox();
            txtDtInclusao = new TextBox();
            txtSequencia = new TextBox();
            lblDescricao = new Label();
            lblSituacao = new Label();
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
            btnSalvar.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvar.Location = new Point(1326, 830);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(145, 43);
            btnSalvar.TabIndex = 39;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Location = new Point(1173, 830);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 43);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(53, 638);
            txtDescricao.Margin = new Padding(4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1418, 184);
            txtDescricao.TabIndex = 37;
            txtDescricao.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtCategoria);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(txtValor);
            groupBox2.Location = new Point(53, 344);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1458, 238);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Relacao";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 115);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(61, 32);
            label11.TabIndex = 1;
            label11.Text = "Tipo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(145, 115);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(67, 32);
            label14.TabIndex = 1;
            label14.Text = "Valor";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(901, 36);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(116, 32);
            label17.TabIndex = 1;
            label17.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 36);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(80, 32);
            label9.TabIndex = 1;
            label9.Text = "Nome";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(901, 72);
            txtCategoria.Margin = new Padding(4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(517, 39);
            txtCategoria.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(26, 72);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(572, 39);
            txtNome.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(145, 156);
            txtValor.Margin = new Padding(4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 39);
            txtValor.TabIndex = 9;
            // 
            // cbbSituacao
            // 
            cbbSituacao.FormattingEnabled = true;
            cbbSituacao.Location = new Point(27, 190);
            cbbSituacao.Margin = new Padding(4);
            cbbSituacao.Name = "cbbSituacao";
            cbbSituacao.Size = new Size(183, 40);
            cbbSituacao.TabIndex = 6;
            // 
            // txtDtInclusao
            // 
            txtDtInclusao.Location = new Point(1229, 63);
            txtDtInclusao.Margin = new Padding(4);
            txtDtInclusao.Name = "txtDtInclusao";
            txtDtInclusao.Size = new Size(186, 39);
            txtDtInclusao.TabIndex = 34;
            // 
            // txtSequencia
            // 
            txtSequencia.Location = new Point(23, 63);
            txtSequencia.Margin = new Padding(4);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(186, 39);
            txtSequencia.TabIndex = 27;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(53, 602);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(116, 32);
            lblDescricao.TabIndex = 25;
            lblDescricao.Text = "Descricao";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(20, 150);
            lblSituacao.Margin = new Padding(4, 0, 4, 0);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(104, 32);
            lblSituacao.TabIndex = 24;
            lblSituacao.Text = "Situação";
            // 
            // lblDtInclusao
            // 
            lblDtInclusao.AutoSize = true;
            lblDtInclusao.Location = new Point(1229, 27);
            lblDtInclusao.Margin = new Padding(4, 0, 4, 0);
            lblDtInclusao.Name = "lblDtInclusao";
            lblDtInclusao.Size = new Size(126, 32);
            lblDtInclusao.TabIndex = 22;
            lblDtInclusao.Text = "DtInclusão";
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.Location = new Point(23, 27);
            lblSequencia.Margin = new Padding(4, 0, 4, 0);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(124, 32);
            lblSequencia.TabIndex = 26;
            lblSequencia.Text = "Sequência";
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Font = new Font("Segoe UI", 30F);
            lblServico.Location = new Point(717, 13);
            lblServico.Margin = new Padding(4, 0, 4, 0);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(149, 54);
            lblServico.TabIndex = 21;
            lblServico.Text = "Serviço";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbbSituacao);
            groupBox1.Controls.Add(lblSequencia);
            groupBox1.Controls.Add(txtSequencia);
            groupBox1.Controls.Add(txtDtInclusao);
            groupBox1.Controls.Add(lblSituacao);
            groupBox1.Controls.Add(lblDtInclusao);
            groupBox1.Location = new Point(56, 64);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(1455, 287);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1461, 13);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(50, 34);
            btnFechar.TabIndex = 41;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // ServicoCad
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescricao);
            Controls.Add(groupBox2);
            Controls.Add(lblDescricao);
            Controls.Add(lblServico);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ServicoCad";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ComboBox cbbSituacao;
        private Label label11;
        private Label label14;
        private Label label17;
        private Label label9;
        private TextBox txtCategoria;
        private TextBox txtNome;
        private TextBox txtValor;
        private TextBox txtDtInclusao;
        private TextBox txtSequencia;
        private Label lblDescricao;
        private Label lblSituacao;
        private Label lblDtInclusao;
        private Label lblSequencia;
        private Label lblServico;
        private GroupBox groupBox1;
        private Button btnFechar;
    }
}
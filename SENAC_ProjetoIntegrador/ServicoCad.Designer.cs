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
            label14 = new Label();
            label17 = new Label();
            label9 = new Label();
            txtCategoria = new TextBox();
            txtNome = new TextBox();
            txtValor = new TextBox();
            lblDescricao = new Label();
            btnFechar = new Button();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            lblServico = new Label();
            txtDtInclusao = new TextBox();
            cbbSituacao = new ComboBox();
            lblDtInclusao = new Label();
            lblSequencia = new Label();
            lblSituacao = new Label();
            txtSequencia = new TextBox();
            cuiGradientPanel2 = new CuoreUI.Controls.cuiGradientPanel();
            label11 = new Label();
            cbbTipoServico = new ComboBox();
            cuiGradientPanel1.SuspendLayout();
            cuiGradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.OliveDrab;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(1321, 787);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(184, 64);
            btnSalvar.TabIndex = 39;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(1111, 787);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(184, 64);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(79, 558);
            txtDescricao.Margin = new Padding(4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1418, 184);
            txtDescricao.TabIndex = 37;
            txtDescricao.Text = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(240, 100);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(67, 32);
            label14.TabIndex = 1;
            label14.Text = "Valor";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Location = new Point(802, 18);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(116, 32);
            label17.TabIndex = 1;
            label17.Text = "Categoria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(14, 18);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(80, 32);
            label9.TabIndex = 1;
            label9.Text = "Nome";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(867, 372);
            txtCategoria.Margin = new Padding(4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(517, 39);
            txtCategoria.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 372);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(572, 39);
            txtNome.TabIndex = 4;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(240, 140);
            txtValor.Margin = new Padding(4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 39);
            txtValor.TabIndex = 9;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Location = new Point(14, 200);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(116, 32);
            lblDescricao.TabIndex = 25;
            lblDescricao.Text = "Descricao";
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
            btnFechar.TabIndex = 41;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(lblServico);
            cuiGradientPanel1.Controls.Add(btnFechar);
            cuiGradientPanel1.Controls.Add(btnSalvar);
            cuiGradientPanel1.Controls.Add(btnCancelar);
            cuiGradientPanel1.Controls.Add(txtDtInclusao);
            cuiGradientPanel1.Controls.Add(cbbSituacao);
            cuiGradientPanel1.Controls.Add(txtDescricao);
            cuiGradientPanel1.Controls.Add(lblDtInclusao);
            cuiGradientPanel1.Controls.Add(txtCategoria);
            cuiGradientPanel1.Controls.Add(lblSequencia);
            cuiGradientPanel1.Controls.Add(txtNome);
            cuiGradientPanel1.Controls.Add(lblSituacao);
            cuiGradientPanel1.Controls.Add(txtSequencia);
            cuiGradientPanel1.Controls.Add(cuiGradientPanel2);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-2, -3);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(8);
            cuiGradientPanel1.Size = new Size(1525, 910);
            cuiGradientPanel1.TabIndex = 35;
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.BackColor = Color.Transparent;
            lblServico.Font = new Font("Segoe UI", 40F);
            lblServico.Location = new Point(698, 22);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(239, 72);
            lblServico.TabIndex = 43;
            lblServico.Text = "SERVIÇO";
            lblServico.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDtInclusao
            // 
            txtDtInclusao.Location = new Point(1311, 124);
            txtDtInclusao.Margin = new Padding(4);
            txtDtInclusao.Name = "txtDtInclusao";
            txtDtInclusao.Size = new Size(186, 39);
            txtDtInclusao.TabIndex = 34;
            // 
            // cbbSituacao
            // 
            cbbSituacao.FormattingEnabled = true;
            cbbSituacao.Location = new Point(80, 210);
            cbbSituacao.Margin = new Padding(4);
            cbbSituacao.Name = "cbbSituacao";
            cbbSituacao.Size = new Size(150, 40);
            cbbSituacao.TabIndex = 6;
            // 
            // lblDtInclusao
            // 
            lblDtInclusao.AutoSize = true;
            lblDtInclusao.BackColor = Color.Transparent;
            lblDtInclusao.Location = new Point(1311, 78);
            lblDtInclusao.Margin = new Padding(4, 0, 4, 0);
            lblDtInclusao.Name = "lblDtInclusao";
            lblDtInclusao.Size = new Size(126, 32);
            lblDtInclusao.TabIndex = 22;
            lblDtInclusao.Text = "DtInclusão";
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.BackColor = Color.Transparent;
            lblSequencia.Location = new Point(79, 78);
            lblSequencia.Margin = new Padding(4, 0, 4, 0);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(124, 32);
            lblSequencia.TabIndex = 26;
            lblSequencia.Text = "Sequência";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.BackColor = Color.Transparent;
            lblSituacao.Location = new Point(79, 177);
            lblSituacao.Margin = new Padding(4, 0, 4, 0);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(104, 32);
            lblSituacao.TabIndex = 24;
            lblSituacao.Text = "Situação";
            // 
            // txtSequencia
            // 
            txtSequencia.Location = new Point(79, 124);
            txtSequencia.Margin = new Padding(4);
            txtSequencia.Name = "txtSequencia";
            txtSequencia.Size = new Size(186, 39);
            txtSequencia.TabIndex = 27;
            // 
            // cuiGradientPanel2
            // 
            cuiGradientPanel2.Controls.Add(label11);
            cuiGradientPanel2.Controls.Add(lblDescricao);
            cuiGradientPanel2.Controls.Add(label14);
            cuiGradientPanel2.Controls.Add(label9);
            cuiGradientPanel2.Controls.Add(label17);
            cuiGradientPanel2.Controls.Add(cbbTipoServico);
            cuiGradientPanel2.Controls.Add(txtValor);
            cuiGradientPanel2.GradientAngle = 0F;
            cuiGradientPanel2.Location = new Point(65, 311);
            cuiGradientPanel2.Name = "cuiGradientPanel2";
            cuiGradientPanel2.OutlineThickness = 1F;
            cuiGradientPanel2.PanelColor1 = Color.White;
            cuiGradientPanel2.PanelColor2 = Color.White;
            cuiGradientPanel2.PanelOutlineColor1 = Color.White;
            cuiGradientPanel2.PanelOutlineColor2 = Color.White;
            cuiGradientPanel2.Rounding = new Padding(8);
            cuiGradientPanel2.Size = new Size(1457, 458);
            cuiGradientPanel2.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(14, 110);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(61, 32);
            label11.TabIndex = 1;
            label11.Text = "Tipo";
            // 
            // cbbTipoServico
            // 
            cbbTipoServico.FormattingEnabled = true;
            cbbTipoServico.Location = new Point(20, 140);
            cbbTipoServico.Margin = new Padding(4);
            cbbTipoServico.Name = "cbbTipoServico";
            cbbTipoServico.Size = new Size(150, 40);
            cbbTipoServico.TabIndex = 6;
            // 
            // ServicoCad
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1550, 900);
            Controls.Add(cuiGradientPanel1);
            Font = new Font("Segoe UI", 18F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ServicoCad";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ServicoCad_Load;
            cuiGradientPanel1.ResumeLayout(false);
            cuiGradientPanel1.PerformLayout();
            cuiGradientPanel2.ResumeLayout(false);
            cuiGradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private Button btnCancelar;
        private RichTextBox txtDescricao;
        private Label label14;
        private Label label17;
        private Label label9;
        private TextBox txtCategoria;
        private TextBox txtNome;
        private TextBox txtValor;
        private Label lblDescricao;
        private Button btnFechar;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private Label label11;
        private TextBox txtDtInclusao;
        private Label lblDtInclusao;
        private ComboBox cbbSituacao;
        private Label lblSequencia;
        private Label lblSituacao;
        private TextBox txtSequencia;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel2;
        private Label lblServico;
        private ComboBox cbbTipo;
        private ComboBox cbbTipoServico;
    }
}
using SENAC_ProjetoIntegrador.Enum;

namespace SENAC_ProjetoIntegrador
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            gpbMenus = new GroupBox();
            pictureBox8 = new PictureBox();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            btnVenda = new CuoreUI.Controls.cuiButton();
            btnServico = new CuoreUI.Controls.cuiButton();
            btnPecaItem = new CuoreUI.Controls.cuiButton();
            btnEquipamento = new CuoreUI.Controls.cuiButton();
            btnPessoa = new CuoreUI.Controls.cuiButton();
            btnOrdemServico = new CuoreUI.Controls.cuiButton();
            cuiGradientPanel1 = new CuoreUI.Controls.cuiGradientPanel();
            label3 = new Label();
            label2 = new Label();
            lblMensagem = new Label();
            btnFechar = new Button();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            gpbMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            cuiGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gpbMenus
            // 
            gpbMenus.BackColor = Color.Transparent;
            gpbMenus.Controls.Add(pictureBox8);
            gpbMenus.Controls.Add(label1);
            gpbMenus.Controls.Add(pictureBox6);
            gpbMenus.Controls.Add(pictureBox5);
            gpbMenus.Controls.Add(cuiButton1);
            gpbMenus.Controls.Add(pictureBox3);
            gpbMenus.Controls.Add(pictureBox4);
            gpbMenus.Controls.Add(pictureBox2);
            gpbMenus.Controls.Add(pictureBox1);
            gpbMenus.Controls.Add(pictureBox7);
            gpbMenus.Controls.Add(btnVenda);
            gpbMenus.Controls.Add(btnServico);
            gpbMenus.Controls.Add(btnPecaItem);
            gpbMenus.Controls.Add(btnEquipamento);
            gpbMenus.Controls.Add(btnPessoa);
            gpbMenus.Controls.Add(btnOrdemServico);
            gpbMenus.FlatStyle = FlatStyle.Popup;
            gpbMenus.Font = new Font("Segoe UI", 25F);
            gpbMenus.Location = new Point(13, 21);
            gpbMenus.Margin = new Padding(3, 2, 3, 2);
            gpbMenus.Name = "gpbMenus";
            gpbMenus.Padding = new Padding(3, 2, 3, 2);
            gpbMenus.Size = new Size(401, 851);
            gpbMenus.TabIndex = 0;
            gpbMenus.TabStop = false;
            gpbMenus.Text = "Menu";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(283, 47);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(110, 76);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 10;
            pictureBox8.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 42F);
            label1.Location = new Point(-2, 47);
            label1.Name = "label1";
            label1.Size = new Size(279, 64);
            label1.TabIndex = 8;
            label1.Text = "TechPoint";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = Properties.Resources.plano;
            pictureBox6.Location = new Point(46, 733);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(64, 64);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            pictureBox6.Click += btnRelatorio_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.moeda;
            pictureBox5.Location = new Point(39, 634);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.servico_tecnico;
            pictureBox3.Location = new Point(39, 540);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.engrenagem;
            pictureBox4.Location = new Point(39, 441);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.computador;
            pictureBox2.Location = new Point(39, 342);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.usuario_de_perfil;
            pictureBox1.Location = new Point(39, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.cadastro;
            pictureBox7.Location = new Point(39, 146);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(64, 64);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // btnVenda
            // 
            btnVenda.CheckButton = false;
            btnVenda.Checked = false;
            btnVenda.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnVenda.CheckedForeColor = Color.White;
            btnVenda.CheckedImageTint = Color.White;
            btnVenda.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnVenda.Content = "Venda";
            btnVenda.DialogResult = DialogResult.None;
            btnVenda.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVenda.ForeColor = Color.Black;
            btnVenda.HoverBackground = Color.White;
            btnVenda.HoverForeColor = Color.Black;
            btnVenda.HoverImageTint = Color.White;
            btnVenda.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnVenda.Image = null;
            btnVenda.ImageAutoCenter = true;
            btnVenda.ImageExpand = new Point(0, 0);
            btnVenda.ImageOffset = new Point(0, 0);
            btnVenda.Location = new Point(13, 628);
            btnVenda.Name = "btnVenda";
            btnVenda.NormalBackground = Color.White;
            btnVenda.NormalForeColor = Color.Black;
            btnVenda.NormalImageTint = Color.White;
            btnVenda.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnVenda.OutlineThickness = 1F;
            btnVenda.PressedBackground = Color.WhiteSmoke;
            btnVenda.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnVenda.PressedImageTint = Color.White;
            btnVenda.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnVenda.Rounding = new Padding(30);
            btnVenda.Size = new Size(377, 79);
            btnVenda.TabIndex = 13;
            btnVenda.TextAlignment = StringAlignment.Center;
            btnVenda.TextOffset = new Point(0, 0);
            btnVenda.Click += btnVenda_Click;
            // 
            // btnServico
            // 
            btnServico.CheckButton = false;
            btnServico.Checked = false;
            btnServico.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnServico.CheckedForeColor = Color.White;
            btnServico.CheckedImageTint = Color.White;
            btnServico.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnServico.Content = "Serviço";
            btnServico.DialogResult = DialogResult.None;
            btnServico.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServico.ForeColor = Color.Black;
            btnServico.HoverBackground = Color.White;
            btnServico.HoverForeColor = Color.Black;
            btnServico.HoverImageTint = Color.White;
            btnServico.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnServico.Image = null;
            btnServico.ImageAutoCenter = true;
            btnServico.ImageExpand = new Point(0, 0);
            btnServico.ImageOffset = new Point(0, 0);
            btnServico.Location = new Point(13, 533);
            btnServico.Name = "btnServico";
            btnServico.NormalBackground = Color.White;
            btnServico.NormalForeColor = Color.Black;
            btnServico.NormalImageTint = Color.White;
            btnServico.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnServico.OutlineThickness = 1F;
            btnServico.PressedBackground = Color.WhiteSmoke;
            btnServico.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnServico.PressedImageTint = Color.White;
            btnServico.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnServico.Rounding = new Padding(30);
            btnServico.Size = new Size(377, 79);
            btnServico.TabIndex = 13;
            btnServico.TextAlignment = StringAlignment.Center;
            btnServico.TextOffset = new Point(0, 0);
            btnServico.Click += btnServico_Click;
            // 
            // btnPecaItem
            // 
            btnPecaItem.CheckButton = false;
            btnPecaItem.Checked = false;
            btnPecaItem.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnPecaItem.CheckedForeColor = Color.White;
            btnPecaItem.CheckedImageTint = Color.White;
            btnPecaItem.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnPecaItem.Content = "    Peça Item";
            btnPecaItem.DialogResult = DialogResult.None;
            btnPecaItem.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPecaItem.ForeColor = Color.Black;
            btnPecaItem.HoverBackground = Color.White;
            btnPecaItem.HoverForeColor = Color.Black;
            btnPecaItem.HoverImageTint = Color.White;
            btnPecaItem.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnPecaItem.Image = null;
            btnPecaItem.ImageAutoCenter = true;
            btnPecaItem.ImageExpand = new Point(0, 0);
            btnPecaItem.ImageOffset = new Point(0, 0);
            btnPecaItem.Location = new Point(13, 433);
            btnPecaItem.Name = "btnPecaItem";
            btnPecaItem.NormalBackground = Color.White;
            btnPecaItem.NormalForeColor = Color.Black;
            btnPecaItem.NormalImageTint = Color.White;
            btnPecaItem.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnPecaItem.OutlineThickness = 1F;
            btnPecaItem.PressedBackground = Color.WhiteSmoke;
            btnPecaItem.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnPecaItem.PressedImageTint = Color.White;
            btnPecaItem.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnPecaItem.Rounding = new Padding(30);
            btnPecaItem.Size = new Size(377, 79);
            btnPecaItem.TabIndex = 13;
            btnPecaItem.TextAlignment = StringAlignment.Center;
            btnPecaItem.TextOffset = new Point(0, 0);
            btnPecaItem.Click += btnPecaItem_Click;
            // 
            // btnEquipamento
            // 
            btnEquipamento.CheckButton = false;
            btnEquipamento.Checked = false;
            btnEquipamento.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnEquipamento.CheckedForeColor = Color.White;
            btnEquipamento.CheckedImageTint = Color.White;
            btnEquipamento.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnEquipamento.Content = "        Equipamento";
            btnEquipamento.DialogResult = DialogResult.None;
            btnEquipamento.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEquipamento.ForeColor = Color.Black;
            btnEquipamento.HoverBackground = Color.White;
            btnEquipamento.HoverForeColor = Color.Black;
            btnEquipamento.HoverImageTint = Color.White;
            btnEquipamento.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnEquipamento.Image = null;
            btnEquipamento.ImageAutoCenter = true;
            btnEquipamento.ImageExpand = new Point(0, 0);
            btnEquipamento.ImageOffset = new Point(0, 0);
            btnEquipamento.Location = new Point(13, 335);
            btnEquipamento.Name = "btnEquipamento";
            btnEquipamento.NormalBackground = Color.White;
            btnEquipamento.NormalForeColor = Color.Black;
            btnEquipamento.NormalImageTint = Color.White;
            btnEquipamento.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnEquipamento.OutlineThickness = 1F;
            btnEquipamento.PressedBackground = Color.WhiteSmoke;
            btnEquipamento.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnEquipamento.PressedImageTint = Color.White;
            btnEquipamento.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnEquipamento.Rounding = new Padding(30);
            btnEquipamento.Size = new Size(377, 79);
            btnEquipamento.TabIndex = 13;
            btnEquipamento.TextAlignment = StringAlignment.Center;
            btnEquipamento.TextOffset = new Point(0, 0);
            btnEquipamento.Click += btnEquipamento_Click;
            // 
            // btnPessoa
            // 
            btnPessoa.CheckButton = false;
            btnPessoa.Checked = false;
            btnPessoa.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnPessoa.CheckedForeColor = Color.White;
            btnPessoa.CheckedImageTint = Color.White;
            btnPessoa.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnPessoa.Content = "Pessoa";
            btnPessoa.DialogResult = DialogResult.None;
            btnPessoa.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPessoa.ForeColor = Color.Black;
            btnPessoa.HoverBackground = Color.White;
            btnPessoa.HoverForeColor = Color.Black;
            btnPessoa.HoverImageTint = Color.White;
            btnPessoa.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnPessoa.Image = null;
            btnPessoa.ImageAutoCenter = true;
            btnPessoa.ImageExpand = new Point(0, 0);
            btnPessoa.ImageOffset = new Point(0, 0);
            btnPessoa.Location = new Point(13, 236);
            btnPessoa.Name = "btnPessoa";
            btnPessoa.NormalBackground = Color.White;
            btnPessoa.NormalForeColor = Color.Black;
            btnPessoa.NormalImageTint = Color.White;
            btnPessoa.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnPessoa.OutlineThickness = 1F;
            btnPessoa.PressedBackground = Color.WhiteSmoke;
            btnPessoa.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnPessoa.PressedImageTint = Color.White;
            btnPessoa.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnPessoa.Rounding = new Padding(30);
            btnPessoa.Size = new Size(377, 79);
            btnPessoa.TabIndex = 13;
            btnPessoa.TextAlignment = StringAlignment.Center;
            btnPessoa.TextOffset = new Point(0, 0);
            btnPessoa.Click += btnPessoa_Click;
            // 
            // btnOrdemServico
            // 
            btnOrdemServico.CheckButton = false;
            btnOrdemServico.Checked = false;
            btnOrdemServico.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnOrdemServico.CheckedForeColor = Color.White;
            btnOrdemServico.CheckedImageTint = Color.White;
            btnOrdemServico.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnOrdemServico.Content = "       Ordem de Serviço";
            btnOrdemServico.DialogResult = DialogResult.None;
            btnOrdemServico.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrdemServico.ForeColor = Color.Black;
            btnOrdemServico.HoverBackground = Color.White;
            btnOrdemServico.HoverForeColor = Color.Black;
            btnOrdemServico.HoverImageTint = Color.White;
            btnOrdemServico.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnOrdemServico.Image = null;
            btnOrdemServico.ImageAutoCenter = true;
            btnOrdemServico.ImageExpand = new Point(0, 0);
            btnOrdemServico.ImageOffset = new Point(0, 0);
            btnOrdemServico.Location = new Point(13, 140);
            btnOrdemServico.Name = "btnOrdemServico";
            btnOrdemServico.NormalBackground = Color.White;
            btnOrdemServico.NormalForeColor = Color.Black;
            btnOrdemServico.NormalImageTint = Color.White;
            btnOrdemServico.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnOrdemServico.OutlineThickness = 1F;
            btnOrdemServico.PressedBackground = Color.WhiteSmoke;
            btnOrdemServico.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnOrdemServico.PressedImageTint = Color.White;
            btnOrdemServico.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnOrdemServico.Rounding = new Padding(30);
            btnOrdemServico.Size = new Size(377, 79);
            btnOrdemServico.TabIndex = 13;
            btnOrdemServico.TextAlignment = StringAlignment.Center;
            btnOrdemServico.TextOffset = new Point(0, 0);
            btnOrdemServico.Click += button1_Click;
            // 
            // cuiGradientPanel1
            // 
            cuiGradientPanel1.Controls.Add(label3);
            cuiGradientPanel1.Controls.Add(label2);
            cuiGradientPanel1.Controls.Add(gpbMenus);
            cuiGradientPanel1.Controls.Add(lblMensagem);
            cuiGradientPanel1.GradientAngle = 0F;
            cuiGradientPanel1.Location = new Point(-1, -8);
            cuiGradientPanel1.Name = "cuiGradientPanel1";
            cuiGradientPanel1.OutlineThickness = 1F;
            cuiGradientPanel1.PanelColor1 = Color.DarkOrchid;
            cuiGradientPanel1.PanelColor2 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor1 = Color.Transparent;
            cuiGradientPanel1.PanelOutlineColor2 = Color.Transparent;
            cuiGradientPanel1.Rounding = new Padding(1);
            cuiGradientPanel1.Size = new Size(1472, 911);
            cuiGradientPanel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(672, 426);
            label3.Name = "label3";
            label3.Size = new Size(522, 37);
            label3.TabIndex = 11;
            label3.Text = "controle de estoque e cadastro de clientes.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(477, 389);
            label2.Name = "label2";
            label2.Size = new Size(932, 37);
            label2.TabIndex = 10;
            label2.Text = "TechPoint é uma aplicação desenvolvida para gerenciar os serviços prestados,";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.BackColor = Color.Transparent;
            lblMensagem.Font = new Font("Segoe UI", 45F);
            lblMensagem.Location = new Point(731, 308);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(393, 81);
            lblMensagem.TabIndex = 9;
            lblMensagem.Text = "lblMensagem";
            lblMensagem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Transparent;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 18F);
            btnFechar.ForeColor = Color.Black;
            btnFechar.Location = new Point(1462, 37);
            btnFechar.Margin = new Padding(4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(65, 43);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Relatório";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverImageTint = Color.White;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(14, 721);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(30);
            cuiButton1.Size = new Size(377, 79);
            cuiButton1.TabIndex = 13;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            cuiButton1.Click += btnRelatorio_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1386, 788);
            Controls.Add(btnFechar);
            Controls.Add(cuiGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            gpbMenus.ResumeLayout(false);
            gpbMenus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            cuiGradientPanel1.ResumeLayout(false);
            cuiGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gpbMenus;
        private Button btnServico1;
        private Button button2;
        private Button btnVenda1;
        private Button btnRelatorio;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private CuoreUI.Controls.cuiButton btnOrdemServico;
        private CuoreUI.Controls.cuiGradientPanel cuiGradientPanel1;
        private CuoreUI.Controls.cuiButton btnEquipamento;
        private CuoreUI.Controls.cuiButton btnPessoa;
        private CuoreUI.Controls.cuiButton cuiButton6;
        private CuoreUI.Controls.cuiButton btnVenda;
        private CuoreUI.Controls.cuiButton btnServico;
        private CuoreUI.Controls.cuiButton btnPecaItem;
        private Button btnFechar;
        private Label label1;
        private Label lblMensagem;
        private PictureBox pictureBox8;
        private Label label2;
        private Label label3;
        private CuoreUI.Controls.cuiButton cuiButton1;
    }
}
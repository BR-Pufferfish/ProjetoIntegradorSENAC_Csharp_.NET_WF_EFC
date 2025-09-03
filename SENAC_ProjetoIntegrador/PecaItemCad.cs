using SENAC_ProjetoIntegrador.Entity;
using SENAC_ProjetoIntegrador.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENAC_ProjetoIntegrador
{
    public partial class PecaItemCad : Form
    {
        private PecaItem _pecaitem;
        public PecaItemCad()
        {
            InitializeComponent();
        }
        public PecaItemCad(PecaItem pecaSelecionada)
        {
            _pecaitem = pecaSelecionada;
            InitializeComponent();
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            if (_pecaitem != null)
            {
                cbbSituacao.Text = _pecaitem.Situacao;
                txtNome.Text = _pecaitem.Nome;
                txtAno.Text = _pecaitem.Ano.ToString();
                cbbSituacao.Text = _pecaitem.Tipo.ToString();
                cbbTipoEquipamento.Text = _pecaitem.TipoEquipamento;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelarpeca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvarpeca_Click(object sender, EventArgs e)
        {
            if (_pecaitem == null)
            {
                InserirPecaItem();
            }
            else
            {
                AtualizarPecaItem();
            }
        }

        private void AtualizarPecaItem()
        {
            using (var bd = new AplicacaoDBContext())
            {
                var nomePeca = txtNome.Text;
                if (bd.PecaItems.Any(pi => pi.Nome == nomePeca))
                {
                    MessageBox.Show("Já existe uma Peça/Item com esse nome",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var pecaItem = bd.PecaItems.FirstOrDefault(pi => pi.Id == _pecaitem.Id);
                pecaItem.Situacao = cbbSituacao.Text;
                pecaItem.Nome = txtNome.Text;

                bd.PecaItems.Update(pecaItem);
                bd.SaveChanges();
            }
            MessageBox.Show("Peça/Item salva com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirPecaItem()
        {
            using (var bd = new AplicacaoDBContext())
            {
                var nomePeca = txtNome.Text;

                if (bd.PecaItems.Any(pi => pi.Nome == nomePeca))
                {
                    MessageBox.Show("Já existe uma Peça/Item com esse nome",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var pecaItem = new PecaItem
                {
                    Nome = txtNome.Text,
                    DtInclusao = DateTime.Now,
                    Custo = decimal.Parse(txtCusto.Text),
                    Situacao = cbbSituacao.Text,
                    Valor = decimal.Parse(txtValor.Text),
                    Estoque = int.Parse(txtEstoque.Text),
                    CodBarras = int.Parse(txtCodBarra.Text),
                    NCM = int.Parse(txtNCM.Text),
                    Descricao = rtxDescricao.Text,
                    Ano = int.Parse(txtAno.Text),
                    Tipo = cbbSituacao.Text,
                    TipoEquipamento = cbbTipoEquipamento.Text
                };

                bd.PecaItems.Add(pecaItem);
                bd.SaveChanges();
            }
            MessageBox.Show("Peça/Item salvo com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void PecaItemCad_Load(object sender, EventArgs e)
        {
            CarregarCbbSituacao();
            CarregarCbbTipoPeca();
            CarregarCbbTipoEquipamento();
        }

        private void CarregarCbbTipoEquipamento()
        {
            var tipoEquipamento = new List<TipoEquipamento>();

            string[] tipoEquipamentos = System.Enum.GetNames(typeof(TipoEquipamento));
            cbbTipoEquipamento.Items.AddRange(tipoEquipamentos);
        }

        private void CarregarCbbTipoPeca()
        {
            var tipoPeca = new List<TipoPeca>();

            string[] tipoPecas = System.Enum.GetNames(typeof(TipoPeca));
            cbbTipoPeca.Items.AddRange(tipoPecas);
        }

        private void CarregarCbbSituacao()
        {
            var situacao = new List<Situacao>();

            string[] situacoes = System.Enum.GetNames(typeof(Situacao));
            cbbSituacao.Items.AddRange(situacoes);
        }
    }
}

using SENAC_ProjetoIntegrador.Entity;
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

            //Carregar dados da tela

            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            if (_pecaitem != null)
            {
                txtNome.Text = _pecaitem.Nome;
                cbbAno.Text = _pecaitem.Ano.ToString();
                cbbTipo.Text = _pecaitem.Tipo.ToString();
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
            //inserir
            if (_pecaitem == null)
            {
                InserirPecaItem();
            }
            //atualizar
            else
            {
                AtualizarPecaItem();
            }
        }

        private void AtualizarPecaItem()
        {
            using (var bd = new AplicacaoDBContext())
            {
                //capturar dados da tela
                var nomePeca = txtNome.Text;
                if (bd.PecaItems.Any(pi => pi.Nome == nomePeca))
                {
                    MessageBox.Show("Já existe uma Peça/Item com esse nome",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                ////atualizar dados
                var pecaItem = bd.PecaItems.FirstOrDefault(pi => pi.Id == _pecaitem.Id);
                pecaItem.Nome = txtNome.Text;

                //salvar as alterações no banco
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
                //capturar dados da tela
                var nomePeca = txtNome.Text;

                if (bd.PecaItems.Any(pi => pi.Nome == nomePeca))
                {
                    MessageBox.Show("Já existe uma Peça/Item com esse nome",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                ////Criar novo objeto PecaItem
                var pecaItem = new PecaItem
                {
                    Nome = txtNome.Text,
                    Custo = decimal.Parse(txtCusto.Text),
                    Valor = decimal.Parse(txtValor.Text),
                    Estoque = int.Parse(txtEstoque.Text),
                    CodBarras = int.Parse(txtCodBarra.Text),
                    NCM = int.Parse(txtNCM.Text),
                    Descricao = rtxDescricao.Text,
                    Ano = int.Parse(cbbAno.Text),
                    Tipo = cbbTipo.Text,
                    TipoEquipamento = cbbTipoEquipamento.Text
                };

                ////Adicionar o novo PecaItem ao contexto do banco de dados
                bd.PecaItems.Add(pecaItem);
                bd.SaveChanges();
            }
            MessageBox.Show("Peça/Item salvo com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }
    }
}

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
    public partial class VendaCad : Form
    {
        private Venda _venda;
        public VendaCad()
        {
            InitializeComponent();
        }

        public VendaCad(Venda venda)
        {
            _venda = venda;
            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            if (_venda != null)
            {
                txtCliente.Text = _venda.Cliente;
                txtCpfCnpj.Text = _venda.CpfCnpj;
                txtValorTotal.Text = _venda.ValorTotal.ToString("F2");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_venda == null)
            {
                InserirVenda();
            }
            else
            {
                AtualizarVenda();
            }
        }

        private void AtualizarVenda()
        {
            using (var bd = new AplicacaoDBContext())
            {
                if (bd.Venda.Any(e => e.Id == _venda.Id))
                {
                    MessageBox.Show("Já existe uma venda com esse ID.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                string cliente = txtCliente.Text;
                string cpfcnpj = txtCpfCnpj.Text;
                decimal valorTotal = decimal.Parse(txtValorTotal.Text);

                // Atualiza os dados da venda
                var venda = bd.Venda.First(x => x.Id == _venda.Id);
                venda.Cliente = cliente;
                venda.CpfCnpj = cpfcnpj;
                venda.ValorTotal = valorTotal;

                // Salva as alterações no banco de dados
                bd.Venda.Update(venda);
                bd.SaveChanges();
            }
            MessageBox.Show("Venda atualizada com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }
        

        private void InserirVenda()
        {
            using (var bd = new AplicacaoDBContext())
            {
                //capturar dados da tela
                var nomeVenda = txtCliente.Text; //verificar se essa variavel irá ser utilizada na tela de Venda

                // Verifica se já existe uma Venda com o mesmo nome
                if (bd.Venda.Any(e => e.Cliente == nomeVenda))
                {
                    MessageBox.Show("Já existe um serviço com esse nome.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string nome = txtNome.Text;
                string categoria = txtCategoria.Text;
                string tipo = cbbTipo.Text;
                decimal valor = decimal.Parse(txtValor.Text);
                string descricao = txtDescricao.Text;

                // Cria um novo Servico
                var criarNovoServico = new Servico()
                {
                    Nome = nome,
                    Categoria = categoria,
                    Tipo = tipo,
                    Valor = valor,
                    Descricao = descricao
                };

                // Adiciona Servico ao banco
                bd.Servicos.Add(criarNovoServico);
                bd.SaveChanges();
            }
            MessageBox.Show("Servico salvo com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }
    }
}

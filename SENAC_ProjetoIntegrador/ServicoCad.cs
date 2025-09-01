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
    public partial class ServicoCad : Form
    {
        private Servico _servico;
        public ServicoCad()
        {
            InitializeComponent();
        }
        public ServicoCad(Servico servico)
        {
            _servico = servico;

            CarregaDadosServico();
        }

        private void CarregaDadosServico()
        {
            if (_servico != null)
            {
                txtNome.Text = _servico.Nome;
                txtCategoria.Text = _servico.Categoria;
                cbbSituacao.Text = _servico.Tipo;
                txtValor.Text = _servico.Valor.ToString("F2");
                txtDescricao.Text = _servico.Descricao;

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
            if (_servico == null)
            {
                InserirServico();
            }
            else
            {
                AtualizarServico();
            }
        }

        private void AtualizarServico()
        {
            using (var bd = new AplicacaoDBContext())
            {
                // Verifica se já existe um servico com o mesmo nome
                if (bd.Servicos.Any(e => e.Nome == txtNome.Text && e.Id != _servico.Id))
                {
                    MessageBox.Show("Já existe um servico com esse nome.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                txtDescricao.Text = _servico.Descricao;

                string nome = txtNome.Text;
                string categoria = txtCategoria.Text;
                string tipo = cbbSituacao.Text;
                decimal valor = decimal.Parse(txtValor.Text);
                string descricao = txtDescricao.Text;

                // Atualiza os dados do servico
                var servico = bd.Servicos.First(x => x.Id == _servico.Id);
                servico.Nome = nome;
                servico.Categoria = categoria;
                servico.Tipo = tipo;
                servico.Valor = valor;
                servico.Descricao = descricao;

                // Salva as alterações no banco de dados
                bd.Servicos.Update(servico);
                bd.SaveChanges();
            }
            MessageBox.Show("Serviço atualizado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirServico()
        {
            using (var bd = new AplicacaoDBContext())
            {
                //capturar dados da tela
                var nomeServico = txtNome.Text;

                // Verifica se já existe um servico com o mesmo nome
                if (bd.Servicos.Any(e => e.Nome == nomeServico))
                {
                    MessageBox.Show("Já existe um serviço com esse nome.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string nome = txtNome.Text;
                string situacao = cbbSituacao.Text;
                string categoria = txtCategoria.Text;
                string tipo = cbbSituacao.Text;
                decimal valor = decimal.Parse(txtValor.Text);
                string descricao = txtDescricao.Text;

                // Cria um novo Servico
                var criarNovoServico = new Servico()
                {
                    Nome = nome,
                    Situacao = situacao,
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

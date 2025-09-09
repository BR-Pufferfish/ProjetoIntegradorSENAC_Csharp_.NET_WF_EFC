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
            CarregarCbbSituacao();
        }

        private void CarregarCbbSituacao()
        {
            var situacoes = new List<Situacao>();

            situacoes = System.Enum.GetValues(typeof(Situacao)).Cast<Situacao>().ToList();
        }

        private void CarregaDadosServico()
        {
            if (_servico != null)
            {
                cbbSituacao.Text = _servico.Situacao;
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
                //if (bd.Servicos.Any(e => e.Nome == txtNome.Text && e.Id != _servico.Id))
                //{
                //    MessageBox.Show("Já existe um servico com esse nome.",
                //        "Erro",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);
                //    return;
                //}
                txtDescricao.Text = _servico.Descricao;

                string situacao = cbbSituacao.Text;
                string nome = txtNome.Text;
                string categoria = txtCategoria.Text;
                string tipo = cbbSituacao.Text;
                decimal valor = decimal.Parse(txtValor.Text);
                string descricao = txtDescricao.Text;

                var servico = bd.Servicos.First(x => x.Id == _servico.Id);
                servico.Situacao = situacao;
                servico.Nome = nome;
                servico.Categoria = categoria;
                servico.Tipo = tipo;
                servico.Valor = valor;
                servico.Descricao = descricao;

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
                var nomeServico = txtNome.Text;

                //if (bd.Servicos.Any(e => e.Nome == nomeServico))
                //{
                //    MessageBox.Show("Já existe um serviço com esse nome.",
                //        "Erro",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);
                //    return;
                //}

                string nome = txtNome.Text;
                string situacao = cbbSituacao.Text;
                string categoria = txtCategoria.Text;
                string tipo = cbbSituacao.Text;
                decimal valor = decimal.Parse(txtValor.Text);
                string descricao = txtDescricao.Text;

                var criarNovoServico = new Servico()
                {
                    Nome = nome,
                    Situacao = situacao,
                    Categoria = categoria,
                    Tipo = tipo,
                    Valor = valor,
                    Descricao = descricao
                };

                bd.Servicos.Add(criarNovoServico);
                bd.SaveChanges();
            }
            MessageBox.Show("Servico salvo com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void ServicoCad_Load(object sender, EventArgs e)
        {
            CarregarCbbTipo();
        }

        private void CarregarCbbTipo()
        {
            var tipoServico = new List<TipoServico>();

            string[] tipoServicos = System.Enum.GetNames(typeof(TipoServico));
            cbbTipoServico.Items.AddRange(tipoServicos);
        }
    }
}

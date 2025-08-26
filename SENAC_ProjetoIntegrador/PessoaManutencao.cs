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
    public partial class PessoaManutencao : Form
    {
        Pessoa? pessoaSelecionada;
        public PessoaManutencao()
        {
            InitializeComponent();
        }

        private void PessoaManutencao_Load(object sender, EventArgs e)
        {
            BuscarPessoa();
        }

        private void BuscarPessoa()
        {
            using (var bd = new AplicacaoDBContext())
            {
                var pessoa = bd.Pessoas.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    pessoa = pessoa.Where(p =>
                                               p.Nome.ToLower().Contains(txtPesquisar.Text) ||
                                               p.Cpf_cnpj.ToLower().Contains(txtPesquisar.Text) ||
                                               p.Razaosoc.ToLower().Contains(txtPesquisar.Text)
                                         );
                }

                dataGridView1.DataSource = pessoa.ToList();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            new PessoaCad().ShowDialog();
            BuscarPessoa();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarPessoa();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pessoaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as Pessoa;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (pessoaSelecionada != null)
            {
                var pessoa = new PessoaCad(pessoaSelecionada);
                pessoa.ShowDialog();
                BuscarPessoa();
                pessoaSelecionada = null;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (pessoaSelecionada != null)
            {
                using (var bd = new AplicacaoDBContext())
                {
                    bd.Pessoas.Remove(pessoaSelecionada);
                    bd.SaveChanges();
                }
                MessageBox.Show("Pessoa removida com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarPessoa();
                pessoaSelecionada = null;

            }
            else
            {
                MessageBox.Show("Selecione uma Pessoa para remover.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

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
    public partial class ServicoManutencao : Form
    {
        Servico? servicoSelecionado;
        public ServicoManutencao()
        {
            InitializeComponent();
        }
        private void ServicoManutencao_Load(object sender, EventArgs e)
        {
            BuscarServico();
        }

        private void BuscarServico()
        {
            using (var bd = new AplicacaoDBContext())
            {
                var servico = bd.Servicos.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    servico = servico.Where(s => s.Id.ToString().Contains(txtPesquisar.Text) ||
                                                 s.Nome.ToLower().Contains(txtPesquisar.Text));
                }

                dataGridView1.DataSource = servico.ToList();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            new ServicoCad().ShowDialog();
            BuscarServico();

        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarServico();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var servicoSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Servico;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (servicoSelecionado != null)
            {
                var servico = new ServicoCad(servicoSelecionado);
                servico.ShowDialog();
                BuscarServico();
                servicoSelecionado = null;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (servicoSelecionado != null)
            {
                using (var bancoDeDados = new AplicacaoDBContext())
                {
                    bancoDeDados.Servicos.Remove(servicoSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Serviço removido com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarServico();
                servicoSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um serviço para remover.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

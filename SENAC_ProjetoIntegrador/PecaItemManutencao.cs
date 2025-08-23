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
    public partial class PecaItemManutencao : Form
    {
        PecaItem? pecaSelecionada;
        public PecaItemManutencao()
        {
            InitializeComponent();
        }

        private void PecaItemManutencao_Load(object sender, EventArgs e)
        {
            BuscarPecaItem();
        }

        private void BuscarPecaItem()
        {
            using (var db = new AplicacaoDBContext())
            {
                //consultar a tabela OrdemServico
                var pecaItem = db.PecaItems.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    pecaItem = pecaItem.Where(pi => pi.Id.ToString().Contains(txtPesquisar.Text) ||
                                     pi.CodBarras.ToString().Contains(txtPesquisar.Text));
                }

                dataGridView1.DataSource = pecaItem.ToList();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            new PecaItemCad().ShowDialog();
            BuscarPecaItem();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarPecaItem();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar a mesa selecionado
                pecaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as PecaItem;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (pecaSelecionada != null)
            {
                //abrir o formulario de edição
                var pecas = new PecaItemCad(pecaSelecionada);
                pecas.ShowDialog();
                //atualizar a lista de mesas
                BuscarPecaItem();
                pecaSelecionada = null;
            }
        }
    }
}

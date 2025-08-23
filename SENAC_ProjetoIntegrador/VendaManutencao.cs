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
    public partial class VendaManutencao : Form
    {
        Venda? vendaSelecionada;
        public VendaManutencao()
        {
            InitializeComponent();
        }

        private void VendaManutencao_Load(object sender, EventArgs e)
        {
            BuscarVenda();
        }

        private void BuscarVenda()
        {
            using (var bd = new AplicacaoDBContext())
            {
                var venda = bd.Venda.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    venda = venda.Where(v => v.Id.ToString().Contains(txtPesquisar.Text) ||
                                             v.Cliente.ToLower().Contains(txtPesquisar.Text) ||
                                             v.CpfCnpj.ToString().Contains(txtPesquisar.Text));
                }

                dataGridView1.DataSource = venda.ToList();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            new VendaCad().ShowDialog();
            BuscarVenda();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarVenda();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var vendaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as Venda;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //if (vendaSelecionada != null)
            //{
            //    var venda = new VendaCad(vendaSelecionada);
            //    venda.ShowDialog();
            //    BuscarVenda();
            //    vendaSelecionada = null;
            //}
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //if (vendaSelecionada != null)
            //{
            //    using (var bancoDeDados = new AplicacaoDBContext())
            //    {
            //        using (var bancoDeDados = new AplicacaoDBContext())
            //        {
            //            bancoDeDados.Venda.Remove(vendaSelecionada);
            //            bancoDeDados.SaveChanges();
            //        }
            //        MessageBox.Show("Venda removida com sucesso!", "Sucess",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        BuscarVenda();
            //        vendaSelecionada = null;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Selecione uma venda para remover.", "Aviso",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
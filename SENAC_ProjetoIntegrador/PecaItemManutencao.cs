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
        public PecaItemManutencao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            new PecaItemCad().ShowDialog();
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
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarPecaItem();
        }
    }
}

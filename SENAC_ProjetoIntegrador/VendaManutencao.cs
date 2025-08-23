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
        //Venda? vendaSelecionada;
        public VendaManutencao()
        {
            InitializeComponent();
        }

        //private void VendaManutencao_Load(object sender, EventArgs e)
        //{
        //    BuscarVenda();
        //}

        //private void BuscarVenda()
        //{
        //    using (var bd = new AplicacaoDBContext())
        //    {
        //        var venda = bd.Venda.AsQueryable();
        //        if (!string.IsNullOrEmpty(txtPesquisar.Text))
        //        {
        //            venda = venda.Where(v => v.Nome.ToLower().Contains(txtPesquisar.Text) ||
        //                                                 v.Modelo.ToLower().Contains(txtPesquisar.Text) ||
        //                                                 v.CodBarra.ToString().Contains(txtPesquisar.Text));
        //        }

        //        dataGridView1.DataSource = venda.ToList();
        //    }
        //}
    }
}

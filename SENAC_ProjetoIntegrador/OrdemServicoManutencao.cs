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
    public partial class OrdemServicoManutencao : Form
    {
        public OrdemServicoManutencao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            //Busca de ordens de serviço
            BuscarOrdemServico();
        }

        private void OrdemServicoManutencao_Load(object sender, EventArgs e)
        {
            //Busca de ordens de serviço
            BuscarOrdemServico();
        }

        private void BuscarOrdemServico()
        {
            using (var db = new AplicacaoDBContext())
            {
                //consultar a tabela OrdemServico
                var ordemServicos = db.OrdemServicos.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    ordemServicos = ordemServicos.Where(os => os.Id.ToString().Contains(txtPesquisar.Text) ||
                                     os.Cliente.Contains(txtPesquisar.Text) ||
                                     os.Equipamento.Contains(txtPesquisar.Text));
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            new OrdemServicoCad().ShowDialog();
            BuscarOrdemServico();
        }
    }
}

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
        OrdemServicoCad? ordemSelecionada;
        public OrdemServicoManutencao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            //Busca de ordens de serviço
            BuscarOrdemServico();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar a ordem de serviço selecionada
                ordemSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as OrdemServicoCad;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //if (ordemSelecionada != null)
            //{
            //    //chamar o form de edição (que é o mesmo do cadastro mas com dados preenchidos já)
            //    var ordemSer = new OrdemServicoCad(ordemSelecionada);
            //    ordemSer.ShowDialog();
            //    //atualizar a lista de ordens de serviço
            //    BuscarOrdemServico();
            //    ordemSer = null;
            //}
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //if (ordemSelecionada != null)
            //{
            //    using (var bd = new AplicacaoDBContext)
            //    {
            //        bd.OrdemServicos.Remove(ordemSelecionada);
            //        bd.SaveChanges();
            //    }
            //    MessageBox.Show("Ordem de serviço removida com sucesso!", "Sucesso",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    BuscarOrdemServico();
            //    ordemSelecionada = null;
            //}
            //else
            //{
            //    MessageBox.Show("Selecione uma ordem de serviço para remover.", "Aviso",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SENAC_ProjetoIntegrador.Entity;

namespace SENAC_ProjetoIntegrador
{
    public partial class EquipamentoManutencao : Form
    {
        Equipamento? equipamentoSelecionado;
        public EquipamentoManutencao()
        {
            InitializeComponent();
        }
        private void EquipamentoManutencao_Load(object sender, EventArgs e)
        {
            BuscarEquipamento();
        }

        private void BuscarEquipamento()
        {
            using (var bd = new AplicacaoDBContext())
            {
                var equipamento = bd.Equipamentos.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisar.Text))
                {
                    equipamento = equipamento.Where(c => c.Titulo.ToLower().Contains(txtPesquisar.Text) ||
                                                         c.Descricao.Contains(txtPesquisar.Text));
                }

                dataGridView1.DataSource = equipamento.ToList();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            new
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }




    }
}

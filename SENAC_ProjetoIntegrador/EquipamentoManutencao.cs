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
                    equipamento = equipamento.Where(e => e.Nome.ToLower().Contains(txtPesquisar.Text) ||
                                                         e.Modelo.ToLower().Contains(txtPesquisar.Text) ||
                                                         e.CodBarra.ToString().Contains(txtPesquisar.Text));
                }

                dataGridView1.DataSource = equipamento.ToList();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            new EquipamentoCad().ShowDialog();
            BuscarEquipamento();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            BuscarEquipamento();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                equipamentoSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Equipamento;
                btnEditar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (equipamentoSelecionado != null)
            {
                var equipamento = new EquipamentoCad(equipamentoSelecionado);
                equipamento.ShowDialog();
                BuscarEquipamento();
                equipamentoSelecionado = null;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (equipamentoSelecionado != null)
            {
                using(var bancoDeDados = new AplicacaoDBContext())
                {
                    bancoDeDados.Equipamentos.Remove(equipamentoSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Equipamento removido com sucesso!", "Sucesso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarEquipamento();
                equipamentoSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um equipamento para remover.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

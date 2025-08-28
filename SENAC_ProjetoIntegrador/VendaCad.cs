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
    public record EquipamentoDto(int Id, string Nome);
    public partial class VendaCad : Form
    {
        private Venda _venda;
        List<EquipamentoDto> equipamentosSelecionados = new List<EquipamentoDto>();
        EquipamentoDto equipamentoSelecionado = null;


        public VendaCad()
        {
            InitializeComponent();
        }


        public VendaCad(Venda venda)
        {
            _venda = venda;
            CarregarDadosDaTela();
        }


        private void VendaCad_Load(object sender, EventArgs e)
        {
            CarregarCbbEquipamentos();
            CarregarDadosDaTela();

            cbbEquipamento.SelectedIndex = -1;
        }


        private void CarregarCbbEquipamentos()
        {
            var equipamentos = new List<Equipamento>();

            using (var bd = new AplicacaoDBContext())
            {
                equipamentos = bd.Equipamentos.ToList();
            }
            cbbEquipamento.DataSource = equipamentos;
            cbbEquipamento.DisplayMember = "Nome";
            cbbEquipamento.ValueMember = "Id";
            cbbEquipamento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbEquipamento.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        private void CarregarDadosDaTela()
        {
            if (_venda != null)
            {
                txtCliente.Text = _venda.Cliente;
                txtCpfCnpj.Text = _venda.CpfCnpj;
                txtValorTotal.Text = _venda.ValorTotal.ToString("F2");
            }
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_venda == null)
            {
                InserirVenda();
            }
            else
            {
                AtualizarVenda();
            }
        }

        private void AtualizarVenda()
        {
            using (var bd = new AplicacaoDBContext())
            {
                if (bd.Venda.Any(e => e.Id == _venda.Id))
                {
                    MessageBox.Show("Já existe uma venda com esse ID.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                string cliente = txtCliente.Text;
                string cpfcnpj = txtCpfCnpj.Text;
                decimal valorTotal = decimal.Parse(txtValorTotal.Text);

                var venda = bd.Venda.First(x => x.Id == _venda.Id);
                venda.Cliente = cliente;
                venda.CpfCnpj = cpfcnpj;
                venda.ValorTotal = valorTotal;

                bd.Venda.Update(venda);
                bd.SaveChanges();
            }
            MessageBox.Show("Venda atualizada com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }


        private void InserirVenda()
        {
            using (var bd = new AplicacaoDBContext())
            {
                var nomeVenda = txtCliente.Text;

                string cliente = txtCliente.Text;
                string cpfcnpj = txtCpfCnpj.Text;
                decimal valorTotal = decimal.Parse(txtValorTotal.Text);

                var criarNovaVenda = new Venda()
                {
                    Cliente = cliente,
                    CpfCnpj = cpfcnpj,
                    ValorTotal = valorTotal
                };

                bd.Venda.Add(criarNovaVenda);

                foreach (EquipamentoDto dto in equipamentosSelecionados)
                {
                    //var vendaEquipamento = new VendaEquipamento()
                    //{
                    //    VendaId = criarNovaVenda.Id,
                    //    EquipamentoId = dto.Id
                    //};
                    //bd.VendaEquipamento.Add(vendaEquipamento);
                }

                bd.SaveChanges();
            }
            MessageBox.Show("Venda salva com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void btnAddVenda_Click(object sender, EventArgs e)
        {
            if (cbbEquipamento.SelectedItem == null) return;
            var idEquipamento = (int)cbbEquipamento.SelectedValue;
            var nomeEquipamento = cbbEquipamento.Text;
            equipamentosSelecionados.Add(new EquipamentoDto(idEquipamento, nomeEquipamento));
            dgvEquipamento.DataSource = null;
            dgvEquipamento.DataSource = equipamentosSelecionados;
        }

        private void dgvEquipamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            equipamentoSelecionado = dgvEquipamento.Rows[e.RowIndex].DataBoundItem as EquipamentoDto;
        }

        private void btnRemVenda_Click(object sender, EventArgs e)
        {
            if (equipamentoSelecionado != null)
            {
                equipamentosSelecionados.Remove(equipamentoSelecionado);
                dgvEquipamento.DataSource = null;
                dgvEquipamento.DataSource = equipamentosSelecionados;
                equipamentoSelecionado = null;
            }
        }
    }
}

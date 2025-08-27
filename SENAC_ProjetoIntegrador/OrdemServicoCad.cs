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
    public record ServicoDto(int id, string Nome);
    public record PecaItemDto(int id, string Nome);
    public partial class OrdemServicoCad : Form
    {
        private OrdemServico? _ordemservico;
        // Variável para armazenar o ID da ordem de serviço, se necessário
        List<ServicoDto> servicosSelecionados = new List<ServicoDto>();
        ServicoDto? servicoSelecionado = null;

        List<PecaItemDto> pecasSelecionadas = new List<PecaItemDto>();
        PecaItemDto? pecaSelecionada = null;

        public OrdemServicoCad()
        {
            InitializeComponent();
        }

        public OrdemServicoCad(OrdemServico ordemServico)
        {
            _ordemservico = ordemServico;
            CarregarDadosDaTela();
        }



        private void OrdemServicoCad_Load(object sender, EventArgs e)
        {
            CarregarCbbEquipamento();
            CarregarCbbCliente();
            CarregarCbbCpfcnpj();
            CarregarCbbServicos();
            CarregarCbbPecaitem();

            // Se for uma nova ordem de serviço, limpar os campos
            cbbCliente.SelectedIndex = -1;
            cbbCpfcnpj.SelectedIndex = -1;
            cbbEquipamento.SelectedIndex = -1;
            cbbServico.SelectedIndex = -1;
            cbbPecaItem.SelectedIndex = -1;
        }

        private void CarregarDadosDaTela()
        {
            //popular os campos com as informações da ordem de serviço, se necessário
            if (_ordemservico != null)
            {
                cbbEquipamento.Text = _ordemservico.Equipamento;
                txtModelo.Text = _ordemservico.Modelo;
                cbbCliente.Text = _ordemservico.Cliente;
                cbbCpfcnpj.Text = _ordemservico.CpfCnpj.ToString();
                rtxDescricaoGeral.Text = _ordemservico.DescricaoGeral;
                rtxDescricaoEncerramento.Text = _ordemservico.DescricaoEncerramento;
                txtValorTotal.Text = _ordemservico.ValorTotal.ToString("F2"); // Formata o valor como moeda
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
            if (_ordemservico == null)
            {
                InserirOrdem();
            }
            else
            {
                AtualizarOrdem();
            }
        }

        private void AtualizarOrdem()
        {
            using (var bd = new AplicacaoDBContext())
            {
                //capturar dados da tela
                int.TryParse(txtSequencia.Text, out var idOrdem);

                if (bd.OrdemServicos.Any(os => os.Id == idOrdem))
                {
                    MessageBox.Show("Já existe uma Ordem com esse número",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //atualizar dados
                var ordemServico = bd.OrdemServicos.FirstOrDefault(os => os.Id == _ordemservico.Id);
                ordemServico.Equipamento = cbbEquipamento.Text;
                ordemServico.Modelo = txtModelo.Text;
                ordemServico.Cliente = cbbCliente.Text;
                ordemServico.CpfCnpj = int.Parse(cbbCpfcnpj.Text);
                ordemServico.DescricaoGeral = rtxDescricaoGeral.Text;
                ordemServico.DescricaoEncerramento = rtxDescricaoEncerramento.Text;
                ordemServico.ValorTotal = decimal.Parse(txtValorTotal.Text);

                //salvar as alterações no banco
                bd.OrdemServicos.Update(ordemServico);
                bd.SaveChanges();
            }
            MessageBox.Show("Ordem salva com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirOrdem()
        {
            using (var bd = new AplicacaoDBContext())
            {
                //TODO ZKFÇGKSDÇZLFGKS~ÇADFLKGSDÇLFGKSÇDLFGKSDÇLFKGSDÇLFKGSÇLDFKGÇSLDFKGÇLSDKFGÇLSDKFGÇLSDFKGÇLSDKFGLÇ

                string Equipamento = cbbEquipamento.Text;
                string Modelo = txtModelo.Text;
                string Cliente = cbbCliente.Text;
                int CpfCnpj = int.Parse(cbbCpfcnpj.Text);
                string DescricaoGeral = rtxDescricaoGeral.Text;
                decimal ValorTotal = decimal.Parse(txtValorTotal.Text);

                var ordemServico = new OrdemServico()
                {
                    Equipamento = cbbEquipamento.Text,
                    Modelo = txtModelo.Text,
                    Cliente = cbbCliente.Text,
                    CpfCnpj = int.Parse(cbbCpfcnpj.Text),
                    DescricaoGeral = rtxDescricaoGeral.Text,
                    ValorTotal = decimal.Parse(txtValorTotal.Text)
                };

                bd.OrdemServicos.Add(ordemServico);

                foreach (ServicoDto dto in servicosSelecionados)
                {
                    var ordemServicoServico = new OrdemServicoServico
                    {
                        OrdemServico = ordemServico,
                        ServicoId = dto.id
                    };
                    bd.OrdemServicoServico.Add(ordemServicoServico);
                }

                foreach (PecaItemDto dto in pecasSelecionadas)
                {
                    var ordemServicoPecaItem = new OrdemServicoPecaItem
                    {
                        OrdemServico = ordemServico,
                        PecaItemId = dto.id
                    };
                    bd.OrdemServicoPecaItem.Add(ordemServicoPecaItem);
                }

                bd.SaveChanges();
            }

        }

        private void CarregarCbbEquipamento()
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

        private void CarregarCbbCliente()
        {
            var pessoas = new List<Pessoa>();

            using (var bd = new AplicacaoDBContext())
            {
                pessoas = bd.Pessoas.ToList();
            }
            cbbCliente.DataSource = pessoas;
            cbbCliente.DisplayMember = "Nome";
            cbbCliente.ValueMember = "Id";
            cbbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CarregarCbbCpfcnpj()
        {
            var pessoas = new List<Pessoa>();

            using (var bd = new AplicacaoDBContext())
            {
                pessoas = bd.Pessoas.ToList();
            }
            cbbCpfcnpj.DataSource = pessoas;
            cbbCpfcnpj.DisplayMember = "Cpf_cnpj";
            cbbCpfcnpj.ValueMember = "Id";
            cbbCpfcnpj.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCpfcnpj.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CarregarCbbServicos()
        {
            var servicos = new List<Servico>();

            using (var bd = new AplicacaoDBContext())
            {
                servicos = bd.Servicos.ToList();
            }

            cbbServico.DataSource = servicos;
            cbbServico.DisplayMember = "Nome";
            cbbServico.ValueMember = "Id";
            cbbServico.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbServico.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CarregarCbbPecaitem()
        {
            var pecas = new List<PecaItem>();

            using (var bd = new AplicacaoDBContext())
            {
                pecas = bd.PecaItems.ToList();
            }
            cbbPecaItem.DataSource = pecas;
            cbbPecaItem.DisplayMember = "Nome";
            cbbPecaItem.ValueMember = "Id";
            cbbPecaItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbPecaItem.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        // Evento disparado quando o cliente é selecionado no ComboBox, trazendo o CPF/CNPJ correspondente
        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clienteSelecionado = cbbCliente.SelectedItem as Pessoa;
            if (clienteSelecionado != null)
            {
                // Atualiza o ComboBox de CPF/CNPJ com base no cliente selecionado
                cbbCpfcnpj.SelectedItem = clienteSelecionado;
                cbbCpfcnpj.Text = clienteSelecionado.Cpf_cnpj;
                cbbCpfcnpj.SelectedValue = clienteSelecionado.Id;
            }
        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            if (cbbServico.SelectedItem == null) return;
            var idServico = (int)cbbServico.SelectedValue;
            var nomeServico = cbbServico.Text;
            servicosSelecionados.Add(new ServicoDto(idServico, nomeServico));
            dgvServico.DataSource = null;
            dgvServico.DataSource = servicosSelecionados;
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignorar cliques no cabeçalho
            servicoSelecionado = dgvServico.Rows[e.RowIndex].DataBoundItem as ServicoDto;
        }

        private void btnRemServico_Click(object sender, EventArgs e)
        {
            if (servicoSelecionado != null)
            {
                servicosSelecionados.Remove(servicoSelecionado);
                dgvServico.DataSource = null;
                dgvServico.DataSource = servicosSelecionados;
                servicoSelecionado = null;
            }
        }

        private void btnAddPecaItem_Click(object sender, EventArgs e)
        {
            if (cbbPecaItem.SelectedItem == null) return;
            var idPecaItem = (int)cbbPecaItem.SelectedValue;
            var nomePecaItem = cbbPecaItem.Text;
            pecasSelecionadas.Add(new PecaItemDto(idPecaItem, nomePecaItem));
            dgvServico.DataSource = pecasSelecionadas;
        }

        private void dgvPecaItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignorar cliques no cabeçalho
            pecaSelecionada = dgvPecaItem.Rows[e.RowIndex].DataBoundItem as PecaItemDto;
        }

        private void btnRemPecaItem_Click(object sender, EventArgs e)
        {
            if (pecaSelecionada != null)
            {
                pecasSelecionadas.Remove(pecaSelecionada);
                dgvPecaItem.DataSource = null;
                dgvPecaItem.DataSource = pecasSelecionadas;
                pecaSelecionada = null;
            }
        }
    }
}

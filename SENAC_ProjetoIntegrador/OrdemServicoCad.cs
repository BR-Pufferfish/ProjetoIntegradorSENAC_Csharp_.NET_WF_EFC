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
    public partial class OrdemServicoCad : Form
    {
        private OrdemServico _ordemservico;
        // Variável para armazenar o ID da ordem de serviço, se necessário
        // List<Servico> servicosSelecionados = [];

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
            // Carrega os serviços dos ComboBox
            CarregarCbbEquipamento();
            CarregarCbbCliente();
            CarregarCbbCpfcnpj();
            CarregarCbbServicos();
            CarregarCbbPecaitem();
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
            //inserir
            if (_ordemservico == null)
            {
                InserirOrdem();
            }
            //atualizar
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

                if(bd.OrdemServicos.Any(os => os.Id == idOrdem))
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
                //verificar se isto é válido pois o ID não é editável
                int.TryParse(txtSequencia.Text, out var idOrdem);

                if (bd.OrdemServicos.Any(os => os.Id == idOrdem))
                {
                    MessageBox.Show("Já existe uma Ordem com esse número",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //Criar o objeto com os dados da tela
                var ordemServico = new OrdemServico()
                {
                    Id = idOrdem,
                    Equipamento = cbbEquipamento.Text,
                    Modelo = txtModelo.Text,
                    Cliente = cbbCliente.Text,
                    CpfCnpj = int.Parse(cbbCpfcnpj.Text),
                    DescricaoGeral = rtxDescricaoGeral.Text,
                    DescricaoEncerramento = rtxDescricaoEncerramento.Text,
                    ValorTotal = decimal.Parse(txtValorTotal.Text)
                };
            }

        }

        private void CarregarCbbEquipamento()
        {
            List<Equipamento> equipamentos = new List<Equipamento>()
            {

            };

            // Aqui você pode preencher a lista de equipamentos com dados reais do banco de dados ou de outra fonte
            using (var bd = new AplicacaoDBContext())
            {
                // Aqui você pode buscar os equipamentos do banco de dados, por exemplo:
                equipamentos = bd.Equipamentos.ToList();
            }
            cbbEquipamento.DataSource = equipamentos;
            cbbEquipamento.DisplayMember = "Nome"; // Exibe o nome do equipamento no ComboBox
            cbbEquipamento.ValueMember = "Id"; // Usa o Id como valor do ComboBox
            // Configura o ComboBox para permitir a pesquisa por nome
            cbbEquipamento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbEquipamento.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CarregarCbbCliente()
        {
            List<Pessoa> clientes = new List<Pessoa>()
            {

            };

            // Aqui você pode preencher a lista de clientes com dados reais do banco de dados ou de outra fonte
            using (var bd = new AplicacaoDBContext())
            {
                // Aqui você pode buscar os clientes do banco de dados, por exemplo:
                clientes = bd.Pessoas.ToList();
            }
            cbbCliente.DataSource = clientes;
            cbbCliente.DisplayMember = "Nome"; // Exibe o nome do cliente no ComboBox
            cbbCliente.ValueMember = "Id"; // Usa o Id como valor do ComboBox
            // Configura o ComboBox para permitir a pesquisa por nome
            cbbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CarregarCbbCpfcnpj()
        {
            List<Pessoa> clientes = new List<Pessoa>()
            {

            };

            // Aqui você pode preencher a lista de clientes com dados reais do banco de dados ou de outra fonte
            using (var bd = new AplicacaoDBContext())
            {
                // Aqui você pode buscar os clientes do banco de dados, por exemplo:
                clientes = bd.Pessoas.ToList();
            }
            cbbCpfcnpj.DataSource = clientes;
            cbbCpfcnpj.DisplayMember = "Cpf_cnpj"; // Exibe o CPF/CNPJ do cliente no ComboBox
            cbbCpfcnpj.ValueMember = "Id"; // Usa o Id como valor do ComboBox
            // Configura o ComboBox para permitir a pesquisa por nome
            cbbCpfcnpj.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCpfcnpj.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CarregarCbbServicos()
        {
            //utilizamos uma lista estatica mas aqui vai conectar à tabela respectiva do banco de dados
            List<Servico> servicos = new List<Servico>()
            {
                //Para utilizar esta lista estática, é preciso remover as restrições de required do Servico, pois o banco de dados não aceita valores nulos
                //new Servico { Id = 1, Nome = "Reparo de Computador" },
                //new Servico { Id = 2, Nome = "Instalação de Software" },
                //new Servico { Id = 3, Nome = "Manutenção de Impressora" }
            };

            using (var bd = new AplicacaoDBContext())
            {
                // Aqui você pode buscar os serviços do banco de dados, por exemplo:
                servicos = bd.Servicos.ToList();
            }

            //Aqui preenchemos o ComboBox com os serviços e com base no que esta sendo escrito ele filtra a lista para facilitar
            cbbServico.DataSource = servicos;
            cbbServico.DisplayMember = "Nome"; // Exibe o nome do serviço no ComboBox
            cbbServico.ValueMember = "Id"; // Usa o Id como valor do ComboBox
            // Configura o ComboBox para permitir a pesquisa por nome
            cbbServico.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbServico.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CarregarCbbPecaitem()
        {
            List<PecaItem> pecas = new List<PecaItem>()
            {

            };

            // Aqui você pode preencher a lista de peças com dados reais do banco de dados ou de outra fonte
            using (var bd = new AplicacaoDBContext())
            {
                // Aqui você pode buscar as peças do banco de dados, por exemplo:
                pecas = bd.PecaItems.ToList();
            }
            cbbPecaItem.DataSource = pecas;
            cbbPecaItem.DisplayMember = "Nome"; // Exibe o nome da peça no ComboBox
            cbbPecaItem.ValueMember = "Id"; // Usa o Id como valor do ComboBox
            // Configura o ComboBox para permitir a pesquisa por nome
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
                cbbCpfcnpj.SelectedItem = clienteSelecionado.Cpf_cnpj;
            }
        }

        
    }
}

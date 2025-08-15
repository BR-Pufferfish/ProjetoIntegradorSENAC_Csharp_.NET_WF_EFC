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
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Variável para armazenar o ID da ordem de serviço, se necessário
        // List<Servico> servicosSelecionados = [];

        public OrdemServicoCad()
        {
            InitializeComponent();
        }

        public OrdemServicoCad(Orde)
        {
            InitializeComponent();
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

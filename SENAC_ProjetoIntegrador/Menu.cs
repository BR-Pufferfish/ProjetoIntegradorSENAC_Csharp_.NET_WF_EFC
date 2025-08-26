using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using FastReport.Utils;
using Microsoft.VisualBasic.ApplicationServices;

namespace SENAC_ProjetoIntegrador
{
    public partial class Menu : Form
    { //CRIAR EVENTO DE CLICK PARA O BOTÃO DE VENDA
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(string nome, string senha)
        {
            InitializeComponent();
            lblHome.Text = "Usuário: " + nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formOrdemServico = new OrdemServicoManutencao();
            formOrdemServico.Show();
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            var formPessoa = new PessoaManutencao();
            formPessoa.Show();
        }

        private void btnEquipamento_Click(object sender, EventArgs e)
        {
            var formEquipamento = new EquipamentoManutencao();
            formEquipamento.Show();
        }

        private void btnPecaItem_Click(object sender, EventArgs e)
        {
            var formPecaItem = new PecaItemManutencao();
            formPecaItem.Show();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            var formServico = new ServicoManutencao();
            formServico.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            var relatorio = new Report();
            relatorio.Load("C: \\Users\\YURIPARANHOS\\source\\repos\\BR - Pufferfish\\ProjetoIntegradorSENAC_Csharp_.NET_WF_EFC\\SENAC_ProjetoIntegrador\\Relatorios\\PrimeiroRelatorio.frx");

            relatorio.SetParameterValue("Codigo do Chamado", 1234); // troque pelo ID real

            // Mostra o relatório
            relatorio.Save("@\"C:\\Users\\Aluno\\source\\repos\\SENAC_ProjetoIntegrador\\SENAC_ProjetoIntegrador\\Relatorios\\RelatorioOrdemServico.pdf");
        }
    }
}

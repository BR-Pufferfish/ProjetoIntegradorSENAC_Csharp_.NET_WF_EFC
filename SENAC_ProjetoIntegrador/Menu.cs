using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using FastReport.Export.PdfSimple;
using FastReport.Utils;
using Microsoft.VisualBasic.ApplicationServices;
using SENAC_ProjetoIntegrador.Properties;

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
            Report report = new Report();

            try
            {
                // Carrega o relatório embutido no Resources
                report.Load(@"C:\Users\YURIPARANHOS\source\repos\BR-Pufferfish\ProjetoIntegradorSENAC_Csharp_.NET_WF_EFC\SENAC_ProjetoIntegrador\Rel\PrimeiroRelatorio.frx");


                // Define os parâmetros
                report.SetParameterValue("Codigo do Chamado", 1234);
                report.SetParameterValue("Data do Atendimento", DateTime.Now.ToShortDateString());
                report.SetParameterValue("Cliente", "Empresa XYZ");
                report.SetParameterValue("Equipamento", "Notebook Dell");
                report.SetParameterValue("Ação Realizada", "Substituição do HD");
                report.SetParameterValue("Status", "Finalizado");

                // Prepara e exporta
                report.Prepare();
                PDFSimpleExport pdf = new PDFSimpleExport();
                report.Export(pdf, @"C:\Users\YURIPARANHOS\Desktop\teste1.pdf");
                Process.Start("explorer.exe", "/select,C:\\Users\\YURIPARANHOS\\Desktop\\teste1.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório: " + ex.Message);
            }
            finally
            {
                report.Dispose();
            }
        }
    }
}

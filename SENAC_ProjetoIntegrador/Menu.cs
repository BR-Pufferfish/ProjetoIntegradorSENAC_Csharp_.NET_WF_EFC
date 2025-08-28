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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Salvar Relatório Como";
                saveFileDialog.FileName = "RelatorioChamado.pdf"; // Nome padrão

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Report report = new Report();

                    try
                    {
                        // Carrega o relatório embutido no Resources
                        report.LoadFromString(SENAC_ProjetoIntegrador.Properties.Resources.PrimeiroRelatorio);

                        // ====== AQUI BUSCA OS DADOS DO BANCO ======
                        //using (var bancoDeDados = new AplicacaoDBContext())
                        //{
                        //    var chamado = bancoDeDados.OrdemServicoServico.FirstOrDefault(c => c.Codigo == 1234); // exemplo: código do chamado

                        //    if (chamado != null)
                        //    {
                        //        report.SetParameterValue("Codigo do Chamado", chamado.Codigo);
                        //        report.SetParameterValue("Data do Atendimento", chamado.DataAtendimento.ToShortDateString());
                        //        report.SetParameterValue("Cliente", chamado.ClienteNome);
                        //        report.SetParameterValue("Equipamento", chamado.Equipamento);
                        //        report.SetParameterValue("Ação Realizada", chamado.AcaoRealizada);
                        //        report.SetParameterValue("Status", chamado.Status);
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Chamado não encontrado!");
                        //        return;
                        //    }
                        //}
                        // ==========================================

                        // Prepara e exporta
                        report.Prepare();
                        PDFSimpleExport pdf = new PDFSimpleExport();
                        report.Export(pdf, saveFileDialog.FileName);

                        // Abre a pasta do arquivo e seleciona ele
                        Process.Start("explorer.exe", "/select,\"" + saveFileDialog.FileName + "\"");
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
    }
}

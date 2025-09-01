using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using FastReport.Export.PdfSimple;
using FastReport.Utils;
using Microsoft.VisualBasic.ApplicationServices;
using SENAC_ProjetoIntegrador.Entity;
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
            Application.Exit();
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
                        var relatorio = Resources.PrimeiroRelatorio;

                        var stringValueRel = Convert.ToBase64String(relatorio);

                        //string caminhoRelatorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Rel", "PrimeiroRelatorio.frx");

                        report.LoadFromString(stringValueRel);

                        var chamados = new List<OrdemServico>();
                        // ====== AQUI BUSCA OS DADOS DO BANCO ======
                        using (var bancoDeDados = new AplicacaoDBContext())
                        {
                            var  chamado = bancoDeDados.OrdemServicos.FirstOrDefault(c => c.Id == 2 ); // exemplo: código do chamado
                            
                            chamados = bancoDeDados.OrdemServicos.ToList();
                            if (chamado != null)
                            {
                                report.SetParameterValue("Codigo do Chamado", 22);
                                report.SetParameterValue("Cliente", "tico molo");
                                report.SetParameterValue("Equipamento", "Boneca inflavel");
                                report.SetParameterValue("Ação Realizada", "Fui");
                            }
                            else
                            {
                                MessageBox.Show("Chamado não encontrado!");
                                return;
                            }
                        }
                        // ==========================================

                        // Prepara e exporta
                       
                        report.RegisterData(chamados, "Chamados");

                        // Ativar o DataSource
                        report.GetDataSource("Chamados").Enabled = true;

                        var dataBand = report.FindObject("Data1") as FastReport.DataBand;
                        if (dataBand != null)
                        {
                            dataBand.DataSource = report.GetDataSource("Chamados");
                        }
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

using System.Diagnostics;
using FastReport;
using FastReport.Export.PdfSimple;
using SENAC_ProjetoIntegrador.Entity;
using SENAC_ProjetoIntegrador.Extensions;
using SENAC_ProjetoIntegrador.Properties;

namespace SENAC_ProjetoIntegrador
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(string nome, string senha)
        {
            InitializeComponent();
            lblMensagem.Text = "Bem-vindo " + nome + "!";
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
        private void btnVenda_Click(object sender, EventArgs e)
        {
            var formVenda = new VendaManutencao();
            formVenda.Show();
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

                        report.LoadFromString(stringValueRel);

                        var chamados = new List<OrdemServico>();
                        // ====== AQUI BUSCA OS DADOS DO BANCO ======
                        using (var bancoDeDados = new AplicacaoDBContext())
                        {
                            var ordemServicos = bancoDeDados.OrdemServicos.ToList();

                            if (ordemServicos.IsNullOrEmpty())
                            {
                                MessageBox.Show("Chamado não encontrado!");
                                return;
                            }

                            chamados.AddRange(ordemServicos);
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

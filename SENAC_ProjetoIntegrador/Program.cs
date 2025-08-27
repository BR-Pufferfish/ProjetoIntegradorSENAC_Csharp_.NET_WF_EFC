using FastReport;
using FastReport.Export.PdfSimple;
using SENAC_ProjetoIntegrador.Properties;
using System;
using System.Reflection;

namespace SENAC_ProjetoIntegrador
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Inicializa o relatório
            Report report = new Report();

            var resourceName = "SENAC_ProjetoIntegrador.Rel.PrimeiroRelatorio.frx";

            // Carrega o relatório do recurso (arquivo .frx embutido)
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                report.Load(stream);

                // Define os valores dos parâmetros usados no relatório
                report.SetParameterValue("Codigo do Chamado", 1234);
                report.SetParameterValue("Data do Atendimento", DateTime.Now.ToShortDateString());
                report.SetParameterValue("Cliente", "Empresa XYZ");
                report.SetParameterValue("Equipamento", "Notebook Dell");
                report.SetParameterValue("Ação Realizada", "Substituição do HD");
                report.SetParameterValue("Status", "Finalizado");

                // Prepara o relatório para exportação
                report.Prepare();

                //Exporta para PDF(usando caminho fixo - ajuste conforme necessário)
                //PDFSimpleExport pdf = new PDFSimpleExport();
                //report.Export(pdf, "C:\\Users\\Marcelo\\Desktop\\teste1.pdf");

                // Libera recursos
                report.Dispose();
            }



            // Executa o formulário da aplicação (se necessário)
            ApplicationConfiguration.Initialize();
            Application.Run(new ServicoManutencao());
        }
    }
}
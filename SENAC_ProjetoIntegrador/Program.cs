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
            // Inicializa o relat�rio
            Report report = new Report();

            var resourceName = "SENAC_ProjetoIntegrador.Rel.PrimeiroRelatorio.frx";

            // Carrega o relat�rio do recurso (arquivo .frx embutido)
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                report.Load(stream);

                // Define os valores dos par�metros usados no relat�rio
                report.SetParameterValue("Codigo do Chamado", 1234);
                report.SetParameterValue("Data do Atendimento", DateTime.Now.ToShortDateString());
                report.SetParameterValue("Cliente", "Empresa XYZ");
                report.SetParameterValue("Equipamento", "Notebook Dell");
                report.SetParameterValue("A��o Realizada", "Substitui��o do HD");
                report.SetParameterValue("Status", "Finalizado");

                // Prepara o relat�rio para exporta��o
                report.Prepare();

                //Exporta para PDF(usando caminho fixo - ajuste conforme necess�rio)
                //PDFSimpleExport pdf = new PDFSimpleExport();
                //report.Export(pdf, "C:\\Users\\Marcelo\\Desktop\\teste1.pdf");

                // Libera recursos
                report.Dispose();
            }



            // Executa o formul�rio da aplica��o (se necess�rio)
            ApplicationConfiguration.Initialize();
            Application.Run(new ServicoManutencao());
        }
    }
}
using FastReport;
using FastReport.Export.PdfSimple;
using SENAC_ProjetoIntegrador.Properties;
using System;

namespace SENAC_ProjetoIntegrador
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PessoaManutencao());
            Report report = new Report();
            var relatorioBuffer = Resources.PrimeiroRelatorio;
            report.LoadFromString(relatorioBuffer);
            report.SetParameterValue("Codigo do Chamado", 1234);
            report.Prepare();
            PDFSimpleExport pedf = new PDFSimpleExport();
            report.Export(pedf, "C:\\Users\\Marcelo\\Desktop\\teste1.pdf");
            report.Dispose();
        }
    }
}
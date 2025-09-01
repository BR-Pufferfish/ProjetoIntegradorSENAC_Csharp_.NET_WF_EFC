using FastReport;
using FastReport.Export.PdfSimple;
using SENAC_ProjetoIntegrador.Properties;
using System;
using System.Diagnostics;
using System.Reflection;

namespace SENAC_ProjetoIntegrador
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Inicializa o relatório
          




            // Executa o formulário da aplicação (se necessário)
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}
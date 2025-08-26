using FastReport;

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
            Application.Run(new Login());
            string firstReport = Path.Combine(Directory.GetCurrentDirectory(), @"\Relatorios\PrimeiroRelatorio.frx");
            Report report = Report.FromFile(firstReport);

           
            report.Prepare();

            using var pdfExport = new FastReport.Export.PdfSimple.PDFSimpleExport();
            using var reportStream = new MemoryStream();
            pdfExport.Export(report, reportStream);
            File.WriteAllBytes("C:\\Nova pastaRelatorio.pdf", reportStream.ToArray());



        }
    }
}
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
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), @"\Relatorios\PrimeiroRelatorio.frx");
            Report report = Report.FromFile(filepath);
        }
    }
}
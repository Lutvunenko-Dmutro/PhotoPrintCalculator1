namespace PhotoPrintCalculator
{
    internal static class Program
    {
        /// <summary>
        /// Головна точка входу у застосунок.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Ініціалізація конфігурації застосунку (шрифти, DPI тощо)
            ApplicationConfiguration.Initialize();
            // Запуск головної форми програми
            Application.Run(new Form1());
        }
    }
}
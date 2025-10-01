using System.Threading.Tasks;

namespace LoaderC_
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var splash = new loadscreen("Initializing...", 2))
            {
                splash.ShowDialog();
            } Application.Run(new Form1());
        }
    }
}
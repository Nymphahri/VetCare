namespace VetCare
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
            DialogResult resultado;
            do
            {
                using FrmLogin login = new FrmLogin();
                if (login.ShowDialog() != DialogResult.OK || login.UsuarioAutenticado == null)
                    return;

                using FrmPrincipal principal = new FrmPrincipal(login.UsuarioAutenticado);
                resultado = principal.ShowDialog();
            } while (resultado == DialogResult.Retry);
        }
    }
}

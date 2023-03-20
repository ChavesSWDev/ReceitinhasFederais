namespace ReceitinhasFederais
{
    public static class Program
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

            try
            {
                MessageBox.Show("Por favor aguarde, o programa está criando as pastas e arquivos necessários!");
                if (Directory.Exists(caminhoPasta) && File.Exists(caminhoTXT))
                {
                    MessageBox.Show("A pasta já existe e o arquivo também!");
                }
                else
                {
                    DirectoryInfo PastaContatos = Directory.CreateDirectory(caminhoPasta);
                    File.Create(caminhoTXT).Close();
                    MessageBox.Show("A Pasta foi criada com sucesso e o arquivo também!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível concluir as operações de criar pasta ou arquivo.txt.\nErro: ", e.ToString());
            }

            Application.Run(new MainMenu());
        }

        //trocar por " y: " caso estiver na facul e nao funcionar o codigo abaixo
        public static string caminhoTXT = @"c:\PastaReceitas\BancoDeReceitas.txt";

        //trocar por " y: " caso estiver na facul e nao funcionar o codigo abaixo
        public static string caminhoPasta = @"c:\PastaReceitas";

        public static List<Receitas> ListaReceitas = new List<Receitas>();
    }
}
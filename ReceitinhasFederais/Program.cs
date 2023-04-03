using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

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

            //esse if else vai verificar se já existe um caminho para o TXT auxiliar(que fica visível na pasta de arquivos)
            //e caso ele não existe, ele vai criar ele e adicionar umas letras aleatórias nele para funcionar como se os dados
            //estivesse criptografados, mas não, é só pro usuário pensar que está  manipulando o banco de dados mas não está.
            

            //esse try catch tenta criar o arquivo do banco de dados oficial, o que o programa utiliza pra manipular os dados.
            //esse TXT vai ficar visível enquanto o programa estiver sendo executado, mas após ele ser fechado, ele fica invisível
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
                MessageBox.Show("Não foi possível concluir as operações de criar pasta ou arquivo.txt.");
            }

            if (!File.Exists(caminhoTXTaux))
            {
                File.Create(caminhoTXTaux);
                File.WriteAllText(caminhoTXTaux, "kvhshxvdcpehvhdrolnpebzdrprrqhod\r\nkwmolsatpiwczxqzhkefffftlkgwipgj\r\ndzzkebiqtmtbuwdcdcxwbyvhlnjgpeiz\r\ntnngvhxgvrucyqooyxntrygmrefpbuck\r\nthnlqymfgvbjthcmbrlxkkmwlwlgiwsq\r\nnqoupiofsjhaxganbfarmgnzehlegbll\r\njfxfcofsimuthhgbkrrsrcgbflrnnjgn\r\netldezyvekmcengqgkvlcgnxikpxvlys\r\nrbvwyybwxgfihlfteghseasfwqzoerol\r\nqttogodumzrheydcacdvnclrhxndtwxd");
            }
            else
            {
                File.WriteAllText(caminhoTXTaux, "kvhshxvdcpehvhdrolnpebzdrprrqhod\r\nkwmolsatpiwczxqzhkefffftlkgwipgj\r\ndzzkebiqtmtbuwdcdcxwbyvhlnjgpeiz\r\ntnngvhxgvrucyqooyxntrygmrefpbuck\r\nthnlqymfgvbjthcmbrlxkkmwlwlgiwsq\r\nnqoupiofsjhaxganbfarmgnzehlegbll\r\njfxfcofsimuthhgbkrrsrcgbflrnnjgn\r\netldezyvekmcengqgkvlcgnxikpxvlys\r\nrbvwyybwxgfihlfteghseasfwqzoerol\r\nqttogodumzrheydcacdvnclrhxndtwxd");
            }

            Application.Run(new MainMenu());
        }

        //trocar por " y: " caso estiver na facul e nao funcionar o codigo abaixo
        public static string caminhoTXT = @"c:\PastaReceitas\BancoDeReceitas.txt";
        public static string caminhoTXTaux = @"c:\PastaReceitas\BancoReceitas.txt";


        //trocar por " y: " caso estiver na facul e nao funcionar o codigo abaixo
        public static string caminhoPasta = @"c:\PastaReceitas";

        //criando a lista de receita que iremos usar e a lista de receitas encontradas pra quando for pesquisar e mostrar as receitas
        //está sendo declarado aqui pra n ter q ficar declarando ela em todos os lugares do programa
        public static List<Receitas> ListaReceitas = new List<Receitas>();
        public static List<Receitas> ListaReceitasEncontradas = new List<Receitas>();
    }
}
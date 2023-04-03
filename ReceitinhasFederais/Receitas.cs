using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitinhasFederais
{
    public class Receitas
    {
        //isso aq é só a classe das receitas com métodos get e set para manipulação caso necessário e também com o construtor. geral sabe fazer isso
        public string Titulo { get; set; }
        public string Ingredientes { get; set; }
        public string ModoPreparo { get; set; }
        public string GrauDificuldade { get; set; }
        public string Autor { get; set; }
        public string TempoPreparo { get; set; }
        public string Categoria { get; set; }
        public int QntdPratos { get; set; }

        public Receitas() { }

        public Receitas(string titulo, string ingredientes, string modoPreparo, string grauDificuldade, string autor, string tempoPreparo, string categoria, int qntdpratos)
        {
            Titulo = titulo;
            Ingredientes = ingredientes;
            ModoPreparo = modoPreparo;
            if (grauDificuldade == "Fácil")
            {
                GrauDificuldade = "Fácil";
            }
            else if (grauDificuldade == "Médio")
            {
                GrauDificuldade = "Médio";
            }
            else if (grauDificuldade == "Difícil")
            {
                GrauDificuldade = "Difícil";
            }
            else if (grauDificuldade == "Experiente")
            {
                GrauDificuldade = "Experiente";
            }
            Autor = autor;
            TempoPreparo = tempoPreparo;
            Categoria = categoria;
            QntdPratos = qntdpratos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceitinhasFederais
{
    public partial class FormMostraDados : Form
    {
        public FormMostraDados(string data)
        {
            //esse form vai mostrar os dados vindo do clique duplo que o usuário fizer qnd tiver vendo os dados das receitas
            //a string data ali em cima é a referência do clique duplo
            InitializeComponent();
            txtData.Text = data;
            txtData.Multiline = true;
        }

        private void txtData_Load(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

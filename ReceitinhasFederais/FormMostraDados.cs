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
            InitializeComponent();
            txtData.Text = data;
            txtData.Multiline = true;
        }

        private void txtData_Load(object sender, EventArgs e)
        {

        }
    }
}

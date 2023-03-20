using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReceitinhasFederais;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReceitinhasFederais
{
    public partial class AdicionarReceitas : Form
    {
        public AdicionarReceitas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionarReceitas_Load(object sender, EventArgs e)
        {

        }
    }
}

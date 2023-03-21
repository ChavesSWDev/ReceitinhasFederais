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

            this.AutoScroll = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;

            cbCategoria.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fecha a aba(form)
            this.Close();
        }

        private void AdicionarReceitas_Load(object sender, EventArgs e)
        {
            //só ta aq por estar
        }

        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {

        }
    }
}

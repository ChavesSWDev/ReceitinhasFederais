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
    public partial class RemoverReceitas : Form
    {
        public RemoverReceitas()
        {
            InitializeComponent();

            string caminhoTXT = @"c:\PastaReceitas\BancoDeReceitas.txt";
            string lerArquivoReceitas = File.ReadAllText(caminhoTXT);
            var DesconverteLerArquivoReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(lerArquivoReceitas);

            if(DesconverteLerArquivoReceitas != null)
            {
                dgvMostraReceitas.Rows.Clear();
                dgvMostraReceitas.Columns.Clear();

                dgvMostraReceitas.Columns.Add("Titulo", "Titulo");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    dgvMostraReceitas.Rows.Add(pegaDados.Titulo);
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

        private void button3_Click(object sender, EventArgs e)
        {
            string caminhoTXT = @"c:\PastaReceitas\BancoDeReceitas.txt";
            string lerArquivoReceitas = File.ReadAllText(caminhoTXT);
            var DesconverteLerArquivoReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(lerArquivoReceitas);

            for(int i = 0; i < DesconverteLerArquivoReceitas.Count; i++)
            {
                if (txtRemoveReceita.Text.Equals(DesconverteLerArquivoReceitas[i].Titulo))
                {
                    DesconverteLerArquivoReceitas.RemoveAt(i);
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                    MessageBox.Show("Você deteletou a receita [" + txtRemoveReceita.Text + "] com sucesso!");
                } else
                {
                    MessageBox.Show("Não há uma receita com este Título cadastrada no sistema!");
                }
            }
        }

        private void RemoverReceitas_Load(object sender, EventArgs e)
        {
            string lerArquivoReceitas = File.ReadAllText(Program.caminhoTXT);
            if (lerArquivoReceitas.Length == 2 || lerArquivoReceitas.Length < 2)
            {
                MessageBox.Show("Não há receitas cadastradas!");
            }
        }

        private void dgvMostraReceitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

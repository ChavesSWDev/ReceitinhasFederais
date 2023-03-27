using Newtonsoft.Json;
using ReceitinhasFederais.Properties;
using System.Windows.Forms;

namespace ReceitinhasFederais
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            cbPesquisaReceitas.SelectedIndex = 0;
            dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new AdicionarReceitas());
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; 
            childForm.AutoScroll = true;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Enabled = false;
            this.VerticalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;

            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new RemoverReceitas());
        }

        private void cbPesquisaReceitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comentario
        }

        private void btnPesquisaReceitas_Click(object sender, EventArgs e)
        {
            dgvMostraReceitas.Rows.Clear();
            dgvMostraReceitas.Columns.Clear();

            string caminhoTXT = @"c:\PastaReceitas\BancoDeReceitas.txt";
            string lerArquivoReceitas = File.ReadAllText(caminhoTXT);
            var DesconverteLerArquivoReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(lerArquivoReceitas);

            if (cbPesquisaReceitas.SelectedIndex == 0)//tudo
            {
                dgvMostraReceitas.Columns.Add("Titulo", "Titulo");
                dgvMostraReceitas.Columns.Add("Ingredientes", "Ingredientes");
                dgvMostraReceitas.Columns.Add("Modo de Preparo", "Modo de Preparo");
                dgvMostraReceitas.Columns.Add("Grau de Dificuldade", "Grau de Dificuldade");
                dgvMostraReceitas.Columns.Add("Autor", "Autor");
                dgvMostraReceitas.Columns.Add("Tempo de Preparo", "Tempo de Preparo");
                dgvMostraReceitas.Columns.Add("Categoria", "Categoria");
                dgvMostraReceitas.Columns.Add("Por��es", "Por��es");

                if (lerArquivoReceitas.Length > 2)
                {
                    try
                    {
                        if (DesconverteLerArquivoReceitas != null)
                        {
                            foreach (var pegaDados in DesconverteLerArquivoReceitas)
                            {
                                dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.Ingredientes, pegaDados.ModoPreparo, pegaDados.GrauDificuldade, pegaDados.Autor, pegaDados.TempoPreparo, pegaDados.Categoria, pegaDados.QntdPratos);
                            }
                            dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("N�o h� receitas cadastradas!");
                    }
                }
                else
                {
                    MessageBox.Show("N�o h� receitas cadastradas!");
                }
            }
            else if (cbPesquisaReceitas.SelectedIndex == 1)//t�tulo
            {
                dgvMostraReceitas.Columns.Add("Titulo", "Titulo");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    dgvMostraReceitas.Rows.Add(pegaDados.Titulo);
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else if (cbPesquisaReceitas.SelectedIndex == 2)//ingredientes
            {
                dgvMostraReceitas.Columns.Add("T�tulo", "T�tulo");
                dgvMostraReceitas.Columns.Add("Ingredientes", "Ingredientes");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.Ingredientes);
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else if (cbPesquisaReceitas.SelectedIndex == 3)//modo de preparo
            {
                dgvMostraReceitas.Columns.Add("T�tulo", "T�tulo");
                dgvMostraReceitas.Columns.Add("Modo de Preparo", "Modo de Preparo");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.ModoPreparo);
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else if (cbPesquisaReceitas.SelectedIndex == 4)//dificuldade facil
            {
                dgvMostraReceitas.Columns.Add("T�tulo", "T�tulo");
                dgvMostraReceitas.Columns.Add("Dificuldade", "Dificuldade");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    if (pegaDados.GrauDificuldade == "F�cil")
                    {
                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.GrauDificuldade);
                    }
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else if (cbPesquisaReceitas.SelectedIndex == 5)//dificuldade media
            {
                dgvMostraReceitas.Columns.Add("T�tulo", "T�tulo");
                dgvMostraReceitas.Columns.Add("Dificuldade", "Dificuldade");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    if (pegaDados.GrauDificuldade == "M�dio")
                    {
                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.GrauDificuldade);
                    }
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else if (cbPesquisaReceitas.SelectedIndex == 6)//dificuldade dificil
            {
                dgvMostraReceitas.Columns.Add("T�tulo", "T�tulo");
                dgvMostraReceitas.Columns.Add("Dificuldade", "Dificuldade");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    if (pegaDados.GrauDificuldade == "Dif�cil")
                    {
                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.GrauDificuldade);
                    }
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else if (cbPesquisaReceitas.SelectedIndex == 7)//dificuldade experiente
            {
                dgvMostraReceitas.Columns.Add("T�tulo", "T�tulo");
                dgvMostraReceitas.Columns.Add("Dificuldade", "Dificuldade");
                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    if (pegaDados.GrauDificuldade == "Experiente")
                    {
                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.GrauDificuldade);
                    }
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else if (cbPesquisaReceitas.SelectedIndex == 8)//autor
            {
                dgvMostraReceitas.Columns.Add("T�tulo", "T�tulo");
                dgvMostraReceitas.Columns.Add("Autor", "Autor");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.Autor);
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else if (cbPesquisaReceitas.SelectedIndex == 9)//tempo de preparo
            {
                dgvMostraReceitas.Columns.Add("T�tulo", "T�tulo");
                dgvMostraReceitas.Columns.Add("Tempo de Preparo", "Tempo de Preparo");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.TempoPreparo);
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else if (cbPesquisaReceitas.SelectedIndex == 10)//categoria
            {
                dgvMostraReceitas.Columns.Add("T�tulo", "T�tulo");
                dgvMostraReceitas.Columns.Add("Categoria", "Categoria");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.Categoria);
                }

                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else if (cbPesquisaReceitas.SelectedIndex == 11)//qntd de pratos
            {
                dgvMostraReceitas.Columns.Add("T�tulo", "T�tulo");
                dgvMostraReceitas.Columns.Add("Por��es", "Por��es");

                foreach (var pegaDados in DesconverteLerArquivoReceitas)
                {
                    dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.QntdPratos);
                }
                dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dgvMostraReceitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMostraReceitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string data = dgvMostraReceitas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            FormMostraDados form = new FormMostraDados(data);
            form.ShowDialog();
        }
    }
}
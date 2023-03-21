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
            errorProvider1.Clear();
            bool erros = false;

            if(

                txtTitulo.Text.Trim() == "" ||
                txtIngredientes.Text.Trim() == "" ||
                txtModoPreparo.Text.Trim() == "" ||
                txtAutor.Text.Trim() == "" ||
                rdoFacil.Checked == false && 
                rdoMedio.Checked == false &&
                rdoDificil.Checked == false && 
                rdoExperiente.Checked == false || 
                txtTempoPreparo.Text.Trim() == ""
                
              )
            {
                MessageBox.Show("É necessário preencher todos os campos!");
                if (txtTitulo.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtTitulo, "Campo Obrigatório!");
                    erros = true;
                }
                if (txtIngredientes.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtIngredientes, "Campo Obrigatório!");
                    erros = true;
                }
                if (txtModoPreparo.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtModoPreparo, "Campo Obrigatório!");
                    erros = true;
                }
                if (txtAutor.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtAutor, "Campo Obrigatório!");
                    erros = true;
                }
                if (rdoFacil.Checked == false && rdoMedio.Checked == false &&
                rdoDificil.Checked == false && rdoExperiente.Checked == false)
                {
                    errorProvider1.SetError(rdoExperiente, "Campo Obrigatório!");
                    erros = true;
                }
                if (txtTempoPreparo.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtTempoPreparo, "Campo Obrigatório!");
                    erros = true;
                }
                erros = true;
            }

            if(erros == false)
            {
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string ingredientes = txtIngredientes.Text;
                string modopreparo = txtModoPreparo.Text;
                string tempopreparo = txtTempoPreparo.Text;
                string categoria = cbCategoria.Text;
                int qntdpratos = (int)qntdPratos.Value;
                string dificuldade = "";

                //variaveis auxiliares
                string auxTitulo = "";
                string auxAutor = "";
                string auxIngredientes = "";
                string auxModoPreparo = "";
                string auxTempoPreparo = "";
                string auxCategoria = "";
                int auxQntdPratos = 0;
                string auxDificuldade = "";

                //guardando o valor do radio button selecionado da dificuldade
                if (rdoFacil.Checked)
                    dificuldade = "Fácil";
                if (rdoMedio.Checked)
                    dificuldade = "Médio";
                if (rdoDificil.Checked)
                    dificuldade = "Difícil";
                if (rdoExperiente.Checked)
                    dificuldade = "Experiente";

                Receitas Receitas = new Receitas(titulo, ingredientes, modopreparo, dificuldade, autor, tempopreparo, categoria, qntdpratos);

                Program.ListaReceitas.Add(Receitas);
                MessageBox.Show("Receita Cadastrada com Sucesso!");
                //os dados da receita nova foram adicionados à lista

                //converter a lista das receitas para Json
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(Program.ListaReceitas, Newtonsoft.Json.Formatting.Indented);


                try
                {
                    if (File.Exists(Program.caminhoTXT))
                    {
                        string LeArquivo = File.ReadAllText(Program.caminhoTXT);
                        if (LeArquivo.Length != 0)
                        {
                            var desconverteLeArquivo = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(LeArquivo);
                            foreach (var pegaDado in desconverteLeArquivo)
                            {
                                auxTitulo = pegaDado.Titulo;
                                auxIngredientes = pegaDado.Ingredientes;
                                auxModoPreparo = pegaDado.ModoPreparo;
                                auxDificuldade = pegaDado.GrauDificuldade;
                                auxAutor = pegaDado.Autor;
                                auxTempoPreparo = pegaDado.TempoPreparo;
                                auxCategoria = pegaDado.Categoria;
                                auxQntdPratos = pegaDado.QntdPratos;

                                Program.ListaReceitas.Add(new Receitas(auxTitulo, auxIngredientes, auxModoPreparo, auxDificuldade, auxAutor, auxTempoPreparo, auxCategoria, auxQntdPratos));
                            }
                            string json2 = Newtonsoft.Json.JsonConvert.SerializeObject(Program.ListaReceitas, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(Program.caminhoTXT, json2);
                            Program.ListaReceitas.Clear();
                        }
                        else
                        {
                            File.WriteAllText(Program.caminhoTXT, json);
                            Program.ListaReceitas.Clear();
                        }
                    }
                } catch
                {
                    MessageBox.Show("O arquivo do banco de dados não existe por algum motivo!");
                }

                txtTitulo.Text = "";
                txtModoPreparo.Text = "";
                txtAutor.Text = "";
                txtIngredientes.Text = "";
                txtTempoPreparo.Text = "";
                cbCategoria.Text = "";
                rdoFacil.Checked = false;
                rdoDificil.Checked = false;
                rdoMedio.Checked = false;
                rdoExperiente.Checked = false;
                qntdPratos.Value = 1;
            }

        }
    }
}

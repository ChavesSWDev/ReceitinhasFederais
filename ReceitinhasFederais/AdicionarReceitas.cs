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

        //esse é o botao verde de add receita
        private void btnAdicionarReceita_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool erros = false;
            //esse if da linha 46 ate 93 é pra verificar se os campos estão preenchidos ou n, se estiver blz, se não ele da erro
            if (

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

            //se n tiver erro, ou seja os campos estao preenchidos, ele vai fazer isso aq
            if (erros == false)
            {
                //variaveis recebendo os valores de cada campo preenchido
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

                //criando uma receita com os valores de cada campo
                Receitas Receitas = new Receitas(titulo, ingredientes, modopreparo, dificuldade, autor, tempopreparo, categoria, qntdpratos);

                //os dados da receita nova foram adicionados à lista
                Program.ListaReceitas.Add(Receitas);

                //converter a lista das receitas para Json
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(Program.ListaReceitas, Newtonsoft.Json.Formatting.Indented);

                //aqui vai ler o arquivo e verificar se tem algum titulo igual ao que foi digitado
                string LeArquivo1 = File.ReadAllText(Program.caminhoTXT);
                var desconverteLeArquivo1 = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(LeArquivo1);
                if (desconverteLeArquivo1 != null)
                {
                    //percorre o desconverteLeArquivo1 que é uma lista de Receitas q foi desconvertido do arquivo txt
                    for (int i = 0; i < desconverteLeArquivo1.Count; i++)
                    {
                        auxTitulo = desconverteLeArquivo1[i].Titulo;
                        if (auxTitulo == titulo)
                        {
                            MessageBox.Show("Já tem uma receita com esse título cadastrada!\nPor favor, insira outro nome!");
                            txtTitulo.Text = "";
                            errorProvider1.SetError(txtTitulo, "Campo Obrigatório!");
                            erros = true;
                            break;
                        }
                    }
                }

                //continuando caso não ter acontecido nenhum erro
                if (erros != true)
                {
                    try
                    {
                        //se o arquivo existe, le o arquivo e faz outra var desconverteLeArquivo do tipo Lista de Receitas
                        if (File.Exists(Program.caminhoTXT))
                        {
                            string LeArquivo = File.ReadAllText(Program.caminhoTXT);
                            if (LeArquivo.Length != 0)
                            {
                                var desconverteLeArquivo = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(LeArquivo);

                                //cada valor auxiliar recebe o valor da receita lá dentro do arquivo
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

                                    //adicionando todas as receitas do arquivo na lista que está rodando no programa agora
                                    Program.ListaReceitas.Add(new Receitas(auxTitulo, auxIngredientes, auxModoPreparo, auxDificuldade, auxAutor, auxTempoPreparo, auxCategoria, auxQntdPratos));
                                }
                                //convertendo a lista pra json pra escrever no banco.txt dnv
                                string json2 = Newtonsoft.Json.JsonConvert.SerializeObject(Program.ListaReceitas, Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(Program.caminhoTXT, json2);
                                MessageBox.Show("Receita Cadastrada com Sucesso!");
                                Program.ListaReceitas.Clear();
                            }
                            else
                            {
                                //caso nao ter nenhuma receita cadastrada, ele só vai cadastrar a receita q ele acabou de adicionar os dados
                                File.WriteAllText(Program.caminhoTXT, json);
                                MessageBox.Show("Receita Cadastrada com Sucesso!");
                                Program.ListaReceitas.Clear();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("O arquivo do banco de dados não existe por algum motivo!\nPara corrigir esse problema, tente reiniciar o programa.");
                    }
                    //o código acima foi feito para o seguinte:
                    //vamos supor que dentro do arquivo já tem 10 receitas, e estamos usando o File.WriteAllText, e ele SOBRE ESCREVE o arquivo TODO
                    //ou seja, qnd usamos o File.WriteAllText, ele DELETA tudo oq tá la dentro e ESCREVE tudo dnv com os dados ATUAIS do programa
                    //então é por isso que serve as variáveis auxiliares, para caso o arquivo existir e caso ter dados lá dentro, as variáveis auxiliares
                    //receberem os valores das receitas lá dentro, e botar elas na lista atual que está rodando no programa, isso vai fazer com que
                    //tanto os dados que estavam lá dentro do arquivo, quanto os que estão rodando agora no programa, possam ser manipulados e salvos da forma correta
                    //ou seja, não perde os dados do arquivo e tbm adiciona os novos, tudo junto e sem repetir nenhuma receita por acidente.
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
}

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

            //verifica se alguma receita do programa tem o nome idêntico a uma existente
            string lerArquivoReceitas = File.ReadAllText(Program.caminhoTXT);
            var DesconverteLerArquivoReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(lerArquivoReceitas);
            List<Receitas> receitasDuplicadas = new List<Receitas>();
            List<Receitas> receitasUnicas = new List<Receitas>();
            bool TituloRepete = false;

            foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
            {
                if (DesconverteLerArquivoReceitas.Count(r => r.Titulo == pegaDado.Titulo) > 1)
                {
                    receitasDuplicadas.Add(pegaDado);
                    TituloRepete = true;
                }
                else
                {
                    receitasUnicas.Add(pegaDado);
                }
            }

            if (TituloRepete)
            {
                MessageBox.Show("Alguma receita possui um título idêntico à outra por algum motivo.\nPara corrigir isso e evitar que ocorra algum problema, as receitas que tiveram o título repetido, terão números aleatórios adicionados ao final.");
            }

            // adiciona um numero inteiro ao final de cada título da receita duplicada
            Random random = new Random();
            foreach (Receitas pegaDado in receitasDuplicadas)
            {
                pegaDado.Titulo = "Receita-" + random.Next().ToString();
            }
            List<Receitas> novaLista = receitasUnicas.Concat(receitasDuplicadas).ToList();
            string serializeSalvarDados2 = Newtonsoft.Json.JsonConvert.SerializeObject(novaLista, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(Program.caminhoTXT, serializeSalvarDados2);

            //qnd essa janela for selecionada, ele vai fazer um data grid view retornar apenas o TITULO de TODAS as receitas cadastradas no banco.
            string caminhoTXT = @"c:\PastaReceitas\BancoDeReceitas.txt";

            if (DesconverteLerArquivoReceitas != null)
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

        //esse botao fecha a janela
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //esse é aquele botao vermelho de remover
        private void button3_Click(object sender, EventArgs e)
        {
            string caminhoTXT = @"c:\PastaReceitas\BancoDeReceitas.txt";
            string lerArquivoReceitas = File.ReadAllText(caminhoTXT);
            var DesconverteLerArquivoReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(lerArquivoReceitas);
            bool receitaEncontrada = false;

            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================

            //verifica se alguma receita do programa tem a quantidade de porções menor que 1, se tiver, muda pra 1
            for (int i = 0; i < DesconverteLerArquivoReceitas.Count; i++)
            {
                if (DesconverteLerArquivoReceitas[i].QntdPratos < 1)
                {
                    MessageBox.Show("Alguma receita foi alterada indevidamente\nA quantidade de porções foi reduzida para um valor abaixo de 1, e isso não é permitido, por conta disso o valor foi alterado para 1.");
                    DesconverteLerArquivoReceitas[i].QntdPratos = 1;
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                }
            }
            //================ FINAL DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ FINAL DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ FINAL DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================

            //================================================================================

            //================ INICIO DA CORREÇÃO DO ERRO DE GRAU DE DIFICULDADE ================
            //================ INICIO DA CORREÇÃO DO ERRO DE GRAU DE DIFICULDADE ================
            //================ INICIO DA CORREÇÃO DO ERRO DE GRAU DE DIFICULDADE ================

            //verifica se alguma receita do programa tem o grau de dificuldade diferente do especificado, e se tiver será alterado para "Fácil"
            for (int i = 0; i < DesconverteLerArquivoReceitas.Count; i++)
            {
                if (
                        DesconverteLerArquivoReceitas[i].GrauDificuldade != "Fácil" &&
                        DesconverteLerArquivoReceitas[i].GrauDificuldade != "Médio" &&
                        DesconverteLerArquivoReceitas[i].GrauDificuldade != "Difícil" &&
                        DesconverteLerArquivoReceitas[i].GrauDificuldade != "Experiente"
                    )
                {
                    MessageBox.Show("Alguma receita foi alterada indevidamente\nO Grau de Dificuldade foi alterado para um valor diferente ao qual é aceitado no programa, portanto para a receita o qual ocorreu essa alteração, sua dificuldade será alterada para [FÁCIL]");
                    DesconverteLerArquivoReceitas[i].GrauDificuldade = "Fácil";
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                }
            }

            //================ FIM DA CORREÇÃO DO ERRO DE GRAU DE DIFICULDADE ================
            //================ FIM DA CORREÇÃO DO ERRO DE GRAU DE DIFICULDADE ================
            //================ FIM DA CORREÇÃO DO ERRO DE GRAU DE DIFICULDADE ================

            //================================================================================

            //================ INICIO CORREÇÃO DO ERRO DE TÍTULO IDÊNTICO ================
            //================ INICIO CORREÇÃO DO ERRO DE TÍTULO IDÊNTICO ================
            //================ INICIO CORREÇÃO DO ERRO DE TÍTULO IDÊNTICO ================

            //verifica se alguma receita do programa tem o nome idêntico a uma existente
            List<Receitas> receitasDuplicadas = new List<Receitas>();
            List<Receitas> receitasUnicas = new List<Receitas>();
            bool TituloRepete = false;

            foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
            {
                if (DesconverteLerArquivoReceitas.Count(r => r.Titulo == pegaDado.Titulo) > 1)
                {
                    receitasDuplicadas.Add(pegaDado);
                    TituloRepete = true;
                }
                else
                {
                    receitasUnicas.Add(pegaDado);
                }
            }

            if (TituloRepete)
            {
                MessageBox.Show("Alguma receita possui um título idêntico à outra por algum motivo.\nPara corrigir isso e evitar que ocorra algum problema, as receitas que tiveram o título repetido serão renomeadas para [Receita-ValorX].");
            }

            // adiciona um numero inteiro ao final de cada título da receita duplicada
            Random random = new Random();
            foreach (Receitas pegaDado in receitasDuplicadas)
            {
                pegaDado.Titulo = "Receita-" + random.Next().ToString();
            }
            List<Receitas> novaLista = receitasUnicas.Concat(receitasDuplicadas).ToList();
            string serializeSalvarDados2 = Newtonsoft.Json.JsonConvert.SerializeObject(novaLista, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(Program.caminhoTXT, serializeSalvarDados2);

            //================ FIM DA CORREÇÃO DO ERRO DE TÍTULO IDÊNTICO ================
            //================ FIM DA CORREÇÃO DO ERRO DE TÍTULO IDÊNTICO ================
            //================ FIM DA CORREÇÃO DO ERRO DE TÍTULO IDÊNTICO ================

            //============================================================================

            //================ INICIO CORREÇÃO DO ERRO DE CATEGORIA NÃO ESPECIFICADA ================
            //================ INICIO CORREÇÃO DO ERRO DE CATEGORIA NÃO ESPECIFICADA ================
            //================ INICIO CORREÇÃO DO ERRO DE CATEGORIA NÃO ESPECIFICADA ================

            for (int i = 0; i < DesconverteLerArquivoReceitas.Count; i++)
            {
                if (
                        DesconverteLerArquivoReceitas[i].Categoria != "Acompanhamento" &&
                        DesconverteLerArquivoReceitas[i].Categoria != "Bebida" &&
                        DesconverteLerArquivoReceitas[i].Categoria != "Prato Principal" &&
                        DesconverteLerArquivoReceitas[i].Categoria != "Sobremesa" &&
                        DesconverteLerArquivoReceitas[i].Categoria != "Salada" &&
                        DesconverteLerArquivoReceitas[i].Categoria != "Não Especificada"
                    )
                {
                    MessageBox.Show("Alguma receita foi alterada indevidamente\nA [Categoria] foi alterada para um valor diferente ao qual é aceitado no programa, portanto para a receita o qual ocorreu essa alteração, sua [Categoria] será alterada para [Não Especificada]");
                    DesconverteLerArquivoReceitas[i].Categoria = "Não Especificada";
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                }
            }

            //================ FIM DA CORREÇÃO DO ERRO DE CATEGORIA NÃO ESPECIFICADA ================
            //================ FIM DA CORREÇÃO DO ERRO DE CATEGORIA NÃO ESPECIFICADA ================
            //================ FIM DA CORREÇÃO DO ERRO DE CATEGORIA NÃO ESPECIFICADA ================

            //ele vai percorrer todas as receitas do banco, remover a receita que tenha o título idêntico ao que foi digitado
            //e mandar pro arquivo com os dados atualizados de que a receita foi excluída com sucesso.
            //a variavel receitaEncontrada fica true, ou seja encontrou a receita com o titulo desejado e excluiu, se não ele da um erro
            //dizendo q n foi encontrada a receita com o titulo desejado
            for (int i = 0; i < DesconverteLerArquivoReceitas.Count; i++)
            {
                if (txtRemoveReceita.Text.Equals(DesconverteLerArquivoReceitas[i].Titulo))
                {
                    DesconverteLerArquivoReceitas.RemoveAt(i);
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                    MessageBox.Show("Você deteletou a receita [" + txtRemoveReceita.Text + "] com sucesso!");
                    receitaEncontrada = true;
                    //caso a receita seja deletada, para atualizar o data grid view após clicar no botão ele faz esse if
                    //e caso o conteúdo lá dentro seja diferente de nulo, ele vai retornar 
                    lerArquivoReceitas = File.ReadAllText(caminhoTXT);
                    if (lerArquivoReceitas.Length > 2)
                    {
                        txtRemoveReceita.Text = null;
                        dgvMostraReceitas.Rows.Clear();
                        dgvMostraReceitas.Columns.Clear();

                        dgvMostraReceitas.Columns.Add("Titulo", "Titulo");

                        foreach (var pegaDados in DesconverteLerArquivoReceitas)
                        {
                            dgvMostraReceitas.Rows.Add(pegaDados.Titulo);
                        }

                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                    else
                    {
                        txtRemoveReceita.Text = null;
                        dgvMostraReceitas.Rows.Clear();
                        dgvMostraReceitas.Columns.Clear();
                        MessageBox.Show("Não há receitas cadastradas!");
                    }
                }
            }

            if (!receitaEncontrada)
            {
                txtRemoveReceita.Text = null;
                MessageBox.Show("Não foi encontrada nenhuma receita com o título inserido.");
                lerArquivoReceitas = File.ReadAllText(caminhoTXT);
                if (lerArquivoReceitas.Length > 2)
                {
                    txtRemoveReceita.Text = null;
                    dgvMostraReceitas.Rows.Clear();
                    dgvMostraReceitas.Columns.Clear();

                    dgvMostraReceitas.Columns.Add("Titulo", "Titulo");

                    foreach (var pegaDados in DesconverteLerArquivoReceitas)
                    {
                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo);
                    }

                    dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    txtRemoveReceita.Text = null;
                    dgvMostraReceitas.Rows.Clear();
                    dgvMostraReceitas.Columns.Clear();
                    MessageBox.Show("Não há receitas cadastradas!");
                }
            }
        }

        //se nao tiver receita cadastrada, mostrar a mensagem abaixo
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

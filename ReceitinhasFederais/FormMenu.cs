using Newtonsoft.Json;
using ReceitinhasFederais.Properties;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ReceitinhasFederais
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            //esse this.Shown vai mostrar uma msg na tela. o código está na linha 22 até a 25
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            //esse this.load é qnd o programa carregar, e definir o index da combo box do filtro pra 0 ou seja, vai ficar selecionado o valor "Tudo"
            //vai também deixar um texto pra qnd o mouse ficar em cima da text box que digita alguma coisa pra mostrar uma msg
            this.Load += new System.EventHandler(this.MainMenu_Load);
            string caminhoTXT = @"c:\PastaReceitas\BancoDeReceitas.txt";
            //isso define o arquivo TXT como normal, pra ser possível manipular ele qnd o programa estiver rodando.
            File.SetAttributes(caminhoTXT, FileAttributes.Normal);

            this.FormClosing += new FormClosingEventHandler(MainMenu_FormClosing);
        }

        //esse MainMenu_Shown é quando o menu é mostrado pela primeira vez e ele irá tanto mostrar essa mensagem quanto
        //verificar se a quantidade de porções de alguma receita é menor que 0, e se for, vai colocar ela como 1.
        private void MainMenu_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Caso queira visualizar todas as receitas cadastradas no sistema, digite 'Tudo' no campo 'Dado a ser pesquisado' com o filtro 'Tudo' selecionado.");

            string lerArquivoReceitas = File.ReadAllText(Program.caminhoTXT);
            var DesconverteLerArquivoReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(lerArquivoReceitas);
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
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            cbPesquisaReceitas.SelectedIndex = 0;
            dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            //cada um desses toolTip vai mostrar uma mensagem diferente qnd o mouse ficar em cima de cada botão do menu
            ToolTip toolTip = new ToolTip();

            string hoverTxtPesquisarDado = "Digite Tudo no filtro Tudo para mostrar todas as receitas cadastradas no sistema";
            toolTip.SetToolTip(txtPesquisarDado, hoverTxtPesquisarDado);

            string hoverBtnReceitas = "Mostrar a pesquisa de receitas.";
            toolTip.SetToolTip(btnReceitas, hoverBtnReceitas);

            string hoverBtnAdicionarReceitas = "Mostrar a janela para adicionar uma receita nova.";
            toolTip.SetToolTip(btnAdicionarReceita, hoverBtnAdicionarReceitas);

            string hoverBtnExcluirReceita = "Mostrar a janela para excluir uma receita.";
            toolTip.SetToolTip(btnExcluirReceita, hoverBtnExcluirReceita);

            string hoverBtnDuvidas = "Mostrar a janela de dúvidas.";
            toolTip.SetToolTip(btnDuvidas, hoverBtnDuvidas);

            string hoverBtnPesquisaReceitas = "Pesquisar o dado digitado.";
            toolTip.SetToolTip(btnPesquisaReceitas, hoverBtnPesquisaReceitas);

            string hoverCbPesquisaReceitas = "Escolher o tipo de dado.";
            toolTip.SetToolTip(cbPesquisaReceitas, hoverCbPesquisaReceitas);

            txtPesquisarDado.Select();
        }

        //aqui vai esconder a pasta do banco de dados do programa pro usuário não encontrá-la e pensar que a outra que está lá é a do banco.
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string caminhoTXT = @"c:\PastaReceitas\BancoDeReceitas.txt";
            File.SetAttributes(caminhoTXT, FileAttributes.Hidden);

        }



        private Form activeForm = null;

        //esse childForm faz com que todos os formulários abram no formulario principal mas do tamanho especificado do Painel usado.
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                txtPesquisarDado.Text = null;
                dgvMostraReceitas.Rows.Clear();
                dgvMostraReceitas.Columns.Clear();
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

        //esse botao só faz mostrar o menu inicial para pesquisar receitas.
        private void btnReceitas_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            txtPesquisarDado.Text = null;
            dgvMostraReceitas.Rows.Clear();
            dgvMostraReceitas.Columns.Clear();

            MessageBox.Show("Caso queira visualizar todas as receitas cadastradas no sistema, digite 'Tudo' no campo 'Dado a ser pesquisado' com o filtro 'Tudo' selecionado.");

            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================

            //verifica se alguma receita do programa tem a quantidade de porções menor que 1, se tiver, muda pra 1
            string lerArquivoReceitas = File.ReadAllText(Program.caminhoTXT);
            var DesconverteLerArquivoReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(lerArquivoReceitas);
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


            txtPesquisarDado.Select();
        }

        //esse botao mostra o menu de add receita
        private void BtnAdicionarReceita(object sender, EventArgs e)
        {
            //chama o formulario pra adicionar as receitas
            openChildForm(new AdicionarReceitas());
        }

        //botao de mostrar o menu de excluir receita
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new RemoverReceitas());

            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================

            //verifica se alguma receita do programa tem a quantidade de porções menor que 1, se tiver, muda pra 1
            string lerArquivoReceitas = File.ReadAllText(Program.caminhoTXT);
            var DesconverteLerArquivoReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(lerArquivoReceitas);
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
        }

        //botao de mostrar o menu de ajuda
        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDuvidas());
        }

        private void cbPesquisaReceitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comentario
        }

        //botao para pesquisar nas receitas algum dado
        private void btnPesquisaReceitas_Click(object sender, EventArgs e)
        {
            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ INICIO DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================

            //verifica se alguma receita do programa tem a quantidade de porções menor que 1, se tiver, muda pra 1
            string lerArquivoReceitas = File.ReadAllText(Program.caminhoTXT);
            var DesconverteLerArquivoReceitas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Receitas>>(lerArquivoReceitas);
            for (int i = 0; i < DesconverteLerArquivoReceitas.Count; i++)
            {
                if (DesconverteLerArquivoReceitas[i].Titulo == null)
                {
                    DesconverteLerArquivoReceitas[i].Titulo = "Arquivo Corrompido.";
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                } else if (DesconverteLerArquivoReceitas[i].Ingredientes == null)
                {
                    DesconverteLerArquivoReceitas[i].Ingredientes = "Arquivo Corrompido.";
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                } else if(DesconverteLerArquivoReceitas[i].ModoPreparo == null)
                {
                    DesconverteLerArquivoReceitas[i].ModoPreparo = "Arquivo Corrompido.";
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                } else if(DesconverteLerArquivoReceitas[i].Categoria == null)
                {
                    DesconverteLerArquivoReceitas[i].Categoria = "Arquivo Corrompido.";
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                } else if(DesconverteLerArquivoReceitas[i].GrauDificuldade == null)
                {
                    DesconverteLerArquivoReceitas[i].GrauDificuldade = "Arquivo Corrompido.";
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                } else if(DesconverteLerArquivoReceitas[i].QntdPratos == null)
                {
                    DesconverteLerArquivoReceitas[i].QntdPratos = 1;
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                } else if(DesconverteLerArquivoReceitas[i].Autor == null)
                {
                    DesconverteLerArquivoReceitas[i].Autor = "Arquivo Corrompido.";
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                } else if(DesconverteLerArquivoReceitas[i].TempoPreparo == null)
                {
                    DesconverteLerArquivoReceitas[i].TempoPreparo = "Arquivo Corrompido.";
                    string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                }
                
            }
            //================ FINAL DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ FINAL DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================
            //================ FINAL DA CORREÇÃO DO ERRO DE PORÇÕES MENOR QUE 1 ================

            //================================================================================

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

            //limpando as linhas e colunas do data grid view
            dgvMostraReceitas.Rows.Clear();
            dgvMostraReceitas.Columns.Clear();

            //lendo o arquivo e desconvertendo ele para uma Lista do tipo Receitas
            string caminhoTXT = @"c:\PastaReceitas\BancoDeReceitas.txt";

            //string q recebe o valor do text box denominado txtPesquisarDado
            string PesquisarDado = txtPesquisarDado.Text;

            //se não digitar nada no textbox, mostrar a mensagem abaixo
            if (string.IsNullOrEmpty(PesquisarDado))
            {
                MessageBox.Show("Por favor, insira algum dado");
            }
            else
            {
                //se digitar Tudo no textbox, mostrar TODAS as receitas cadastradas no sistema
                if (PesquisarDado.Equals("Tudo", StringComparison.OrdinalIgnoreCase) && cbPesquisaReceitas.SelectedIndex == 0)
                {
                    dgvMostraReceitas.Columns.Add("Titulo", "Titulo");//index 1
                    dgvMostraReceitas.Columns.Add("Ingredientes", "Ingredientes");//index 2
                    dgvMostraReceitas.Columns.Add("Modo de Preparo", "Modo de Preparo");//index 3
                    dgvMostraReceitas.Columns.Add("Grau de Dificuldade", "Grau de Dificuldade");//index 4
                    dgvMostraReceitas.Columns.Add("Autor", "Autor");//index 5
                    dgvMostraReceitas.Columns.Add("Tempo de Preparo", "Tempo de Preparo");//index 6
                    dgvMostraReceitas.Columns.Add("Categoria", "Categoria");//index 7
                    dgvMostraReceitas.Columns.Add("Porções", "Porções");//index 8

                    if (DesconverteLerArquivoReceitas != null)
                    {
                        foreach (Receitas pegaDados in DesconverteLerArquivoReceitas)
                        {
                            if (lerArquivoReceitas.Length > 2)
                            {
                                try
                                {
                                    if (DesconverteLerArquivoReceitas != null)
                                    {
                                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.Ingredientes, pegaDados.ModoPreparo, pegaDados.GrauDificuldade, pegaDados.Autor, pegaDados.TempoPreparo, pegaDados.Categoria, pegaDados.QntdPratos);

                                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Não há receitas cadastradas!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não há receitas cadastradas!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não há receitas cadastradas!");
                    }
                }
                //se digitar qualquer coisa com o filtro Tudo selecionado, esse if vai pesquisar o valor digitado em TODOS os campos da receita
                //e caso encontrar, vai ir mostrando todos os dados e falando onde ele foi encontrado(qual campo da receita)
                else if (cbPesquisaReceitas.SelectedIndex == 0)
                {
                    bool receitasEncontradas = false;
                    HashSet<string> CategoriasEncontradas = new HashSet<string>();

                    if (DesconverteLerArquivoReceitas != null)
                    {
                        //basicamente cada if representa um tipo de campo da receita como ingredientes, titulo, modo de preparo etc
                        //ele vai comparar o dado digitado com as strings contidas em cada campo, e se ele encontrar, ele vai 
                        //adicionar a receita inteira para uma lista auxiliar de receitas encontradas e vai adicionar o campo em que o
                        //dado digitado foi encontrado dentro o HashSet do tipo string e se ele não encontrar, vai dar uma msg de erro.
                        //caso ocorra de encontrar o mesmo dado digitado em mais de um campo de uma mesma receita, ele só vai adicionar o campo
                        //em que o dado foi encontrado.
                        foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
                        {
                            try
                            {
                                if (pegaDado.Ingredientes.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                                {
                                    if (!Program.ListaReceitasEncontradas.Contains(pegaDado))
                                    {
                                        Program.ListaReceitasEncontradas.Add(pegaDado);
                                        CategoriasEncontradas.Add("[Ingredientes]");
                                        receitasEncontradas = true;
                                    }
                                    else
                                    {
                                        CategoriasEncontradas.Add("[Ingredientes]");
                                        receitasEncontradas = true;
                                    }
                                }
                                if (pegaDado.Titulo.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                                {
                                    if (!Program.ListaReceitasEncontradas.Contains(pegaDado))
                                    {
                                        Program.ListaReceitasEncontradas.Add(pegaDado);
                                        CategoriasEncontradas.Add("[Titulo]");
                                        receitasEncontradas = true;
                                    }
                                    else
                                    {
                                        CategoriasEncontradas.Add("[Titulo]");
                                        receitasEncontradas = true;
                                    }
                                }
                                if (pegaDado.ModoPreparo.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                                {
                                    if (!Program.ListaReceitasEncontradas.Contains(pegaDado))
                                    {
                                        Program.ListaReceitasEncontradas.Add(pegaDado);
                                        CategoriasEncontradas.Add("[Modo Preparo]");
                                        receitasEncontradas = true;
                                    }
                                    else
                                    {
                                        CategoriasEncontradas.Add("[Modo Preparo]");
                                        receitasEncontradas = true;
                                    }
                                }
                                if (pegaDado.TempoPreparo.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                                {
                                    if (!Program.ListaReceitasEncontradas.Contains(pegaDado))
                                    {
                                        Program.ListaReceitasEncontradas.Add(pegaDado);
                                        CategoriasEncontradas.Add("[Tempo Preparo]");
                                        receitasEncontradas = true;
                                    }
                                    else
                                    {
                                        CategoriasEncontradas.Add("[Tempo Preparo]");
                                        receitasEncontradas = true;
                                    }
                                }
                                if (pegaDado.Autor.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                                {
                                    if (!Program.ListaReceitasEncontradas.Contains(pegaDado))
                                    {
                                        Program.ListaReceitasEncontradas.Add(pegaDado);
                                        CategoriasEncontradas.Add("[Autor]");
                                        receitasEncontradas = true;
                                    }
                                    else
                                    {
                                        CategoriasEncontradas.Add("[Autor]");
                                        receitasEncontradas = true;
                                    }
                                }
                                if (pegaDado.GrauDificuldade.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                                {
                                    if (!Program.ListaReceitasEncontradas.Contains(pegaDado))
                                    {
                                        Program.ListaReceitasEncontradas.Add(pegaDado);
                                        CategoriasEncontradas.Add("[Grau de Dificuldade]");
                                        receitasEncontradas = true;
                                    }
                                    else
                                    {
                                        CategoriasEncontradas.Add("[Grau de Dificuldade]");
                                        receitasEncontradas = true;
                                    }
                                }
                            } catch
                            {
                                MessageBox.Show("Os dados do arquivo estão corrompidos.");
                                for (int i = 0; i < DesconverteLerArquivoReceitas.Count; i++)
                                {
                                    if (DesconverteLerArquivoReceitas[i].Titulo == null)
                                    {
                                        DesconverteLerArquivoReceitas[i].Titulo = "Arquivo Corrompido.";
                                        string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                                        File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                                    }
                                    else if (DesconverteLerArquivoReceitas[i].Ingredientes == null)
                                    {
                                        DesconverteLerArquivoReceitas[i].Ingredientes = "Arquivo Corrompido.";
                                        string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                                        File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                                    }
                                    else if (DesconverteLerArquivoReceitas[i].ModoPreparo == null)
                                    {
                                        DesconverteLerArquivoReceitas[i].ModoPreparo = "Arquivo Corrompido.";
                                        string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                                        File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                                    }
                                    else if (DesconverteLerArquivoReceitas[i].Categoria == null)
                                    {
                                        DesconverteLerArquivoReceitas[i].Categoria = "Arquivo Corrompido.";
                                        string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                                        File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                                    }
                                    else if (DesconverteLerArquivoReceitas[i].GrauDificuldade == null)
                                    {
                                        DesconverteLerArquivoReceitas[i].GrauDificuldade = "Arquivo Corrompido.";
                                        string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                                        File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                                    }
                                    else if (DesconverteLerArquivoReceitas[i].QntdPratos == null)
                                    {
                                        DesconverteLerArquivoReceitas[i].QntdPratos = 1;
                                        string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                                        File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                                    }
                                    else if (DesconverteLerArquivoReceitas[i].Autor == null)
                                    {
                                        DesconverteLerArquivoReceitas[i].Autor = "Arquivo Corrompido.";
                                        string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                                        File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                                    }
                                    else if (DesconverteLerArquivoReceitas[i].TempoPreparo == null)
                                    {
                                        DesconverteLerArquivoReceitas[i].TempoPreparo = "Arquivo Corrompido.";
                                        string serializeSalvarDados = Newtonsoft.Json.JsonConvert.SerializeObject(DesconverteLerArquivoReceitas, Newtonsoft.Json.Formatting.Indented);
                                        File.WriteAllText(Program.caminhoTXT, serializeSalvarDados);
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não há receitas cadastradas!");
                    }

                    //caso nenhum dos ifs seja retornado true, ele cai aq como falso e da essa mensagem de erro, se não ele vai continuar rodando.
                    if (!receitasEncontradas)
                    {
                        MessageBox.Show("Não foi encontrado nenhum dado no filtro [" + cbPesquisaReceitas.Text + "] com o dado inserido.");
                    }
                    //aqui ele vai mostrar todos os campos e todos os dados deles, de todas as receitas que foram encontradas
                    //de dentro da lista de receitas encontradas com o valor digitado.
                    else
                    {
                        dgvMostraReceitas.Columns.Add("Titulo", "Titulo");//index 1
                        dgvMostraReceitas.Columns.Add("Ingredientes", "Ingredientes");//index 2
                        dgvMostraReceitas.Columns.Add("Modo de Preparo", "Modo de Preparo");//index 3
                        dgvMostraReceitas.Columns.Add("Grau de Dificuldade", "Grau de Dificuldade");//index 4
                        dgvMostraReceitas.Columns.Add("Autor", "Autor");//index 5
                        dgvMostraReceitas.Columns.Add("Tempo de Preparo", "Tempo de Preparo");//index 6
                        dgvMostraReceitas.Columns.Add("Categoria", "Categoria");//index 7
                        dgvMostraReceitas.Columns.Add("Porções", "Porções");//index 8

                        foreach (Receitas pegaDados in Program.ListaReceitasEncontradas)
                        {
                            if (lerArquivoReceitas.Length > 2)
                            {
                                try
                                {
                                    if (DesconverteLerArquivoReceitas != null)
                                    {
                                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.Ingredientes, pegaDados.ModoPreparo, pegaDados.GrauDificuldade, pegaDados.Autor, pegaDados.TempoPreparo, pegaDados.Categoria, pegaDados.QntdPratos);

                                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Não há receitas cadastradas!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não há receitas cadastradas!");
                            }
                        }
                        //vai mostrar uma messageBox dizendo essa mensagem para todos os campos que a informação digitada foi encontrada
                        string DadoEncontradoEm = "Dado encontrado nos seguintes filtros:\n" + Environment.NewLine;
                        foreach (string category in CategoriasEncontradas)
                        {
                            DadoEncontradoEm += category + Environment.NewLine;
                        }
                        MessageBox.Show(DadoEncontradoEm);
                        Program.ListaReceitasEncontradas.Clear();
                    }
                }
                //se digitar qualquer coisa com o filtro Tudo selecionado, esse if vai pesquisar o valor digitado em TODOS os campos da receita
                //e caso encontrar, vai ir mostrando todos os dados e falando onde ele foi encontrado(qual campo da receita)
                else if (cbPesquisaReceitas.SelectedIndex == 1)
                {
                    bool receitasEncontradas = false;
                    HashSet<string> CategoriasEncontradas = new HashSet<string>();

                    if (DesconverteLerArquivoReceitas != null)
                    {
                        foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
                        {
                            if (pegaDado.Titulo.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                            {
                                Program.ListaReceitasEncontradas.Add(pegaDado);
                                CategoriasEncontradas.Add("[Titulo]");
                                receitasEncontradas = true;
                            }
                        }
                    }


                    if (!receitasEncontradas)
                    {
                        MessageBox.Show("Não foi encontrado nenhum dado no filtro [" + cbPesquisaReceitas.Text + "] com o dado inserido.");
                    }
                    else
                    {
                        dgvMostraReceitas.Columns.Add("Titulo", "Titulo");//index 1

                        foreach (Receitas pegaDados in Program.ListaReceitasEncontradas)
                        {
                            if (lerArquivoReceitas.Length > 2)
                            {
                                try
                                {
                                    if (DesconverteLerArquivoReceitas != null)
                                    {
                                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo);

                                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Não há receitas cadastradas!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não há receitas cadastradas!");
                            }
                        }
                        string DadoEncontradoEm = "Dado encontrado com sucesso no filtro ";
                        foreach (string category in CategoriasEncontradas)
                        {
                            DadoEncontradoEm += category; // add found categories to message
                        }
                        MessageBox.Show(DadoEncontradoEm);
                        Program.ListaReceitasEncontradas.Clear();
                    }
                }
                //se digitar qualquer coisa com o filtro Tudo selecionado, esse if vai pesquisar o valor digitado em TODOS os campos da receita
                //e caso encontrar, vai ir mostrando todos os dados e falando onde ele foi encontrado(qual campo da receita)
                else if (cbPesquisaReceitas.SelectedIndex == 2)
                {
                    bool receitasEncontradas = false;
                    HashSet<string> CategoriasEncontradas = new HashSet<string>();

                    if (DesconverteLerArquivoReceitas != null)
                    {
                        foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
                        {
                            if (pegaDado.Ingredientes.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                            {
                                Program.ListaReceitasEncontradas.Add(pegaDado);
                                CategoriasEncontradas.Add("[Ingredientes]");
                                receitasEncontradas = true;
                            }
                        }
                    }


                    if (!receitasEncontradas)
                    {
                        MessageBox.Show("Não foi encontrado nenhum dado no filtro [" + cbPesquisaReceitas.Text + "] com o dado inserido.");
                    }
                    else
                    {
                        dgvMostraReceitas.Columns.Add("Titulo", "Titulo");//index 1
                        dgvMostraReceitas.Columns.Add("Ingredientes", "Ingredientes");//index 2

                        foreach (Receitas pegaDados in Program.ListaReceitasEncontradas)
                        {
                            if (lerArquivoReceitas.Length > 2)
                            {
                                try
                                {
                                    if (DesconverteLerArquivoReceitas != null)
                                    {
                                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.Ingredientes);

                                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Não há receitas cadastradas!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não há receitas cadastradas!");
                            }
                        }
                        string DadoEncontradoEm = "Dado encontrado com sucesso no filtro ";
                        foreach (string category in CategoriasEncontradas)
                        {
                            DadoEncontradoEm += category; // add found categories to message
                        }
                        MessageBox.Show(DadoEncontradoEm + Environment.NewLine + "\nO Título será mostrado para identificar de qual receita o dado se trata.");
                        Program.ListaReceitasEncontradas.Clear();
                    }
                }
                //se digitar qualquer coisa com o filtro Tudo selecionado, esse if vai pesquisar o valor digitado em TODOS os campos da receita
                //e caso encontrar, vai ir mostrando todos os dados e falando onde ele foi encontrado(qual campo da receita)
                else if (cbPesquisaReceitas.SelectedIndex == 3)
                {
                    bool receitasEncontradas = false;
                    HashSet<string> CategoriasEncontradas = new HashSet<string>();

                    if (DesconverteLerArquivoReceitas != null)
                    {
                        foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
                        {
                            if (pegaDado.ModoPreparo.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                            {
                                Program.ListaReceitasEncontradas.Add(pegaDado);
                                CategoriasEncontradas.Add("[Modo Preparo]");
                                receitasEncontradas = true;
                            }
                        }
                    }


                    if (!receitasEncontradas)
                    {
                        MessageBox.Show("Não foi encontrado nenhum dado no filtro [" + cbPesquisaReceitas.Text + "] com o dado inserido.");
                    }
                    else
                    {
                        dgvMostraReceitas.Columns.Add("Titulo", "Titulo");//index 1
                        dgvMostraReceitas.Columns.Add("Modo de Preparo", "Modo Preparo");//index 3

                        foreach (Receitas pegaDados in Program.ListaReceitasEncontradas)
                        {
                            if (lerArquivoReceitas.Length > 2)
                            {
                                try
                                {
                                    if (DesconverteLerArquivoReceitas != null)
                                    {
                                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.ModoPreparo);

                                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Não há receitas cadastradas!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não há receitas cadastradas!");
                            }
                        }
                        string DadoEncontradoEm = "Dado encontrado com sucesso no filtro ";
                        foreach (string category in CategoriasEncontradas)
                        {
                            DadoEncontradoEm += category; // add found categories to message
                        }
                        MessageBox.Show(DadoEncontradoEm + Environment.NewLine + "\nO Título será mostrado para identificar de qual receita o dado se trata.");
                        Program.ListaReceitasEncontradas.Clear();
                    }
                }
                //se digitar qualquer coisa com o filtro Tudo selecionado, esse if vai pesquisar o valor digitado em TODOS os campos da receita
                //e caso encontrar, vai ir mostrando todos os dados e falando onde ele foi encontrado(qual campo da receita)
                else if (cbPesquisaReceitas.SelectedIndex == 4)
                {
                    bool receitasEncontradas = false;
                    HashSet<string> CategoriasEncontradas = new HashSet<string>();

                    if (DesconverteLerArquivoReceitas != null)
                    {
                        foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
                        {
                            if (pegaDado.GrauDificuldade.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                            {
                                Program.ListaReceitasEncontradas.Add(pegaDado);
                                CategoriasEncontradas.Add("[Grau de Dificuldade]");
                                receitasEncontradas = true;
                            }
                        }
                    }


                    if (!receitasEncontradas)
                    {
                        MessageBox.Show("Não foi encontrado nenhum dado no filtro [" + cbPesquisaReceitas.Text + "] com o dado inserido.");
                    }
                    else
                    {
                        dgvMostraReceitas.Columns.Add("Titulo", "Titulo");//index 1
                        dgvMostraReceitas.Columns.Add("Grau de Dificuldade", "Grau de Dificuldade");//index 4

                        foreach (Receitas pegaDados in Program.ListaReceitasEncontradas)
                        {
                            if (lerArquivoReceitas.Length > 2)
                            {
                                try
                                {
                                    if (DesconverteLerArquivoReceitas != null)
                                    {
                                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.GrauDificuldade);

                                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Não há receitas cadastradas!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não há receitas cadastradas!");
                            }
                        }
                        string DadoEncontradoEm = "Dado encontrado com sucesso no filtro ";
                        foreach (string category in CategoriasEncontradas)
                        {
                            DadoEncontradoEm += category; // add found categories to message
                        }
                        MessageBox.Show(DadoEncontradoEm + Environment.NewLine + "\nO Título será mostrado para identificar de qual receita o dado se trata.");
                        Program.ListaReceitasEncontradas.Clear();
                    }
                }
                //se digitar qualquer coisa com o filtro Tudo selecionado, esse if vai pesquisar o valor digitado em TODOS os campos da receita
                //e caso encontrar, vai ir mostrando todos os dados e falando onde ele foi encontrado(qual campo da receita)
                else if (cbPesquisaReceitas.SelectedIndex == 5)
                {
                    bool receitasEncontradas = false;
                    HashSet<string> CategoriasEncontradas = new HashSet<string>();

                    if (DesconverteLerArquivoReceitas != null)
                    {
                        foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
                        {
                            if (pegaDado.Autor.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                            {
                                Program.ListaReceitasEncontradas.Add(pegaDado);
                                CategoriasEncontradas.Add("[Autor]");
                                receitasEncontradas = true;
                            }
                        }
                    }


                    if (!receitasEncontradas)
                    {
                        MessageBox.Show("Não foi encontrado nenhum dado no filtro [" + cbPesquisaReceitas.Text + "] com o dado inserido.");
                    }
                    else
                    {
                        dgvMostraReceitas.Columns.Add("Titulo", "Titulo");//index 1
                        dgvMostraReceitas.Columns.Add("Autor", "Autor");//index 5

                        foreach (Receitas pegaDados in Program.ListaReceitasEncontradas)
                        {
                            if (lerArquivoReceitas.Length > 2)
                            {
                                try
                                {
                                    if (DesconverteLerArquivoReceitas != null)
                                    {
                                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.Autor);

                                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Não há receitas cadastradas!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não há receitas cadastradas!");
                            }
                        }
                        string DadoEncontradoEm = "Dado encontrado com sucesso no filtro ";
                        foreach (string category in CategoriasEncontradas)
                        {
                            DadoEncontradoEm += category; // add found categories to message
                        }
                        MessageBox.Show(DadoEncontradoEm + Environment.NewLine + "\nO Título será mostrado para identificar de qual receita o dado se trata.");
                        Program.ListaReceitasEncontradas.Clear();
                    }
                }
                //se digitar qualquer coisa com o filtro Tudo selecionado, esse if vai pesquisar o valor digitado em TODOS os campos da receita
                //e caso encontrar, vai ir mostrando todos os dados e falando onde ele foi encontrado(qual campo da receita)
                else if (cbPesquisaReceitas.SelectedIndex == 6)
                {
                    bool receitasEncontradas = false;
                    HashSet<string> CategoriasEncontradas = new HashSet<string>();

                    if (DesconverteLerArquivoReceitas != null)
                    {
                        foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
                        {
                            if (pegaDado.TempoPreparo.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                            {
                                Program.ListaReceitasEncontradas.Add(pegaDado);
                                CategoriasEncontradas.Add("[Tempo de Preparo]");
                                receitasEncontradas = true;
                            }
                        }
                    }


                    if (!receitasEncontradas)
                    {
                        MessageBox.Show("Não foi encontrado nenhum dado no filtro [" + cbPesquisaReceitas.Text + "] com o dado inserido.");
                    }
                    else
                    {
                        dgvMostraReceitas.Columns.Add("Titulo", "Titulo");//index 1
                        dgvMostraReceitas.Columns.Add("Tempo de Preparo", "Tempo de Preparo");//index 6

                        foreach (Receitas pegaDados in Program.ListaReceitasEncontradas)
                        {
                            if (lerArquivoReceitas.Length > 2)
                            {
                                try
                                {
                                    if (DesconverteLerArquivoReceitas != null)
                                    {
                                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.TempoPreparo);

                                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Não há receitas cadastradas!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não há receitas cadastradas!");
                            }
                        }
                        string DadoEncontradoEm = "Dado encontrado com sucesso no filtro ";
                        foreach (string category in CategoriasEncontradas)
                        {
                            DadoEncontradoEm += category; // add found categories to message
                        }
                        MessageBox.Show(DadoEncontradoEm + Environment.NewLine + "\nO Título será mostrado para identificar de qual receita o dado se trata.");
                        Program.ListaReceitasEncontradas.Clear();
                    }
                }
                //se digitar qualquer coisa com o filtro Tudo selecionado, esse if vai pesquisar o valor digitado em TODOS os campos da receita
                //e caso encontrar, vai ir mostrando todos os dados e falando onde ele foi encontrado(qual campo da receita)
                else if (cbPesquisaReceitas.SelectedIndex == 7)
                {
                    bool receitasEncontradas = false;
                    HashSet<string> CategoriasEncontradas = new HashSet<string>();

                    if (DesconverteLerArquivoReceitas != null)
                    {
                        foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
                        {
                            if (pegaDado.Categoria.IndexOf(PesquisarDado, StringComparison.OrdinalIgnoreCase) != -1)
                            {
                                Program.ListaReceitasEncontradas.Add(pegaDado);
                                CategoriasEncontradas.Add("[Categoria]");
                                receitasEncontradas = true;
                            }
                        }
                    }


                    if (!receitasEncontradas)
                    {
                        MessageBox.Show("Não foi encontrado nenhum dado no filtro [" + cbPesquisaReceitas.Text + "] com o dado inserido.");
                    }
                    else
                    {
                        dgvMostraReceitas.Columns.Add("Titulo", "Titulo");//index 1
                        dgvMostraReceitas.Columns.Add("Categoria", "Categoria");//index 7

                        foreach (Receitas pegaDados in Program.ListaReceitasEncontradas)
                        {
                            if (lerArquivoReceitas.Length > 2)
                            {
                                try
                                {
                                    if (DesconverteLerArquivoReceitas != null)
                                    {
                                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.Categoria);

                                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Não há receitas cadastradas!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não há receitas cadastradas!");
                            }
                        }
                        string DadoEncontradoEm = "Dado encontrado com sucesso no filtro ";
                        foreach (string category in CategoriasEncontradas)
                        {
                            DadoEncontradoEm += category; // add found categories to message
                        }
                        MessageBox.Show(DadoEncontradoEm + Environment.NewLine + "\nO Título será mostrado para identificar de qual receita o dado se trata.");
                        Program.ListaReceitasEncontradas.Clear();
                    }
                }
                //se digitar qualquer coisa com o filtro Tudo selecionado, esse if vai pesquisar o valor digitado em TODOS os campos da receita
                //e caso encontrar, vai ir mostrando todos os dados e falando onde ele foi encontrado(qual campo da receita)
                else if (cbPesquisaReceitas.SelectedIndex == 8)
                {
                    bool receitasEncontradas = false;
                    HashSet<string> CategoriasEncontradas = new HashSet<string>();

                    if (DesconverteLerArquivoReceitas != null)
                    {
                        foreach (Receitas pegaDado in DesconverteLerArquivoReceitas)
                        {
                            if (pegaDado.QntdPratos.ToString().Equals(PesquisarDado))
                            {
                                Program.ListaReceitasEncontradas.Add(pegaDado);
                                CategoriasEncontradas.Add("[Porções]");
                                receitasEncontradas = true;
                            }
                        }
                    }


                    if (!receitasEncontradas)
                    {
                        MessageBox.Show("Não foi encontrado nenhum dado no filtro [" + cbPesquisaReceitas.Text + "] com o dado inserido.");
                    }
                    else
                    {
                        dgvMostraReceitas.Columns.Add("Titulo", "Titulo");//index 1
                        dgvMostraReceitas.Columns.Add("Porções", "Porções");//index 8

                        foreach (Receitas pegaDados in Program.ListaReceitasEncontradas)
                        {
                            if (lerArquivoReceitas.Length > 2)
                            {
                                try
                                {
                                    if (DesconverteLerArquivoReceitas != null)
                                    {
                                        dgvMostraReceitas.Rows.Add(pegaDados.Titulo, pegaDados.QntdPratos);

                                        dgvMostraReceitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Não há receitas cadastradas!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Não há receitas cadastradas!");
                            }
                        }
                        string DadoEncontradoEm = "Dado encontrado com sucesso no filtro ";
                        foreach (string category in CategoriasEncontradas)
                        {
                            DadoEncontradoEm += category; // add found categories to message
                        }
                        MessageBox.Show(DadoEncontradoEm + Environment.NewLine + "\nO Título será mostrado para identificar de qual receita o dado se trata.");
                        Program.ListaReceitasEncontradas.Clear();
                    }
                }
                //se digitar qualquer coisa com o filtro Tudo selecionado, esse if vai pesquisar o valor digitado em TODOS os campos da receita
                //e caso encontrar, vai ir mostrando todos os dados e falando onde ele foi encontrado(qual campo da receita)
            }
        }

        private void dgvMostraReceitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //clicamo errado e n vamos excluir pq vai q buga tudo e da trabalho pra excluir certinho dps
        }

        //aqui é quando o usuário clica duas vezes em algum campo do data grid view
        //por exemplo se ele clicar no titulo de alguma receita duas vezes, ela vai abrir uma janela nova contendo todo o dado contido dentro daquele campo
        private void dgvMostraReceitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string data = dgvMostraReceitas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            FormMostraDados form = new FormMostraDados(data);
            form.ShowDialog();
        }
    }
}
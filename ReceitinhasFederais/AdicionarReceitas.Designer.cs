namespace ReceitinhasFederais
{
    partial class AdicionarReceitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarReceitas));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModoPreparo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoFacil = new System.Windows.Forms.RadioButton();
            this.rdoMedio = new System.Windows.Forms.RadioButton();
            this.rdoDificil = new System.Windows.Forms.RadioButton();
            this.rdoExperiente = new System.Windows.Forms.RadioButton();
            this.txtTempoPreparo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.qntdPratos = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdicionarReceita = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qntdPratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adicionar Receita";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-1, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(515, 57);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 81);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "Ex: Bolo de Fubá";
            this.txtTitulo.Size = new System.Drawing.Size(231, 23);
            this.txtTitulo.TabIndex = 14;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(12, 138);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.PlaceholderText = "Ex: Farinha, Ovo entre outras coisas";
            this.txtIngredientes.Size = new System.Drawing.Size(231, 253);
            this.txtIngredientes.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingredientes";
            // 
            // txtModoPreparo
            // 
            this.txtModoPreparo.Location = new System.Drawing.Point(249, 81);
            this.txtModoPreparo.Multiline = true;
            this.txtModoPreparo.Name = "txtModoPreparo";
            this.txtModoPreparo.PlaceholderText = "Ex: Misture tudo em uma combuca...";
            this.txtModoPreparo.Size = new System.Drawing.Size(265, 310);
            this.txtModoPreparo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(249, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Modo de Preparo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(12, 417);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PlaceholderText = "Ex: Fulano de Tal";
            this.txtAutor.Size = new System.Drawing.Size(231, 23);
            this.txtAutor.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(311, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Grau de Dificuldade";
            // 
            // rdoFacil
            // 
            this.rdoFacil.AutoSize = true;
            this.rdoFacil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoFacil.Location = new System.Drawing.Point(249, 419);
            this.rdoFacil.Name = "rdoFacil";
            this.rdoFacil.Size = new System.Drawing.Size(49, 19);
            this.rdoFacil.TabIndex = 22;
            this.rdoFacil.TabStop = true;
            this.rdoFacil.Text = "Fácil";
            this.rdoFacil.UseVisualStyleBackColor = true;
            // 
            // rdoMedio
            // 
            this.rdoMedio.AutoSize = true;
            this.rdoMedio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoMedio.Location = new System.Drawing.Point(299, 419);
            this.rdoMedio.Name = "rdoMedio";
            this.rdoMedio.Size = new System.Drawing.Size(60, 19);
            this.rdoMedio.TabIndex = 23;
            this.rdoMedio.TabStop = true;
            this.rdoMedio.Text = "Médio";
            this.rdoMedio.UseVisualStyleBackColor = true;
            // 
            // rdoDificil
            // 
            this.rdoDificil.AutoSize = true;
            this.rdoDificil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoDificil.Location = new System.Drawing.Point(358, 419);
            this.rdoDificil.Name = "rdoDificil";
            this.rdoDificil.Size = new System.Drawing.Size(57, 19);
            this.rdoDificil.TabIndex = 24;
            this.rdoDificil.TabStop = true;
            this.rdoDificil.Text = "Difícil";
            this.rdoDificil.UseVisualStyleBackColor = true;
            // 
            // rdoExperiente
            // 
            this.rdoExperiente.AutoSize = true;
            this.rdoExperiente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoExperiente.Location = new System.Drawing.Point(421, 419);
            this.rdoExperiente.Name = "rdoExperiente";
            this.rdoExperiente.Size = new System.Drawing.Size(86, 19);
            this.rdoExperiente.TabIndex = 25;
            this.rdoExperiente.TabStop = true;
            this.rdoExperiente.Text = "Experiente";
            this.rdoExperiente.UseVisualStyleBackColor = true;
            // 
            // txtTempoPreparo
            // 
            this.txtTempoPreparo.Location = new System.Drawing.Point(12, 477);
            this.txtTempoPreparo.Name = "txtTempoPreparo";
            this.txtTempoPreparo.PlaceholderText = "Ex: 15 minutos...";
            this.txtTempoPreparo.Size = new System.Drawing.Size(231, 23);
            this.txtTempoPreparo.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tempo de Preparo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(335, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Não Especificado",
            "Acompanhamento",
            "Bebida",
            "Prato Principal",
            "Sobremesa",
            "Salada"});
            this.cbCategoria.Location = new System.Drawing.Point(274, 477);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(202, 23);
            this.cbCategoria.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(164, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Rendimento em Porções";
            // 
            // qntdPratos
            // 
            this.qntdPratos.Location = new System.Drawing.Point(182, 555);
            this.qntdPratos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qntdPratos.Name = "qntdPratos";
            this.qntdPratos.Size = new System.Drawing.Size(75, 23);
            this.qntdPratos.TabIndex = 31;
            this.qntdPratos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(263, 555);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Prato(s)";
            // 
            // btnAdicionarReceita
            // 
            this.btnAdicionarReceita.BackColor = System.Drawing.Color.Lime;
            this.btnAdicionarReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarReceita.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarReceita.Location = new System.Drawing.Point(207, 615);
            this.btnAdicionarReceita.Name = "btnAdicionarReceita";
            this.btnAdicionarReceita.Size = new System.Drawing.Size(91, 39);
            this.btnAdicionarReceita.TabIndex = 33;
            this.btnAdicionarReceita.Text = "Adicionar";
            this.btnAdicionarReceita.UseVisualStyleBackColor = false;
            this.btnAdicionarReceita.Click += new System.EventHandler(this.btnAdicionarReceita_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AdicionarReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(546, 666);
            this.Controls.Add(this.btnAdicionarReceita);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.qntdPratos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTempoPreparo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdoExperiente);
            this.Controls.Add(this.rdoDificil);
            this.Controls.Add(this.rdoMedio);
            this.Controls.Add(this.rdoFacil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModoPreparo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdicionarReceitas";
            this.Text = "Adicionar Receitas";
            this.Load += new System.EventHandler(this.AdicionarReceitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qntdPratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private TextBox txtTitulo;
        private TextBox txtIngredientes;
        private Label label3;
        private TextBox txtModoPreparo;
        private Label label4;
        private Label label5;
        private TextBox txtAutor;
        private Label label6;
        private RadioButton rdoFacil;
        private RadioButton rdoMedio;
        private RadioButton rdoDificil;
        private RadioButton rdoExperiente;
        private TextBox txtTempoPreparo;
        private Label label7;
        private Label label8;
        private ComboBox cbCategoria;
        private Label label9;
        private NumericUpDown qntdPratos;
        private Label label10;
        private Button btnAdicionarReceita;
        private ErrorProvider errorProvider1;
    }
}
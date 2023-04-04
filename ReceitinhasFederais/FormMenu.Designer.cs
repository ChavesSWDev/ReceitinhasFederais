namespace ReceitinhasFederais
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnDuvidas = new System.Windows.Forms.Button();
            this.btnExcluirReceita = new System.Windows.Forms.Button();
            this.btnAdicionarReceita = new System.Windows.Forms.Button();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.panelLogoMenu = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisarDado = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvMostraReceitas = new System.Windows.Forms.DataGridView();
            this.btnPesquisaReceitas = new System.Windows.Forms.Button();
            this.cbPesquisaReceitas = new System.Windows.Forms.ComboBox();
            this.panelSideMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraReceitas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelSideMenu.Controls.Add(this.btnDuvidas);
            this.panelSideMenu.Controls.Add(this.btnExcluirReceita);
            this.panelSideMenu.Controls.Add(this.btnAdicionarReceita);
            this.panelSideMenu.Controls.Add(this.btnReceitas);
            this.panelSideMenu.Controls.Add(this.panelLogoMenu);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 521);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnDuvidas
            // 
            this.btnDuvidas.FlatAppearance.BorderSize = 0;
            this.btnDuvidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuvidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDuvidas.Image = ((System.Drawing.Image)(resources.GetObject("btnDuvidas.Image")));
            this.btnDuvidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuvidas.Location = new System.Drawing.Point(1, 464);
            this.btnDuvidas.Name = "btnDuvidas";
            this.btnDuvidas.Size = new System.Drawing.Size(247, 45);
            this.btnDuvidas.TabIndex = 7;
            this.btnDuvidas.Text = "Dúvidas";
            this.btnDuvidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuvidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuvidas.UseVisualStyleBackColor = true;
            this.btnDuvidas.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExcluirReceita
            // 
            this.btnExcluirReceita.FlatAppearance.BorderSize = 0;
            this.btnExcluirReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirReceita.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirReceita.Image")));
            this.btnExcluirReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirReceita.Location = new System.Drawing.Point(0, 292);
            this.btnExcluirReceita.Name = "btnExcluirReceita";
            this.btnExcluirReceita.Size = new System.Drawing.Size(250, 45);
            this.btnExcluirReceita.TabIndex = 6;
            this.btnExcluirReceita.Text = "Excluir Receita";
            this.btnExcluirReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirReceita.UseVisualStyleBackColor = true;
            this.btnExcluirReceita.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionarReceita
            // 
            this.btnAdicionarReceita.FlatAppearance.BorderSize = 0;
            this.btnAdicionarReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarReceita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarReceita.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarReceita.Image")));
            this.btnAdicionarReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarReceita.Location = new System.Drawing.Point(-2, 226);
            this.btnAdicionarReceita.Name = "btnAdicionarReceita";
            this.btnAdicionarReceita.Size = new System.Drawing.Size(250, 45);
            this.btnAdicionarReceita.TabIndex = 5;
            this.btnAdicionarReceita.Text = "Adicionar Receita";
            this.btnAdicionarReceita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarReceita.UseVisualStyleBackColor = true;
            this.btnAdicionarReceita.Click += new System.EventHandler(this.BtnAdicionarReceita);
            // 
            // btnReceitas
            // 
            this.btnReceitas.FlatAppearance.BorderSize = 0;
            this.btnReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceitas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReceitas.Image = ((System.Drawing.Image)(resources.GetObject("btnReceitas.Image")));
            this.btnReceitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitas.Location = new System.Drawing.Point(0, 160);
            this.btnReceitas.Name = "btnReceitas";
            this.btnReceitas.Size = new System.Drawing.Size(250, 45);
            this.btnReceitas.TabIndex = 4;
            this.btnReceitas.Text = "Receitas";
            this.btnReceitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceitas.UseVisualStyleBackColor = true;
            this.btnReceitas.Click += new System.EventHandler(this.btnReceitas_Click);
            // 
            // panelLogoMenu
            // 
            this.panelLogoMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelLogoMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogoMenu.BackgroundImage")));
            this.panelLogoMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogoMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLogoMenu.Name = "panelLogoMenu";
            this.panelLogoMenu.Size = new System.Drawing.Size(250, 163);
            this.panelLogoMenu.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.label2);
            this.panelChildForm.Controls.Add(this.label1);
            this.panelChildForm.Controls.Add(this.txtPesquisarDado);
            this.panelChildForm.Controls.Add(this.splitter1);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Controls.Add(this.dgvMostraReceitas);
            this.panelChildForm.Controls.Add(this.btnPesquisaReceitas);
            this.panelChildForm.Controls.Add(this.cbPesquisaReceitas);
            this.panelChildForm.Location = new System.Drawing.Point(248, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(536, 521);
            this.panelChildForm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dado a ser pesquisado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtro de Dados";
            // 
            // txtPesquisarDado
            // 
            this.txtPesquisarDado.Location = new System.Drawing.Point(52, 291);
            this.txtPesquisarDado.Name = "txtPesquisarDado";
            this.txtPesquisarDado.Size = new System.Drawing.Size(246, 23);
            this.txtPesquisarDado.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 521);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 244);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dgvMostraReceitas
            // 
            this.dgvMostraReceitas.AllowUserToAddRows = false;
            this.dgvMostraReceitas.AllowUserToDeleteRows = false;
            this.dgvMostraReceitas.AllowUserToResizeColumns = false;
            this.dgvMostraReceitas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostraReceitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostraReceitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvMostraReceitas.BackgroundColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostraReceitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostraReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraReceitas.Location = new System.Drawing.Point(52, 321);
            this.dgvMostraReceitas.MultiSelect = false;
            this.dgvMostraReceitas.Name = "dgvMostraReceitas";
            this.dgvMostraReceitas.ReadOnly = true;
            this.dgvMostraReceitas.RowHeadersVisible = false;
            this.dgvMostraReceitas.RowHeadersWidth = 60;
            this.dgvMostraReceitas.RowTemplate.Height = 25;
            this.dgvMostraReceitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostraReceitas.Size = new System.Drawing.Size(443, 188);
            this.dgvMostraReceitas.TabIndex = 2;
            this.dgvMostraReceitas.TabStop = false;
            this.dgvMostraReceitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostraReceitas_CellContentClick);
            this.dgvMostraReceitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostraReceitas_CellDoubleClick);
            // 
            // btnPesquisaReceitas
            // 
            this.btnPesquisaReceitas.BackColor = System.Drawing.Color.Lime;
            this.btnPesquisaReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaReceitas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisaReceitas.Location = new System.Drawing.Point(413, 291);
            this.btnPesquisaReceitas.Name = "btnPesquisaReceitas";
            this.btnPesquisaReceitas.Size = new System.Drawing.Size(82, 23);
            this.btnPesquisaReceitas.TabIndex = 3;
            this.btnPesquisaReceitas.Text = "Pesquisar";
            this.btnPesquisaReceitas.UseVisualStyleBackColor = false;
            this.btnPesquisaReceitas.Click += new System.EventHandler(this.btnPesquisaReceitas_Click);
            // 
            // cbPesquisaReceitas
            // 
            this.cbPesquisaReceitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisaReceitas.FormattingEnabled = true;
            this.cbPesquisaReceitas.Items.AddRange(new object[] {
            "Tudo",
            "Título",
            "Ingredientes",
            "Modo Preparo",
            "Dificuldade",
            "Autor",
            "Tempo Preparo",
            "Categoria",
            "Porções"});
            this.cbPesquisaReceitas.Location = new System.Drawing.Point(317, 292);
            this.cbPesquisaReceitas.Name = "cbPesquisaReceitas";
            this.cbPesquisaReceitas.Size = new System.Drawing.Size(90, 23);
            this.cbPesquisaReceitas.TabIndex = 2;
            this.cbPesquisaReceitas.SelectedIndexChanged += new System.EventHandler(this.cbPesquisaReceitas_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelChildForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 560);
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitinhas Federais";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraReceitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogoMenu;
        private Button btnReceitas;
        private Button btnAdicionarReceita;
        private Button btnExcluirReceita;
        private Panel panelChildForm;
        private ComboBox cbPesquisaReceitas;
        private Button btnPesquisaReceitas;
        private DataGridView dgvMostraReceitas;
        private PictureBox pictureBox1;
        private Splitter splitter1;
        private Label label2;
        private Label label1;
        private TextBox txtPesquisarDado;
        private Button btnDuvidas;
    }
}
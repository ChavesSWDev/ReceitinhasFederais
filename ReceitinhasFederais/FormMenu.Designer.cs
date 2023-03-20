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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.panelLogoMenu = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
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
            this.panelSideMenu.Controls.Add(this.button2);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.btnReceitas);
            this.panelSideMenu.Controls.Add(this.panelLogoMenu);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 521);
            this.panelSideMenu.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-3, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Excluir Receita";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar Receita";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnReceitas.TabIndex = 1;
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
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Controls.Add(this.dgvMostraReceitas);
            this.panelChildForm.Controls.Add(this.btnPesquisaReceitas);
            this.panelChildForm.Controls.Add(this.cbPesquisaReceitas);
            this.panelChildForm.Location = new System.Drawing.Point(248, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(536, 521);
            this.panelChildForm.TabIndex = 3;
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
            this.dgvMostraReceitas.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvMostraReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostraReceitas.Location = new System.Drawing.Point(52, 321);
            this.dgvMostraReceitas.MultiSelect = false;
            this.dgvMostraReceitas.Name = "dgvMostraReceitas";
            this.dgvMostraReceitas.ReadOnly = true;
            this.dgvMostraReceitas.RowHeadersVisible = false;
            this.dgvMostraReceitas.RowTemplate.Height = 25;
            this.dgvMostraReceitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostraReceitas.Size = new System.Drawing.Size(443, 188);
            this.dgvMostraReceitas.TabIndex = 2;
            // 
            // btnPesquisaReceitas
            // 
            this.btnPesquisaReceitas.BackColor = System.Drawing.Color.Lime;
            this.btnPesquisaReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaReceitas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisaReceitas.Location = new System.Drawing.Point(413, 291);
            this.btnPesquisaReceitas.Name = "btnPesquisaReceitas";
            this.btnPesquisaReceitas.Size = new System.Drawing.Size(82, 23);
            this.btnPesquisaReceitas.TabIndex = 1;
            this.btnPesquisaReceitas.Text = "Pesquisar";
            this.btnPesquisaReceitas.UseVisualStyleBackColor = false;
            // 
            // cbPesquisaReceitas
            // 
            this.cbPesquisaReceitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPesquisaReceitas.FormattingEnabled = true;
            this.cbPesquisaReceitas.Items.AddRange(new object[] {
            "Todos os dados das Receitas",
            "Título",
            "Ingredientes",
            "Modo de Preparo",
            "Dificuldade Fácil",
            "Dificuldade Média",
            "Dificuldade Difícil",
            "Dificuldade Experiente",
            "Autor",
            "Tempo de Preparo",
            "Categoria",
            "Quantidade de Porções"});
            this.cbPesquisaReceitas.Location = new System.Drawing.Point(52, 292);
            this.cbPesquisaReceitas.Name = "cbPesquisaReceitas";
            this.cbPesquisaReceitas.Size = new System.Drawing.Size(355, 23);
            this.cbPesquisaReceitas.TabIndex = 0;
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
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitinhas Federais";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostraReceitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogoMenu;
        private Button btnReceitas;
        private Button button1;
        private Button button2;
        private Panel panelChildForm;
        private ComboBox cbPesquisaReceitas;
        private Button btnPesquisaReceitas;
        private DataGridView dgvMostraReceitas;
        private PictureBox pictureBox1;
    }
}
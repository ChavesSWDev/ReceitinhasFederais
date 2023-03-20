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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMostraReceitas = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnPesquisaReceitas = new System.Windows.Forms.Button();
            this.cbPesquisaReceitas = new System.Windows.Forms.ComboBox();
            this.panelSideMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(300, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 244);
            this.panel1.TabIndex = 1;
            // 
            // dgvMostraReceitas
            // 
            this.dgvMostraReceitas.AutoScroll = true;
            this.dgvMostraReceitas.BackColor = System.Drawing.Color.NavajoWhite;
            this.dgvMostraReceitas.Location = new System.Drawing.Point(300, 321);
            this.dgvMostraReceitas.Name = "dgvMostraReceitas";
            this.dgvMostraReceitas.Size = new System.Drawing.Size(443, 188);
            this.dgvMostraReceitas.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.btnPesquisaReceitas);
            this.panelChildForm.Controls.Add(this.cbPesquisaReceitas);
            this.panelChildForm.Location = new System.Drawing.Point(248, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(536, 521);
            this.panelChildForm.TabIndex = 3;
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
            this.Controls.Add(this.dgvMostraReceitas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelChildForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitinhas Federais";
            this.panelSideMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogoMenu;
        private Panel panel1;
        private Button btnReceitas;
        private Button button1;
        private Button button2;
        private Panel dgvMostraReceitas;
        private Panel panelChildForm;
        private ComboBox cbPesquisaReceitas;
        private Button btnPesquisaReceitas;
    }
}
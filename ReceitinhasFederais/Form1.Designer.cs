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
            this.panelLogoMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReceitas = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelSideMenu.Controls.Add(this.btnReceitas);
            this.panelSideMenu.Controls.Add(this.panelLogoMenu);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 521);
            this.panelSideMenu.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(443, 307);
            this.panel1.TabIndex = 1;
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitinhas Federais";
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogoMenu;
        private Panel panel1;
        private Button btnReceitas;
    }
}
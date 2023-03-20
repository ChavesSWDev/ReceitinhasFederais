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
    }
}
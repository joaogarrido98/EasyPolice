using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class EasyPolice : Form
    {
        public EasyPolice()
        {
            InitializeComponent();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer fazer logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Mostwanted mdiMW = new Mostwanted();
            mdiMW.MdiParent = this;
            mdiMW.Show();
        }

        private void registoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistoOcorrencias mdiRO = new RegistoOcorrencias();
            mdiRO.MdiParent = this;
            mdiRO.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaOcorrências mdiCO = new ConsultaOcorrências();
            mdiCO.MdiParent = this;
            mdiCO.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CadastroPesquisa mdiCP = new CadastroPesquisa();
            mdiCP.MdiParent = this;
            mdiCP.Show();
        }
    }
}

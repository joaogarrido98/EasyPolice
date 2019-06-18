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
    public partial class EasyPolice_Admin : Form
    {
        public EasyPolice_Admin()
        {
            InitializeComponent();
        }

        //chamar os forms respetivos de cada botao. Em mdi

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarContas mdiregisto = new AdicionarContas();
            mdiregisto.MdiParent = this;
            mdiregisto.Show();
       
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverContas mdiremover = new RemoverContas();
            mdiremover.MdiParent = this;
            mdiremover.Show();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer fazer logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
            }
        }

        private void consultarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConsultaOcorrencias mdiCO = new ConsultaOcorrencias();
            mdiCO.MdiParent = this;
            mdiCO.Show();
        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistoOcorrencias mdiRO = new RegistoOcorrencias();
            mdiRO.MdiParent = this;
            mdiRO.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroPesquisa mdiCP = new CadastroPesquisa();
            mdiCP.MdiParent = this;
            mdiCP.Show();
        }

        private void informaçõesExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacoesExtra mdiIE = new InformacoesExtra();
            mdiIE.MdiParent = this;
            mdiIE.Show();
        }

        private void adicionarCrimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarCrimes mdiCC = new CriarCrimes();
            mdiCC.MdiParent = this;
            mdiCC.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultarCrimes mdiCri = new ConsultarCrimes();
            mdiCri.MdiParent = this;
            mdiCri.Show();
        }
    }
}

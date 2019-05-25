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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mostwanted mw = new Mostwanted();
            mw.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistoOcorrencias RO = new RegistoOcorrencias();
            RO.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaOcorrências CO = new ConsultaOcorrências();
            CO.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroPesquisa CP = new CadastroPesquisa();
            CP.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer fazer logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Logo lgt = new Logo();
                lgt.ShowDialog();
            }
        }
    }
}

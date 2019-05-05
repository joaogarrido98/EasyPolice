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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mostwanted mw = new Mostwanted();
            mw.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistoOcorrencias RO = new RegistoOcorrencias();
            RO.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaOcorrências CO = new ConsultaOcorrências();
            CO.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroPesquisa CP = new CadastroPesquisa();
            CP.ShowDialog();
        }
    }
}

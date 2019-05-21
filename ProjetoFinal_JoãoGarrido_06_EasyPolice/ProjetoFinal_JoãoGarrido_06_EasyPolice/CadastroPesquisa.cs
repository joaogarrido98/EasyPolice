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
    public partial class CadastroPesquisa : Form
    {
        public CadastroPesquisa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void CadastroPesquisa_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void procurar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }
        }
    }
}

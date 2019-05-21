using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class RemoverContas : Form
    {
        public RemoverContas()
        {
            InitializeComponent();
        }


        private void textbox1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer remover a conta?", "Remover", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                /*  SqlConnection connectiondelete = new SqlConnection(conString);
          connectiondelete.Open();
          string textbox1 = textBox1.Text;
          string querydelete = ($"DELETE from utilizadores WHERE Nome= 'textbox1'");
          */

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string conString = "Data Source=. ;Initial Catalog = EasyPolice_Bd; Integrated Security = True";

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection connectiondelete = new SqlConnection(conString);
            connectiondelete.Open();
            string textbox1 = textBox1.Text;
            string querydelete = ($"DELETE from utilizadores WHERE Nome= 'textbox1'");

        }
    }
}

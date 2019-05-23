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
    public partial class AdicionarContas : Form
    {
        private static string connectionString = "Data Source=.;Initial Catalog=EasyPolice_Bd; Integrated Security=True";
        private static SqlConnection db = new SqlConnection(connectionString);
       

        public AdicionarContas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Criar_Click(object sender, EventArgs e)
        {
            db.Open();
            string usernameregisto = textusername.Text;
            string passregisto = textpass.Text;
            string distintivo = textdistintivo.Text;

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = db;

            cmdInsert.CommandText = "Insert into Utilizador (Nome, Password, Distintivo) values (@Nome, @Password, @Distintivo)";

            cmdInsert.Parameters.Add("@Nome", SqlDbType.VarChar).Value = usernameregisto;
            cmdInsert.Parameters.Add("@Password", SqlDbType.VarChar).Value = passregisto;
            cmdInsert.Parameters.Add("@Distintivo", SqlDbType.Int).Value = distintivo;

            int afetados = cmdInsert.ExecuteNonQuery();

            MessageBox.Show("Conta criada");

            if (textusername.Text != "" || textusername.Text != null || textpass.Text != "" || textpass.Text != null || textdistintivo.Text != "" || textdistintivo.Text != null)
            {
                textusername.Text = "";
                textpass.Text = "";
                textdistintivo.Text = "";
            }

            

            
        }

        private void textbox1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textpass.Focus();
            }
        }

        private void textbox2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textdistintivo.Focus();
            }
        }

        private void textbox3(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Criar.Focus();
            }
        }
    }
}

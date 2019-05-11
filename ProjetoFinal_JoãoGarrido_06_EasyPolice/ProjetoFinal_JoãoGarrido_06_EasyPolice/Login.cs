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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sistema de login

        public string conString = "Data Source=LAPTOP-DJ6AD10V;Initial Catalog = EasyPolice_Bd; Integrated Security = True";
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection connect = new SqlConnection(conString);
            connect.Open();

            string query = "Select * from Utilizador Where Nome= '" + textuser.Text.Trim() + "'and password = '" + textpassword.Text.Trim() + "'";

            string sqlcon = null;
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
                
                if (dtb.Rows.Count == 1) //falta ainda distinguir de admin e de normal.
            {
                EasyPolice_Admin admin = new EasyPolice_Admin();
                admin.ShowDialog();
            }
           else
            {
               MessageBox.Show("Login incorreto, tente novamente");
            }
        }
    }
}


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
        private static string connectionString = "Data Source=.;Initial Catalog=EasyPolice_Bd; Integrated Security=True";
        private static SqlConnection db = new SqlConnection(connectionString);


        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Sistema de login


       

        private void button2_Click(object sender, EventArgs e)
        {
             db.Open();
 
             string query = "Select * from Utilizador Where Nome= '" + textuser.Text.Trim() + "'and password = '" + textpassword.Text.Trim() + "'";
            
             
             SqlDataAdapter sda = new SqlDataAdapter(query, db);

             DataTable dtb = new DataTable();
             sda.Fill(dtb);
                
            if (dtb.Rows.Count == 1)  //falta ainda distinguir de admin e de normal.
            {
                this.Hide();
                EasyPolice_Admin admin = new EasyPolice_Admin();
                admin.ShowDialog();
            }
           else
            {
               MessageBox.Show("Username e/ou Password incorreto, tente novamente");
                textuser.Focus();
            }
        }

        private void textbox1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textpassword.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textuser;
            textpassword.UseSystemPasswordChar = true;
        }

        private void textbox2(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                entrarbutton.Focus();
            }
        }

        private void Ver_CheckedChanged(object sender, EventArgs e)
        {
            if(Ver.Checked)
            {
                textpassword.UseSystemPasswordChar = false;
            }
            else
            {
                textpassword.UseSystemPasswordChar = true;
            }
        }
    }
}


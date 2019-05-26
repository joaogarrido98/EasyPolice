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
        //fazer a ligação à base de dados
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
            string Username = "";
            string password = "";
            bool IsAdmin;

            try
            {
                //sistema de login! quando tiver também a funcionar o ativo inativo de conta é que posso completar a 100% o sistema de login 
                SqlDataReader dr;

                string Query = "SELECT Nome, Password, IsAdmin FROM Utilizador";
                SqlCommand cmd = new SqlCommand(Query, db);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Username = dr["Nome"].ToString();
                    password = dr["Password"].ToString();
                    IsAdmin = dr["IsAdmin"].;
                }
                dr.Close();
                if (textuser.Text == Username && textpassword.Text == password)
                {
                   if (IsAdmin == )
                    {
                        EasyPolice_Admin epa = new EasyPolice_Admin();
                        epa.ShowDialog();
                  }
                    else
                    {
                        EasyPolice ep = new EasyPolice();
                        ep.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Utilizador e/ou Password errados");
                    textuser.Text = "";
                    textpassword.Text = "";
                }
                

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
            db.Close();
          
        }

        private void textbox1(object sender, KeyEventArgs e)
        {
            //para ficar focado na textbox que eu quero e ao pressionar enter passar à proxima.
            if (e.KeyCode == Keys.Enter)
            {
                textpassword.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textuser; //para meter a password encriptada
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
            if(Ver.Checked) //se tiver check então dá para ver a password, caso nao esteja, nao dá para ver a password.
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


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
using System.Configuration;


namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class Login : Form
    {
        //fazer a ligação à base de dados
        


        public Login()
        {
            InitializeComponent();
        }

        //Sistema de login


        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            string Username = "";
            string password = "";
            bool IsAdmin = false;
            bool AtivoInativo = false;

            try
            {
                db.Open();
               
                //sistema de login! quando tiver também a funcionar o ativo inativo de conta é que posso completar a 100% o sistema de login 
                SqlDataReader dr;

                string Query = "SELECT Nome, Password, IsAdmin, Ativo_Inativo FROM Utilizador WHERE Nome = @Nome AND Password = @Password";
                SqlCommand cmd = new SqlCommand(Query, db);

                cmd.Parameters.AddWithValue("@Nome", textuser.Text);
                cmd.Parameters.AddWithValue("@Password", textpassword.Text);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Username = dr["Nome"].ToString();
                        password = dr["Password"].ToString();
                        IsAdmin = Convert.ToBoolean(dr["IsAdmin"].ToString());
                        AtivoInativo = Convert.ToBoolean(dr["Ativo_Inativo"].ToString());
                    }
                    dr.Close();
                    
                    if (AtivoInativo == true) //para ver se está ativo ou nao
                    {
                        if (IsAdmin == true) //para ver se é admin ou não
                        {
                            db.Close();
                            this.Hide();
                            EasyPolice_Admin epa = new EasyPolice_Admin();
                            epa.ShowDialog();
                            this.Dispose();
                        }
                        else
                        {
                            db.Close();
                            this.Hide();
                            EasyPolice ep = new EasyPolice();
                            ep.ShowDialog();
                            this.Dispose();

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Conta Inativa");
                        textuser.Text = "";
                        textpassword.Text = "";
                        db.Close();
                    }
                }   
                else
                {
                    MessageBox.Show("Utilizador e/ou Password errados");
                    textuser.Text = "";
                    textpassword.Text = "";
                    db.Close();
                }
                if (!dr.IsClosed)
                {
                    dr.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
            
          
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


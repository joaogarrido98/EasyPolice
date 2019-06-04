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
    public partial class AdicionarContas : Form
    {
        public AdicionarContas()
        {
            InitializeComponent();
        }

        //sistema de registo

        private void Criar_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;

            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            if (AdminCheck.Checked)
            {
                try
                {
                    db.Open(); //abrir a base de dados

                    string usernameregisto = "";
                    string passregisto = textpass.Text;
                    string distintivo = "";

                    string query = "SELECT Nome, Distintivo FROM Utilizador WHERE Nome LIKE @Nome AND Distintivo LIKE @Distintivo";

                    SqlCommand cmdSelect = new SqlCommand(query, db);

                    cmdSelect.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textusername.Text;
                    cmdSelect.Parameters.Add("@Distintivo", SqlDbType.Int).Value = textdistintivo.Text;

                    dr = cmdSelect.ExecuteReader();

                    while (dr.Read())
                    {
                        usernameregisto = dr["Nome"].ToString();
                        distintivo = dr["Distintivo"].ToString();
                    }
                    dr.Close();

                    if (usernameregisto != textusername.Text && distintivo != textdistintivo.Text)
                    {
                        SqlCommand cmdInsert = new SqlCommand();
                        cmdInsert.Connection = db;

                        //query para inserir nome, password, distintivo e se é admin ou nao.
                        cmdInsert.CommandText = "Insert into Utilizador (Nome, Password, Distintivo, IsAdmin, Ativo_Inativo) values (@Nome, @Password, @Distintivo, @IsAdmin, @Ativo_Inativo)";

                        cmdInsert.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textusername.Text;
                        cmdInsert.Parameters.Add("@Password", SqlDbType.VarChar).Value = textpass.Text;
                        cmdInsert.Parameters.Add("@Distintivo", SqlDbType.Int).Value = textdistintivo.Text;
                        cmdInsert.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = 1;
                        cmdInsert.Parameters.Add("@Ativo_Inativo", SqlDbType.Bit).Value = 1;


                        cmdInsert.ExecuteNonQuery();

                        MessageBox.Show("Conta criada");

                    }
                    else if (usernameregisto == textusername.Text && distintivo != textdistintivo.Text)
                    {
                        MessageBox.Show("Username existente");

                    }
                    else if (usernameregisto != textusername.Text && distintivo == textdistintivo.Text)
                    {
                        MessageBox.Show("Distintivo Existente");

                    }
                    else
                    {
                        MessageBox.Show("Username e Distintivo existentes");

                    }
                    db.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.ToString());
                }
            }
            else
            {
                try
                {
                    db.Open();

                    string usernameregisto = "";
                    string passregisto = textpass.Text;
                    string distintivo = "";

                    string query = "SELECT Nome, Distintivo FROM Utilizador WHERE Nome LIKE @Nome AND Distintivo LIKE @Distintivo";

                    SqlCommand cmdSelect = new SqlCommand(query, db);

                    cmdSelect.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textusername.Text;
                    cmdSelect.Parameters.Add("@Distintivo", SqlDbType.Int).Value = textdistintivo.Text;

                    dr = cmdSelect.ExecuteReader();

                    while (dr.Read())
                    {
                        usernameregisto = dr["Nome"].ToString();
                        distintivo = dr["Distintivo"].ToString();
                    }
                    dr.Close();


                    if (usernameregisto != textusername.Text && distintivo != textdistintivo.Text)
                    {
                        SqlCommand cmdInsert = new SqlCommand();
                        cmdInsert.Connection = db;

                        cmdInsert.CommandText = "Insert into Utilizador (Nome, Password, Distintivo, IsAdmin, Ativo_Inativo) values (@Nome, @Password, @Distintivo, @IsAdmin, @Ativo_Inativo)";

                        cmdInsert.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textusername.Text;
                        cmdInsert.Parameters.Add("@Password", SqlDbType.VarChar).Value = textpass.Text;
                        cmdInsert.Parameters.Add("@Distintivo", SqlDbType.Int).Value = textdistintivo.Text;
                        cmdInsert.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = 0;
                        cmdInsert.Parameters.Add("@Ativo_Inativo", SqlDbType.Bit).Value = 1;


                        cmdInsert.ExecuteNonQuery();

                        MessageBox.Show("Conta criada");
                    }
                    else if (usernameregisto == textusername.Text && distintivo != textdistintivo.Text)
                    {
                        MessageBox.Show("Username existente");
                    }
                    else if (usernameregisto != textusername.Text && distintivo == textdistintivo.Text)
                    {
                        MessageBox.Show("Distintivo Existente");
                    }
                    else
                    {
                        MessageBox.Show("Username e Distintivo existentes");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.ToString());
                }
            }

            db.Close();
            
           
            
            //serve para apagar as caixas de texto depois de criar a conta 
            if (textusername.Text != "" || textusername.Text != null || textpass.Text != "" || textpass.Text != null || textdistintivo.Text != "" || textdistintivo.Text != null)
            {
                textusername.Text = "";
                textpass.Text = "";
                textdistintivo.Text = "";
            }

            
        }

        private void textbox1(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter) //foco na caixa de texto
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

        private void textdistintivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') //so deixar escrever numeros
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 4) //so deixar escrever ate quatro caracteres.
            {
                e.Handled = true;
            }
        }

        private void textusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.Count(Char.IsLetter) >= 12)
            {
                e.Handled = true;
            }
        }

        private void textpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((sender as TextBox).Text.Count(Char.IsLetter) >= 12)
            {
                e.Handled = true;
            }
        }
    }
}

﻿using System;
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

        
        //sistema de registo

        private void Criar_Click(object sender, EventArgs e)
        {
            if (AdminCheck.Checked)
            {
                db.Open(); //abrir a base de dados

                string usernameregisto = textusername.Text;
                string passregisto = textpass.Text;
                string distintivo = textdistintivo.Text;

                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = db;

                //query para inserir nome, password, distintivo e se é admin ou nao.
                cmdInsert.CommandText = "Insert into Utilizador (Nome, Password, Distintivo, IsAdmin, Ativo_Inativo) values (@Nome, @Password, @Distintivo, @IsAdmin, @Ativo_Inativo)";

                cmdInsert.Parameters.Add("@Nome", SqlDbType.VarChar).Value = usernameregisto;
                cmdInsert.Parameters.Add("@Password", SqlDbType.VarChar).Value = passregisto;
                cmdInsert.Parameters.Add("@Distintivo", SqlDbType.Int).Value = distintivo;
                cmdInsert.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = 1;
                cmdInsert.Parameters.Add("@Ativo_Inativo", SqlDbType.Bit).Value = 1;


                int afetados = cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Conta criada");
            }
            else
            {
                db.Open();

                string usernameregisto = textusername.Text;
                string passregisto = textpass.Text;
                string distintivo = textdistintivo.Text;

                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = db;

                cmdInsert.CommandText = "Insert into Utilizador (Nome, Password, Distintivo, IsAdmin, Ativo_Inativo) values (@Nome, @Password, @Distintivo, @IsAdmin, @Ativo_Inativo)";

                cmdInsert.Parameters.Add("@Nome", SqlDbType.VarChar).Value = usernameregisto;
                cmdInsert.Parameters.Add("@Password", SqlDbType.VarChar).Value = passregisto;
                cmdInsert.Parameters.Add("@Distintivo", SqlDbType.Int).Value = distintivo;
                cmdInsert.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = 0;
                cmdInsert.Parameters.Add("@Ativo_Inativo", SqlDbType.Bit).Value = 1;


                int afetados = cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Conta criada");
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
            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 4) //so deixar esscrever ate quatro caracteres.
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

        private void button2_Click(object sender, EventArgs e) //para reativar a conta escolhida.
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer ativar a conta?", "Ativar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    string ativar = textusername.Text;
                    string distintivoativar = textdistintivo.Text;

                    SqlCommand cmdDelete = new SqlCommand();
                    cmdDelete.Connection = db;

                    cmdDelete.CommandText = ("UPDATE Utilizador SET Ativo_Inativo = 1 WHERE Distintivo = @Distintivo AND Nome = @Nome");
                    cmdDelete.Parameters.Add("@Distintivo", SqlDbType.Int).Value = distintivoativar;
                    cmdDelete.Parameters.Add("@Nome", SqlDbType.VarChar).Value = ativar;

                    int afectados = cmdDelete.ExecuteNonQuery();
                    db.Close();

                    MessageBox.Show("Conta Desativada");

                    if (textusername.Text != "" || textusername.Text != null && textdistintivo.Text != "" || textdistintivo.Text != null)
                    {
                        textdistintivo.Text = "";
                        textusername.Text = "";
                    }

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }

        }
    }
}

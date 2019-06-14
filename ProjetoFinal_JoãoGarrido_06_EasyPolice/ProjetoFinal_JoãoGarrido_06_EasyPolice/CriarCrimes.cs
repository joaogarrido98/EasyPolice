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
    public partial class CriarCrimes : Form
    {
        public CriarCrimes()
        {
            InitializeComponent();
        }

        public void limpar()
        {
            txtgravidade.Text = "";
            txttipo.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;

            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                db.Open(); //abrir a base de dados

                string tipo = "";
                string gravidade = txtgravidade.Text;

                string query = "SELECT IdCrime, Tipo, Gravidade FROM Crimes WHERE Tipo = @Tipo";

                SqlCommand cmdSelect = new SqlCommand(query, db);

                cmdSelect.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = txttipo.Text;

                dr = cmdSelect.ExecuteReader();

                while (dr.Read())
                {
                    tipo = dr["Tipo"].ToString();
                }
                dr.Close();

                if(tipo.Equals(txttipo.Text, StringComparison.OrdinalIgnoreCase)) //PARA IGNORAR SE É LETRA MAIUSCULA OU MINISCULA
                {
                    MessageBox.Show("Crime Existente");
                    limpar();
                }
                else
                {
                    SqlCommand cmdInsertCrime = new SqlCommand();
                    cmdInsertCrime.Connection = db;

                    //query para inserir nome, password, distintivo e se é admin ou nao.
                    cmdInsertCrime.CommandText = "Insert into Crimes (Tipo, Gravidade) values (@Tipo, @Gravidade)";

                    cmdInsertCrime.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = txttipo.Text;
                    cmdInsertCrime.Parameters.Add("@Gravidade", SqlDbType.Int).Value = txtgravidade.Text;

                    cmdInsertCrime.ExecuteNonQuery();

                    MessageBox.Show("Crime Adicionado");
                    limpar();
                }


            }
            catch (Exception)
            {

            }
        }

        private void txttipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtgravidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8) //so deixar escrever numeros
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 1)  //so deixar escrever ate quatro caracteres.
            {
                e.Handled = !(e.KeyChar == 8);
            }
        }
    }
}

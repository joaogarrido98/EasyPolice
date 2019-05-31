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
    public partial class RemoverContas : Form
    {



        public RemoverContas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void distintivopress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer desativar a conta?", "Desativar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    (dataGridView1.DataSource as DataTable).Columns["IdUtilizador"]
                    dataGridView1.Columns[e.ColumnIndex].DataPropertyName*/


                    if (chk.Selected == true)
                    {
                        db.Open();
                        SqlCommand cmdDelete = new SqlCommand();
                        cmdDelete.Connection = db;

                        cmdDelete.CommandText = ("UPDATE Utilizador SET Ativo_Inativo = 0");

                        int afectados = cmdDelete.ExecuteNonQuery();
                        db.Close();

                        MessageBox.Show("Conta Desativada");
                       // chk.Selected = false;
                    }
                    else
                    {
                        db.Open();
                        SqlCommand cmdDelete = new SqlCommand();
                        cmdDelete.Connection = db;

                        cmdDelete.CommandText = ("UPDATE Utilizador SET Ativo_Inativo = 1");

                        int afectados = cmdDelete.ExecuteNonQuery();
                        db.Close();

                        MessageBox.Show("Conta Ativada");
                      //  chk.Selected = true;
                    }*/
                }
            }
            catch (Exception errado)
            {
                MessageBox.Show(errado.ToString());
            }

        }

        private void RemoverContas_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            try
            {


                SqlCommand cmd = db.CreateCommand();

                db.Open();
                cmd.CommandText = "SELECT Nome, IsAdmin, Distintivo, Ativo_Inativo FROM Utilizador";

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    DataSet ds = new DataSet(); // dataset representa uma estrura de base de dados em memória
                    DataTable dataTable = new DataTable("Utilizadores"); //assim necessitamos de uma tabela ao dataset
                    ds.Tables.Add(dataTable);
                    ds.Load(dr, LoadOption.PreserveChanges, ds.Tables["Utilizadores"]); //carregar
                    dataGridView1.DataSource = ds.Tables["Utilizadores"];
                }

                dr.Dispose();
                cmd.Dispose();
            }

            catch (SqlException ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro de BASE DE DADOS!!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro GERAL!!", MessageBoxButtons.OK);
            }
            finally
            {
                if (db.State == System.Data.ConnectionState.Open)
                {
                    db.Close();
                    db.Dispose();
                }
            }
        }

    }
}
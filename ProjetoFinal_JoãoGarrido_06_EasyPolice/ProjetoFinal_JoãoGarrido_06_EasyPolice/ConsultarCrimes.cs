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
using System.Threading;

namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class ConsultarCrimes : Form
    {
        DataSet ds = new DataSet(); // dataset representa uma estrura de base de dados em memória
        DataTable dataTable = new DataTable("Crimes");


        public ConsultarCrimes()
        {
            InitializeComponent();
            ds.Tables.Add(dataTable);
            dataGridView1.AutoGenerateColumns = false;
        }

        public void consulta()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {

                SqlCommand cmd = db.CreateCommand();

                db.Open();
                cmd.CommandText = "SELECT IdCrime, Tipo, Gravidade FROM Crimes";

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    ds.Load(dr, LoadOption.PreserveChanges, ds.Tables["Crimes"]); //carregar a tabela

                    dataGridView1.DataSource = ds.Tables["Crimes"];
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

        private void ConsultarCrimes_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
    }

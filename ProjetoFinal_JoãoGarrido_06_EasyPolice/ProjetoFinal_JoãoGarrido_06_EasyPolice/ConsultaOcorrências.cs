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
    public partial class ConsultaOcorrências : Form
    {
        DataSet dt = new DataSet(); // dataset representa uma estrutura de base de dados em memória
        DataTable dataTable = new DataTable("Ocorrencias"); //assim necessitamos de uma tabela ao dataset


        public ConsultaOcorrências()
        {
            InitializeComponent();
        }

        private void ConsultaOcorrências_Load(object sender, EventArgs e)
        {
            dt.Tables.Add(dataTable);
            dataGridView1.AutoGenerateColumns = false;

            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = db.CreateCommand();
                db.Open();

                cmd.CommandText = "SELECT IdOcorrencia, IdCriminoso, Data, IdCrime, IdDistrito, IdUtilizador FROM Ocorrencias";

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr, LoadOption.PreserveChanges, dt.Tables["Ocorrencias"]); //carregar

                    dataGridView1.DataSource = dt.Tables["Ocorrencias"];
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

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
    public partial class CadastroPesquisa : Form
    {

        public CadastroPesquisa()
        {
            InitializeComponent();
        }

        private void textbox1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void CadastroPesquisa_Load(object sender, EventArgs e)
        {
            DataSet dc = new DataSet(); // dataset representa uma estrutura de base de dados em memória
            DataTable dataTable = new DataTable("Criminoso"); //assim necessitamos de uma tabela ao dataset

            dc.Tables.Add(dataTable);
            dataGridView1.AutoGenerateColumns = false;

            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = db.CreateCommand();
                db.Open();

                cmd.CommandText = "SELECT IdCriminoso, Nome, CartaoCidadao, Idade FROM Criminoso";

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dc.Load(dr, LoadOption.PreserveChanges, dc.Tables["Criminoso"]); //carregar

                    dataGridView1.DataSource = dc.Tables["Criminoso"];
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

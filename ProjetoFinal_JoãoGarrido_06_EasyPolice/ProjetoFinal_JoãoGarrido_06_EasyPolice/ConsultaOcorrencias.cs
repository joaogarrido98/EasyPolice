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
    public partial class ConsultaOcorrencias : Form
    {
        DataSet dt = new DataSet(); //dataset representa uma estrutura de base de dados em memória
        DataTable dataTable = new DataTable("Ocorrencias"); //assim necessitamos de uma tabela ao dataset


        public void DoRefresh() //função para realizar mais que uma vez o mesmo codigo de chamar as informações na query para a datagridview
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = db.CreateCommand();
                db.Open();

                cmd.CommandText = "SELECT IdOcorrencia, Data, Distrito.Nome AS Distrito, Criminoso.Nome, Crimes.Tipo, Utilizador.Distintivo FROM Ocorrencias INNER JOIN Distrito ON Ocorrencias.IdDistrito = Distrito.IdDistrito INNER JOIN Criminoso ON Ocorrencias.IdCriminoso = Criminoso.IdCriminoso INNER JOIN Crimes ON Ocorrencias.IdCrime = Crimes.IdCrime INNER JOIN Utilizador ON Ocorrencias.idUtilizador = Utilizador.IdUtilizador ORDER BY Data Desc";

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
        public ConsultaOcorrencias()
        {
            InitializeComponent();
            dt.Tables.Add(dataTable);
            dataGridView1.AutoGenerateColumns = false;
        }

        private void ConsultaOcorrências_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyPolice_BdDataSet1.Crimes' table. You can move, or remove it, as needed.
            this.crimesTableAdapter.Fill(this.easyPolice_BdDataSet1.Crimes);
            // TODO: This line of code loads data into the 'easyPolice_BdDataSet1.Distrito' table. You can move, or remove it, as needed.
            this.distritoTableAdapter.Fill(this.easyPolice_BdDataSet1.Distrito);

            DoRefresh(); //chamar a funçao
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            DoRefresh();
        }

        private void clickcell(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try //registar o IdOcorrencia da ocorrencia na qual se carregou na row da datagridview
            {
                /*int row = Convert.ToInt32((dataGridView1.DataSource as DataTable).Rows[e.RowIndex][]

                if (Convert.ToInt32(dataGridView1.DataSource as DataTable).Rows[e.RowIndex][-1])
                {

                }*/

                int ocorrenciaID = Convert.ToInt32((dataGridView1.DataSource as DataTable).Rows[e.RowIndex]["IdOcorrencia"]);
                OcorrenciaDetalhe od = new OcorrenciaDetalhe();//chamar o form 
                od.carregar(ocorrenciaID);
                od.Show();

            }
            catch (Exception errado)
            {
                MessageBox.Show(errado.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            //sistema de fazer pesquisa a partir das textbox

            
            string data = txtdata.Value.ToString();
            string crime = txtcrime.SelectedValue.ToString();
            string distrito = txtdistrito.SelectedValue.ToString();


            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
              

                SqlCommand cmd = db.CreateCommand();
                db.Open();
                
                cmd.CommandText = "SELECT dbo.Ocorrencias.IdOcorrencia, dbo.Ocorrencias.Data, dbo.Criminoso.Nome, dbo.Crimes.Tipo, dbo.Distrito.Nome AS Distrito, dbo.Utilizador.Distintivo FROM dbo.Ocorrencias INNER JOIN dbo.Criminoso ON dbo.Ocorrencias.IdCriminoso = dbo.Criminoso.IdCriminoso INNER JOIN  dbo.Crimes ON dbo.Ocorrencias.IdCrime = dbo.Crimes.IdCrime INNER JOIN dbo.Distrito ON dbo.Ocorrencias.IdDistrito = dbo.Distrito.IdDistrito INNER JOIN dbo.Utilizador ON dbo.Ocorrencias.idUtilizador = dbo.Utilizador.IdUtilizador WHERE Ocorrencias.IdDistrito = @Distrito OR Ocorrencias.IdCrime=@Crime OR Ocorrencias.Data = @Data";

                cmd.Parameters.Add("@Data", SqlDbType.Date).Value = data;
                cmd.Parameters.Add("@Crime", SqlDbType.VarChar).Value = crime;
                cmd.Parameters.Add("@Distrito", SqlDbType.VarChar).Value = distrito;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr, LoadOption.PreserveChanges, dt.Tables["Ocorrencias"]); //carregar

                    dataGridView1.DataSource = dt.Tables["Ocorrencias"];
                }

                dr.Dispose();
                cmd.Dispose();
                GC.Collect();

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
                    GC.Collect();
                }
            }
        }
    }
}

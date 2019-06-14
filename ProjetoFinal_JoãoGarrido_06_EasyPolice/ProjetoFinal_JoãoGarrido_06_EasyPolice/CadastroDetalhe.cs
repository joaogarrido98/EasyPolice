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
    public partial class CadastroDetalhe : Form
    {
       
        public CadastroDetalhe()
        {
            InitializeComponent();  
        }

        public void carregamento(int criminosoID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = db.CreateCommand();
                db.Open();

                cmd.CommandText = ("SELECT IdCriminoso, Nome, Idade, CartaoCidadao, Sexo, Altura, Cor FROM Criminoso WHERE IdCriminoso = @IdCriminoso");            
                cmd.Parameters.Add("@IdCriminoso", SqlDbType.Int).Value = criminosoID;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lblnome.Text = dr["Nome"].ToString();
                        lblCC.Text = dr["CartaoCidadao"].ToString();
                        lblIdade.Text = dr["Idade"].ToString();
                        txtalt.Text = dr["Altura"].ToString();
                        txtcor.Text = dr["Cor"].ToString();
                        txtsexo.Text = dr["Sexo"].ToString();
                        
                    }
                    dr.Close();
                }
                db.Close();
                cmd.Dispose();
                GC.Collect();
            }
            catch (Exception errado)
            {
                MessageBox.Show(errado.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void detalhe(int criminosoID)
        {

            DataSet dc = new DataSet(); // dataset representa uma estrutura de base de dados em memória
            DataTable dataTable = new DataTable("Ocorrencias"); //assim necessitamos de uma tabela ao dataset

            dc.Tables.Add(dataTable);
            dataGridView1.AutoGenerateColumns = false;

            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = db.CreateCommand();
                db.Open();

                cmd.CommandText = "SELECT Ocorrencias.IdOcorrencia, Ocorrencias.Data, Crimes.Tipo, Distrito.Nome, Utilizador.Distintivo FROM Ocorrencias INNER JOIN Crimes ON Ocorrencias.IdCrime = Crimes.IdCrime INNER JOIN Distrito ON Ocorrencias.IdDistrito = Distrito.IdDistrito INNER JOIN Utilizador ON Ocorrencias.idUtilizador = Utilizador.IdUtilizador WHERE IdCriminoso = @IdCriminoso ORDER BY Data ASC";
                cmd.Parameters.Add("@IdCriminoso", SqlDbType.Int).Value = criminosoID;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dc.Load(dr, LoadOption.PreserveChanges, dc.Tables["Ocorrencias"]); //carregar

                    dataGridView1.DataSource = dc.Tables["Ocorrencias"];
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

        private void CadastroDetalhe_Load(object sender, EventArgs e)
        {

        }
    }
}

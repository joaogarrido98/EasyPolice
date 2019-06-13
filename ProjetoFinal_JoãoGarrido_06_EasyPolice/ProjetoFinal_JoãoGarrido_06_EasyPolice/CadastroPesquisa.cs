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
        DataSet dc = new DataSet(); // dataset representa uma estrutura de base de dados em memória
        DataTable dataTable = new DataTable("Criminoso"); //assim necessitamos de uma tabela ao dataset

        public CadastroPesquisa()
        {
            InitializeComponent();
            dc.Tables.Add(dataTable);
            dataGridView1.AutoGenerateColumns = false;
        }

        private void textbox1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                txtcc.Focus();
            }
        }

        public void DoRefreshness()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = db.CreateCommand();
                db.Open();

                cmd.CommandText = "SELECT IdCriminoso, Nome, CartaoCidadao, Idade FROM Criminoso ORDER BY Nome ASC";

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

        private void CadastroPesquisa_Load(object sender, EventArgs e)
        {    
            DoRefreshness();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            DoRefreshness();
        }

        private void clickcell(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                int criminosoID = Convert.ToInt32((dataGridView1.DataSource as DataTable).Rows[e.RowIndex]["IdCriminoso"]);
                CadastroDetalhe cd = new CadastroDetalhe();
                cd.carregamento(criminosoID);
                cd.detalhe(criminosoID);
                cd.Show();
            }
            catch (Exception errado)
            {
                MessageBox.Show(errado.ToString());
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();

            string nome = txtnome.Text;
            string CC = txtcc.Text;


            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = db.CreateCommand();
                db.Open();

                cmd.CommandText = "SELECT IdCriminoso, Nome, CartaoCidadao, Idade FROM Criminoso WHERE Nome = @Nome or CartaoCidadao = @CartaoCidadao";
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@CartaoCidadao", SqlDbType.VarChar).Value = CC;

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

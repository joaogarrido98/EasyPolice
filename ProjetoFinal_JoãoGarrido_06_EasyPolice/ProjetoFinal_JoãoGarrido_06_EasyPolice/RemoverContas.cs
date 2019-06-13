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
    public partial class RemoverContas : Form
    {
        DataSet ds = new DataSet(); // dataset representa uma estrura de base de dados em memória
        DataTable dataTable = new DataTable("Utilizadores"); //assim necessitamos de uma tabela ao datase

        public RemoverContas()
        {
            InitializeComponent();
            ds.Tables.Add(dataTable);
            dataGridView1.AutoGenerateColumns = false;
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

        public void remover()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            try
            {


                SqlCommand cmd = db.CreateCommand();

                db.Open();
                cmd.CommandText = "SELECT IdUtilizador, Nome, IsAdmin, Distintivo, Ativo_Inativo FROM Utilizador";

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    ds.Load(dr, LoadOption.PreserveChanges, ds.Tables["Utilizadores"]); //carregar a tabela

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

        private void RemoverContas_Load(object sender, EventArgs e)
        {
            remover();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if ( dataGridView1.Columns[e.ColumnIndex].DataPropertyName.ToLowerInvariant() != "ativo_inativo" ) return;

            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                bool IsActive = !Convert.ToBoolean((dataGridView1.DataSource as DataTable).Rows[e.RowIndex]["ativo_inativo"]);
                int userID = Convert.ToInt32((dataGridView1.DataSource as DataTable).Rows[e.RowIndex]["idutilizador"]);

                Cursor = Cursors.WaitCursor;

                db.Open();
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = db;

                cmdDelete.CommandText = ("UPDATE Utilizador SET Ativo_Inativo = @activo where IdUtilizador = @iduser");
                cmdDelete.Parameters.Add("@iduser", SqlDbType.Int).Value = userID;
                cmdDelete.Parameters.Add("@activo", SqlDbType.Bit).Value = IsActive;

                cmdDelete.ExecuteNonQuery();
                db.Close();

                Thread.Sleep(125);
                Cursor = Cursors.Default;

                ds.Tables["Utilizadores"].Rows[e.RowIndex]["ativo_inativo"] = IsActive;
                
            }
            catch (Exception errado)
            {
                MessageBox.Show(errado.ToString());
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            remover();
        }
    }
}
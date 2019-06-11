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
       /*DataSet dc = new DataSet(); // dataset representa uma estrutura de base de dados em memória
        DataTable dataTable = new DataTable("Criminoso"); //assim necessitamos de uma tabela ao dataset*/

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
                db.Open();
                SqlDataReader dr;

                string query = ("SELECT Criminoso.IdDistrito, Distrito.Nome, Criminoso.IdConcelho, Concelho.Nome AS Concelho, Criminoso.IdFreguesia, Freguesia.Nome AS Freguesia FROM Criminoso INNER JOIN Distrito ON Criminoso.IdDistrito = Distrito.IdDistrito INNER JOIN Concelho ON Criminoso.IdConcelho = Concelho.IdConcelho AND Distrito.IdDistrito = Concelho.IDDistrito INNER JOIN Freguesia ON Criminoso.IdFreguesia = Freguesia.IdFreguesia AND Concelho.IdConcelho = Freguesia.IDConcelho");

                SqlCommand cmd = new SqlCommand(query, db);

                cmd.Parameters.Add("@IdCriminoso", SqlDbType.Int).Value = criminosoID;

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lblnome.Text = dr["Nome"].ToString();
                        lblCC.Text = dr["CartaoCidadao"].ToString();
                        lblIdade.Text = dr["Idade"].ToString();
                        lblDistrito.Text = dr["Distrito"].ToString();
                        lblConcelho.Text = dr["Concelho"].ToString();
                        lblFreguesia.Text = dr["Freguesia"].ToString();
                    }
                    dr.Close();

                }
                    
                db.Close();

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
    }
}

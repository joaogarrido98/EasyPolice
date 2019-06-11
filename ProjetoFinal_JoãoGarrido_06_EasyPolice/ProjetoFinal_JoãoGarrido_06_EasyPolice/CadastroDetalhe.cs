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

                string query = ("SELECT IdCriminoso, Nome, CartaoCidadao,Idade, Distrito, Concelho, Freguesia FROM Criminoso Where IdCriminoso = @IdCriminoso, Nome = @Nome, CartaoCidadao = @CartaoCidadao, Idade = @Idade, Distrito = @Distrito, Concelho = @Concelho, Freguesia = @Freguesia ");

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

                    cmd.ExecuteNonQuery();
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

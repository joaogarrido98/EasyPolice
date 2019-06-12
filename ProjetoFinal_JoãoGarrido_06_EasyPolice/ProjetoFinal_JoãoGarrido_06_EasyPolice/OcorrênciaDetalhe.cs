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
    public partial class OcorrênciaDetalhe : Form
    {
        public OcorrênciaDetalhe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void carregar(int ocorrenciaId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = db.CreateCommand();
                db.Open();

                cmd.CommandText = ("SELECT dbo.Ocorrencias.IdOcorrencia, dbo.Ocorrencias.Data, dbo.Ocorrencias.Detalhe, dbo.Crimes.Tipo, dbo.Crimes.Gravidade, dbo.Distrito.Nome AS Distrito, dbo.Concelho.Nome AS Concelho, dbo.Freguesia.Nome AS Freguesia, dbo.Utilizador.Distintivo FROM dbo.Ocorrencias INNER JOIN dbo.Crimes ON dbo.Ocorrencias.IdCrime = dbo.Crimes.IdCrime INNER JOIN dbo.Distrito ON dbo.Ocorrencias.IdDistrito = dbo.Distrito.IdDistrito INNER JOIN dbo.Concelho ON dbo.Distrito.IdDistrito = dbo.Concelho.IDDistrito INNER JOIN dbo.Freguesia ON dbo.Concelho.IdConcelho = dbo.Freguesia.IDConcelho INNER JOIN dbo.Utilizador ON dbo.Ocorrencias.idUtilizador = dbo.Utilizador.IdUtilizador WHERE IdOcorrencia = @IdOcorrencia");
                cmd.Parameters.Add("@IdOcorrencia", SqlDbType.Int).Value = ocorrenciaId;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtdetalhe.Text = dr["Detalhe"].ToString();
                        txtdata.Text = dr["Data"].ToString();
                        txtdistrito.Text = dr["Distrito"].ToString();
                        txtConcelho.Text = dr["Concelho"].ToString();
                        txtfreguesia.Text = dr["Freguesia"].ToString();
                        txtpolicia.Text = dr["Distintivo"].ToString();
                        txtcrime.Text = dr["Tipo"].ToString();
                        txtgravidade.Text = dr["gravidade"].ToString();
                    }
                    dr.Close();
                }
                db.Close();
                cmd.Dispose();
            }
            catch (Exception errado)
            {
                MessageBox.Show(errado.ToString());
            }

        }

    }
}

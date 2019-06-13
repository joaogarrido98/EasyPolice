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

namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class Mostwanted : Form
    {
        public Mostwanted()
        {
            InitializeComponent();
        }


        public void mostwanted()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                db.Open();
                SqlDataReader dr;

                string query = "SELECT dbo.Ocorrencias.IdOcorrencia, dbo.Criminoso.Nome, dbo.Crimes.Tipo, dbo.Crimes.Gravidade FROM dbo.Ocorrencias INNER JOIN dbo.Crimes ON dbo.Ocorrencias.IdCrime = dbo.Crimes.IdCrime INNER JOIN dbo.Criminoso ON dbo.Ocorrencias.IdCriminoso = dbo.Criminoso.IdCriminoso";
                SqlCommand cmdmostwanted = new SqlCommand(query, db);

                dr = cmdmostwanted.ExecuteReader();

                if (dr.HasRows)
                {
                   
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }


        }

        private void Mostwanted_Load(object sender, EventArgs e)
        {
            
        }
    }
}

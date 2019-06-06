using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class RegistoOcorrencias : Form
    {
        public RegistoOcorrencias()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CriarRegisto(object sender, EventArgs e)
        {
          try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
                SqlConnection db = new SqlConnection(connectionString);

                db.Open();

                string Nome = TextNome.Text;
                string CC = TextCC.Text;
                DateTime Data;
                Data = textdata.Value;
                Convert.ToString(Data);
                string Freguesia = TextFreguesia.Text;
                string Concelho = TextConcelho.Text;
                string Distrito = ComboDistrito.SelectedValue.ToString();
                string Detalhe = TextDetalhe.Text;
                string Crime = ComboCrime.SelectedValue.ToString();


                //insertConcelho
                SqlCommand cmdInsertConcelho = new SqlCommand();
                cmdInsertConcelho.Connection = db;
                cmdInsertConcelho.CommandText = "Insert into Concelho (Nome, IdDistrito) values (@Nome, @IdDistrito)";

                cmdInsertConcelho.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Concelho;
                cmdInsertConcelho.Parameters.Add("@IdDistrito", SqlDbType.Int).Value = Convert.ToInt32(Distrito);
                cmdInsertConcelho.ExecuteNonQuery();

                SqlDataReader dr;
                SqlCommand cmdMaxIdConcelho = new SqlCommand();
                cmdMaxIdConcelho.CommandText = "Select Max(IdConcelho) as MaxId FROM Concelho";
                cmdMaxIdConcelho.Connection = db;


                string MaxIdConcelho = "";

                dr = cmdMaxIdConcelho.ExecuteReader();
                while(dr.Read())
                {
                    MaxIdConcelho = dr["MaxId"].ToString();
                }
                dr.Close();

                //insertFreguesia
                SqlCommand cmdInsertFreguesia = new SqlCommand();
                cmdInsertFreguesia.Connection = db;
                cmdInsertFreguesia.CommandText = "Insert into Freguesia (Nome, IdConcelho) values (@Nome, @IdConcelho)";

                cmdInsertFreguesia.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Freguesia;
                cmdInsertFreguesia.Parameters.Add("@IdConcelho", SqlDbType.Int).Value = MaxIdConcelho;
                cmdInsertFreguesia.ExecuteNonQuery();


                //insertOcorrencias
                SqlCommand cmdInsertOcorrencias = new SqlCommand();
                cmdInsertOcorrencias.Connection = db;
                cmdInsertOcorrencias.CommandText = "Insert into Ocorrencias (Hora) values (@Hora)";
                cmdInsertOcorrencias.CommandText = "Insert into Ocorrencias (Detalhe) values (@Detalhe)";
                cmdInsertOcorrencias.CommandText = "Insert into Ocorrencias (IdDistrito) values (@IdDistrito)";

                cmdInsertOcorrencias.Parameters.Add("@Detalhe", SqlDbType.VarChar).Value = Detalhe;
                cmdInsertOcorrencias.Parameters.Add("@Hora", SqlDbType.Date).Value = Data;
                cmdInsertOcorrencias.Parameters.Add("@IdDistrito", SqlDbType.Int).Value = Convert.ToInt32(Distrito);
                cmdInsertOcorrencias.ExecuteNonQuery();

                //insertCrimes
                SqlCommand cmdInsertCrimes = new SqlCommand();
                cmdInsertCrimes.Connection = db;
                cmdInsertCrimes.CommandText = "Insert into Crimes (Tipo) values (@Tipo)";

                cmdInsertCrimes.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = Crime;
                cmdInsertCrimes.ExecuteNonQuery();

                //Insert criminoso
                SqlCommand cmdInsertCriminoso = new SqlCommand();
                cmdInsertCriminoso.Connection = db;
                cmdInsertCriminoso.CommandText = "Insert into Criminoso (Nome, CartaoCidadao, IdDistrito) values (@Nome, @CartaoCidadao, @IdDistrito)";

                cmdInsertCriminoso.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                cmdInsertCriminoso.Parameters.Add("@CartaoCidadao", SqlDbType.Int).Value = CC;
                cmdInsertCriminoso.Parameters.Add("@IdDistrito", SqlDbType.Int).Value = Convert.ToInt32(Distrito);

                cmdInsertCriminoso.ExecuteNonQuery();
                
                MessageBox.Show("Registo Criado");
                db.Close();
 
            }
            catch (Exception erro)
            {
                    MessageBox.Show(erro.ToString());
            }
            

        }

        private void RegistoOcorrencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyPolice_BdDataSet1.Crimes' table. You can move, or remove it, as needed.
            this.crimesTableAdapter.Fill(this.easyPolice_BdDataSet1.Crimes);
            // TODO: This line of code loads data into the 'easyPolice_BdDataSet1.Distrito' table. You can move, or remove it, as needed.
            this.distritoTableAdapter.Fill(this.easyPolice_BdDataSet1.Distrito);

        }
    }
}

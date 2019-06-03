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
                string Idade = TextIdade.Text;
                string CC = TextCC.Text;
                string Gravidade = textGravidade.Text;
                string Data = textdata.Text;
                string Freguesia = TextFreguesia.Text;
                string Concelho = TextConcelho.Text;
                string Distrito = ComboDistrito.SelectedItem.ToString();
                string Detalhe = TextDetalhe.Text;
                string Crime = ComboCrime.SelectedItem.ToString();


                //Insert criminoso
                SqlCommand cmdInsertCriminoso = new SqlCommand();
                cmdInsertCriminoso.Connection = db;
                cmdInsertCriminoso.CommandText = "Insert into Criminoso (Nome, Idade, CartaoCidadao) values (@Nome, @Idade, @CartaoCidadao)";

                //insertFreguesia
                SqlCommand cmdInsertFreguesia = new SqlCommand();
                cmdInsertFreguesia.Connection = db;
                cmdInsertFreguesia.CommandText = "Insert into Freguesia (Nome) values (@Nome)";

                //insertConcelho
                SqlCommand cmdInsertConcelho = new SqlCommand();
                cmdInsertConcelho.Connection = db;
                cmdInsertConcelho.CommandText = "Insert into Concelho (Nome) values (@Nome)";

                //insertDistrito
                SqlCommand cmdInsertDistrito = new SqlCommand();
                cmdInsertDistrito.Connection = db;
                cmdInsertDistrito.CommandText = "Insert into Distrito (Nome) values (@Nome)";

                //insertOcorrencias
                SqlCommand cmdInsertOcorrencias = new SqlCommand();
                cmdInsertOcorrencias.Connection = db;
                cmdInsertOcorrencias.CommandText = "Insert into Ocorrencias (Hora) values (@Hora)";
                cmdInsertOcorrencias.CommandText = "Insert into Ocorrencias (Detalhe) values (@Detalhe)";

                //insertCrimes
                SqlCommand cmdInsertCrimes = new SqlCommand();
                cmdInsertCrimes.Connection = db;
                cmdInsertCrimes.CommandText = "Insert into Crimes (Tipo) values (@Tipo)";
                cmdInsertCrimes.CommandText = "Insert into Crimes (Gravidade) values (@Gravidade)";


                cmdInsertCriminoso.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                cmdInsertCriminoso.Parameters.Add("@Idade", SqlDbType.Int).Value = Idade;
                cmdInsertCriminoso.Parameters.Add("@CartaoCidadao", SqlDbType.Int).Value = CC;

                cmdInsertFreguesia.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Freguesia;

                cmdInsertConcelho.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Concelho;

                cmdInsertDistrito.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Distrito;

                cmdInsertOcorrencias.Parameters.Add("@Detalhe", SqlDbType.VarChar).Value = Detalhe;
                cmdInsertOcorrencias.Parameters.Add("@Hora", SqlDbType.DateTime).Value = Data;

                cmdInsertCrimes.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = Crime;
                cmdInsertCrimes.Parameters.Add("@Gravidade", SqlDbType.Int).Value = Gravidade;

                int afetados = cmdInsertCriminoso.ExecuteNonQuery();
                int afetados2 = cmdInsertFreguesia.ExecuteNonQuery();
                int afetados3 = cmdInsertConcelho.ExecuteNonQuery();
                int afetados4 = cmdInsertDistrito.ExecuteNonQuery();
                int afetados5 = cmdInsertOcorrencias.ExecuteNonQuery();
                int afetados6 = cmdInsertCrimes.ExecuteNonQuery();


                MessageBox.Show("Registo Criado");
            }
            catch (Exception erro)
            {
                    MessageBox.Show(erro.ToString());
            }
            

        }
    }
}

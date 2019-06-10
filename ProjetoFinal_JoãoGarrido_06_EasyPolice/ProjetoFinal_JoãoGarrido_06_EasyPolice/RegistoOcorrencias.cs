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
                SqlDataReader dr;

                string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
                SqlConnection db = new SqlConnection(connectionString);

                db.Open();

                string Nome = TextNome.Text;
                string CC = "";
                string Data = textdata.Value.ToString();
                string Distrito = ComboDistrito.SelectedValue.ToString();
                string Detalhe = TextDetalhe.Text;
                string Crime = ComboCrime.SelectedValue.ToString();
                string idade = textidade.Text;
                string distintivo = comboBox1.SelectedValue.ToString();

                string queryCriminoso = "SELECT CartaoCidadao FROM Criminoso WHERE CartaoCidadao=@CartaoCidadao";

                SqlCommand cmdSelectCriminoso = new SqlCommand(queryCriminoso, db);

                cmdSelectCriminoso.Parameters.Add("@CartaoCidadao", SqlDbType.Int).Value = TextCC.Text;

                dr = cmdSelectCriminoso.ExecuteReader();

                while (dr.Read())
                {
                    CC = dr["CartaoCidadao"].ToString();
                }
                dr.Close();

                if (CC != TextCC.Text)
                {
                    //insertcriminoso
                    SqlCommand cmdInsertCriminoso = new SqlCommand();
                    cmdInsertCriminoso.Connection = db;
                    cmdInsertCriminoso.CommandText = "Insert into Criminoso (Nome, CartaoCidadao, Idade) values (@Nome, @Cartaocidadao, @Idade)";

                    cmdInsertCriminoso.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome;
                    cmdInsertCriminoso.Parameters.Add("@CartaoCidadao", SqlDbType.Int).Value = TextCC.Text;
                    cmdInsertCriminoso.Parameters.Add("@Idade", SqlDbType.Int).Value = Convert.ToInt32(idade);
                    cmdInsertCriminoso.ExecuteNonQuery();

                    string query = "SELECT IdCriminoso FROM Criminoso WHERE CartaoCidadao=@CartaoCidadao";

                    SqlCommand cmdSelect = new SqlCommand(query, db);

                    cmdSelect.Parameters.Add("@CartaoCidadao", SqlDbType.Int).Value = TextCC.Text;

                    dr = cmdSelect.ExecuteReader();

                    while (dr.Read())
                    {
                        CC = dr["IdCriminoso"].ToString();
                    }
                    dr.Close();


                    //insertOcorrencias
                    SqlCommand cmdInsertOcorrencias = new SqlCommand();
                    cmdInsertOcorrencias.Connection = db;
                    cmdInsertOcorrencias.CommandText = "Insert into Ocorrencias (Data, Detalhe, IdDistrito, idUtilizador, IdCrime, IdCriminoso) values (@Data, @Detalhe, @IdDistrito, @IdUtilizador, @IdCrime, @IdCriminoso)";

                    cmdInsertOcorrencias.Parameters.Add("@Data", SqlDbType.Date).Value = Data;
                    cmdInsertOcorrencias.Parameters.Add("@Detalhe", SqlDbType.VarChar).Value = Detalhe;
                    cmdInsertOcorrencias.Parameters.Add("@IdDistrito", SqlDbType.Int).Value = Distrito;
                    cmdInsertOcorrencias.Parameters.Add("@idUtilizador", SqlDbType.Int).Value = distintivo;
                    cmdInsertOcorrencias.Parameters.Add("@Idcrime", SqlDbType.Int).Value = Crime;
                    cmdInsertOcorrencias.Parameters.Add("@IdCriminoso", SqlDbType.Int).Value = CC;
                    cmdInsertOcorrencias.ExecuteNonQuery();

                    MessageBox.Show("Registo Criado");
                    db.Close();
                }
                else
                {
                    string query = "SELECT IdCriminoso FROM Criminoso WHERE CartaoCidadao=@CartaoCidadao";

                    SqlCommand cmdSelect = new SqlCommand(query, db);

                    cmdSelect.Parameters.Add("@CartaoCidadao", SqlDbType.Int).Value = TextCC.Text;

                    dr = cmdSelect.ExecuteReader();

                    while (dr.Read())
                    {
                        CC = dr["IdCriminoso"].ToString();
                    }
                    dr.Close();


                    //insertOcorrencias
                    SqlCommand cmdInsertOcorrencias = new SqlCommand();
                    cmdInsertOcorrencias.Connection = db;
                    cmdInsertOcorrencias.CommandText = "Insert into Ocorrencias (Data, Detalhe, IdDistrito, idUtilizador, IdCrime, IdCriminoso) values (@Data, @Detalhe, @IdDistrito, @IdUtilizador, @IdCrime, @IdCriminoso)";

                    cmdInsertOcorrencias.Parameters.Add("@Data", SqlDbType.Date).Value = Data;
                    cmdInsertOcorrencias.Parameters.Add("@Detalhe", SqlDbType.VarChar).Value = Detalhe;
                    cmdInsertOcorrencias.Parameters.Add("@IdDistrito", SqlDbType.Int).Value = Distrito;
                    cmdInsertOcorrencias.Parameters.Add("@idUtilizador", SqlDbType.Int).Value = distintivo;
                    cmdInsertOcorrencias.Parameters.Add("@Idcrime", SqlDbType.Int).Value = Crime;
                    cmdInsertOcorrencias.Parameters.Add("@IdCriminoso", SqlDbType.Int).Value = CC;
                    cmdInsertOcorrencias.ExecuteNonQuery();

                    MessageBox.Show("Registo Criado");
                    db.Close();
                }

                TextNome.Clear();
                TextDetalhe.Clear();
                textidade.Clear();
                TextCC.Clear();

            }
            catch (Exception erro)
            {
                    MessageBox.Show(erro.ToString());
            }

        }

        private void RegistoOcorrencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'easyPolice_BdDataSet2.Utilizador' table. You can move, or remove it, as needed.
            this.utilizadorTableAdapter.Fill(this.easyPolice_BdDataSet2.Utilizador); 
            // TODO: This line of code loads data into the 'easyPolice_BdDataSet1.Crimes' table. You can move, or remove it, as needed.
            this.crimesTableAdapter.Fill(this.easyPolice_BdDataSet1.Crimes);
            // TODO: This line of code loads data into the 'easyPolice_BdDataSet1.Distrito' table. You can move, or remove it, as needed.
            this.distritoTableAdapter.Fill(this.easyPolice_BdDataSet1.Distrito);

        }
    }
}

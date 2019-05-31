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
         /*   string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            db.Open();

            string Nome = TextNome.Text;
            string Hora = TextHora.Text;
            string Data = TextData.Text;
            string Freguesia = TextFreguesia.Text;
            string Concelho = TextConcelho.Text;
            string Distrito = ComboDistrito.SelectedItem.ToString();
            string Crime = ComboCrime.SelectedItem.ToString();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = db;

            cmdInsert.CommandText = "Insert into Criminoso (Nome, Idade, CartaoCidadao) values (@Nome, @Idade, @CartaoCidadao)";
            cmdInsert.CommandText = "Insert into Freguesia (Nome) values (@Nome)";
            cmdInsert.CommandText = "Insert into Concelho (Nome) values (@Nome)";
            cmdInsert.CommandText = "Insert into Distrito (Nome) values (@Nome)";
            cmdInsert.CommandText = "Insert into Ocorrencias (Hora) values (@Hora)";
            cmdInsert.CommandText = "Insert into Ocorrencias (Detalhe) values (@Detalhe)";
            cmdInsert.CommandText = "Insert into Crimes (Tipo) values (@Tipo)";
            cmdInsert.CommandText = "Insert into Crimes (Gravidade) values (@Gravidade)";




            cmdInsert.Parameters.Add("@Nome", SqlDbType.VarChar).Value = usernameregisto;
            cmdInsert.Parameters.Add("@Password", SqlDbType.VarChar).Value = passregisto;
            cmdInsert.Parameters.Add("@Distintivo", SqlDbType.Int).Value = distintivo;
            */

        }
    }
}

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
    public partial class InformacoesExtra : Form
    {
        public InformacoesExtra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //fazer o update do criminoso.
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            int altura = Convert.ToInt32(txtaltura.Text);
            string sexo = txtsexo.Text;
            string cor = txtcor.Text;
            string CC = "";

            try
            {
                db.Open();

                SqlDataReader dr; 

                string query = "SELECT IdCriminoso FROM Criminoso WHERE CartaoCidadao=@CartaoCidadao"; 

                SqlCommand cmdSelect = new SqlCommand(query, db);

                cmdSelect.Parameters.Add("@CartaoCidadao", SqlDbType.Int).Value = txtCC.Text;

                dr = cmdSelect.ExecuteReader();

                while (dr.Read()) //ler o idcriminoso a partir do Cartao de Cidadão para depois fazer update só nesse criminoso.
                {
                    CC = dr["IdCriminoso"].ToString();
                }
                dr.Close();

                SqlCommand cmdInsertCriminoso = new SqlCommand();
                cmdInsertCriminoso.Connection = db;

                cmdInsertCriminoso.CommandText = "UPDATE Criminoso SET Altura = @Altura, Sexo = @Sexo, Cor = @Cor WHERE IdCriminoso = @IdCriminoso";

                cmdInsertCriminoso.Parameters.Add("@IdCriminoso", SqlDbType.Int).Value = CC;
                cmdInsertCriminoso.Parameters.Add("@Altura", SqlDbType.Int).Value = txtaltura.Text;
                cmdInsertCriminoso.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = txtsexo.Text;
                cmdInsertCriminoso.Parameters.Add("@Cor", SqlDbType.VarChar).Value = txtcor.Text;
                cmdInsertCriminoso.ExecuteNonQuery();

                MessageBox.Show("Atualização feita com sucesso!");
                db.Close();
                cmdInsertCriminoso.Dispose();
                GC.Collect();
              
                if (!dr.IsClosed)
                {
                    dr.Close();
                }

                txtaltura.Text = "";
                txtCC.Text = "";
                txtcor.Text = "";
                txtsexo.Text = "";
            
            }
            catch (Exception)
            {
                if (CC != txtCC.Text)
                {
                    MessageBox.Show("Criminoso não existe!");
                } 
            }
        }

        private void txtaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8) //so deixar escrever numeros
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 3)  //so deixar escrever ate quatro caracteres.
            {
                e.Handled = !(e.KeyChar == 8);
            }
        }
    }
}

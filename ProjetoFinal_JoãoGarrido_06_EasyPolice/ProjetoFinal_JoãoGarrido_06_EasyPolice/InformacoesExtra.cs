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
using System.IO;

namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class InformacoesExtra : Form
    {
        public InformacoesExtra()
        {
            InitializeComponent();
        }

        public void apagar()
        {
            txtaltura.Text = "";
            txtCC.Text = "";
            txtcor.Text = "";
            txtsexo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) //fazer o update do criminoso.
        {
           
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);
            
            string sexo = txtsexo.Text;
            string cor = txtcor.Text;
            string CC = "";

           

            try
            {
                if (txtCC.Text == "" || txtaltura.Text == "" || txtcor.Text == "" || txtsexo.Text == "" )
                {
                    MessageBox.Show("Introduza os valores necessários por favor");
                    apagar();
                }
                else
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

                    apagar();
                }
            }
            catch (Exception)
            {
                if (CC != txtCC.Text)
                {
                    MessageBox.Show("Criminoso não existe!");
                    apagar();
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);


            //imagem
            string filePath;
            string folderpath = @"\temp\imagens\";
            OpenFileDialog open = new OpenFileDialog();
            string CC = txtCC.Text;

            if (txtCC.Text != "")
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

                    try
                    {

                        if (open.ShowDialog() == DialogResult.OK)
                        {
                            open.Filter = ("Image Files *.jpg, *.jpeg, *.jpe, *.jfif, *.png | *.jpg, *.jpeg, *.jpe, *.jfif, *.png");

                            filePath = open.FileName;


                            if (!Directory.Exists(folderpath))
                            {
                                Directory.CreateDirectory(folderpath);
                            }


                            SqlCommand cmdUpdateFoto = new SqlCommand();
                            cmdUpdateFoto.Connection = db;

                            cmdUpdateFoto.CommandText = "UPDATE Criminoso SET Fotografia = @Fotografia WHERE IdCriminoso = @IdCriminoso";
                            cmdUpdateFoto.Parameters.Add("@IdCriminoso", SqlDbType.Int).Value = CC;
                            cmdUpdateFoto.Parameters.Add("@Fotografia", SqlDbType.VarChar).Value = folderpath + Path.GetFileName(open.FileName);


                            string fileName = Path.Combine(folderpath, Path.GetFileName(filePath));

                            if (!File.Exists(fileName))
                            {
                                File.Copy(filePath, fileName, true);
                            }

                            cmdUpdateFoto.ExecuteNonQuery();

                            MessageBox.Show("Atualização feita com sucesso!");
                            db.Close();
                            cmdUpdateFoto.Dispose();

                            GC.Collect();

                            if (!dr.IsClosed)
                            {
                                dr.Close();
                            }

                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.ToString());
                    }
             

            }
            else
            {
                MessageBox.Show("Introduza um Cartão de Cidadão");
            }
        }
        }
    }

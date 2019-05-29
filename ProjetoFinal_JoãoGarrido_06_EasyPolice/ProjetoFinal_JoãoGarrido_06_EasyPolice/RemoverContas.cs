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

namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class RemoverContas : Form
    {
        private static string connectionString = "Data Source=.;Initial Catalog=EasyPolice_Bd; Integrated Security=True";
        private static SqlConnection db = new SqlConnection(connectionString);
        

        public RemoverContas()
        {
            InitializeComponent();
        }


        private void textbox1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               textDistintivo.Focus();
            }
        }
        private void textdistintivo (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer desativar a conta?", "Desativar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.Open();
                    string deletename = apagar.Text;
                    string distintivodelete = textDistintivo.Text;

                    SqlCommand cmdDelete = new SqlCommand();
                    cmdDelete.Connection = db;

                    cmdDelete.CommandText = ("UPDATE Utilizador SET Ativo_Inativo = 0 WHERE Distintivo = @Distintivo AND Nome = @Nome");
                    cmdDelete.Parameters.Add("@Distintivo", SqlDbType.Int).Value = distintivodelete;
                    cmdDelete.Parameters.Add("@Nome", SqlDbType.VarChar).Value = deletename;
                    
                    int afectados = cmdDelete.ExecuteNonQuery();
                    db.Close();

                    MessageBox.Show("Conta Desativada");

                    if (apagar.Text != "" || apagar.Text != null && textDistintivo.Text != "" || textDistintivo.Text !=null)
                    {
                        textDistintivo.Text = "";
                        apagar.Text = "";
                    }
                    
                }
            } 
            catch (Exception errado)
            {
                MessageBox.Show(errado.ToString());
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void distintivopress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') //so deixar escrever numeros
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 4) //so deixar esscrever ate quatro caracteres.
            {
                e.Handled = true;
            }
        }
    }
}

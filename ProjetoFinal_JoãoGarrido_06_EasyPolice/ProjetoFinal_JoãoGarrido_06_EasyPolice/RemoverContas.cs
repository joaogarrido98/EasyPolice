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
                    bool AtivoInativo = false;

                    SqlCommand cmdDelete = new SqlCommand();
                    cmdDelete.Connection = db;

                    cmdDelete.CommandText = "UPDATE Utilizador set Ativo_Inativo = @Ativo_Inativo WHERE nome=@nome";
                    cmdDelete.Parameters.Add("@Ativo_Inativo", SqlDbType.Bit).Value = AtivoInativo;

                    int afectados = cmdDelete.ExecuteNonQuery();

                    MessageBox.Show("Conta Desativada");

                    if (apagar.Text != "" || apagar.Text != null)
                    {
                        apagar.Text = "";
                    }

                }
                if (dialogResult == DialogResult.No)
                {

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
    }
}

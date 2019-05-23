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
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer remover a conta?", "Remover", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.Open();
                string deletename = apagar.Text;

                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = db;

                cmdDelete.CommandText = "DELETE FROM utilizador where Nome=@Nome";
                cmdDelete.Parameters.Add("@Nome", SqlDbType.VarChar).Value = deletename;

                int afectados = cmdDelete.ExecuteNonQuery();

                MessageBox.Show("Conta apagada");

                if (apagar.Text != "" || apagar.Text != null)
                {
                    apagar.Text = "";
                }

            }
            if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

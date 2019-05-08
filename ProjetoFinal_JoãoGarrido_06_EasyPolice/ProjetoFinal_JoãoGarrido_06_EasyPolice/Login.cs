using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //sistema de login do programa 
        { 
            
            //nao liga ao using mysql.data....
            string user = textuser.Text;
            string password = textpassword.Text;
            //completar a base de dados...
           // MysqlConnection connect = new MysqlConnection();



            if(/*consicao*/) //falta ainda distinguir de admin e de normal.
            {
                EasyPolice_Admin admin = new EasyPolice_Admin();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login incorreto, tente novamente");
            }
        }
    }
}

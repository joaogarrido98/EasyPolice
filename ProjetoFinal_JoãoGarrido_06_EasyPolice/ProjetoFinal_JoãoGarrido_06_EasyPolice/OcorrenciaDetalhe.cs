﻿using System;
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
using System.Threading;


namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class OcorrenciaDetalhe : Form
    {
        public OcorrenciaDetalhe()
        {
            InitializeComponent();
            
        }

        public void carregar(int ocorrenciaId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EasyPolice_BD"].ConnectionString;
            SqlConnection db = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = db.CreateCommand();
                db.Open();

                cmd.CommandText = ("SELECT dbo.Ocorrencias.IdOcorrencia, dbo.Criminoso.Nome, dbo.Ocorrencias.Data, dbo.Crimes.Tipo, dbo.Crimes.Gravidade, dbo.Ocorrencias.Detalhe, dbo.Distrito.Nome AS Distrito, dbo.Utilizador.Distintivo, dbo.Concelho.Nome AS Concelho,   dbo.Freguesia.Nome AS Freguesia FROM dbo.Ocorrencias INNER JOIN dbo.Criminoso ON dbo.Ocorrencias.IdCriminoso = dbo.Criminoso.IdCriminoso INNER JOIN dbo.Crimes ON dbo.Ocorrencias.IdCrime = dbo.Crimes.IdCrime INNER JOIN  dbo.Distrito ON dbo.Ocorrencias.IdDistrito = dbo.Distrito.IdDistrito INNER JOIN dbo.Utilizador ON dbo.Ocorrencias.idUtilizador = dbo.Utilizador.IdUtilizador INNER JOIN dbo.Concelho ON dbo.Ocorrencias.IdConcelho = dbo.Concelho.IdConcelho INNER JOIN dbo.Freguesia ON dbo.Ocorrencias.IdFreguesia = dbo.Freguesia.IdFreguesia WHERE IdOcorrencia = @IdOcorrencia");
                cmd.Parameters.Add("@IdOcorrencia", SqlDbType.Int).Value = ocorrenciaId;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtdetalhe.Text = dr["Detalhe"].ToString();
                        txtdata.Text = dr["Data"].ToString();
                        txtdistrito.Text = dr["Distrito"].ToString();
                        txtConcelho.Text = dr["Concelho"].ToString();
                        txtfreguesia.Text = dr["Freguesia"].ToString();
                        txtpolicia.Text = dr["Distintivo"].ToString();
                        txtcrime.Text = dr["Tipo"].ToString();
                        txtgravidade.Text = dr["gravidade"].ToString();
                        txtcriminoso.Text = dr["Nome"].ToString();
                    }
                    dr.Close();
                }
                db.Close();
                cmd.Dispose();
                GC.Collect();

            }
            catch (Exception errado)
            {
                MessageBox.Show(errado.ToString());
            }

        }

        }
    }

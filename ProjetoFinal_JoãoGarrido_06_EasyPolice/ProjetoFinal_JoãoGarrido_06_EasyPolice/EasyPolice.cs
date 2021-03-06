﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    public partial class EasyPolice : Form
    {
        public EasyPolice()
        {
            InitializeComponent();
        }

        //chamar os forms respetivos de cada botao. Em mdi

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que quer fazer logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
            }
        }

        private void registoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistoOcorrencias mdiRO = new RegistoOcorrencias();
            mdiRO.MdiParent = this;
            mdiRO.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaOcorrencias mdiCO = new ConsultaOcorrencias();
            mdiCO.MdiParent = this;
            mdiCO.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroPesquisa mdiCP = new CadastroPesquisa();
            mdiCP.MdiParent = this;
            mdiCP.Show();
        }

        private void informaçõesExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacoesExtra mdiIE = new InformacoesExtra();
            mdiIE.MdiParent = this;
            mdiIE.Show();
        }

    }
}

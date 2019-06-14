namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    partial class CadastroDetalhe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDetalhe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Policia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.TextBox();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtalt = new System.Windows.Forms.TextBox();
            this.lblcor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Crime,
            this.Distrito,
            this.Policia});
            this.dataGridView1.Location = new System.Drawing.Point(80, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 207);
            this.dataGridView1.TabIndex = 5;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Crime
            // 
            this.Crime.DataPropertyName = "Tipo";
            this.Crime.HeaderText = "Crime";
            this.Crime.Name = "Crime";
            this.Crime.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Nome";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // Policia
            // 
            this.Policia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Policia.DataPropertyName = "Distintivo";
            this.Policia.HeaderText = "Policia";
            this.Policia.Name = "Policia";
            this.Policia.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(77, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(236, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(219, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Idade:";
            // 
            // lblnome
            // 
            this.lblnome.BackColor = System.Drawing.SystemColors.Info;
            this.lblnome.Location = new System.Drawing.Point(123, 49);
            this.lblnome.Name = "lblnome";
            this.lblnome.ReadOnly = true;
            this.lblnome.Size = new System.Drawing.Size(100, 22);
            this.lblnome.TabIndex = 17;
            // 
            // lblCC
            // 
            this.lblCC.BackColor = System.Drawing.SystemColors.Info;
            this.lblCC.Location = new System.Drawing.Point(264, 88);
            this.lblCC.Name = "lblCC";
            this.lblCC.ReadOnly = true;
            this.lblCC.Size = new System.Drawing.Size(100, 22);
            this.lblCC.TabIndex = 18;
            // 
            // lblIdade
            // 
            this.lblIdade.BackColor = System.Drawing.SystemColors.Info;
            this.lblIdade.Location = new System.Drawing.Point(264, 128);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.ReadOnly = true;
            this.lblIdade.Size = new System.Drawing.Size(53, 22);
            this.lblIdade.TabIndex = 19;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.BackColor = System.Drawing.SystemColors.Control;
            this.lblsexo.Location = new System.Drawing.Point(393, 91);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(41, 17);
            this.lblsexo.TabIndex = 20;
            this.lblsexo.Text = "sexo:";
            // 
            // txtsexo
            // 
            this.txtsexo.BackColor = System.Drawing.SystemColors.Info;
            this.txtsexo.Location = new System.Drawing.Point(440, 91);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.ReadOnly = true;
            this.txtsexo.Size = new System.Drawing.Size(54, 22);
            this.txtsexo.TabIndex = 21;
            // 
            // txtcor
            // 
            this.txtcor.BackColor = System.Drawing.SystemColors.Info;
            this.txtcor.Location = new System.Drawing.Point(395, 128);
            this.txtcor.Name = "txtcor";
            this.txtcor.ReadOnly = true;
            this.txtcor.Size = new System.Drawing.Size(99, 22);
            this.txtcor.TabIndex = 22;
            // 
            // txtalt
            // 
            this.txtalt.BackColor = System.Drawing.SystemColors.Info;
            this.txtalt.Location = new System.Drawing.Point(575, 91);
            this.txtalt.Name = "txtalt";
            this.txtalt.ReadOnly = true;
            this.txtalt.Size = new System.Drawing.Size(49, 22);
            this.txtalt.TabIndex = 23;
            // 
            // lblcor
            // 
            this.lblcor.AutoSize = true;
            this.lblcor.BackColor = System.Drawing.SystemColors.Control;
            this.lblcor.Location = new System.Drawing.Point(357, 131);
            this.lblcor.Name = "lblcor";
            this.lblcor.Size = new System.Drawing.Size(32, 17);
            this.lblcor.TabIndex = 24;
            this.lblcor.Text = "cor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(520, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Altura:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 130);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(630, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "cm";
            // 
            // CadastroDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblcor);
            this.Controls.Add(this.txtalt);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Detalhe";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CadastroDetalhe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblnome;
        private System.Windows.Forms.TextBox lblCC;
        private System.Windows.Forms.TextBox lblIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Policia;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtalt;
        private System.Windows.Forms.Label lblcor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
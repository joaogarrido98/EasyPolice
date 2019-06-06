namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    partial class RegistoOcorrencias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistoOcorrencias));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextNome = new System.Windows.Forms.TextBox();
            this.TextFreguesia = new System.Windows.Forms.TextBox();
            this.TextConcelho = new System.Windows.Forms.TextBox();
            this.ComboCrime = new System.Windows.Forms.ComboBox();
            this.crimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.easyPolice_BdDataSet1 = new ProjetoFinal_JoãoGarrido_06_EasyPolice.EasyPolice_BdDataSet1();
            this.ComboDistrito = new System.Windows.Forms.ComboBox();
            this.distritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TextDetalhe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextCC = new System.Windows.Forms.TextBox();
            this.textdata = new System.Windows.Forms.DateTimePicker();
            this.distritoTableAdapter = new ProjetoFinal_JoãoGarrido_06_EasyPolice.EasyPolice_BdDataSet1TableAdapters.DistritoTableAdapter();
            this.distritoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.crimesTableAdapter = new ProjetoFinal_JoãoGarrido_06_EasyPolice.EasyPolice_BdDataSet1TableAdapters.CrimesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyPolice_BdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Freguesia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Concelho:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Distrito:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nome:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Crime:";
            // 
            // TextNome
            // 
            this.TextNome.Location = new System.Drawing.Point(140, 79);
            this.TextNome.Name = "TextNome";
            this.TextNome.Size = new System.Drawing.Size(100, 22);
            this.TextNome.TabIndex = 1;
            // 
            // TextFreguesia
            // 
            this.TextFreguesia.Location = new System.Drawing.Point(317, 81);
            this.TextFreguesia.Name = "TextFreguesia";
            this.TextFreguesia.Size = new System.Drawing.Size(100, 22);
            this.TextFreguesia.TabIndex = 4;
            // 
            // TextConcelho
            // 
            this.TextConcelho.Location = new System.Drawing.Point(317, 109);
            this.TextConcelho.Name = "TextConcelho";
            this.TextConcelho.Size = new System.Drawing.Size(100, 22);
            this.TextConcelho.TabIndex = 5;
            // 
            // ComboCrime
            // 
            this.ComboCrime.DataSource = this.crimesBindingSource;
            this.ComboCrime.DisplayMember = "Tipo";
            this.ComboCrime.FormattingEnabled = true;
            this.ComboCrime.Location = new System.Drawing.Point(140, 139);
            this.ComboCrime.Name = "ComboCrime";
            this.ComboCrime.Size = new System.Drawing.Size(100, 24);
            this.ComboCrime.TabIndex = 9;
            this.ComboCrime.ValueMember = "IdCrime";
            // 
            // crimesBindingSource
            // 
            this.crimesBindingSource.DataMember = "Crimes";
            this.crimesBindingSource.DataSource = this.easyPolice_BdDataSet1;
            // 
            // easyPolice_BdDataSet1
            // 
            this.easyPolice_BdDataSet1.DataSetName = "EasyPolice_BdDataSet1";
            this.easyPolice_BdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComboDistrito
            // 
            this.ComboDistrito.BackColor = System.Drawing.Color.White;
            this.ComboDistrito.DataSource = this.distritoBindingSource;
            this.ComboDistrito.DisplayMember = "Nome";
            this.ComboDistrito.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ComboDistrito.FormattingEnabled = true;
            this.ComboDistrito.Location = new System.Drawing.Point(317, 139);
            this.ComboDistrito.Name = "ComboDistrito";
            this.ComboDistrito.Size = new System.Drawing.Size(100, 24);
            this.ComboDistrito.TabIndex = 6;
            this.ComboDistrito.ValueMember = "IdDistrito";
            // 
            // distritoBindingSource
            // 
            this.distritoBindingSource.DataMember = "Distrito";
            this.distritoBindingSource.DataSource = this.easyPolice_BdDataSet1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(556, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CriarRegisto);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(85, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Detalhe: (1000)";
            // 
            // TextDetalhe
            // 
            this.TextDetalhe.Location = new System.Drawing.Point(88, 195);
            this.TextDetalhe.Multiline = true;
            this.TextDetalhe.Name = "TextDetalhe";
            this.TextDetalhe.Size = new System.Drawing.Size(462, 183);
            this.TextDetalhe.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "CC:";
            // 
            // TextCC
            // 
            this.TextCC.Location = new System.Drawing.Point(140, 110);
            this.TextCC.Name = "TextCC";
            this.TextCC.Size = new System.Drawing.Size(100, 22);
            this.TextCC.TabIndex = 21;
            // 
            // textdata
            // 
            this.textdata.Location = new System.Drawing.Point(440, 104);
            this.textdata.Name = "textdata";
            this.textdata.Size = new System.Drawing.Size(145, 22);
            this.textdata.TabIndex = 25;
            // 
            // distritoTableAdapter
            // 
            this.distritoTableAdapter.ClearBeforeFill = true;
            // 
            // distritoBindingSource1
            // 
            this.distritoBindingSource1.DataMember = "Distrito";
            this.distritoBindingSource1.DataSource = this.easyPolice_BdDataSet1;
            // 
            // crimesTableAdapter
            // 
            this.crimesTableAdapter.ClearBeforeFill = true;
            // 
            // RegistoOcorrencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 403);
            this.Controls.Add(this.textdata);
            this.Controls.Add(this.TextCC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextDetalhe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboDistrito);
            this.Controls.Add(this.ComboCrime);
            this.Controls.Add(this.TextConcelho);
            this.Controls.Add(this.TextFreguesia);
            this.Controls.Add(this.TextNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistoOcorrencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar Ocorrências";
            this.Load += new System.EventHandler(this.RegistoOcorrencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyPolice_BdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextNome;
        private System.Windows.Forms.TextBox TextFreguesia;
        private System.Windows.Forms.TextBox TextConcelho;
        private System.Windows.Forms.ComboBox ComboCrime;
        private System.Windows.Forms.ComboBox ComboDistrito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextDetalhe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextCC;
        private System.Windows.Forms.DateTimePicker textdata;
        private EasyPolice_BdDataSet1 easyPolice_BdDataSet1;
        private System.Windows.Forms.BindingSource distritoBindingSource;
        private EasyPolice_BdDataSet1TableAdapters.DistritoTableAdapter distritoTableAdapter;
        private System.Windows.Forms.BindingSource distritoBindingSource1;
        private System.Windows.Forms.BindingSource crimesBindingSource;
        private EasyPolice_BdDataSet1TableAdapters.CrimesTableAdapter crimesTableAdapter;
    }
}
namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    partial class ConsultaOcorrências
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaOcorrências));
            this.txtcrime = new System.Windows.Forms.ComboBox();
            this.crimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.easyPolice_BdDataSet1 = new ProjetoFinal_JoãoGarrido_06_EasyPolice.EasyPolice_BdDataSet1();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.distritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distritoTableAdapter = new ProjetoFinal_JoãoGarrido_06_EasyPolice.EasyPolice_BdDataSet1TableAdapters.DistritoTableAdapter();
            this.crimesTableAdapter = new ProjetoFinal_JoãoGarrido_06_EasyPolice.EasyPolice_BdDataSet1TableAdapters.CrimesTableAdapter();
            this.txtdata = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdistrito = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdOcorrencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Criminoso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Policia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyPolice_BdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcrime
            // 
            this.txtcrime.DataSource = this.crimesBindingSource;
            this.txtcrime.DisplayMember = "Tipo";
            this.txtcrime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcrime.FormattingEnabled = true;
            this.txtcrime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtcrime.Location = new System.Drawing.Point(407, 60);
            this.txtcrime.Name = "txtcrime";
            this.txtcrime.Size = new System.Drawing.Size(100, 24);
            this.txtcrime.TabIndex = 4;
            this.txtcrime.ValueMember = "IdCrime";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Crime:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(319, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOcorrencia,
            this.Data,
            this.Criminoso,
            this.Crime,
            this.Distrito,
            this.Policia});
            this.dataGridView1.Location = new System.Drawing.Point(76, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 229);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickcell);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(305, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Recarregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // distritoBindingSource
            // 
            this.distritoBindingSource.DataMember = "Distrito";
            this.distritoBindingSource.DataSource = this.easyPolice_BdDataSet1;
            // 
            // distritoTableAdapter
            // 
            this.distritoTableAdapter.ClearBeforeFill = true;
            // 
            // crimesTableAdapter
            // 
            this.crimesTableAdapter.ClearBeforeFill = true;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(192, 59);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(153, 22);
            this.txtdata.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data:";
            // 
            // txtdistrito
            // 
            this.txtdistrito.DataSource = this.distritoBindingSource;
            this.txtdistrito.DisplayMember = "Nome";
            this.txtdistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtdistrito.FormattingEnabled = true;
            this.txtdistrito.Location = new System.Drawing.Point(354, 27);
            this.txtdistrito.Name = "txtdistrito";
            this.txtdistrito.Size = new System.Drawing.Size(100, 24);
            this.txtdistrito.TabIndex = 24;
            this.txtdistrito.ValueMember = "IdDistrito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Distrito:";
            // 
            // IdOcorrencia
            // 
            this.IdOcorrencia.DataPropertyName = "IdOcorrencia";
            this.IdOcorrencia.HeaderText = "IdOcorrencia";
            this.IdOcorrencia.Name = "IdOcorrencia";
            this.IdOcorrencia.ReadOnly = true;
            this.IdOcorrencia.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Criminoso
            // 
            this.Criminoso.DataPropertyName = "Nome";
            this.Criminoso.HeaderText = "Criminoso";
            this.Criminoso.Name = "Criminoso";
            this.Criminoso.ReadOnly = true;
            // 
            // Crime
            // 
            this.Crime.DataPropertyName = "Tipo";
            this.Crime.HeaderText = "Crime";
            this.Crime.Name = "Crime";
            this.Crime.ReadOnly = true;
            this.Crime.Width = 80;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            this.Distrito.Width = 80;
            // 
            // Policia
            // 
            this.Policia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Policia.DataPropertyName = "Distintivo";
            this.Policia.HeaderText = "Policia";
            this.Policia.Name = "Policia";
            this.Policia.ReadOnly = true;
            // 
            // ConsultaOcorrências
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 407);
            this.Controls.Add(this.txtdistrito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcrime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaOcorrências";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Ocorrências";
            this.Load += new System.EventHandler(this.ConsultaOcorrências_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyPolice_BdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtcrime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private EasyPolice_BdDataSet1 easyPolice_BdDataSet1;
        private System.Windows.Forms.BindingSource distritoBindingSource;
        private EasyPolice_BdDataSet1TableAdapters.DistritoTableAdapter distritoTableAdapter;
        private System.Windows.Forms.BindingSource crimesBindingSource;
        private EasyPolice_BdDataSet1TableAdapters.CrimesTableAdapter crimesTableAdapter;
        private System.Windows.Forms.DateTimePicker txtdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtdistrito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOcorrencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Criminoso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Policia;
    }
}
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
            this.Detalhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Policia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblConcelho = new System.Windows.Forms.Label();
            this.lblFreguesia = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.Detalhe,
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
            this.Crime.HeaderText = "Crime";
            this.Crime.Name = "Crime";
            this.Crime.ReadOnly = true;
            // 
            // Detalhe
            // 
            this.Detalhe.HeaderText = "Detalhe";
            this.Detalhe.Name = "Detalhe";
            this.Detalhe.ReadOnly = true;
            // 
            // Distrito
            // 
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            // 
            // Policia
            // 
            this.Policia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Policia.HeaderText = "Policia";
            this.Policia.Name = "Policia";
            this.Policia.ReadOnly = true;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.SystemColors.Control;
            this.lblnome.Location = new System.Drawing.Point(132, 57);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(45, 17);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Nome";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(272, 131);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(47, 17);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "Idade:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(522, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Adicionar Informações";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 116);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(272, 91);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(30, 17);
            this.lblCC.TabIndex = 10;
            this.lblCC.Text = "CC:";
            // 
            // lblConcelho
            // 
            this.lblConcelho.AutoSize = true;
            this.lblConcelho.Location = new System.Drawing.Point(482, 91);
            this.lblConcelho.Name = "lblConcelho";
            this.lblConcelho.Size = new System.Drawing.Size(71, 17);
            this.lblConcelho.TabIndex = 11;
            this.lblConcelho.Text = "Concelho:";
            // 
            // lblFreguesia
            // 
            this.lblFreguesia.AutoSize = true;
            this.lblFreguesia.Location = new System.Drawing.Point(370, 131);
            this.lblFreguesia.Name = "lblFreguesia";
            this.lblFreguesia.Size = new System.Drawing.Size(75, 17);
            this.lblFreguesia.TabIndex = 12;
            this.lblFreguesia.Text = "Freguesia:";
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(370, 91);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(56, 17);
            this.lblDistrito.TabIndex = 13;
            this.lblDistrito.Text = "Distrito:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(77, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(236, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(219, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Idade:";
            // 
            // CadastroDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDistrito);
            this.Controls.Add(this.lblFreguesia);
            this.Controls.Add(this.lblConcelho);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblnome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Detalhe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblConcelho;
        private System.Windows.Forms.Label lblFreguesia;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Policia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
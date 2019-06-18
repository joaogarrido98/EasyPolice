namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    partial class InformacoesExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacoesExtra));
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.img_Criminoso = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Criminoso)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(346, 33);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(141, 22);
            this.txtCC.TabIndex = 0;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCC.Location = new System.Drawing.Point(35, 31);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(285, 24);
            this.lblCC.TabIndex = 1;
            this.lblCC.Text = "Cartão de Cidadão do criminoso:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar informações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(300, 140);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(76, 22);
            this.txtsexo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cor:";
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(300, 184);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(76, 22);
            this.txtcor.TabIndex = 4;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(300, 100);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(76, 22);
            this.txtaltura.TabIndex = 2;
            this.txtaltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaltura_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Altura:";
            // 
            // img_Criminoso
            // 
            this.img_Criminoso.Image = global::ProjetoFinal_JoãoGarrido_06_EasyPolice.Properties.Resources.face;
            this.img_Criminoso.Location = new System.Drawing.Point(37, 69);
            this.img_Criminoso.Name = "img_Criminoso";
            this.img_Criminoso.Size = new System.Drawing.Size(188, 180);
            this.img_Criminoso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Criminoso.TabIndex = 9;
            this.img_Criminoso.TabStop = false;
            this.img_Criminoso.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "cm";
            // 
            // InformacoesExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 277);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.img_Criminoso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.txtCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformacoesExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Extra";
            this.Load += new System.EventHandler(this.InformacoesExtra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Criminoso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox img_Criminoso;
        private System.Windows.Forms.Label label4;
    }
}
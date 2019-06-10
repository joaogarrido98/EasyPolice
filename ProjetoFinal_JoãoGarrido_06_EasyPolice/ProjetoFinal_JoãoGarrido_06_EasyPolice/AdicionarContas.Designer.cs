namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    partial class AdicionarContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarContas));
            this.textusername = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textdistintivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Criar = new System.Windows.Forms.Button();
            this.AdminCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(169, 97);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(193, 22);
            this.textusername.TabIndex = 1;
            this.textusername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox1);
            this.textusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textusername_KeyPress);
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(169, 149);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(193, 22);
            this.textpass.TabIndex = 2;
            this.textpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox2);
            this.textpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textpass_KeyPress);
            // 
            // textdistintivo
            // 
            this.textdistintivo.Location = new System.Drawing.Point(169, 201);
            this.textdistintivo.Name = "textdistintivo";
            this.textdistintivo.Size = new System.Drawing.Size(193, 22);
            this.textdistintivo.TabIndex = 3;
            this.textdistintivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox3);
            this.textdistintivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textdistintivo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Distintivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // Criar
            // 
            this.Criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criar.Location = new System.Drawing.Point(223, 257);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(95, 31);
            this.Criar.TabIndex = 5;
            this.Criar.Text = "Criar";
            this.Criar.UseVisualStyleBackColor = true;
            this.Criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // AdminCheck
            // 
            this.AdminCheck.AutoSize = true;
            this.AdminCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCheck.Location = new System.Drawing.Point(210, 229);
            this.AdminCheck.Name = "AdminCheck";
            this.AdminCheck.Size = new System.Drawing.Size(121, 22);
            this.AdminCheck.TabIndex = 4;
            this.AdminCheck.Text = "Administrador";
            this.AdminCheck.UseVisualStyleBackColor = true;
            // 
            // AdicionarContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 381);
            this.Controls.Add(this.AdminCheck);
            this.Controls.Add(this.Criar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textdistintivo);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdicionarContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textdistintivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.CheckBox AdminCheck;
    }
}
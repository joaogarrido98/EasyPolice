﻿namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    partial class EasyPolice_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyPolice_Admin));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Most Wanted";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 86);
            this.button2.TabIndex = 1;
            this.button2.Text = "Registar Ocorrências";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 86);
            this.button3.TabIndex = 2;
            this.button3.Text = "Consultar Ocorrências";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(139, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 86);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cadastro";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(418, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 86);
            this.button5.TabIndex = 4;
            this.button5.Text = "Procedimentos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(139, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 86);
            this.button6.TabIndex = 5;
            this.button6.Text = "Adicionar Contas";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(285, 290);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 86);
            this.button7.TabIndex = 6;
            this.button7.Text = "Remover Contas";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(418, 290);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 86);
            this.button8.TabIndex = 7;
            this.button8.Text = "Logout";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(528, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "hh:mm/ dd:mm:aa";
            // 
            // EasyPolice_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "EasyPolice_Admin";
            this.Text = "EasyPolice_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
    }
}


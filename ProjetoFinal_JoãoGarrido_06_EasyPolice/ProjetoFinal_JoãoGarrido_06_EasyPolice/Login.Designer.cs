namespace ProjetoFinal_JoãoGarrido_06_EasyPolice
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.entrarbutton = new System.Windows.Forms.Button();
            this.Ver = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(259, 191);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(102, 24);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(367, 193);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(107, 22);
            this.textuser.TabIndex = 3;
            this.textuser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox1);
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(367, 221);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(107, 22);
            this.textpassword.TabIndex = 4;
            this.textpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox2);
            // 
            // entrarbutton
            // 
            this.entrarbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.entrarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrarbutton.Location = new System.Drawing.Point(318, 258);
            this.entrarbutton.Name = "entrarbutton";
            this.entrarbutton.Size = new System.Drawing.Size(117, 35);
            this.entrarbutton.TabIndex = 5;
            this.entrarbutton.Text = "Entrar";
            this.entrarbutton.UseVisualStyleBackColor = true;
            this.entrarbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ver
            // 
            this.Ver.AutoSize = true;
            this.Ver.Location = new System.Drawing.Point(480, 208);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(117, 21);
            this.Ver.TabIndex = 6;
            this.Ver.Text = "Ver Password";
            this.Ver.UseVisualStyleBackColor = true;
            this.Ver.CheckedChanged += new System.EventHandler(this.Ver_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ProjetoFinal_JoãoGarrido_06_EasyPolice.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(280, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ver);
            this.Controls.Add(this.entrarbutton);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyPolice";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button entrarbutton;
        private System.Windows.Forms.CheckBox Ver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
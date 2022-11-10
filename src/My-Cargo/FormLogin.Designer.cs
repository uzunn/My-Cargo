namespace My_Kargo
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tbxSicilNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxYuklemeResmi = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYuklemeResmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSicilNo
            // 
            this.tbxSicilNo.Location = new System.Drawing.Point(135, 92);
            this.tbxSicilNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSicilNo.Name = "tbxSicilNo";
            this.tbxSicilNo.Size = new System.Drawing.Size(100, 22);
            this.tbxSicilNo.TabIndex = 0;
            this.tbxSicilNo.TextChanged += new System.EventHandler(this.tbxUserName_TextChanged);
            this.tbxSicilNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSicilNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sicil No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(135, 140);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(100, 22);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(135, 188);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 31);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Tamam";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBoxYuklemeResmi
            // 
            this.pictureBoxYuklemeResmi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYuklemeResmi.Image")));
            this.pictureBoxYuklemeResmi.Location = new System.Drawing.Point(24, 91);
            this.pictureBoxYuklemeResmi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxYuklemeResmi.Name = "pictureBoxYuklemeResmi";
            this.pictureBoxYuklemeResmi.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxYuklemeResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxYuklemeResmi.TabIndex = 7;
            this.pictureBoxYuklemeResmi.TabStop = false;
            this.pictureBoxYuklemeResmi.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(155, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 242);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxYuklemeResmi);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSicilNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Giris";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYuklemeResmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSicilNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBoxYuklemeResmi;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
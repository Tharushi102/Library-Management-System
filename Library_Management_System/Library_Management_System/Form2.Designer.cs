namespace Library_Management_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnClose2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textfirstName = new System.Windows.Forms.TextBox();
            this.textlastName = new System.Windows.Forms.TextBox();
            this.textUserName2 = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword2 = new System.Windows.Forms.TextBox();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.btncreatAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.Silver;
            this.btnClose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.ForeColor = System.Drawing.Color.Red;
            this.btnClose2.Location = new System.Drawing.Point(286, 12);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(36, 36);
            this.btnClose2.TabIndex = 13;
            this.btnClose2.Text = "X";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "CREATE YOUR ACCOUNT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textfirstName
            // 
            this.textfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textfirstName.ForeColor = System.Drawing.Color.DarkGray;
            this.textfirstName.Location = new System.Drawing.Point(22, 210);
            this.textfirstName.Name = "textfirstName";
            this.textfirstName.Size = new System.Drawing.Size(143, 29);
            this.textfirstName.TabIndex = 16;
            this.textfirstName.Text = "First Name";
            this.textfirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textfirstName_MouseClick);
            // 
            // textlastName
            // 
            this.textlastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textlastName.ForeColor = System.Drawing.Color.DarkGray;
            this.textlastName.Location = new System.Drawing.Point(171, 210);
            this.textlastName.Name = "textlastName";
            this.textlastName.Size = new System.Drawing.Size(143, 29);
            this.textlastName.TabIndex = 17;
            this.textlastName.Text = "Last Name";
            this.textlastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textlastName_MouseClick);
            // 
            // textUserName2
            // 
            this.textUserName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName2.ForeColor = System.Drawing.Color.DarkGray;
            this.textUserName2.Location = new System.Drawing.Point(22, 245);
            this.textUserName2.Name = "textUserName2";
            this.textUserName2.Size = new System.Drawing.Size(292, 29);
            this.textUserName2.TabIndex = 18;
            this.textUserName2.Text = "User Name";
            this.textUserName2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textUserName2_MouseClick);
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.textEmail.Location = new System.Drawing.Point(22, 280);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(292, 29);
            this.textEmail.TabIndex = 19;
            this.textEmail.Text = "Email";
            this.textEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textEmail_MouseClick);
            // 
            // textPassword2
            // 
            this.textPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword2.ForeColor = System.Drawing.Color.DarkGray;
            this.textPassword2.Location = new System.Drawing.Point(22, 315);
            this.textPassword2.Name = "textPassword2";
            this.textPassword2.Size = new System.Drawing.Size(292, 29);
            this.textPassword2.TabIndex = 20;
            this.textPassword2.Text = "Password";
            this.textPassword2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPassword2_MouseClick);
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.textConfirmPassword.Location = new System.Drawing.Point(22, 350);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.Size = new System.Drawing.Size(292, 29);
            this.textConfirmPassword.TabIndex = 21;
            this.textConfirmPassword.Text = "Confirm Password";
            this.textConfirmPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textConfirmPassword_MouseClick);
            // 
            // btncreatAccount
            // 
            this.btncreatAccount.BackColor = System.Drawing.Color.Peru;
            this.btncreatAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncreatAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatAccount.Location = new System.Drawing.Point(22, 405);
            this.btncreatAccount.Name = "btncreatAccount";
            this.btncreatAccount.Size = new System.Drawing.Size(292, 53);
            this.btncreatAccount.TabIndex = 22;
            this.btncreatAccount.Text = "CREAT ACCOUNT";
            this.btncreatAccount.UseVisualStyleBackColor = false;
            this.btncreatAccount.Click += new System.EventHandler(this.btncreatAccount_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(334, 534);
            this.Controls.Add(this.btncreatAccount);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.textPassword2);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textUserName2);
            this.Controls.Add(this.textlastName);
            this.Controls.Add(this.textfirstName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textfirstName;
        private System.Windows.Forms.TextBox textlastName;
        private System.Windows.Forms.TextBox textUserName2;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword2;
        private System.Windows.Forms.TextBox textConfirmPassword;
        private System.Windows.Forms.Button btncreatAccount;
    }
}
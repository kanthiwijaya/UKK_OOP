namespace BetaMart
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 405);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_password);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Location = new System.Drawing.Point(192, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 263);
            this.panel2.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_login.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_login.Location = new System.Drawing.Point(123, 180);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(125, 37);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(81, 117);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(200, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.TabStop = false;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(81, 64);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(200, 20);
            this.txt_username.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beta Mart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 406);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Fast moing goods BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
    }
}


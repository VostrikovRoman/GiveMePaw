namespace GiveMePaw
{
    partial class profil
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
            this.SignUpDisplay = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.password_sign_up = new System.Windows.Forms.TextBox();
            this.email_sign_up = new System.Windows.Forms.TextBox();
            this.phone_sign_up = new System.Windows.Forms.TextBox();
            this.last_name_sign_up = new System.Windows.Forms.TextBox();
            this.name_sign_up = new System.Windows.Forms.TextBox();
            this.save_button_sign_up = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.surname_sign_up = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.SignUpDisplay.SuspendLayout();
            this.save_button_sign_up.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpDisplay
            // 
            this.SignUpDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(181)))), ((int)(((byte)(152)))));
            this.SignUpDisplay.Controls.Add(this.label1);
            this.SignUpDisplay.Controls.Add(this.password_sign_up);
            this.SignUpDisplay.Controls.Add(this.email_sign_up);
            this.SignUpDisplay.Controls.Add(this.phone_sign_up);
            this.SignUpDisplay.Controls.Add(this.last_name_sign_up);
            this.SignUpDisplay.Controls.Add(this.name_sign_up);
            this.SignUpDisplay.Controls.Add(this.save_button_sign_up);
            this.SignUpDisplay.Controls.Add(this.surname_sign_up);
            this.SignUpDisplay.Controls.Add(this.pictureBox5);
            this.SignUpDisplay.Location = new System.Drawing.Point(-5, -5);
            this.SignUpDisplay.Name = "SignUpDisplay";
            this.SignUpDisplay.Size = new System.Drawing.Size(1017, 638);
            this.SignUpDisplay.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(398, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "ПРОФИЛЬ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_sign_up
            // 
            this.password_sign_up.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_sign_up.ForeColor = System.Drawing.Color.Gray;
            this.password_sign_up.Location = new System.Drawing.Point(330, 391);
            this.password_sign_up.Name = "password_sign_up";
            this.password_sign_up.Size = new System.Drawing.Size(356, 36);
            this.password_sign_up.TabIndex = 15;
            this.password_sign_up.Text = "**********";
            // 
            // email_sign_up
            // 
            this.email_sign_up.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_sign_up.ForeColor = System.Drawing.Color.Gray;
            this.email_sign_up.Location = new System.Drawing.Point(330, 340);
            this.email_sign_up.Name = "email_sign_up";
            this.email_sign_up.Size = new System.Drawing.Size(356, 36);
            this.email_sign_up.TabIndex = 14;
            this.email_sign_up.Text = "email";
            // 
            // phone_sign_up
            // 
            this.phone_sign_up.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_sign_up.ForeColor = System.Drawing.Color.Gray;
            this.phone_sign_up.Location = new System.Drawing.Point(330, 289);
            this.phone_sign_up.Name = "phone_sign_up";
            this.phone_sign_up.Size = new System.Drawing.Size(356, 36);
            this.phone_sign_up.TabIndex = 13;
            this.phone_sign_up.Text = "89999999999";
            // 
            // last_name_sign_up
            // 
            this.last_name_sign_up.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name_sign_up.ForeColor = System.Drawing.Color.Gray;
            this.last_name_sign_up.Location = new System.Drawing.Point(330, 238);
            this.last_name_sign_up.Name = "last_name_sign_up";
            this.last_name_sign_up.Size = new System.Drawing.Size(356, 36);
            this.last_name_sign_up.TabIndex = 12;
            this.last_name_sign_up.Text = "Иванович";
            // 
            // name_sign_up
            // 
            this.name_sign_up.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_sign_up.ForeColor = System.Drawing.Color.Gray;
            this.name_sign_up.Location = new System.Drawing.Point(330, 187);
            this.name_sign_up.Name = "name_sign_up";
            this.name_sign_up.Size = new System.Drawing.Size(356, 36);
            this.name_sign_up.TabIndex = 11;
            this.name_sign_up.Text = "Иван";
            // 
            // save_button_sign_up
            // 
            this.save_button_sign_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(140)))), ((int)(((byte)(44)))));
            this.save_button_sign_up.Controls.Add(this.label5);
            this.save_button_sign_up.Location = new System.Drawing.Point(405, 473);
            this.save_button_sign_up.Name = "save_button_sign_up";
            this.save_button_sign_up.Size = new System.Drawing.Size(232, 47);
            this.save_button_sign_up.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(44)))), ((int)(((byte)(4)))));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Редактировать";
            // 
            // surname_sign_up
            // 
            this.surname_sign_up.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname_sign_up.ForeColor = System.Drawing.Color.Gray;
            this.surname_sign_up.Location = new System.Drawing.Point(330, 136);
            this.surname_sign_up.Name = "surname_sign_up";
            this.surname_sign_up.Size = new System.Drawing.Size(356, 36);
            this.surname_sign_up.TabIndex = 3;
            this.surname_sign_up.Text = "Иванов";
            this.surname_sign_up.TextChanged += new System.EventHandler(this.surname_sign_up_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GiveMePaw.Properties.Resources.Rectangle_9;
            this.pictureBox5.Location = new System.Drawing.Point(3, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(268, 333);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 630);
            this.Controls.Add(this.SignUpDisplay);
            this.Name = "profil";
            this.Text = "profil";
            this.SignUpDisplay.ResumeLayout(false);
            this.SignUpDisplay.PerformLayout();
            this.save_button_sign_up.ResumeLayout(false);
            this.save_button_sign_up.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SignUpDisplay;
        private System.Windows.Forms.TextBox password_sign_up;
        private System.Windows.Forms.TextBox email_sign_up;
        private System.Windows.Forms.TextBox phone_sign_up;
        private System.Windows.Forms.TextBox last_name_sign_up;
        private System.Windows.Forms.TextBox name_sign_up;
        private System.Windows.Forms.Panel save_button_sign_up;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surname_sign_up;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
    }
}

namespace GiveMePaw
{
    partial class SignIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.SignInDisplay = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.password_sign_in = new System.Windows.Forms.TextBox();
            this.email_sign_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.link_to_sign_up = new System.Windows.Forms.LinkLabel();
            this.SignInDisplay.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SignInDisplay
            // 
            this.SignInDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(181)))), ((int)(((byte)(152)))));
            this.SignInDisplay.Controls.Add(this.link_to_sign_up);
            this.SignInDisplay.Controls.Add(this.label3);
            this.SignInDisplay.Controls.Add(this.panel2);
            this.SignInDisplay.Controls.Add(this.pictureBox3);
            this.SignInDisplay.Controls.Add(this.password_sign_in);
            this.SignInDisplay.Controls.Add(this.email_sign_in);
            this.SignInDisplay.Controls.Add(this.label1);
            this.SignInDisplay.Controls.Add(this.pictureBox1);
            this.SignInDisplay.Controls.Add(this.pictureBox2);
            this.SignInDisplay.Location = new System.Drawing.Point(0, 0);
            this.SignInDisplay.Name = "SignInDisplay";
            this.SignInDisplay.Size = new System.Drawing.Size(1011, 617);
            this.SignInDisplay.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(140)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(404, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 47);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(44)))), ((int)(((byte)(4)))));
            this.label2.Location = new System.Drawing.Point(35, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "ВОЙТИ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GiveMePaw.Properties.Resources.paws__1_;
            this.pictureBox3.Location = new System.Drawing.Point(-168, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(453, 406);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // password_sign_in
            // 
            this.password_sign_in.Font = new System.Drawing.Font("Lucida Sans", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_sign_in.ForeColor = System.Drawing.Color.Gray;
            this.password_sign_in.Location = new System.Drawing.Point(340, 310);
            this.password_sign_in.Name = "password_sign_in";
            this.password_sign_in.Size = new System.Drawing.Size(340, 44);
            this.password_sign_in.TabIndex = 4;
            this.password_sign_in.Text = "пароль";
            // 
            // email_sign_in
            // 
            this.email_sign_in.Font = new System.Drawing.Font("Lucida Sans", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_sign_in.ForeColor = System.Drawing.Color.Gray;
            this.email_sign_in.Location = new System.Drawing.Point(340, 248);
            this.email_sign_in.Name = "email_sign_in";
            this.email_sign_in.Size = new System.Drawing.Size(340, 44);
            this.email_sign_in.TabIndex = 3;
            this.email_sign_in.Text = "email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(414, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "ВХОД";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GiveMePaw.Properties.Resources.Rectangle_8;
            this.pictureBox1.Location = new System.Drawing.Point(721, -86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 354);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GiveMePaw.Properties.Resources.Rectangle_7;
            this.pictureBox2.Location = new System.Drawing.Point(520, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(513, 426);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ещё нет аккаунта? Зарегистрируйся";
            // 
            // link_to_sign_up
            // 
            this.link_to_sign_up.ActiveLinkColor = System.Drawing.Color.Black;
            this.link_to_sign_up.AutoSize = true;
            this.link_to_sign_up.BackColor = System.Drawing.Color.Transparent;
            this.link_to_sign_up.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_to_sign_up.LinkColor = System.Drawing.Color.Black;
            this.link_to_sign_up.Location = new System.Drawing.Point(619, 487);
            this.link_to_sign_up.Name = "link_to_sign_up";
            this.link_to_sign_up.Size = new System.Drawing.Size(61, 24);
            this.link_to_sign_up.TabIndex = 8;
            this.link_to_sign_up.TabStop = true;
            this.link_to_sign_up.Text = "здесь!";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 614);
            this.Controls.Add(this.SignInDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 652);
            this.MinimumSize = new System.Drawing.Size(1024, 652);
            this.Name = "SignIn";
            this.Text = "Дай лапу";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SignInDisplay.ResumeLayout(false);
            this.SignInDisplay.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SignInDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox password_sign_in;
        private System.Windows.Forms.TextBox email_sign_in;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel link_to_sign_up;
        private System.Windows.Forms.Label label3;
    }
}


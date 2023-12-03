
namespace GiveMePaw
{
    partial class FormAddPet
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
            this.panelHat = new System.Windows.Forms.Panel();
            this.labelTextAddPet = new System.Windows.Forms.Label();
            this.panelAddPet = new System.Windows.Forms.Panel();
            this.save_button_account = new System.Windows.Forms.Panel();
            this.labelButtSavePet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelButtPetText = new System.Windows.Forms.Label();
            this.PhotoTxtbx = new System.Windows.Forms.TextBox();
            this.BreedTxtbx = new System.Windows.Forms.TextBox();
            this.WeightTxtbx = new System.Windows.Forms.TextBox();
            this.AgeTxtbx = new System.Windows.Forms.TextBox();
            this.NameTxtbx = new System.Windows.Forms.TextBox();
            this.Pet_typeTxtbx = new System.Windows.Forms.TextBox();
            this.panelHat.SuspendLayout();
            this.panelAddPet.SuspendLayout();
            this.save_button_account.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHat
            // 
            this.panelHat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.panelHat.Controls.Add(this.labelTextAddPet);
            this.panelHat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHat.Location = new System.Drawing.Point(0, 0);
            this.panelHat.Name = "panelHat";
            this.panelHat.Size = new System.Drawing.Size(584, 106);
            this.panelHat.TabIndex = 0;
            // 
            // labelTextAddPet
            // 
            this.labelTextAddPet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTextAddPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTextAddPet.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextAddPet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(164)))), ((int)(((byte)(84)))));
            this.labelTextAddPet.Location = new System.Drawing.Point(20, 24);
            this.labelTextAddPet.Name = "labelTextAddPet";
            this.labelTextAddPet.Size = new System.Drawing.Size(548, 63);
            this.labelTextAddPet.TabIndex = 9;
            this.labelTextAddPet.Text = "Добавление животного";
            this.labelTextAddPet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAddPet
            // 
            this.panelAddPet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelAddPet.Controls.Add(this.save_button_account);
            this.panelAddPet.Controls.Add(this.label5);
            this.panelAddPet.Controls.Add(this.label4);
            this.panelAddPet.Controls.Add(this.label3);
            this.panelAddPet.Controls.Add(this.label2);
            this.panelAddPet.Controls.Add(this.label1);
            this.panelAddPet.Controls.Add(this.labelButtPetText);
            this.panelAddPet.Controls.Add(this.PhotoTxtbx);
            this.panelAddPet.Controls.Add(this.BreedTxtbx);
            this.panelAddPet.Controls.Add(this.WeightTxtbx);
            this.panelAddPet.Controls.Add(this.AgeTxtbx);
            this.panelAddPet.Controls.Add(this.NameTxtbx);
            this.panelAddPet.Controls.Add(this.Pet_typeTxtbx);
            this.panelAddPet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAddPet.Location = new System.Drawing.Point(0, 106);
            this.panelAddPet.Name = "panelAddPet";
            this.panelAddPet.Size = new System.Drawing.Size(584, 439);
            this.panelAddPet.TabIndex = 1;
            // 
            // save_button_account
            // 
            this.save_button_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(140)))), ((int)(((byte)(44)))));
            this.save_button_account.Controls.Add(this.labelButtSavePet);
            this.save_button_account.Cursor = System.Windows.Forms.Cursors.Default;
            this.save_button_account.Location = new System.Drawing.Point(225, 376);
            this.save_button_account.Name = "save_button_account";
            this.save_button_account.Size = new System.Drawing.Size(150, 40);
            this.save_button_account.TabIndex = 45;
            // 
            // labelButtSavePet
            // 
            this.labelButtSavePet.AutoSize = true;
            this.labelButtSavePet.BackColor = System.Drawing.Color.Transparent;
            this.labelButtSavePet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelButtSavePet.Font = new System.Drawing.Font("Lucida Sans", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButtSavePet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.labelButtSavePet.Location = new System.Drawing.Point(16, 7);
            this.labelButtSavePet.Name = "labelButtSavePet";
            this.labelButtSavePet.Size = new System.Drawing.Size(119, 26);
            this.labelButtSavePet.TabIndex = 34;
            this.labelButtSavePet.Text = "Сохранить";
            this.labelButtSavePet.Click += new System.EventHandler(this.labelButtSavePet_Click);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(41, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 36);
            this.label5.TabIndex = 44;
            this.label5.Text = "Фото";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(41, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 36);
            this.label4.TabIndex = 43;
            this.label4.Text = "Порода";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(41, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 36);
            this.label3.TabIndex = 42;
            this.label3.Text = "Вес";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(41, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 36);
            this.label2.TabIndex = 41;
            this.label2.Text = "Возраст";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(41, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 36);
            this.label1.TabIndex = 40;
            this.label1.Text = "Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelButtPetText
            // 
            this.labelButtPetText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelButtPetText.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.labelButtPetText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            this.labelButtPetText.Location = new System.Drawing.Point(43, 68);
            this.labelButtPetText.Name = "labelButtPetText";
            this.labelButtPetText.Size = new System.Drawing.Size(127, 36);
            this.labelButtPetText.TabIndex = 39;
            this.labelButtPetText.Text = "Тип";
            this.labelButtPetText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhotoTxtbx
            // 
            this.PhotoTxtbx.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhotoTxtbx.ForeColor = System.Drawing.Color.Gray;
            this.PhotoTxtbx.Location = new System.Drawing.Point(176, 324);
            this.PhotoTxtbx.Name = "PhotoTxtbx";
            this.PhotoTxtbx.Size = new System.Drawing.Size(356, 36);
            this.PhotoTxtbx.TabIndex = 38;
            // 
            // BreedTxtbx
            // 
            this.BreedTxtbx.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreedTxtbx.ForeColor = System.Drawing.Color.Gray;
            this.BreedTxtbx.Location = new System.Drawing.Point(176, 273);
            this.BreedTxtbx.Name = "BreedTxtbx";
            this.BreedTxtbx.Size = new System.Drawing.Size(356, 36);
            this.BreedTxtbx.TabIndex = 37;
            // 
            // WeightTxtbx
            // 
            this.WeightTxtbx.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTxtbx.ForeColor = System.Drawing.Color.Gray;
            this.WeightTxtbx.Location = new System.Drawing.Point(176, 222);
            this.WeightTxtbx.Name = "WeightTxtbx";
            this.WeightTxtbx.Size = new System.Drawing.Size(356, 36);
            this.WeightTxtbx.TabIndex = 36;
            // 
            // AgeTxtbx
            // 
            this.AgeTxtbx.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTxtbx.ForeColor = System.Drawing.Color.Gray;
            this.AgeTxtbx.Location = new System.Drawing.Point(176, 171);
            this.AgeTxtbx.Name = "AgeTxtbx";
            this.AgeTxtbx.Size = new System.Drawing.Size(356, 36);
            this.AgeTxtbx.TabIndex = 35;
            // 
            // NameTxtbx
            // 
            this.NameTxtbx.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtbx.ForeColor = System.Drawing.Color.Gray;
            this.NameTxtbx.Location = new System.Drawing.Point(176, 120);
            this.NameTxtbx.Name = "NameTxtbx";
            this.NameTxtbx.Size = new System.Drawing.Size(356, 36);
            this.NameTxtbx.TabIndex = 34;
            // 
            // Pet_typeTxtbx
            // 
            this.Pet_typeTxtbx.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pet_typeTxtbx.ForeColor = System.Drawing.Color.Gray;
            this.Pet_typeTxtbx.Location = new System.Drawing.Point(176, 68);
            this.Pet_typeTxtbx.Name = "Pet_typeTxtbx";
            this.Pet_typeTxtbx.Size = new System.Drawing.Size(356, 36);
            this.Pet_typeTxtbx.TabIndex = 33;
            // 
            // FormAddPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 545);
            this.Controls.Add(this.panelAddPet);
            this.Controls.Add(this.panelHat);
            this.Name = "FormAddPet";
            this.Text = "FormAddPet";
            this.panelHat.ResumeLayout(false);
            this.panelAddPet.ResumeLayout(false);
            this.panelAddPet.PerformLayout();
            this.save_button_account.ResumeLayout(false);
            this.save_button_account.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHat;
        private System.Windows.Forms.Label labelTextAddPet;
        private System.Windows.Forms.Panel panelAddPet;
        private System.Windows.Forms.TextBox PhotoTxtbx;
        private System.Windows.Forms.TextBox BreedTxtbx;
        private System.Windows.Forms.TextBox WeightTxtbx;
        private System.Windows.Forms.TextBox AgeTxtbx;
        private System.Windows.Forms.TextBox NameTxtbx;
        private System.Windows.Forms.TextBox Pet_typeTxtbx;
        private System.Windows.Forms.Label labelButtPetText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel save_button_account;
        private System.Windows.Forms.Label labelButtSavePet;
    }
}
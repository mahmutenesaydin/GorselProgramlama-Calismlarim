namespace UrunBilgi
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            this.btnŞifreGüncelle = new System.Windows.Forms.Button();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.lblGüncelleYeniSifre = new System.Windows.Forms.Label();
            this.txtSifreGuncelleID = new System.Windows.Forms.TextBox();
            this.lnlSifreGuncelleID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnŞifreGüncelle
            // 
            this.btnŞifreGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnŞifreGüncelle.BackgroundImage")));
            this.btnŞifreGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnŞifreGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnŞifreGüncelle.Font = new System.Drawing.Font("Rockwell", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnŞifreGüncelle.Location = new System.Drawing.Point(202, 230);
            this.btnŞifreGüncelle.Name = "btnŞifreGüncelle";
            this.btnŞifreGüncelle.Size = new System.Drawing.Size(118, 63);
            this.btnŞifreGüncelle.TabIndex = 9;
            this.btnŞifreGüncelle.Text = "Şifremi Güncelle";
            this.btnŞifreGüncelle.UseVisualStyleBackColor = true;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Location = new System.Drawing.Point(190, 168);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(130, 32);
            this.txtYeniSifre.TabIndex = 8;
            // 
            // lblGüncelleYeniSifre
            // 
            this.lblGüncelleYeniSifre.AutoSize = true;
            this.lblGüncelleYeniSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblGüncelleYeniSifre.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGüncelleYeniSifre.Location = new System.Drawing.Point(39, 171);
            this.lblGüncelleYeniSifre.Name = "lblGüncelleYeniSifre";
            this.lblGüncelleYeniSifre.Size = new System.Drawing.Size(128, 25);
            this.lblGüncelleYeniSifre.TabIndex = 7;
            this.lblGüncelleYeniSifre.Text = "Yeni Şifre:";
            // 
            // txtSifreGuncelleID
            // 
            this.txtSifreGuncelleID.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreGuncelleID.Location = new System.Drawing.Point(190, 115);
            this.txtSifreGuncelleID.Name = "txtSifreGuncelleID";
            this.txtSifreGuncelleID.Size = new System.Drawing.Size(130, 32);
            this.txtSifreGuncelleID.TabIndex = 6;
            // 
            // lnlSifreGuncelleID
            // 
            this.lnlSifreGuncelleID.AutoSize = true;
            this.lnlSifreGuncelleID.BackColor = System.Drawing.Color.Transparent;
            this.lnlSifreGuncelleID.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnlSifreGuncelleID.Location = new System.Drawing.Point(30, 118);
            this.lnlSifreGuncelleID.Name = "lnlSifreGuncelleID";
            this.lnlSifreGuncelleID.Size = new System.Drawing.Size(160, 25);
            this.lnlSifreGuncelleID.TabIndex = 5;
            this.lnlSifreGuncelleID.Text = "Kullanıcı Adı:";
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 334);
            this.Controls.Add(this.btnŞifreGüncelle);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.lblGüncelleYeniSifre);
            this.Controls.Add(this.txtSifreGuncelleID);
            this.Controls.Add(this.lnlSifreGuncelleID);
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnŞifreGüncelle;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Label lblGüncelleYeniSifre;
        private System.Windows.Forms.TextBox txtSifreGuncelleID;
        private System.Windows.Forms.Label lnlSifreGuncelleID;
    }
}
namespace UrunBilgi
{
    partial class Kayıt_Ol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıt_Ol));
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.mskCepTel = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblCepTel = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.txtKayıtŞifre = new System.Windows.Forms.TextBox();
            this.lblKayıtŞifre = new System.Windows.Forms.Label();
            this.txtKayıtID = new System.Windows.Forms.TextBox();
            this.lblKayıtID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(186, 309);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(125, 36);
            this.cmbCinsiyet.TabIndex = 23;
            // 
            // mskCepTel
            // 
            this.mskCepTel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskCepTel.Location = new System.Drawing.Point(186, 256);
            this.mskCepTel.Mask = "(999) 000-0000";
            this.mskCepTel.Name = "mskCepTel";
            this.mskCepTel.Size = new System.Drawing.Size(125, 36);
            this.mskCepTel.TabIndex = 21;
            // 
            // btnKaydol
            // 
            this.btnKaydol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydol.BackgroundImage")));
            this.btnKaydol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydol.Font = new System.Drawing.Font("Segoe Print", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydol.Location = new System.Drawing.Point(186, 372);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(125, 46);
            this.btnKaydol.TabIndex = 28;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = true;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.Black;
            this.lblCinsiyet.Location = new System.Drawing.Point(24, 317);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(99, 35);
            this.lblCinsiyet.TabIndex = 27;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblCepTel
            // 
            this.lblCepTel.AutoSize = true;
            this.lblCepTel.BackColor = System.Drawing.Color.Transparent;
            this.lblCepTel.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCepTel.ForeColor = System.Drawing.Color.Black;
            this.lblCepTel.Location = new System.Drawing.Point(24, 259);
            this.lblCepTel.Name = "lblCepTel";
            this.lblCepTel.Size = new System.Drawing.Size(148, 35);
            this.lblCepTel.TabIndex = 26;
            this.lblCepTel.Text = "Cep Telefonu:";
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Location = new System.Drawing.Point(186, 190);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(125, 36);
            this.txtEposta.TabIndex = 19;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.BackColor = System.Drawing.Color.Transparent;
            this.lblEposta.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.ForeColor = System.Drawing.Color.Black;
            this.lblEposta.Location = new System.Drawing.Point(24, 198);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(101, 35);
            this.lblEposta.TabIndex = 25;
            this.lblEposta.Text = "E-posta:";
            // 
            // txtKayıtŞifre
            // 
            this.txtKayıtŞifre.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtŞifre.Location = new System.Drawing.Point(186, 137);
            this.txtKayıtŞifre.Name = "txtKayıtŞifre";
            this.txtKayıtŞifre.Size = new System.Drawing.Size(125, 36);
            this.txtKayıtŞifre.TabIndex = 18;
            // 
            // lblKayıtŞifre
            // 
            this.lblKayıtŞifre.AutoSize = true;
            this.lblKayıtŞifre.BackColor = System.Drawing.Color.Transparent;
            this.lblKayıtŞifre.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayıtŞifre.ForeColor = System.Drawing.Color.Black;
            this.lblKayıtŞifre.Location = new System.Drawing.Point(24, 145);
            this.lblKayıtŞifre.Name = "lblKayıtŞifre";
            this.lblKayıtŞifre.Size = new System.Drawing.Size(67, 35);
            this.lblKayıtŞifre.TabIndex = 24;
            this.lblKayıtŞifre.Text = "Şifre:";
            // 
            // txtKayıtID
            // 
            this.txtKayıtID.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKayıtID.Location = new System.Drawing.Point(186, 91);
            this.txtKayıtID.Name = "txtKayıtID";
            this.txtKayıtID.Size = new System.Drawing.Size(125, 36);
            this.txtKayıtID.TabIndex = 17;
            // 
            // lblKayıtID
            // 
            this.lblKayıtID.AutoSize = true;
            this.lblKayıtID.BackColor = System.Drawing.Color.Transparent;
            this.lblKayıtID.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayıtID.ForeColor = System.Drawing.Color.Black;
            this.lblKayıtID.Location = new System.Drawing.Point(24, 91);
            this.lblKayıtID.Name = "lblKayıtID";
            this.lblKayıtID.Size = new System.Drawing.Size(150, 35);
            this.lblKayıtID.TabIndex = 22;
            this.lblKayıtID.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, -51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lütfen gerekli alanları doldurunuz !";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(186, 29);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(125, 36);
            this.txtAdSoyad.TabIndex = 15;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblAdSoyad.Location = new System.Drawing.Point(30, 27);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(119, 35);
            this.lblAdSoyad.TabIndex = 16;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // Kayıt_Ol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 431);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.mskCepTel);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblCepTel);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.txtKayıtŞifre);
            this.Controls.Add(this.lblKayıtŞifre);
            this.Controls.Add(this.txtKayıtID);
            this.Controls.Add(this.lblKayıtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Name = "Kayıt_Ol";
            this.Text = "Kayıt_Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox mskCepTel;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblCepTel;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.TextBox txtKayıtŞifre;
        private System.Windows.Forms.Label lblKayıtŞifre;
        private System.Windows.Forms.TextBox txtKayıtID;
        private System.Windows.Forms.Label lblKayıtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
    }
}
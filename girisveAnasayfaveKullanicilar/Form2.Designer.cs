namespace girisveAnasayfa
{
    partial class FrmKullanicilar
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
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textKid = new System.Windows.Forms.TextBox();
            this.textKad = new System.Windows.Forms.TextBox();
            this.textKmail = new System.Windows.Forms.TextBox();
            this.textKsifre = new System.Windows.Forms.TextBox();
            this.textKdepartman = new System.Windows.Forms.TextBox();
            this.textKtel = new System.Windows.Forms.TextBox();
            this.buttnKlistele = new System.Windows.Forms.Button();
            this.bttnKsil = new System.Windows.Forms.Button();
            this.bttnKekle = new System.Windows.Forms.Button();
            this.bttnKguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.AllowUserToDeleteRows = false;
            this.dgvKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(12, 12);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.Size = new System.Drawing.Size(673, 218);
            this.dgvKullanicilar.TabIndex = 0;
            this.dgvKullanicilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanicilar_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim ve Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mail Adresi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(84, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Departman:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon No:";
            // 
            // textKid
            // 
            this.textKid.Enabled = false;
            this.textKid.Location = new System.Drawing.Point(147, 251);
            this.textKid.Name = "textKid";
            this.textKid.Size = new System.Drawing.Size(145, 20);
            this.textKid.TabIndex = 7;
            // 
            // textKad
            // 
            this.textKad.Location = new System.Drawing.Point(147, 294);
            this.textKad.Name = "textKad";
            this.textKad.Size = new System.Drawing.Size(145, 20);
            this.textKad.TabIndex = 8;
            // 
            // textKmail
            // 
            this.textKmail.Location = new System.Drawing.Point(147, 332);
            this.textKmail.Name = "textKmail";
            this.textKmail.Size = new System.Drawing.Size(145, 20);
            this.textKmail.TabIndex = 9;
            // 
            // textKsifre
            // 
            this.textKsifre.Location = new System.Drawing.Point(147, 370);
            this.textKsifre.Name = "textKsifre";
            this.textKsifre.Size = new System.Drawing.Size(145, 20);
            this.textKsifre.TabIndex = 10;
            // 
            // textKdepartman
            // 
            this.textKdepartman.Location = new System.Drawing.Point(147, 410);
            this.textKdepartman.Name = "textKdepartman";
            this.textKdepartman.Size = new System.Drawing.Size(145, 20);
            this.textKdepartman.TabIndex = 11;
            // 
            // textKtel
            // 
            this.textKtel.Location = new System.Drawing.Point(147, 452);
            this.textKtel.Name = "textKtel";
            this.textKtel.Size = new System.Drawing.Size(145, 20);
            this.textKtel.TabIndex = 12;
            // 
            // buttnKlistele
            // 
            this.buttnKlistele.BackColor = System.Drawing.Color.FloralWhite;
            this.buttnKlistele.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttnKlistele.Location = new System.Drawing.Point(367, 242);
            this.buttnKlistele.Name = "buttnKlistele";
            this.buttnKlistele.Size = new System.Drawing.Size(115, 45);
            this.buttnKlistele.TabIndex = 13;
            this.buttnKlistele.Text = "Kullanıcıları Listele";
            this.buttnKlistele.UseVisualStyleBackColor = false;
            this.buttnKlistele.Click += new System.EventHandler(this.buttnKlistele_Click);
            // 
            // bttnKsil
            // 
            this.bttnKsil.BackColor = System.Drawing.Color.FloralWhite;
            this.bttnKsil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKsil.Location = new System.Drawing.Point(367, 295);
            this.bttnKsil.Name = "bttnKsil";
            this.bttnKsil.Size = new System.Drawing.Size(115, 45);
            this.bttnKsil.TabIndex = 14;
            this.bttnKsil.Text = "Kullanıcıyı Sil";
            this.bttnKsil.UseVisualStyleBackColor = false;
            this.bttnKsil.Click += new System.EventHandler(this.bttnKsil_Click);
            // 
            // bttnKekle
            // 
            this.bttnKekle.BackColor = System.Drawing.Color.FloralWhite;
            this.bttnKekle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKekle.Location = new System.Drawing.Point(367, 357);
            this.bttnKekle.Name = "bttnKekle";
            this.bttnKekle.Size = new System.Drawing.Size(115, 45);
            this.bttnKekle.TabIndex = 15;
            this.bttnKekle.Text = "Kullanıcıyı Kaydet";
            this.bttnKekle.UseVisualStyleBackColor = false;
            this.bttnKekle.Click += new System.EventHandler(this.bttnKekle_Click);
            // 
            // bttnKguncelle
            // 
            this.bttnKguncelle.BackColor = System.Drawing.Color.FloralWhite;
            this.bttnKguncelle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKguncelle.Location = new System.Drawing.Point(367, 417);
            this.bttnKguncelle.Name = "bttnKguncelle";
            this.bttnKguncelle.Size = new System.Drawing.Size(115, 45);
            this.bttnKguncelle.TabIndex = 16;
            this.bttnKguncelle.Text = "Güncelle";
            this.bttnKguncelle.UseVisualStyleBackColor = false;
            this.bttnKguncelle.Click += new System.EventHandler(this.bttnKguncelle_Click);
            // 
            // FrmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(700, 494);
            this.Controls.Add(this.bttnKguncelle);
            this.Controls.Add(this.bttnKekle);
            this.Controls.Add(this.bttnKsil);
            this.Controls.Add(this.buttnKlistele);
            this.Controls.Add(this.textKtel);
            this.Controls.Add(this.textKdepartman);
            this.Controls.Add(this.textKsifre);
            this.Controls.Add(this.textKmail);
            this.Controls.Add(this.textKad);
            this.Controls.Add(this.textKid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "FrmKullanicilar";
            this.Text = "Kullanıcılar ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textKid;
        private System.Windows.Forms.TextBox textKad;
        private System.Windows.Forms.TextBox textKmail;
        private System.Windows.Forms.TextBox textKsifre;
        private System.Windows.Forms.TextBox textKdepartman;
        private System.Windows.Forms.TextBox textKtel;
        private System.Windows.Forms.Button buttnKlistele;
        private System.Windows.Forms.Button bttnKsil;
        private System.Windows.Forms.Button bttnKekle;
        private System.Windows.Forms.Button bttnKguncelle;
    }
}
namespace kullanicilarSayfasi
{
    partial class FrmKullanicilar
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.bttnKekle = new System.Windows.Forms.Button();
            this.bttnKlistele = new System.Windows.Forms.Button();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.bttnKsil = new System.Windows.Forms.Button();
            this.bttnKguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(119, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(99, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(97, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(60, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kullanıcı Departman:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(77, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon Numarası:";
            // 
            // textKid
            // 
            this.textKid.Enabled = false;
            this.textKid.Location = new System.Drawing.Point(205, 226);
            this.textKid.Name = "textKid";
            this.textKid.Size = new System.Drawing.Size(150, 20);
            this.textKid.TabIndex = 6;
            // 
            // textKad
            // 
            this.textKad.Location = new System.Drawing.Point(205, 274);
            this.textKad.Name = "textKad";
            this.textKad.Size = new System.Drawing.Size(150, 20);
            this.textKad.TabIndex = 7;
            // 
            // textKmail
            // 
            this.textKmail.Location = new System.Drawing.Point(205, 322);
            this.textKmail.Name = "textKmail";
            this.textKmail.Size = new System.Drawing.Size(150, 20);
            this.textKmail.TabIndex = 8;
            // 
            // textKsifre
            // 
            this.textKsifre.Location = new System.Drawing.Point(205, 371);
            this.textKsifre.Name = "textKsifre";
            this.textKsifre.Size = new System.Drawing.Size(150, 20);
            this.textKsifre.TabIndex = 9;
            // 
            // textKdepartman
            // 
            this.textKdepartman.Location = new System.Drawing.Point(205, 416);
            this.textKdepartman.Name = "textKdepartman";
            this.textKdepartman.Size = new System.Drawing.Size(150, 20);
            this.textKdepartman.TabIndex = 10;
            // 
            // textKtel
            // 
            this.textKtel.Location = new System.Drawing.Point(205, 469);
            this.textKtel.Name = "textKtel";
            this.textKtel.Size = new System.Drawing.Size(150, 20);
            this.textKtel.TabIndex = 11;
            // 
            // bttnKekle
            // 
            this.bttnKekle.BackColor = System.Drawing.Color.FloralWhite;
            this.bttnKekle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKekle.Location = new System.Drawing.Point(464, 441);
            this.bttnKekle.Name = "bttnKekle";
            this.bttnKekle.Size = new System.Drawing.Size(136, 48);
            this.bttnKekle.TabIndex = 12;
            this.bttnKekle.Text = "Kullanıcıyı Kaydet";
            this.bttnKekle.UseVisualStyleBackColor = false;
            this.bttnKekle.Click += new System.EventHandler(this.bttnKekle_Click);
            // 
            // bttnKlistele
            // 
            this.bttnKlistele.BackColor = System.Drawing.Color.FloralWhite;
            this.bttnKlistele.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKlistele.Location = new System.Drawing.Point(464, 222);
            this.bttnKlistele.Name = "bttnKlistele";
            this.bttnKlistele.Size = new System.Drawing.Size(136, 48);
            this.bttnKlistele.TabIndex = 13;
            this.bttnKlistele.Text = "Kullanıcıları Listele";
            this.bttnKlistele.UseVisualStyleBackColor = false;
            this.bttnKlistele.Click += new System.EventHandler(this.bttnKlistele_Click);
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.AllowUserToDeleteRows = false;
            this.dgvKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullanicilar.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(12, 12);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(717, 192);
            this.dgvKullanicilar.TabIndex = 14;
            this.dgvKullanicilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanicilar_CellContentClick);
            // 
            // bttnKsil
            // 
            this.bttnKsil.BackColor = System.Drawing.Color.FloralWhite;
            this.bttnKsil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKsil.Location = new System.Drawing.Point(464, 294);
            this.bttnKsil.Name = "bttnKsil";
            this.bttnKsil.Size = new System.Drawing.Size(136, 48);
            this.bttnKsil.TabIndex = 15;
            this.bttnKsil.Text = "Kullanıcıyı Sil";
            this.bttnKsil.UseVisualStyleBackColor = false;
            this.bttnKsil.Click += new System.EventHandler(this.bttnKsil_Click);
            // 
            // bttnKguncelle
            // 
            this.bttnKguncelle.BackColor = System.Drawing.Color.FloralWhite;
            this.bttnKguncelle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKguncelle.Location = new System.Drawing.Point(464, 372);
            this.bttnKguncelle.Name = "bttnKguncelle";
            this.bttnKguncelle.Size = new System.Drawing.Size(136, 48);
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
            this.ClientSize = new System.Drawing.Size(741, 512);
            this.Controls.Add(this.bttnKguncelle);
            this.Controls.Add(this.bttnKsil);
            this.Controls.Add(this.dgvKullanicilar);
            this.Controls.Add(this.bttnKlistele);
            this.Controls.Add(this.bttnKekle);
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
            this.Name = "FrmKullanicilar";
            this.Text = "Kullanicilar";
            this.Load += new System.EventHandler(this.FrmKullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button bttnKekle;
        private System.Windows.Forms.Button bttnKlistele;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Button bttnKsil;
        private System.Windows.Forms.Button bttnKguncelle;
    }
}


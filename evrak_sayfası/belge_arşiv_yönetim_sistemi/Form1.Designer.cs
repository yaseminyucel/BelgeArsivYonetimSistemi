namespace belge_arşiv_yönetim_sistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.kategori = new System.Windows.Forms.ComboBox();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.evrakNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.evrakRaf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kayitEden = new System.Windows.Forms.TextBox();
            this.verileriGoster = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.evrakAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Filtre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Filtreleme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kategori
            // 
            this.kategori.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategori.ForeColor = System.Drawing.Color.Black;
            this.kategori.FormattingEnabled = true;
            this.kategori.Items.AddRange(new object[] {
            "Öğrenci Belgeleri",
            "Öğrenci Sınav Belgeleri",
            "Personel Belgeleri",
            "Muhasebe Belgeleri",
            "Öğrenci İşleri Belgeleri"});
            this.kategori.Location = new System.Drawing.Point(18, 52);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(221, 28);
            this.kategori.TabIndex = 0;
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(964, 52);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(314, 27);
            this.aciklama.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FloralWhite;
            this.btnKaydet.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.Location = new System.Drawing.Point(1294, 47);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 37);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // evrakNo
            // 
            this.evrakNo.Location = new System.Drawing.Point(265, 52);
            this.evrakNo.Name = "evrakNo";
            this.evrakNo.Size = new System.Drawing.Size(200, 27);
            this.evrakNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategoriler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Evrak Numarası";
            // 
            // evrakRaf
            // 
            this.evrakRaf.Location = new System.Drawing.Point(500, 52);
            this.evrakRaf.Name = "evrakRaf";
            this.evrakRaf.Size = new System.Drawing.Size(200, 27);
            this.evrakRaf.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bulunduğu Raf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(769, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kayıt Eden Kişi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1082, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Açıklama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(20, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1361, 433);
            this.dataGridView1.TabIndex = 15;
            // 
            // kayitEden
            // 
            this.kayitEden.Location = new System.Drawing.Point(750, 52);
            this.kayitEden.Name = "kayitEden";
            this.kayitEden.Size = new System.Drawing.Size(183, 27);
            this.kayitEden.TabIndex = 17;
            // 
            // verileriGoster
            // 
            this.verileriGoster.BackColor = System.Drawing.Color.FloralWhite;
            this.verileriGoster.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.verileriGoster.Location = new System.Drawing.Point(371, 149);
            this.verileriGoster.Name = "verileriGoster";
            this.verileriGoster.Size = new System.Drawing.Size(682, 29);
            this.verileriGoster.TabIndex = 19;
            this.verileriGoster.Text = "EVRAKLARI GÖR";
            this.verileriGoster.UseVisualStyleBackColor = false;
            this.verileriGoster.Click += new System.EventHandler(this.verileriGoster_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAra.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAra.Location = new System.Drawing.Point(217, 147);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(84, 31);
            this.btnAra.TabIndex = 20;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // evrakAra
            // 
            this.evrakAra.Location = new System.Drawing.Point(18, 150);
            this.evrakAra.Name = "evrakAra";
            this.evrakAra.Size = new System.Drawing.Size(183, 27);
            this.evrakAra.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Evrak Ara";
            // 
            // Filtre
            // 
            this.Filtre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filtre.FormattingEnabled = true;
            this.Filtre.Location = new System.Drawing.Point(1198, 117);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(133, 28);
            this.Filtre.TabIndex = 23;
            this.Filtre.SelectedIndexChanged += new System.EventHandler(this.Filtre_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1122, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Filtrele";
            // 
            // Filtreleme
            // 
            this.Filtreleme.Location = new System.Drawing.Point(1122, 151);
            this.Filtreleme.Name = "Filtreleme";
            this.Filtreleme.Size = new System.Drawing.Size(228, 27);
            this.Filtreleme.TabIndex = 25;
            this.Filtreleme.TextChanged += new System.EventHandler(this.filtreleme_TextChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1400, 650);
            this.Controls.Add(this.Filtreleme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Filtre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.evrakAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.verileriGoster);
            this.Controls.Add(this.kayitEden);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.evrakRaf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evrakNo);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.aciklama);
            this.Controls.Add(this.kategori);
            this.Name = "Form1";
            this.Text = "Belge Arşiv Yönetim Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox kategori;
        private TextBox aciklama;
        private Button btnKaydet;
        private TextBox evrakNo;
        private Label label1;
        private Label label2;
        private TextBox evrakRaf;
        private Label label5;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox kayitEden;
        private Button verileriGoster;
        private Button btnAra;
        private TextBox evrakAra;
        private Label label6;
        private ComboBox Filtre;
        private Label label7;
        private TextBox Filtreleme;
    }
}



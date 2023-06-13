
namespace Kitaplik_Proje
{
    partial class Kitaplik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplik));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKitapAd = new System.Windows.Forms.TextBox();
            this.TxtKitapYazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSayfa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbTur = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtKitapid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtKitapBul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBul = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(720, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı:";
            // 
            // TxtKitapAd
            // 
            this.TxtKitapAd.Location = new System.Drawing.Point(126, 48);
            this.TxtKitapAd.Name = "TxtKitapAd";
            this.TxtKitapAd.Size = new System.Drawing.Size(213, 30);
            this.TxtKitapAd.TabIndex = 2;
            // 
            // TxtKitapYazar
            // 
            this.TxtKitapYazar.Location = new System.Drawing.Point(125, 84);
            this.TxtKitapYazar.Name = "TxtKitapYazar";
            this.TxtKitapYazar.Size = new System.Drawing.Size(213, 30);
            this.TxtKitapYazar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar:";
            // 
            // TxtSayfa
            // 
            this.TxtSayfa.Location = new System.Drawing.Point(126, 120);
            this.TxtSayfa.Name = "TxtSayfa";
            this.TxtSayfa.Size = new System.Drawing.Size(213, 30);
            this.TxtSayfa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sayfa:";
            // 
            // CmbTur
            // 
            this.CmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTur.FormattingEnabled = true;
            this.CmbTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tiyatro"});
            this.CmbTur.Location = new System.Drawing.Point(126, 156);
            this.CmbTur.Name = "CmbTur";
            this.CmbTur.Size = new System.Drawing.Size(213, 32);
            this.CmbTur.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(128, 194);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 28);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İkinci El";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(270, 196);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 28);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pakette";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Durum:";
            // 
            // TxtKitapid
            // 
            this.TxtKitapid.Enabled = false;
            this.TxtKitapid.Location = new System.Drawing.Point(126, 12);
            this.TxtKitapid.Name = "TxtKitapid";
            this.TxtKitapid.Size = new System.Drawing.Size(213, 30);
            this.TxtKitapid.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kitap ID:";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(369, 18);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(140, 34);
            this.BtnListele.TabIndex = 14;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(369, 60);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(140, 34);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(369, 100);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(140, 34);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(369, 140);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(140, 34);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // TxtKitapBul
            // 
            this.TxtKitapBul.Location = new System.Drawing.Point(610, 134);
            this.TxtKitapBul.Name = "TxtKitapBul";
            this.TxtKitapBul.Size = new System.Drawing.Size(122, 30);
            this.TxtKitapBul.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kitap Adı:";
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(610, 170);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(60, 34);
            this.BtnBul.TabIndex = 21;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(676, 170);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(56, 34);
            this.BtnAra.TabIndex = 22;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // Kitaplik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(743, 445);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.TxtKitapBul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtKitapid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.CmbTur);
            this.Controls.Add(this.TxtSayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKitapYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKitapAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Kitaplik";
            this.Text = "Kitaplık";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKitapAd;
        private System.Windows.Forms.TextBox TxtKitapYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSayfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbTur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtKitapid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtKitapBul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.Button BtnAra;
    }
}


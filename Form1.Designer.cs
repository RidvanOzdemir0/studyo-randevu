namespace MuzikStudyoOtomasyonu
{
    partial class Form1
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
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.tvEkipmanlar = new System.Windows.Forms.TreeView();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnRandevuTamamla = new System.Windows.Forms.Button();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.cmbTarih = new System.Windows.Forms.ComboBox();
            this.rdbKart = new System.Windows.Forms.RadioButton();
            this.rdbNakit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAsistan = new System.Windows.Forms.CheckBox();
            this.clbAksesuarlar = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seçilen Ekipmanlar ve Sepet:";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(229, 21);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(317, 31);
            this.txtMusteriAdi.TabIndex = 2;
            // 
            // tvEkipmanlar
            // 
            this.tvEkipmanlar.Location = new System.Drawing.Point(92, 120);
            this.tvEkipmanlar.Name = "tvEkipmanlar";
            this.tvEkipmanlar.Size = new System.Drawing.Size(609, 515);
            this.tvEkipmanlar.TabIndex = 3;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 25;
            this.lstSepet.Location = new System.Drawing.Point(855, 120);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(559, 654);
            this.lstSepet.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(92, 641);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(609, 66);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Sepete ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnRandevuTamamla
            // 
            this.btnRandevuTamamla.Location = new System.Drawing.Point(855, 806);
            this.btnRandevuTamamla.Name = "btnRandevuTamamla";
            this.btnRandevuTamamla.Size = new System.Drawing.Size(559, 66);
            this.btnRandevuTamamla.TabIndex = 6;
            this.btnRandevuTamamla.Text = "Randevuyu Tamamla";
            this.btnRandevuTamamla.UseVisualStyleBackColor = true;
            this.btnRandevuTamamla.Click += new System.EventHandler(this.btnRandevuTamamla_Click);
            // 
            // cmbSaat
            // 
            this.cmbSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(930, 21);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(121, 33);
            this.cmbSaat.TabIndex = 7;
            // 
            // cmbTarih
            // 
            this.cmbTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarih.FormattingEnabled = true;
            this.cmbTarih.Location = new System.Drawing.Point(1197, 21);
            this.cmbTarih.Name = "cmbTarih";
            this.cmbTarih.Size = new System.Drawing.Size(163, 33);
            this.cmbTarih.TabIndex = 8;
            // 
            // rdbKart
            // 
            this.rdbKart.AutoSize = true;
            this.rdbKart.Checked = true;
            this.rdbKart.Location = new System.Drawing.Point(6, 46);
            this.rdbKart.Name = "rdbKart";
            this.rdbKart.Size = new System.Drawing.Size(143, 29);
            this.rdbKart.TabIndex = 9;
            this.rdbKart.TabStop = true;
            this.rdbKart.Text = "Kredi Kartı";
            this.rdbKart.UseVisualStyleBackColor = true;
            // 
            // rdbNakit
            // 
            this.rdbNakit.AutoSize = true;
            this.rdbNakit.Location = new System.Drawing.Point(6, 112);
            this.rdbNakit.Name = "rdbNakit";
            this.rdbNakit.Size = new System.Drawing.Size(212, 29);
            this.rdbNakit.TabIndex = 10;
            this.rdbNakit.Text = "Nakit (%5 İndirim)";
            this.rdbNakit.UseVisualStyleBackColor = true;
            this.rdbNakit.CheckedChanged += new System.EventHandler(this.rdbNakit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbKart);
            this.groupBox1.Controls.Add(this.rdbNakit);
            this.groupBox1.Location = new System.Drawing.Point(92, 713);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 175);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Yöntemi";
            // 
            // chkAsistan
            // 
            this.chkAsistan.AutoSize = true;
            this.chkAsistan.Location = new System.Drawing.Point(345, 727);
            this.chkAsistan.Name = "chkAsistan";
            this.chkAsistan.Size = new System.Drawing.Size(266, 29);
            this.chkAsistan.TabIndex = 12;
            this.chkAsistan.Text = "Kayıt Asistanı İstiyorum";
            this.chkAsistan.UseVisualStyleBackColor = true;
            this.chkAsistan.CheckedChanged += new System.EventHandler(this.chkAsistan_CheckedChanged);
            // 
            // clbAksesuarlar
            // 
            this.clbAksesuarlar.FormattingEnabled = true;
            this.clbAksesuarlar.Location = new System.Drawing.Point(345, 775);
            this.clbAksesuarlar.Name = "clbAksesuarlar";
            this.clbAksesuarlar.Size = new System.Drawing.Size(333, 116);
            this.clbAksesuarlar.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 903);
            this.Controls.Add(this.clbAksesuarlar);
            this.Controls.Add(this.chkAsistan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTarih);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.btnRandevuTamamla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.tvEkipmanlar);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.TreeView tvEkipmanlar;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnRandevuTamamla;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.ComboBox cmbTarih;
        private System.Windows.Forms.RadioButton rdbKart;
        private System.Windows.Forms.RadioButton rdbNakit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAsistan;
        private System.Windows.Forms.CheckedListBox clbAksesuarlar;
    }
}


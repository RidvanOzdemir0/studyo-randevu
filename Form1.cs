using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikStudyoOtomasyonu
{
    public partial class Form1 : Form
    {
        // Ekipmanların isimlerini ve fiyatlarını eşleştirmek için Dictionary kullanıyoruz
        Dictionary<string, double> ekipmanFiyatlari = new Dictionary<string, double>();

        // Sepete eklenen ürünleri arka planda dinamik tutmak için List kullanıyoruz
        List<string> secilenEkipmanlar = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. DİCTİONARY VE TREEVİEW (EKİPMANLAR)

            // Elektro Gitarlar
            ekipmanFiyatlari.Add("Ibanez GRX40 (1 Saat = 150 TL)", 150);
            ekipmanFiyatlari.Add("Fender Stratocaster (1 Saat = 250 TL)", 250);
            ekipmanFiyatlari.Add("Gibson Les Paul (1 Saat = 300 TL)", 300);

            // Bas Gitarlar
            ekipmanFiyatlari.Add("Yamaha TRBX304 Bas Gitar (1 Saat = 200 TL)", 200);
            ekipmanFiyatlari.Add("Fender Precision Bass (1 Saat = 250 TL)", 250);
            ekipmanFiyatlari.Add("Ibanez SR300E Bas Gitar (1 Saat = 180 TL)", 180);

            // Bateriler
            ekipmanFiyatlari.Add("Pearl Export Bateri Seti (1 Saat = 350 TL)", 350);
            ekipmanFiyatlari.Add("Tama Imperialstar Bateri Seti (1 Saat = 400 TL)", 400);
            ekipmanFiyatlari.Add("Roland Elektronik Bateri (1 Saat = 300 TL)", 300);

            // Amfiler
            ekipmanFiyatlari.Add("Marshall MG15GFX Amfi (1 Saat = 120 TL)", 120);
            ekipmanFiyatlari.Add("Boss Katana 50 MkII Amfi (1 Saat = 150 TL)", 150);
            ekipmanFiyatlari.Add("Fender Champion 100 Amfi (1 Saat = 180 TL)", 180);

            // Kayıt ve Ses Ekipmanları
            ekipmanFiyatlari.Add("Focusrite Scarlett 2i2 Ses Kartı (1 Saat = 100 TL)", 100);
            ekipmanFiyatlari.Add("Universal Audio Apollo Ses Kartı (1 Saat = 250 TL)", 250);
            ekipmanFiyatlari.Add("Rode NT1-A Stüdyo Mikrofonu (1 Saat = 150 TL)", 150);
            ekipmanFiyatlari.Add("Shure SM58 Vokal Mikrofonu (1 Saat = 100 TL)", 100);

            TreeNode anaDugum1 = new TreeNode("Elektro Gitarlar");
            anaDugum1.Nodes.Add("Ibanez GRX40 (1 Saat = 150 TL)");
            anaDugum1.Nodes.Add("Fender Stratocaster (1 Saat = 250 TL)");
            anaDugum1.Nodes.Add("Gibson Les Paul (1 Saat = 300 TL)");

            TreeNode anaDugum2 = new TreeNode("Bas Gitarlar");
            anaDugum2.Nodes.Add("Yamaha TRBX304 Bas Gitar (1 Saat = 200 TL)");
            anaDugum2.Nodes.Add("Fender Precision Bass (1 Saat = 250 TL)");
            anaDugum2.Nodes.Add("Ibanez SR300E Bas Gitar (1 Saat = 180 TL)");

            TreeNode anaDugum3 = new TreeNode("Bateri Setleri");
            anaDugum3.Nodes.Add("Pearl Export Bateri Seti (1 Saat = 350 TL)");
            anaDugum3.Nodes.Add("Tama Imperialstar Bateri Seti (1 Saat = 400 TL)");
            anaDugum3.Nodes.Add("Roland Elektronik Bateri (1 Saat = 300 TL)");

            TreeNode anaDugum4 = new TreeNode("Amfiler");
            anaDugum4.Nodes.Add("Marshall MG15GFX Amfi (1 Saat = 120 TL)");
            anaDugum4.Nodes.Add("Boss Katana 50 MkII Amfi (1 Saat = 150 TL)");
            anaDugum4.Nodes.Add("Fender Champion 100 Amfi (1 Saat = 180 TL)");

            tvEkipmanlar.Nodes.Add(anaDugum1);
            tvEkipmanlar.Nodes.Add(anaDugum2);
            tvEkipmanlar.Nodes.Add(anaDugum3);
            tvEkipmanlar.Nodes.Add(anaDugum4);

            tvEkipmanlar.ExpandAll();

            // 2. TAKVİM (TARİH) DÖNGÜSÜ
            for (int i = 0; i < 14; i++)
            {
                DateTime eklenecekGun = DateTime.Now.AddDays(i);
                cmbTarih.Items.Add(eklenecekGun.ToString("dd.MM.yyyy"));
            }
            cmbTarih.SelectedIndex = 0;

            // 3. SAAT DÖNGÜSÜ
            for (int j = 10; j <= 22; j++)
            {
                cmbSaat.Items.Add(j.ToString() + ":00");
            }
            cmbSaat.SelectedIndex = 0;

            // 4. CHECKEDLISTBOX (EKSTRA AKSESUARLAR) DOLDURMA
            clbAksesuarlar.Items.Add("Ekstra Monitör Kulaklık");
            clbAksesuarlar.Items.Add("Yedek Jak Kablosu");
            clbAksesuarlar.Items.Add("Nota Sehpası");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Try-Catch mekanizması ile olası hataları yakalıyoruz
            try
            {
                // Eğer TreeView'den hiçbir şey seçilmediyse veya sadece ana kategori seçildiyse
                if (tvEkipmanlar.SelectedNode == null || tvEkipmanlar.SelectedNode.Level == 0)
                {
                    // Kendi hatamızı yazdırıyoruz
                    throw new Exception("Lütfen ağaç yapısından geçerli bir enstrüman veya cihaz seçin!");
                }

                string secilenUrun = tvEkipmanlar.SelectedNode.Text;

                // Seçilen ürün listede zaten var mı kontrol ediyoruz
                if (secilenEkipmanlar.Contains(secilenUrun))
                {
                    MessageBox.Show("Bu ekipman zaten sepetinizde ekli.");
                }
                else
                {
                    // List koleksiyonumuza ekliyoruz
                    secilenEkipmanlar.Add(secilenUrun);
                    // Ekrandaki ListBox'a ekliyoruz
                    lstSepet.Items.Add(secilenUrun);
                }
            }
            catch (Exception ex)
            {
                // Bir hata oluşursa kullanıcıya gösteriyoruz
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }

        private void btnRandevuTamamla_Click(object sender, EventArgs e)
        {
            try
            {
                string musteriAdi = txtMusteriAdi.Text.Trim();

                if (string.IsNullOrEmpty(musteriAdi))
                {
                    throw new Exception("Randevu oluşturabilmek için Müşteri Adı alanını doldurmalısınız!");
                }

                musteriAdi = musteriAdi.ToUpper();
                string secilenTarih = cmbTarih.SelectedItem.ToString();
                string secilenSaat = cmbSaat.SelectedItem.ToString();

                double toplamTutar = 0;

                // 1. Sadece seçilen ana ekipmanların fiyatını hesaplıyoruz
                foreach (string urun in secilenEkipmanlar)
                {
                    if (ekipmanFiyatlari.ContainsKey(urun))
                    {
                        toplamTutar += ekipmanFiyatlari[urun];
                    }
                }

                // CheckBox Kontrolü
                string asistanDurumu = "İstenmedi";
                if (chkAsistan.Checked)
                {
                    asistanDurumu = "İstendi";
                }

                // CheckedListBox Kontrolü
                string secilenAksesuarlar = "";
                foreach (var aksesuar in clbAksesuarlar.CheckedItems)
                {
                    // Sadece seçilenlerin ismini alıp arasına virgül koyarak mesaja ekliyoruz
                    secilenAksesuarlar += aksesuar.ToString() + ", ";

                }

                if (secilenAksesuarlar == "") secilenAksesuarlar = "Yok";

                // 3. Ödeme Yöntemi ve İndirim
                string odemeYontemi = "";
                if (rdbNakit.Checked)
                {
                    odemeYontemi = "Nakit (%5 İndirim Uygulandı)";
                    double indirimMiktari = toplamTutar * 0.05;
                    toplamTutar -= indirimMiktari;
                }
                else if (rdbKart.Checked)
                {
                    odemeYontemi = "Kredi Kartı";
                }

                // 4. Özet Mesajı
                string ozetMesaj = $"Sayın {musteriAdi},\n" +
                                   $"Randevunuz {secilenTarih} tarihinde, saat {secilenSaat} için kaydedildi.\n\n" +
                                   $"Asistan: {asistanDurumu}\n" +
                                   $"Aksesuarlar: {secilenAksesuarlar}\n" +
                                   $"Ödeme Yöntemi: {odemeYontemi}\n" +
                                   $"TOPLAM TUTAR: {toplamTutar} TL";

                MessageBox.Show(ozetMesaj, "Randevu Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Başarısız: " + ex.Message);
            }
        }

        private void rdbNakit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAsistan_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

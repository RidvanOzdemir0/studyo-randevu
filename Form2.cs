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
    public partial class Form2 : Form
    {
        string kayitliSifre = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            try
            {
                string girilenYeniSifre = txtYeniSifre.Text.Trim();

                // Kutuyu boş bırakıp butona basarsa hata mesajı çıkar
                if (string.IsNullOrEmpty(girilenYeniSifre))
                {
                    throw new Exception("Şifre oluşturmak için lütfen bir değer girin!");
                }

                // Girilen şifreyi en üstteki değişkene atıyoruz (Kaydediyoruz)
                kayitliSifre = girilenYeniSifre;

                MessageBox.Show("Üyeliğiniz başarıyla oluşturuldu! Şimdi diğer taraftan giriş yapabilirsiniz.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Güvenlik için kayıt olunan kutunun içini temizliyoruz
                txtYeniSifre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uyarı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGirisSifre_Click(object sender, EventArgs e)
        {
            try
            {
                string girilenGirisSifresi = txtGirisSifre.Text.Trim();

                // Kullanıcı henüz hiç üye olmamışsa (Şifre değişkeni boşsa)
                if (kayitliSifre == "")
                {
                    throw new Exception("Sistemde henüz kayıtlı bir şifreniz yok. Lütfen önce 'Üye Ol' panelinden bir şifre oluşturun!");
                }

                // Giriş kutusunu boş bırakmışsa
                if (string.IsNullOrEmpty(girilenGirisSifresi))
                {
                    throw new Exception("Giriş yapabilmek için şifrenizi girmelisiniz!");
                }

                // Yazdığı şifre ile bizim kaydettiğimiz şifre uyuşuyor mu kontrol
                if (girilenGirisSifresi == kayitliSifre)
                {
                    MessageBox.Show("Giriş Başarılı! Stüdyo sistemine yönlendiriliyorsunuz.", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Formlar Arası Geçiş
                    Form1 anaStudyoFormu = new Form1();
                    anaStudyoFormu.Show();
                    this.Hide();
                }
                else
                {
                    // Şifre yanlışsa kendi özel hatamızı yazdırıyoruz
                    throw new Exception("Şifre hatalı! Lütfen doğru şifreyi girdiğinizden emin olun.");
                }
            }
            catch (Exception ex)
            {
                // Yakalanan hataları ekranda gösteriyoruz
                MessageBox.Show("Giriş Başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtGirisSifre_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

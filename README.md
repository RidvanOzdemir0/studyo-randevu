1. Uygulamanın Amacı: kullanıcıların müzik stüdyosu ekipmanlarını kiralayarak randevu oluşturabilecekleri, basit bir kayıt/giriş paneline
ve dinamik bir sepet sistemine sahip masaüstü otomasyon uygulaması geliştirmektir. Proje, müşterilerin ihtiyaç duydukları enstrüman ve
cihazları (elektro gitar, amfi, bateri, ses kartı vb.) seçmelerini, takvim üzerinden tarih/saat belirlemelerini ve asistan/aksesuar gibi ek
taleplerle birlikte ödeme yöntemini (nakit indirimli veya kart) seçerek toplam tutarın otomatik hesaplanmasını hedeflemektedir.

2. Çalışma Mantığı ve Kullanılan Teknolojiler: Uygulama, C# programlama dili ve masaüstü arayüz geliştirme platformu olan Windows Forms
(WinForms) kullanılarak tasarlanmıştır. Formlar arası veri aktarımı ve istemci taraflı iş mantığı şu mimariyle kurgulanmıştır:
Koleksiyon Yapıları (Collections): Ekipman isimleri ve fiyatlarını bellekte eşleştirmek için anahtar-değer (key-value) mantığıyla çalışan
Dictionary, kullanıcının seçtiği ürünleri dinamik bir sepette tutmak için ise List sınıfları kullanılmıştır.
Gelişmiş Form Kontrolleri: Ürünleri kategorik bir ağaç yapısında sunmak için TreeView, tarih ve saatleri döngülerle (for loop) dinamik
olarak listelemek için ComboBox, çoklu aksesuar seçimi için CheckedListBox ve tekil seçim gerektiren ödeme yöntemleri için RadioButton
araçları entegre edilmiştir.
Hata Yönetimi ve Güvenlik: İki farklı form (Kayıt/Giriş ve Ana Kiralama Ekranı) arasında geçiş sağlanırken, kullanıcıların boş alan
bırakması veya hatalı seçim yapması gibi istisnai durumlar Try-Catch mekanizmalarıyla yakalanarak uygulamanın çökmesi engellenmiş ve özel
uyarı mesajları (MessageBox) oluşturulmuştur.


<img width="563" height="401" alt="Ekran Resmi 2026-10-05 15 55 01" src="https://github.com/user-attachments/assets/9b7dae3c-65f0-4be3-b147-cb3746d2ab31" />


<img width="734" height="495" alt="Ekran Resmi 2026-10-05 15 55 59" src="https://github.com/user-attachments/assets/a72b61f1-1658-4b21-97ce-c10a0acea148" />


<img width="730" height="494" alt="Ekran Resmi 2026-10-05 15 56 12" src="https://github.com/user-attachments/assets/0df32f3b-c841-4a9d-ac75-9bec391e1228" />

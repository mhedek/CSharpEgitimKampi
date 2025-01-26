## 📍 Uygulama 1: Merhaba Kelime!
  Temel yazdırma komutları ve 'Console.WriteLine' ve ilk "Merhaba Dünya!"   Mesaj yazmayı öğrendim.   👋

  ---

  ## 📍 Uygulama 2: Değişkenler ve Veri Türleri

  Bu uygulamada string, int, double gibi veri türlerinin kullanım alanlarını ve kullanım şekillerini anladım.✨  

  ---


  ## 📍 Uygulama 3: Koşullu İfadeler (If-Else)

  If, else if, else, Switch Case, Break yapılarıyla karar verme süreçlerini öğrendim.   Programların belirli koşullara bağlı olarak farklı yollar izlemesini sağlayabilirim!   🌟

  ---

  ## 📍 Uygulama 4: Döngüler

  For ve while ile tekrarlanan işlemleri nerede ve nasıl kullanabileceğim hakkında bilgi sahibi oldum.🔄

  ---

  ## 📍 5. Uygulama: Döngülerle Şekiller Oluşturma

  Bu projemizde ilmekleri kullanarak yıldızlarla şekiller oluşturmayı öğrendik.   Yıldız uygulaması algoritma mantığı için güzel bir başlangıç ​​oldu.🎓

  ---

  ## 📍 Uygulama 6: Diziler

  Dizilerin nasıl kullanılacağını öğrenerek aynı veri türünden birden fazla veriyi nasıl depolayabileceğimizi keşfettim.   Verileri toplu olarak yönetmek işleri kolaylaştıracak.🔢

  ---

  ## 📍 Uygulama 7: Foreach Döngüsü

  Dizileri öğrendikten sonra daha iyi anlaşılacak olan foreach döngüsü, dizi ve dizi elemanlarını yazdırmak için tercih ettiğim yöntem haline geldi.🔄

  ---

  ## 📍 Uygulama 8: Yöntemler

  Yöntem döndürenler ve yöntem döndürmeyenler olmak üzere iki grupta inceledik.   Functions'ı kullanarak yöntemlere işlevsellik ekledim.   🧩

  ---

 ## 📍Tur Projesini: Entity Framework ile Konum İşlemleri CSharpEgitimKampi301.EFProject Klasörü ile inceleyebilirsiniz.

✔️ Projede yer alan FrmStatistics formu bir tur projesi için geliştirilmiş istatistik uygulamasıdır.  Veritabanından çıkarılan bilgiler Linq sorguları kullanılarak görselleştirildi.

➡️ Projede Form uygulaması için C# Winform uygulaması
➡️ Veritabanı işlemleri için Entity Framework ve Linq Sorgular
➡️ Verilerin saklanması için SQL Server kullanılmıştır.

✔️ Projede kullanılan bazı Entity Framework Metotları ve Linq Sorguları ile ilgili kısa bilgilendirme ve açıklamalar
  • lblLocationCount.Text = db.Location.Count().ToString() ➙➙ db.Location tablosundaki tüm kayıtları sayar. Count() metodu, satır sayısını döner. Veritabanında kayıtlı olan toplam lokasyon sayısını bulur.

  • lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString() ➙➙ Sum(x => x.Capacity) fonksiyonu, Capacity sütunundaki değerleri toplar. Tüm lokasyonların kapasite değerlerini toplayarak toplam kapasiteyi hesaplar

  • lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString() ➙➙ Average(x => x.Capacity) fonksiyonu, tüm kapasite değerlerinin aritmetik ortalamasını döner. Tüm lokasyonların ortalama kapasitesini hesaplar

  • lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).ToString("0.00") + " ₺" ➙➙ Average(x => x.Price) fonksiyonu, fiyatların ortalamasını hesaplar. Tüm turların ortalama fiyatını hesaplar.

  •int lastCountryId = db.Location.Max(x => x.LocationId); 
    lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault() ➙➙ En son eklenen ülkeyi bulmayı hesaplar. 
   ➙➙ Max(x => x.LocationId) ifadesi, en yüksek LocationId değerini (son eklenen kayıt) döner.
   ➙➙ Where filtresi, bu LocationId'ye sahip kaydı bulur.
   ➙➙ Select(y => y.Country) ile sadece ülke adını seçer.
   ➙➙ FirstOrDefault() ise sonucu döner.
   

                                                ✨✨ KAYNAK kOD VE ÇIKTILAR ✨✨   
![Ekran görüntüsü 2024-12-01 212145](https://github.com/user-attachments/assets/0247f8f8-3e36-43f9-b808-f984c288b8bd)
![Ekran görüntüsü 2024-12-01 212237](https://github.com/user-attachments/assets/02522a85-ffd1-41ce-8fba-a9a86baf3732)


  ---

 ## 📍C# ile MongoDB Kullanımı
 C# ile MongoDb kullanımını başlangıç düzeyi ile ele aldık. Ekleme,silme,güncelleme gibi Crud işlemlerini basit düzeyde öğrenmiş olduk. Aşağıda bulunan kod dizimi MongoDb ile database oluşturma ve bu database tablo ekleyip tabloyu isimlendirdiğimiz örnek bulunmaktadır.
 
![Ekran görüntüsü 2025-01-26 143350](https://github.com/user-attachments/assets/b4195908-bd7d-44f7-ace2-ad1e72306df9)

  ---

 ## 📍C# ile PostgreSQL Kullanımı
 PostgreSQL güçlü, esnek ve güvenli bir veritabanı yönetim sistemidir, büyük projelerden küçük uygulamalara kadar her boyutta kullanımı mümkündür. Tercih edilmesindeki en büyyük neden açık kaynak kodlu olmasıddır. MySql ile benzerlikleri açık kaynaklı ilişkisel veritabanı yönetim sistemleridir ve SQL dilini kullanır. Her ikisi de yüksek performans ve güvenilirlik sunar.  

  ---

 ## 📍C# Final Projesi (FİNANSAL CRM UYGULAMASI)
 Bu projemizde Entity Framework kullanarak gelir, gider, banka hareketleri, banklar ve login işlemlerinin bulunduğu orta seviye bir uygulama geliştirdik. Banks, BankaProcesses, Bills, Category, Spendings, User gibi tablolar oluşturduk ve ilişkileri kurduk.

 ✔️ Projede oluşturulan bazı tablolar, form ve kodların örneklerini aşağıda görebilirsiniz.

 ➡️Proje başlatılınca ilk çalışacak form Login formudur. Girilen kullanıcı bilgilerinin doğruluğunu kontrol edip giriş yaptılırı. Dasa sonra Dashboard formuna geçiş yapılır

 ![Login paneli](https://github.com/user-attachments/assets/723ba1a1-e24d-43e1-9d3e-6b2ea2e1f2af)

  ➡️Dashboard, genel bakış formu, toplam bakiye, toplam harcama yani giderler ve son havalelerin istatistiklerinin bulunduğu form oluşturdum. Grafik(chart) kullanarak formumuzu zenginleştirdim.Faturaların adı ve tutuarları için timer kullanarak tel label ile hepsini listelemeyi başardık.Sol kısımda bulunan butonlar ile geçmek istediğiniz formun butonuna tıklayabilirsiniz. Kaynak kod ve formun çıktını inceleyebilirsiniz. 

![Ekran görüntüsü 2025-01-26 154945](https://github.com/user-attachments/assets/668fe0d3-20e0-4c29-b049-9e7c9d90694e)

![Ekran görüntüsü 2025-01-26 155134](https://github.com/user-attachments/assets/39466849-c320-4b13-8ac3-4ff17e2ba1aa)

![Ekran görüntüsü 2025-01-26 155208](https://github.com/user-attachments/assets/541bfa20-26cc-43c4-8d3a-6596e08fafff)

  ➡️Ödeme ve Fatura formunda ödemeleri listedik, ödeme ekledik, ödeme sildik, ödeme güncelleme işlemleri yaptık ve bunları datagrid ile listeledik.
  
![Ekran görüntüsü 2025-01-26 155554](https://github.com/user-attachments/assets/f638fbf9-c1ba-49ad-a3ad-3a705ca59519)

![Ekran görüntüsü 2025-01-26 155645](https://github.com/user-attachments/assets/328bb982-9808-41a4-92c1-8d48045ed155)

  ➡️Banka formu ile banka hesaplarımızı ve limitlerini ayrıca son beş banka hareketini görebileceğimiz form oluşturduk.

![Ekran görüntüsü 2025-01-26 155949](https://github.com/user-attachments/assets/a17e1515-c2bd-4c11-b94e-c06ad2be6601)

![Ekran görüntüsü 2025-01-26 155914](https://github.com/user-attachments/assets/aeca4f24-2e97-4588-b0d8-bdd7a36e8ce4)


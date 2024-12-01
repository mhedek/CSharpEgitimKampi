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

                                                
  C# eğitim kampı boyunca ilerlememi buraya eklemeye devam edeceğim.   🌱🌱

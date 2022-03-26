# Nesne Tabanlı Programlama Örnek Çalışma

5 Katmanlı nesne tabanlı programlamaya örnek bir çalışma. Üniversite dönemi katmanları daha iyi bir şekilde anlamak için geliştirmiş olduğum bir projeydi. Veri tabanı 
yedek dosyası mevcuttur. 

Uygulamanın tam hali için;

 ## Benimle İletişime Geç


&nbsp;&nbsp;
[![website](./img/linkedin-light.svg)](https://www.linkedin.com/in/oguzhansadikoglu/#gh-light-mode-only)
[![website](./img/linkedin-dark.svg)](https://www.linkedin.com/in/oguzhansadikoglu/#gh-dark-mode-only)
&nbsp;&nbsp;
[![website](./img/instagram-light.svg)](https://www.instagram.com/ouz.spy#gh-light-mode-only)
[![website](./img/instagram-dark.svg)](https://www.instagram.com/ouz.spy#gh-dark-mode-only)

### Nesne Tabanlı Programlama Almış Olduğum Notlar

- Daha düzenli kod yazmak
- İstediğimiz kod bloklarına daha hızlı erişim
- Kod tekrarını önlemek!! - En önemlisi
- Sınıf : Bizim şablonumuz çatımız iskeletimiz
- Nesne : O sınıfın içerisinde bulunan özelliklere ulaşabilmemiz için elçi araç vb vb
- Apartman bizim sınıfımız
- Daireler bizim nesnemiz 
- Dairenin özellikleri de nesnenin özellikleri


#### Katmanlı Mimari 
 Büyük ölçekli projelerde kodları bloklara ayırmak, kodlara erişimi kolaylaştırmak, kod tekrarını azaltmak

#### Veri Tabanı Katmanı

Sql tabanında hazırlanacak

- Prosedür
- Trigger
- İlişkili tablo
- Alt sorgu

#### Varlık Katmanı 
Tablo alanlarımızı değişkenlere atayıp bunları da propertiler aracılığıyla erişime açtık, public hale getirdik erişimleri açıldı.
( Entity )

#### Facade(Cephe, Dış Görünüş) 

Ekleme güncelleme listelenme kodlarının yazıldığı alan !!!! Data Accses Layer DALL Katmanı 

#### İş Mantık ( Business Logic Layer ) ( Süzgeç )

Veriler eklenmeden silinmeden güncellenmeden vb vb bizim istediğimiz formatta yapılması bu işlemlerin. 
Örneğin, Öğrencinin sınav notu 0 ila 100 arasında olsun. 0 dan küçük olmasın 100den büyük olmasın vb vb gibi koşulları işlediğimiz alan.
Programın buglarını açıklarını kapattığımız alan.
Veri katmanı ile ( Facade ) Sunum katmanı arasında bir köprü görevi gören katman !!! ÖNEMLİDİR


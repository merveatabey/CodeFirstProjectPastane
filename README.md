# Pastane Yönetim Sistemi

Bu proje, **Code First** yaklaşımı kullanılarak geliştirilmiş ASP.NET tabanlı bir web uygulamasıdır. Bir pastanenin günlük yönetim işlerini kolaylaştırmak ve raporlama süreçlerini dinamik hale getirmek amacıyla hazırlanmıştır.



![Ekran Kaydı 2025-06-30 20 39 16](https://github.com/user-attachments/assets/779a23eb-e7dc-476e-9fd7-8dca5a5103f8)


![Ekran Kaydı 2025-06-30 20 39 16](https://github.com/user-attachments/assets/0f645c2d-4e44-4713-b661-a01011058e0b)


![Ekran Kaydı 2025-06-30 20 39 16](https://github.com/user-attachments/assets/e0107d67-0ed9-48a5-9fde-ac2296b2fc14)


![Ekran Kaydı 2025-06-30 20 48 11](https://github.com/user-attachments/assets/7965db6f-993a-4081-9346-79ba02b9f028)




---

##  Özellikler

-  **CRUD İşlemleri**: Ürünler, siparişler, müşteriler ve personeller üzerinde oluşturma, okuma, güncelleme ve silme.
-  **Dashboard ve Raporlar**: SQL sorguları ile dinamik raporlar oluşturulur. Rapor verileri modern JavaScript’in **`fetch` API** kullanılarak sayfa yenilenmeden asenkron olarak güncellenir.
-  **Join İşlemleri**: Veritabanındaki tablolar arasında ilişkisel join sorguları ile karmaşık veri çekme işlemleri.
-  **Code First Yaklaşımı**: Entity Framework Code First ile veritabanı modelleri oluşturulmuş, migrasyonlar ile veritabanı yönetilmiştir.
-  **Performanslı ve Kullanıcı Dostu**: AJAX (fetch) ile hızlı veri aktarımı, kullanıcı deneyimini arttırır.

---

##  Kullanılan Teknolojiler

- ASP.NET MVC / ASP.NET Core (proje tipine göre)
- Entity Framework (Code First)
- SQL Server
- JavaScript (ES6+) — `fetch` API
- HTML5, CSS3
- Visual Studio

---

##  Proje Yapısı
/Controllers # İş mantığı ve API endpointleri
/Models # Veri modelleri (Entity Framework)
/Views # Razor veya ilgili view dosyaları
/Migrations # EF Code First migrasyonları
/wwwroot # Statik dosyalar (CSS, JS, resimler)


## Kurulum & Çalıştırma

1. Repoyu klonlayın:

```bash
git clone https://github.com/merveatabey/CodeFirstProjectPastane.git


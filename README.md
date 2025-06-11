# DataBaseUI
# Fatura Takip ve İşleme Sistemi

Bu Windows Forms uygulaması, temel bir fatura giriş ve takip sistemi sağlar. Kullanıcı, adım adım:
- Yeni bir fatura (irsaliyeli fatura) oluşturabilir,
- Bu faturaya bağlı ürünleri ekleyebilir,
- İlgili taşıma irsaliyesi detaylarını tamamlayabilir.

## Özellikler

- **Adım adım veri girişi**: Fatura, ürün ve taşıma kayıtları ayrı panellerde girilir.
- **Geçici ürün listesi**: Ürünler kaydedilmeden önce tabloda gösterilir, hesaplanan tutar anlık güncellenir.
- **Veritabanı bağlantısı**: SQL Server ile çalışan sistem, `Fatura_Urunleri`, `Irsaliyeli_Fatura` ve `Tasima_Irsaliyesi` tablolarına kayıt yapar.
- **Fatura numarası otomatik artar**: Son `FaturaNo`'ya göre bir sonrakini sistem kendisi üretir (`F001`, `F002`, ...).
- **Dikey ürün görünümü**: Ürün listesi kullanıcı dostu, transpozlanmış (dikey) şekilde görüntülenir.

## Teknolojiler

- C# / Windows Forms
- .NET Framework
- SQL Server
- ADO.NET (manuel sorgular, `SqlConnection`, `SqlCommand`)

## Kullanım

1. Uygulama başlatıldığında `Fatura Oluştur` paneli ile başlanır.
2. Ürün bilgileri girilir ve geçici olarak listelenir.
3. Taşıma bilgileri tamamlandıktan sonra `Faturayı Kaydet` ile işlem tek seferde veritabanına aktarılır.

## Notlar

- `Tutar` kolonu, veritabanında otomatik (`computed`) olarak hesaplanır.
- Uygulama kendi içinde sade, doğrudan ve işlev odaklıdır.
- Geliştirmeye açık: arama, raporlama, kullanıcı yönetimi gibi modüller kolayca entegre edilebilir.

---

Her şey yerli yerinde. Gereksiz parlaklık yok, ama yaptığı işi iyi yapan bir uygulama.  

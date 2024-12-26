# Trendyol OOP Yönetim Form Projesi

## Projenin Amacı

Bu proje, nesne yönelimli programlama (OOP) prensiplerini kullanarak temel bir yönetim uygulaması oluşturmayı amaçlar. Trendyol'un temel yapısından esinlenerek geliştirilen bu proje, CRUD (Create, Read, Update, Delete - Oluşturma, Okuma, Güncelleme, Silme) işlemlerini destekleyerek veri yönetimi için bir temel sağlar.

## Projenin Kapsamı
roje, aşağıdaki temel bileşenleri içerir:

*   **ITRENDYOL Arayüzü (Interface):** Veri yönetimi operasyonları için bir arayüz (sözleşme) tanımlar. Bu arayüz, farklı veri kaynakları (örneğin, liste, veritabanı) veya farklı uygulamalar arasında tutarlılık sağlar. `Ekleme`, `Listeleme`, `Güncelle`, `Silme` gibi metotları içerir.
*   **Ürünler Sınıfı (Class):** Yönetilecek verileri temsil eden bir sınıftır. Bu örnekte "Ürünler" olarak adlandırılmıştır, ancak proje farklı veri türlerini yönetmek için uyarlanabilir. Bu sınıf, ürün bilgilerini saklamak için aşağıdaki özelliklere (property) sahiptir:

    *   **ID (int):** Ürünün benzersiz kimlik numarası.
    *   **ÜrünAdı (string):** Ürünün adı veya tanımı.
    *   **Fiyat (İNT):** Ürünün fiyatı. İNT para birimi gibi  TAM sayılar için daha uygundur.
    *   **Beden (string):** Ürünün bedeni (örneğin, S, M, L, XL veya 36, 38, 40).

    *   *   **TRENDYOL Sınıfı (Class):** `ITRENDYOL` arayüzünü uygular ve gerçek veri yönetimi işlemlerini gerçekleştirir. Bir `List<Ürünler>` koleksiyonu kullanarak verileri bellekte saklar. CRUD işlemlerinin mantığı bu sınıfta bulunur.
*   **Windows Forms Arayüzü:** Kullanıcı arayüzünü sağlar ve kullanıcıların verilerle etkileşim kurmasını mümkün kılar. Form üzerinde butonlar, metin kutuları, listeler vb. kontroller bulunur.

Proje, temel CRUD işlemlerini aşağıdaki gibi destekler:

*   **Ekleme (Create):** Yeni ürün bilgilerini sisteme ekler.
*   **Listeleme (Read):** Sistemdeki tüm ürünlerin listesini görüntüler.
*   **Güncelleme (Update):** Mevcut ürün bilgilerini düzenler.
*   **Silme (Delete):** Sistemden ürün kaydını siler.

## Kullanılan Teknolojiler

*   C#
*   .NET Framework veya .NET (projenin hedef çerçevesine göre)
*   Windows Forms
*   Nesne Yönelimli Programlama (OOP)

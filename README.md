# 🗓️ BusinessScheduler | İş Randevu Planlama Sistemi

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4.svg)](https://dotnet.microsoft.com/)
[![Blazor](https://img.shields.io/badge/Blazor-WebAssembly-5C2D91.svg)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![REST API](https://img.shields.io/badge/REST-API-FF6C37.svg)](https://restfulapi.net/)
[![EF Core](https://img.shields.io/badge/EF_Core-8.0-512BD4.svg)](https://learn.microsoft.com/en-us/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL_Server-2019+-CC2927.svg)](https://www.microsoft.com/en-us/sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

> 🇹🇷 **Türkçe** | 🇬🇧 **English** | 🧩 **Blazor WASM** | ⚙️ **REST API** | 🗄️ **SQL Server**

---

## 🇹🇷 Türkçe

### Proje Özeti

**BusinessScheduler**, modern işletmelerin randevu ve takvim yönetim ihtiyaçlarını karşılamak için geliştirilmiş, **çift dilli (Türkçe/İngilizce)** bir randevu planlama sistemidir.

**Mimari:** ASP.NET Core Web API (backend) + Blazor WebAssembly (frontend) + Entity Framework Core (ORM) + SQL Server (veritabanı). Clean Architecture prensipleriyle tasarlanmış, production-ready bir çözümdür.

### Kullanım Senaryoları

*   💈 **Hizmet İşletmeleri:** Kuaför, berber, dişçi, güzellik merkezi randevuları
*   🧑‍💼 **Danışmanlık:** Müşteri randevu takibi ve yönetimi
*   🏫 **Eğitim Kurumları:** Öğretmen-öğrenci görüşme planlaması
*   🏥 **Sağlık Kuruluşları:** Hasta randevu sistemi
*   📅 **Genel Kullanım:** Her türlü hizmet sektörü için çevrimiçi rezervasyon

### Kullanılan Teknolojiler

| Bileşen | Teknoloji | Amaç |
| :--- | :--- | :--- |
| **Framework** | .NET 8 | Ana framework |
| **Frontend** | Blazor WebAssembly | SPA (Single Page Application), C# ile tarayıcıda çalışır |
| **Backend API** | ASP.NET Core 8 | RESTful API servisleri |
| **ORM** | Entity Framework Core 8 | Veritabanı işlemleri (Code-First) |
| **Veritabanı** | SQL Server 2019+ | Veri kalıcılığı |
| **Test** | xUnit 2.5+ | Birim testleri |
| **Yerelleştirme**| .RESX | Çift dilli UI desteği |

### Proje Yapısı

    BusinessScheduler/
    │   .gitignore
    │   BusinessScheduler.sln
    │   LICENSE
    │   README.md
    │
    ├───src/
    │   ├───Api/                          # Backend: ASP.NET Core Web API
    │   │   ├───Controllers/              # API endpoint'leri
    │   │   ├───Data/                     # DbContext ve Migration dosyaları
    │   │   ├───Models/                   # Entity modelleri (veritabanı)
    │   │   ├───Services/                 # İş mantığı servisleri (Dependency Injection ile)
    │   │   └───Properties/               # launchSettings.json (ortam ayarları)
    │   │
    │   └───Client/                       # Frontend: Blazor WebAssembly
    │       ├───Layout/                   # Ana layout (NavMenu, MainLayout)
    │       ├───Pages/                    # Uygulama sayfaları (Index, Appointment, etc.)
    │       ├───Resources/                # Yerelleştirme (.resx) dosyaları (TR/EN)
    │       └───wwwroot/                  # Statik dosyalar (CSS, JS, icons)
    │
    └───tests/
        └───Api.Tests/                    # xUnit test projesi
                AppointmentTests.cs
                UnitTest1.cs

### Özellikler

| Özellik | Açıklama |
| :--- | :--- |
| ✅ **Çift Dilli Arayüz (TR/EN)** | Tüm UI ve bildirimler, çalışma anında dil değiştirebilir |
| ✅ **Randevu Yönetimi** | CRUD işlemleri, tarih/saat bazlı filtreleme ve arama |
| ✅ **Müsaitlik Kontrolü** | Çakışan randevuları otomatik engelleme, dinamik zaman dilimi yönetimi |
| ✅ **Servis Yönetimi** | Hizmet bazlı randevu süresi ve ücret tanımlama |
| ✅ **Müşteri Yönetimi** | Müşteri kaydı, randevu geçmişi ve iletişim bilgileri |
| ✅ **Randevu Hatırlatma** | E-posta ile otomatik hatırlatma (arkaplan servisi) |
| ✅ **Takvim Görünümü** | Haftalık/aylık takvim ile randevu takibi |
| ✅ **Excel/PDF Raporlama** | Randevu istatistikleri ve müşteri raporları |

### Hızlı Başlangıç

#### 1. Projeyi Klonla

    git clone https://github.com/omertarikbayir/BusinessScheduler.git
    cd BusinessScheduler

#### 2. Bağımlılıkları Yükle ve Derle

    dotnet restore
    dotnet build BusinessScheduler.sln -c Release

#### 3. Connection String'i Güncelle

`src/Api/appsettings.json` dosyasını düzenleyin:

    {
      "ConnectionStrings": {
        "Default": "Server=(localdb)\\mssqllocaldb;Database=BusinessSchedulerDB;Trusted_Connection=True;"
      }
    }

#### 4. Veritabanı Migration'larını Çalıştır

    dotnet ef database update --project src/Api

#### 5. Uygulamayı Başlat

**API Sunucusu:**

    dotnet run --project src/Api

**Blazor WebAssembly İstemcisi:**

    dotnet run --project src/Client

### API Endpoint'leri (Örnek)

| Metot | Endpoint | Açıklama |
| :--- | :--- | :--- |
| GET | `/api/appointments` | Randevu listesi |
| GET | `/api/appointments/{id}` | Randevu detayı |
| POST | `/api/appointments` | Yeni randevu oluştur |
| PUT | `/api/appointments/{id}` | Randevu güncelle |
| DELETE | `/api/appointments/{id}` | Randevu iptal et |
| GET | `/api/availability/{date}` | Belirli tarih için müsait saatler |

### Testleri Çalıştırma

    dotnet test tests/Api.Tests

---

## 🇬🇧 English

### Project Summary

**BusinessScheduler** is a **bilingual (Turkish/English)** appointment scheduling system developed to meet the scheduling and calendar management needs of modern businesses.

**Architecture:** ASP.NET Core Web API (backend) + Blazor WebAssembly (frontend) + Entity Framework Core (ORM) + SQL Server (database). Designed with Clean Architecture principles as a production-ready solution.

### Use Cases

*   💈 **Service Businesses:** Salons, barbershops, dental clinics, beauty centers
*   🧑‍💼 **Consulting:** Client appointment tracking and management
*   🏫 **Education:** Teacher-student meeting scheduling
*   🏥 **Healthcare:** Patient appointment systems
*   📅 **General:** Online reservations for any service industry

### Technologies Used

| Component | Technology | Purpose |
| :--- | :--- | :--- |
| **Framework** | .NET 8 | Main framework |
| **Frontend** | Blazor WebAssembly | SPA, runs C# in the browser |
| **Backend API** | ASP.NET Core 8 | RESTful API services |
| **ORM** | Entity Framework Core 8 | Database operations (Code-First) |
| **Database** | SQL Server 2019+ | Data persistence |
| **Testing** | xUnit 2.5+ | Unit testing |
| **Localization**| .RESX | Bilingual UI support |

### Features

| Feature | Description |
| :--- | :--- |
| ✅ **Bilingual UI (TR/EN)** | Runtime-switchable UI and notifications |
| ✅ **Appointment Management** | CRUD operations with date/time filtering and search |
| ✅ **Availability Check** | Automatic conflict prevention, dynamic time slot management |
| ✅ **Service Management** | Service-based duration and pricing definition |
| ✅ **Customer Management** | Customer records, appointment history, contact info |
| ✅ **Appointment Reminders** | Automatic email reminders (background service) |
| ✅ **Calendar View** | Weekly/monthly calendar for appointment tracking |
| ✅ **Excel/PDF Reporting** | Appointment statistics and customer reports |

### Quick Start

    # Clone repository
    git clone https://github.com/omertarikbayir/BusinessScheduler.git
    cd BusinessScheduler

    # Restore and build
    dotnet restore
    dotnet build BusinessScheduler.sln -c Release

    # Update database
    dotnet ef database update --project src/Api

    # Run API
    dotnet run --project src/Api

    # Run Blazor client
    dotnet run --project src/Client

    # Run tests
    dotnet test tests/Api.Tests

### API Endpoints (Example)

| Method | Endpoint | Description |
| :--- | :--- | :--- |
| GET | `/api/appointments` | List appointments |
| GET | `/api/appointments/{id}` | Get appointment details |
| POST | `/api/appointments` | Create new appointment |
| PUT | `/api/appointments/{id}` | Update appointment |
| DELETE | `/api/appointments/{id}` | Cancel appointment |
| GET | `/api/availability/{date}` | Get available time slots for a date |

---

## 📝 Notlar | Notes

*   Bu proje **kurumsal kullanıma hazır** bir şablon olarak tasarlanmıştır | This project is designed as a **production-ready enterprise template**.
*   E-posta bildirimleri için geçerli SMTP ayarları gereklidir | Valid SMTP settings required for email notifications.
*   JWT Authentication eklenmesi planlanmaktadır (şu an open API) | JWT Authentication is planned (currently open API).

---

## 📄 Lisans | License

MIT License - detaylar için [LICENSE](LICENSE) dosyasına bakın | See [LICENSE](LICENSE) file for details.

---

**Ready for production use in service businesses.**  
**Hizmet işletmelerinde üretim kullanımına hazır.**

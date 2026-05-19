# BusinessScheduler | İş Randevu Planlama Sistemi

> 🇹🇷 Türkçe | 🇬🇧 English | .NET 8 | Blazor WebAssembly | REST API

---

## 🇹🇷 Türkçe

### Proje Özeti

**BusinessScheduler**, modern işletmelerin randevu ve takvim yönetim ihtiyaçlarını karşılamak için geliştirilmiş çift dilli bir randevu planlama sistemidir. ASP.NET Core Web API backend, Blazor WebAssembly frontend ve Entity Framework Core ile SQL Server veritabanı kullanır.

### Kullanım Senaryoları

- Kuaför, berber, dişçi gibi hizmet işletmelerinde randevu yönetimi
- Danışmanlık firmalarında müşteri randevu takibi
- Eğitim kurumlarında öğretmen-öğrenci görüşme planlaması
- Sağlık kuruluşlarında hasta randevu sistemi
- Her türlü hizmet sektöründe çevrimiçi rezervasyon

### Kullanılan Teknolojiler

| Bileşen | Teknoloji | Amaç |
|---------|-----------|------|
| .NET | 8.0 | Ana framework |
| Blazor WebAssembly | .NET 8 | SPA frontend (C# ile) |
| ASP.NET Core | 8.0 | REST API |
| Entity Framework Core | 8.0 | ORM / Veritabanı |
| SQL Server | 2019+ | Veritabanı |
| xUnit | 2.5+ | Birim testleri |

### Proje Yapısı

```
BusinessScheduler/
│   .gitignore
│   BusinessScheduler.sln
│   LICENSE
│   README.md
│
├───src
│   ├───Api/                          # ASP.NET Core Web API
│   │   ├───Controllers/              # API endpoint'leri
│   │   ├───Data/                     # DbContext ve migrations
│   │   ├───Models/                   # Entity modelleri
│   │   ├───Services/                 # İş mantığı servisleri
│   │   └───Properties/               # launchSettings
│   │
│   └───Client/                       # Blazor WebAssembly
│       ├───Layout/                   # Ana layout bileşenleri
│       ├───Pages/                    # Sayfalar
│       ├───Resources/                # Yerelleştirme dosyaları
│       └───wwwroot/                  # Statik dosyalar
│
└───tests
    └───Api.Tests/                    # xUnit testleri
            AppointmentTests.cs
            UnitTest1.cs
```

### Özellikler

| Özellik | Açıklama |
|---------|----------|
| ✅ **Çift Dilli Arayüz (TR/EN)** | Tüm UI ve veriler çalışma anında dil değiştirebilir |
| ✅ **Randevu Yönetimi** | CRUD işlemleri, tarih/saat bazlı filtreleme |
| ✅ **Müsaitlik Kontrolü** | Çakışan randevuları engelleme, zaman dilimi yönetimi |
| ✅ **Servis Yönetimi** | Hizmet bazlı randevu süresi ve ücret tanımlama |
| ✅ **Müşteri Yönetimi** | Müşteri kaydı, randevu geçmişi |
| ✅ **Randevu Hatırlatma** | E-posta ile otomatik hatırlatma |
| ✅ **Takvim Görünümü** | Haftalık/aylık takvim ile randevu takibi |
| ✅ **Excel/PDF Raporlama** | Randevu ve istatistik raporları |

### Hızlı Başlangıç

#### 1. Projeyi Klonla

```bash
git clone https://github.com/omertarikbayir/BusinessScheduler.git
cd BusinessScheduler
```

#### 2. Bağımlılıkları Yükle ve Derle

```bash
dotnet restore
dotnet build BusinessScheduler.sln -c Release
```

#### 3. Connection String'i Güncelle

`src/Api/appsettings.json` dosyasını düzenleyin:

```json
{
  "ConnectionStrings": {
    "Default": "Server=(localdb)\\mssqllocaldb;Database=BusinessSchedulerDB;Trusted_Connection=True;"
  }
}
```

#### 4. Veritabanı Migration'larını Çalıştır

```bash
dotnet ef database update --project src/Api
```

#### 5. Uygulamayı Başlat

**API Sunucusu:**
```bash
dotnet run --project src/Api
```

**Blazor WebAssembly İstemcisi:**
```bash
dotnet run --project src/Client
```

### API Endpoint'leri (Örnek)

| Metot | Endpoint | Açıklama |
|-------|----------|----------|
| GET | `/api/appointments` | Randevu listesi |
| GET | `/api/appointments/{id}` | Randevu detayı |
| POST | `/api/appointments` | Yeni randevu oluştur |
| PUT | `/api/appointments/{id}` | Randevu güncelle |
| DELETE | `/api/appointments/{id}` | Randevu iptal et |
| GET | `/api/availability/{date}` | Müsait saatler |

### Testleri Çalıştırma

```bash
dotnet test tests/Api.Tests
```

---

## 🇬🇧 English

### Project Summary

**BusinessScheduler** is a bilingual appointment scheduling system developed to meet the scheduling and calendar management needs of modern businesses. It uses ASP.NET Core Web API backend, Blazor WebAssembly frontend, and Entity Framework Core with SQL Server database.

### Use Cases

- Appointment management for service businesses (hair salons, dental clinics)
- Client appointment tracking for consulting firms
- Teacher-student meeting scheduling for educational institutions
- Patient appointment systems for healthcare providers

### Technologies Used

| Component | Technology | Purpose |
|-----------|------------|---------|
| .NET | 8.0 | Main framework |
| Blazor WebAssembly | .NET 8 | SPA frontend |
| ASP.NET Core | 8.0 | REST API |
| Entity Framework Core | 8.0 | ORM / Database |
| SQL Server | 2019+ | Database |
| xUnit | 2.5+ | Unit testing |

### Project Structure

```
BusinessScheduler/
│   .gitignore
│   BusinessScheduler.sln
│   LICENSE
│   README.md
│
├───src
│   ├───Api/                          # ASP.NET Core Web API
│   │   ├───Controllers/              # API endpoints
│   │   ├───Data/                     # DbContext and migrations
│   │   ├───Models/                   # Entity models
│   │   ├───Services/                 # Business logic services
│   │   └───Properties/               # launchSettings
│   │
│   └───Client/                       # Blazor WebAssembly
│       ├───Layout/                   # Layout components
│       ├───Pages/                    # Pages
│       ├───Resources/                # Localization files
│       └───wwwroot/                  # Static files
│
└───tests
    └───Api.Tests/                    # xUnit tests
            AppointmentTests.cs
            UnitTest1.cs
```

### Features

| Feature | Description |
|---------|-------------|
| ✅ **Bilingual UI (TR/EN)** | Runtime-switchable UI and data |
| ✅ **Appointment Management** | CRUD operations with date/time filtering |
| ✅ **Availability Check** | Conflict prevention, time slot management |
| ✅ **Service Management** | Service-based duration and pricing |
| ✅ **Customer Management** | Customer records and appointment history |
| ✅ **Appointment Reminders** | Automatic email notifications |
| ✅ **Calendar View** | Weekly/monthly calendar |
| ✅ **Excel/PDF Reporting** | Appointment and statistics reports |

### Quick Start

```bash
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
```

### API Endpoints (Example)

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/appointments` | List appointments |
| GET | `/api/appointments/{id}` | Get appointment details |
| POST | `/api/appointments` | Create new appointment |
| PUT | `/api/appointments/{id}` | Update appointment |
| DELETE | `/api/appointments/{id}` | Cancel appointment |
| GET | `/api/availability/{date}` | Get available time slots |

---

## 📝 Notlar | Notes

- Bu proje **kurumsal kullanıma hazır** bir şablon olarak tasarlanmıştır | This project is designed as a **production-ready enterprise template**
- E-posta bildirimleri için geçerli SMTP ayarları gereklidir | Valid SMTP settings required for email notifications

---

## 📄 Lisans | License

MIT License - detaylar için [LICENSE](LICENSE) dosyasına bakın | See [LICENSE](LICENSE) file for details.

---

**Ready for production use in service businesses.**  
**Hizmet işletmelerinde üretim kullanımına hazır.**
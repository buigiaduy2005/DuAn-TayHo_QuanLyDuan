# MiniPMS - Dự Án Quản Lý Dự Án Tây Hồ

Hệ thống quản lý dự án Mini (Mini Project Management System) được xây dựng bằng .NET 8 Web API, hỗ trợ quản lý các dự án và công việc một cách hiệu quả.

## 🚀 Công Nghệ Sử Dụng

- **Backend:** .NET 8 Web API
- **Database:** 
  - SQL Server (Dữ liệu chính)
  - MongoDB (Tùy chọn mở rộng)
- **ORM:** Entity Framework Core
- **Containerization:** Docker & Docker Compose
- **Tài liệu API:** Swagger / OpenAPI

## 🛠️ Yêu Cầu Hệ Thống

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- Visual Studio 2022 hoặc VS Code

## 🏃 Hướng Dẫn Cài Đặt & Chạy Dự Án

### 1. Khởi chạy Database qua Docker
Dự án sử dụng Docker để chạy SQL Server và MongoDB. Mở terminal tại thư mục gốc và chạy:

```bash
docker-compose up -d
```

### 2. Cấu hình Connection String
Kiểm tra file `appsettings.json` trong thư mục `MiniPMS.Api` để đảm bảo chuỗi kết nối chính xác:

```json
"ConnectionStrings": {
  "MiniPMSDb": "Server=localhost,1433;Database=MiniPMS;User=sa;Password=Password123!;TrustServerCertificate=True;Encrypt=False"
}
```

### 3. Chạy dự án Backend
Tại thư mục `MiniPMS.Api`, chạy lệnh:

```bash
dotnet run
```

Dự án sẽ tự động khởi tạo database nếu chưa tồn tại nhờ lệnh `db.Database.EnsureCreated()` trong `Program.cs`.

## 📖 Tài Liệu API

Sau khi chạy dự án thành công, bạn có thể truy cập Swagger UI để xem và thử nghiệm các API tại:
`https://localhost:7xxx/swagger/index.html` (Cổng port sẽ hiển thị khi chạy lệnh `dotnet run`).

## ✨ Các Tính Năng Chính

- [x] Quản lý dự án (Project Management)
- [x] Thêm mới công việc vào dự án (Add Tasks)
- [x] Tự động khởi tạo cấu trúc Database
- [x] Hỗ trợ môi trường Docker cho Database

## 👥 Tác Giả

- **Bùi Gia Duy** - [buigiaduy2005](https://github.com/buigiaduy2005)

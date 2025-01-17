# DI Service Lifetime Demo
這是一個 ASP.NET Core 專案，主要用來測試和演示依賴注入（Dependency Injection, DI）中的不同服務生命周期：
## 功能
- **Transient (瞬態)**：每次請求服務時，產生新的物件實例。
- **Scoped (範圍)**：在同一個 HTTP 請求中，使用相同的物件實例。
- **Singleton (單例)**：在應用程式生命週期中，所有請求共享同一個物件實例。

控制器 `HomeController` 會將每個生命周期的服務注入兩次，並顯示每個服務的 GUID，幫助觀察是否為同一實例。


透過簡單的 Controller 和服務類別，顯示不同生命周期的物件在應用程式中的行為差異。


## 專案結構
DI_Service_Lifetime/
├── Controllers/
│   └── HomeController.cs      // 控制器，測試和展示 DI 的不同生命周期行為
├── Services/
│   ├── ISingletonGuidService.cs
│   ├── IScopedGuidService.cs
│   ├── ITransientGuidService.cs
│   ├── SingletonGuidService.cs
│   ├── ScopedGuidService.cs
│   └── TransientGuidService.cs
├── Models/
│   └── ErrorViewModel.cs      // 用於 Error 頁面的模型
├── Program.cs                 // 註冊 DI 的生命周期設定
├── appsettings.json           // 設定檔
└── DI_Service_Lifetime.csproj // 專案檔

## 啟動專案
1. 確保安裝了以下工具：
   - [.NET 8 SDK](https://dotnet.microsoft.com/)
   - 任意 IDE（如 Visual Studio 或 Visual Studio Code）
2. CLONE專案：
   ```bash
   git clone <https://github.com/wds901209/DI_Service_Lifetime.git>
   cd DI_Service_Lifetime

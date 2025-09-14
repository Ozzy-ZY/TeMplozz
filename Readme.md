# 💀 API TEMPLATE (BUT CHAOTIC) 💀

## To be Updated soon
---

YO. THIS IS A FREAKIN’ **ASP.NET Core Web API Template**. It’s got layers. It’s got JWT auth. It’s got **file handling**. Basically, it’s BUILT DIFFERENT. 🚀

---
## 🏗️ ARCHITECTURE (BECAUSE ORGANIZATION MATTERS, OK?)

- **API Layer** – HTTP requests go brrrr 💨
- **Application Layer** – Business logic happens here, nerd
- **Domain Layer** – The pure, untouchable core entities
- **Infrastructure Layer** – Where the database magic lives

---
## ✨ FEATURES (A.K.A. WHY THIS SLAPS)

- **🔥 Authentication & Authorization 🔥**
  - JWTs with refresh token sorcery 🪄
  - Role-based nonsense (Admin vs Peasant)
  - Registration & login because DUH
  - Change password so you can regret your choices
  - Google Authentication for the cool kids 🔍

- **📂 File Management**
  - Upload stuff 📤
  - Image storage 📸
  - Configurable like your coffee ☕

- **🛢️ Data Access**
  - Entity Framework Core (EF Core) because raw SQL is pain
  - Repositories for that clean, crisp data handling ✨
  - Unit of Work because transactions exist
  - Migrations because "Works on my machine" isn't good enough

- **🛠️ API Configuration**
  - DI setup because manual dependency management is suffering
  - OpenAPI/Swagger docs so people actually use this
  - Environment-specific configs (yes, PROD and DEV are different)

---
## 🚀 GETTING STARTED (NOOB GUIDE)

### Prerequisites:
- .NET 6.0+ (stay up to date, kids)
- SQL Server (or something compatible, we don’t judge)
- Visual Studio 2022 or VS Code (pick your poison)

### Installation (FOLLOW THE STEPS OR SUFFER):
1. **Clone it.**
   ```sh
   git clone https://github.com/Ozzy-ZY/api-template.git
   ```
2. **Enter the void.**
   ```sh
   cd api-template
   ```
3. **Configure your secrets (aka database connection).**
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DB;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```
4. **Summon the database.**
   ```sh
   dotnet ef database update
   ```
5. **Summon the API overlords.**
   ```sh
   dotnet run --project API
   ```
6. **Swagger lives here →** `https://localhost:7282/Scalar/v1`

---
## 📁 PROJECT STRUCTURE (A.K.A. THE BLUEPRINTS)

```
API_Template/
├── API/
│   ├── Controllers/ (Here be endpoints 🛑)
│   │   ├── AuthController.cs (Login, Register, etc.)
│   │   ├── TestController.cs (Just vibes 🤷‍♂️)
│   │   └── UserController.cs (User stuff 👤)
│   ├── wwwroot/
│   │   └── uploads/ (Where your cursed files go)
│   ├── appsettings.json (Configs, don’t touch if scared)
│   └── Program.cs (API bootup magic 🏎️)
│
├── Application/
│   ├── DTOs/ (Data but with ✨ structure ✨)
│   ├── Services/ (The real work happens here)
│   └── Validators/ (STOP BAD INPUTS 🚫)
│
├── Domain/
│   ├── Models/ (Entities, aka the data lords)
│   ├── ModelsConfig/ (Mapping rules because EF Core needs them)
│
└── Infrastructure/
    └── DataAccess/
        ├── Repositories/ (Data handlers 📦)
        ├── Migrations/ (DB evolution, survival of the fittest)
```

---
## 🔐 AUTH FLOW (FOR THOSE WHO LIKE SECURITY)

1. **Register** – Sign up (yay, new user!)
   ```http
   POST /api/auth/RegisterUser
   ```
2. **Login** – Get a token, prove you're cool
   ```http
   POST /api/auth/loginUser
   ```
3. **Google Login** – Let the big G vouch for you 🌐
   ```http
   GET /api/googleauth/login
   ```
4. **Refresh Token** – Because tokens expire like milk 🥛
   ```http
   POST /api/auth/RefreshToken
   ```
5. **Change Password** – When you forget your dog's birthday
   ```http
   POST /api/auth/Logout
   ```

---
## 🛠️ CUSTOMIZATION (BECOME A CODE WIZARD)

### Adding a Controller:
1. Make a new `.cs` file in `API/Controllers`
2. Inherit `ControllerBase`
3. Add `[Route]`, `[HttpGet]`, etc.
4. Deploy. Dominate. 🚀

### Adding a Model:
1. Create it in `Domain/Models/`
2. Config it in `Domain/ModelsConfig/`
3. Add it to `AppDbContext`
4. Migrate (`dotnet ef migrations add SomethingCool`)

---
## 📄 LICENSE (IT'S MIT, DO WHATEVER, JUST DON’T SUE ME)

## 🤝 CONTRIBUTING (WE WANT YOUR CODE)

1. **Fork it.** 📌
2. **Make a branch.** 🌿
   ```sh
   git checkout -b feature/amazing-feature
   ```
3. **Commit your masterpiece.** 🎨
   ```sh
   git commit -m "Add some amazing feature"
   ```
4. **Push it real good.** 🚀
   ```sh
   git push origin feature/amazing-feature
   ```
5. **Open a Pull Request.** 🛠️

---

🔥 **Made with caffeine, sleepless nights, and questionable decisions.** 🔥


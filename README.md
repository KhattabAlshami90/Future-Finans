# Future Finans

Ett exempelprojekt byggt med Blazor Web App (.NET 8) där kunder kan ansöka om lån online.
Projektet innehåller ett formulär för låneansökningar, logik för beslut om lånet samt lagring i en databas via Entity Framework Core.

🚀 Funktioner

Formulär för låneansökan (namn, inkomst, lånebelopp, återbetalningstid).

Beslutslogik i frontend/backend (enkelt exempel: godkänd/nekad baserat på inkomst och lånebelopp).

Lagring i databas (SQL Server via EF Core).

Blazor Web App med serverinteraktivitet.

🛠️ Teknologier

.NET 8

Blazor Web App

Entity Framework Core

SQL Server

📂 Projektstruktur
YourBankApp/
│── Components/
│   └── Pages/
│       └── LoanForm.razor      # Formulär för låneansökan
│── Data/
│   └── ApplicationDbContext.cs # Databas-koppling via EF Core
│── Models/
│   └── LoanApplication.cs      # Låneansökan-modell
│── wwwroot/                    # Statisk frontend (css, js)
│── Program.cs                  # Konfiguration och DI
│── appsettings.json            # Connection string
│── README.md                   # Dokumentation

⚙️ Installation och körning

Klona repot:

git clone https://github.com/YourUsername/YourBankApp.git
cd YourBankApp


Installera beroenden:

dotnet restore


Uppdatera appsettings.json med din SQL Server connection string:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=YourBankDb;Trusted_Connection=True;TrustServerCertificate=True"
}


Kör migrationer och skapa databasen:

dotnet ef migrations add InitialCreate
dotnet ef database update


Starta projektet:

dotnet run


Öppna i webbläsaren:
👉 https://localhost:5001/loan

📸 Skärmbilder (exempel)

(lägg in screenshots här på formulär + resultat)

🔮 Kommande funktioner

Adminpanel för att se alla ansökningar.

Rollbaserad autentisering (Admin/User).

Mer avancerad beslutslogik (räntor, risknivåer).

Möjlighet att exportera rapporter (PDF/Excel).

👤 Författare

Khattab Alshami
📧 Khmoal90@gmail.com

💻 GitHub Khattabalshami90
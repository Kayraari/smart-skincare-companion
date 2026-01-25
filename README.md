# Smart Skincare Companion 🧴✨

A comprehensive **Blazor Server** web application built with **.NET 8** for managing skincare routines, products, and user profiles. This application helps users organize their skincare products, create personalized routines, track progress, and receive allergy warnings.

---

## 📋 Table of Contents

- [Features](#-features)
- [Technologies](#-technologies)
- [Database Schema](#-database-schema)
- [Prerequisites](#-prerequisites)
- [Installation & Setup](#-installation--setup)
- [Running the Application](#-running-the-application)
- [Project Structure](#-project-structure)
- [Usage Guide](#-usage-guide)
- [Team Members](#-team-members)

---

## ✨ Features

### User Management
- **User Registration & Login**: Secure user authentication with email and password
- **User Profiles**: Personal profile pages displaying user information and skincare collections

### Product Management
- **Product Catalog**: Browse and manage skincare products with ingredient information
- **Product Ownership**: Track products you own with purchase dates and expiration dates
- **Expiring Inventory Tracking**: View products that are approaching expiration dates
- **Ingredient Tracking**: Monitor ingredients in products for allergy awareness

### Routine Management
- **Custom Routines**: Create personalized skincare routines (morning, evening, weekly, etc.)
- **Routine Steps**: Define step-by-step instructions for each routine
- **Product Association**: Link owned products to specific routine steps
- **Routine Details**: View comprehensive details of each routine with all products used

### Progress & Health Tracking
- **Progress Records**: Track skincare progress over time
- **Allergy Warnings**: Automatic alerts for products containing ingredients you're allergic to
- **Routine Analytics**: Monitor adherence and effectiveness of skincare routines

### Data Views
- **Allergy Warnings View**: Database view showing potential allergic reactions
- **Expiring Inventory View**: Database view listing products nearing expiration
- **Routine Details View**: Database view providing complete routine information

---

## 🛠 Technologies

### Main Frameworks
- **.NET 8** - Latest .NET framework
- **Blazor Server** - Interactive web UI framework
- **ASP.NET Core** - Web application framework
- **C#** - Primary programming language

### Data Access
- **Entity Framework Core 8.0.22** - Modern ORM for .NET
- **Entity Framework 6.2.0** - For DataAccess layer compatibility
- **Microsoft SQL Server** - Database engine
- **SQL Server LocalDB** - Development database

### UI & Components
- **Blazor Components** - Reusable UI components
- **Microsoft.AspNetCore.Components.Forms** - Form handling
- **Microsoft.AspNetCore.Components.QuickGrid** - Data grid with Entity Framework adapter
- **Bootstrap** - CSS framework for responsive design

### Development Tools
- **Microsoft.EntityFrameworkCore.Tools** - EF Core CLI tools
- **Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore** - Database diagnostics
- **Microsoft.VisualStudio.Web.CodeGeneration.Design** - Scaffolding tools

### Validation & Security
- **System.ComponentModel.DataAnnotations** - Model validation
- **Integrated Windows Authentication** - Database security

---

## 🗄 Database Schema

The application uses a SQL Server database with the following main entities:

### Core Tables
- **User** - User accounts with email, password hash, allergies
- **PRODUCT** - Skincare products with names, brands, and descriptions
- **INGREDIENT** - Product ingredients for allergy tracking
- **OWNERSHIP** - User-owned products with purchase/expiration dates
- **ROUTINE** - User-created skincare routines
- **ROUTINESTEP** - Individual steps in routines with product associations
- **PROGRESSRECORD** - Tracking user progress over time

### Database Views
- **v_AllergyWarnings** - Identifies products with user allergens
- **v_ExpiringInventory** - Lists products approaching expiration
- **v_RoutineDetail** - Complete routine information with products

For detailed database setup instructions, see `databasereadme.txt`.

---

## 📦 Prerequisites

Before running the project, ensure you have:

1. **[.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)**
   - Required for building and running the application

2. **[Visual Studio 2022](https://visualstudio.microsoft.com/vs/)** (Recommended)
   - With **ASP.NET and web development** workload
   - With **Data storage and processing** workload
   - Alternatively, use Visual Studio Code with C# extension

3. **[SQL Server](https://www.microsoft.com/sql-server)**
   - SQL Server 2019 or later, or
   - SQL Server LocalDB (included with Visual Studio)
   - SQL Server Express (free edition)

4. **Windows Operating System** (Recommended)
   - For integrated Windows authentication with SQL Server

---

## 🚀 Installation & Setup

### 1. Clone the Repository

```bash
git clone https://github.com/Kayraari/smart-skincare-companion.git
cd smart-skincare-companion
```

### 2. Open the Solution

- Launch **Visual Studio 2022**
- Open `CMPE232yen.sln`

### 3. Restore NuGet Packages

Packages should restore automatically. If not:
- Right-click on the solution in Solution Explorer
- Select **Restore NuGet Packages**

Or via command line:
```bash
dotnet restore
```

### 4. Configure the Database

#### Option A: Using SQL Server LocalDB (Default)

The application is pre-configured for LocalDB:

```json
"ConnectionStrings": {
  "SengWebContext": "Data Source=(local);Initial Catalog=Skincare companion;Integrated Security=True;Encrypt=false;TrustServerCertificate=true"
}
```

#### Option B: Using SQL Server

1. Open `SengWeb/appsettings.json`
2. Update the connection string:

```json
"ConnectionStrings": {
  "SengWebContext": "Server=YOUR_SERVER_NAME;Database=Skincare companion;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true"
}
```

Replace `YOUR_SERVER_NAME` with your SQL Server instance name.

### 5. Create the Database

Refer to `databasereadme.txt` for detailed database setup instructions, including:
- Database creation scripts
- Table creation
- View creation
- Sample data insertion

**Quick Setup:**
1. Open SQL Server Management Studio (SSMS)
2. Connect to your SQL Server instance
3. Execute the SQL scripts provided in `databasereadme.txt`
4. Verify all tables, views, and sample data are created

### 6. Build the Solution

**Via Visual Studio:**
- Press `Ctrl + Shift + B`, or
- Select **Build → Build Solution**

**Via Command Line:**
```bash
dotnet build
```

---

## ▶️ Running the Application

### Using Visual Studio

1. Set **SengWeb** as the startup project:
   - Right-click on the `SengWeb` project
   - Select **Set as Startup Project**

2. Run the application:
   - Press **F5** (with debugging), or
   - Press **Ctrl + F5** (without debugging)

3. Your default browser will open automatically at `https://localhost:xxxx/`

### Using Command Line

```bash
cd SengWeb
dotnet run
```

Then navigate to the URL shown in the console (typically `https://localhost:5001` or `http://localhost:5000`)

### Default Access

The application will open to the **Login Page** at the root URL (`/`).

---

## 📁 Project Structure

```
smart-skincare-companion/
├── CMPE232yen.sln              # Visual Studio solution file
├── README.md                   # This file
├── databasereadme.txt          # Database setup instructions
│
├── DataAccess/                 # Data Access Layer
│   ├── DataAccess.csproj       # Entity Framework 6 project
│   ├── Model1.edmx             # Entity Data Model
│   ├── User.cs                 # User entity
│   ├── PRODUCT.cs              # Product entity
│   ├── INGREDIENT.cs           # Ingredient entity
│   ├── OWNERSHIP.cs            # Ownership entity
│   ├── ROUTINE.cs              # Routine entity
│   ├── ROUTINESTEP.cs          # RoutineStep entity
│   ├── PROGRESSRECORD.cs       # ProgressRecord entity
│   └── v_*.cs                  # Database view entities
│
└── SengWeb/                    # Main Web Application
    ├── SengWeb.csproj          # Blazor Server project (.NET 8)
    ├── Program.cs              # Application entry point
    ├── appsettings.json        # Configuration file
    │
    ├── Components/             # Blazor components
    │   ├── Layout/             # Layout components
    │   │   ├── MainLayout.razor
    │   │   └── NavMenu.razor
    │   │
    │   └── Pages/              # Page components
    │       ├── Home.razor      # Login page (/)
    │       ├── AddUser.razor   # Registration page
    │       ├── Profile.razor   # User profile page
    │       ├── AddProduct.razor # Add products to profile
    │       ├── Routines.razor  # Create routines
    │       │
    │       ├── UserPages/      # User CRUD operations
    │       ├── PRODUCTPages/   # Product CRUD operations
    │       ├── OWNERSHIPPages/ # Ownership CRUD operations
    │       ├── ROUTINEPages/   # Routine CRUD operations
    │       └── ROUTINESTEPPages/ # Routine step CRUD operations
    │
    ├── Data/                   # Data context
    │   └── SengWebContext.cs   # EF Core DbContext
    │
    └── wwwroot/                # Static files
        ├── css/                # Stylesheets
        └── js/                 # JavaScript files
```

---

## 📖 Usage Guide

### Getting Started

1. **Register a New Account**
   - Navigate to the registration page from the login screen
   - Provide email, password, and allergy information
   - Submit to create your account

2. **Login**
   - Enter your email and password on the login page
   - Click "Login" to access your profile

3. **View Your Profile**
   - After login, navigate to your profile page
   - View your user information and owned products

### Managing Products

1. **Add Products to Your Collection**
   - From your profile, click "Add Product"
   - Select products from the catalog
   - Enter purchase date and expiration date
   - Save to add to your collection

2. **View Product Details**
   - Click on any product to see details
   - View ingredients and check for allergens
   - See which routines use this product

### Creating Routines

1. **Create a New Routine**
   - Navigate to "Create Routine" from your profile
   - Enter routine name (e.g., "Morning Routine")
   - Specify routine type (e.g., "Daily", "Weekly")
   - Select products from your collection to include
   - Save the routine

2. **Add Routine Steps**
   - Open your routine
   - Add individual steps (e.g., "Cleanse", "Tone", "Moisturize")
   - Assign products to each step
   - Set the order of steps

### Tracking Progress

1. **View Allergy Warnings**
   - Check for products containing ingredients you're allergic to
   - Review warnings before using new products

2. **Monitor Expiring Products**
   - View products approaching expiration
   - Plan to use or replace them in time

3. **Track Your Skincare Journey**
   - Record progress regularly
   - Monitor improvements over time

---

## 👥 Team Members

This project was developed as a **group project** by:

- **Sema Işıl Kadıoğlu**
- **Kayra Arı**
- **Elçin Karagül**
- **Beyza Songül**

All team members contributed collaboratively to the project's development, design, and implementation.

---

## 📄 License

This project was developed as an academic project for educational purposes.

---

## 🤝 Contributing

This is an academic project. For questions or suggestions, please contact the team members.

---

## 📞 Support

For issues or questions about the application:
1. Check the `databasereadme.txt` for database-related issues
2. Ensure all prerequisites are installed correctly
3. Verify the connection string in `appsettings.json`
4. Check that the database is running and accessible

---

**Built with ❤️ using Blazor and .NET 8**

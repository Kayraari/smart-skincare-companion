# Skincare Companion – Blazor Web Application

This is a **Blazor Server** web application developed with **.NET 8** for managing  
**user profiles, skincare routines, and products**.

The project uses **Entity Framework Core** for database access and **SQL Server** as the database provider.

---

## Technologies & Libraries

### Main Frameworks
- **.NET 8**
- **Blazor Server**
- **ASP.NET Core**

### Data Access
- **Microsoft.EntityFrameworkCore**
- **Microsoft.EntityFrameworkCore.SqlServer**
- **Microsoft.EntityFrameworkCore.Tools**

### UI & Forms
- **Microsoft.AspNetCore.Components**
- **Microsoft.AspNetCore.Components.Forms**

### Validation
- **System.ComponentModel.DataAnnotations**

>⚠️ Additional NuGet packages may exist.  
> Please check the `.csproj` file for the full list.

---

## Prerequisites

Before running the project, make sure you have:

- **.NET 8 SDK**
- **Visual Studio 2022**  
  (ASP.NET and Blazor workloads installed)
- **SQL Server** (LocalDB or full SQL Server)

---

## Setup & Run Instructions
 1. Open the Solution
- Launch **Visual Studio 2022**
- Open the solution file (`.sln`)

---

 2. Restore NuGet Packages
- Packages are restored automatically  
- If not:
  - Right-click the solution  
  - Select **Restore NuGet Packages**

---

3. Configure the Database
- Open `appsettings.json`
- Ensure the connection string is correct:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=...;Database=...;Trusted_Connection=True;"
}
4. Build the Solution

Press Ctrl + Shift + B

Or select Build → Build Solution

5. Run the Application

Set the Blazor project (e.g. SengWeb) as Startup Project

Press:

F5 (with debugging)
6. Access the Application

The app will open in your browser:

https://localhost:xxxx/
Ctrl + F5 (without debugging)
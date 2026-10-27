# StockWise — Inventory and Stock Management System

A mini-project for Web Technologies with .NET, built with ASP.NET Core MVC, Entity Framework Core, MySQL and Bootstrap.

## Features
- Product CRUD with SKU uniqueness validation
- Categories seeded on database creation
- Stock-in and stock-out transaction history
- Automatic quantity updates and insufficient-stock validation
- Low-stock dashboard and inventory report
- Search products by name or SKU
- Responsive Bootstrap interface
- TempData flash messages for state management

## Requirements
- .NET 8 SDK
- MySQL 8.x
- Visual Studio 2022 or VS Code

## Setup
1. Install MySQL and ensure the server is running.
2. Edit `appsettings.json` and replace `CHANGE_ME` with your local MySQL password.
3. Open a terminal in this project directory.
4. Run:

```bash
dotnet restore
dotnet tool install --global dotnet-ef --version 8.*
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```

5. Open the HTTPS or HTTP URL shown by `dotnet run`.

EF Core migrations create the `inventory_stock_db` database and tables, provided the MySQL user has permission to create databases. Otherwise create the database manually in MySQL first:

```sql
CREATE DATABASE inventory_stock_db;
```

## Important notes
- This is an educational mini-project starter. Test it locally before submission.
- The default connection string is for local development only. Do not commit real passwords to GitHub. Prefer environment variables or user secrets.
- Stock movement validation is suitable for a single-user classroom demo. For multi-user/production use, add concurrency control, authentication/authorization, stronger transaction safeguards, audit logs, and backups.
- The inventory value report is a simple estimate based on quantity × current product unit price, not an accounting valuation.
- Category CRUD and separate supplier/purchase/sales invoice modules can be added if required; the current version demonstrates categories, product CRUD, and stock-in/stock-out transactions.

## GitHub submission
Create a new GitHub repository, then run:

```bash
git init
git add .
git commit -m "Initial Inventory Stock Management project"
git branch -M main
git remote add origin https://github.com/YOUR-USERNAME/YOUR-REPOSITORY.git
git push -u origin main
```

Replace the placeholder repository URL with your own. Do not upload passwords, database dumps with private data, or `bin/` and `obj/` folders.

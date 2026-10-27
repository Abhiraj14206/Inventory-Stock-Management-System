# 📦 StockWise — Inventory and Stock Management System

**A Web-Based Inventory Management Application Using ASP.NET Core MVC, C#, Entity Framework Core, MySQL, and Bootstrap**

---

## 📖 1. About the Project

**StockWise** is a web-based Inventory and Stock Management System developed to simplify the process of managing products, monitoring stock quantities, organizing product categories, and tracking inventory movements.

The application provides a centralized platform where users can maintain product information, record stock-in and stock-out transactions, monitor low-stock items, and review inventory-related reports.

The project uses **ASP.NET Core MVC** for the web application architecture, **Entity Framework Core** for database operations, and **MySQL** for storing inventory information.

StockWise is designed as an academic and learning project to demonstrate web application development, database integration, CRUD operations, data validation, and inventory management workflows.

## 🎯 2. Project Objectives

The main objectives of StockWise are:

- To simplify product and inventory management.
- To maintain organized product and category records.
- To track stock additions and stock reductions.
- To prevent stock-out transactions from exceeding available quantities.
- To identify products with low stock levels.
- To maintain inventory movement records.
- To provide a user-friendly and responsive web interface.
- To demonstrate the practical use of ASP.NET Core MVC and MySQL.

## ✨ 3. Key Features

### 📊 Dashboard
Provides an overview of inventory information and helps users identify products that require attention, including low-stock items.

### 📦 Product Management
Allows users to:
- Add new products.
- View product information.
- Edit existing product details.
- Delete product records.
- Maintain product information such as name, SKU, category, and stock quantity, where supported by the application.

### 🗂️ Category Management
Organizes products into categories to make inventory records easier to maintain and navigate.

### 🔄 Stock In and Stock Out
Records stock movements when inventory is added or issued. Quantities are updated to reflect stock changes.

### ✅ Stock Validation
Validates stock-out transactions to help prevent users from issuing more items than are currently available.

### 🏷️ SKU Validation
Helps prevent duplicate SKU values so that products can be identified more consistently.

### 📉 Low-Stock Monitoring
Helps identify products whose available quantities fall below the configured stock threshold.

### 📋 Stock Movement History
Maintains records of stock transactions so users can review inventory changes.

### 📈 Inventory Reports
Provides inventory-related information to help users review stock status and product records.

### 📱 Responsive Interface
Uses Bootstrap to provide a structured interface that adapts to different screen sizes.

*Note: The availability of individual features depends on the implementation in the current project source code.*

## 🛠️ 4. Technologies Used

| Technology | Purpose |
|---|---|
| C# | Main programming language |
| ASP.NET Core MVC | Web application framework and MVC architecture |
| Entity Framework Core | Database access and object-relational mapping |
| MySQL | Relational database for inventory data |
| HTML5 | Web page structure |
| CSS3 | Styling and page presentation |
| Bootstrap | Responsive layouts and interface components |
| JavaScript | Client-side interactions, where used |
| .NET SDK | Building and running the application |

## 🏗️ 5. System Architecture

StockWise follows the Model-View-Controller (MVC) architecture.

### Model
Represents the application's data entities, such as products, categories, and stock movements.

### View
Provides the user interface through Razor views and HTML pages.

### Controller
Handles incoming requests, processes user actions, and coordinates application operations.

### Database Layer
Entity Framework Core communicates with MySQL to store, retrieve, and update inventory information.

### Application Workflow

1. The user opens a page in the web application.
2. The controller receives the request.
3. The application processes the requested operation.
4. Entity Framework Core communicates with the MySQL database when data access is required.
5. The application returns the appropriate view or result.
6. The user sees the updated inventory information.


## 🗂️ 6. Project Structure

The main project folders follow the ASP.NET Core MVC structure.

```text
Inventory-Stock-Management-System/
│
├── Controllers/
│   └── Application controllers
│
├── Data/
│   └── Database context and configuration
│
├── Migrations/
│   └── Entity Framework Core migrations
│
├── Models/
│   └── Application data models
│
├── Views/
│   └── Razor views and user interface pages
│
├── wwwroot/
│   └── CSS, JavaScript, and static assets
│
├── Program.cs
│   └── Application startup and service configuration
│
├── appsettings.json
│   └── Application configuration
│
└── README.md
    └── Project documentation
```

## 👨‍🎓 7. Student Details

- **Name:** Abhiraj Medhat
- **Enrollment Number:** 202403103510478
- **Project Title:** StockWise — Inventory and Stock Management System

## 👨‍💻 8. Author

**Abhiraj**

GitHub Profile: [Abhiraj14206](https://github.com/Abhiraj14206)

Project Repository: [Inventory Stock Management System](https://github.com/Abhiraj14206/Inventory-Stock-Management-System)

---

<div align="center">

**StockWise — Inventory Made Easier**

Developed using ASP.NET Core MVC, C#, Entity Framework Core, and MySQL.

</div>


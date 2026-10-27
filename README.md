<div align="center">

StockWise
Inventory and Stock Management System
A web-based inventory management application built with ASP.NET Core MVC, C#, Entity Framework Core, MySQL, and Bootstrap.




Manage products. Track stock. Monitor inventory.

Features · Screenshots · Setup · Project Structure
</div>

📌 About the Project
StockWise is an inventory and stock management web application designed to help users maintain product records, organize products into categories, record stock-in and stock-out transactions, and identify low-stock items.

The project demonstrates an ASP.NET Core MVC application connected to a MySQL database through Entity Framework Core. It is intended as a learning/academic project and a foundation for further development.
✨ Features
- Dashboard — view key inventory information and low-stock items.
- Product management — create, view, update, and delete product records.
- SKU validation — help prevent duplicate SKU values.
- Category management — organize products by category.
- Stock In / Stock Out — record stock movements and update quantities.
- Stock validation — prevent a stock-out transaction from exceeding available quantity.
- Stock movement history — review recorded inventory transactions.
- Low-stock monitoring — identify products that may need replenishment.
- Reports — review inventory and stock information.
- Responsive UI — Bootstrap-based interface for desktop and smaller screens.
- Database persistence — save application data in MySQL using Entity Framework Core.
Features can vary with the version of the source code. Keep this list aligned with the pages and functionality implemented in your repository.

🖼️ Application Screenshots
Add screenshots captured from your running StockWise application to docs/screenshots/. The images will appear here after you commit them to GitHub.
<table>
  <tr>
    <td align="center"><strong>Dashboard</strong><br><img src="docs/screenshots/dashboard.png" alt="StockWise dashboard screenshot" width="480"></td>
    <td align="center"><strong>Product List</strong><br><img src="docs/screenshots/products.png" alt="StockWise product list screenshot" width="480"></td>
  </tr>
  <tr>
    <td align="center"><strong>Add Product</strong><br><img src="docs/screenshots/add-product.png" alt="StockWise add product screenshot" width="480"></td>
    <td align="center"><strong>Stock Movement</strong><br><img src="docs/screenshots/stock-movement.png" alt="StockWise stock movement screenshot" width="480"></td>
  </tr>
  <tr>
    <td align="center" colspan="2"><strong>Reports</strong><br><img src="docs/screenshots/reports.png" alt="StockWise reports screenshot" width="600"></td>
  </tr>
</table>


Screenshot folder layout:
docs/
└── screenshots/
    ├── dashboard.png
    ├── products.png
    ├── add-product.png
    ├── stock-movement.png
    └── reports.png
If a screen is not implemented in your project, remove its image entry. Do not use sample images as though they are screenshots of the actual application.
🧰 Technology Stack
Technology	Purpose
C#	Application programming language
ASP.NET Core MVC	Web framework and MVC architecture
Entity Framework Core	Object-relational mapping and database access
MySQL	Relational database
Bootstrap	Responsive styling and layout
HTML / CSS	Page structure and presentation
JavaScript	Client-side interactions, where used
.NET SDK	Build and run the application


🏗️ Project Structure
The repository uses the ASP.NET Core MVC project layout. Main folders and files include:
Inventory-Stock-Management-System/
├── Controllers/       # Request handling and application logic
├── Data/              # Database context and data configuration
├── Migrations/        # Entity Framework Core schema migrations
├── Models/            # Application data models
├── Views/             # Razor views and UI pages
├── wwwroot/           # Static assets such as CSS and JavaScript
├── Program.cs         # Application startup and service configuration
├── appsettings.json   # Application configuration
└── README.md
Folder contents may differ slightly from this overview.
⚙️ Prerequisites
Install the following before running the project:
- .NET 8 SDK
- MySQL Server
- Git (for cloning the repository)
- An editor such as Visual Studio or Visual Studio Code
🚀 Getting Started
1. Clone the repository
git clone https://github.com/Abhiraj14206/Inventory-Stock-Management-System.git
cd Inventory-Stock-Management-System
2. Configure MySQL
Start your local MySQL server and create the database if your application does not create it automatically:
CREATE DATABASE inventory_stock_db;
Open appsettings.json and configure the connection string used by your project. For example:
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3306;database=inventory_stock_db;user=YOUR_MYSQL_USER;password=YOUR_MYSQL_PASSWORD;"
  }
}
Replace the example credentials with your local MySQL credentials. The connection-string name must match the name used in your application code. Do not commit real passwords or other secrets to a public repository.
3. Restore packages
dotnet restore
4. Apply database migrations
If the repository already contains Entity Framework Core migrations, apply them:
dotnet ef database update
If dotnet ef is not installed, install a tool version compatible with the project's EF Core version. Do not create another initial migration when suitable migrations already exist.
5. Run the application
dotnet run
Open the local URL printed in the terminal. The port may vary by configuration.
🗃️ Database
The development configuration uses a MySQL database named inventory_stock_db. The project includes inventory-related data such as products, categories, and stock movements. Entity Framework Core migrations are used to manage schema changes where configured.
🔐 Security Notes
- Never publish real database passwords, API keys, or other secrets.
- Use local user secrets or environment variables for sensitive configuration.
- Review appsettings.json before pushing changes to a public GitHub repository.
- This project is an educational starter and should be reviewed and hardened before production use.
🔮 Possible Future Improvements
- User authentication and role-based permissions
- Supplier and purchase-order management
- Sales, invoices, and returns
- Search, filtering, and pagination for large inventories
- Exportable reports
- Automated tests and deployment instructions
- Improved audit logging and handling of simultaneous stock updates
These are possible enhancements, not a claim that they are already implemented.
🎓 Project Purpose
StockWise demonstrates how an MVC web application can combine database-backed CRUD operations, inventory transactions, validation, and a responsive user interface to support basic stock management.
👨‍💻 Author
Abhiraj

GitHub: @Abhiraj14206
<div align="center">

Made with C#, ASP.NET Core MVC, Entity Framework Core, and MySQL.
</div>

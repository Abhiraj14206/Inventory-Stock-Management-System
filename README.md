StockWise — Inventory and Stock Management System
<p align="center">
  <strong>A web-based inventory management application built with ASP.NET Core MVC, Entity Framework Core, MySQL, and Bootstrap.</strong>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?logo=dotnet&logoColor=white" alt="ASP.NET Core MVC" />
  <img src="https://img.shields.io/badge/C%23-Programming%20Language-239120?logo=csharp&logoColor=white" alt="C sharp" />
  <img src="https://img.shields.io/badge/Database-MySQL-4479A1?logo=mysql&logoColor=white" alt="MySQL" />
  <img src="https://img.shields.io/badge/UI-Bootstrap-7952B3?logo=bootstrap&logoColor=white" alt="Bootstrap" />
</p>

📌 About the Project
StockWise is an inventory and stock management system designed to help users organize products, manage categories, track stock changes, and monitor low-stock items from a web interface. It is a student/learning project demonstrating CRUD operations, database integration, validation, and a responsive MVC application structure.
✨ Features
- Dashboard: View key inventory information and low-stock items.
- Product management: Add, view, edit, and delete products.
- SKU validation: Help prevent duplicate product SKU values.
- Category management: Organize products by category.
- Stock In / Stock Out: Record stock movements and update quantities.
- Stock validation: Prevent stock-out transactions that exceed available quantity.
- Movement history: Review recorded inventory movements.
- Low-stock monitoring: Identify products that need replenishment.
- Reports: Review inventory and stock information.
- Responsive interface: Bootstrap-based layouts for desktop and smaller screens.
- Database persistence: Store application data in MySQL using Entity Framework Core.
🖼️ Application Screenshots
Add your own screenshots to docs/screenshots/ using the filenames shown below. GitHub will render the images once the files are committed. These image links are placeholders until you add the screenshots.

Dashboard

Product List

Add Product

Stock Movement

Reports

🧰 Technologies Used
Technology	Purpose
C#	Application programming language
ASP.NET Core MVC	Web application framework and MVC structure
Entity Framework Core	Object-relational mapping and database access
MySQL	Relational database
Bootstrap	Responsive user interface styling
HTML and CSS	Page structure and presentation
JavaScript	Client-side interactions where used
.NET SDK	Build and run the application


🏗️ Application Structure
The project follows the ASP.NET Core MVC pattern:
- Models: Represent application entities and data.
- Views: Render the user interface using Razor views.
- Controllers: Handle requests and coordinate application actions.
- Data / DbContext: Configure Entity Framework Core database access.
- Migrations: Track database schema changes.
- wwwroot: Contains static assets such as CSS, JavaScript, and images.
Exact folder names may vary depending on the current project structure.

⚙️ Prerequisites
Install the following before running the application:
- .NET 8 SDK
- MySQL Server
- A code editor such as Visual Studio or Visual Studio Code
- Git, if you want to clone the repository
🚀 Getting Started
1. Clone the repository
git clone https://github.com/Abhiraj14206/Inventory-Stock-Management-System.git
cd Inventory-Stock-Management-System
2. Configure the database connection
Open appsettings.json and configure the connection string for your local MySQL server. Example format:
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3306;database=inventory_stock_db;user=YOUR_MYSQL_USER;password=YOUR_MYSQL_PASSWORD;"
  }
}
Use the connection-string key expected by your project if it differs from DefaultConnection. Replace the example username and password with your local credentials. Never commit real passwords, API keys, or other secrets to GitHub.
3. Restore dependencies
dotnet restore
4. Apply Entity Framework Core migrations
If the repository contains migrations, run:
dotnet ef database update
If the dotnet ef command is unavailable, install the EF Core CLI tool compatible with the project's Entity Framework Core version. If no migrations are included, create the initial migration only after checking the project's existing database configuration:
dotnet ef migrations add InitialCreate
dotnet ef database update
Do not create a duplicate initial migration if migrations already exist.
5. Run the application
dotnet run
Open the local URL printed in the terminal, for example http://localhost:5000 or the HTTPS URL shown by the application. The actual port may differ by configuration.
🗃️ Database
The application is configured to use a MySQL database named inventory_stock_db in the development setup. The project includes inventory-related entities for products, categories, and stock movements. EF Core migrations are used to create or update the schema when migrations are present.
📸 How to Add Screenshots to This README
1. Run the application locally.
2. Capture screenshots of the dashboard, product list, Add Product page, stock movement page, and reports page.
3. Create a folder named docs/screenshots in the repository root.
4. Save the screenshots with these exact names:
   - dashboard.png
   - products.png
   - add-product.png
   - stock-movement.png
   - reports.png
5. Commit the images and README:
git add README.md docs/screenshots
git commit -m "Add project README and screenshots"
git push
If a page is not implemented in your version, remove its screenshot entry rather than adding a misleading image.
🔒 Security Notes
- Keep local database passwords out of source control.
- Use placeholder values in documentation and sample configuration.
- Review appsettings.json and any environment-specific settings before making the repository public.
- This project is intended as an educational starter and should receive a security review before production use.
🚧 Scope and Future Enhancements
Possible future improvements include:
- User authentication and role-based authorization
- Supplier and purchase-order management
- Sales and invoice management
- Exportable reports
- Search, filtering, and pagination for large product lists
- Audit logging and stronger protection against simultaneous stock updates
- Automated tests and deployment configuration
These are suggested enhancements and may not be implemented in the current version.
🎓 Project Purpose
StockWise demonstrates how a web application can combine an MVC architecture, database-backed CRUD operations, stock validation, and a responsive interface to support basic inventory management workflows.
👨‍💻 Author
Abhiraj

GitHub: @Abhiraj14206
<p align="center">Made as a learning project using ASP.NET Core and MySQL.<

# Stationery Store Management System

A professional Windows Forms application designed for efficient management of a stationery store. The system supports inventory control, sales operations, user roles, and detailed reporting, all within a modern, fully localized right-to-left (Arabic) interface.

## Key Features

- **Secure Login & Roles**  
  Authentication system with role-based access for Admin and User accounts.

- **Product Management**  
  Add, update, delete, and search products with filtering by category and price.

- **Category Organization**  
  Manage product categories to streamline inventory navigation.

- **Sales & Invoicing**  
  Process sales through a cart system with real-time inventory updates and invoice generation.

- **Reports & Analytics**  
  Generate, view, and print detailed sales and revenue reports by custom date range.

- **User Administration**  
  Admins can manage user accounts, including creation and role assignment.

- **Dashboard Overview**  
  Interactive dashboard displaying product counts, stock levels, revenue, and sales performance.

- **Right-to-Left Interface**  
  Modern UI design fully tailored for Arabic users, offering a natural and intuitive experience.

## Login Screen

Below are screenshots of the login screen:

![Login Screen 1](assets/login-1.png)
![Login Screen 2](assets/login-2.png)
![Login as admin ](assets/login-3.png)
![Login as user  ](assets/login-4.png)

## Home Screen

Below is a screenshot of the home screen:

![Home Screen 1](assets/home-1.png)

## Sell Screen

Below are screenshots of the sell screen:

![Sell Screen 1](assets/sell-1.png)
![Sell Screen 2](assets/sell-2.png)
![Sell Screen 3](assets/sell-3.png)
![Sell Screen 4](assets/sell-4.png)
![Sell Screen 5](assets/sell-5.png)
![Sell Screen 6](assets/sell-6.png)
![Sell Screen 7](assets/sell-7.png)

## Category Screen

Below are screenshots of the category screen:

![Category Screen 1](assets/category-1.png)
![Category Screen 2](assets/category-2.png)
![Category Screen 3](assets/category-3.png)
![Category Screen 4](assets/category-4.png)

## Product Screen

Below are screenshots of the product screen:

![Product Screen 1](assets/product-1.png)
![Product Screen 2](assets/product-2.png)
![Product Screen 3](assets/product-3.png)
![Product Screen 4](assets/product-4.png)
![Product Screen 5](assets/product-5.png)

## Reports Screen

Below are screenshots of the reports screen:

![Reports Screen 1](assets/report-1.png)
![Reports Screen 2](assets/report-2.png)
![Reports Screen 3](assets/report-3.png)

## Users Screen

Below is a screenshot of the users screen:

![Users Screen 1](assets/user-1.png)

## Backup

Below is the backup icon used in the application:

![Backup Icon](Resources/Data-Database-Backup-icon.png)

## Technology Stack

- **.NET 8.0** – Windows Forms  
- **C#** – Application logic and structure  
- **Entity Framework Core** – ORM for SQL Server or SQLite  
- **Microsoft.Data.Sqlite** – Lightweight optional database support

## Project Structure

- `Entities/` – Core data models (User, Product, Category, Order, OrderItem)  
- `Forms/` – Application interface forms (Login, Home, Products, Sales, Reports, etc.)  
- `Data/` – Entity Framework DbContext and data operations  
- `Migrations/` – EF Core migration files  
- `Resources/` – Icons, images, and localization assets

## Getting Started

### Requirements

- Windows 10 or 11  
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)  
- SQL Server (default) or SQLite

### Setup Instructions

1. **Clone the Repository**
   ```bash
   git clone <your-repo-url>


# 🏪 Business Management System

A comprehensive desktop-based management system designed specifically for stationery shops and small retail businesses. Built with **C# Windows Forms** and **SQLite**, this application provides an intuitive interface for managing products, sales, inventory, and generating detailed reports.

![Project Logo](assets/management.ico)

## 📋 Table of Contents

- [Features](#-features)
- [Screenshots](#-screenshots)
- [Technology Stack](#-technology-stack)
- [Installation](#-installation)
- [Usage](#-usage)
- [Project Structure](#-project-structure)
- [Database Schema](#-database-schema)
- [Contributors](#-contributors)
- [License](#-license)

## ✨ Features

### 🔐 User Management
- **Dual Role System**: Admin and Regular User roles with different permissions
- **Secure Login**: Password-protected access to the system
- **User Management**: Add, edit, and manage user accounts

### 📦 Product Management
- **Product Catalog**: Complete product database with categories
- **Inventory Tracking**: Real-time stock monitoring
- **Category Management**: Organize products by type and category
- **Product Details**: Comprehensive product information storage

### 🛒 Sales Management
- **Invoice Generation**: Create and manage sales invoices
- **Receipt Printing**: Print detailed receipts for customers
- **Sales History**: Track all sales transactions
- **Multi-Product Sales**: Add multiple items to a single invoice

### 📊 Reporting System
- **Sales Reports**: Detailed sales analysis and statistics
- **User Activity Reports**: Monitor user actions and system usage
- **Category Reports**: Product performance by category
- **Export Functionality**: Generate and export reports

### 🎨 User Interface
- **Modern Design**: Clean and intuitive Windows Forms interface
- **Responsive Layout**: Adapts to different screen sizes
- **Professional Appearance**: Business-ready visual design

## 📸 Screenshots

### Login Screen
![Login Screen](assets/screenshots/Screenshot%202025-06-18%20145252.png)
*Secure login interface with user authentication*

### Home Dashboard
![Home Dashboard](assets/screenshots/Screenshot%202025-06-18%20145409.png)
*Main dashboard with navigation to all system features*

### Product Management
![Product Management](assets/screenshots/Screenshot%202025-06-18%20145422.png)
*Product catalog management interface*

### Sales Interface
![Sales Interface](assets/screenshots/Screenshot%202025-06-18%20145450.png)
*Sales transaction and invoice creation*

### Category Management
![Category Management](assets/screenshots/Screenshot%202025-06-18%20145538.png)
*Product category organization and management*

### User Management
![User Management](assets/screenshots/Screenshot%202025-06-18%20145553.png)
*User account administration and role management*

### Reporting Dashboard
![Reporting Dashboard](assets/screenshots/Screenshot%202025-06-18%20145616.png)
*Comprehensive reporting and analytics interface*

### Invoice Generation
![Invoice Generation](assets/screenshots/Screenshot%202025-06-18%20145656.png)
*Professional invoice creation and printing*

### Product Details
![Product Details](assets/screenshots/Screenshot%202025-06-18%20145711.png)
*Detailed product information and editing*

### Multi-Product Sales
![Multi-Product Sales](assets/screenshots/Screenshot%202025-06-18%20145719.png)
*Adding multiple products to sales transactions*

## 🛠️ Technology Stack

- **Programming Language**: C# (.NET Framework)
- **UI Framework**: Windows Forms
- **Database**: SQLite (Embedded)
- **IDE**: Visual Studio
- **Version Control**: Git
- **Platform**: Windows Desktop Application

## 📦 Installation

### Prerequisites
- Windows 10/11 or Windows Server 2016+
- .NET Framework 4.7.2 or higher
- Visual Studio 2019/2022 (for development)

### Setup Instructions

1. **Clone the Repository**
   ```bash
   git clone https://github.com/AlaaAyesh/windows-Application.git
   cd windows-Application
   ```

2. **Open in Visual Studio**
   - Open `Stationery_Store.sln` in Visual Studio
   - Restore NuGet packages if prompted

3. **Build and Run**
   - Press `F5` or click "Start Debugging"
   - The application will launch and create the database automatically

4. **First Time Setup**
   - Default admin credentials will be created
   - Follow the on-screen instructions to set up your account

## 🚀 Usage

### Getting Started
1. **Login**: Use your credentials to access the system
2. **Navigate**: Use the main menu to access different features
3. **Add Products**: Start by adding your product catalog
4. **Create Categories**: Organize products into categories
5. **Process Sales**: Begin managing sales transactions
6. **Generate Reports**: Monitor your business performance

### Key Workflows

#### Product Management
1. Navigate to "Products" from the main menu
2. Click "Add New Product" to create product entries
3. Fill in product details (name, price, category, stock)
4. Save and manage your product catalog

#### Sales Processing
1. Go to "Sales" section
2. Select products to add to the invoice
3. Adjust quantities and prices as needed
4. Complete the sale and print receipt

#### Reporting
1. Access "Reports" from the main menu
2. Select the type of report you need
3. Set date ranges and filters
4. Generate and export reports

## 📁 Project Structure

```
Business-Management/
├── Stationery_Store/
│   ├── Forms/                 # Windows Forms UI
│   │   ├── LoginForm.cs      # User authentication
│   │   ├── HomeForm.cs       # Main dashboard
│   │   ├── ProductsForm.cs   # Product management
│   │   ├── Sell.cs           # Sales interface
│   │   ├── Report.cs         # Reporting system
│   │   └── ...
│   ├── Entities/             # Data models
│   │   ├── Product.cs        # Product entity
│   │   ├── User.cs           # User entity
│   │   ├── Order.cs          # Sales order entity
│   │   └── Context.cs        # Database context
│   ├── Data/                 # Database files
│   ├── Resources/            # Application resources
│   └── Scripts/              # Data import/export scripts
├── assets/                   # Project assets
│   ├── screenshots/          # Application screenshots
│   └── management.ico        # Application icon
└── Stationery_Store.sln      # Visual Studio solution
```

## 🗄️ Database Schema

The application uses SQLite with the following main entities:

- **Users**: User accounts and authentication
- **Products**: Product catalog and inventory
- **Categories**: Product categorization
- **Orders**: Sales transactions
- **OrderItems**: Individual items in sales orders

## 👥 Contributors

This project was developed as a collaborative effort:

- **Ahmed Khaled Noor-Elhady** - Lead Developer
- **Ahmed Khaled Sayed** - Backend Development
- **Mahmoud AbdelGhany** - UI/UX Design
- **Mahmoud Ali** - Database Design
- **Alaa Ayash** - Testing & Quality Assurance
- **Marawan Abdeen** - Documentation

**Supervisor**: Merihan Mohamed - Information Technology Institute (ITI)

## 📄 License

This project is proprietary software developed for a paid client. All rights reserved by the developers and the client.

---

## 🤝 Support

For technical support or questions about the Business Management System, please contact the development team.

---

*Built with ❤️ for efficient business management* 
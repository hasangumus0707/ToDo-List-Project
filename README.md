# 📝 ToDo List Web Application

A modern, responsive web application built with ASP.NET Core MVC that allows users to manage their todo tasks efficiently. Features a clean interface, real-time updates, and mobile-friendly design.

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blue)
![SQLite](https://img.shields.io/badge/SQLite-Database-green)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.x-purple)
![jQuery](https://img.shields.io/badge/jQuery-AJAX-orange)

## ✨ Features

- **Full CRUD Operations**: Create, Read, Update, and Delete todo items
- **Real-time Updates**: AJAX-powered interface for seamless user experience
- **Responsive Design**: Mobile-first approach with Bootstrap framework
- **SQLite Database**: Lightweight, serverless database solution
- **Input Validation**: Client-side and server-side validation
- **Clean UI**: Modern, intuitive user interface
- **Text Wrapping**: Handles long todo texts gracefully on all screen sizes


## 🛠️ Tech Stack

### Backend
- **ASP.NET Core MVC 8.0** - Web framework
- **Entity Framework Core 9.0.8** - ORM (Optional - using raw SQL for direct database access)
- **SQLite** - Database engine
- **Microsoft.Data.Sqlite** - Database provider

### Frontend
- **Bootstrap 5.x** - CSS framework for responsive design
- **jQuery** - JavaScript library for AJAX operations
- **Razor Views** - Server-side rendering
- **CSS3** - Custom styling and responsive design

### Development Tools
- **.NET 8.0** - Runtime environment
- **C#** - Programming language
- **HTML5** - Markup language
- **JavaScript** - Client-side scripting

## 🚀 Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Git (for cloning the repository)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/hasangumus0707/ToDo-List-Project.git
   cd ToDo-List-Project
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Access the application**
   - Open your browser and navigate to `http://localhost:5247`
   - The SQLite database will be created automatically on first run

## 📁 Project Structure

```
ToDoList/
├── Controllers/
│   └── HomeController.cs          # Main controller handling CRUD operations
├── Models/
│   ├── TodoItem.cs               # Todo item entity
│   ├── TodoViewModel.cs          # View model for data binding
│   └── ErrorViewModel.cs         # Error handling model
├── Views/
│   ├── Home/
│   │   └── Index.cshtml          # Main todo list view
│   └── Shared/
│       ├── _Layout.cshtml        # Main layout template
│       ├── _Form.cshtml          # Todo form partial view
│       └── Error.cshtml          # Error page
├── wwwroot/
│   ├── css/
│   │   └── site.css              # Custom styles and responsive design
│   ├── js/
│   │   └── site.js               # AJAX functions and client-side logic
│   └── lib/                      # Third-party libraries (Bootstrap, jQuery)
├── Data/
│   └── ApplicationDbContext.cs    # Entity Framework context (optional)
├── Properties/
│   └── launchSettings.json       # Development settings
├── Program.cs                     # Application entry point
├── ToDoList.csproj               # Project configuration
└── db.sqlite                     # SQLite database (auto-generated)
```

## 🎯 Key Features Details

### CRUD Operations
- **Create**: Add new todo items with validation
- **Read**: Display all todos in a responsive table format
- **Update**: Edit existing todos inline with AJAX
- **Delete**: Remove todos with confirmation

### Database Design
```sql
-- SQLite Table Structure
CREATE TABLE todo (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL
);
```

### AJAX Functionality
- **Non-blocking operations**: All CRUD operations use AJAX for smooth UX
- **Real-time updates**: Page updates without full reload
- **Error handling**: Graceful error management

### Responsive Design
- **Mobile-first approach**: Optimized for mobile devices
- **Flexible grid system**: Bootstrap responsive classes
- **Text wrapping**: Long texts break appropriately
- **Touch-friendly buttons**: Optimized button sizes for mobile

## 📱 Screenshots
![image alt](https://github.com/hasangumus0707/ToDo-List-Project/blob/79349899fd210f53ba1fc4c4d04616cac27e851a/Screenshot%20from%202025-08-07%2009-27-52.png)

### Desktop View
- Clean, modern interface with table layout
- Action buttons for each todo item
- Responsive form for adding new items

### Mobile View
- Optimized for touch interaction
- Compressed layout for smaller screens
- Maintained functionality across all devices

## 🔧 Configuration

### Database Connection
The application uses SQLite with the connection string defined in the controller:
```csharp
"Data Source=db.sqlite"
```

### Development Settings
- **HTTP Port**: 5247
- **HTTPS Port**: 7247 (if HTTPS is configured)
- **Environment**: Development

## 🌟 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/` | Display todo list |
| POST | `/Home/Insert` | Create new todo |
| POST | `/Home/Delete` | Delete todo (AJAX) |
| GET | `/Home/PopulateForm` | Get todo for editing (AJAX) |
| POST | `/Home/Update` | Update existing todo |

## 🛡️ Security Features

- **Parameterized Queries**: Protection against SQL injection
- **Input Validation**: Server-side and client-side validation
- **CSRF Protection**: Built-in ASP.NET Core protection
- **Safe HTML Encoding**: Automatic XSS protection

## 🔄 Future Enhancements

- [ ] User authentication and authorization
- [ ] Todo categories and tags
- [ ] Due dates and reminders
- [ ] Task priority levels
- [ ] Search and filter functionality
- [ ] Export/Import features
- [ ] Dark mode theme
- [ ] API endpoints for mobile app integration

## 🤝 Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

## 👨‍💻 Author

**Hasan Gumus**
- GitHub: [@hasangumus0707](https://github.com/hasangumus0707)
- Gmail : gumushasan764@gmail.com

## 🙏 Acknowledgments

- Bootstrap team for the excellent CSS framework
- jQuery team for the JavaScript library
- Microsoft for ASP.NET Core framework
- SQLite team for the lightweight database engine

---

⭐ Don't forget to give this project a star if you found it helpful!

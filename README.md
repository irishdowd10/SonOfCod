# SonOfCod
### John Dowd, August 11th, 2017

## Description
This is a site where ALL users can:  visit a home page, contact page, about page and signup for a news letter. In addition the site
allows a ADMIN user to view all subscribers. 

## Setup

* [Visual Studio 2017]https://www.visualstudio.com/downloads/
* [Microsoft SQL Server]https://www.microsoft.com/en-in/sql-server/sql-server-downloads

1. Clone this repository
2. Open your console program(Terminal, Powershell, etc.)
3. In your console, navigate to `\SonOfCod\src\SonOfCod` inside the cloned project folder.
4. Run this command: `dotnet ef migrations add Initial` 
4. Run `dotnet ef database update` in your console to migrate the app's database.
5. Run the database script (sql file) if you want the example data rather than having to add your own.
6. Open the SonOfCod.sln in Visual Studio. 
7. Start the local server by hitting the play button.


## Built With

* C#
* ASP.NET Core MVC
* Microsoft SQL Server
* Entity Framework
* CSS

## Similar Site


## License

This project is licensed under the MIT License

Copyright (c) John Dowd, 2017

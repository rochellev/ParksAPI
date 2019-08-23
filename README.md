# Parks API
### By Rochelle Roberts
-----

## Description
* Custom API featuring state and national parks in Washington. Additionally, I created a MVC Web app to consume ParksAPI.

## Technologies Used
* C#/.NET
* ASP.NET Core Web API
* ASP.NET Core MVC Web App
* HTML
* MySQL
* Entity
* Postman
* Swagger

## Installation
* Follow the following steps using the terminal
* After running project, go to http://localhost:5000

```sh
$ git clone https://github.com/rochellev/ParksAPI.git
$ cd ParksAPI
$ dotnet restore
$ dotnet ef database update
$ dotnet run
```

## API Features
* Full CRUD functionality
  * Developed Create, Read, Update, Delete endpoints
* MySQL Database
  * Parks Table
  * Data containing a park's name, state or national status, and city
  * Migrations used to maintain the tables
* Swagger
  * Provides clear documentation of the endpoints of the ParksAPI
  * https://localhost:5001/swagger/index.html
  * JSON Schema in swagger.json 
* MVC Client App 
  * Consumes ParksAPI
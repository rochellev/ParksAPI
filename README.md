# Parks API
### By Rochelle Roberts
-----

## Description
* Custom API featuring state and national parks in Washington. Additionally, I created a MVC Web app to consume ParksAPI.

## Technologies Used
* C#/.NET
* ASP.NET Core Web API
* ASP.NET Core Web App MVC
* HTML
* MySQL
* Entity
* Postman
* Swagger

## Installation for API
* Follow these steps using the terminal
* You must run the API before the web app

```sh
$ git clone https://github.com/rochellev/ParksAPI.git
$ cd ParksAPI
$ dotnet restore
$ dotnet ef database update
$ dotnet run
```

## Installation for Web App
* Follow these steps using the terminal, after running the api
* After running project, go to http://localhost:5003

```sh
$ git clone https://github.com/rochellev/ParkFinder.Solution.git
$ cd ParkFinder.Solution/ParkFinder
$ dotnet restore
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




* trying to do token stuff
# ToDoList

A RESTful API for a to-do list application. This API allows users to manage their tasks, including creating, updating, and deleting tasks.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET Core 7.0
- Visual Studio or Visual Studio Code

### Installing

1. Clone the repository to your local machine:

    ```powershell
    git clone https://github.com/prateekchaplot/ToDoList.git
    ```

1. Open the solution in Visual Studio or Visual Studio Code.

1. Restore the NuGet packages.

    ```powershell
    dotnet restore
    ```

1. Build the solution.

    ```powershell
    dotnet build
    ```

<!-- 1. Update the connection string in the appsettings.json file to point to your local SQL Server instance.

1. Run the Update-Database command in the Package Manager Console to create the database. -->

5. Start the application and test the API using a tool such as Postman.

    ```powershell
    dotnet run --project .\ToDoList.API\ToDoList.API.csproj
    ```

## Endpoints

The following endpoints are available:

- `GET /tasks`: Retrieve a list of all tasks.
- `GET /tasks/{id}`: Retrieve a specific task by its ID.
- `POST /tasks`: Create a new task.
- `PUT /tasks/{id}`: Update an existing task.
- `DELETE /tasks/{id}`: Delete a task.


## Run with Docker

1. To build & run docker image locally, use following commands:

```powershell
docker-compose build
docker-compose up
```

## Built With

- .NET Core 7.0
- ASP.NET Core Web API
- Entity Framework Core
<!-- - SQL Server -->

## Author

[Prateek Chaplot](https://github.com/prateekchaplot/)
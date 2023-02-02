# ToDoList

[![.NET](https://github.com/prateekchaplot/ToDoList/actions/workflows/dotnet.yml/badge.svg?branch=master)](https://github.com/prateekchaplot/ToDoList/actions/workflows/dotnet.yml)

A RESTful API for a to-do list application. This API allows users to manage their tasks, including creating, updating, and deleting tasks.

## Prerequisites

- Docker

## Endpoints

The following endpoints are available:

- `GET /tasks`: Retrieve a list of all tasks.
- `GET /tasks/{id}`: Retrieve a specific task by its ID.
- `POST /tasks`: Create a new task.
- `PUT /tasks/{id}`: Update an existing task.
- `DELETE /tasks/{id}`: Delete a task.


## Run on local machine with Docker

1. To build and run docker image locally, use following commands:

```powershell
docker-compose build
docker-compose up
```

## Built With

- .NET Core 7.0
- ASP.NET Core Web API
- Entity Framework Core
- SQLite

### Notes

1. To add migration via powershell -

    ```powershell
    PS> $env:ASPNETCORE_ENVIRONMENT='Production'
    dotnet ef migrations add Init --project ..\ToDoList.Data\ToDoList.Data.csproj
    ```

1. To run on `PRODUCTION` environment:
    - Update `ASPNETCORE_ENVIRONMENT=Production` in `docker-compose.yml` file.
    - Then, build and run.

## Author

[Prateek Chaplot](https://github.com/prateekchaplot/)

## Future Improvements

- Add authentication
- Move db (sqlite) to separate container
- Add load balancer (nginx) scale application
- Add cache (redis) to improve db reads
- Deploy service to api hosting service (vercel)

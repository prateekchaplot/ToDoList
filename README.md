# ToDoList

A RESTful API for a to-do list application. This API allows users to manage their tasks, including creating, updating, and deleting tasks.

### Prerequisites

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
<!-- - SQL Server -->

## Author

[Prateek Chaplot](https://github.com/prateekchaplot/)
# Task Management API

A RESTful API built with .NET 6 and ASP.NET Core, demonstrating CRUD operations for task management.

## Tech Stack
- .NET 6 / ASP.NET Core
- C#
- Swagger / OpenAPI

## Endpoints
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /tasks | Get all tasks |
| GET | /tasks/{id} | Get task by ID |
| POST | /tasks | Create a new task |
| PUT | /tasks/{id} | Update a task |
| DELETE | /tasks/{id} | Delete a task |

## Run Locally
```bash
dotnet run
```
Then open https://localhost:7039/swagger to explore the API.

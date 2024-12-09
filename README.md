# Film Management Software

## Project Overview
This project is a simple **ASP.NET Core Web API** application designed for managing films and directors in a film library. It demonstrates core concepts such as routing, controllers, dependency injection, Entity Framework Core, model validation, and authentication.

---

## Entities and Properties

### Film
- **FilmId** (int) - Primary key.  
- **Title** (string, max length: 100) - Name of the film.  
- **Genre** (string, max length: 50) - Type of film (e.g., Action, Drama).  
- **ReleaseYear** (int) - Year of release.  
- **DirectorId** (int) - Foreign key referencing **Director**.  

### Director
- **DirectorId** (int) - Primary key.  
- **Name** (string, max length: 100) - Name of the director.  
- **Country** (string, max length: 50) - Country of origin.  

---

## Project Architecture Flow

### Layers
1. **Presentation Layer**  
   - ASP.NET Core Web API.  

2. **Business Logic Layer**  
   - Application services for core operations like validations.  

3. **Data Access Layer**  
   - Repository pattern implemented using **Entity Framework Core**.  

4. **Database**  
   - **SQLite** for simplicity.

### Components
- **Controllers**  
  Manage API endpoints (e.g., `/api/films`, `/api/directors`) and use dependency injection to access services.  

- **Services**  
  Contain business logic (e.g., adding a film, validating director existence).  

- **Repositories**  
  Abstract data access logic (e.g., `FilmRepository`, `DirectorRepository`) and interact with EF Core DbContext.  

- **Models**  
  Define the structure of entities and DTOs (Data Transfer Objects) for client-server communication.  

- **Database Context**  
  EF Core DbContext manages database connections and entity configurations.  

---

## API Endpoints

| **Action**            | **HTTP Method** | **URL**              | **Description**                |
|------------------------|-----------------|----------------------|--------------------------------|
| Get all films          | GET             | /api/films           | Fetch all films               |
| Get film by ID         | GET             | /api/films/{id}      | Fetch a film by its ID        |
| Add a new film         | POST            | /api/films           | Add a new film                |
| Update a film          | PUT             | /api/films/{id}      | Update a film by its ID       |
| Delete a film          | DELETE          | /api/films/{id}      | Delete a film by its ID       |
| Get all directors      | GET             | /api/directors       | Fetch all directors           |
| Add a new director     | POST            | /api/directors       | Add a new director            |

---

## Features to Implement

1. **Model Validation**  
   - Use data annotations like `[Required]` and `[StringLength]` to validate inputs.

2. **Dependency Injection**  
   - Inject services and repositories into controllers.

3. **Authentication**  
   - Add JWT authentication for secured endpoints.

4. **Database**  
   - Use SQLite with migrations via EF Core.

5. **Error Handling**  
   - Implement middleware to handle global exceptions gracefully.

6. **Swagger**  
   - Document the API for easier testing and usage.

7. **Versioning**  
   - Introduce API versioning (e.g., `/api/v1/films`).

---

## Entity Relationship
- **One-to-Many Relationship**  
  - A **Director** can direct many **Films**.  
  - A **Film** can have only one **Director**.  

---

## Getting Started

### Prerequisites
- .NET SDK installed.
- SQLite installed (or use the built-in support in EF Core).

### Running the Application
1. Clone the repository.  
2. Run `dotnet restore` to install dependencies.  
3. Use `dotnet ef migrations add InitialMigration` and `dotnet ef database update` to set up the database.  
4. Run the project using `dotnet run`.

### Testing the API
- Use Swagger UI at `/swagger` for testing endpoints.  
- Alternatively, use tools like Postman or curl.

---

## License
This project is licensed under the MIT License.

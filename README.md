# Game Store RESTful API

This repository contains a simple RESTful API for a game store. The project follows standard REST and .NET best practices, incorporating techniques such as asynchronous programming, dependency injection, and inversion of control.

## General Structure

### Genres

Genres are preloaded into the database when the application runs for the first time through the `GameStoreContext`. Additional genres can be added in the same file or modified according to the user's preference.

### Games

The API provides full CRUD (Create, Read, Update, Delete) operations for games. When creating a new game, the request must follow the API contract:

```json
{
    "name": "Death Stranding 2",
    "genreId": 2,
    "price": 59.99,
    "releaseDate": "2025-06-26"
}
```
> Example request body for creating a new game.

## Technologies Used

- **.NET 8** – The latest version of the .NET framework, ensuring modern features and performance improvements.
- **Entity Framework Core** – For database interactions and object-relational mapping (ORM).
- **Dependency Injection** – To promote modularity and testability.
- **Asynchronous Programming** – To improve efficiency and responsiveness.

## Installation & Usage

1. **Clone the repository**:
   ```sh
   git clone https://github.com/kaelkkd/rest-game-store-api.git
   cd game-store-api
   ```

2. **Restore dependencies**:
   ```sh
   dotnet restore
   ```

3. **Run the application**:
   ```sh
   dotnet run
   ```

4. The API will be available at the port set on `launchSettings.json` (or another configured port).

## Endpoints

### Games

- **GET /api/games** – Retrieves a list of all games.
- **GET /api/games/{id}** – Retrieves a specific game by its ID.
- **POST /api/games** – Creates a new game.
- **PUT /api/games/{id}** – Updates an existing game.
- **DELETE /api/games/{id}** – Deletes a game by its ID.

### Genres

- **GET /api/genres** – Retrieves a list of all genres.

## Notes

- This project is built using **.NET 8**, and updating dependencies may cause compatibility issues.
- Database migrations may be required when modifying the entity structure.
- The database can also be changed to another SQL service, but be aware of the dependency compatibility with **.NET 8**.




# .NET Web API with Dapper Demo

This repository contains a .NET Web API project showcasing the use of Dapper as the Object-Relational Mapping (ORM) tool for interacting with a SQL Server database. The API manages products using CRUD operations.

## Project Structure

The project structure follows a typical ASP.NET Web API pattern, and Dapper is used for data access.

- **Controllers:**
  - `ProductController`: Manages CRUD operations for products.

- **Models:**
  - `Product`: Represents a product entity.

## API Endpoints

### 1. Get All Products

- **Endpoint:** `GET /api/Product`
- **Description:** Retrieve a list of all products.
- **Response:** Array of products.

### 2. Add Product

- **Endpoint:** `POST /api/Product`
- **Description:** Add a new product.
- **Request Body:** JSON representing the new product.
- **Response:** OK with the added product details.

### 3. Remove Product

- **Endpoint:** `DELETE /api/Product`
- **Description:** Remove a product by ID.
- **Request Body:** JSON representing the product to be removed.
- **Response:** OK with a message indicating that the product is deleted.

## How to Run

1. Clone this repository.
2. Set up a SQL Server or another compatible database and update the connection string in `appsettings.json`.
3. Run the application using Visual Studio or `dotnet run`.
4. Test the API using a tool like [Postman](https://www.postman.com/) or [Swagger](https://swagger.io/).


## Dependencies

- ASP.NET Core
- Dapper
- Microsoft.Extensions.Configuration
- Microsoft.Data.SqlClient

Feel free to customize and extend this project based on your specific requirements. For any issues or improvements, please create an issue or submit a pull request.

Happy coding!

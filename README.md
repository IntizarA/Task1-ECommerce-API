<!-- ECommerce Web API Project -->

# <b><i>Task 1 ECommerce</i></b>

This project is an ECommerce web application developed using .NET Core 6. It provides endpoints for managing products, customers, orders, and order details.

## Table of Contents

1. [Introduction](#introduction)
2. [Technologies Used](#technologies-used)
3. [Features](#features)
4. [Folder Structure](#folder-structure)
5. [Setup](#setup)
6. [Usage](#usage)
    - [Authentication](#authentication)
    - [Testing Authorized Methods](#testing-authorized-methods)
7. [Validation](#validation)

## Introduction

The ECommerce Web API project is designed following the Onion Architecture, which emphasizes separation of concerns and dependency inversion. It helps for managing various aspects of an ECommerce system, including products, customers, and orders.

## Technologies Used

- .NET Core
- Entity Framework Core (EF Core)
- SQLite3
- MediatR
- JSON Web Tokens (JWT)
- Repository Pattern
- CQRS Pattern
- Onion Architecture

## Features

- CRUD operations for products, customers, orders, and order details.
- Repository pattern for database operations.
- Services with Data Transfer Objects (DTOs) for better abstraction.
- CQRS pattern for separating command and query responsibilities.
- Authentication using JWT for secure access to protected endpoints.
- Middleware for generating and validating JWT tokens.
- Validation middleware with MediatR pattern for request validation.

## Folder Structure

Core/

│ ├── Domain/ # Contains domain entities

│ └── Application/ # Contains application repositories, services and DTOs

Infrastructure/

│ ├── Infrastructure/ # Contains infrastructure-related logic

│ └── Persistence/ # Contains database context and migrations

Presentation/

│ └── API/ # Contains API controllers 



## Setup

1. Clone the repository.
2. Open the project in Visual Studio or your preferred IDE.
3. Restore NuGet packages.
4. Update the `appsettings.json` file with your database connection string.
5. Run the EF Core migrations to create the database schema and seed data.
6. Build and run the project.

## Usage

### Authentication

Authentication is performed using JWT tokens. After successful login, a JWT token is generated and returned to the client. This token must be included in the authorization header of all subsequent requests to access protected endpoints. The token contains information about the customer, including their ID, which is used for authorization and identification.

### Testing Authorized Methods

To test authorized methods using Postman, follow these steps:

1. **Obtain JWT Token:** Send a POST request to the login endpoint with valid credentials to obtain a JWT token. Save the token from the response.
2. **Use the Token:** In Postman, create or open a request and add the JWT token to the authorization header with the value "Bearer your_jwt_token", where "your_jwt_token" is the token obtained from the login request.
3. **Test Authorized Endpoints:** Use the configured request to access authorized endpoints. Ensure the authorization header with the JWT token is included in the request.
4. **Handle Responses:** Postman will display the response content, status codes, headers, etc., making it easy to analyze the results of your requests.

## Validation

Request validation is implemented using middleware with the MediatR pattern. Requests are validated before they reach the controller action. If validation fails, appropriate error messages are returned to the client.

## Database Table Relations

![db](https://github.com/IntizarA/Task1-ECommerce-API/assets/80961100/f3f10630-a2ea-45d2-8faf-5b99092e87dd)

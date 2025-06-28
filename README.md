# GraphQL API with .NET 7 and HotChocolate

This project is a simple, fully functional GraphQL API built with **.NET 7** and **HotChocolate**. It supports full **CRUD operations** on a `User` entity with proper input validations.

---

## Table of Contents
- [Features](#features)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
- [GraphQL Endpoints](#graphql-endpoints)
- [Example Queries](#example-queries)

---

## Features
- CRUD Operations on User model

---

## Technologies
- .NET 7
- HotChocolate GraphQL Server
- C#

---

## Getting Started

### Prerequisites
- .NET 7 SDK

### Setup
```bash
git clone https://github.com/techflow21/GraphqlTask
cd GraphqlTask
dotnet restore
```
### Run the API
```bash
dotnet run
```
Visit: `https://localhost:5001/graphql`

---

## Input Validations

- **Name:** Must be at least **3 characters long.**
- **Email:** Must be a valid email address.
- **Phone:** Must be between **7 to 15 digits**, optionally starting with a `+` (international format).

---

## GraphQL Endpoints
GraphQL Playground and API Endpoint.

## Example Queries

### Add User

```graphql
mutation {
  addUser(input: {name: "Bello Soliu", email: "bello@gmail.com", phone: "+2348123599166"}) {
    id
    name
    email
    phone
    createdAt
  }
}
```

### Update User

```graphql
mutation {
  updateUser(id: "USER_ID_HERE", input: {name: "Updated Name", email: "updated@gmail.com", phone: "+2347012345678"}) {
    id
    name
    email
    phone
    updatedAt
  }
}
```

### Delete User

```graphql
mutation {
  deleteUser(id: "USER_ID_HERE")
}
```

### Get All Users

```graphql
query {
  users {
    id
    name
    email
    phone
    createdAt
    updatedAt
  }
}
```

### Get User By ID

```graphql
query {
  userById(id: "USER_ID_HERE") {
    id
    name
    email
    phone
    createdAt
    updatedAt
  }
}
```

---

## ⚙️ Notes

- The API uses an **in-memory repository**, meaning data is lost when the application stops unless connected to a persistent database.



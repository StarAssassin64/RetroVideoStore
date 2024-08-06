### Final Project: Retro Video Store

#### Project Overview

You will create a retro rental video store web application using Blazor Server. The application will allow customers to view available movies (at least 8 movies must be listed), add movies to a cart, and place an order. The order information will be stored in a database. You must then have a way to view all existing orders from the database on another page.

#### Project Requirements

-   **Frontend Requirements:**

    -   A catalog page displaying available movies.
    -   Each movie should display a title, description, format (DVD or VHS), and an "Add to Cart" button.
    -   You need to use a fixed price for DVD rentals and another fixed priced for VHS rental. This fixed price is per media.
    -   A cart page displaying selected movies and an "Order" button to place the order.
-   **Backend Requirements:**

    -   A database to store movie details and orders.
    -   Models for movies and orders.
    -   Services to manage movie data and orders.
-   **Database Requirements:**

    -   A table for movies with columns: `Id`, `Title`, `Description`, `Format.`
    -   A table for orders with columns: `Id`, `CustomerName`, `CustomerEmail`, `OrderDate`, OrderID and `TotalPrice`.
    -   A table for order details with columns: `OrderId`, `MovieId`, and `Quantity`.
-   Display Page Requirments:
    -   A page to display all existing database information on orders and their details.
    -   Bonus Points: 8 bonus points if you can add a search filter to the page (Not something we've done in class)
-   Test Case:
    -   Demonstrate your ability to write and use test cases effectively by writing a minimum of 5 test cases
-   Project deployment using Render
    -   You will need to create a postgre database on render as well as a webservice.
    -   You will need to change your connection string for your database to your postgre service.
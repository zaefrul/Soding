# Soding
Simple application using ASP.NET MVC 4.5.2

This project basically for Task handling. These

### Model
This application consist of two model
  1. User
    - Id
    - Name
    - Email
  2. Task
    - Id
    - Name
    - UserId
    - DateCreated
    - DateModified
    
Every task should have one user assign and each user can have many task.

### Controller

With MVC framework, the controller for each model will have basic CRUD functionalities. The view is created during generation of the controller using a scaffolding method. Scaffolder will also set up the initial database, based on the Model that has been specified. To be specific, scaffolder generate the database using Entity Framework.
Each controller will have below action,
1.	Index
2.	Details
3.	Create as a Get Action
4.	Create as a Post Action
5.	Edit as a Get Action
6.	Edit as a Post Action
7.	Delete as a Get Action
8.	Delete as a Post Action



### View

View is needed to support each action in the controller. All views are structured properly to utilize all attributes added to the properties in model.

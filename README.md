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

### Controller & View

Each controller and view is generated using MVC 5 Controller with actions, using Entity Framework.

These means, all view and controller is scaffold according to the Model design.

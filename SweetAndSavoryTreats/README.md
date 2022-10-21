# Pierre's Sweet and Savory Treats

#### MVC Web Application: Many-To-Many Database Relationship 

#### By Helen Lehrer

## Description

An MVC application for a bakery that has user authentication and many-to-many relationship.
 
The User Can:

* Log in and log out. Only logged in users have create, update, and delete functionality. All users have read functionality.
* Select an flavor, see it's details, and see a list of all treats that belong to that flavor. They can also select a treat, see its details, and see a list of all flavors assigned to it.
* All data can be edited or deleted.
* Navigate to a splash page that lists all treats and flavors. They can click on an individual flavor or treat to see all the flavors/treats that belong to it.

Features:

* User authentification
* A splash page
* Many-to-Many database relationship
* Multiple controllers 
* Use of MySQL for database management
* GET and POST requests
* MVC routes follow RESTful conventions

## Technologies Used

* .NET 5.0.401
* C#
* MySQL
* Entity Framework Core 5.0.0
* Identity 5.0.0
* HTML/CSS

## Setup/Installation Requirements

Enter this command into your terminal to clone the project: 
```bash
$ git clone https://github.com/helen-lehrer/SweetAndSavoryTreats.Solution
```

Navigate from the root directory of the repo into the production folder `SweetAndSavoryTreats`:
```bash
$ cd SweetAndSavoryTreats
```

Restore dependencies and tools: 
```bash
$ dotnet restore
```

Compile the code: 
```bash
$ dotnet build
```

---

#### Database Import/Configuration:

* Download, install, and configure [MySQL](https://dev.mysql.com/downloads/installer/)

Navigate from the root directory of the repo into the production folder `SweetAndSavoryTreats`:
```bash
$ cd SweetAndSavoryTreats
```

Create a file called **appsettings.json**: 
```bash
$ touch appsettings.json
```

Add the following code to the **appsettings.json** file: 
```bash
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=helen_lehrer;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```

* Make sure to insert your MySQL username and password into the  **appsettings.json**  connection string

* Note that uid and pwd may vary depending on your MySql configurations.

Update your local MySQL database:
```bash
$ cd dotnet ef database update
```

---

#### To run the application: 

Navigate from the root directory of the repo into the folder `SweetAndSavoryTreats`:
```bash
$ cd SweetAndSavoryTreats
```

Run the application:
```bash
$ dotnet run
```

## Known Bugs

* none

## License
[![License](https://img.shields.io/badge/License-BSD_3--Clause-blue.svg)](https://opensource.org/licenses/BSD-3-Clause)

&copy; _Copyright 2022 Helen Lehrer_
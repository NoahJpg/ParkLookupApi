  # Parks Lookup API
  ### By: Noah Atkinson

  ## Table of Contents
- [Parks Lookup API](#parks-lookup-api)
      - [By: Noah Atkinson](#by-noah-atkinson)
  - [Technologies Used](#technologies-used)
  - [Description](#description)
    - [Setup Instructions](#setup-instructions)
      - [You Will Need:](#you-will-need)
      - [Preliminary Project Set-up:](#preliminary-project-set-up)
  - [Endpoints](#endpoints)
      - [Park Endpoints](#park-endpoints)
      - [Authentication Endpoints](#authentication-endpoints)
  - [Further Exploration](#further-exploration)
  - [Known Bugs](#known-bugs)
  - [License](#license)


## Technologies Used

* C#
* Razor HTML
* VS Code
* .Net 6
* API
* Swagger
* MySQL
* Entity Framework Core 6

## Description
An API that lists Name, State, and Type of National and State Parks. 

### Setup Instructions

#### You Will Need: 

* A code editor, such as [VS Code](https://code.visualstudio.com/)
* [Git](https://github.com/) installed
* [Install .Net 6 SDK:](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
* [Install MySqlWorkbench](https://www.mysql.com/products/workbench/) Follow installation instructions 


#### Preliminary Project Set-up:
1. Clone or download this repository to your machine.
2. Navigate to the local directory (YourPath/ParksLookupApi-main/ParksLookupApi) and create a new file "appsettings.json" and "appsettings.Developer.json".
3. Open "appsettings.json" in VS Code and add :
  ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```
4. Open "appsettings.Developer.json" in VS Code and add :
  ```
  {
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft": "Trace",
        "Microsoft.AspNetCore": "Information",
        "Microsoft.Hosting.Lifetime": "Information"
      }
    }
  }
  ```

**IMPORTANT:** Be sure to replace your username, password, and name of your database for the fields [YOUR-USER-HERE], [YOUR-PASSWORD-HERE], AND [YOUR-DB-NAME].

5. Create a .gitignore file and add "appsettings.json", "appsettings.*.json", "bin", and "obj" to the ignored file list.  
6. Open your shell (e.g., Terminal or GitBash) and add your .gitignore file and commit it before adding any other files. 
7. Navigate to this project's production directory called "ParksLookupApi". 
8. In the command line, run these commands in order
 * `$ dotnet tool install --global dotnet-ef --version 6.0.0` 
 * `$ dotnet ef database update` (Run this command anytime changes are made to the database)
 
9. Then, run the command `dotnet run` to compile and execute the console application. Optionally, you can run `dotnet build` to compile this console app without running it.
10. Run `dotnet watch run` in the command line to start the project in development mode with a watcher.
11. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Endpoints

#### Park Endpoints

* _api/parks_
* _api/parks{id}_

#### Authentication Endpoints

* _api/login_
* _api/user/admins_
* _api/user/sellers_
* _api/user/adminsandsellers_

## Further Exploration

* _Token Based Authentication_

* _In order to generate and check a unique user token based on role, do the following:_

1. Open or download [Postman](https://www.postman.com/downloads/)
2. Start the server in the project using `dotnet run`
3. Create a 'Post' request on Postman at this path: _https://localhost:5001/api/login_ 
using this information in the 'body' set to 'raw' and format type 'JSON':

* ```{"Username": "jason_admin", "Password": "MyPass_w0rd"}```
* If you want to create a token for the seller, not admin, use this instead:
* ```{"Username": "elyse_seller", "Password": "MyPass_w0rd"}```
* These are setup in the `UserConstants.cs` file.

4. Send the request and copy the long token it generates
5. Create a new 'Get' request on Postman one of the following paths accordingly:

* _https://localhost:5001/api/user/admins_
* _https://localhost:5001/api/user/sellers_
* _https://localhost:5001/api/adminsandsellers_

6. Select 'Authorization' and in 'Type' choose 'Bearer Token' from the drop down
7. Paste the token in the 'Token' field and send the request
8. If working, it will return: ```Hi Jason, you are an Administrator```
* or if you are testing the seller, it will return ```Hi Elyse, you are a Seller```


## Known Bugs

* _None_

## License

_If you have any issues or have questions, ideas or concerns please contact me at [noahatkinson1.1@gmail.com](mailto:noahatkinson1.1@gmail.com)_

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _2023_ _Noah Atkinson_
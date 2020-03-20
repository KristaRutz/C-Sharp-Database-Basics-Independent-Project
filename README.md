# User-Zine Relationship Tracker (C# Web Application)

#### A web-based application to organize users and zines, where the user can input new hires and create zines under the emoloyees, hosted on [GitHub](https://github.com/KristaRutz/C-Sharp-Database-Basics-Independent-Project). _Last Updated 03.13.2020._

#### By _**Krista Rutz**_

## Description

This application, utilizing an MVC framework, keeps track of users and their zines. Users can be added dynamically in a form, and zines can be listed under each user account. The app implements this with C#, .NET Core, and SQL.

This project uses SQL, Entity Framework, RESTful routing, the Razor View Engine, and MVC conventions. It was created for the Epicodus week 11 friday independent project, on week 4 of C# and .NET course: Database Basics.

The source code is hosted on [GitHub](https://github.com/KristaRutz/C-Sharp-Database-Basics-Independent-Project).

## Installation / Set-up

Download or clone the repository to run this program locally!

_This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._

_This program also makes use of SQL databases. We recommend using MySQL Workbench to build your databases. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) for installing MySQL WorkBench and MySQL Community Server on Mac or Windows 10._

- **Download or clone this repo.**
  - **To Download ZIP:**
    - Select "Download" on the [GitHub Repository](https://github.com/KristaRutz/C-Sharp-Database-Basics-Independent-Project) site
    - Once downloaded, open the ZIP and extract files. The new folder will be created as 'VendorList.Solution'.
  - **To Clone:**
    - Clone from command line into your Desktop: `$ git clone https://github.com/KristaRutz/C-Sharp-Database-Basics-Independent-Project.git`
    - The new directory will be created as 'Desktop/C-Sharp-Database-Basics-Independent-Project'.
- **Build your local databases.**
  - **To construct in the command line:**
    - run your MySQL server from the command line.
    - use the commands listed in the 'DataBaseSetUpInstructions.txt' file in the root directory of this project.
  - **To construct import from my file:**
    - Open MySQL Workbench. In the Navigator > Administration window, select Data Import/Restore.
    - In Import Options select Import from Self-Contained File.
    - Navigate to the sql file at 'DumpStructure.sql' in the root directory of this project.
    - Under Default Schema to be Imported To, select the New button.
    - Enter the desired name of your database. _The program is currently set to look for a database called 'zine_machine'. If you use a different name, you will need to change the connection string in appsettings.json to reflect this._
    - Click Ok.
    - Click Start Import.
    - Reopen the Navigator > Schemas tab. Right click and select Refresh All to see the database appear.
- **Once you have stored the files locally and built databases, execute the following commands.**
  - Navigate to the application directory: `$ cd VendorList.Solution/VendorList`
  - `dotnet build`
  - `dotnet run`
- **Upon success, the program will begin running on a local server.**

## Technologies Used

- C#
- .NET Core 2.2
- MySQL Server and MySQL Workbench
- Entity Framework
- HTML with Razor
- CSS: Custom and Bootstrap

## Specifications

- [x] Database table and column names follow both the specific requirements for this project and general .NET naming conventions.
- [x] Instructions for re-creating your database are thorough and clear.
- [x] There is a one-to-many relationship set up correctly in the database.
- [ ] CREATE functionality is included for one class and CREATE and VIEW functionality are included for the other class.
- [x] Entity is used for communication with the database
- [x] The project demonstrates understanding of this week's concepts.
- [x] The project is in a polished, portfolio-quality state.
- [x] Project uses two or more controllers.
- [x] GET and ZINE requests/responses are used successfully.
- [x] MVC routes follow RESTful conventions.
- [x] Logic is easy to understand.
- [x] Build files are included in .gitignore file and are not be tracked by Git
- [x] Code and Git documentation follows best practices (descriptive variables names, proper indentation and spacing, separation between front and back-end logic, detailed commit messages in the correct tense, and a well-formatted README).

## User Stories

| As a _User-Type_,                 | I want...                                                                                                              | so that...                                        |
| :-------------------------------- | :--------------------------------------------------------------------------------------------------------------------- | :------------------------------------------------ |
| As the site and database manager  | I want users that I add to be stored in a database                                                                     | so that I can access them as often as I need      |
| As the site and database manager, | I want to add new users                                                                                                | so that I can view the complete list              |  |
| As the salon owner,               | I need to be able to select a user, see their details, and see a list of all zines that belong to that user            | to stay organized                                 |
| As the site and database manager, | I want to see the zines belonging to those users                                                                       | to simplify payment accounts                      |
| As the salon owner,               | I need to be able to add new zines to a specific user (I should not be able to add a zine if no users have been added) | so that I don't have unassigned zines by mistake. |
| As the site and database manager, | I want name and preferred user for zines visible                                                                       | so that my tracker is useful from both sides      |
| As the site and database manager, | I want a splash page                                                                                                   | so that I can access any sides of my site         |
| As the site and database manager, | I want to be able to delete zines or users                                                                             | in case of changes to the business                |
| As the site and database manager, | I want to be able to edit zines or users                                                                               | in case of changes, or user error                 |

## Known Bugs

_No known bugs_

## Support and contact details

Please contact me if you run into any issues or have questions, ideas or concerns. I can be contacted at <krista.rutz@pomona.edu>. Feel free to fork and create pull requests for updates - _contributions to the code are encouraged!_

### License

Copyright (c) 2020 **_Krista Rutz_**

_This software is licensed under the MIT license._

<details>
  <summary>View license details</summary>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

</details>

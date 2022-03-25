# Factory

#### By **Brit Wallace**

#### Factory is a website that allows a factory manager to make a list of their engineers  and their machines. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines and a machine can have many engineers licensed to repair it. This information can be updated or deleted. This is a project that showcases a many to many relationship using a database. 

## Technologies Used

- C#
- ASP.Net Core
- ASP.NET MVC
- Entity Framework
- MySql Database

## Description

This application allows the user to view a list of engineers and see what machines they are licensed to repair. This application will also show a list of machines and the engineers that are qualified to work on them.  It will save these entries in persistent database files. There is functionality to add and delete machines and engineers as well.

Database Structure

![Database Structure Image](/Factory/wwwroot/images/DatabaseImage.jpg)

## Setup/Installation Requirements

1. If you don't already have C# and .NET installed on your computer, you can get the Software Development Kit or SDK for Mac here: Dot.Net for Mac and for Windows here: Dot.Net for Windows. Follow the instructions detailed in both links above for set up.
2. If not already installed, download: MySql Community
3. If not already installed, download: MySql Workbench
4. Follow the instruction here for configuring MySql:
5. Open the terminal on your local machine and navigate to where you want to clone the project
6. Run the following command: git clone https://github.com/BritWallace/Factory
7. Follow these steps to import the table needed for the project:
- Determine if the MySql server is running locally by typing the following into the command line mysql -uroot -p[The password you set up]
- Open MySql Workbench. Once open select the Administration tab. Next select Data Import/Restore. This opens up the Data Import window with the Import from Disk tab open. Select the radio button for Import from Self-Contained File. Click the button with the three dots (if on windows) or two dots (if on mac) at the end of the path field. This will open a window to search for the sql dump file on your local disk. Navigate to the root directory of the cloned project and select brit_wallace.sql and click the open button. Next, press the New... button. This will open a window where you can choose the name of the imported schema. Choose a name appropriate to the project, e.g. factory and click Okay We'll need this name later when setting up the project to work with this schema. If on a mac, click the Start Import button. If on a windows machine, switch to the Import Progress tab on the Data Import page. Click the Import button. Finally, re-click on the Schemas tab. Right-click in the Schemas window, and select Refresh All. The imported schema should now be listed.
8. Navigate back to the Factory/ directory and create a file named: appsettings.json. In this file, add the following configuration to set up the project to work with the schema you imported:
{gb
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[THE-NAME-YOU-CHOSE-WHEN-IMPORTING-THE-SCHEMA];uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
9. As an alternative to importing the database with MySql Workbench, you can install dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0 on the command line in the Factory main directory.
10. In the Factory main directory run dotnet build on the command line to check for errors
11. Next run $ dotnet ef migrations add Initial. Note when making changes to the schema (i.e. making changes in the models that affect the database such as adding a new attribute, you would change "Initial" to something more descriptive of what change you are making to the table.
12. Next Run: $ dotnet ef migrations add Initial
13. Run: $ dotnet ef database update
 This will update the data base tables.
14. Run: $ dotnet build again to make sure there are no errors.
15. Run: $ dotnet run on the command line to start the web server
## Known Bugs

- _None at this time_

## Contact Me

Let me know if you run into any issues, questions, ideas, or concerns:
britwallace888@gmail.com

## License

Copyright (c) March 2022 Brit Wallace.


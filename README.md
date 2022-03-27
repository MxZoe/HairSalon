# Hair Salon

#### By _**Zoe Weinstein**_

#### A website that allows the user to add hair stylists and their clients

## Technologies Used

* SQL
* C#
* .Net
* Razor
* CSS
* HTML

## Description

This console application lets a user add stylists and then add clients to those individual clients. This program uses SQL tables with a one to many relationship for stylists to clients.
## Setup/Installation Requirements

* Must have mySQL workbench installed. You can download it from https://www.mysql.com/products/workbench/
* Go to https://github.com/MxZoe/HairSalon to clone or download the project. 
* You must then create a file named appsettings.json and add it to your .gitignore file
* The appsettings.json file should then have the following:
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
* Next you must import the zoe_weinstein.sql schema into mySQL workbench by doing th following:
    In the Navigator > Administration window, select Data Import/Restore.

    In Import Options select Import from Self-Contained File.

    Navigate to the file we just created.

    Under Default Schema to be Imported To, select the New button.

    Enter the name of your database with _test appended to the end.
    In this case zoe_weinstein_test.
    Click Ok.
    Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
* To use the program, go to the HairSalon folder and run "dotnet restore" followed by"dotnet run."
## Known Bugs
  None

## License

https://opensource.org/licenses/MIT

Copyright (c) 2022. Zoe Weinstein
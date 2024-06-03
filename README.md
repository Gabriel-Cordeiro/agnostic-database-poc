**Agnostic database PoC:
**
The main idea is creating a library to use in many other API in a multitenant project where the final customer can choose the best SQL database for their needs, like Postgres, SqlServer, MySql or Hana.

- Through your CLI access the Infrasctructure project
- Make sure EF Cli is installed in your computer
- For SqlServer migrations run: 
    dotnet ef migrations add InitialCreate --context SqlServerContext --output-dir Migrations/SqlServer
    dotnet ef database update --context SqlServerContext --connection "YourConnectionString"
- For MySQl migrations run: dotnet ef migrations add InitialCreate --context MySqlContext --output-dir Migrations/MySql
    dotnet ef migrations add InitialCreate --context MySqlContext --output-dir Migrations/MySql
    dotnet ef database update --context MySqlContext --connection "YourConnectionString"
- For Postgres
- For Hana
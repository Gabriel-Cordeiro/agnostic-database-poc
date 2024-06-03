**Agnostic database PoC:**

The main idea is to create a library that can be used in multiple APIs within a multitenant project, allowing the final customer to choose the best SQL database for their needs, such as Postgres, SQL Server, MySQL, or Hana.

Steps:

- Access the Infrastructure project through your CLI.
- Ensure EF CLI is installed on your computer.
- Run the appropriate commands for each database:

**For SQL Server migrations:**
- dotnet ef migrations add InitialCreate --context SqlServerContext --output-dir Migrations/SqlServer
- dotnet ef database update --context SqlServerContext --connection "YourConnectionString"

**For MySql migrations:**
- dotnet ef migrations add InitialCreate --context MySqlContext --output-dir Migrations/MySql
- dotnet ef database update --context MySqlContext --connection "YourConnectionString"

To be done:
**For Hana:**
**For Postgres:**

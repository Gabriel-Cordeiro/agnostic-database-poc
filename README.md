**MultiTenantHelper:**
This is a helper class with an extensible method, AddMultiTenantDbContext(). This method will check the database provider and the connection string, then register an instance of ApiDbContext for MySQL, SQL Server, Postgres, or Hana. The main idea is to use two keys in the JWT token:

{
  "sub": "1234567890",
  "name": "John Doe",
  "id": "1",
  "iat": 1516239022,
 **"provider"**: "1",
 **"connectionName"**: "client1"
}

Provider is a DatabaseProvider enum that indicates which database provider the method needs to instantiate.
ConnectionName specifies which connection string will be used (it could be set in app.settings or Key Vault).

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

**For Postgres:**
    dotnet ef migrations add InitialCreate --context PostgresContext --output-dir Migrations/Postgres
    dotnet ef database update --context PostgresContext --connection "YourConnectionString"

To be done:
**For Hana:**
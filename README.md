# C# Web API Project

Setup a quick api that talks to our neon instance

## Setup

- install-package Microsoft.EntityFrameworkCore
- install-package npgsql.entityframeworkcore.postgresql
- add an appsettings.json and ensure it contains your credentials:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnectionString": "Host=HOSTNAME; Database=DATABASENAME; Username=USERNAME; Password=PASSWORD;"
  }
}

```

- add a ``` dotnet new gitignore ``` and ensure it contains: 

```
*/**/bin/Debug   
*/**/bin/Release   
*/**/obj/Debug   
*/**/obj/Release   
/workshop.wwwapi/appsettings.json
/workshop.wwwapi/appsettings.Development.json
```

- your DataContext needs to look similar to this:
```cs
public class DataContext : DbContext
{
    private string _connectionString;
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString);
        optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console
    }
    public DbSet<Car> Cars { get; set; }
}
```


## SQL

The following SQL is required to setup the db: 
```


CREATE TABLE IF NOT EXISTS bottles
(
  id serial PRIMARY KEY,
  brand VARCHAR (255) NOT NULL
);

INSERT INTO bottles (brand)
VALUES
('Heineken'),
('Tuborg'),
('Norrlands Guld'),
('Staropramen'),
('Guinness');

```
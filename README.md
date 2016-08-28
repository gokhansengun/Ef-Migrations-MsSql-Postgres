# Setting up Migrations for MsSql and Postgres in the same Visual Studio Project

This example project shows enabling migrations for both MsSql and Postgres and adding a new migration for both of them using Entity Framework Code First Migrations.

Use the following instructions to generate Entity Framework migrations in order to obtain SQL scripts or update the Postgres and MsSql databases. 

## MsSql Migrations Steps

1. Open the Package Manager Console project and issue the following command to enable migrations.

	```
	Enable-Migrations -ProjectName "EfMigrationDifferentDbs" -ConnectionStringName MsSqlDbConnection -ContextTypeName AppDbContext -MigrationsDirectory MsSqlMigrations
	```

2. In the Package Manager Console, issue the following command to add migration.

	```
	Add-Migration -ProjectName "EfMigrationDifferentDbs" -ConfigurationTypeName EfMigrationDifferentDbs.MsSqlMigrations.Configuration V0001__InitialSetup -ConnectionStringName MsSqlDbConnection
	```

3. In the Package Manager Console, issue the following command to migrate the database or generate the SQL script

	```
	Update-Database -ProjectName "EfMigrationDifferentDbs" -ConfigurationTypeName EfMigrationDifferentDbs.MsSqlMigrations.Configuration -ConnectionStringName MsSqlDbConnection
	```

## Postgres Migrations Steps

1. Open the Package Manager Console project and issue the following command to enable migrations.

	```
	Enable-Migrations -ProjectName "EfMigrationDifferentDbs" -ConnectionStringName PostgresDbConnection -ContextTypeName AppDbContext -MigrationsDirectory PostgresMigrations
	```

2. In the Package Manager Console, issue the following command to add migration.

	```
	Add-Migration -ProjectName "EfMigrationDifferentDbs" -ConfigurationTypeName EfMigrationDifferentDbs.PostgresMigrations.Configuration V0001__InitialSetup -ConnectionStringName PostgresDbConnection
	```

3. In the Package Manager Console, issue following command to migrate the database or generate the SQL script

	```
	Update-Database -ProjectName "EfMigrationDifferentDbs" -ConfigurationTypeName EfMigrationDifferentDbs.PostgresMigrations.Configuration -ConnectionStringName PostgresDbConnection
	```

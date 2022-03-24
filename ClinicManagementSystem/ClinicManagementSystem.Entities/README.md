## Database migrations aka updating your database

### TL;DR: To update DB: Tools/NuGet Package Manager/Package Manager Console -> `Update-Database -ProjectName ClinicManagementSystem.Entities`

1. Open the Package Manager Console (Tools/NuGet Package Manager/Package Manager Console). 
2. When you add a new class or update an existing one, type `Add-Migration <migration-name> -ProjectName ClinicManagementSystem.Entities`. EF will detect changes and write some stuff. 
3. To apply those changes, type `Update-Database -ProjectName ClinicManagementSystem.Entities`. If you want to see the SQL behind, add `-Verbose` to it.
4. When you just want to update your database when someone added/changed classes and already made a migration, just update database (point 3).
5. Done! You can check your DB. 

Tip: PM console supports TAB command completion.
Note: If migrations aren't enabled (there is no `Migrations` directory), type `Enable-Migrations -ProjectName ClinicManagementSystem.Entities`. It is needed only once. 

## Data annotations aka how to specify primary key, not null, index, etc.

See https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations

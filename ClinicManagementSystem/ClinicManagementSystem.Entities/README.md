## Database migrations aka updating your database

1. Open the Package Manager Console (Tools/NuGet Package Manager/Package Manager Console). 
2. Type `Enable-Migrations -ProjectName ClinicManagementSystem.Entities`. It is needed only once. (Tip: console supports TAB command completion). 
3. When you add a new class or update an existing one, type `Add-Migration <migration-name> -ProjectName ClinicManagementSystem.Entities`. EF will detect changes and write some stuff.
4. To apply those changes, type `Update-Database -ProjectName ClinicManagementSystem.Entities`. If you want to see the SQL behind, add `-Verbose` to it.
5. Done! You can check your DB.


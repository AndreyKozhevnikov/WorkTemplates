install-package Microsoft.EntityFrameworkCore.Tools -version 6.0.3 -ProjectName EFSecur.Module

Add-Migration InitialCreate -StartupProject EFSecur.Module -Project EFSecur.Module
Update-Database -StartupProject EFSecur.Module -Project EFSecur.Module

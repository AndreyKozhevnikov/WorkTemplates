install-package Microsoft.EntityFrameworkCore.Tools -version 6.0.3 -ProjectName MySQLSolution.Module

Add-Migration InitialCreate -StartupProject MySQLSolution.Module -Project MySQLSolution.Module
Update-Database -StartupProject MySQLSolution.Module -Project MySQLSolution.Module

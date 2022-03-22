@echo off
docker pull mcr.microsoft.com/mssql/server:2019-latest && ^
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=TAB_DRA1" --name "SQLServer2019" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
pause
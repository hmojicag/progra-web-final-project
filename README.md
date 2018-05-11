# Como correr este proyecto

## Prerequisitos

* .Net Core
* Docker


## Levanta una instancia de SQL Server

    docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=AStrongPassword123!' -p 1401:1433 --name sql1 -d --rm microsoft/mssql-server-linux:2017-latest
    
## Clona y corre el proyecto
    
    git clone https://github.com/hmojicag/progra-web-final-project.git
    cd progra-web-final-project
    dotnet run
    
Visita http://localhost:5000/Music
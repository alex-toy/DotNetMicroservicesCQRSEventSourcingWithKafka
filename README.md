# .Net Microservices CQRS Event Sourcing With Kafka

## Prerequisites

1. Network :
```
docker network create --attachable -d bridge mydockernetwork
```

2. Kafka :
```
docker-compose up -d
```

3. Mongodb :
```
docker run -it -d --name mongo-container -p 27017:27017 --network mydockernetwork --restart always `
-v mongodb_data_container:/data/db mongo:latest
```

4. Microsoft SQL Server
```
docker run -d --name sql-container --network mydockernetwork --restart always `
-e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=$tr0ngS@P@ssw0rd02' -e 'MSSQL_PID=Express' `
-p 1433:1433 mcr.microsoft.com/mssql/server:2017-latest-ubuntu 
```
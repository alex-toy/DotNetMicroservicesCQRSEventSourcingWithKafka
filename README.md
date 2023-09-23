# .Net Microservices CQRS Event Sourcing With Kafka

## Prerequisites

1. Network :
```
docker network create --attachable -d bridge mydockernetwork
```

2. Kafka :
```
docker-compose up -d
docker exec dotnetmicroservicescqrseventsourcingwithkafka_kafka_1 kafka-topics.sh  --bootstrap-server localhost:9092  --create --replication-factor 1 --partitions 1 --topic SocialMediaPostEvents
```

3. Mongodb :
```
docker run -it -d --name mongo-container -p 27017:27017 --network mydockernetwork --restart always -v mongodb_data_container:/data/db mongo:latest
```

4. Microsoft SQL Server
```
docker run -d --name sql-container --network mydockernetwork --restart always -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=$tr0ngS@P@ssw0rd02' -e 'MSSQL_PID=Express' -p 1433:1433 mcr.microsoft.com/mssql/server:2017-latest-ubuntu 
```

<img src="/pictures/images.png" title="docker images"  width="900"> 

The connect to the server using the following credentials :
- Server name : localhost
- no database name
- user name : sa
- Password : from docker command
- No profile name

5. Nuget Packages

- in *CQRS.Core*
```
Install-Package MongoDB.Driver
```

- in *Post.Cmd.Infrastructure*
```
Install-Package Confluent.Kafka 
Install-Package Microsoft.Extensions.Options 6.0.0
Install-Package MongoDB.Driver 
```

- in *Post.Query.Api*
```
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL
```

Swashbuckle.AspNetCore" Version="6.2.3

- in *Post.Query.Infrastructure*
```
Install-Package Microsoft.EntityFrameworkCore.Proxies
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL
```

## Test API

### Create Post
<img src="/pictures/post_cmd_api.png" title="post cmd api"  width="900"> 





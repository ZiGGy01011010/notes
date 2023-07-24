**Compose** is a tool for defining and running multi-container Docker applications. With Compose, you use a **[YAML](Docker/docker-compose.yaml)** file to configure your application’s services. Then, with a single command, you create and start all the services from your configuration.

Start containers from `docker-compose.yaml`
```shell
docker-compose -f docker-compose.yaml up
```
Stop containers
```shell
docker-compose -f docker-compose.yaml down
```
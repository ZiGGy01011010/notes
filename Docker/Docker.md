[Good docker beginners guide](https://www.youtube.com/watch?v=3c-iBn73dDE)

- **Main docker commands**

Show all docker images:
```shell
docker images
```
There is public ([Docker Hub](https://hub.docker.com/)) and private ([AWS ECR](https://aws.amazon.com/ecr/)) docker image repositories.

Pull image from image repository (without starting container):
```shell
docker pull <image>:<tag>
```
**tag** - version of the image, not required, default `latest`.

Delete an image:
```shell
docker rmi <container id>
```
> **Note**
> 
> If image is used by container (even stopped container) you have to delete container first.

List of running containers:
```shell
docker ps
```
List of all containers:
```shell
docker ps -a
```
Create a new container from an image (and pull image from repository if it missing locally):
```shell
docker run -p <host_port>:<container_port> -d <image>
```
`-d` - optional flag, detached mode, no accesses to container terminal.

`--name` - specify name of the container

[List of all flags.](https://docs.docker.com/engine/reference/commandline/run/)

Start/spot containers (to get container_id use `docker ps`):
```shell
docker stop <container_id>
docker start <container_id>
```
Delete the container:
```shell
docker rm <container_id>
```

- **Debugging containers**

Logs:
```shell
docker logs <container_id or container_name>
```
Show only latest logs:
```shell
docker logs <container_id or container_name> | tail
```
Stream logs:
```shell
docker logs <container_id or container_name> -f
```
Connect to terminal of running container:
```shell
docker exec -it <container_id or container_name> /bin/bash
```
Essentially we are starting bash from container.
> **Note**
> 
> Some containers do not have bash installed, use `/bin/sh` instead.

Docker networks
```shell
docker network ls
```
Create network
```shell
docker network create <name>
```
In order to add container to network, add `--network <network name>` flag to your `docker run` command.
- **Dockerfile**

[Dockerfile](Docker/Dockerfile) - blueprint for building images. It is always called Dockerfile (with capital D, without extension).

Build image from Dockerfile
```shell
docker build -t <image name>:<tag> <path to file without filename>
```
- **Volumes**

Volume - mechanism for storing containers data.

1. Host volumes
```shell
docker run <other flags> -v <host directory>:<container directory>
```
Binds directory from host to directory in container.

2. Anonymous volumes
```shell
docker run <other flags> -v <container directory>
```
Docker puts this volume somewhere in `/docker/volumes/`.

3. Named volumes
```shell
docker run <other flags> -v <name>:<container directory>
```
Also managed by docker, can be referenced by `name`.

Example `docker-compose.yaml`:
```yaml
version: '3'
services:
  mongodb:
    .
    .
    .
    volumes:
      - mongo-data:/data/db
volumes:
  mongo-data
```
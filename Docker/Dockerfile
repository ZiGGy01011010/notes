# Base image
FROM node
# Environmental variables, better define them in yaml file
ENV MONGO_INITDB_ROOT_USERNAME=admin MONGO_INITDB_ROOT_PASSWORD=password
# Run any Linux command inside container
RUN mkdir -p /home/app
# COPY executes on the host machine
# First parameter source on host, second destenation inside container
COPY . /home/app
# Dockerfile ends with CMD command, which starts your application
CMD ["node", "/home/app/server.js"]
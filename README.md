# CURSO_UDEMY_REST_API_ASPNET_CORE_DOCKER_AZURE_2022

"MySQLConnectionString": "Server=localhost;port=3309;DataBase=rest_with_asp_net_udemy;Uid=root;Pwd=my!SQ@ladmin123"
docker-compose up -d --build 

docker ps -a 


http://localhost:44300/swagger/index.html


PS H:\Desenvolvimento_e_TI\WebSitesSistemas\GITHUB\APIREST2022\RestWithASPNETUdemy> docker ps -a
CONTAINER ID   IMAGE                        COMMAND                  CREATED              STATUS              PORTS                              NAMES
41d743b2c647   rest-with-asp-net-udemy      "dotnet RestWithASPN…"   About a minute ago   Up About a minute   443/tcp, 0.0.0.0:44300->80/tcp     restwithaspnetudemy_rest-with-asp-net-udemy_1
51bcb0207844   rest-with-asp-net-udemy-db   "docker-entrypoint.s…"   About a minute ago   Up About a minute   3310/tcp, 0.0.0.0:3310->3306/tcp   restwithaspnetudemy_db_1
PS H:\Desenvolvimento_e_TI\WebSitesSistemas\GITHUB\APIREST2022\RestWithASPNETUdemy>


docker logs CONTAINER ID 
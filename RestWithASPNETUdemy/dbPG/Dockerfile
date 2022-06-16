FROM postgres:5.7.22
EXPOSE 5432
COPY ./RestWithASPNETUdemy/dbPG/migrations/ /home/database/ 
COPY ./RestWithASPNETUdemy/ciPG/init_database.sh/ /docker-entrypoint-initdb.d/init_database.sh
DROP DATABASE IF EXISTS parchis;
CREATE DATABASE parchis;
USE parchis;

CREATE TABLE jugador(
nombre VARCHAR(255) PRIMARY KEY NOT NULL,
contraseña INTEGER NOT NULL
)ENGINE=InnoDB;

CREATE TABLE partida(
id INTEGER PRIMARY KEY NOT NULL,
fecha TEXT NOT NULL,
hora TEXT NOT NULL,
duracion TEXT NOT NULL,
ganador TEXT NOT NULL
)ENGINE=InnoDB;

CREATE TABLE participacion(
jugador VARCHAR(255) NOT NULL,
partida INTEGER NOT NULL,
posicion INTEGER NOT NULL,
FOREIGN KEY (jugador) REFERENCES jugador(nombre),
FOREIGN KEY (partida) REFERENCES partida(id)
)ENGINE=InnoDB;

INSERT INTO jugador VALUES ('christian',1234);
INSERT INTO jugador VALUES ('pol',5678);
INSERT INTO jugador VALUES ('lluc',7890);

INSERT INTO partida VALUES (1,'3 de marzo','15:00','20 minutos','christian');
INSERT INTO partida VALUES (2,'2 de febrero','10:30','30 minutos','pol');
INSERT INTO partida VALUES (3,'15 de abril','12:00','40 minutos','lluc');


INSERT INTO participacion VALUES ('christian',2,1);
INSERT INTO participacion VALUES ('lluc',1,3);
INSERT INTO participacion VALUES ('pol',3,1);



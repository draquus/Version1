#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <string.h>



int main(int argc, char *argv[])
{
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	conn = mysql_init(NULL);
	if (conn==NULL){
		printf("Error al crear la conexion: %u %s \n", mysql_errno(conn), mysql_error(conn));
		
	}
	conn = mysql_real_connect (conn, "localhost", "root", "mysql","parchis",0, NULL, 0);
	if (conn==NULL){
		printf ("Error al inicializar la conexion: %u %s \n", mysql_errno(conn), mysql_error(conn));
		
	}
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina.
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9040);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i;
	// Bucle infinito
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
		
		int terminar =0;
		// Entramos en un bucle para atender todas las peticiones de este cliente
		//hasta que se desconecte
		while (terminar ==0)
		{
			// Ahora recibimos la petici?n
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			
			// Tenemos que a?adirle la marca de fin de string
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';
			
			
			printf ("Peticion: %s\n",peticion);
			
			// vamos a ver que quieren
			char *p = strtok( peticion, "/");
			printf("p: %s\n",p);
			int codigo =  atoi (p);
			// Ya tenemos el c?digo de la petici?n
			char nombre[20];
			int pwd;
			int pwds;
			
			if (codigo == 0) //petici?n de desconexi?n
				terminar = 1;
			if (codigo == 1)
			{
				//consulta de pol
				char consulta[100];
				strcpy(consulta, "SELECT nombre From jugador;");
				err = mysql_query(conn, consulta);
				if (err != 0) {
					sprintf(respuesta, "Error al consultar datos de la base %u %s \n",
							mysql_errno(conn), mysql_error(conn));
					
				}
				
				else
					resultado = mysql_store_result(conn);
				row = mysql_fetch_row(resultado);
				strcpy ( respuesta, row[0]);
				row = mysql_fetch_row(resultado);
				while (row != NULL) {
					// la columna 0 contiene el nombre del jugador
					
					sprintf(respuesta, "%s, %s",respuesta, row[0]);
					// obtenemos la siguiente fila
					row = mysql_fetch_row(resultado);
				}
				
				
			}
			
			
			if (codigo == 2)
			{printf("todo bien ");
			char *j = strtok( peticion, "/");
			j = strtok(NULL, "/");
			printf("p: %s" , p);
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf("nombre: %s" , nombre);
			//consulta de lluc
			char consulta[100];
			strcpy(consulta, "SELECT * FROM partida WHERE ganador='");
			strcat(consulta, nombre);
			strcat(consulta, ";");
			mysql_query(conn, consulta);
			err = mysql_query(conn, consulta);
			if (err != 0) {
				
				sprintf(respuesta, "Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				
			}
			resultado = mysql_store_result(conn);
			row = mysql_fetch_row(resultado);
			if (row == NULL)
				strcpy(respuesta, "No se han obtenido datos en la consulta\n");
			else {
				// El resultado debe ser una matriz con una sola fila
				// y una columna que contiene el nombre
				while (row != NULL)
				{
					sprintf(respuesta, "%d %s %s %s %s", row[0], row[1], row[2], row[3], row[4]);
					row = mysql_fetch_row(resultado);
				}
			}
			
			
			}
			
			if (codigo ==3) //consulta de christian
			{
				
				char consulta[100];
				strcpy(consulta, "SELECT id,ganador FROM partida;");
				
				err = mysql_query(conn, consulta);
				if (err != 0) {
					sprintf(respuesta, "Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					
				}
				
				else if (row == NULL)
					strcpy(respuesta, "No se han obtenido datos en la consulta");
				else
				{
					resultado = mysql_store_result(conn);
					
					row = mysql_fetch_row(resultado);
					while (row != NULL)
					{
						sprintf(respuesta, "%s %s", row[0], row[1]);
						row = mysql_fetch_row(resultado);
						
					}
					
				}
				
			}
			
			if (codigo == 4)
			{
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				// Ya tenemos el nombre
				p = strtok(NULL, "/");
				pwd = atoi(p);
				
				char consulta[100];
				strcpy(consulta, "SELECT * FROM jugador WHERE nombre='");
				strcat(consulta, nombre);
				strcat(consulta, "' ");
				strcat(consulta, "AND contraseña=");
				strcat(consulta, pwd);
				err = mysql_query(conn, consulta);
				if (err != 0) {
					sprintf(respuesta, "Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					
				}
				resultado = mysql_store_result(conn);
				row = mysql_fetch_row(resultado);
				if (row == NULL)
					strcpy(respuesta, "No existe este jugador");
				else
					strcpy(respuesta, "Login correcto");
			}
			if (codigo==5)//registro
			{
				p = strtok( NULL, "/");
				strcpy (nombre, p);
				// Ya tenemos el nombre
				p = strtok(NULL, "/");
				pwd = atoi(p);
				char consulta[100];
				strcpy(consulta, "INSERT INTO jugador VALUES('");
				strcat(consulta, nombre);
				strcat(consulta, "',");
				sprintf(pwds, "%d", pwd);
				strcat(consulta, pwds);
				strcat(consulta, ");");
				printf("consulta = %s\n", consulta);
				err = mysql_query(conn, consulta);
				if (err != 0) {
					sprintf(respuesta, "Error al introducir datos la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					
				}
				sprintf(respuesta, "Registro correcto");
			}
			if (codigo !=0)
			{
				
				printf ("Respuesta: %s\n", respuesta);
				// Enviamos respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
		}
		// Se acabo el servicio para este cliente
		close(sock_conn);
	}
}




--PRODUCTO
INSERT INTO Producto VALUES ( CONVERT(datetime, '01/03/2020 00:00:00', 103) -- fecha Creacion
								,1
								,'Milanesa a la napolitana'
								,200
								,1
								,1
								,2)

INSERT INTO Producto VALUES ( CONVERT(datetime, '01/03/2020 00:00:00', 103) -- fecha Creacion
								,2
								,'Pure de papa'
								,75
								,1
								,1
								,1)

INSERT INTO Producto VALUES ( CONVERT(datetime, '01/03/2020 00:00:00', 103) -- fecha Creacion
								,3
								,'Ensalada waldorf'
								,90
								,1
								,1
								,1)


-- MENU
INSERT INTO Menu VALUES (2,NULL
								,CONVERT(datetime, '01/03/2020 00:00:00', 103) -- fecha Creacion
								,CONVERT(datetime, '01/12/2020 00:00:00', 103) -- fecha Vigencia
								,4
								,'Menu Patagonico'
								,625)




							
-- PRODUCTO DE CARTA
INSERT INTO ProductoDeCarta VALUES ( 1,--favorito =1 , no favorito=0
									NULL,158.58,--precio
									1); --Id Producto.

INSERT INTO ProductoDeCarta VALUES (0,--favorito =1 , no favorito=0
									NULL,600.00,--precio
									2); --Id Producto.

INSERT INTO ProductoDeCarta VALUES (0,--favorito =1 , no favorito=0
									NULL,700.00,--precio
									3); --Id Producto.





--ESTADOS MESA
INSERT INTO Estado VALUES ('Mesa','Activa');--Es decir, Libre. --id= 1
INSERT INTO Estado VALUES ('Mesa','Reservada');--id= 2
INSERT INTO Estado VALUES ('Mesa','Abierta');--id= 3
INSERT INTO Estado VALUES ('Mesa','Con pedido generado')--id= 4
INSERT INTO Estado VALUES ('Mesa','Cerrada');--id= 5

--ESTADOS DETALLE DE PEDIDO

INSERT INTO Estado VALUES ('DetallePedido','Pendiente de preparacion');--id= 6
INSERT INTO Estado VALUES ('DetallePedido','En preparacion');--id= 7
INSERT INTO Estado VALUES ('DetallePedido','Listo para servir');--id= 8
INSERT INTO Estado VALUES ('DetallePedido','Notificado');--id= 9
INSERT INTO Estado VALUES ('DetallePedido','Cancelado');--id= 10
INSERT INTO Estado VALUES ('DetallePedido','Cerrado');--id= 11

--ESTADOS DETALLE DE PEDIDO

INSERT INTO Estado VALUES ('Pedido','Abierto');--id= 12
INSERT INTO Estado VALUES ('Pedido','Cerrado');--id= 13
INSERT INTO Estado VALUES ('Pedido','Cancelado');--id= 14





--HISTORIAL ESTADO DETALLE DE PEDIDOS.

INSERT INTO HistorialEstado VALUES (   CONVERT(datetime, '8/11/2020 08:51:01', 103) --frcha hora FIN
									 , CONVERT(datetime, '8/11/2020 08:28:53', 103) -- fecha Inicio
									 , 6) --Pendiente de preparacion
									 

INSERT INTO HistorialEstado VALUES (   CONVERT(datetime, '8/11/2020 09:56:09', 103) --frcha hora FIN
									 , CONVERT(datetime, '8/11/2020 08:51:02', 103) -- fecha Inicio
									 ,7) --En preparacion

INSERT INTO HistorialEstado VALUES (   CONVERT(datetime, '8/11/2020 09:57:49', 103) --frcha hora FIN
									 , CONVERT(datetime, '8/11/2020 09:56:10', 103) -- fecha Inicio
									 , 8) --Listo Para Servir

INSERT INTO HistorialEstado VALUES ( CONVERT(datetime, '8/11/2020 09:58:02', 103) --frcha hora FIN
									 , CONVERT(datetime, '8/11/2020 09:57:50', 103) -- fecha Inicio
									  , 9) --Notificado
									 

INSERT INTO HistorialEstado VALUES (   NULL --frcha hora FIN
									 , CONVERT(datetime, '8/11/2020 08:28:53', 103) -- fecha Inicio
									 , 7) --En preparacion


INSERT INTO HistorialEstado VALUES (   NULL --frcha hora FIN
									 , CONVERT(datetime, '8/11/2020 08:29:53', 103) -- fecha Inicio
									 , 7) --En preparacion

INSERT INTO HistorialEstado VALUES (   NULL --frcha hora FIN
									 , CONVERT(datetime, '8/11/2020 08:35:53', 103) -- fecha Inicio
									 , 7) --En preparacion


--HISTORIAL ESTADO DE PEDIDO.

INSERT INTO HistorialEstado VALUES (   CONVERT(datetime, '8/11/2020 09:58:02', 103) --frcha hora FIN
									 , CONVERT(datetime, '8/11/2020 08:28:53', 103) -- fecha Inicio
									 , 12) --Abierto

INSERT INTO HistorialEstado VALUES (   NULL --frcha hora FIN
									 , CONVERT(datetime, '8/11/2020 09:58:03', 103) -- fecha Inicio
									 , 13) --Cerrado


-- MESAS 

INSERT INTO Mesa VALUES (6,1,1,1,1,1);
INSERT INTO Mesa VALUES (5,1,2,1,2,1);
INSERT INTO Mesa VALUES (6,1,2,2,2,4);
INSERT INTO Mesa VALUES (4,1,3,2,3,3);
INSERT INTO Mesa VALUES (4,1,4,3,3,5);



--PEDIDOS

INSERT INTO Pedidos VALUES (4,NULL,NULL
									   ,CONVERT(datetime, '8/11/2020 08:28:01', 103) --fechaHoraPedido
									   ,5 -- mesa 5
									   ,8); --Historial pedido 8

INSERT INTO Pedidos VALUES (6,NULL,NULL
									   ,CONVERT(datetime, '8/11/2020 08:30:00', 103) --fechaHoraPedido
									   ,3 -- mesa 3
									   ,9); -- Historial Pedido 9



--DETALLE PEDIDOS

INSERT INTO DetallePedidos VALUES(   NULL
									,2 --cantidad
									,CONVERT(datetime, '8/11/2020 08:30:00', 103) --hora
									,2
									,1 -- Ligado al nroPedido 1
									,1 -- id HistorialPedido
									,NULL
									,1);  --ProductoDeCarta
									

INSERT INTO DetallePedidos VALUES(   NULL
									,1 --cantidad
									,CONVERT(datetime, '8/11/2020 08:31:00', 103) --hora
									,2
									,2 -- Ligado al nroPedido 2
									,2 -- id HistorialPedido
									,NULL
									,3);  --ProductoDeCarta
									
									
INSERT INTO DetallePedidos VALUES(   NULL
									,2 --cantidad
									,CONVERT(datetime, '8/11/2020 08:32:00', 103) --hora
									,2
									,2 -- Ligado al nroPedido 2
									,5 -- id HistorialPedido
									,1 -- Un Menu patagonico
									,NULL);  --ProductoDeCarta
									
									
INSERT INTO DetallePedidos VALUES(   NULL
									,1 --cantidad
									,CONVERT(datetime, '8/11/2020 08:33:00', 103) --hora
									,2
									,2 -- Ligado al nroPedido 2
									,6 -- id HistorialPedido
									,NULL
									,2);  --ProductoDeCarta

INSERT INTO DetallePedidos VALUES(   NULL
									,3 --cantidad
									,CONVERT(datetime, '8/11/2020 08:32:00', 103) --hora
									,2
									,1 -- Ligado al nroPedido 2
									,7 -- id HistorialPedido
									,1 -- Un Menu patagonico
									,NULL);  --ProductoDeCarta
									










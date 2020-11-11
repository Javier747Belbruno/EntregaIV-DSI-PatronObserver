
USE Restaurant;  
GO  
CREATE TABLE Producto (
    id_producto INT PRIMARY KEY IDENTITY (1, 1),
    fechaCreacion DATETIME,
	foto INT,
	nombre VARCHAR (50),
	precio DECIMAL(8,2),
	receta INT,
	sectorComanda INT,
	tiempoPresen INT
	
);


CREATE TABLE Menu (
    id_menu INT PRIMARY KEY IDENTITY (1, 1),
    cantidadMinimaComensales INT NOT NULL,
	comentarios VARCHAR (50),
    fechaCreacion DATETIME,
	fechaVigencia DATETIME,
	foto INT,
	nombre VARCHAR (50),
	precio DECIMAL(8,2),
	
);

CREATE TABLE ProductoDeCarta (
    id_productoDeCarta INT PRIMARY KEY IDENTITY (1, 1),
    esFavorito INT NOT NULL,
	comentarios VARCHAR (50),
	precio DECIMAL(8,2),

	id_producto INT NOT NULL,
	FOREIGN KEY (id_producto) REFERENCES Producto (id_producto) 
);

CREATE TABLE Estado (
    id_estado INT PRIMARY KEY IDENTITY (1, 1),
    ambito VARCHAR (50),
	nombre VARCHAR (50),
);

CREATE TABLE HistorialEstado (
    id_historialEstado INT PRIMARY KEY IDENTITY (1, 1),
	
    fechaHoraFin DATETIME,
	fechaHoraInicio DATETIME,

	 id_estado INT NOT NULL,
	 FOREIGN KEY (id_estado) REFERENCES Estado (id_estado) 
);



CREATE TABLE Mesa (
    numero INT PRIMARY KEY IDENTITY (1, 1),
	capacidadComensales INT,
	espacioQueOcupa INT,
	forma INT,
	filaEnPlano INT,
	ordenEnPlano INT,

    id_estado INT NOT NULL -- Not null es una Mesa tiene uno y un solo estado.
	FOREIGN KEY (id_estado) REFERENCES Estado (id_estado) 
);

CREATE TABLE Pedidos (
    nroPedido INT PRIMARY KEY IDENTITY (1, 1),
    cantComensales INT,
    detPedido VARCHAR (50),
    factura INT,
    fechaHoraPed DATETIME,
	
	id_mesa INT NOT NULL,
	FOREIGN KEY (id_mesa) REFERENCES Mesa (numero),
	id_historialEstado INT NOT NULL,
	FOREIGN KEY (id_historialEstado) REFERENCES HistorialEstado (id_historialEstado) 
);


CREATE TABLE DetallePedidos (
    nroDetallePedido INT PRIMARY KEY IDENTITY (1, 1),
   
	detDetallePedido VARCHAR (50),
	cantidad INT NOT NULL,
    hora DATETIME,
	tiempo INT,

	nroPedido INT NOT NULL,
    FOREIGN KEY (nroPedido) REFERENCES Pedidos (nroPedido),
	id_historialEstado INT NOT NULL,
	FOREIGN KEY (id_historialEstado) REFERENCES HistorialEstado (id_historialEstado), 

	id_menu INT,
	FOREIGN KEY (id_menu) REFERENCES Menu (id_menu) ,
	id_productoDeCarta INT,
	FOREIGN KEY (id_productoDeCarta) REFERENCES ProductoDeCarta (id_productoDeCarta) ,
);
/*



DROP TABLE DetallePedidos
drop table Pedidos
drop table mesa
drop table HistorialEstado
drop table Estado
drop table ProductoDeCarta
DROP table Menu
drop table Producto








*/

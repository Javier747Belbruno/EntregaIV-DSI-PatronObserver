
USE Restaurant;  
GO  
CREATE TABLE Pedidos (
    nroPedido INT PRIMARY KEY IDENTITY (1, 1),
    cantComensales INT,
    detPedido VARCHAR (50),
    factura INT,
    fechaHoraPed DATETIME,
	
	id_mesa INT,
);

--DROP TABLE Pedidos

CREATE TABLE DetallePedidos (
    nroDetallePedido INT PRIMARY KEY IDENTITY (1, 1),
    nroPedido INT NOT NULL,
	detDetallePedido VARCHAR (50),
	cantidad INT NOT NULL,
    hora DATETIME,
	menu INT,
	productoDeCarta INT,
	tiempo INT,
	
    --Por ahora no pongo foreing key para no cagarla.
    --FOREIGN KEY (nroPedido) REFERENCES Pedidos (nroPedido)
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
	
);

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



CREATE TABLE HistorialEstado (
    id_historialEstado INT PRIMARY KEY IDENTITY (1, 1),
    id_estado INT,
    fechaHoraFin DATETIME,
	fechaHoraInicio DATETIME,
	id_detallePedido INT, --Si es de detalle pedido , id_pedido tendria que ser nulo.
	id_pedido INT --Si es de pedido , id_detallePedido no deberia tener un valor.
);

--DROP TABLE DetallePedidos;

--DROP TABLE Mesa;

--DROP TABLE HistorialEstado;

CREATE TABLE Estado (
    id_estado INT PRIMARY KEY IDENTITY (1, 1),
    ambito VARCHAR (50),
	nombre VARCHAR (50),
);

CREATE TABLE Mesa (
    numero INT PRIMARY KEY IDENTITY (1, 1),
	capacidadComensales INT,
	espacioQueOcupa INT,
	forma INT,
	filaEnPlano INT,
	ordenEnPlano INT,
    id_estado INT
);

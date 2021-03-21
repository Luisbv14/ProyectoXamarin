Create table Tarjetas (
	numTarjeta varchar(50) primary key not null,
	ccv varchar(50) not null,
	Titular varchar(50) not null,
	tipoTarjeta varchar(50) not null, --Si es Visa o Mastercard
	fechaVencimiento date not null,
);

Create table Usuario (
	cedula varchar(50) primary key not null,
	username varchar(50) not null,
	contraseña varchar(50) not null,
	correo varchar(50) not null,
	telefono varchar(50) not null,
	numTarjeta varchar(50) not null,
	tipo varchar(50) not null, --Si el usuario es un usuario normal o es un administrador
	constraint usuariofk_0 foreign key (numTarjeta) references Tarjetas(numTarjeta),
);

Create table Productos (
	codigoProducto varchar(50) primary key not null,
	marca varchar(50) not null,
	modelo varchar(50) not null,
	estilo varchar(50),
	combustible varchar(50) not null,
	transmision varchar(50) not null, 
	imagen varchar(50) not null,
	año varchar(50) not null,
	precio int not null,
);

Create table Ventas (
	codigoVentas int IDENTITY(1,1) primary key not null,
	monto int not null,
	cedula varchar(50) not null,
	codigoProducto varchar(50) not null,
	fecha date not null,
	constraint ventasfk_0 foreign key(cedula) references Usuario(cedula),
	constraint ventasfk_1 foreign key (codigoProducto) references Productos(codigoProducto),
);

Create table VentasEsp (
	codigoVentasEsp varchar(50) primary key not null,
	codigoVentas int not null,
	descripcion varchar(100) not null,
	constraint ventasEspfk_0 foreign key (codigoVentas) references Ventas(codigoVentas),
);

Create table Inventarios (
	codigoStock varchar(50) primary key not null,
	codigoProducto varchar(50) not null,
	cantidad int not null,
	constraint inventariosfk_0 foreign key (codigoProducto) references Productos(codigoProducto),
);

Create table Abonos (
	codigoAbono varchar(50) primary key not null,
	codigoVentasEsp varchar(50) not null,
	monto float not null,
	fecha date not null,
	constraint abonosfk_0 foreign key (codigoVentasEsp) references VentasEsp(codigoVentasEsp),
);

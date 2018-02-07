Create table Vendedores(
	VendedoresId int primary key identity,
	Nombres varchar(100),
	Descripcion Varchar(100),
	MensajeInicial varchar(100),
	MensajeFinal varchar(100),
	PorcientoComision1 float,
	PorcientoComision2 float,
    PorcientoComision3 float,
    PorcientoComision4 float,
    PorcientoComision5 float,
	LimiteVentas float)

	Create table Ventas(
	VentasId int primary key identity,
	VendedorId int,
	Fecha datetime,
	Total float,
	Comision float)

	create table Subsidios(
	SubsidioId int primary key identity,
	VendedorId int,
	Fecha datetime,
	Concepto varchar(100),
	Monto float
	
	);





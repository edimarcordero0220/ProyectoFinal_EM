CREATE TABLE Gastoss (
	GastoId int primary key identity,	
	VendedorId int,	
	Fecha datetime,
	Concepto varchar(100),
	Monto int)
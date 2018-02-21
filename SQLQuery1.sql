CREATE TABLE CuadresVendedorDetalles (
	Id int primary key identity,
	CuadreId int,
	Vendido int,
	Subsidios int,
	Gastos int,
	Pagos int,
	Comision int,
	Ganancia int,
	Pendiente int,
	Monto int)

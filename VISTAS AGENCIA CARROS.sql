
--Practica de vistas AGENCIA CARROS
--Mostrar nombre, apellido y precio de todos los veh�culos con un precio mayor a 20,000. 
Create view Vw_Clientes
	as
	(
		Select 
			c.Nombre,
			c.Apellido,
			v.Precio
		FROM tblVentas ven
				INNER JOIN tblClientes c ON ven.ClienteID = c.ClienteID
				INNER JOIN tblVehiculos v ON ven.VehiculoID = v.VehiculoID
		where v.Precio > 20000
	);

Select * from tblVehiculos

--b. Mostrar nombre, apellido y monto total gastado por cada cliente 
CREATE VIEW vw_MontoTotalPorCliente 
AS
(
SELECT 
    c.ClienteID,
    c.Nombre, 
    c.Apellido, 
    SUM(v.Monto) AS MontoTotalGastado
FROM tblClientes c
INNER JOIN tblVentas v ON c.ClienteID = v.ClienteID
GROUP BY c.ClienteID, c.Nombre, c.Apellido);

--c. Listar informaci�n de todas las ventas, incluyendo el cliente, el veh�culo y el monto de 
--la venta. 
CREATE VIEW vw_InformacionVentas AS
SELECT 
	ven.VentaID,
    c.ClienteID,
    c.Nombre, 
    c.Apellido,
    v.VehiculoID,
    v.Marca,
    v.Modelo,
    ven.FechaVenta,
    ven.Monto
FROM tblVentas ven
INNER JOIN tblClientes c ON ven.ClienteID = c.ClienteID
INNER JOIN tblVehiculos v ON ven.VehiculoID = v.VehiculoID;

select * from tblVentas

--d. Mostrar datos de los clientes que han realizado m�s de una compra. 
CREATE VIEW vw_Clientes2 AS
SELECT 
    c.ClienteID,
    c.Nombre, 
    c.Apellido,
    c.Email,
	c.Telefono,
	c.Estado,
	COUNT(ven.VentaID) AS TotalCompras
FROM tblClientes c
INNER JOIN tblVentas ven ON c.ClienteID = ven.ClienteID
GROUP BY c.ClienteID, c.Nombre, c.Apellido, c.Email, c.Telefono, c.Estado
HAVING COUNT(ven.VentaID) > 1;

--e. Listar todos los veh�culos que est�n disponibles para la venta, ordenados por precio de 
--forma ascendente.
Create view Vw_VehiculosDisponibles
	as
	(
		Select TOP 100
			VehiculoID,
			Marca,
			Modelo,
			A�o,
			Precio,
			Estado
		FROM tblVehiculos 
		where Estado = 'Disponible'
		Order by Precio Asc
	);
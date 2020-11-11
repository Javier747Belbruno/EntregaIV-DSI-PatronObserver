
--update HistorialEstado set fechaHoraFin = GETDATE() where id_estado = 8
/*
select * from DetallePedidos where id_historialEstado in (12,13,14)
select * from HistorialEstado where id_historialEstado in (12,13,14)
select * from Menu
select * from mesa
select * from Pedidos
select * from ProductoDeCarta
select * from Producto
select * from Estado where nombre = 'En preparacion'

*/
--delete from Estado where id_estado in (15,16)
/*
select GETDATE()-0.011
UPDATE HistorialEstado set fechaHoraInicio = GETDATE()-0.011 Where id_historialEstado = 101
UPDATE HistorialEstado set fechaHoraInicio = GETDATE()-0.012 Where id_historialEstado = 104
UPDATE HistorialEstado set fechaHoraInicio = GETDATE()-0.013 Where id_historialEstado = 105
*/
/*


select * from HistorialEstado 
update HistorialEstado set id_estado = 7 where id_estado in (9)

update HistorialEstado set fechaHoraInicio where id_estado in (9)

*/
/*update HistorialEstado set id_estado = 7 where id_historialEstado in (5,6)*/
/*
update DetallePedidos set id_historialEstado = 6 where nroDetallePedido = 1
update DetallePedidos set id_historialEstado = 5 where nroDetallePedido = 2

*/
/*
select * from HistorialEstado where id_historialEstado in (7,8)
select * from DetallePedidos
select * from Estado
--delete from DetallePedidos where nroDetallePedido > 5
--delete from HistorialEstado where id_historialEstado >5
------------------------------
*/
/*update DetallePedidos set id_historialEstado = 5
				where id_historialEstado = 125

				select * from Pedidos
				select * from Mesa
				--delete Mesa where numero > 5
				select * from Pedidos
				
				--delete from Pedidos where nroPedido>2
--delete from Estado where id_estado > 16*/




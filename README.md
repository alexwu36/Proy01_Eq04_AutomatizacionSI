# Proy01_Eq04_AutomatizacionSI
1. Abrir la carpet a "Leer"
2. Seguir pasos del Word de Importar BD 
3. Seguir pasos del Word "2. Errores detectados justo después de copiar del repositorio"

#Notas de Cambios en la BD
----------------------------------------------------------------------------------------------------------------------------------------------------------------
12-13-21
-Alex 

1) AÑADI COLUMNA ESTADO Y COMENTARIOS PARA TABLA SOLICITUD
ALTER TABLE automatizacion.solicitud
ADD Estado varchar(255);
ALTER TABLE automatizacion.solicitud
ADD comentarios varchar(255);
----------------------------------------------------------------------------------------------------------------------------------------------------------------
2) Para llenar a la tabla de solicitud hay q tener:
Una actividad ya creada, porque se le usa el idActividad.
Use la consulta SQL:
INSERT INTO automatizacion.actividad(nombreActividad) VALUES('Evento de temporada');

----------------------------------------------------------------------------------------------------------------------------------------------------------------
3) Luego llenar una consulta pa probar en tabla solicitud para probar SQL:
INSERT INTO automatizacion.solicitud (nombreEvento, fechaEvento, horaInicio, horaFinal, observacion, idLugar, idFacultad, idActividad, idUsuario, Estado ) VALUES ( 'Evento 2', '12-12-21', '2:00 pm', '3:00 pm', 'juegos todo el dia ', '1', '1', '1', '1', 'Pendiente');
 
----------------------------------------------------------------------------------------------------------------------------------------------------------------
4)Crear 2 procedimientos almacenados para aprobar o rechazar el evento:

CREATE PROCEDURE Sp_Actualizar_Coment
@CODIGO INT,
@COMENTARIO VARCHAR(255)
AS 
UPDATE automatizacion.solicitud 
SET Estado='Aprobado', comentarios=@COMENTARIO
WHERE idSolicitud = @CODIGO

CREATE PROCEDURE Sp_Rechazar_Coment
@CODIGO INT,
@COMENTARIO VARCHAR(255)
AS 
UPDATE automatizacion.solicitud 
SET Estado='Rechazado', comentarios=@COMENTARIO
WHERE idSolicitud = @CODIGO

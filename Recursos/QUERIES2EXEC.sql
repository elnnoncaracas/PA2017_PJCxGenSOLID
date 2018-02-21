/*

************************************************************
INNER JOIN STRUCTURE
------------------------------------------------------------
SELECT column_name(s)
FROM table1
INNER JOIN table2 ON table1.column_name = table2.column_name;
*************************************************************

*/

USE EMPRESA;

SELECT NOMBRE,APELLIDO,NPUESTO,SALARIO FROM EMPLEADO INNER JOIN SUELDOS ON EMPLEADO.FKPTRAB = SUELDOS.SPID WHERE NPUESTO = 'VENDEDOR';

USE DBCONFIG_E;

SELECT NOMBREPROV,CADENA FROM PROVEEDORES INNER JOIN CADENACONECT ON PROVEEDORES.ID = CADENACONECT.CID WHERE CID = 1;
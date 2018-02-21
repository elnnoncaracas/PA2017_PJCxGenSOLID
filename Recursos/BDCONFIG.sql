CREATE DATABASE DBCONFIG_E;
USE DBCONFIG_E;

CREATE TABLE SQUERIES(ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL, NCONSULTA VARCHAR(255));
CREATE TABLE TIPOSBD(TID INT IDENTITY(1,1) PRIMARY KEY NOT NULL, NOMTIPO VARCHAR(50));
CREATE TABLE PROVEEDORES(ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL, NOMBREPROV VARCHAR(50), FKTIPO INT FOREIGN KEY REFERENCES TIPOSBD(TID));
CREATE TABLE CADENACONECT(CID INT IDENTITY(1,1) PRIMARY KEY NOT NULL, CADENA VARCHAR(255), CADTIP INT FOREIGN KEY REFERENCES PROVEEDORES(ID));



CREATE TABLE IMPOSITORA(IID INT PRIMARY KEY IDENTITY NOT NULL, FKPID INT FOREIGN KEY REFERENCES PROVEEDORES(ID), CCID INT FOREIGN KEY REFERENCES CADENACONECT(CID), TDB INT REFERENCES TIPOSBD(TID));


INSERT INTO TIPOSBD VALUES('MICROSOFT SQL SERVER');
INSERT INTO TIPOSBD VALUES('POSTGRES SQL');
INSERT INTO TIPOSBD VALUES('MYSQL');
INSERT INTO TIPOSBD VALUES('MARIADB');

INSERT INTO PROVEEDORES VALUES('System.Data.SqlClient',1);
INSERT INTO PROVEEDORES VALUES('Npgsql',2);
INSERT INTO PROVEEDORES VALUES('MySql.Data',3);
INSERT INTO PROVEEDORES VALUES('MySql.Data',4);

INSERT INTO CADENACONECT VALUES('Data Source=DESKTOP-8MI8C4P;Initial Catalog=EMPRESA;Integrated Security=True',1);
INSERT INTO CADENACONECT VALUES('Server =babar.elephantsql.com; Port = 5432; Database = bmfkgevd; User Id = bmfkgevd; Password =  1erS7WgQ83Ql3i9DRjJk5mT_CV64jTwX',2);

INSERT INTO SQUERIES VALUES('SELECT * FROM EMPLEADOS');
INSERT INTO SQUERIES VALUES('SELECT * FROM CLIENTE');
INSERT INTO SQUERIES VALUES('SELECT * FROM ORDENES');
INSERT INTO SQUERIES VALUES('SELECT * FROM EMPLEADO');
INSERT INTO SQUERIES VALUES('SELECT * FROM PRODUCTOS');
INSERT INTO SQUERIES VALUES('SELECT * FROM SUELDOS');

INSERT INTO IMPOSITORA VALUES(1,1,1);
INSERT INTO IMPOSITORA VALUES(2,2,2);
SELECT*FROM IMPOSITORA
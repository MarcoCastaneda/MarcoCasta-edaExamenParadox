CREATE DATABASE MarcoCastañedaParadox
GO
USE MarcoCastañedaParadox
GO

CREATE TABLE Usuario(

IdUsuario INT PRIMARY KEY IDENTITY (1,1),
Nombre VARCHAR (50),
ApellidoPaterno VARCHAR(50),
ApellidoMaterno VARCHAR(50),
Email VARCHAR(50),
Password VARCHAR(50))
GO

CREATE PROCEDURE [dbo].[GetByEmail]
@Email VARCHAR (50)
AS
SELECT
	
	Email,
	Password,
	IdUsuario

FROM Usuario

WHERE Email = @Email


INSERT INTO Usuario VALUES('Marco','Castañeda','Bautista','marco123@gmail.com','123')


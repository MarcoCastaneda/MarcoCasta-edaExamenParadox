CREATE DATABASE MarcoCasta�edaParados
GO
USE MarcoCasta�edaParados
GO

CREATE TABLE Usuario(

IdUsuario INT PRIMARY KEY IDENTITY (1,1),
Nombre VARCHAR (50),
ApellidoPaterno VARCHAR(50),
ApellidoMaterno VARCHAR(50),
Email VARCHAR(50),
Password VARCHAR(50))
GO

CREATE PROCEDURE GetByEmail
@Email VARCHAR (50)
AS
SELECT
	
	Email,
	Password,
	IdUsuario

FROM Usuario

WHERE Email = @Email

GO

INSERT INTO Usuario VALUES('Marco','Casta�eda','Bautista','marco123@gmail.com','123')






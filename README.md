
CREATE DATABASE Productos;
GO
USE Productos;
GO

CREATE TABLE Categorias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL
);
GO

INSERT INTO Categorias (Nombre) VALUES
('Electrónica'),
('Hogar'),
('Textil');
GO

CREATE TABLE Productos (
    Codigo INT PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(100),
    Precio DECIMAL(10,2),
    Stock INT,
    CategoriaId INT FOREIGN KEY REFERENCES Categorias(Id)
);
GO

INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock, CategoriaId) VALUES
(1001, 'Mouse', 'Mouse óptico USB', 1500, 30, 1),
(1002, 'Teclado', 'Teclado mecánico RGB', 3500, 20, 1),
(1003, 'Monitor', 'Monitor LED 24 pulgadas', 23000, 10, 1),
(1004, 'Lámpara', 'Lámpara de escritorio LED', 4200, 15, 2),
(1005, 'Cortinas', 'Cortinas blackout', 6200, 25, 3);
GO


---------------------------------------------------------------------------------------



CREATE DATABASE Agenda;
GO


USE Agenda;
GO


IF OBJECT_ID('Contactos', 'U') IS NOT NULL
    DROP TABLE Contactos;
GO


CREATE TABLE Contactos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50),
    Apellido NVARCHAR(50),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100),
    Categoria NVARCHAR(50)
);
GO

INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, Categoria) VALUES
('Juan', 'Pérez', '123456789', 'juan.perez@gmail.com', 'Amigos'),
('Laura', 'García', '987654321', 'laura.garcia@yahoo.com', 'Trabajo'),
('Carlos', 'Martínez', '456123789', 'carlos.m@hotmail.com', 'Familia');
GO


--------------------------------------------------------------------------------------



CREATE DATABASE Tareas;
GO


USE Tareas;
GO


CREATE TABLE Usuario (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Contraseña NVARCHAR(100) NOT NULL
);
GO


CREATE TABLE Tarea (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(500),
    Prioridad NVARCHAR(20),
    FechaVencimiento DATE,
    Estado NVARCHAR(50),
    UsuarioId INT NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuario(Id)
);
GO


INSERT INTO Usuario (Nombre, Contraseña) VALUES
('Messi', '1234'),
('Chicho', 'abcd'),
('Leon XIV', 'soyelpapa');
GO


INSERT INTO Tarea (Titulo, Descripcion, Prioridad, FechaVencimiento, Estado, UsuarioId) VALUES
('Preparar informe', 'Informe mensual de ventas', 'Alta', '2025-05-10', 'Pendiente', 1),
('Revisar correos', 'Responder correos urgentes', 'Media', '2025-05-09', 'En Proceso', 1),
('Diseñar logo', 'Nuevo logo para campaña', 'Alta', '2025-05-15', 'Pendiente', 2),
('Actualizar sistema', 'Instalar nueva versión', 'Baja', '2025-05-12', 'Pendiente', 2),
('Reunión equipo', 'Coordinación semanal', 'Media', '2025-05-08', 'Completada', 3),
('Crear presentación', 'PowerPoint para clientes', 'Alta', '2025-05-11', 'En Proceso', 3);
GO

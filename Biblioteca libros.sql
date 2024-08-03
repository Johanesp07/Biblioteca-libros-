create database Biblioteca_Libros 
go 
use Biblioteca_Libros
go

-- Crear tabla Libros
CREATE TABLE Libros (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(100),
    Autor NVARCHAR(100),
    ISBN NVARCHAR(20),
    AnoPublicacion INT,
    NumeroPaginas INT
);

-- Insertar libros de ejemplo
INSERT INTO Libros (Titulo, Autor, ISBN, AñoPublicacion, NumeroPaginas) VALUES
('El Quijote', 'Miguel de Cervantes', '1234567890', 1605, 863),
'1984', 'George Orwell', '2345678901', 1949, 328),
('Cien Años de Soledad', 'Gabriel García Márquez', '3456789012', 1967, 417),
('Moby Dick', 'Herman Melville', '4567890123', 1851, 585);

-- Crear tabla Usuarios
CREATE TABLE usuario(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    NumeroSocio INT
);

-- Insertar usuarios de ejemplo
INSERT INTO Usuarios (Nombre, Apellido, NumeroSocio) VALUES
('Johan', 'Espinoza', 01),
('Andres', 'Alfaro', 02),
('Carlos', 'Sánchez', 03),
('María', 'Rodríguez', 04);

-- Crear tabla Prestamos
CREATE TABLE prestamo (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdLibro INT FOREIGN KEY REFERENCES Libros(Id),
    IdUsuario INT FOREIGN KEY REFERENCES Usuarios(Id),
    FechaPrestamo DATE,
    FechaDevolucion DATE
);
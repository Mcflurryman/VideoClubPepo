-- CREACIÓN DE BASE DE DATOS
--------------------------------------------------------
CREATE DATABASE PeliculasDB;
GO

USE PeliculasDB;
GO


-- TABLA: Peliculas
--------------------------------------------------------
CREATE TABLE Peliculas (
    Id INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Categoria VARCHAR(50),
    Duracion INT,
    estaDisponible BIT
);


-- TABLA: PeliculasDisponibles
--------------------------------------------------------
CREATE TABLE PeliculasDisponibles (
    IdPelicula INT PRIMARY KEY,
    Cantidad INT,
    FOREIGN KEY (IdPelicula) REFERENCES Peliculas(Id)
);


-- TABLA: AlquilerPeliculas
--------------------------------------------------------
CREATE TABLE AlquilerPeliculas (
    Id INT PRIMARY KEY,
    IdPelicula INT,
    nombreCliente VARCHAR(100),
    FechaAlquiler DATE,
    FechaDevolucion DATE NULL,
    FOREIGN KEY (IdPelicula) REFERENCES Peliculas(Id)
);



-- INSERTS: Peliculas  (PRIMERO)
--------------------------------------------------------
INSERT INTO Peliculas (Id, Nombre, Categoria, Duracion, estaDisponible) VALUES
(1, 'Inception', 'Ciencia ficción', 149, 1),
(2, 'Titanic', 'Romance', 195, 1),
(3, 'Gladiator', 'Acción', 155, 1),
(4, 'Avatar', 'Ciencia ficción', 162, 1),
(5, 'Toy Story', 'Animación', 81, 1),
(6, 'El Padrino 3', 'Drama', 177, 1),
(7, 'Interstellar', 'Ciencia ficción', 169, 1),
(8, 'Jurassic Park', 'Aventura', 127, 1),
(9, 'Matrix', 'Acción', 136, 1),
(10, 'Up', 'Animación', 96, 1),

(11, 'Pokemon 1', 'Fantasia', 145, 1),
(12, 'Pokemon 6', 'Fantasia', 180, 0),
(13, 'Pokemon 7', 'Fantasia', 180, 0),
(14, 'Pokemon 8', 'Fantasia', 180, 0),
(15, 'Pokemon 3', 'Fantasia', 180, 0),
(16, 'Pokemon 3', 'Fantasia', 180, 0),
(17, 'Pokemon 7', 'Fantasia', 180, 0),
(18, 'Pokemon 8', 'Fantasia', 180, 0),

(19, 'El Pikachu 1', 'Ficcion', 178, 1),
(20, 'El Pikachu 2', 'Ficcion', 178, 1),
(21, 'El Pikachu 3', 'Ficcion', 178, 1);
-- ⚠ IMPORTANTE: Ya NO metemos la película 22 (no existe)



-- INSERTS: PeliculasDisponibles (SEGUNDO)
--------------------------------------------------------
INSERT INTO PeliculasDisponibles (IdPelicula, Cantidad) VALUES
(1, 2),
(2, 5),
(3, 2),
(4, 3),
(5, 2),
(6, 3),
(7, 2),
(8, 5),
(9, 1);



-- INSERTS: AlquilerPeliculas (TERCERO)
--------------------------------------------------------
INSERT INTO AlquilerPeliculas (Id, IdPelicula, nombreCliente, FechaAlquiler, FechaDevolucion) VALUES
(1, 1, 'Carlos López', '2025-01-12', NULL),
(2, 3, 'Ana Torres', '2025-02-05', NULL),
(3, 6, 'Lucía Pérez', '2025-03-21', NULL),
(4, 5, 'Mario Sánchez', '2025-04-10', NULL),
(5, 9, 'Elena García', '2025-05-02', NULL),

(6, 5, 'Lucía Perez', '2025-03-21', '2025-11-08'),
(7, 5, 'Jonatan Luengo', '2025-03-21', NULL),
(8, 6, 'Jonatan Luengo', '2025-03-21', NULL),
(9, 7, 'Jonatan Luengo', '2025-03-21', '2025-11-08'),
(10, 8, 'Jonatan Luengo', '2025-03-21', '2025-11-08'),

(11, 9, 'Jonatan Luengo', '2025-11-06', NULL),
(12, 21, 'Jonatan Luengo', '2025-11-06', NULL),

-- ⚠ Se elimina el IdPelicula 22 porque NO existe
-- (13 era inválido → eliminado)

(14, 7, 'Jonatan Luengo', '2025-11-08', NULL),
(15, 6, 'Jonatan Luengo', '2025-11-08', NULL),
(16, 7, 'Jonatan', '2025-11-16', NULL),
(17, 4, 'jona', '2025-11-19', NULL),
(18, 3, 'aida', '2025-11-20', NULL),
(19, 3, 'aida', '2025-11-25', NULL),
(20, 5, 'jonatan', '2025-11-26', '2025-11-26');

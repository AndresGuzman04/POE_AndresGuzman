CREATE DATABASE clinica_animales

GO

USE clinica_animales;

CREATE TABLE pacientes(
id_paciente INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
nombre_paciente VARCHAR (50) NOT NULL,
edad_paciente INT NOT NULL,
)
GO 

CREATE TABLE propietarios(
id_propietario INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
nombre_propietario  VARCHAR (50) NOT NULL,
direccion  VARCHAR (50) NOT NULL
)

GO 

CREATE TABLE tratamientos (
id_tratamiento INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
tipo_tratamiento VARCHAR (50) NOT NULL,
precio  MONEY  NOT NULL
)

CREATE TABLE registros (
idRegistro INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
fecha_consulta DATETIME NOT NULL,
motivo_consulta VARCHAR(100)NOT NULL,
id_paciente INT FOREIGN KEY REFERENCES pacientes(Id_paciente),
id_propietario INT FOREIGN KEY REFERENCES propietarios(id_propietario),
id_tratamiento INT FOREIGN KEY REFERENCES tratamientos(id_tratamiento)
)

INSERT INTO pacientes(nombre_paciente, edad_paciente) VALUES ('Kaiser',4);
INSERT INTO pacientes(nombre_paciente, edad_paciente) VALUES ('Chucho',2);
INSERT INTO pacientes(nombre_paciente, edad_paciente) VALUES ('Michi',1);

INSERT INTO propietarios(nombre_propietario, direccion) VALUES ('Juan','Calle 1');
INSERT INTO propietarios(nombre_propietario, direccion) VALUES ('Pablo','Calle 2');
INSERT INTO propietarios(nombre_propietario, direccion) VALUES ('Pedro','Calle 3');

INSERT INTO tratamientos(tipo_tratamiento, precio) VALUES ('Tipo A', 5);
INSERT INTO tratamientos(tipo_tratamiento, precio) VALUES ('Tipo B', 10);
INSERT INTO tratamientos(tipo_tratamiento, precio) VALUES ('Tipo C', 15);

INSERT INTO registros (fecha_consulta, motivo_consulta, id_paciente, id_propietario, id_tratamiento) VALUES ('2023-09-23 14:30:00', 'Consulta de rutina', 1, 2, 3);
INSERT INTO registros (fecha_consulta, motivo_consulta, id_paciente, id_propietario, id_tratamiento) VALUES ('2023-09-23 14:30:00', 'Consulta de rutina', 2, 3, 3);
INSERT INTO registros (fecha_consulta, motivo_consulta, id_paciente, id_propietario, id_tratamiento) VALUES ('2023-09-23 14:30:00', 'Consulta de rutina', 3, 3, 3);

UPDATE registros SET id_tratamiento=1 WHERE idRegistro=1;
UPDATE pacientes SET nombre_paciente='Firu' WHERE id_paciente=2;
UPDATE propietarios SET direccion='Calle 25' WHERE id_propietario=3;

DELETE from registros WHERE idRegistro=1;

SELECT * FROM pacientes;
SELECT * FROM propietarios;
SELECT * FROM tratamientos;
SELECT * FROM registros;
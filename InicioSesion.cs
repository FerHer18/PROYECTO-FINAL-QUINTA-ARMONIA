using System;

use proyecto_quinta_armonia

CREATE TABLE Usuarios
(
        [Id] INT NOT NULL PRIMARY KEY,
        [Nombre] VARCHAR(100) NULL,
        [Cuenta] VARCHAR(100) NULL,
        [Contraseña] VARCHAR(15) NULL,
        [Monto] INT NOT NULL

);

select* from Usuarios;

insert into Usuarios values (357658, 'Valeria Bernal Salcedo', 'admin', 'val_05', 0),
                            (123456, 'Invitado', 'guest', '123', 0),
                            (522266, 'Fernando Gabriel Hernández Junco', 'usuario1', 'fer_18', 0),
                            (302307, 'Rosa Lizeth Suárez Medina', 'usuario2', 'rosy_30', 0),
                            (300058, 'Vanessa Carolina Torres Rojas', 'usuario3', 'vane_03', 0),
                            (300624, 'Valeria Paola Chávez Flores', 'usuario4', 'vale_11', 0);


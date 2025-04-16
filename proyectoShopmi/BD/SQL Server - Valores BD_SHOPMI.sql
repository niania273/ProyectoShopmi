USE BD_SHOPMI
GO

/* INSERCIONES */

-- ROL
INSERT INTO ROL (NOMBREROL, ESTROL) VALUES ('CLI', 1) -- Cliente
INSERT INTO ROL (NOMBREROL, ESTROL) VALUES ('VND', 1) -- Vendedor
INSERT INTO ROL (NOMBREROL, ESTROL) VALUES ('ADV', 1) -- Administrador de almac�n
INSERT INTO ROL (NOMBREROL, ESTROL) VALUES ('SPT', 1) -- Soporte
GO	

-- USUARIO
INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('48392812', 'Ram�rez Huam�n', 'Carlos', '1985-05-20', 'M', '945123456', 'c.ramirez@empresa.com', 'Empleado123', 1, 2);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('40382920', 'Quispe Soto', 'Andrea', '1990-09-12', 'F', '981234567', 'a.quispe@empresa.com', 'Empleado123', 1, 2);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('40839201', 'Torres Medina', 'Luis', '1992-07-08', 'M', '912345678', 'l.torres@gmail.com', 'Cliente123', 1, 2);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('47829301', 'Alvarado Ruiz', 'Sof�a', '1995-11-25', 'F', '987654321', 's.alvarado@hotmail.com', 'Cliente123', 1, 2);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('42918432', 'Gonzales R�os', 'Mart�n', '1991-02-17', 'M', '956782341', 'martin.gr@correo.com', 'PassMart1', 1, 1);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('42123456', 'V�squez L�pez', 'Claudia', '1993-03-22', 'F', '967834122', 'claudia.vl@empresa.com', 'PassClau2', 1, 1);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('43128977', 'C�ceres Poma', 'Jorge', '1988-12-10', 'M', '976123456', 'jorge.cp@correo.com', 'PassJor3', 1, 1);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('45267891', 'Meza Huerta', 'Patricia', '1994-06-05', 'F', '912345879', 'patricia.mh@empresa.com', 'PassPat4', 1, 1);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('46278901', 'Rojas Tejada', 'H�ctor', '1990-11-30', 'M', '964789132', 'hector.rt@empresa.com', 'PassHec5', 1, 1);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('49238721', 'Fern�ndez Luj�n', 'Daniela', '1996-08-18', 'F', '986531278', 'daniela.fl@gmail.com', 'CliDani1', 1, 2);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('40239817', 'Medina R�os', 'Sergio', '1991-01-04', 'M', '998123987', 'sergio.mr@gmail.com', 'CliSerg2', 1, 2);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('45819273', 'Guzm�n Pe�aloza', 'Andrea', '1998-02-09', 'F', '984561234', 'andrea.gp@hotmail.com', 'CliAnd3', 1, 2);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('41289347', 'Vega Salas', 'Ignacio', '1993-10-14', 'M', '971234987', 'ignacio.vs@yahoo.com', 'CliIgn4', 1, 2);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('48932175', 'Delgado Ramos', 'Luc�a', '1997-04-28', 'F', '974321654', 'lucia.dr@gmail.com', 'CliLuc5', 1, 2);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('47892341', 'Pe�a Torres', 'Renato', '1987-03-16', 'M', '935612348', 'renato.pt@empresa.com', 'EmpRen6', 1, 1);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('46982734', 'Ch�vez Herrera', 'Valeria', '1990-12-07', 'F', '956123456', 'valeria.ch@empresa.com', 'EmpVal7', 1, 1);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('41327849', 'Aguilar Pinto', 'Miguel', '1989-08-01', 'M', '985634712', 'miguel.ap@empresa.com', 'EmpMig8', 1, 1);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('49731248', 'Navarro Le�n', 'Mar�a', '1994-01-19', 'F', '963218745', 'maria.nl@empresa.com', 'EmpMar9', 1, 1);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('40321578', 'Campos Rivas', 'Enzo', '1992-05-22', 'M', '984513276', 'enzo.cr@empresa.com', 'EmpEnz10', 1, 1);

INSERT INTO USUARIO (NUMERODOCUMENTO, APEUSUARIO, NOMUSUARIO, FECNAC, SEXUSUARIO, TELUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('48821739', 'Morales Escobar', 'Valentina', '1999-09-03', 'F', '991234562', 'valentina.me@gmail.com', 'CliVal6', 1, 2);

-- CATEGORIA
INSERT INTO CATEGORIA (IMGCATEGORIA, NOMCATEGORIA, ESTCATEGORIA) 
VALUES ('smartphones.jpg', 'Smartphones y Accesorios', 1)
INSERT INTO CATEGORIA (IMGCATEGORIA, NOMCATEGORIA, ESTCATEGORIA) 
VALUES ('computo.jpg', 'Laptops y Equipos de C�mputo', 1)
INSERT INTO CATEGORIA (IMGCATEGORIA, NOMCATEGORIA, ESTCATEGORIA) 
VALUES ('audio.jpg', 'Audio y Accesorios Bluetooth', 1)
INSERT INTO CATEGORIA (IMGCATEGORIA, NOMCATEGORIA, ESTCATEGORIA) 
VALUES ('gaming.jpg', 'Gaming y Consolas', 1)
INSERT INTO CATEGORIA (IMGCATEGORIA, NOMCATEGORIA, ESTCATEGORIA) 
VALUES ('hogar-inteligente.jpg', 'Hogar Inteligente y Dom�tica', 1)
INSERT INTO CATEGORIA (IMGCATEGORIA, NOMCATEGORIA, ESTCATEGORIA) 
VALUES ('fotografia.jpg', 'C�maras y Fotograf�a Digital', 1)
GO

-- MARCA
INSERT INTO MARCA (NOMBREMARCA, ESTMARCA) VALUES ('Apple', 1)
INSERT INTO MARCA (NOMBREMARCA, ESTMARCA) VALUES ('Samsung', 1)
INSERT INTO MARCA (NOMBREMARCA, ESTMARCA) VALUES ('Xiaomi', 1)
INSERT INTO MARCA (NOMBREMARCA, ESTMARCA) VALUES ('Sony', 1)
INSERT INTO MARCA (NOMBREMARCA, ESTMARCA) VALUES ('HP', 1)
INSERT INTO MARCA (NOMBREMARCA, ESTMARCA) VALUES ('Lenovo', 1)
INSERT INTO MARCA (NOMBREMARCA, ESTMARCA) VALUES ('DJI', 1)
INSERT INTO MARCA (NOMBREMARCA, ESTMARCA) VALUES ('GoPro', 1)
INSERT INTO MARCA (NOMBREMARCA, ESTMARCA) VALUES ('Anker', 1)
INSERT INTO MARCA (NOMBREMARCA, ESTMARCA) VALUES ('TP-Link', 1)
GO

-- PRODUCTO --

-- SMARTPHONES
INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones1.jpg', 'iPhone 15 Pro Max 128GB', 'Smartphone de �ltima generaci�n con c�mara de 48 MP y rendimiento excepcional', 1299.99, 1, 50, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones2.jpg', 'Samsung Galaxy S24 Ultra 256GB', 'Pantalla Dynamic AMOLED 2X, 5G, c�mara de 200 MP y dise�o premium', 1499.99, 2, 40, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones3.jpg', 'Xiaomi Redmi Note 13 Pro+ 5G', 'Smartphone 5G con procesador potente, pantalla de 120Hz y c�mara de 200 MP', 499.99, 3, 60, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones4.jpg', 'Sony Xperia 1 IV', 'Smartphone con pantalla 4K OLED y c�mara avanzada para video y fotograf�a', 1299.99, 4, 30, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones5.jpg', 'HP Omen 45 Smartphone', 'Dise�o premium, potente rendimiento y gran pantalla para gamers', 799.99, 5, 25, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones6.jpg', 'Lenovo Legion Phone Duel 2', 'Smartphone gamer con dual cooling y pantalla de 144Hz', 999.99, 6, 35, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones7.jpg', 'GoPro HERO 11 Black', 'C�mara de acci�n que se puede vincular a tu smartphone, ideal para aventuras extremas', 399.99, 8, 45, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones8.jpg', 'Anker PowerCore 20000 mAh', 'Power bank de alta capacidad con carga r�pida para smartphones', 49.99, 9, 120, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones9.jpg', 'DJI OM 5 Smartphone Stabilizer', 'Estabilizador port�til para smartphones con control preciso', 159.99, 7, 100, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones10.jpg', 'TP-Link Tapo C200', 'C�mara de seguridad inteligente para tu smartphone con visi�n nocturna', 39.99, 10, 80, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones11.jpg', 'Funda Antigolpes para iPhone 15 Pro Max', 'Funda resistente a golpes, elegante y ligera, ideal para proteger tu iPhone 15 Pro Max', 29.99, 1, 200, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (1, 'smartphones12.jpg', 'Cargador R�pido Samsung 25W USB-C', 'Cargador r�pido original de 25W, ideal para todos los dispositivos Samsung', 24.99, 2, 150, 1)
GO

-- COMPUTO
INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo1.jpg', 'MacBook Air M2', 'Laptop ligera con chip Apple M2, ideal para productividad.', 1199.99, 1, 15, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo2.jpg', 'MacBook Pro 14"', 'Potente laptop para profesionales con chip M3 y pantalla Liquid Retina.', 1999.99, 1, 10, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo3.jpg', 'Samsung Galaxy Book3', 'Laptop ultradelgada con pantalla AMOLED y gran rendimiento.', 1099.99, 2, 8, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo4.jpg', 'Xiaomi RedmiBook Pro 15', 'Laptop con pantalla 2.5K y procesador Ryzen 7.', 899.99, 3, 12, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo5.jpg', 'Sony VAIO SX14', 'Laptop premium con dise�o ligero y pantalla 4K.', 1499.99, 4, 5, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo6.jpg', 'HP Pavilion x360', 'Laptop convertible con pantalla t�ctil y rendimiento vers�til.', 799.99, 5, 20, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo7.jpg', 'HP Victus Gaming', 'Laptop gamer con tarjeta gr�fica dedicada y buen enfriamiento.', 999.99, 5, 9, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo8.jpg', 'Lenovo IdeaPad 3', 'Laptop confiable para uso diario con excelente bater�a.', 649.99, 6, 25, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo9.jpg', 'Lenovo Legion 5 Pro', 'Laptop para gaming con pantalla de alta tasa de refresco.', 1299.99, 6, 6, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo10.jpg', 'Anker Docking Station', 'Estaci�n de acoplamiento USB-C para laptops.', 149.99, 9, 18, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo11 .jpg', 'TP-Link Adaptador USB WiFi 6', 'Mejora tu conexi�n con este adaptador WiFi r�pido.', 39.99, 10, 30, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (2, 'computo12.jpg', 'DJI Wireless Mouse', 'Mouse inal�mbrico con dise�o ergon�mico y precisi�n l�ser.', 59.99, 7, 14, 1)
GO

-- AUDIO
INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio1.jpg', 'AirPods Pro 2da Gen', 'Auriculares inal�mbricos con cancelaci�n activa de ruido.', 249.99, 1, 20, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio2.jpg', 'Samsung Galaxy Buds2 Pro', 'Auriculares con sonido Hi-Fi y ANC.', 199.99, 2, 15, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio3.jpg', 'Xiaomi Redmi Buds 4', 'Auriculares Bluetooth con buena autonom�a y calidad.', 39.99, 3, 30, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio4.jpg', 'Sony WH-1000XM5', 'Aud�fonos over-ear con cancelaci�n de ruido l�der en el mercado.', 349.99, 4, 10, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio5.jpg', 'HP Bluetooth Headset 400', 'Auriculares ligeros para uso diario y llamadas.', 59.99, 5, 25, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio6.jpg', 'Lenovo LP40 Pro', 'Auriculares Bluetooth compactos con sonido envolvente.', 29.99, 6, 40, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio7.jpg', 'Anker Soundcore Life Q30', 'Auriculares con cancelaci�n activa y bater�a de 40h.', 89.99, 9, 22, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio8.jpg', 'Anker Soundcore Liberty Air 2', 'Auriculares con micr�fono dual y carga inal�mbrica.', 99.99, 9, 18, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio9.jpg', 'GoPro Pro 3.5mm Mic Adapter', 'Adaptador de audio para c�maras GoPro.', 49.99, 8, 12, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio10.jpg', 'TP-Link UB500', 'Adaptador Bluetooth USB para conectar audio inal�mbrico.', 19.99, 10, 35, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio11.jpg', 'DJI Mic', 'Micr�fono inal�mbrico profesional ideal para grabaci�n de video.', 329.99, 7, 8, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (3, 'audio12.jpg', 'Sony SRS-XB13', 'Mini parlante Bluetooth con Extra Bass y resistencia al agua.', 59.99, 4, 17, 1)
GO

-- GAMING
INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming1', 'PlayStation 5', 'Consola de nueva generaci�n con SSD ultra r�pido y gr�ficos envolventes.', 499.99, 4, 10, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming2.jpg', 'Xbox Series X', 'Consola potente con capacidad 4K y biblioteca Xbox Game Pass.', 499.99, 5, 12, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming3.jpg', 'Nintendo Switch OLED', 'Consola h�brida port�til con pantalla OLED y juegos exclusivos.', 349.99, 1, 20, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming4.jpg', 'Mouse Gaming Logitech G502 HERO', 'Mouse ergon�mico con sensor de alta precisi�n.', 59.99, 5, 25, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming5.jpg', 'HP OMEN 16', 'Laptop gamer con GPU dedicada y pantalla de alta frecuencia.', 1299.99, 5, 8, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming6.jpg', 'Lenovo Legion Go', 'Consola port�til con sistema Windows para gaming completo.', 699.99, 6, 7, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming7.jpg', 'Mando Xbox Wireless', 'Control inal�mbrico con agarre mejorado y compatibilidad amplia.', 59.99, 5, 30, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming8.jpg', 'Anker Cargador Doble para Controles', 'Base de carga r�pida para mandos de consola.', 39.99, 9, 15, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming9.jpg', 'DJI GamePad Pro', 'Controlador ergon�mico para juegos m�viles y drones.', 89.99, 7, 5, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming10.jpg', 'GoPro MAX', 'C�mara 360 ideal para grabaciones inmersivas en VR y gaming.', 499.99, 8, 6, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming11.jpg', 'TP-Link Archer GX90', 'Router gaming con triple banda y optimizaci�n de latencia.', 229.99, 10, 10, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (4, 'gaming12.jpg', 'Sony INZONE H9', 'Auriculares gaming con cancelaci�n de ruido y audio espacial.', 279.99, 4, 9, 1)
GO

-- HOGAR INTELIGENTE
INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar1.jpg', 'Apple HomePod Mini', 'Altavoz inteligente con Siri y sonido envolvente.', 99.99, 1, 15, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar2.jpg', 'Samsung SmartThings Hub', 'Centro de control para dispositivos del hogar inteligente.', 89.99, 2, 10, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar3.jpg', 'Xiaomi Sensor de Temperatura y Humedad', 'Sensor inteligente para monitoreo ambiental.', 19.99, 3, 25, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar4.jpg', 'Sony Bravia XR OLED', 'Smart TV con inteligencia cognitiva y control por voz.', 1799.99, 4, 5, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar5.jpg', 'HP Smart Tank 7305', 'Impresora inal�mbrica con control v�a app.', 289.99, 5, 8, 1);

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar6.jpg', 'Lenovo Smart Clock 2', 'Reloj inteligente con pantalla t�ctil y Google Assistant.', 69.99, 6, 12, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar7.jpg', 'DJI Mini 2 SE', 'Drone compacto con retorno autom�tico y conexi�n a casa.', 399.99, 7, 6, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar8.jpg', 'GoPro Hero como c�mara de seguridad', 'C�mara vers�til para vigilancia dom�stica.', 299.99, 8, 10, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar9.jpg', 'Anker Eufy Video Doorbell', 'Timbre inteligente con c�mara y reconocimiento facial.', 179.99, 9, 9, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar10.jpg', 'TP-Link Tapo C200', 'C�mara de seguridad Wi-Fi con visi�n nocturna.', 39.99, 10, 18, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar11.jpg', 'TP-Link Tapo P100', 'Enchufe inteligente controlable desde el m�vil.', 24.99, 10, 30, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (5, 'hogar12.jpg', 'Anker Eufy Smart Bulb', 'Foco inteligente con control por voz y app.', 29.99, 9, 20, 1)
GO

-- FOTOGRAFIA
INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia1.jpg', 'GoPro HERO12 Black', 'C�mara de acci�n con grabaci�n 5.3K y estabilizaci�n avanzada.', 449.99, 8, 12, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia2.jpg', 'Sony Alpha A7 III', 'C�mara mirrorless full-frame con enfoque autom�tico preciso.', 1999.99, 4, 6, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia3.jpg', 'DJI Osmo Pocket 2', 'C�mara port�til con estabilizador y calidad 4K.', 349.99, 7, 10, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia4.jpg', 'HP Sprocket', 'Mini impresora fotogr�fica para m�viles con conexi�n Bluetooth.', 129.99, 5, 15, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia5.jpg', 'Anker Ring Light 10"', 'Aro de luz LED con soporte para selfies y grabaciones.', 49.99, 9, 25, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia6.jpg', 'Lenovo 500 FHD Webcam', 'C�mara web Full HD para videollamadas y grabaciones.', 59.99, 6, 20, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia7.jpg', 'TP-Link Tapo C325WB', 'C�mara exterior con ultra visi�n y tecnolog�a ColorPro.', 109.99, 10, 8, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia8.jpg', 'Samsung Galaxy Camera 2', 'C�mara compacta con Android y conectividad Wi-Fi.', 299.99, 2, 9, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia9.jpg', 'iPhone 15 Pro - Modo Cinem�tico', 'Smartphone con c�mara triple y grabaci�n en ProRes.', 1199.99, 1, 14, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia10.jpg', 'Sony ZV-E10', 'C�mara ideal para vlogging con pantalla abatible y micr�fono externo.', 749.99, 4, 7, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia11.jpg', 'DJI Mavic Air 2', 'Drone con c�mara 4K y modos inteligentes de fotograf�a.', 799.99, 7, 5, 1)

INSERT INTO PRODUCTO (CODCATEGORIA, IMGPRODUCTO, NOMPRODUCTO, DESCRIPCION, PREUNI, CODMARCA, STOCK, ESTPRODUCTO) 
VALUES (6, 'fotografia12.jpg', 'Xiaomi Mi 360� Home Camera 2K', 'C�mara de vigilancia con visi�n nocturna y control desde app.', 54.99, 3, 18, 1)
GO

-- PEDIDO
INSERT INTO PEDIDO (CODUSUARIO, FECPED, PRECIOTOTAL, ACTPED, ESTPED) VALUES 
(1, '2025-03-01', 250.50, 'Procesando', 1),
(2, '2025-03-02', 180.00, 'Enviado', 1),
(3, '2025-03-03', 320.75, 'Entregado', 1),
(4, '2025-03-04', 95.30, 'Cancelado', 0),
(5, '2025-03-05', 410.00, 'Procesando', 1),
(6, '2025-03-06', 212.99, 'Enviado', 1),
(7, '2025-03-07', 147.20, 'Procesando', 1),
(8, '2025-03-08', 305.50, 'Entregado', 1),
(9, '2025-03-09', 99.99, 'Cancelado', 0),
(10, '2025-03-10', 525.00, 'Procesando', 1),
(11, '2025-03-11', 183.45, 'Enviado', 1),
(12, '2025-03-12', 289.70, 'Entregado', 1),
(13, '2025-03-13', 150.25, 'Procesando', 1),
(14, '2025-03-14', 198.99, 'Cancelado', 0),
(15, '2025-03-15', 333.00, 'Procesando', 1),
(16, '2025-03-16', 268.40, 'Entregado', 1),
(17, '2025-03-17', 149.99, 'Enviado', 1),
(18, '2025-03-18', 440.10, 'Procesando', 1),
(19, '2025-03-19', 375.75, 'Entregado', 1),
(20, '2025-03-20', 295.30, 'Cancelado', 0);

-- DETALLEPEDIDO
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (1, 1, 12.80, 2, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (1, 3, 12.40, 1, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (2, 2, 10.00, 3, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (2, 4, 34.00, 2, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (3, 1, 9.70, 1, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (4, 5, 20.80, 2, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (5, 6, 70.45, 2, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (5, 2, 11.00, 1, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (6, 7, 50.10, 2, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (6, 8, 60.70, 1, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (7, 9, 30.20, 3, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (7, 10, 50.20, 2, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (8, 11, 80.90, 1, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (8, 12, 15.90, 1, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (9, 13, 59.50, 3, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (9, 14, 60.50, 2, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (10, 15, 10.50, 2, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (10, 16, 32.00, 1, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (10, 17, 23.00, 3, 1)
INSERT INTO DETALLEPEDIDO (CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP) VALUES (10, 18, 60.00, 4, 1)
GO

-- PAGO
INSERT INTO PAGO (CODPEDIDO, MONTOPAGO, FECPAGO, METPAGO, ESTPAGO) VALUES
(1, 250.50, '2025-03-01', 'TC', 1),
(2, 180.00, '2025-03-02', 'TB', 1),
(3, 320.75, '2025-03-03', 'TB', 1),
(4, 95.30, '2025-03-04', 'E', 0),
(5, 410.00, '2025-03-05', 'TC', 1),
(6, 212.99, '2025-03-06', 'TB', 1),
(7, 147.20, '2025-03-07', 'E', 1),
(8, 305.50, '2025-03-08', 'TD', 1),
(9, 99.99, '2025-03-09', 'TC', 0),
(10, 525.00, '2025-03-10', 'TB', 1),
(11, 183.45, '2025-03-11', 'E', 1),
(12, 289.70, '2025-03-12', 'E', 1),
(13, 150.25, '2025-03-13', 'TC', 1),
(14, 198.99, '2025-03-14', 'TB', 0),
(15, 333.00, '2025-03-15', 'TD', 1),
(16, 268.40, '2025-03-16', 'E', 1),
(17, 149.99, '2025-03-17', 'TC', 1),
(18, 440.10, '2025-03-18', 'TB', 1),
(19, 375.75, '2025-03-19', 'E', 1),
(20, 295.30, '2025-03-20', 'TB', 0);


-- DISTRITO
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES
('Cercado de Lima', '10001', 1),
('Barranco', '10002', 1),
('Bre�a', '10003', 1),
('Chorrillos', '10004', 1),
('El Agustino', '10005', 1),
('Independencia', '10006', 1),
('Jes�s Mar�a', '10007', 1),
('La Victoria', '10008', 1),
('Lince', '10009', 1),
('Los Olivos', '10010', 1),
('Magdalena del Mar', '10011', 1),
('Pueblo Libre', '10012', 1),
('Miraflores', '10013', 1),
('San Borja', '10015', 1),
('San Isidro', '10016', 1),
('San Luis', '10017', 1),
('San Mart�n de Porres', '10018', 1),
('San Miguel', '10019', 1),
('Santa Anita', '10020', 1),
('Santiago de Surco', '10021', 1),
('Surquillo', '10022', 1),
('Ate', '10028', 0),
('Comas', '10029', 0),
('La Molina', '10030', 1),
('San Juan de Lurigancho', '10031', 1),
('San Juan de Miraflores', '10032', 1)
GO

-- SUCURSAL
INSERT INTO SUCURSAL(NOMSUCURSAL, DIRSUCURSAL, ESTSUCURSAL, CODDISTRITO) VALUES ('Bloom Tower', 'Av. Javier Prado Oeste 2501', 1, 11)
GO

-- RECOJO
INSERT INTO RECOJO (CODPEDIDO, CODSUCURSAL, FECRECOJO) VALUES
(1, 1, '2025-03-01'),
(2, 1, '2025-03-02'),
(3, 1, '2025-03-03'),
(4, 1, '2025-03-04'),
(5, 1, '2025-03-05'),
(6, 1, '2025-03-06'),
(7, 1, '2025-03-07'),
(8, 1, '2025-03-08'),
(9, 1, '2025-03-09'),
(10, 1, '2025-03-10'),
(11, 1, '2025-03-11'),
(12, 1, '2025-03-12'),
(13, 1, '2025-03-13'),
(14, 1, '2025-03-14'),
(15, 1, '2025-03-15'),
(16, 1, '2025-03-16'),
(17, 1, '2025-03-17'),
(18, 1, '2025-03-18'),
(19, 1, '2025-03-19'),
(20, 1, '2025-03-20');

-- ENVIO
INSERT INTO ENVIO (CODPEDIDO, FECENVIO, ACTENVIO, DIRENVIO, CODDISTRITO) VALUES
(1, '2025-03-01', 'En tr�nsito', 'Av. Las Palmas 123, Lima', 1),
(2, '2025-03-02', 'En tr�nsito', 'Av. San Borja 456, Lima', 2),
(3, '2025-03-03', 'Entregado', 'Calle Larga 789, Lima', 3),
(4, '2025-03-04', 'Cancelado', 'Av. El Sol 321, Lima', 1),
(5, '2025-03-05', 'En tr�nsito', 'Calle Los Pinos 654, Lima', 2),
(6, '2025-03-06', 'Entregado', 'Av. Miraflores 888, Lima', 3),
(7, '2025-03-07', 'En tr�nsito', 'Calle del Sol 101, Lima', 1),
(8, '2025-03-08', 'Entregado', 'Av. Javier Prado 202, Lima', 2),
(9, '2025-03-09', 'En tr�nsito', 'Calle La Victoria 303, Lima', 3),
(10, '2025-03-10', 'Entregado', 'Av. Universitaria 404, Lima', 1),
(11, '2025-03-11', 'En tr�nsito', 'Calle San Juan 505, Lima', 2),
(12, '2025-03-12', 'Entregado', 'Av. Benavides 606, Lima', 3),
(13, '2025-03-13', 'En tr�nsito', 'Calle Los Olivos 707, Lima', 1),
(14, '2025-03-14', 'Cancelado', 'Av. Roca 808, Lima', 2),
(15, '2025-03-15', 'Entregado', 'Calle San Isidro 909, Lima', 3),
(16, '2025-03-16', 'En tr�nsito', 'Calle El Parque 1010, Lima', 1),
(17, '2025-03-17', 'Entregado', 'Av. La Marina 1111, Lima', 2),
(18, '2025-03-18', 'En tr�nsito', 'Calle La Libertad 1212, Lima', 3),
(19, '2025-03-19', 'Entregado', 'Av. Pardo 1313, Lima', 1),
(20, '2025-03-20', 'En tr�nsito', 'Calle Ayacucho 1414, Lima', 2);
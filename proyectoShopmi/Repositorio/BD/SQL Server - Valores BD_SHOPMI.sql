USE BD_SHOPMI
GO

/* INSERCIONES */

-- ROL
INSERT INTO ROL (NOMBREROL, ESTROL) VALUES ('ADM', 1) -- Administrador
INSERT INTO ROL (NOMBREROL, ESTROL) VALUES ('VND', 1) -- Vendedor
INSERT INTO ROL (NOMBREROL, ESTROL) VALUES ('CJR', 1) -- Cajero
INSERT INTO ROL (NOMBREROL, ESTROL) VALUES ('SPT', 1) -- Soporte
GO	

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

-- DISTRITO
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Cercado de Lima', '10001', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Barranco', '10002', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Bre�a', '10003', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Chorrillos', '10004', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('El Agustino', '10005', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Independencia', '10006', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Jes�s Mar�a', '10007', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('La Victoria', '10008', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Lince', '10009', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Los Olivos', '10010', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Magdalena del Mar', '10011', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Pueblo Libre', '10012', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Miraflores', '10013', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('San Borja', '10015', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('San Isidro', '10016', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('San Luis', '10017', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('San Mart�n de Porres', '10018', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('San Miguel', '10019', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Santa Anita', '10020', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Santiago de Surco', '10021', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Surquillo', '10022', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Ate', '10028', 0)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('Comas', '10029', 0)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('La Molina', '10030', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('San Juan de Lurigancho', '10031', 1)
INSERT INTO DISTRITO (NOMBREDISTRITO, CODPOSTAL, ESTDISTRITO) VALUES ('San Juan de Miraflores', '10032', 1)
GO

-- CLIENTE
INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('11234567', 'Novikov Petrov', 'Maxim Ivan', 2, 'Av. Ricardo El�as Aparicio 740', '2000-05-12', 'M', 'novikow.maxim@gmail.com', '987654321', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('87654321', 'G�mez P�rez', 'Laura Sof�a', 3, 'Av. Centenario, 25', '2000-05-12', 'F', 'g�mez.laura@gmail.com', '976543210', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('34567890', 'Mercedes L�pez', 'Mario Alberto', 4, 'Jr 28 De Julio 537 A, Cercado', '1987-08-10', 'M', 'mercedes.mario@gmail.com', '965432109', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('98765432', 'Garc�a Ruiz', 'Ester Mar�a', 7, 'Los Cedros 209', '2002-10-11', 'F', 'garcia.ester@gmail.com', '954321098', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('12345678', 'Rodr�guez S�nchez', 'Jos� Luis', 2, 'Jr. Ucayali N� 388 ', '1989-03-21', 'M', 'rodriguez.jose@gmail.com', '943210987', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('87654320', 'Mart�nez Vargas', 'Rodrigo Andr�s', 8, 'Jr. Caman� 616 ', '1999-10-17', 'M', 'martinez.rodrigo@gmail.com', '932109876', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('09876543', 'Gonz�les Torres', 'Fabrizio Daniel', 6, 'Jr Maria Montesori 150', '2002-01-13', 'M', 'gonzales.fabrizio@gmail.com', '921098765', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('23456789', 'Ru�z Castillo', 'Sandra Milena', 9, 'AV De La Poesia 160', '1992-09-26', 'F', 'ru�z.sandra@gmail.com', '910987654', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('11223344', 'D�az Flores', 'Raquel Elena', 10, 'AV Las Casuarinas 250', '1995-07-19', 'F', 'd�az.raquel@gmail.com', '999876543', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('55667788', 'Mu�oz Herrera', 'Diego Armando', 2, 'AV Arenales 1302', '2003-10-08', 'M', 'mu�oz.diego@gmail.com', '988765432', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('33445566', '�lvarez Mendoza', 'Javier Eduardo', 3, 'Av. Abancay Cuadra 5', '1994-02-27', 'M', '�lvarez.javier@gmail.com', '977654321', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('29876543', 'Navarro Ortiz', 'Sergio Antonio', 5, 'Av. Paseo de la Rep�blica', '1998-06-15', 'M', 'navarro.sergio@gmail.com', '966543210', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('77889900', 'Morales Vega', 'Vanessa Luc�a', 1, 'Jr Ciro Alegria 430', '2001-01-11', 'F', 'morales.vanessa@gmail.com', '955432109', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('P1234567', 'Han Zhang', 'Jie Wei', 7, 'Jr San Agustin Zea 200', '1986-07-04', 'M', 'han.jie@gmail.com', '944321098', 1)

INSERT INTO CLIENTE (NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
VALUES ('99001122', 'V�squez Ramos', 'Ana Patricia', 4, 'JR 2 De Mayo 107', '1993-02-05', 'F', 'vasquez.ana@gmail.com', '933210987', 1)

-- EMPLEADO
INSERT INTO EMPLEADO (NUMERODOCUMENTO, APELLIDOS, NOMBRES,  CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, ESTEMPLEADO)
VALUES ('72556891', 'Lopez', 'Juan', 4, 'av. jos� larco 40', '1994-05-12', 'M', 'juan.lopez@gmail.com', 1)

INSERT INTO EMPLEADO (NUMERODOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, ESTEMPLEADO)
VALUES ('72902765', 'Mercedes', 'Lorena', 1, 'jir�n jos� galvez 895', '1991-03-06', 'F', 'lorena.mercedes@gmail.com', 1)

INSERT INTO EMPLEADO (NUMERODOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, ESTEMPLEADO)
VALUES ('65247938', 'Caceres', 'Luis', 6, 'jr. los amautas 180', '1992-07-10', 'M', 'luis.caceres@gmail.com', 1)

INSERT INTO EMPLEADO (NUMERODOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, ESTEMPLEADO)
VALUES ('63822909', 'Jim�nez', 'Laura', 3, 'jr. sol 357', '1986-12-15', 'F', 'laura.jimenez@mail.com', 1)
GO

INSERT INTO EMPLEADO (NUMERODOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, ESTEMPLEADO)
VALUES ('75893021', 'Perez', 'Ana', 2, 'av. la paz 123', '1995-08-22', 'F', 'ana.perez@gmail.com', 1)

INSERT INTO EMPLEADO (NUMERODOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, ESTEMPLEADO)
VALUES ('75102834', 'Gomez', 'Carlos', 5, 'jr. belgrano 456', '1990-11-12', 'M', 'carlos.gomez@gmail.com', 1)

INSERT INTO EMPLEADO (NUMERODOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, ESTEMPLEADO)
VALUES ('77632478', 'Vega', 'Elena', 7, 'av. jorge chavez 789', '1988-04-07', 'F', 'elena.vega@gmail.com', 1)

INSERT INTO EMPLEADO (NUMERODOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, ESTEMPLEADO)
VALUES ('72485367', 'Salazar', 'Ricardo', 4, 'av. las americas 321', '1993-02-15', 'M', 'ricardo.salazar@gmail.com', 1)

INSERT INTO EMPLEADO (NUMERODOCUMENTO, APELLIDOS, NOMBRES, CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, ESTEMPLEADO)
VALUES ('73487261', 'Romero', 'Sofia', 2, 'jr. los pinos 567', '1996-09-30', 'F', 'sofia.romero@gmail.com', 1)
GO

-- USUARIO
INSERT INTO USUARIO (APEUSUARIO, NOMUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODEMPLEADO, CODROL)
VALUES ('Lopez', 'Juan', 'juan.lopez@gmail.com', 'Contrase�aGenerada123', 1, 1, 1)

INSERT INTO USUARIO (APEUSUARIO, NOMUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODEMPLEADO, CODROL)
VALUES ('Mercedes', 'Lorena', 'lorena.mercedes@gmail.com', 'Contrase�aGenerada123', 1, 1, 1)

INSERT INTO USUARIO (APEUSUARIO, NOMUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODEMPLEADO, CODROL)
VALUES ('Caceres', 'Luis', 'luis.caceres@gmail.com', 'Contrase�aGenerada123', 1, 1, 1)

INSERT INTO USUARIO (APEUSUARIO, NOMUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODEMPLEADO, CODROL)
VALUES ('Jim�nez', 'Laura', 'laura.jimenez@mail.com', 'Contrase�aGenerada123', 4, 1, 1)

INSERT INTO USUARIO (APEUSUARIO, NOMUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('Ataulluco', 'Ashly', 'ashly.ataulluco@gmail.com', 'ashly123', 1, 1) -- Rol Administrador

INSERT INTO USUARIO (APEUSUARIO, NOMUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES('Hidalgo', 'Eyen', 'eyen.hidalgo@gmail.com', 'eyen123', 1, 2) -- Rol Vendedor 

INSERT INTO USUARIO (APEUSUARIO, NOMUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('Arteaga', 'Miguel', 'miguel.arteaga@gmail.com', 'miguel123', 1, 3) -- Rol Cajero

INSERT INTO USUARIO (APEUSUARIO, NOMUSUARIO, CORUSUARIO, CONUSUARIO, ESTUSUARIO, CODROL)
VALUES ('Reyna', 'Sabrina', 'sabrina.reyna@gmail.com', 'sabrina123', 1, 4) -- Rol Soporte
GO

-- PEDIDO
INSERT INTO PEDIDO (CODCLIENTE, CODEMPLEADO, FECPED, ACTPED, ESTPED) VALUES (1, 2, '2025-03-01', 'Procesando', 1)
INSERT INTO PEDIDO (CODCLIENTE, CODEMPLEADO, FECPED, ACTPED, ESTPED) VALUES (2, 3, '2025-03-02', 'Enviado', 1)
INSERT INTO PEDIDO (CODCLIENTE, CODEMPLEADO, FECPED, ACTPED, ESTPED) VALUES (3, 1, '2025-03-03', 'Pendiente', 1)
INSERT INTO PEDIDO (CODCLIENTE, CODEMPLEADO, FECPED, ACTPED, ESTPED) VALUES (4, 4, '2025-03-04', 'Entregado', 1)
INSERT INTO PEDIDO (CODCLIENTE, CODEMPLEADO, FECPED, ACTPED, ESTPED) VALUES (5, 5, '2025-03-05', 'Cancelado', 0)
INSERT INTO PEDIDO (CODCLIENTE, CODEMPLEADO, FECPED, ACTPED, ESTPED) VALUES (6, 2, '2025-03-06', 'En proceso', 1)
INSERT INTO PEDIDO (CODCLIENTE, CODEMPLEADO, FECPED, ACTPED, ESTPED) VALUES (7, 3, '2025-03-07', 'Pendiente', 1)
INSERT INTO PEDIDO (CODCLIENTE, CODEMPLEADO, FECPED, ACTPED, ESTPED) VALUES (8, 1, '2025-03-08', 'Entregado', 1)
INSERT INTO PEDIDO (CODCLIENTE, CODEMPLEADO, FECPED, ACTPED, ESTPED) VALUES (9, 4, '2025-03-09', 'Enviado', 1)
INSERT INTO PEDIDO (CODCLIENTE, CODEMPLEADO, FECPED, ACTPED, ESTPED) VALUES (10, 5, '2025-03-10', 'Cancelado', 0)
GO

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
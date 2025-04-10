--- PROCEDIMIENTOS ALMACENADOS ---

-- Usamos la bd -- 
Use BD_SHOPMI	
Go

-------------------
---- CATEGORIA ---- 
-------------------

--- GET ---
CREATE OR ALTER PROC USP_GET_CATEGORIA
@ESTCATEGORIA BIT = 1
AS
BEGIN
	IF @ESTCATEGORIA = 1
		SELECT 
		CA.CODCATEGORIA,
		CA.IMGCATEGORIA,
		CA.NOMCATEGORIA
		FROM CATEGORIA AS CA
		WHERE CA.ESTCATEGORIA = 1
	ELSE
		SELECT 
		CA.CODCATEGORIA,
		CA.IMGCATEGORIA,
		CA.NOMCATEGORIA
		FROM CATEGORIA AS CA	
END
GO

--EXEC dbo.USP_GET_CATEGORIA

--- GET ID --- 
CREATE OR ALTER PROC USP_GET_ID_CATEGORIA
    @CODCATEGORIA INT
AS
BEGIN
    SELECT CA.CODCATEGORIA,
     	   CA.IMGCATEGORIA,
		   CA.NOMCATEGORIA
	FROM CATEGORIA AS CA
	WHERE CA.CODCATEGORIA = @CODCATEGORIA
END
GO

--EXEC dbo.USP_GET_ID_CATEGORIA @CODCATEGORIA = 2

--- POST/ PUT ---
CREATE OR ALTER PROC USP_MERGE_CATEGORIA
    @CODCATEGORIA INT,
    @IMGCATEGORIA VARCHAR(50),
    @NOMCATEGORIA VARCHAR(50),
    @ESTCATEGORIA BIT
AS
BEGIN
    MERGE CATEGORIA AS target
    USING (SELECT @CODCATEGORIA AS CODCATEGORIA) AS source
    ON target.CODCATEGORIA = source.CODCATEGORIA
    WHEN MATCHED THEN
        UPDATE SET
            IMGCATEGORIA = @IMGCATEGORIA,
            NOMCATEGORIA = @NOMCATEGORIA,
            ESTCATEGORIA = @ESTCATEGORIA
    WHEN NOT MATCHED THEN
        INSERT (IMGCATEGORIA, NOMCATEGORIA, ESTCATEGORIA)
        VALUES (@IMGCATEGORIA, @NOMCATEGORIA, @ESTCATEGORIA);
END
GO

--- DELETE ---
CREATE OR ALTER PROC USP_DELETE_CATEGORIA
	@CODCATEGORIA INT
AS
BEGIN
	UPDATE CATEGORIA SET ESTCATEGORIA = 0 WHERE CODCATEGORIA = @CODCATEGORIA
END
GO

--- ENABLE ---
CREATE OR ALTER PROC USP_ENABLE_CATEGORIA
	@CODCATEGORIA INT
AS
BEGIN
	UPDATE CATEGORIA SET ESTCATEGORIA = 1 WHERE CODCATEGORIA = @CODCATEGORIA
END
GO

---------------
---- MARCA ----
---------------

--- GET ---
CREATE OR ALTER PROC USP_GET_MARCA
@ESTMARCA BIT = 1
AS
BEGIN
	IF @ESTMARCA = 1
		SELECT
		MA.CODMARCA,
		MA.NOMBREMARCA
		FROM MARCA AS MA
		WHERE MA.ESTMARCA = @ESTMARCA
	ELSE
		SELECT
		MA.CODMARCA,
		MA.NOMBREMARCA
		FROM MARCA AS MA
END
GO

--EXEC dbo.USP_GET_MARCA

--- GET ID ---
CREATE OR ALTER PROC USP_GET_ID_MARCA
	@CODMARCA INT
AS
BEGIN
	SELECT MA.CODMARCA,
	       MA.NOMBREMARCA
	FROM MARCA AS MA
	WHERE MA.CODMARCA = @CODMARCA
	AND MA.ESTMARCA = 1
END
GO

--EXEC dbo.USP_GET_ID_MARCA @CODMARCA = 8

--- POST/PUT ---
CREATE OR ALTER PROC USP_MERGE_MARCA
	@CODMARCA INT,
	@NOMBREMARCA VARCHAR(25),
	@ESTMARCA BIT
AS
BEGIN
	MERGE MARCA AS target
	USING(SELECT @CODMARCA AS CODMARCA) AS source
	ON target.CODMARCA = source.CODMARCA
	WHEN MATCHED THEN
		UPDATE SET
			NOMBREMARCA = @NOMBREMARCA,
			ESTMARCA = @ESTMARCA
	WHEN NOT MATCHED THEN
		INSERT(NOMBREMARCA, ESTMARCA)
		VALUES(@NOMBREMARCA, @ESTMARCA);
END
GO

--- DELETE --- 
CREATE OR ALTER PROC USP_DELETE_MARCA
	@CODMARCA INT
AS
BEGIN
	UPDATE MARCA SET ESTMARCA = 0 WHERE CODMARCA = @CODMARCA
END
GO

--- ENABLE ---
CREATE OR ALTER PROC USP_ENABLE_MARCA
	@CODMARCA INT
AS
BEGIN
	UPDATE MARCA SET ESTMARCA = 1 WHERE CODMARCA = @CODMARCA
END
GO

------------------
---- DISTRITO ----
------------------

--- GET ---
CREATE OR ALTER PROC USP_GET_DISTRITO
@ESTDISTRITO BIT = 1
AS
BEGIN
	IF @ESTDISTRITO = 1
		SELECT
		DI.CODDISTRITO,
		DI.NOMBREDISTRITO,
		DI.CODPOSTAL
		FROM DISTRITO AS DI
		WHERE DI.ESTDISTRITO = @ESTDISTRITO
	ELSE 
		SELECT
		DI.CODDISTRITO,
		DI.NOMBREDISTRITO,
		DI.CODPOSTAL
		FROM DISTRITO AS DI
END
GO

--EXEC dbo.USP_GET_DISTRITO


-----------------
---- CLIENTE ----
-----------------

--- GET ---
CREATE OR ALTER PROC USP_GET_CLIENTE
AS
BEGIN
	SELECT 
	CL.CODCLIENTE,
	CL.NUMEROCOMDOCUMENTO,
	CL.APELLIDOS,
	CL.NOMBRES,
	D.CODDISTRITO,
	CL.DIRECCION,
	CL.FECNAC,
	CL.SEXO
	FROM CLIENTE AS CL
	INNER JOIN DISTRITO D ON CL.CODDISTRITO = D.CODDISTRITO
	WHERE CL.ESTCLIENTE = 1
END
GO

--EXEC dbo.USP_GET_CLIENTE

--- GET ID ---
CREATE OR ALTER PROC USP_GET_ID_CLIENTE
	@CODCLIENTE INT
AS
BEGIN
	SELECT 
	CL.CODCLIENTE,
	CL.NUMEROCOMDOCUMENTO,
	CL.APELLIDOS,
	CL.NOMBRES,
	D.CODDISTRITO,
	CL.DIRECCION,
	CL.FECNAC,
	CL.SEXO
	FROM CLIENTE AS CL
	INNER JOIN DISTRITO D ON CL.CODDISTRITO = D.CODDISTRITO
	WHERE CL.CODCLIENTE = @CODCLIENTE
END
GO

--EXEC dbo.USP_GET_ID_CLIENTE @CODCLIENTE = 10

--- POST/PUT ---
CREATE OR ALTER PROC USP_GET_MERGE_CLIENTE
	@CODCLIENTE  INT,
	@NUMEROCOMDOCUMENTO CHAR(8),
	@APELLIDOS VARCHAR(50),
	@NOMBRES VARCHAR(50),
	@CODDISTRITO INT,
	@DIRECCION VARCHAR(150), 
	@FECNAC DATE,
	@SEXO CHAR(1),
	@CORREO VARCHAR(50),
	@TELEFONO CHAR(9),
	@ESTCLIENTE BIT
AS
BEGIN
	MERGE CLIENTE AS target
	USING(SELECT @CODCLIENTE AS CODCLIENTE) AS source
	ON target.CODCLIENTE = source.CODCLIENTE
	WHEN MATCHED THEN
		UPDATE SET
			NUMEROCOMDOCUMENTO = @NUMEROCOMDOCUMENTO,
			APELLIDOS = @APELLIDOS,
			NOMBRES = @NOMBRES,
			CODDISTRITO = @CODDISTRITO,
			DIRECCION = @DIRECCION,
			FECNAC = @FECNAC,
			SEXO = @SEXO,
			CORREO = @CORREO,
			TELEFONO = @TELEFONO,
			ESTCLIENTE = @ESTCLIENTE
	WHEN NOT MATCHED THEN
		INSERT(NUMEROCOMDOCUMENTO, APELLIDOS, NOMBRES,
		CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, TELEFONO, ESTCLIENTE)
		VALUES(@NUMEROCOMDOCUMENTO, @APELLIDOS, @NOMBRES,
		@CODDISTRITO, @DIRECCION, @FECNAC, @SEXO, @CORREO, @TELEFONO, @ESTCLIENTE);
END
GO

--- DELETE ---
CREATE OR ALTER PROC USP_DELETE_CLIENTE
	@CODCLIENTE INT
AS
BEGIN
	UPDATE CLIENTE SET ESTCLIENTE = 0 WHERE CODCLIENTE = @CODCLIENTE
END
GO

--- ENABLE ---
CREATE OR ALTER PROC USP_ENABLE_CLIENTE
	@CODCLIENTE INT
AS
BEGIN
	UPDATE CLIENTE SET ESTCLIENTE = 1 WHERE CODCLIENTE = @CODCLIENTE
END
GO

------------------
---- EMPLEADO ----
------------------

--- GET ---
CREATE OR ALTER PROC USP_GET_EMPLEADO
@ESTEMPLEADO BIT = 1
AS
BEGIN
	IF @ESTEMPLEADO = 1
		SELECT 
		EM.CODEMPLEADO,
		EM.NUMERODOCUMENTO,
		EM.APELLIDOS,
		EM.NOMBRES,
		D.CODDISTRITO,
		EM.DIRECCION,
		EM.FECNAC,
		EM.SEXO,
		EM.CORREO
		FROM EMPLEADO AS EM
		INNER JOIN DISTRITO D ON EM.CODDISTRITO = D.CODDISTRITO
		WHERE EM.ESTEMPLEADO = 1
	ELSE
		SELECT 
		EM.CODEMPLEADO,
		EM.NUMERODOCUMENTO,
		EM.APELLIDOS,
		EM.NOMBRES,
		D.CODDISTRITO,
		EM.DIRECCION,
		EM.FECNAC,
		EM.SEXO,
		EM.CORREO
		FROM EMPLEADO AS EM
		INNER JOIN DISTRITO D ON EM.CODDISTRITO = D.CODDISTRITO
END
GO

--EXEC dbo.USP_GET_EMPLEADO

--- GET ID ---
CREATE OR ALTER PROC USP_GET_ID_EMPLEADO
	@CODEMPLEADO INT
AS
BEGIN
	SELECT 
	EM.CODEMPLEADO,
	EM.NUMERODOCUMENTO,
	EM.APELLIDOS,
	EM.NOMBRES,
	D.CODDISTRITO,
	EM.DIRECCION,
	EM.FECNAC,
	EM.SEXO,
	EM.CORREO
	FROM EMPLEADO AS EM
	INNER JOIN DISTRITO D ON EM.CODDISTRITO = D.CODDISTRITO
	WHERE CODEMPLEADO = @CODEMPLEADO
END
GO

--EXEC dbo.USP_GET_ID_EMPLEADO @CODEMPLEADO = 8

--- POST/PUT ---
CREATE OR ALTER PROC USP_MERGE_EMPLEADO
    @CODEMPLEADO INT,
	@CODDOCUMENTO INT,
	@NUMERODOCUMENTO VARCHAR(50),
	@APELLIDOS VARCHAR(50),
	@NOMBRES VARCHAR(50),
	@CODDISTRITO INT,
	@DIRECCION VARCHAR(150), 
	@FECNAC DATE,
	@SEXO CHAR(1),
	@CORREO VARCHAR(50),
	@ESTEMPLEADO BIT
AS
BEGIN

	MERGE EMPLEADO AS target
	USING(SELECT @CODEMPLEADO AS CODEMPLEADO) AS source
	ON target.CODEMPLEADO = source.CODEMPLEADO
	WHEN MATCHED THEN
		UPDATE SET
			NUMERODOCUMENTO = @NUMERODOCUMENTO,
			APELLIDOS = @APELLIDOS,
			NOMBRES = @NOMBRES,
			CODDISTRITO = @CODDISTRITO,
			DIRECCION = @DIRECCION,
			FECNAC = @FECNAC,
			SEXO = @SEXO,
			CORREO = @CORREO,
			ESTEMPLEADO = @ESTEMPLEADO
	WHEN NOT MATCHED THEN
		INSERT(NUMERODOCUMENTO, APELLIDOS, NOMBRES,
		CODDISTRITO, DIRECCION, FECNAC, SEXO, CORREO, ESTEMPLEADO)
		VALUES(@NUMERODOCUMENTO, @APELLIDOS, @NOMBRES,
		@CODDISTRITO, @DIRECCION, @FECNAC, @SEXO, @CORREO, @ESTEMPLEADO);
END
GO

--- DELETE ---
CREATE OR ALTER PROC USP_DELETE_EMPLEADO
	@CODEMPLEADO INT
AS
BEGIN
	UPDATE EMPLEADO SET ESTEMPLEADO = 0 WHERE CODEMPLEADO = @CODEMPLEADO
END
GO

--- ENABLE ---
CREATE OR ALTER PROC USP_ENABLE_EMPLEADO
	@CODEMPLEADO INT
AS
BEGIN
	UPDATE EMPLEADO SET ESTEMPLEADO = 1 WHERE CODEMPLEADO = @CODEMPLEADO
END
GO

-----------------
---- USUARIO ----
-----------------

--- GET ---
CREATE OR ALTER PROC USP_GET_USUARIO
@ESTUSUARIO BIT = 1
AS
BEGIN
	IF @ESTUSUARIO = 1	
		SELECT
		U.CODUSUARIO,
		U.APEUSUARIO,
		U.NOMUSUARIO,
		U.CORUSUARIO,
		U.FECCRE,
		EM.CODEMPLEADO,
		R.NOMBREROL AS ROL
		FROM USUARIO AS U
		INNER JOIN EMPLEADO EM ON U.CODEMPLEADO = EM.CODEMPLEADO
		INNER JOIN ROL R ON U.CODROL = R.CODROL
		WHERE U.ESTUSUARIO = 1
	ELSE
		SELECT
		U.CODUSUARIO,
		U.APEUSUARIO,
		U.NOMUSUARIO,
		U.CORUSUARIO,
		U.FECCRE,
		EM.CODEMPLEADO,
		R.NOMBREROL AS ROL
		FROM USUARIO AS U
		INNER JOIN EMPLEADO EM ON U.CODEMPLEADO = EM.CODEMPLEADO
		INNER JOIN ROL R ON U.CODROL = R.CODROL
END
GO

--EXEC dbo.USP_GET_USUARIO

--- GET ID ---
CREATE OR ALTER PROC USP_GET_ID_USUARIO
	@CODUSUARIO INT
AS
BEGIN
	SELECT
	U.CODUSUARIO,
	U.APEUSUARIO,
	U.NOMUSUARIO,
	U.CORUSUARIO,
	U.FECCRE,
	EM.CODEMPLEADO,
	R.NOMBREROL AS ROL
	FROM USUARIO AS U
	INNER JOIN EMPLEADO EM ON U.CODEMPLEADO = EM.CODEMPLEADO
	INNER JOIN ROL R ON U.CODROL = R.CODROL
	WHERE CODUSUARIO = @CODUSUARIO
END
GO

--EXEC dbo.USP_GET_ID_USUARIO @CODUSUARIO = 3

--- POST/PUT ---
CREATE OR ALTER PROC USP_MERGE_USUARIO
	@CODUSUARIO INT,
	@APEUSUARIO VARCHAR(50),
	@NOMUSUARIO VARCHAR(50),
	@CORUSUARIO VARCHAR(100),
	@CONUSUARIO VARCHAR(50),
	@FECCRE DATETIME,
	@ESTUSUARIO BIT,
	@CODEMPLEADO INT,
	@CODROL INT
AS
BEGIN
	MERGE USUARIO AS target
	USING(SELECT @CODUSUARIO AS CODUSUARIO) AS source
	ON target.CODUSUARIO = source.CODUSUARIO
	WHEN MATCHED THEN
		UPDATE SET
			APEUSUARIO = @APEUSUARIO,
			NOMUSUARIO = @NOMUSUARIO,
			CORUSUARIO = @CORUSUARIO,
			CONUSUARIO = @CONUSUARIO,
			FECCRE = @FECCRE,
			ESTUSUARIO = @ESTUSUARIO,
			CODEMPLEADO = @CODEMPLEADO,
			CODROL = @CODROL
	WHEN NOT MATCHED THEN
		INSERT(APEUSUARIO, NOMUSUARIO, CORUSUARIO, CONUSUARIO,
		FECCRE, ESTUSUARIO, CODEMPLEADO, CODROL)
		VALUES(@APEUSUARIO, @NOMUSUARIO, @CORUSUARIO, @CONUSUARIO,
		@FECCRE, @ESTUSUARIO, @CODEMPLEADO, @CODROL);
END
GO

--- DELETE ---
CREATE OR ALTER PROC USP_DELETE_USUARIO
	@CODUSUARIO INT
AS
BEGIN
	UPDATE USUARIO SET ESTUSUARIO = 0 WHERE CODUSUARIO = @CODUSUARIO
END
GO

--- ENABLE ---
CREATE OR ALTER PROC USP_ENABLE_USUARIO
	@CODUSUARIO INT
AS
BEGIN
	UPDATE USUARIO SET ESTUSUARIO = 1 WHERE CODUSUARIO = @CODUSUARIO
END
GO

----------------
---- PEDIDO ----
----------------

--- GET ---
CREATE OR ALTER PROC USP_GET_PEDIDO
@ESTPED BIT = 1
AS
BEGIN
	IF @ESTPED = 1	
		SELECT
		P.CODPEDIDO,
		CL.CODCLIENTE,
		EM.CODEMPLEADO,
		P.FECPED,
		P.PRECIOTOTAL,
		P.ACTPED
		FROM PEDIDO AS P
		INNER JOIN CLIENTE CL ON P.CODCLIENTE = CL.CODCLIENTE
		INNER JOIN EMPLEADO EM ON P.CODEMPLEADO = EM.CODEMPLEADO
		WHERE P.ESTPED = 1
	ELSE
		SELECT
		P.CODPEDIDO,
		CL.CODCLIENTE,
		EM.CODEMPLEADO,
		P.FECPED,
		P.PRECIOTOTAL,
		P.ACTPED
		FROM PEDIDO AS P
		INNER JOIN CLIENTE CL ON P.CODCLIENTE = CL.CODCLIENTE
		INNER JOIN EMPLEADO EM ON P.CODEMPLEADO = EM.CODEMPLEADO
END
GO

--EXEC dbo.USP_GET_PEDIDO

--- GET ID ---
CREATE OR ALTER PROC USP_GET_ID_PEDIDO
	@CODPEDIDO INT
AS
BEGIN
	SELECT
	P.CODPEDIDO,
	CL.CODCLIENTE,
	EM.CODEMPLEADO,
	P.FECPED,
	P.PRECIOTOTAL,
	P.ACTPED
	FROM PEDIDO AS P
	INNER JOIN CLIENTE CL ON P.CODCLIENTE = CL.CODCLIENTE
	INNER JOIN EMPLEADO EM ON P.CODEMPLEADO = EM.CODEMPLEADO
	WHERE CODPEDIDO = @CODPEDIDO
END
GO

--EXEC dbo.USP_GET_ID_PEDIDO @CODPEDIDO = 5

--- POST/PUT ---
CREATE OR ALTER PROC USP_MERGE_PEDIDO
	@CODPEDIDO INT,
	@CODCLIENTE INT,
	@CODEMPLEADO INT,
	@FECPED DATE,
	@PRECIOTOTAL DECIMAL,
	@ACTPED VARCHAR(20),
	@ESTPED BIT
AS
BEGIN
	MERGE PEDIDO AS target
	USING(SELECT @CODPEDIDO AS CODPEDIDO) AS source
	ON target.CODPEDIDO = source.CODPEDIDO
	WHEN MATCHED THEN
		UPDATE SET
			CODCLIENTE = @CODCLIENTE,
			CODEMPLEADO = @CODEMPLEADO,
			FECPED = @FECPED,
			PRECIOTOTAL = @PRECIOTOTAL,
			ACTPED = @ACTPED,
			ESTPED = @ESTPED
	WHEN NOT MATCHED THEN
		INSERT(CODPEDIDO, CODCLIENTE, CODEMPLEADO, FECPED,
		PRECIOTOTAL, ACTPED, ESTPED)
		VALUES(@CODPEDIDO, @CODCLIENTE, @CODEMPLEADO, @FECPED, 
		@PRECIOTOTAL, @ACTPED, @ESTPED);
END
GO

--- DELETE ---
CREATE OR ALTER PROC USP_DELETE_PEDIDO
	@CODPEDIDO INT
AS
BEGIN
	UPDATE PEDIDO SET ESTPED = 0 WHERE CODPEDIDO = @CODPEDIDO
END
GO

--- ENABLE ---
CREATE OR ALTER PROC USP_ENABLE_PEDIDO
	@CODPEDIDO INT
AS
BEGIN
	UPDATE PEDIDO SET ESTPED = 1 WHERE CODPEDIDO = @CODPEDIDO
END
GO

------------------------
---- DETALLE PEDIDO ----
------------------------

--- GET ---
CREATE OR ALTER PROC USP_GET_DETALLEPEDIDO
@EST_PP BIT = 1
AS
BEGIN
	IF @EST_PP = 1
		SELECT
		P.ACTPED,
		PR.NOMPRODUCTO,
		DT.PREUNI,
		DT.CANTIDAD
		FROM DETALLEPEDIDO AS DT
		INNER JOIN PEDIDO P ON DT.CODPEDIDO = P.CODPEDIDO
		INNER JOIN PRODUCTO PR ON DT.CODPRODUCTO = PR.CODPRODUCTO
		WHERE DT.EST_PP = 1
	ELSE
		SELECT
		P.ACTPED,
		PR.NOMPRODUCTO,
		DT.PREUNI,
		DT.CANTIDAD
		FROM DETALLEPEDIDO AS DT
		INNER JOIN PEDIDO P ON DT.CODPEDIDO = P.CODPEDIDO
		INNER JOIN PRODUCTO PR ON DT.CODPRODUCTO = PR.CODPRODUCTO
END
GO

--EXEC dbo.USP_GET_DETALLEPEDIDO

--- GET ID ---
CREATE OR ALTER PROC USP_GET_ID_DETALLEPEDIDO
	@CODPEDIDO INT
AS
BEGIN
	SELECT
	DT.CODPEDIDO,
	DT.CODPRODUCTO,
	DT.PREUNI,
	DT.CANTIDAD
	FROM DETALLEPEDIDO AS DT
	INNER JOIN PEDIDO P ON DT.CODPEDIDO = P.CODPEDIDO
	INNER JOIN PRODUCTO PR ON DT.CODPRODUCTO = PR.CODPRODUCTO
	WHERE DT.CODPEDIDO = @CODPEDIDO
END
GO

--EXEC dbo.USP_GET_ID_DETALLEPEDIDO @CODPEDIDO =2, @CODPRODUCTO = 2

--- POST/PUT ---
CREATE OR ALTER PROC USP_MERGE_DETALLEPEDIDO
	@CODPEDIDO INT,
	@CODPRODUCTO INT,
	@PREUNI DECIMAL(10, 2),
	@CANTIDAD INT,
	@EST_PP BIT
AS
BEGIN
	MERGE DETALLEPEDIDO AS target
	USING(SELECT @CODPEDIDO AS CODPEDIDO, @CODPRODUCTO AS CODPRODUCTO) AS source
	ON target.CODPEDIDO = source.CODPEDIDO AND
	target.CODPRODUCTO = source.CODPRODUCTO
	WHEN MATCHED THEN
		UPDATE SET
			PREUNI = @PREUNI,
			CANTIDAD = @CANTIDAD,
			EST_PP = @EST_PP 
	WHEN NOT MATCHED THEN
		INSERT(CODPEDIDO, CODPRODUCTO, PREUNI, CANTIDAD, EST_PP)
		VALUES(@CODPEDIDO, @CODPRODUCTO, @PREUNI, @CANTIDAD, @EST_PP);
END
GO

--- DELETE ---
CREATE OR ALTER PROC USP_DELETE_DETALLEPEDIDO
	 @CODPEDIDO INT,
	 @CODPRODUCTO INT
AS
BEGIN
	UPDATE DETALLEPEDIDO SET EST_PP = 0 WHERE CODPEDIDO = @CODPEDIDO AND CODPRODUCTO = @CODPRODUCTO
END
GO


--- ENABLE ---
CREATE OR ALTER PROC USP_ENABLE_DETALLEPEDIDO
	 @CODPEDIDO INT,
	 @CODPRODUCTO INT
AS
BEGIN
	UPDATE DETALLEPEDIDO SET EST_PP = 1 WHERE CODPEDIDO = @CODPEDIDO AND CODPRODUCTO = @CODPRODUCTO
END
GO
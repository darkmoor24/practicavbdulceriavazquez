


USE practicadulceriavazquez;
GO

CREATE TABLE Usuario (
	IdUsuario		INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	NombreUsuario	NVARCHAR(90) NOT NULL UNIQUE,
	Contrasenia		NVARCHAR(90) NOT NULL
);

CREATE TABLE Categoria (
	IdCategoria		INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Nombre			NVARCHAR(255)
);

CREATE TABLE Direccion (
	IdDireccion		INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    Calle			NVARCHAR(100),
    NumeroInterior  NVARCHAR(10),
    NumeroExterior	NVARCHAR(10),
    Colonia			NVARCHAR(100),
    Localidad		NVARCHAR(100),
    Municipio		NVARCHAR(100),
    Estado			NVARCHAR(100),
    CodigoPostal	NVARCHAR(10),
    Tipo			NVARCHAR(50) -- e.g., Fiscal, Real
);


CREATE TABLE Contacto (
	IdContacto			INT PRIMARY KEY IDENTITY(1, 1),
	NombreCompleto		NVARCHAR(255) NOT NULL,
	Apellidos			NVARCHAR(255) NOT NULL,
	IdDireccion			INT,
	IdCategoria			INT,
	FechaRegistro		DATETIME DEFAULT GETDATE(),
	FechaModificacion	DATETIME DEFAULT GETDATE(),
	IdUsuarioCreador	INT,

	FOREIGN KEY (IdDireccion) REFERENCES Direccion(IdDireccion) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY (IdUsuarioCreador) REFERENCES Usuario(IdUsuario) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE NumeroTelefono (
	IdNumeroTelefono	INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	NumeroTelefono		NVARCHAR(12) NOT NULL UNIQUE,
	Tipo				NVARCHAR(50),
	IdContacto			INT,

	FOREIGN KEY (IdContacto) REFERENCES Contacto(IdContacto) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE Correo (
	IdCorreo		INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Correo			NVARCHAR(90),
	IdContacto		INT,

	FOREIGN KEY (IdContacto) REFERENCES Contacto(IdContacto) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE DatosEmpleado (
	IdDatosEmpleado INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Curp			NVARCHAR(18),
	Puesto			NVARCHAR(90),
	Sueldo			DECIMAL(18,2),
	IdContacto		INT,

	FOREIGN KEY (IdContacto) REFERENCES Contacto(IdContacto) ON UPDATE CASCADE ON DELETE CASCADE
);


CREATE TABLE DatosCliente (
	IdDatosCliente  INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	MontoCredito	DECIMAL(18,2),
	DiasCredito		INT,
	RegimenFiscal	NVARCHAR(90),
	IdContacto		INT,

	FOREIGN KEY (IdContacto) REFERENCES Contacto(IdContacto) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE DatosProveedor (
	IdDatosProveedor		INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	Descripcion				NVARCHAR(255),
	RegimenFiscal			NVARCHAR(90),
	FechaEntregaMercancia	NVARCHAR(90),
	IdContacto			INT,

	FOREIGN KEY (IdContacto) REFERENCES Contacto(IdContacto) ON UPDATE CASCADE ON DELETE CASCADE
);
GO

CREATE VIEW ViewContactos AS
SELECT 
    c.IdContacto, c.NombreCompleto AS NombreCompleto, c.Apellidos AS Apellidos, c.FechaRegistro AS FechaRegistro, c.FechaModificacion AS FechaModificacion,
    cat.IdCategoria, cat.Nombre AS NombreCategoria,
	u.IdUsuario,
	dir.IdDireccion,
	dc.IdDatosCliente, dc.MontoCredito AS MontoCredito, dc.DiasCredito AS DiasCredito, dc.RegimenFiscal AS RegimenFiscalCliente,
	de.IdDatosEmpleado, de.Curp AS Curp, de.Puesto AS Puesto, de.Sueldo AS Sueldo,
	dp.IdDatosProveedor, dp.Descripcion AS Descripcion, dp.FechaEntregaMercancia AS FechaEntregaMercancia, dp.RegimenFiscal AS RegimenFiscalProveedor
FROM 
    Contacto c
	INNER JOIN Categoria cat ON c.IdCategoria = cat.IdCategoria
	INNER JOIN Usuario u ON c.IdUsuarioCreador = u.IdUsuario
	INNER JOIN Direccion dir ON c.IdDireccion = dir.IdDireccion
	LEFT JOIN DatosCliente dc ON c.IdContacto = dc.IdContacto
	LEFT JOIN DatosEmpleado de ON c.IdContacto = de.IdContacto
	LEFT JOIN DatosProveedor dp ON c.IdContacto = dp.IdContacto;
GO

CREATE PROCEDURE SpInsertarContacto
	@Calle NVARCHAR(100),
	@NumeroExterior	NVARCHAR(10),
	@NumeroInterior	NVARCHAR(10),
	@Colonia	NVARCHAR(100),
	@Localidad	NVARCHAR(100),
	@Municipio	NVARCHAR(100),
	@Estado	NVARCHAR(100),
	@CodigoPostal	NVARCHAR(10),
	@TipoDireccion	NVARCHAR(50),
	@NombreCompleto	NVARCHAR(255),
	@Apellidos	NVARCHAR(255),
	@IdCategoria	INT,
	@IdUsuarioCreador	INT,
	-- Empleado
	@IdDatosEmpleado INT = 0,
	@Curp NVARCHAR(18) = NULL,
	@Puesto NVARCHAR(90) = NULL,
	@Sueldo DECIMAL(18, 2) = 0,
	-- Cliente
	@IdDatosCliente INT = 0,
	@MontoCredito DECIMAL(18, 0) = 0,
	@DiasCredito INT = 0,
	@RegimenFiscalCliente NVARCHAR(90) = NULL,
	-- Proveedor
	@IdDatosProveedor INT = 0,
	@Descripcion NVARCHAR(255) = NULL,
	@RegimenFiscalProveedor NVARCHAR(90) = NULL,
	@FechaEntregaMercancia NVARCHAR(90) = NULL,
	@IdContacto INT OUTPUT
AS
BEGIN
	DECLARE @IdDireccion INT;

	BEGIN TRANSACTION;

	BEGIN TRY
		INSERT INTO Direccion (Calle, NumeroExterior, NumeroInterior, Colonia, Localidad, Municipio, Estado, CodigoPostal, Tipo) VALUES 
							  (@Calle, @NumeroExterior, @NumeroInterior, @Colonia, @Localidad, @Municipio, @Estado, @CodigoPostal, @TipoDireccion);

		SET @IdDireccion = SCOPE_IDENTITY();

		INSERT INTO Contacto (NombreCompleto, Apellidos, IdDireccion, IdCategoria, IdUsuarioCreador) VALUES 
							 (@NombreCompleto, @Apellidos, @IdDireccion, @IdCategoria, @IdUsuarioCreador);

		-- Obtener el ID del nuevo contacto
        SET @IdContacto = SCOPE_IDENTITY();

		-- Empleado
		IF @IdCategoria = 1
			INSERT INTO DatosEmpleado (Curp, Puesto, Sueldo, IdContacto) VALUES 
									  (@Curp, @Puesto, @Sueldo, @IdContacto);

		-- Cliente
		ELSE IF @IdCategoria = 2
			INSERT INTO DatosCliente (MontoCredito, DiasCredito, RegimenFiscal, IdContacto) VALUES 
									 (@MontoCredito, @DiasCredito, @RegimenFiscalCliente, @IdContacto);

		--Proveedor
		ELSE IF @IdCategoria = 3
			INSERT INTO DatosProveedor (Descripcion, RegimenFiscal, FechaEntregaMercancia, IdContacto) VALUES 
									   (@Descripcion, @RegimenFiscalProveedor, @FechaEntregaMercancia, @IdContacto);		

        -- Confirmar la transacción
		SELECT * FROM ViewContactos WHERE IdContacto = @IdContacto;

        COMMIT TRANSACTION;
	END TRY

	BEGIN CATCH
        ROLLBACK TRANSACTION;

        THROW;
	END CATCH
END
GO

CREATE PROCEDURE SpInsertarNumeroTelefono
    @IdContacto INT,
    @NumeroTelefono NVARCHAR(12),
    @Tipo NVARCHAR(50)
AS
BEGIN
    -- Iniciar la transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insertar en la tabla NumeroTelefono
        INSERT INTO NumeroTelefono (NumeroTelefono, Tipo, IdContacto)
        VALUES (@NumeroTelefono, @Tipo, @IdContacto);

        -- Confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Deshacer la transacción en caso de error
        ROLLBACK TRANSACTION;

        -- Lanzar el error para que pueda ser manejado por el llamado
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE SpInsertarCorreo
    @IdContacto INT,
    @Correo NVARCHAR(90)
AS
BEGIN
    -- Iniciar la transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insertar en la tabla Correo
        INSERT INTO Correo (Correo, IdContacto)
        VALUES (@Correo, @IdContacto);

        -- Confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Deshacer la transacción en caso de error
        ROLLBACK TRANSACTION;

        -- Lanzar el error para que pueda ser manejado por el llamado
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE SpActualizarContacto
    @NombreCompleto NVARCHAR(255),
    @Apellidos NVARCHAR(255),
    @IdDireccion INT,
    @IdCategoria INT,
    @IdUsuarioCreador INT,
    @FechaRegistro DATETIME = NULL,
    @IdContacto INT OUTPUT
AS
BEGIN
    -- Iniciar la transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insertar en la tabla Contacto
        INSERT INTO Contacto (NombreCompleto, Apellidos, IdDireccion, IdCategoria, FechaRegistro, FechaModificacion, IdUsuarioCreador)
        VALUES (@NombreCompleto, @Apellidos, @IdDireccion, @IdCategoria, ISNULL(@FechaRegistro, GETDATE()), NULL, @IdUsuarioCreador);

        -- Obtener el ID del nuevo contacto
        SET @IdContacto = SCOPE_IDENTITY();

        -- Confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Deshacer la transacción en caso de error
        ROLLBACK TRANSACTION;

        -- Lanzar el error para que pueda ser manejado por el llamado
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE SpActualizarNumeroTelefono
    @IdContacto INT,
    @NumeroTelefono NVARCHAR(12),
    @Tipo NVARCHAR(50)
AS
BEGIN
    -- Iniciar la transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insertar en la tabla NumeroTelefono
        INSERT INTO NumeroTelefono (NumeroTelefono, Tipo, IdContacto)
        VALUES (@NumeroTelefono, @Tipo, @IdContacto);

        -- Confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Deshacer la transacción en caso de error
        ROLLBACK TRANSACTION;

        -- Lanzar el error para que pueda ser manejado por el llamado
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE SpActualizarCorreo
    @IdContacto INT,
    @Correo NVARCHAR(90)
AS
BEGIN
    -- Iniciar la transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insertar en la tabla Correo
        INSERT INTO Correo (Correo, IdContacto)
        VALUES (@Correo, @IdContacto);

        -- Confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Deshacer la transacción en caso de error
        ROLLBACK TRANSACTION;

        -- Lanzar el error para que pueda ser manejado por el llamado
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE SpEliminarContacto
    @IdContacto INT
AS
BEGIN

    BEGIN TRANSACTION;

    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Contacto WHERE IdContacto = @IdContacto)
			BEGIN
				DELETE FROM Contacto WHERE IdContacto = @IdContacto;

				COMMIT TRANSACTION;

				RETURN 1
        END
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        THROW;
    END CATCH
END
GO



INSERT INTO Usuario (NombreUsuario, Contrasenia) VALUES 
('serchrmz', 'skyper123'), /* ID 1 */
('jonathan_hernandez', 'jonathanhernandez123'), /* ID 2 */
('rafa', 'rafadev'); /* ID 3 - Sin registros previos */ 

INSERT INTO Categoria (Nombre) VALUES 
('Empleado'), /* ID 1 */
('Cliente'), /* ID 2 */
('Proveedor'); /* ID 3 */

INSERT INTO Direccion (Calle, NumeroExterior, NumeroInterior, Colonia, Localidad, Municipio, Estado, CodigoPostal, Tipo) VALUES 
('Patras', '223', '', 'Valle Delta', 'León de los Aldama', 'León', 'Guanajuato', '37538', 'Real'), /* ID 1 */
('Álvaro Obregon', '1205', '', 'Centro', 'León de los Aldama', 'León', 'Guanajuato', '37233', 'Fiscal'), /* ID 2 */
('Blvd. Lópéz Mateos', '14052', '', 'Centro', 'León de los Aldama', 'León', 'Guanajuato', '37123', 'Real');   /* ID 3 */

INSERT INTO Contacto (NombreCompleto, Apellidos, IdDireccion, IdCategoria, IdUsuarioCreador) VALUES 
('Sergio Antonio', 'Hernández Ramírez', 1, 2, 1), /* Cliente - ID 1*/ 
('Oswaldo', 'Jiménez', 2, 1, 2), /* Empleado - ID 2*/ 
('Luis', 'Muciño', 3, 3, 2); /* Proveedor - ID 3*/ 

INSERT INTO DatosCliente (MontoCredito, DiasCredito, RegimenFiscal, IdContacto) VALUES 
(25250.50, 90, 'Actividad Empresarial', 1);

INSERT INTO DatosEmpleado (Curp, Puesto, Sueldo, IdContacto) VALUES 
('JIVO160988HDFRMR00', 'Auxiliar TICs', 12000, 2);

INSERT INTO DatosProveedor (Descripcion, RegimenFiscal, FechaEntregaMercancia, IdContacto) VALUES 
('Proveedor La Rosa', 'Actividad Empresarial', 'Días 15 de cada mes', 3);

INSERT INTO NumeroTelefono (NumeroTelefono, Tipo, IdContacto) VALUES 
('4771234567', 'Celular', 1), /* Cliente ID Contacto 1 - ID 1 */
('4771636778', 'WhatsApp', 1), /* Cliente ID Contacto 1 - ID 2 */
('4770000000', 'Celular', 2), /* Empleado ID Contacto 2 - ID 3 */
('4770001233', 'Emergencia', 2), /* Empleado ID Contacto 2 - ID 4 */
('4791234567', 'Celular', 3), /* Proveedor ID Contacto 3 - ID 5 */
('4799876543', 'WhatsApp', 3); /* Proveedor ID Contacto 3 - ID 6 */ 

INSERT INTO Correo (Correo, IdContacto) VALUES 
('correo1@correo.com', 1), /* Cliente ID Contacto 1 - ID 1 */
('correo2@correo.com', 1), /* Cliente ID Contacto 1 - ID 2 */
('correo3@correo.com', 2), /* Empleado ID Contacto 2 - ID 3 */
('correo4@correo.com', 2), /* Empleado ID Contacto 2 - ID 4 */
('correo5@correo.com', 3); /* Proveedor ID Contacto 3 - ID 5 */


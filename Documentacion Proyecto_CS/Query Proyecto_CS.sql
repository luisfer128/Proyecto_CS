CREATE TABLE [Usuario] (
  [Id_Usuario] VARCHAR(10),
  [Nombre] VARCHAR(20),
  [Apellido] VARCHAR(20),
  [User] VARCHAR(20),
  [Contraseña] VARCHAR(100),
  [Rol] VARCHAR(50),
  [Direccion] TEXT,
  [Telefono] VARCHAR(10),
  [Estado] CHAR DEFAULT 'A',
  PRIMARY KEY ([Id_Usuario])
);

CREATE TABLE [Log] (
  [Id_Log] INT IDENTITY(1,1),
  [Id_Usuario] VARCHAR(10),
  [Accion] TEXT,
  [Fecha_modificacion] DATE,
  PRIMARY KEY ([Id_Log]),
  FOREIGN KEY ([Id_Usuario]) REFERENCES [Usuario]([Id_Usuario])
);

CREATE TABLE Productos (
    Id_Producto INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(255),
    Valor DECIMAL(10, 2),
    Descripcion NVARCHAR(MAX)
);

CREATE TABLE Carrito (
    Id_Carrito INT PRIMARY KEY IDENTITY(1,1),
    Id_Usuario varchar(10),
	Id_Producto INT,
    Cantidad INT,
	FOREIGN KEY (Id_Producto) REFERENCES Productos(Id_Producto),
    FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id_Usuario)
);

CREATE TABLE Domicilio(
    Id_Domicilio INT PRIMARY KEY IDENTITY(1,1),
    Id_Usuario varchar(10),
    Calle varchar(50),
    Estado varchar(50),
    Ciudad varchar(50),
    Pais varchar(50),
    CodigoPostal varchar(50),
    FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id_Usuario)
);

CREATE TABLE MetodoPago (
    Id_Pago INT PRIMARY KEY IDENTITY(1,1),
    Nombre varchar(50)
);

CREATE TABLE OrdenPago (
    Id_OrdenPago INT PRIMARY KEY IDENTITY(1,1),
    Id_Usuario varchar(10),
    Id_Domicilio INT,
    Id_Pago INT,
    Total DECIMAL(10, 2),
    FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id_Usuario),
    FOREIGN KEY (Id_Domicilio) REFERENCES Domicilio(Id_Domicilio),
    FOREIGN KEY (Id_Pago) REFERENCES MetodoPago(Id_Pago),
);


CREATE TABLE DetalleOrdenPago (
    Id_DetalleOrdenPago INT PRIMARY KEY IDENTITY(1,1),
    Id_OrdenPago INT,
    Id_Producto INT,
    Cantidad INT,
    FOREIGN KEY (Id_OrdenPago) REFERENCES OrdenPago(Id_OrdenPago),
    FOREIGN KEY (Id_Producto) REFERENCES Productos(Id_Producto)
);

CREATE TABLE Factura (
    Id_Factura INT PRIMARY KEY IDENTITY(1,1),
    Id_DetalleOrdenPago INT,
    FechaEmision DATE,
    EstadoPago VARCHAR(50),
    FOREIGN KEY (Id_DetalleOrdenPago) REFERENCES DetalleOrdenPago(Id_DetalleOrdenPago)
);

---------StoreProcedures------------

CREATE PROCEDURE InsertarUsuario
    @Id_Usuario VARCHAR(10),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @User VARCHAR(50),
    @Contraseña VARCHAR(50),
    @Rol VARCHAR(50),
    @Direccion VARCHAR(50),
    @Telefono VARCHAR(50),
    @Estado CHAR = 'A'
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [Usuario] (
        [Id_Usuario], 
        [Nombre], 
        [Apellido], 
        [User], 
        [Contraseña], 
        [Rol], 
        [Direccion], 
        [Telefono], 
        [Estado]
    )
    VALUES (
        @Id_Usuario, 
        @Nombre, 
        @Apellido, 
        @User, 
        @Contraseña, 
        @Rol, 
        @Direccion, 
        @Telefono, 
        @Estado
    );
END;



CREATE PROCEDURE ObtenerUsuario
    @UsuarioIngresado VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        [Id_Usuario],  
        [Contraseña], 
        [Rol]
    FROM 
        [Usuario]
    WHERE 
        [User] = @UsuarioIngresado;
END;



CREATE PROCEDURE EliminarUsuario
  @IdUsuario VARCHAR(10)
AS
BEGIN
  DELETE FROM Usuario
  WHERE Id_Usuario = @IdUsuario;
END;


CREATE PROCEDURE ActualizarUsuario
  @IdUsuario VARCHAR(10),
  @Nombre VARCHAR(20),
  @Apellido VARCHAR(20),
  @Rol VARCHAR(50),
  @Direccion TEXT,
  @Telefono VARCHAR(10),
  @Estado CHAR
AS
BEGIN
  UPDATE Usuario
  SET Nombre = @Nombre,
      Apellido = @Apellido,
      Rol = @Rol,
      Direccion = @Direccion,
      Telefono = @Telefono,
	  Estado = @Estado
  WHERE Id_Usuario = @IdUsuario;
END;

CREATE PROCEDURE SelectUsuarios
AS
BEGIN
  SELECT
    [Id_Usuario],
    [Nombre],
    [Apellido],
    [User],
    [Contraseña],
    [Rol],
    [Direccion],
    [Telefono],
    [Estado]
  FROM
    [Usuario];
END;


CREATE PROCEDURE sp_AgregarProductoAlCarrito
    @Id_Usuario varchar(10),
    @Id_Producto INT,
    @Cantidad INT
AS
BEGIN
    BEGIN TRANSACTION;
    
    DECLARE @Id_Carrito INT;

    -- Verificar si el producto ya existe en el carrito del usuario
    IF EXISTS (SELECT 1 FROM Carrito WHERE Id_Usuario = @Id_Usuario AND Id_Producto = @Id_Producto)
    BEGIN
        UPDATE Carrito
        SET Cantidad = Cantidad + @Cantidad
        WHERE Id_Usuario = @Id_Usuario AND Id_Producto = @Id_Producto;
    END
    ELSE
    BEGIN
        INSERT INTO Carrito (Id_Usuario, Id_Producto, Cantidad)
        VALUES (@Id_Usuario, @Id_Producto, @Cantidad);
    END

    COMMIT;
END;


CREATE PROCEDURE sp_EliminarProductoDelCarrito
    @Id_Usuario varchar(50),
    @Id_Producto INT
AS
BEGIN
    BEGIN TRANSACTION;

    DELETE FROM Carrito
    WHERE Id_Usuario = @Id_Usuario AND Id_Producto = @Id_Producto;

    COMMIT;
END;

CREATE PROCEDURE sp_EliminarTodoDelCarrito
    @Id_Usuario varchar(50)
AS
BEGIN
    BEGIN TRANSACTION;

    DELETE FROM Carrito
    WHERE Id_Usuario = @Id_Usuario;

    COMMIT;
END;



CREATE PROCEDURE sp_ObtenerProductosDelCarrito
    @Id_Usuario varchar(10)
AS
BEGIN
    SELECT p.Id_Producto ,p.Nombre, p.Valor, c.Cantidad
    FROM Carrito c
    JOIN Productos p ON c.Id_Producto = p.Id_Producto
    WHERE c.Id_Usuario = @Id_Usuario;
END;

CREATE PROCEDURE sp_CantidadProductoEnCarrito
    @Id_Producto INT,
	@Id_Usuario varchar(50)
AS
BEGIN
	DECLARE @CantidadEnCarrito INT;
    SELECT @CantidadEnCarrito = SUM(Cantidad)
    FROM Carrito
    WHERE Id_Usuario = @Id_Usuario AND Id_Producto = @Id_Producto;

	IF @CantidadEnCarrito IS NULL
        SET @CantidadEnCarrito = 0;

	SELECT @CantidadEnCarrito AS CantidadEnCarrito;
END;

CREATE PROCEDURE sp_SumarValorTotalCarrito
    @Id_Usuario varchar(10)
AS
BEGIN
    DECLARE @Total DECIMAL(10, 2);

    SELECT @Total = SUM(p.Valor * c.Cantidad)
    FROM Carrito c
    INNER JOIN Productos p ON c.Id_Producto = p.Id_Producto
    WHERE c.Id_Usuario = @Id_Usuario;

    -- Si no hay resultados, establecer el total en 0
    IF @Total IS NULL
        SET @Total = 0;

    SELECT @Total AS ValorTotalCarrito;
END;

CREATE PROCEDURE sp_InsertarDireccion
    @Id_Usuario varchar(10),
    @Calle varchar(50),
    @Estado varchar(50),
    @Ciudad varchar(50),
    @Pais varchar(50),
    @CodigoPostal varchar(50)
AS
BEGIN
    INSERT INTO Domicilio (Id_Usuario, Calle, Estado, Ciudad, Pais, CodigoPostal)
    VALUES (@Id_Usuario, @Calle, @Estado, @Ciudad, @Pais, @CodigoPostal);
END;

CREATE PROCEDURE sp_InsertarDomicilio
    @Id_Usuario varchar(10),
    @Calle varchar(50),
    @Estado varchar(50),
    @Ciudad varchar(50),
    @Pais varchar(50),
    @CodigoPostal varchar(50),
    @Id_Domicilio INT OUTPUT
AS
BEGIN
    INSERT INTO Domicilio (Id_Usuario, Calle, Estado, Ciudad, Pais, CodigoPostal)
    VALUES (@Id_Usuario, @Calle, @Estado, @Ciudad, @Pais, @CodigoPostal);

    -- Obtener el Id_Domicilio recién insertado
    SET @Id_Domicilio = SCOPE_IDENTITY();
END;



CREATE PROCEDURE sp_InsertarOrdenPago
    @Id_Usuario varchar(10),
    @Id_Domicilio INT,
    @Total DECIMAL(10, 2),
    @Id_Pago INT,
    @Id_OrdenPago INT OUTPUT
AS
BEGIN
    INSERT INTO OrdenPago (Id_Usuario, Id_Domicilio, Id_Pago ,Total)
    VALUES (@Id_Usuario, @Id_Domicilio, @Id_Pago, @Total);

    -- Obtener el Id_OrdenPago recién insertado
    SET @Id_OrdenPago = SCOPE_IDENTITY();
END;


CREATE PROCEDURE sp_InsertarDetalleOrdenPago
    @Id_OrdenPago INT,
    @Id_Producto INT,
    @Cantidad INT,
    @Id_DetalleOrdenPago INT OUTPUT
AS
BEGIN
    INSERT INTO DetalleOrdenPago (Id_OrdenPago, Id_Producto, Cantidad)
    VALUES (@Id_OrdenPago, @Id_Producto, @Cantidad);

    -- Obtener el Id_DetalleOrdenPago recién insertado
    SET @Id_DetalleOrdenPago = SCOPE_IDENTITY();
END;


CREATE PROCEDURE sp_InsertarFactura
    @Id_DetalleOrdenPago INT,
    @FechaEmision DATE,
    @EstadoPago VARCHAR(50)
AS
BEGIN
    INSERT INTO Factura (Id_DetalleOrdenPago, FechaEmision, EstadoPago)
    VALUES (@Id_DetalleOrdenPago, @FechaEmision, @EstadoPago);
END;


CREATE PROCEDURE sp_ObtenerDetallesFacturaPorUsuario
    @Id_Usuario VARCHAR(10)
AS
BEGIN
    SELECT 
        F.Id_Factura,
        F.FechaEmision,
        F.EstadoPago,
        O.Id_OrdenPago,
        O.Total,
        D.Calle AS DireccionCalle,
        D.Estado AS DireccionEstado,
        D.Ciudad AS DireccionCiudad,
        D.Pais AS DireccionPais,
        D.CodigoPostal AS DireccionCodigoPostal,
        M.Nombre AS MetodoPago,
        P.Nombre AS ProductoNombre,
        DOP.Cantidad,
        P.Valor AS PrecioUnitario,
        DOP.Cantidad * P.Valor AS Subtotal
    FROM 
        Factura F
    JOIN 
        DetalleOrdenPago DOP ON F.Id_DetalleOrdenPago = DOP.Id_DetalleOrdenPago
    JOIN 
        OrdenPago O ON F.Id_DetalleOrdenPago = O.Id_OrdenPago
    JOIN 
        Domicilio D ON O.Id_Domicilio = D.Id_Domicilio
    JOIN 
        MetodoPago M ON O.Id_Pago = M.Id_Pago
    JOIN 
        Productos P ON DOP.Id_Producto = P.Id_Producto
    WHERE 
        O.Id_Usuario = @Id_Usuario;
END;



----------pruebas---------------
INSERT INTO [Usuario] ([Id_Usuario], [Nombre], [Apellido], [User], [Contraseña], [Rol], [Direccion], [Telefono], [Estado])
VALUES ('1', 'Administrador', 'AdminApellido', 'admin', 'zt+OGWw7Yslmj0MOv0DO6Q==', 'Admin', 'DirecciónAdmin', '123456789', 'A');

EXEC InsertarUsuario
    @Id_Usuario = '3',
    @Nombre = 'John',
    @Apellido = 'Doe',
    @User = 'john.doe',
    @Contraseña = 'contraseña_segura',
    @Rol = 'Usuario',
    @Direccion = '123 Main St',
    @Telefono = '123456789';


-- Insertar curso de ensamblaje de PC
INSERT INTO Productos (Nombre, Valor, Descripcion)
VALUES ('Curso de Ensamblaje de PC', 199.99, 'Aprende a ensamblar y configurar computadoras desde cero.');

-- Insertar curso de programación
INSERT INTO Productos (Nombre, Valor, Descripcion)
VALUES ('Curso de Programación', 249.99, 'Domina un lenguaje de programación y desarrolla habilidades de codificación.');

-- Insertar curso de base de datos
INSERT INTO Productos (Nombre, Valor, Descripcion)
VALUES ('Curso de Base de Datos', 149.99, 'Aprende a diseñar y administrar bases de datos eficientes.');

INSERT INTO MetodoPago (Nombre) VALUES ('Tarjeta de debito')
INSERT INTO MetodoPago (Nombre) VALUES ('Tarjeta de credito')


SELECT * from Usuario

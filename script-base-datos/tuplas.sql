/****** Data Script for BDTarjetas   Script Date: 27/02/2020 10:58:22 p. m. ******/

SET XACT_ABORT ON

USE [BDTarjetas]

SET IDENTITY_INSERT [dbo].[Cliente] ON

BEGIN TRANSACTION
INSERT INTO [dbo].[Cliente] ([Id], [Nombre], [Telefono], [Carnet])
VALUES (1, 'Juan Pablo', '456822', '123456')
INSERT INTO [dbo].[Cliente] ([Id], [Nombre], [Telefono], [Carnet])
VALUES (2, 'Pedro Juan', '789553', '654123')
SET IDENTITY_INSERT [dbo].[Cliente] OFF

SET IDENTITY_INSERT [dbo].[Recarga] ON
INSERT INTO [dbo].[Recarga] ([Id], [fecha], [monto], [Id_Tarjeta], [Id_Cliente], [Id_Usuario])
VALUES (1, '2020-02-27T22:47:50.35', 30.00, 1, 1, 1)
INSERT INTO [dbo].[Recarga] ([Id], [fecha], [monto], [Id_Tarjeta], [Id_Cliente], [Id_Usuario])
VALUES (2, '2020-02-27T22:47:50.35', 50.00, 2, 1, 1)
INSERT INTO [dbo].[Recarga] ([Id], [fecha], [monto], [Id_Tarjeta], [Id_Cliente], [Id_Usuario])
VALUES (3, '2020-02-27T22:47:50.35', 40.00, 3, 2, 2)
SET IDENTITY_INSERT [dbo].[Recarga] OFF

SET IDENTITY_INSERT [dbo].[Tarjeta] ON
INSERT INTO [dbo].[Tarjeta] ([Id], [Codigo])
VALUES (1, 'xxx123')
INSERT INTO [dbo].[Tarjeta] ([Id], [Codigo])
VALUES (2, 'xxx456')
INSERT INTO [dbo].[Tarjeta] ([Id], [Codigo])
VALUES (3, 'yyy123')
SET IDENTITY_INSERT [dbo].[Tarjeta] OFF

SET IDENTITY_INSERT [dbo].[Tarjeta_Cliente] ON
INSERT INTO [dbo].[Tarjeta_Cliente] ([Id], [Fecha], [Saldo], [Id_Tarjeta], [Id_Cliente])
VALUES (1, '2020-02-27T22:55:50.177', 30.00, 1, 1)
INSERT INTO [dbo].[Tarjeta_Cliente] ([Id], [Fecha], [Saldo], [Id_Tarjeta], [Id_Cliente])
VALUES (2, '2020-02-27T22:55:50.177', 50.00, 2, 1)
INSERT INTO [dbo].[Tarjeta_Cliente] ([Id], [Fecha], [Saldo], [Id_Tarjeta], [Id_Cliente])
VALUES (3, '2020-02-27T22:55:50.177', 40.00, 3, 2)
SET IDENTITY_INSERT [dbo].[Tarjeta_Cliente] OFF

SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT INTO [dbo].[Usuario] ([Id], [Nombre], [Codigo], [Password])
VALUES (1, 'Rosember', '123456', '123456')
INSERT INTO [dbo].[Usuario] ([Id], [Nombre], [Codigo], [Password])
VALUES (2, 'Carlos', '654321', '65432')
SET IDENTITY_INSERT [dbo].[Usuario] OFF

COMMIT TRANSACTION
GO

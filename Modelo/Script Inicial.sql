USE [HOUSE_FOOD]
GO
--crea accesos del menu
INSERT INTO [dbo].[Menus] VALUES  ('Mantenimiento' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Seguridad' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Usuarios' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Categorias' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Productos' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Ordenes' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Ordenar' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Cobrar' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Cierres' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Gastos' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Reportes' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('AcercaDe' ,1)
INSERT INTO [dbo].[Menus] VALUES  ('Ayuda?' ,1)       
GO
INSERT INTO [dbo].[Roles] VALUES  ('Administrador' ,1)
--ingresar datos
INSERT INTO [dbo].[Usuarios] VALUES  ('usuario','Nombre', 1, 'contraseña' ,1)
INSERT INTO [dbo].[Permisos] VALUES  (1,1,'Mantenimiento', 1)
INSERT INTO [dbo].[Permisos] VALUES  (2,1,'Seguridad', 1)
go
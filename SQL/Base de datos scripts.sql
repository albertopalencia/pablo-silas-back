USE [ArandaSoft]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28/04/2022 2:50:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 28/04/2022 2:50:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 28/04/2022 2:50:21 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Descripcion] [varchar](1500) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220428060005_CreateSchoolDB', N'5.0.13')
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (1, N'Bebidas', 1)
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (2, N'Comestibles', 1)
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (3, N'Chocolates', 1)
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (4, N'Empaquetados', 1)
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (5, N'Galletas', 1)
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (6, N'Gaseosas', 1)
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (7, N'Jugos', 1)
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (8, N'Panes', 1)
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (9, N'Comestibles', 1)
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (10, N'Variados', 1)
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (11, N'Verduras', 1)
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id], [IdCategoria], [Nombre], [Descripcion], [Estado]) VALUES (2, 7, N'Uva Postobon ', N'Actualizado', 1)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF_Productos_Estado]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categorias] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categorias]
GO

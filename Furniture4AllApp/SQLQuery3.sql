/****** Object:  Table [dbo].[Category]    Script Date: 3/29/2026 11:55:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/29/2026 11:55:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](50) NULL,
	[lname] [varchar](50) NULL,
	[sex] [varchar](10) NULL,
	[date_of_birth] [date] NULL,
	[address] [varchar](100) NULL,
	[city] [varchar](50) NULL,
	[state] [varchar](2) NULL,
	[zip] [varchar](10) NULL,
	[phone] [varchar](10) NULL,
	[username] [varchar](50) NULL,
	[password_hash] [varchar](100) NULL,
	[is_admin] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furniture]    Script Date: 3/29/2026 11:55:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furniture](
	[furniture_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[description] [varchar](255) NULL,
	[category_id] [int] NULL,
	[style_id] [int] NULL,
	[daily_rental_rate] [decimal](10, 2) NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[furniture_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 3/29/2026 11:55:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[member_id] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](50) NULL,
	[lname] [varchar](50) NULL,
	[sex] [varchar](10) NULL,
	[date_of_birth] [date] NULL,
	[address] [varchar](100) NULL,
	[city] [varchar](50) NULL,
	[state] [varchar](2) NULL,
	[zip] [varchar](10) NULL,
	[phone] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[member_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalLineItem]    Script Date: 3/29/2026 11:55:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalLineItem](
	[rental_transaction_id] [int] NOT NULL,
	[furniture_id] [int] NOT NULL,
	[quantity] [int] NULL,
	[quantity_returned] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[rental_transaction_id] ASC,
	[furniture_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalTransaction]    Script Date: 3/29/2026 11:55:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalTransaction](
	[rental_transaction_id] [int] IDENTITY(1,1) NOT NULL,
	[member_id] [int] NULL,
	[employee_id] [int] NULL,
	[rental_date] [date] NULL,
	[due_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[rental_transaction_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnLineItem]    Script Date: 3/29/2026 11:55:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnLineItem](
	[return_transaction_id] [int] NOT NULL,
	[rental_transaction_id] [int] NOT NULL,
	[furniture_id] [int] NOT NULL,
	[quantity] [int] NULL,
	[fine] [decimal](10, 2) NULL,
	[refund] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[return_transaction_id] ASC,
	[rental_transaction_id] ASC,
	[furniture_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 3/29/2026 11:55:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnTransaction](
	[return_transaction_id] [int] IDENTITY(1,1) NOT NULL,
	[member_id] [int] NULL,
	[employee_id] [int] NULL,
	[return_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[return_transaction_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Style]    Script Date: 3/29/2026 11:55:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Style](
	[style_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[style_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([category_id], [name]) VALUES (1, N'Chair')
INSERT [dbo].[Category] ([category_id], [name]) VALUES (2, N'Table')
INSERT [dbo].[Category] ([category_id], [name]) VALUES (3, N'Sofa')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Furniture] ON 

INSERT [dbo].[Furniture] ([furniture_id], [name], [description], [category_id], [style_id], [daily_rental_rate], [quantity]) VALUES (1, N'Office Chair', N'A basic office chair', 1, 1, CAST(15.00 AS Decimal(10, 2)), 10)
INSERT [dbo].[Furniture] ([furniture_id], [name], [description], [category_id], [style_id], [daily_rental_rate], [quantity]) VALUES (2, N'Dining Table', N'Polished oak dining table', 2, 2, CAST(45.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Furniture] ([furniture_id], [name], [description], [category_id], [style_id], [daily_rental_rate], [quantity]) VALUES (3, N'Modern Sofa', N'Grey sofa, sits three', 3, 1, CAST(60.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Furniture] ([furniture_id], [name], [description], [category_id], [style_id], [daily_rental_rate], [quantity]) VALUES (4, N'Rustic Coffee Table', N'Wooden small table', 2, 3, CAST(25.00 AS Decimal(10, 2)), 8)
INSERT [dbo].[Furniture] ([furniture_id], [name], [description], [category_id], [style_id], [daily_rental_rate], [quantity]) VALUES (5, N'Classic Armchair', N'Velvet printed armchair', 1, 2, CAST(30.00 AS Decimal(10, 2)), 4)
SET IDENTITY_INSERT [dbo].[Furniture] OFF
GO
SET IDENTITY_INSERT [dbo].[Style] ON 

INSERT [dbo].[Style] ([style_id], [name]) VALUES (1, N'Modern')
INSERT [dbo].[Style] ([style_id], [name]) VALUES (2, N'Classic')
INSERT [dbo].[Style] ([style_id], [name]) VALUES (3, N'Rustic')
SET IDENTITY_INSERT [dbo].[Style] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Employee__F3DBC572F7464E94]    Script Date: 3/29/2026 11:55:34 AM ******/
ALTER TABLE [dbo].[Employee] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RentalLineItem] ADD  DEFAULT ((0)) FOR [quantity_returned]
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD FOREIGN KEY([category_id])
REFERENCES [dbo].[Category] ([category_id])
GO
ALTER TABLE [dbo].[Furniture]  WITH CHECK ADD FOREIGN KEY([style_id])
REFERENCES [dbo].[Style] ([style_id])
GO
ALTER TABLE [dbo].[RentalLineItem]  WITH CHECK ADD FOREIGN KEY([furniture_id])
REFERENCES [dbo].[Furniture] ([furniture_id])
GO
ALTER TABLE [dbo].[RentalLineItem]  WITH CHECK ADD FOREIGN KEY([rental_transaction_id])
REFERENCES [dbo].[RentalTransaction] ([rental_transaction_id])
GO
ALTER TABLE [dbo].[RentalTransaction]  WITH CHECK ADD FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
ALTER TABLE [dbo].[RentalTransaction]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[Member] ([member_id])
GO
ALTER TABLE [dbo].[ReturnLineItem]  WITH CHECK ADD FOREIGN KEY([return_transaction_id])
REFERENCES [dbo].[ReturnTransaction] ([return_transaction_id])
GO
ALTER TABLE [dbo].[ReturnLineItem]  WITH CHECK ADD FOREIGN KEY([rental_transaction_id], [furniture_id])
REFERENCES [dbo].[RentalLineItem] ([rental_transaction_id], [furniture_id])
GO
ALTER TABLE [dbo].[ReturnTransaction]  WITH CHECK ADD FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
ALTER TABLE [dbo].[ReturnTransaction]  WITH CHECK ADD FOREIGN KEY([member_id])
REFERENCES [dbo].[Member] ([member_id])
GO

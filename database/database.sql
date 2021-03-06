USE [TmTech]
GO
/****** Object:  Table [dbo].[AppAccount]    Script Date: 2017-02-11 2:28:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AppAccount](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](200) NOT NULL,
	[Password] [varchar](200) NULL,
	[RecoverEmail] [varchar](100) NULL,
	[UserId] [int] NULL,
	[UserTypeId] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
 CONSTRAINT [PK_AppUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bank]    Script Date: 2017-02-11 2:28:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bank](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Address] [nvarchar](200) NULL,
	[Phone] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[CompanyId] [int] NULL,
	[AccountBankNo] [varchar](100) NULL,
	[AccountName] [nvarchar](500) NULL,
	[Type] [int] NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Bank] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2017-02-11 2:28:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[ParentId] [int] NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Company]    Script Date: 2017-02-11 2:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Address] [nvarchar](500) NULL,
	[Phone1] [varchar](20) NULL,
	[Phone2] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[Taxcode] [varchar](50) NULL,
	[SwiftCode] [varchar](50) NULL,
	[Employee] [int] NULL,
	[DebitValue] [float] NULL,
	[ParentCompanyId] [int] NULL,
	[Branch] [int] NULL,
	[TagetValue] [int] NULL,
	[Website] [varchar](100) NULL,
	[Email] [varchar](200) NULL,
	[StaffId] [int] NULL,
	[Note] [varchar](200) NULL,
	[TypeId] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CurrencyUnit]    Script Date: 2017-02-11 2:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CurrencyUnit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Code] [varchar](10) NULL,
	[Note] [nvarchar](200) NULL,
 CONSTRAINT [PK_CurrencyUnit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CurrentInventory]    Script Date: 2017-02-11 2:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrentInventory](
	[Id] [uniqueidentifier] NOT NULL,
	[InventoryId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
 CONSTRAINT [PK_CurrentInventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CustomerType]    Script Date: 2017-02-11 2:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
 CONSTRAINT [PK_CustomerType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Quantity] [int] NULL,
	[HeaderId] [int] NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Deputy]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Deputy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[CompanyId] [int] NULL,
	[Address] [nvarchar](500) NULL,
	[Phone1] [varchar](20) NULL,
	[Phone2] [varchar](20) NULL,
	[Birthday] [datetime] NULL,
	[Fax] [varchar](20) NULL,
	[Skype] [nvarchar](200) NULL,
	[Email] [varchar](100) NULL,
	[Note] [nvarchar](200) NULL,
	[StaffId] [int] NULL,
	[UserId] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Deputy] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ExportInventory]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExportInventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[InventoryId] [int] NULL,
	[Quantity] [int] NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_ExportInventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Housing]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Housing](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Housing] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ImportInventory]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ImportInventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[InventoryId] [int] NULL,
	[Quantity] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
	[Note] [nvarchar](200) NULL,
 CONSTRAINT [PK_ImportInventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Address] [nvarchar](200) NULL,
	[Width] [float] NULL,
	[Long] [float] NULL,
	[StaffId] [int] NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Material]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Material](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ObjectPermission]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ObjectPermission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [varchar](200) NULL,
	[ObjectName] [varchar](200) NULL,
	[Note] [nvarchar](200) NULL,
 CONSTRAINT [PK_ObjectPermission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Payment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[POId] [int] NULL,
	[CusId] [int] NULL,
	[Paid] [float] NULL,
	[StaffId] [int] NULL,
	[PaidDate] [datetime] NULL,
	[PaymentMethodId] [int] NULL,
	[Note] [nvarchar](200) NULL,
	[BankId] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PaymentMethod]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethod](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Note] [nvarchar](200) NULL,
 CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permission]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[ViewOwn] [bit] NULL,
	[ViewAll] [bit] NULL,
	[Create] [bit] NULL,
	[Update] [bit] NULL,
	[Delete] [bit] NULL,
	[UserId] [int] NULL,
	[ObjectPermissionId] [int] NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[ViewOwn] [bit] NULL,
	[ViewAll] [bit] NULL,
	[Create] [bit] NULL,
	[Edit] [bit] NULL,
	[Delete] [bit] NULL,
	[UserGroupId] [int] NULL,
	[ObjectPermissionId] [int] NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
 CONSTRAINT [PK_UserPermission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PO]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PO](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Name] [nvarchar](200) NULL,
	[CusId] [int] NULL,
	[DeputyId] [int] NULL,
	[StaffId] [int] NULL,
	[StatusId] [int] NULL,
	[TakePlace] [nvarchar](200) NULL,
	[Note] [nvarchar](200) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveBy] [varchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_PO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PODetail]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PODetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[PoId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[StandardId] [int] NULL,
	[HopePrice] [float] NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_PODetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[CategoryId] [int] NULL,
	[Watt] [float] NULL,
	[InputVoltage] [float] NULL,
	[Long] [float] NULL,
	[Height] [float] NULL,
	[Width] [float] NULL,
	[IP] [float] NULL,
	[ColorId] [int] NULL,
	[ClassId] [varchar](1) NULL,
	[Temperature] [float] NULL,
	[CRI] [float] NULL,
	[Angle] [float] NULL,
	[Head] [float] NULL,
	[DataSheet] [nvarchar](100) NULL,
	[InstallGuide] [nvarchar](max) NULL,
	[ThreeD] [nvarchar](100) NULL,
	[InVoltage] [float] NULL,
	[Dim] [float] NULL,
	[Led] [nvarchar](500) NULL,
	[Control] [nvarchar](500) NULL,
	[Finishing] [nvarchar](500) NULL,
	[IPRate] [nvarchar](500) NULL,
	[IKRate] [float] NULL,
	[ClassSafety] [nvarchar](500) NULL,
	[ENEC] [nvarchar](500) NULL,
	[Standard] [varchar](50) NULL,
	[PhotoMeter] [nvarchar](100) NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductColor]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductColor](
	[ProductId] [int] NOT NULL,
	[ColorId] [int] NOT NULL,
	[Note] [nchar](10) NULL,
 CONSTRAINT [PK_ProductColor] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[ColorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductPrice]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductPrice](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](200) NULL,
	[ProductId] [int] NULL,
	[Price] [float] NULL,
	[ActiveDate] [datetime] NULL,
	[Active] [bit] NULL,
	[UnitId] [int] NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_ProductPrice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductStandard]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductStandard](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_ProductStandard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProfileHousing]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProfileHousing](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_ProfileHousing] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Name] [nvarchar](200) NULL,
	[POId] [int] NULL,
	[QuotationId] [int] NULL,
	[ProductId] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Quotation]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Quotation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Name] [nvarchar](200) NULL,
	[CusId] [int] NULL,
	[StaffId] [int] NULL,
	[POId] [int] NULL,
	[StatusId] [int] NULL,
	[Note] [nvarchar](200) NULL,
	[ApproveDate] [datetime] NULL,
	[ApproveBy] [varchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Quotation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuotationDetail]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuotationDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[QuotationId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[StandardId] [int] NULL,
	[Price] [nchar](10) NULL,
	[Discount] [float] NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_QuotationDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staff](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Name] [nvarchar](200) NULL,
	[Phone1] [varchar](20) NULL,
	[Phone2] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[Fax] [varchar](20) NULL,
	[Skype] [nvarchar](100) NULL,
	[Address] [nvarchar](500) NULL,
	[Birthday] [datetime] NULL,
	[DepartmentId] [int] NULL,
	[PositionId] [int] NULL,
	[UserId] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [varchar](50) NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [varchar](50) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StaffPosition]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffPosition](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
 CONSTRAINT [PK_StaffPosition] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Status]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Note] [nvarchar](500) NULL,
	[Type] [int] NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StatusType]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Desc] [nvarchar](200) NULL,
 CONSTRAINT [PK_StatusType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SystemColor]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SystemColor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Code] [varchar](100) NULL,
	[HexCode] [varchar](10) NULL,
	[Note] [nvarchar](200) NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](200) NULL,
	[Note] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
 CONSTRAINT [PK_GroupUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](200) NULL,
	[Password] [varchar](200) NULL,
	[RecoverEmail] [varchar](100) NULL,
	[UserTypeId] [int] NULL,
	[UserGroupId] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[ModifyBy] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 2017-02-11 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[AppAccount] ON 

INSERT [dbo].[AppAccount] ([Id], [UserName], [Password], [RecoverEmail], [UserId], [UserTypeId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (1, N'quangphat', N'31F84BB5E0A2EE8D76144F099E3CF4AF2788D86163CC5B65A387A0A203B9B00F', N'quangphatitu@gmail.com', 1, 2, CAST(0x0000A58B00000000 AS DateTime), 1, CAST(0x0000A6E000F6ACE0 AS DateTime), 1)
INSERT [dbo].[AppAccount] ([Id], [UserName], [Password], [RecoverEmail], [UserId], [UserTypeId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (2, N'23', N'23', N'32', NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[AppAccount] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (2, N'Đèn gì đó', 0, N'1', CAST(0x0000A6E001230F20 AS DateTime), 1, CAST(0x0000A6E001230F70 AS DateTime), 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (3, N'test', 1, N'', CAST(0x0000A6E001236C23 AS DateTime), 1, CAST(0x0000A6E001236C23 AS DateTime), 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (1002, N'test', NULL, N'không có gì để tả', CAST(0x0000A6EB014B4F78 AS DateTime), 1, CAST(0x0000A6EB014B4F78 AS DateTime), 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (1003, N'tesssssss', NULL, N'', CAST(0x0000A6EB014BB284 AS DateTime), 1, CAST(0x0000A6EB014BB284 AS DateTime), 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (1004, N'sefsa', NULL, N'dfsdz', CAST(0x0000A6EB014C6678 AS DateTime), 1, CAST(0x0000A6EB014C6678 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([Id], [Code], [Name], [Address], [Phone1], [Phone2], [Fax], [Taxcode], [SwiftCode], [Employee], [DebitValue], [ParentCompanyId], [Branch], [TagetValue], [Website], [Email], [StaffId], [Note], [TypeId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (2, N'123', N'nghiahidhf', N'123', N'12', N'3', N'12', NULL, N'', 12, 22, 0, NULL, 2, N'2', N'123434', NULL, N'qw34er5t67i', NULL, CAST(0x0000A6F60146C40B AS DateTime), N'1', CAST(0x0000A6FB01004495 AS DateTime), N'1')
INSERT [dbo].[Company] ([Id], [Code], [Name], [Address], [Phone1], [Phone2], [Fax], [Taxcode], [SwiftCode], [Employee], [DebitValue], [ParentCompanyId], [Branch], [TagetValue], [Website], [Email], [StaffId], [Note], [TypeId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (3, N'123123444', N'55', N'123', N'12', N'3', N'12', NULL, N'', 12, 22, 0, NULL, 2, N'2', N'123434', NULL, N'qw34er5t67i', NULL, CAST(0x0000A6F6014C8C74 AS DateTime), N'1', CAST(0x0000A6F8013D47FA AS DateTime), N'1')
INSERT [dbo].[Company] ([Id], [Code], [Name], [Address], [Phone1], [Phone2], [Fax], [Taxcode], [SwiftCode], [Employee], [DebitValue], [ParentCompanyId], [Branch], [TagetValue], [Website], [Email], [StaffId], [Note], [TypeId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (4, N'fsdklnd', N'nghhi1234344', N'123', N'12', N'3', N'12', NULL, N'', 12, 22, 0, NULL, 2, N'2', N'123434', NULL, N'qw34er5t67i', NULL, CAST(0x0000A6F6014CB66C AS DateTime), N'1', CAST(0x0000A6F6016927ED AS DateTime), N'1')
INSERT [dbo].[Company] ([Id], [Code], [Name], [Address], [Phone1], [Phone2], [Fax], [Taxcode], [SwiftCode], [Employee], [DebitValue], [ParentCompanyId], [Branch], [TagetValue], [Website], [Email], [StaffId], [Note], [TypeId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (7, N'rq3efdsf', N'2e3dssdf', N'2242', N'243', N'2432', N'', NULL, N'', 242, 243224, 0, NULL, NULL, N'', N'234324', NULL, N'', NULL, CAST(0x0000A6FB00F99A13 AS DateTime), N'1', CAST(0x0000A6FB00F99A13 AS DateTime), N'1')
INSERT [dbo].[Company] ([Id], [Code], [Name], [Address], [Phone1], [Phone2], [Fax], [Taxcode], [SwiftCode], [Employee], [DebitValue], [ParentCompanyId], [Branch], [TagetValue], [Website], [Email], [StaffId], [Note], [TypeId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (8, N'nghia', N'ẻtyuiol', N'', N'24', N'34', N'', NULL, N'', NULL, NULL, 0, NULL, NULL, N'', N'23434', NULL, N'', NULL, CAST(0x0000A6FB00F9C285 AS DateTime), N'1', CAST(0x0000A6FB00F9C285 AS DateTime), N'1')
INSERT [dbo].[Company] ([Id], [Code], [Name], [Address], [Phone1], [Phone2], [Fax], [Taxcode], [SwiftCode], [Employee], [DebitValue], [ParentCompanyId], [Branch], [TagetValue], [Website], [Email], [StaffId], [Note], [TypeId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (9, N'213', N'1332344', N'56', N'1', N'2', N'', NULL, N'', NULL, 4, 0, NULL, NULL, N'', N'5', NULL, N'', NULL, CAST(0x0000A6FB00FAC636 AS DateTime), N'1', CAST(0x0000A6FB00FAC636 AS DateTime), N'1')
INSERT [dbo].[Company] ([Id], [Code], [Name], [Address], [Phone1], [Phone2], [Fax], [Taxcode], [SwiftCode], [Employee], [DebitValue], [ParentCompanyId], [Branch], [TagetValue], [Website], [Email], [StaffId], [Note], [TypeId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (13, N'12334', N'nghiait06', N'3133', N'13313', N'1333', N'', NULL, N'', NULL, 133131, 0, NULL, NULL, N'323', N'131313131', NULL, N'', NULL, CAST(0x0000A6FB00FFBD38 AS DateTime), N'1', CAST(0x0000A6FB01005E49 AS DateTime), N'1')
SET IDENTITY_INSERT [dbo].[Company] OFF
SET IDENTITY_INSERT [dbo].[CustomerType] ON 

INSERT [dbo].[CustomerType] ([Id], [Name]) VALUES (1, N'Khách hàng')
INSERT [dbo].[CustomerType] ([Id], [Name]) VALUES (2, N'Công ty')
INSERT [dbo].[CustomerType] ([Id], [Name]) VALUES (3, N'Loại khác')
SET IDENTITY_INSERT [dbo].[CustomerType] OFF
SET IDENTITY_INSERT [dbo].[ObjectPermission] ON 

INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (10, N'AppAccount', N'AppAccount', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (11, N'Bank', N'Bank', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (12, N'Category', N'Category', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (13, N'SystemColor', N'SystemColor', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (14, N'Company', N'Company', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (15, N'CurrencyUnit', N'CurrencyUnit', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (16, N'CurrentInventory', N'CurrentInventory', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (17, N'CustomerType', N'CustomerType', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (18, N'Department', N'Department', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (19, N'Deputy', N'Deputy', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (20, N'ExportInventory', N'ExportInventory', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (21, N'Housing', N'Housing', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (22, N'ImportInventory', N'ImportInventory', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (23, N'Inventory', N'Inventory', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (24, N'Material', N'Material', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (25, N'ObjectPermission', N'ObjectPermission', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (26, N'Payment', N'Payment', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (27, N'PaymentMethod', N'PaymentMethod', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (28, N'Permission', N'Permission', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (29, N'Permissions', N'Permissions', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (30, N'PO', N'PO', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (31, N'PODetail', N'PODetail', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (32, N'Product', N'Product', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (33, N'ProductColor', N'ProductColor', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (34, N'ProductStandard', N'ProductStandard', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (35, N'ProfileHousing', N'ProfileHousing', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (36, N'Project', N'Project', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (37, N'Quotation', N'Quotation', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (38, N'QuotationDetail', N'QuotationDetail', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (39, N'Staff', N'Staff', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (40, N'StaffPosition', N'StaffPosition', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (41, N'Status', N'Status', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (42, N'StatusType', N'StatusType', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (43, N'UserGroup', N'UserGroup', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (44, N'Users', N'Users', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (45, N'UserType', N'UserType', NULL)
INSERT [dbo].[ObjectPermission] ([Id], [TableName], [ObjectName], [Note]) VALUES (46, N'ProductPrice', N'ProductPrice', NULL)
SET IDENTITY_INSERT [dbo].[ObjectPermission] OFF
SET IDENTITY_INSERT [dbo].[Permission] ON 

INSERT [dbo].[Permission] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Update], [Delete], [UserId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (1, N'Admin', 1, 1, 1, 1, 1, 1, 1, N'Phát', NULL, NULL, NULL, NULL)
INSERT [dbo].[Permission] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Update], [Delete], [UserId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (2, N'Admin', 1, 1, 1, 1, 1, 1, 2, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Permission] OFF
SET IDENTITY_INSERT [dbo].[Permissions] ON 

INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (1, N'Quản lý người dùng', 1, 1, 1, 1, 1, 1, 3, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (2, N'Quản lý đơn hàng', 1, 1, 1, 1, 1, 1, 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (3, N'Quản lý Sản phẩm', 1, 1, 1, 1, 1, 1, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (4, N'Quản lý Nhóm người dùng', 1, 1, 1, 1, 1, 1, 43, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (5, N'Quyền', 1, 1, 1, 1, 1, 1, 29, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (6, NULL, 1, 1, 1, 1, 1, 1, 9, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (7, NULL, 1, 0, NULL, NULL, NULL, 7, 46, NULL, CAST(0x0000A6F500BE87D7 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (8, NULL, NULL, 1, 1, NULL, NULL, 7, 44, NULL, CAST(0x0000A6F500BE87D7 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (9, NULL, 1, 1, 1, 1, 1, 1, 46, NULL, CAST(0x0000A6F500F0126D AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (10, NULL, 1, 1, 1, 1, 1, 1, 42, NULL, CAST(0x0000A6F500F04EE7 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (11, NULL, 1, 0, 0, 0, 0, 1, 44, NULL, CAST(0x0000A6F500F0EB20 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (12, NULL, 1, 1, 1, 1, 1, 1, 44, NULL, CAST(0x0000A6F500F0FA3F AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (13, NULL, 1, 0, 0, 0, 0, 1, 27, NULL, CAST(0x0000A6F500F43E38 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (14, NULL, 1, 1, 1, 1, 1, 1, 27, NULL, CAST(0x0000A6F500F4482D AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (15, NULL, 1, 1, 1, 1, 1, 1, 45, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (16, NULL, 1, 1, 1, 1, 1, 1, 41, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (17, NULL, 1, 1, 1, 1, 1, 1, 40, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (18, NULL, 1, 1, 1, 1, 1, 1, 39, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (19, NULL, 1, 1, 1, 1, 1, 1, 38, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (20, NULL, 1, 1, 1, 1, 1, 1, 37, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (21, NULL, 1, 1, 1, 1, 1, 1, 36, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (22, NULL, 1, 1, 1, 1, 1, 1, 35, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (23, NULL, 1, 1, 1, 1, 1, 1, 34, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (24, NULL, 1, 1, 1, 1, 1, 1, 33, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (25, NULL, 1, 1, 1, 1, 1, 1, 32, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (26, NULL, 1, 1, 1, 1, 1, 1, 31, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (27, NULL, 1, 1, 1, 1, 1, 1, 30, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (28, NULL, 1, 1, 1, 1, 1, 1, 28, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (29, NULL, 1, 1, 1, 1, 1, 1, 26, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (30, NULL, 1, 1, 1, 1, 1, 1, 25, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (31, NULL, 1, 1, 1, 1, 1, 1, 24, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (32, NULL, 1, 1, 1, 1, 1, 1, 23, NULL, CAST(0x0000A6F500F4D600 AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (33, NULL, 1, 1, 1, 1, 1, 1, 22, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (34, NULL, 1, 1, 1, 1, 1, 1, 21, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (35, NULL, 1, 1, 1, 1, 1, 1, 20, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (36, NULL, 1, 1, 1, 1, 1, 1, 19, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (37, NULL, 1, 1, 1, 1, 1, 1, 18, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (38, NULL, 1, 1, 1, 1, 1, 1, 17, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (39, NULL, 1, 1, 1, 1, 1, 1, 16, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (40, NULL, 1, 1, 1, 1, 1, 1, 15, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (41, NULL, 1, 1, 1, 1, 1, 1, 14, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (42, NULL, 1, 1, 1, 1, 1, 1, 13, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (43, NULL, 1, 1, 1, 1, 1, 1, 12, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
INSERT [dbo].[Permissions] ([Id], [Name], [ViewOwn], [ViewAll], [Create], [Edit], [Delete], [UserGroupId], [ObjectPermissionId], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (44, NULL, 1, 1, 1, 1, 1, 1, 11, NULL, CAST(0x0000A6F500F52FFC AS DateTime), 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Permissions] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Code], [Name], [CategoryId], [Watt], [InputVoltage], [Long], [Height], [Width], [IP], [ColorId], [ClassId], [Temperature], [CRI], [Angle], [Head], [DataSheet], [InstallGuide], [ThreeD], [InVoltage], [Dim], [Led], [Control], [Finishing], [IPRate], [IKRate], [ClassSafety], [ENEC], [Standard], [PhotoMeter], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (1, N'erd', N'asd', 2, 1, 1, 1, 1, 1, 1, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, N'1', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000A6EB016E1286 AS DateTime), 1, CAST(0x0000A6EB016E1286 AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Code], [Name], [CategoryId], [Watt], [InputVoltage], [Long], [Height], [Width], [IP], [ColorId], [ClassId], [Temperature], [CRI], [Angle], [Head], [DataSheet], [InstallGuide], [ThreeD], [InVoltage], [Dim], [Led], [Control], [Finishing], [IPRate], [IKRate], [ClassSafety], [ENEC], [Standard], [PhotoMeter], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (2, N'23', N'123', 3, 32, 1, 4, 4, 3, 5, NULL, NULL, NULL, NULL, 3, NULL, NULL, NULL, NULL, NULL, NULL, N'3', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x0000A6EC01418A79 AS DateTime), 1, CAST(0x0000A6EC01418A79 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([Id], [Code], [Name], [Phone1], [Phone2], [Email], [Fax], [Skype], [Address], [Birthday], [DepartmentId], [PositionId], [UserId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (1, N'1', N'Phát', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Staff] ([Id], [Code], [Name], [Phone1], [Phone2], [Email], [Fax], [Skype], [Address], [Birthday], [DepartmentId], [PositionId], [UserId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (2, N'2', N'Yến', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Staff] OFF
SET IDENTITY_INSERT [dbo].[UserGroup] ON 

INSERT [dbo].[UserGroup] ([Id], [GroupName], [Note], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (1, N'Nhà phát triển', N'Lập trình', NULL, 1, NULL, 1)
SET IDENTITY_INSERT [dbo].[UserGroup] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [Password], [RecoverEmail], [UserTypeId], [UserGroupId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (1, N'quangphat', N'31F84BB5E0A2EE8D76144F099E3CF4AF2788D86163CC5B65A387A0A203B9B00F', N'quangphatitu@gmail.com', 2, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [RecoverEmail], [UserTypeId], [UserGroupId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (24, N'1', N'6B86B273FF34FCE19D6B804EFF5A3F5747ADA4EAA22F1D49C01E52DDB7875B4B', N'1', 1, 1, CAST(0x0000A6E700E5CE02 AS DateTime), 1, CAST(0x0000A6E700E5CE02 AS DateTime), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [RecoverEmail], [UserTypeId], [UserGroupId], [CreateDate], [CreateBy], [ModifyDate], [ModifyBy]) VALUES (25, N'2', N'D4735E3A265E16EEE03F59718B9B5D03019C07D8B6C51F90DA3A666EEC13AB35', N'2', 1, 1, CAST(0x0000A6E700E66B2A AS DateTime), 1, CAST(0x0000A6E700E66B2A AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
SET IDENTITY_INSERT [dbo].[UserType] ON 

INSERT [dbo].[UserType] ([Id], [Name]) VALUES (1, N'Khách hàng')
INSERT [dbo].[UserType] ([Id], [Name]) VALUES (2, N'Nhân viên')
SET IDENTITY_INSERT [dbo].[UserType] OFF
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1.Công ty; 2.Supplier;3.Personal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Bank', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1.Khác hàng mua sản phầm hay nhà cung cấp' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CustomerType', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'người có cấp cao nhất của phòng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Department', @level2type=N'COLUMN',@level2name=N'HeaderId'
GO

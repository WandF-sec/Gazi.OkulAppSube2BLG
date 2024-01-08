CREATE DATABASE BerkeOdev;
GO

USE BerkeOdev;
GO
/****** Object:  Table [dbo].[Ogrenciler]    Script Date: 24.12.2023 22:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenciler](
	[OgrenciId] [smallint] IDENTITY(1,1) NOT NULL,
	[OgrenciAd] [varchar](30) NOT NULL,
	[OgrenciSoyad] [varchar](20) NOT NULL,
	[OgrenciNumara] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Ogrenciler] PRIMARY KEY CLUSTERED 
(
	[OgrenciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogretmenler]    Script Date: 24.12.2023 22:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogretmenler](
	[OgretmenId] [smallint] IDENTITY(1,1) NOT NULL,
	[OgretmenAd] [varchar](30) NOT NULL,
	[OgretmenSoyad] [varchar](20) NOT NULL,
	[OgretmenTc] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Ogretmenler] PRIMARY KEY CLUSTERED 
(
	[OgretmenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

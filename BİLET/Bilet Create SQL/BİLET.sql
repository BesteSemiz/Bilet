USE [master]
GO
/****** Object:  Database [Bilet]    Script Date: 11.04.2022 15:23:33 ******/
CREATE DATABASE [Bilet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bilet', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Bilet.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bilet_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Bilet_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bilet] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bilet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bilet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bilet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bilet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bilet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bilet] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bilet] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bilet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bilet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bilet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bilet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bilet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bilet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bilet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bilet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bilet] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Bilet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bilet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bilet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bilet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bilet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bilet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bilet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bilet] SET RECOVERY FULL 
GO
ALTER DATABASE [Bilet] SET  MULTI_USER 
GO
ALTER DATABASE [Bilet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bilet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bilet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bilet] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bilet] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bilet] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Bilet', N'ON'
GO
ALTER DATABASE [Bilet] SET QUERY_STORE = OFF
GO
USE [Bilet]
GO
/****** Object:  Table [dbo].[BiletIade]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BiletIade](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EtkinlikId] [int] NULL,
	[SatinAlanAd] [nvarchar](200) NULL,
	[SatinAlanSoyad] [nvarchar](200) NULL,
	[AlinanKoltuklar] [nvarchar](1000) NULL,
	[BiletAdet] [int] NULL,
	[BiletFiyat] [int] NULL,
	[ToplamBiletFiyat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BiletSatis]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BiletSatis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EtkinlikId] [int] NULL,
	[SatinAlanAd] [nvarchar](200) NULL,
	[SatinAlanSoyad] [nvarchar](200) NULL,
	[AlinanKoltuklar] [nvarchar](1000) NULL,
	[BiletAdet] [int] NULL,
	[BiletFiyat] [int] NULL,
	[ToplamBiletFiyat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etkinlikler]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etkinlikler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EtkinlikTurId] [int] NULL,
	[Ad] [nvarchar](1000) NULL,
	[Mekan] [nvarchar](200) NULL,
	[Salon] [nvarchar](200) NULL,
	[Tarih] [nvarchar](200) NULL,
	[Saat] [nvarchar](200) NULL,
	[BiletSayisi] [int] NULL,
	[BiletFiyat] [int] NULL,
	[BiletAcilis] [nvarchar](200) NULL,
	[BiletBitis] [nvarchar](200) NULL,
	[EtkinlikMaliyeti] [int] NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EtkinlikTuru]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EtkinlikTuru](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TurAdi] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kisiler]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisiler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](200) NULL,
	[Sifre] [int] NULL,
	[YetkiId] [int] NULL,
	[Ad] [nvarchar](200) NULL,
	[Soyad] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mekanlar]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mekanlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MekanIl] [nvarchar](200) NULL,
	[MekanIlce] [nvarchar](200) NULL,
	[MekanAdi] [nvarchar](200) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Muhasebe]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muhasebe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [date] NULL,
	[Turu] [nvarchar](200) NULL,
	[Aciklama] [nvarchar](1000) NULL,
	[Gelir] [int] NULL,
	[Gider] [int] NULL,
	[HesapBakiyesi] [int] NULL,
	[ToplamBakiye] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuhasebeTuru]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuhasebeTuru](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MuhasebeTuru] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](200) NULL,
	[Sifre] [nvarchar](5) NULL,
	[YetkiId] [int] NULL,
	[Ad] [nvarchar](200) NULL,
	[Soyad] [nvarchar](200) NULL,
	[TCKimlik] [nvarchar](11) NULL,
	[Maas] [int] NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salonlar]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salonlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MekanAdi] [nvarchar](200) NULL,
	[SalonAdi] [nvarchar](200) NULL,
	[KoltukSirasi] [int] NULL,
	[SiradakiKoltukSayisi] [int] NULL,
	[ToplamKoltukSayisi] [int] NULL,
	[SalonKirasi] [int] NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uyeler]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uyeler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](200) NULL,
	[Sifre] [int] NULL,
	[YetkiId] [int] NULL,
	[Ad] [nvarchar](200) NULL,
	[Soyad] [nvarchar](200) NULL,
	[Mail] [nvarchar](200) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetkiler]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetkiler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YetkiAd] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BiletSatis] ON 

INSERT [dbo].[BiletSatis] ([Id], [EtkinlikId], [SatinAlanAd], [SatinAlanSoyad], [AlinanKoltuklar], [BiletAdet], [BiletFiyat], [ToplamBiletFiyat]) VALUES (1, 3, N'Ayse', N'Semiz', N'1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 - 10 - 11 - 12 - 13 - 14 - 15 - 16 - 17 - 18 - 19 - 20 - 21 - 22 - 23 - 24 - 25 - 26 - 27 - 28 - 29 - 30 - 31 - 32 - 33 - 34 - 35 - 36 - 37 - 38 - 39 - 40 - 41 - 42 - 43 - 44 - 45 - 46 - 47 - 48 - 49 - 50 - ', 50, 50, 2500)
INSERT [dbo].[BiletSatis] ([Id], [EtkinlikId], [SatinAlanAd], [SatinAlanSoyad], [AlinanKoltuklar], [BiletAdet], [BiletFiyat], [ToplamBiletFiyat]) VALUES (2, 1, N'Ayşe', N'Sulu', N'10 - 11 - 12 - 13 - ', 4, 60, 240)
INSERT [dbo].[BiletSatis] ([Id], [EtkinlikId], [SatinAlanAd], [SatinAlanSoyad], [AlinanKoltuklar], [BiletAdet], [BiletFiyat], [ToplamBiletFiyat]) VALUES (3, 1, N'', N'', N'74-75-', 2, 60, 240)
SET IDENTITY_INSERT [dbo].[BiletSatis] OFF
GO
SET IDENTITY_INSERT [dbo].[Etkinlikler] ON 

INSERT [dbo].[Etkinlikler] ([Id], [EtkinlikTurId], [Ad], [Mekan], [Salon], [Tarih], [Saat], [BiletSayisi], [BiletFiyat], [BiletAcilis], [BiletBitis], [EtkinlikMaliyeti], [Durum]) VALUES (1, 1, N'İkiye On Kala', N'İBB Cem Karaca Kültür Merkezi', N'B Salonu', N'16.4.2022', N'20:00', 114, 60, N'30.3.2022', N'15.4.2022', 9000, 1)
INSERT [dbo].[Etkinlikler] ([Id], [EtkinlikTurId], [Ad], [Mekan], [Salon], [Tarih], [Saat], [BiletSayisi], [BiletFiyat], [BiletAcilis], [BiletBitis], [EtkinlikMaliyeti], [Durum]) VALUES (2, 2, N'Vektor . Special Guest: Cryptosis', N'İBB Bülent Ecevit Kültür Merkezi', N'C Salonu', N'13.8.2022', N'20:30', 80, 100, N'15.4.2022', N'10.8.2022', 8000, 1)
INSERT [dbo].[Etkinlikler] ([Id], [EtkinlikTurId], [Ad], [Mekan], [Salon], [Tarih], [Saat], [BiletSayisi], [BiletFiyat], [BiletAcilis], [BiletBitis], [EtkinlikMaliyeti], [Durum]) VALUES (3, 3, N'İstanbul Oda Orkestrası', N'Cemal Reşit Rey Konser Salonu (CRR)', N'A Salonu', N'10.4.2022', N'20:00', 0, 50, N'29.3.2022', N'9.4.2022', 7000, 1)
INSERT [dbo].[Etkinlikler] ([Id], [EtkinlikTurId], [Ad], [Mekan], [Salon], [Tarih], [Saat], [BiletSayisi], [BiletFiyat], [BiletAcilis], [BiletBitis], [EtkinlikMaliyeti], [Durum]) VALUES (4, 4, N'Venezuela Simon Bolivar Senfoni Orkestrası', N'İBB İdris Güllüce Kültür Merkezi', N'C Salonu', N'10.4.2022', N'20:00', 350, 60, N'29.3.2022', N'9.4.2022', 12000, 1)
INSERT [dbo].[Etkinlikler] ([Id], [EtkinlikTurId], [Ad], [Mekan], [Salon], [Tarih], [Saat], [BiletSayisi], [BiletFiyat], [BiletAcilis], [BiletBitis], [EtkinlikMaliyeti], [Durum]) VALUES (5, 5, N'1984 . Büyük Gözaltı', N'İBB Şehit Kaymakam M. Fatih Safitürk Kültür Merkezi', N'C Salonu', N'24.5.2022', N'19:00', 120, 80, N'10.4.2022', N'20.5.2022', 9000, 1)
INSERT [dbo].[Etkinlikler] ([Id], [EtkinlikTurId], [Ad], [Mekan], [Salon], [Tarih], [Saat], [BiletSayisi], [BiletFiyat], [BiletAcilis], [BiletBitis], [EtkinlikMaliyeti], [Durum]) VALUES (6, 6, N'Uykusuzlar Kulübü', N'İBB Erdem Bayazıt Kültür Merkezi', N'B Salonu', N'1.6.2022', N'22:00', 350, 120, N'1.4.2022', N'30.5.2022', 15000, 1)
INSERT [dbo].[Etkinlikler] ([Id], [EtkinlikTurId], [Ad], [Mekan], [Salon], [Tarih], [Saat], [BiletSayisi], [BiletFiyat], [BiletAcilis], [BiletBitis], [EtkinlikMaliyeti], [Durum]) VALUES (7, 7, N'İlber Ortaylı İle Gündem Ötesi', N'İBB Ali Emiri Efendi Kültür Merkezi', N'C Salonu', N'16.5.2022', N'16:00', 120, 120, N'10.4.2022', N'15.5.2022', 10000, 1)
INSERT [dbo].[Etkinlikler] ([Id], [EtkinlikTurId], [Ad], [Mekan], [Salon], [Tarih], [Saat], [BiletSayisi], [BiletFiyat], [BiletAcilis], [BiletBitis], [EtkinlikMaliyeti], [Durum]) VALUES (8, 8, N'Fenerbahçe.Galatasaray', N'Şükrü Saraçoğlu Stadı', N'A Salonu', N'6.6.2022', N'20:00', 300, 150, N'4.4.2022', N'5.6.2022', 17000, 1)
INSERT [dbo].[Etkinlikler] ([Id], [EtkinlikTurId], [Ad], [Mekan], [Salon], [Tarih], [Saat], [BiletSayisi], [BiletFiyat], [BiletAcilis], [BiletBitis], [EtkinlikMaliyeti], [Durum]) VALUES (9, 9, N'Fenerbahçe.Vakıfbank', N'Şükrü Saraçoğlu Stadı', N'B Salonu', N'12.5.2022', N'16:00', 200, 150, N'6.4.2022', N'11.5.2022', 16000, 1)
INSERT [dbo].[Etkinlikler] ([Id], [EtkinlikTurId], [Ad], [Mekan], [Salon], [Tarih], [Saat], [BiletSayisi], [BiletFiyat], [BiletAcilis], [BiletBitis], [EtkinlikMaliyeti], [Durum]) VALUES (10, 10, N'Fenerbahçe.FinansBank', N'Şükrü Saraçoğlu Stadı', N'C Salonu', N'3.7.2022', N'19:30', 100, 120, N'5.4.2022', N'2.7.2022', 15000, 1)
SET IDENTITY_INSERT [dbo].[Etkinlikler] OFF
GO
SET IDENTITY_INSERT [dbo].[EtkinlikTuru] ON 

INSERT [dbo].[EtkinlikTuru] ([Id], [TurAdi]) VALUES (1, N'Pop')
INSERT [dbo].[EtkinlikTuru] ([Id], [TurAdi]) VALUES (2, N'Rock')
INSERT [dbo].[EtkinlikTuru] ([Id], [TurAdi]) VALUES (3, N'Caz')
INSERT [dbo].[EtkinlikTuru] ([Id], [TurAdi]) VALUES (4, N'Klasik')
INSERT [dbo].[EtkinlikTuru] ([Id], [TurAdi]) VALUES (5, N'Tiyatro')
INSERT [dbo].[EtkinlikTuru] ([Id], [TurAdi]) VALUES (6, N'Stand Up')
INSERT [dbo].[EtkinlikTuru] ([Id], [TurAdi]) VALUES (7, N'Söyleşi')
INSERT [dbo].[EtkinlikTuru] ([Id], [TurAdi]) VALUES (8, N'Futbol')
INSERT [dbo].[EtkinlikTuru] ([Id], [TurAdi]) VALUES (9, N'Voleybol')
INSERT [dbo].[EtkinlikTuru] ([Id], [TurAdi]) VALUES (10, N'Basketbol')
SET IDENTITY_INSERT [dbo].[EtkinlikTuru] OFF
GO
SET IDENTITY_INSERT [dbo].[Kisiler] ON 

INSERT [dbo].[Kisiler] ([Id], [KullaniciAdi], [Sifre], [YetkiId], [Ad], [Soyad]) VALUES (1, N'EKaya', 12345, 1, N'Erhan', N'Kaya')
INSERT [dbo].[Kisiler] ([Id], [KullaniciAdi], [Sifre], [YetkiId], [Ad], [Soyad]) VALUES (2, N'BSemiz', 54321, 2, N'Beste', N'Semiz')
INSERT [dbo].[Kisiler] ([Id], [KullaniciAdi], [Sifre], [YetkiId], [Ad], [Soyad]) VALUES (3, N'ASekerci', 56789, 3, N'Ahmet', N'Şekerci')
INSERT [dbo].[Kisiler] ([Id], [KullaniciAdi], [Sifre], [YetkiId], [Ad], [Soyad]) VALUES (4, N'GHasbal', 98765, 4, N'Gökhan', N'Hasbal')
INSERT [dbo].[Kisiler] ([Id], [KullaniciAdi], [Sifre], [YetkiId], [Ad], [Soyad]) VALUES (5, N'Helesa', 12345, 5, N'Ayse', N'Semiz')
SET IDENTITY_INSERT [dbo].[Kisiler] OFF
GO
SET IDENTITY_INSERT [dbo].[Mekanlar] ON 

INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (1, N'İstanbul', N'Bahçelievler', N'İBB Yenibosna Dr. Enver Ören Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (2, N'İstanbul', N'Bakırköy', N'İBB Cem Karaca Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (3, N'İstanbul', N'Başakşehir', N'İBB Başakşehir Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (4, N'İstanbul', N'Beyoğlu', N'İBB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (5, N'İstanbul', N'Beyoğlu', N'Taksim Sanat', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (6, N'İstanbul', N'Esenler', N'İBB Prof. Dr. Adem Baştürk Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (7, N'İstanbul', N'Fatih', N'İBB Ali Emiri Efendi Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (8, N'İstanbul', N'Güngören', N'İBB Erdem Bayazıt Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (9, N'İstanbul', N'Kartal', N'İBB Bülent Ecevit Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (10, N'İstanbul', N'Ümraniye', N'İBB Şehit Kaymakam M. Fatih Safitürk Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (11, N'İstanbul', N'Sancaktepe', N'İBB Sancaktepe Eyüp Sultan Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (12, N'İstanbul', N'Sultanbeyli', N'İBB Prof. Dr. Necmettin Erbakan Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (13, N'İstanbul', N'Şile', N'İBB Şile Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (14, N'İstanbul', N'Şişli', N'Cemal Reşit Rey Konser Salonu (CRR)', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (15, N'İstanbul', N'Tuzla', N'İBB İdris Güllüce Kültür Merkezi', 1)
INSERT [dbo].[Mekanlar] ([Id], [MekanIl], [MekanIlce], [MekanAdi], [Durum]) VALUES (16, N'İstanbul', N'Kadıköy', N'Şükrü Saraçoğlu Stadı', 1)
SET IDENTITY_INSERT [dbo].[Mekanlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Muhasebe] ON 

INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (1, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Personel Maaş', 0, 10000, -10000, -10000)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (2, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Personel Maaş', 0, 9000, -9000, -19000)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (3, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Personel Maaş', 0, 7500, -7500, -26500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (4, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Personel Maaş', 0, 6000, -6000, -32500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (5, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Etkinlik Maliyeti', 0, 9000, -9000, -41500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (6, CAST(N'2022-04-09' AS Date), N'Kira', N'Salon Kirası', 0, 7500, -7500, -49000)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (7, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Etkinlik Maliyeti', 0, 8000, -8000, -57000)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (8, CAST(N'2022-04-09' AS Date), N'Kira', N'Salon Kirası', 0, 6500, -6500, -63500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (9, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Etkinlik Maliyeti', 0, 7000, -7000, -70500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (10, CAST(N'2022-04-09' AS Date), N'Kira', N'Salon Kirası', 0, 5000, -5000, -75500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (11, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Etkinlik Maliyeti', 0, 12000, -12000, -87500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (12, CAST(N'2022-04-09' AS Date), N'Kira', N'Salon Kirası', 0, 10000, -10000, -97500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (13, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Etkinlik Maliyeti', 0, 9000, -9000, -106500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (14, CAST(N'2022-04-09' AS Date), N'Kira', N'Salon Kirası', 0, 7500, -7500, -114000)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (15, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Etkinlik Maliyeti', 0, 15000, -15000, -129000)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (16, CAST(N'2022-04-09' AS Date), N'Kira', N'Salon Kirası', 0, 10000, -10000, -139000)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (17, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Etkinlik Maliyeti', 0, 10000, -10000, -149000)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (18, CAST(N'2022-04-09' AS Date), N'Kira', N'Salon Kirası', 0, 7500, -7500, -156500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (19, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Etkinlik Maliyeti', 0, 17000, -17000, -173500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (20, CAST(N'2022-04-09' AS Date), N'Kira', N'Salon Kirası', 0, 15000, -15000, -188500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (21, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Etkinlik Maliyeti', 0, 16000, -16000, -204500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (22, CAST(N'2022-04-09' AS Date), N'Kira', N'Salon Kirası', 0, 12000, -12000, -216500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (23, CAST(N'2022-04-09' AS Date), N'Hizmet', N'Etkinlik Maliyeti', 0, 15000, -15000, -231500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (24, CAST(N'2022-04-09' AS Date), N'Kira', N'Salon Kirası', 0, 10000, -10000, -241500)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (25, CAST(N'2022-04-10' AS Date), N'Fatura', N'Bilet Satis', 2500, 0, 2500, -239000)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (26, CAST(N'2022-04-10' AS Date), N'Bağış', N'KOSGEB DESTEK', 500000, 0, 500000, 261000)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (27, CAST(N'2022-04-10' AS Date), N'Fatura', N'Bilet Satis', 240, 0, 240, 261240)
INSERT [dbo].[Muhasebe] ([Id], [Tarih], [Turu], [Aciklama], [Gelir], [Gider], [HesapBakiyesi], [ToplamBakiye]) VALUES (28, CAST(N'2022-04-10' AS Date), N'Fatura', N'Bilet Satis', 240, 0, 240, 261480)
SET IDENTITY_INSERT [dbo].[Muhasebe] OFF
GO
SET IDENTITY_INSERT [dbo].[MuhasebeTuru] ON 

INSERT [dbo].[MuhasebeTuru] ([Id], [MuhasebeTuru]) VALUES (1, N'Hizmet')
INSERT [dbo].[MuhasebeTuru] ([Id], [MuhasebeTuru]) VALUES (2, N'Fatura')
INSERT [dbo].[MuhasebeTuru] ([Id], [MuhasebeTuru]) VALUES (3, N'Bağış')
SET IDENTITY_INSERT [dbo].[MuhasebeTuru] OFF
GO
SET IDENTITY_INSERT [dbo].[Personeller] ON 

INSERT [dbo].[Personeller] ([Id], [KullaniciAdi], [Sifre], [YetkiId], [Ad], [Soyad], [TCKimlik], [Maas], [Durum]) VALUES (1, N'EKaya', N'12345', 1, N'Erhan', N'Kaya', N'11122233344', 10000, 1)
INSERT [dbo].[Personeller] ([Id], [KullaniciAdi], [Sifre], [YetkiId], [Ad], [Soyad], [TCKimlik], [Maas], [Durum]) VALUES (2, N'BSemiz', N'54321', 2, N'Beste', N'Semiz', N'11122233355', 9000, 1)
INSERT [dbo].[Personeller] ([Id], [KullaniciAdi], [Sifre], [YetkiId], [Ad], [Soyad], [TCKimlik], [Maas], [Durum]) VALUES (3, N'ASekerci', N'56789', 3, N'Ahmet', N'Şekerci', N'11122233366', 7500, 1)
INSERT [dbo].[Personeller] ([Id], [KullaniciAdi], [Sifre], [YetkiId], [Ad], [Soyad], [TCKimlik], [Maas], [Durum]) VALUES (4, N'GHasbal', N'98765', 4, N'Gökhan', N'Hasbal', N'11122233377', 6000, 1)
SET IDENTITY_INSERT [dbo].[Personeller] OFF
GO
SET IDENTITY_INSERT [dbo].[Salonlar] ON 

INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (1, N'Şükrü Saraçoğlu Stadı', N'A Salonu', 10, 30, 300, 15000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (2, N'Şükrü Saraçoğlu Stadı', N'B Salonu', 10, 20, 200, 12000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (3, N'Şükrü Saraçoğlu Stadı', N'C Salonu', 10, 10, 100, 10000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (4, N'İBB Yenibosna Dr. Enver Ören Kültür Merkezi', N'A Salonu', 5, 10, 50, 5000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (5, N'İBB Yenibosna Dr. Enver Ören Kültür Merkezi', N'B Salonu', 8, 10, 80, 6500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (6, N'İBB Yenibosna Dr. Enver Ören Kültür Merkezi', N'C Salonu', 6, 20, 120, 7500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (7, N'İBB Cem Karaca Kültür Merkezi', N'A Salonu', 3, 10, 30, 3000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (8, N'İBB Cem Karaca Kültür Merkezi', N'B Salonu', 4, 30, 120, 7500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (9, N'İBB Cem Karaca Kültür Merkezi', N'C Salonu', 10, 20, 200, 8000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (10, N'İBB Başakşehir Kültür Merkezi', N'A Salonu', 5, 10, 50, 5000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (11, N'İBB Başakşehir Kültür Merkezi', N'B Salonu', 8, 10, 80, 6500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (12, N'İBB Başakşehir Kültür Merkezi', N'C Salonu', 6, 30, 180, 7750, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (13, N'İBB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)', N'A Salonu', 5, 70, 350, 10000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (14, N'İBB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)', N'B Salonu', 8, 20, 160, 8000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (15, N'İBB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)', N'C Salonu', 5, 20, 100, 6000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (16, N'Taksim Sanat', N'A Salonu', 5, 10, 50, 5000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (17, N'Taksim Sanat', N'B Salonu', 8, 30, 240, 8000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (18, N'Taksim Sanat', N'C Salonu', 6, 40, 240, 8500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (19, N'İBB Prof. Dr. Adem Baştürk Kültür Merkezi', N'A Salonu', 7, 30, 210, 8250, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (20, N'İBB Prof. Dr. Adem Baştürk Kültür Merkezi', N'B Salonu', 5, 80, 400, 20000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (21, N'İBB Prof. Dr. Adem Baştürk Kültür Merkezi', N'C Salonu', 3, 80, 240, 8500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (22, N'İBB Ali Emiri Efendi Kültür Merkezi', N'A Salonu', 8, 10, 80, 6500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (23, N'İBB Ali Emiri Efendi Kültür Merkezi', N'B Salonu', 5, 20, 100, 6000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (24, N'İBB Ali Emiri Efendi Kültür Merkezi', N'C Salonu', 6, 20, 120, 7500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (25, N'İBB Erdem Bayazıt Kültür Merkezi', N'A Salonu', 6, 20, 120, 7500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (26, N'İBB Erdem Bayazıt Kültür Merkezi', N'B Salonu', 5, 70, 350, 10000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (27, N'İBB Erdem Bayazıt Kültür Merkezi', N'C Salonu', 8, 10, 80, 6500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (28, N'İBB Bülent Ecevit Kültür Merkezi', N'A Salonu', 5, 20, 100, 6000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (29, N'İBB Bülent Ecevit Kültür Merkezi', N'B Salonu', 5, 70, 350, 10000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (30, N'İBB Bülent Ecevit Kültür Merkezi', N'C Salonu', 8, 10, 80, 6500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (31, N'İBB Şehit Kaymakam M. Fatih Safitürk Kültür Merkezi', N'A Salonu', 8, 10, 80, 6500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (32, N'İBB Şehit Kaymakam M. Fatih Safitürk Kültür Merkezi', N'B Salonu', 5, 10, 50, 5000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (33, N'İBB Şehit Kaymakam M. Fatih Safitürk Kültür Merkezi', N'C Salonu', 6, 20, 120, 7500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (34, N'İBB Sancaktepe Eyüp Sultan Kültür Merkezi', N'A Salonu', 6, 20, 120, 7500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (35, N'İBB Sancaktepe Eyüp Sultan Kültür Merkezi', N'B Salonu', 5, 70, 350, 10000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (36, N'İBB Sancaktepe Eyüp Sultan Kültür Merkezi', N'C Salonu', 5, 20, 100, 6000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (37, N'İBB Prof. Dr. Necmettin Erbakan Kültür Merkezi', N'A Salonu', 5, 10, 50, 5000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (38, N'İBB Prof. Dr. Necmettin Erbakan Kültür Merkezi', N'B Salonu', 5, 20, 100, 6000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (39, N'İBB Prof. Dr. Necmettin Erbakan Kültür Merkezi', N'C Salonu', 4, 30, 120, 7500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (40, N'İBB Şile Kültür Merkezi', N'A Salonu', 8, 10, 80, 6500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (41, N'İBB Şile Kültür Merkezi', N'B Salonu', 6, 20, 120, 7500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (42, N'İBB Şile Kültür Merkezi', N'C Salonu', 4, 30, 120, 7500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (43, N'Cemal Reşit Rey Konser Salonu (CRR)', N'A Salonu', 5, 10, 50, 5000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (44, N'Cemal Reşit Rey Konser Salonu (CRR)', N'B Salonu', 8, 10, 80, 6500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (45, N'Cemal Reşit Rey Konser Salonu (CRR)', N'C Salonu', 5, 70, 350, 10000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (46, N'İBB İdris Güllüce Kültür Merkezi', N'A Salonu', 8, 10, 80, 6500, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (47, N'İBB İdris Güllüce Kültür Merkezi', N'B Salonu', 5, 70, 350, 10000, 1)
INSERT [dbo].[Salonlar] ([Id], [MekanAdi], [SalonAdi], [KoltukSirasi], [SiradakiKoltukSayisi], [ToplamKoltukSayisi], [SalonKirasi], [Durum]) VALUES (48, N'İBB İdris Güllüce Kültür Merkezi', N'C Salonu', 5, 70, 350, 10000, 1)
SET IDENTITY_INSERT [dbo].[Salonlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Uyeler] ON 

INSERT [dbo].[Uyeler] ([Id], [KullaniciAdi], [Sifre], [YetkiId], [Ad], [Soyad], [Mail], [Durum]) VALUES (1, N'Helesa', 12345, 5, N'Ayse', N'Semiz', N'as@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[Uyeler] OFF
GO
SET IDENTITY_INSERT [dbo].[Yetkiler] ON 

INSERT [dbo].[Yetkiler] ([Id], [YetkiAd]) VALUES (1, N'Mudur')
INSERT [dbo].[Yetkiler] ([Id], [YetkiAd]) VALUES (2, N'Organizasyon Muduru')
INSERT [dbo].[Yetkiler] ([Id], [YetkiAd]) VALUES (3, N'Bilet Satis Yetkilisi')
INSERT [dbo].[Yetkiler] ([Id], [YetkiAd]) VALUES (4, N'Hizmetli')
INSERT [dbo].[Yetkiler] ([Id], [YetkiAd]) VALUES (5, N'Uye')
SET IDENTITY_INSERT [dbo].[Yetkiler] OFF
GO
/****** Object:  StoredProcedure [dbo].[BiletIadeSP]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BiletIadeSP]
@EtkinlikId int,
@SatinAlanAd nvarchar(200),
@SatinAlanSoyad nvarchar(200),
@AlinanKoltuklar nvarchar(1000),
@BiletAdet int,
@BiletFiyat int,
@ToplamBiletFiyat int
as
begin
insert into BiletIade(EtkinlikId,SatinAlanAd,SatinAlanSoyad,AlinanKoltuklar,BiletAdet,BiletFiyat,ToplamBiletFiyat)
values(@EtkinlikId,@SatinAlanAd,@SatinAlanSoyad,@AlinanKoltuklar,@BiletAdet,@BiletFiyat,@ToplamBiletFiyat)
end
GO
/****** Object:  StoredProcedure [dbo].[BiletSatisSP]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[BiletSatisSP]
@EtkinlikId int,
@SatinAlanAd nvarchar(200),
@SatinAlanSoyad nvarchar(200),
@AlinanKoltuklar nvarchar(1000),
@BiletAdet int,
@BiletFiyat int,
@ToplamBiletFiyat int
as
begin
insert into BiletSatis(EtkinlikId,SatinAlanAd,SatinAlanSoyad,AlinanKoltuklar,BiletAdet,BiletFiyat,ToplamBiletFiyat)
values(@EtkinlikId,@SatinAlanAd,@SatinAlanSoyad,@AlinanKoltuklar,@BiletAdet,@BiletFiyat,@ToplamBiletFiyat)
end
GO
/****** Object:  StoredProcedure [dbo].[EtkinlikEkle]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[EtkinlikEkle]
@EtkinlikTurId int,
@Ad nvarchar(1000),
@Mekan nvarchar(200),
@Salon nvarchar(200),
@Tarih nvarchar(200),
@Saat nvarchar(200),
@BiletSayisi int,
@BiletFiyat int,
@BiletAcilis nvarchar(200),
@BiletBitis nvarchar(200),
@EtkinlikMaliyeti int,
@Durum bit
as
begin
insert into Etkinlikler(EtkinlikTurId,Ad,Mekan,Salon,Tarih,Saat,BiletSayisi,BiletFiyat,BiletAcilis,BiletBitis,EtkinlikMaliyeti,Durum)
values(@EtkinlikTurId,@Ad,@Mekan,@Salon,@Tarih,@Saat,@BiletSayisi,@BiletFiyat,@BiletAcilis,@BiletBitis,@EtkinlikMaliyeti,1)
end
GO
/****** Object:  StoredProcedure [dbo].[EtkinlikTuruEkle]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[EtkinlikTuruEkle]
@TurAdi nvarchar(200)
as
begin
insert into EtkinlikTuru(TurAdi)
values(@TurAdi)
end
GO
/****** Object:  StoredProcedure [dbo].[GelirEkle]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[GelirEkle]
@Tarih date,
@Turu nvarchar(200),
@Aciklama nvarchar(1000),
@Gelir int,
@HesapBakiyesi int
as
declare @ToplamBakiye int
select top 1 @ToplamBakiye=ToplamBakiye FROM Muhasebe order by Id desc
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values (@Tarih,@Turu,@Aciklama,@Gelir,0,@HesapBakiyesi,(@ToplamBakiye+@HesapBakiyesi))
end
GO
/****** Object:  StoredProcedure [dbo].[GiderEkle]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[GiderEkle]
@Tarih date,
@Turu nvarchar(200),
@Aciklama nvarchar(1000),
@Gider int,
@HesapBakiyesi int
as
declare @ToplamBakiye int
select top 1 @ToplamBakiye=ToplamBakiye FROM Muhasebe order by Id desc
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values (@Tarih,@Turu,@Aciklama,0,@Gider,-@HesapBakiyesi,(@ToplamBakiye - @HesapBakiyesi))
end
GO
/****** Object:  StoredProcedure [dbo].[MekanEkle]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[MekanEkle]
@MekanIl nvarchar(200),
@MekanIlce nvarchar(200),
@MekanAdi nvarchar(200),
@Durum bit
as
begin
insert into Mekanlar(MekanIl,MekanIlce,MekanAdi,Durum)
values(@MekanIl,@MekanIlce,@MekanAdi,1)
end
GO
/****** Object:  StoredProcedure [dbo].[MekanSil]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[MekanSil]
@MekanAdi nvarchar(200)
as
begin
delete from Mekanlar where @MekanAdi=MekanAdi
delete from Salonlar where @MekanAdi=MekanAdi
end
GO
/****** Object:  StoredProcedure [dbo].[MuhasebeTuruEkle]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[MuhasebeTuruEkle]
@MuhasebeTuru nvarchar(200)
as
begin
insert into MuhasebeTuru(MuhasebeTuru)
values(@MuhasebeTuru)
end
GO
/****** Object:  StoredProcedure [dbo].[PersonelEkle]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[PersonelEkle]
@KullaniciAdi nvarchar(200),
@Sifre nvarchar(5),
@YetkiId int,
@Ad nvarchar(200),
@Soyad nvarchar(200),
@TCKimlik nvarchar(11),
@Maas int,
@Durum bit
as
begin
insert into Personeller(KullaniciAdi,Sifre,YetkiId,Ad,Soyad,TCKimlik,Maas,Durum)
values(@KullaniciAdi,@Sifre,@YetkiId,@Ad,@Soyad,@TCKimlik,@Maas,1)
insert into Kisiler(KullaniciAdi,Sifre,YetkiId,Ad,Soyad)
values(@KullaniciAdi,@Sifre,@YetkiId,@Ad,@Soyad)
end
GO
/****** Object:  StoredProcedure [dbo].[PersonelSil]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[PersonelSil]
@TCKimlik nvarchar(11)
as
begin
delete from Personeller where @TCKimlik=TCKimlik
end
GO
/****** Object:  StoredProcedure [dbo].[SalonEkle]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SalonEkle]
@MekanAdi nvarchar(200),
@SalonAdi nvarchar(200),
@KoltukSirasi int,
@SiradakiKoltukSayisi int,
@ToplamKoltukSayisi int,
@SalonKirasi int,
@Durum bit
as
begin
insert into Salonlar(MekanAdi,SalonAdi,KoltukSirasi,SiradakiKoltukSayisi,ToplamKoltukSayisi,SalonKirasi,Durum)
values(@MekanAdi,@SalonAdi,@KoltukSirasi,@SiradakiKoltukSayisi,@KoltukSirasi*@SiradakiKoltukSayisi,@SalonKirasi,1)
end
GO
/****** Object:  StoredProcedure [dbo].[UyeEkle]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[UyeEkle]
@KullaniciAdi nvarchar(200),
@Sifre nvarchar(5),
@YetkiId int,
@Ad nvarchar(200),
@Soyad nvarchar(200),
@Mail nvarchar(200),
@Durum bit
as
begin
insert into Uyeler(KullaniciAdi,Sifre,YetkiId,Ad,Soyad,Mail,Durum)
values (@KullaniciAdi,@Sifre,5,@Ad,@Soyad,@Mail,1)
insert into Kisiler(KullaniciAdi,Sifre,YetkiId,Ad,Soyad)
values(@KullaniciAdi,@Sifre,@YetkiId,@Ad,@Soyad)
end
GO
/****** Object:  StoredProcedure [dbo].[UyeSil]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[UyeSil]
@KullaniciAdi nvarchar(200)
as
begin
delete from Uyeler where @KullaniciAdi=KullaniciAdi
end
GO
/****** Object:  StoredProcedure [dbo].[YetkiEkle]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[YetkiEkle]
@YetkiAd nvarchar(200)
as
begin
insert into Yetkiler(YetkiAd)
values(@YetkiAd)
end
GO
/****** Object:  Trigger [dbo].[BiletIadeUcret]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[BiletIadeUcret]
on [dbo].[BiletIade]
after insert
as
declare @ToplamBakiye int
declare @BiletAdet int
declare @BiletFiyat int
declare @EtkinlikId int
declare @ToplamBiletFiyat int
declare @SatinAlanAd nvarchar(200)
declare @SatinAlanSoyad nvarchar(200)
declare @EtkinliklerId int
declare @EtkinlikAdi nvarchar(1000)
declare @MekanAdi nvarchar(200)
declare @SalonAdi nvarchar(200)
declare @BiletSayisi int
select @MekanAdi=Mekan, @SalonAdi=Salon, @EtkinlikAdi=Ad, @EtkinliklerId=Id from Etkinlikler
select @ToplamBiletFiyat=ToplamBiletFiyat, @BiletAdet=BiletAdet, @BiletFiyat=BiletFiyat, @EtkinlikId=EtkinlikId from inserted
select top 1 @ToplamBakiye=ToplamBakiye FROM Muhasebe order by Id desc

update BiletSatis set BiletAdet+=@BiletAdet,ToplamBiletFiyat-=@BiletFiyat where @EtkinlikId=EtkinlikId and @SatinAlanAd=SatinAlanAd and @SatinAlanSoyad=SatinAlanSoyad
update Etkinlikler set BiletSayisi+=@BiletAdet where @EtkinlikId=Id
if @ToplamBakiye Is Null
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Fatura','Bilet İade',0,@ToplamBiletFiyat,-@ToplamBiletFiyat,0-@ToplamBiletFiyat)
end
else if @ToplamBakiye Is Not Null
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Fatura','Bilet İade',0,@ToplamBiletFiyat,-@ToplamBiletFiyat,@ToplamBakiye-@ToplamBiletFiyat)
end
GO
ALTER TABLE [dbo].[BiletIade] ENABLE TRIGGER [BiletIadeUcret]
GO
/****** Object:  Trigger [dbo].[BiletSatisUcret]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[BiletSatisUcret]
on [dbo].[BiletSatis]
after insert
as
declare @ToplamBakiye int
declare @BiletAdet int
declare @BiletFiyat int
declare @EtkinlikId int
declare @ToplamBiletFiyat int
declare @SatinAlanAd nvarchar(200)
declare @SatinAlanSoyad nvarchar(200)
declare @EtkinliklerId int
declare @EtkinlikAdi nvarchar(1000)
declare @MekanAdi nvarchar(200)
declare @SalonAdi nvarchar(200)
declare @BiletSayisi int
select @ToplamBiletFiyat=ToplamBiletFiyat, @BiletAdet=BiletAdet, @BiletFiyat=BiletFiyat, @EtkinlikId=EtkinlikId from inserted
select top 1 @ToplamBakiye=ToplamBakiye FROM Muhasebe order by Id desc

update Etkinlikler set BiletSayisi-=@BiletAdet where @EtkinlikId=Id
if @ToplamBakiye Is Null
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Fatura','Bilet Satis',@ToplamBiletFiyat,0,+@ToplamBiletFiyat,0+@ToplamBiletFiyat)
end
else if @ToplamBakiye Is Not Null
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Fatura','Bilet Satis',@ToplamBiletFiyat,0,+@ToplamBiletFiyat,@ToplamBakiye+@ToplamBiletFiyat)
end
GO
ALTER TABLE [dbo].[BiletSatis] ENABLE TRIGGER [BiletSatisUcret]
GO
/****** Object:  Trigger [dbo].[EtkinlikGider]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[EtkinlikGider]
on [dbo].[Etkinlikler]
after insert
as
declare @ToplamBakiye int
declare @HesapBakiyesi int
declare @EtkinlikMaliyeti int
declare @SalonKirasi int
declare @SalonAdi nvarchar(200)
declare @MekanAdi nvarchar(200)
declare @Salon nvarchar(200)
declare @Mekan nvarchar(200)
declare @EtkinlikAdi nvarchar(1000)
select @EtkinlikMaliyeti=EtkinlikMaliyeti,@SalonAdi=Salon, @MekanAdi=Mekan from inserted
select @SalonKirasi=SalonKirasi from Salonlar where SalonAdi=@SalonAdi and MekanAdi=@MekanAdi
select top 1 @ToplamBakiye=ToplamBakiye FROM Muhasebe order by Id desc

if @ToplamBakiye Is Null
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Hizmet','Etkinlik Maliyeti',0,@EtkinlikMaliyeti,-@EtkinlikMaliyeti,0-@EtkinlikMaliyeti)
end
else if @ToplamBakiye Is Not Null
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Hizmet','Etkinlik Maliyeti',0,@EtkinlikMaliyeti,-@EtkinlikMaliyeti,@ToplamBakiye-@EtkinlikMaliyeti)
set @ToplamBakiye-=@EtkinlikMaliyeti
end
if @ToplamBakiye Is Null
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Kira','Salon Kirası',0,@SalonKirasi,-@SalonKirasi,0-@SalonKirasi)
end
else if @ToplamBakiye Is Not Null
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Kira','Salon Kirası',0,@SalonKirasi,-@SalonKirasi,@ToplamBakiye-@SalonKirasi)
end

GO
ALTER TABLE [dbo].[Etkinlikler] ENABLE TRIGGER [EtkinlikGider]
GO
/****** Object:  Trigger [dbo].[PersonelMaas]    Script Date: 11.04.2022 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[PersonelMaas]
on [dbo].[Personeller]
after insert
as
declare @Maas int
declare @ToplamBakiye int
select @Maas=Maas from inserted
select top 1 @ToplamBakiye=ToplamBakiye FROM Muhasebe order by Id desc
if @ToplamBakiye Is Null
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Hizmet','Personel Maaş',0,@Maas,-@Maas,0-@Maas)
else if @ToplamBakiye Is Not Null
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Hizmet','Personel Maaş',0,@Maas,-@Maas,@ToplamBakiye-@Maas)
GO
ALTER TABLE [dbo].[Personeller] ENABLE TRIGGER [PersonelMaas]
GO
USE [master]
GO
ALTER DATABASE [Bilet] SET  READ_WRITE 
GO

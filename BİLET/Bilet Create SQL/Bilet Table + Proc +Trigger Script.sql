USE [master]
GO
/****** Object:  Database [Bilet]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[BiletIade]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[BiletSatis]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[Etkinlikler]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[EtkinlikTuru]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[Kisiler]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[Mekanlar]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[Muhasebe]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[MuhasebeTuru]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[Personeller]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[Salonlar]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[Uyeler]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Table [dbo].[Yetkiler]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[BiletIadeSP]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[BiletSatisSP]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[EtkinlikEkle]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[EtkinlikTuruEkle]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[GelirEkle]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[GiderEkle]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[MekanEkle]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[MekanSil]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[MuhasebeTuruEkle]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[PersonelEkle]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[PersonelSil]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[SalonEkle]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[UyeEkle]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[UyeSil]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  StoredProcedure [dbo].[YetkiEkle]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Trigger [dbo].[BiletIadeUcret]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Trigger [dbo].[BiletSatisUcret]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Trigger [dbo].[EtkinlikGider]    Script Date: 9.04.2022 23:04:47 ******/
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
/****** Object:  Trigger [dbo].[PersonelMaas]    Script Date: 9.04.2022 23:04:47 ******/
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

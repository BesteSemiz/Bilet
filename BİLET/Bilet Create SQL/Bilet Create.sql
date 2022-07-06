Create Database Bilet

Create Table Yetkiler(
Id int Primary Key Identity(1,1) not null,
YetkiAd nvarchar(200)
);

Create Table Kisiler(
Id int Primary Key Identity(1,1) not null,
KullaniciAdi nvarchar(200),
Sifre int,
YetkiId int,
Ad nvarchar(200),
Soyad nvarchar(200)
);

Create Table Personeller(
Id int Primary Key Identity(1,1) not null,
KullaniciAdi nvarchar(200),
Sifre nvarchar(5),
YetkiId int,
Ad nvarchar(200),
Soyad nvarchar(200),
TCKimlik nvarchar(11),
Maas int,
Durum bit
);

Create Table Uyeler(
Id int Primary Key Identity(1,1) not null,
KullaniciAdi nvarchar(200),
Sifre int,
YetkiId int,
Ad nvarchar(200),
Soyad nvarchar(200),
Mail nvarchar(200),
Durum bit
);
-----------------------------------------------------------------------------
Create Table Mekanlar (
Id int Primary Key Identity(1,1) not null,
MekanIl nvarchar(200),
MekanIlce nvarchar(200),
MekanAdi nvarchar(200),
Durum bit
);

Create Table Salonlar(
Id int Primary Key Identity(1,1) not null,
MekanAdi nvarchar(200),
SalonAdi nvarchar(200),
KoltukSirasi int,
SiradakiKoltukSayisi int,
ToplamKoltukSayisi int,
SalonKirasi int,
Durum bit
);

Create Table EtkinlikTuru(
Id int Primary Key Identity(1,1) not null,
TurAdi nvarchar(200)
);

Create Table Etkinlikler(
Id int Primary Key Identity(1,1) not null,
EtkinlikTurId int,
Ad nvarchar(1000),
Mekan nvarchar(200),
Salon nvarchar(200),
Tarih nvarchar(200),
Saat nvarchar(200),
BiletSayisi int,
BiletFiyat int,
BiletAcilis nvarchar(200),
BiletBitis nvarchar(200),
EtkinlikMaliyeti int,
Durum bit
);

Create Table BiletSatis(
Id int Primary Key Identity(1,1) not null,
EtkinlikId int,
SatinAlanAd nvarchar(200),
SatinAlanSoyad nvarchar(200),
AlinanKoltuklar nvarchar(1000),
BiletAdet int,
BiletFiyat int,
ToplamBiletFiyat int
);

Create Table BiletIade(
Id int Primary Key Identity(1,1) not null,
EtkinlikId int,
SatinAlanAd nvarchar(200),
SatinAlanSoyad nvarchar(200),
AlinanKoltuklar nvarchar(1000),
BiletAdet int,
BiletFiyat int,
ToplamBiletFiyat int
);
-------------------------------------------------
Create Table MuhasebeTuru(
Id int Primary Key Identity(1,1) not null,
MuhasebeTuru nvarchar(200)
);

Create Table Muhasebe(
Id int Primary Key Identity(1,1) not null,
Tarih date,
Turu nvarchar(200),
Aciklama nvarchar(1000),
Gelir int,
Gider int,
HesapBakiyesi int,
ToplamBakiye int
);

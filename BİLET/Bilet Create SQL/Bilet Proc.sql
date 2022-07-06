use Bilet
go

Create Proc YetkiEkle
@YetkiAd nvarchar(200)
as
begin
insert into Yetkiler(YetkiAd)
values(@YetkiAd)
end

Create Proc PersonelEkle
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

Create Proc PersonelSil
@TCKimlik nvarchar(11)
as
begin
delete from Personeller where @TCKimlik=TCKimlik
end

Create Proc UyeEkle
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

Create Proc UyeSil
@KullaniciAdi nvarchar(200)
as
begin
delete from Uyeler where @KullaniciAdi=KullaniciAdi
end
-----------------------------------------------------------------------------------------------------

Create Proc MekanEkle
@MekanIl nvarchar(200),
@MekanIlce nvarchar(200),
@MekanAdi nvarchar(200),
@Durum bit
as
begin
insert into Mekanlar(MekanIl,MekanIlce,MekanAdi,Durum)
values(@MekanIl,@MekanIlce,@MekanAdi,1)
end

Create Proc MekanSil
@MekanAdi nvarchar(200)
as
begin
delete from Mekanlar where @MekanAdi=MekanAdi
delete from Salonlar where @MekanAdi=MekanAdi
end

Create Proc SalonEkle
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

Create Proc EtkinlikTuruEkle
@TurAdi nvarchar(200)
as
begin
insert into EtkinlikTuru(TurAdi)
values(@TurAdi)
end

Create Proc EtkinlikEkle
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

Create Proc BiletSatisSP
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

Create Proc BiletIadeSP
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

Create Proc MuhasebeTuruEkle
@MuhasebeTuru nvarchar(200)
as
begin
insert into MuhasebeTuru(MuhasebeTuru)
values(@MuhasebeTuru)
end

Create Proc GelirEkle
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

Create Proc GiderEkle
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
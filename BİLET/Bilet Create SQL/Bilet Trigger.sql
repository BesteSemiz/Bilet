Create Trigger PersonelMaas
on Personeller
after insert
as
declare @Maas int
declare @ToplamBakiye int
select @Maas=Maas from inserted
select top 1 @ToplamBakiye=ToplamBakiye FROM Muhasebe order by Id desc
if @ToplamBakiye Is Null
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Hizmet','Personel Maaþ',0,@Maas,-@Maas,0-@Maas)
else if @ToplamBakiye Is Not Null
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Hizmet','Personel Maaþ',0,@Maas,-@Maas,@ToplamBakiye-@Maas)

----------------------------------------------------------------------------
Create Trigger BiletIadeUcret
on BiletIade
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
values(GETDATE(),'Fatura','Bilet Ýade',0,@ToplamBiletFiyat,-@ToplamBiletFiyat,0-@ToplamBiletFiyat)
end
else if @ToplamBakiye Is Not Null
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Fatura','Bilet Ýade',0,@ToplamBiletFiyat,-@ToplamBiletFiyat,@ToplamBakiye-@ToplamBiletFiyat)
end

Create Trigger BiletSatisUcret
on BiletSatis
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
--------------------------------------------------------------------------------------------------------------------------------
Create Trigger EtkinlikGider
on Etkinlikler
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
values(GETDATE(),'Kira','Salon Kirasý',0,@SalonKirasi,-@SalonKirasi,0-@SalonKirasi)
end
else if @ToplamBakiye Is Not Null
begin
insert into Muhasebe(Tarih,Turu,Aciklama,Gelir,Gider,HesapBakiyesi,ToplamBakiye)
values(GETDATE(),'Kira','Salon Kirasý',0,@SalonKirasi,-@SalonKirasi,@ToplamBakiye-@SalonKirasi)
end


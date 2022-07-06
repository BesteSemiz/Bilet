use Bilet
go
------------------------------
exec YetkiEkle 'Mudur'
exec YetkiEkle 'Organizasyon Muduru'
exec YetkiEkle 'Bilet Satis Yetkilisi'
exec YetkiEkle 'Hizmetli'
exec YetkiEkle 'Uye'
------------------------------
exec PersonelEkle 'EKaya','12345',1,'Erhan','Kaya','11122233344',10000,1
exec PersonelEkle 'BSemiz','54321',2,'Beste','Semiz','11122233355',9000,1
exec PersonelEkle 'ASekerci','56789',3,'Ahmet','Þekerci','11122233366',7500,1
exec PersonelEkle 'GHasbal','98765',4,'Gökhan','Hasbal','11122233377',6000,1
------------------------------
exec UyeEkle 'Helesa','12345',5,'Ayse','Semiz','as@gmail.com',1
------------------------------
exec MekanEkle 'Ýstanbul','Bahçelievler','ÝBB Yenibosna Dr. Enver Ören Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Bakýrköy','ÝBB Cem Karaca Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Baþakþehir','ÝBB Baþakþehir Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Beyoðlu','ÝBB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)',1
exec MekanEkle 'Ýstanbul','Beyoðlu','Taksim Sanat',1
exec MekanEkle 'Ýstanbul','Esenler','ÝBB Prof. Dr. Adem Baþtürk Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Fatih','ÝBB Ali Emiri Efendi Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Güngören','ÝBB Erdem Bayazýt Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Kartal','ÝBB Bülent Ecevit Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Ümraniye','ÝBB Þehit Kaymakam M. Fatih Safitürk Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Sancaktepe','ÝBB Sancaktepe Eyüp Sultan Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Sultanbeyli','ÝBB Prof. Dr. Necmettin Erbakan Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Þile','ÝBB Þile Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Þiþli','Cemal Reþit Rey Konser Salonu (CRR)',1
exec MekanEkle 'Ýstanbul','Tuzla','ÝBB Ýdris Güllüce Kültür Merkezi',1
exec MekanEkle 'Ýstanbul','Kadýköy','Þükrü Saraçoðlu Stadý',1
------------------------------
exec SalonEkle 'Þükrü Saraçoðlu Stadý','A Salonu',10,30,300,15000,1;
exec SalonEkle 'Þükrü Saraçoðlu Stadý','B Salonu',10,20,200,12000,1;
exec SalonEkle 'Þükrü Saraçoðlu Stadý','C Salonu',10,10,100,10000,1;

exec SalonEkle 'ÝBB Yenibosna Dr. Enver Ören Kültür Merkezi','A Salonu',5,10,50,5000,1;
exec SalonEkle 'ÝBB Yenibosna Dr. Enver Ören Kültür Merkezi','B Salonu',8,10,80,6500,1;
exec SalonEkle 'ÝBB Yenibosna Dr. Enver Ören Kültür Merkezi','C Salonu',6,20,120,7500,1;

exec SalonEkle 'ÝBB Cem Karaca Kültür Merkezi','A Salonu',3,10,30,3000,1;
exec SalonEkle 'ÝBB Cem Karaca Kültür Merkezi','B Salonu',4,30,120,7500,1;
exec SalonEkle 'ÝBB Cem Karaca Kültür Merkezi','C Salonu',10,20,200,8000,1;

exec SalonEkle 'ÝBB Baþakþehir Kültür Merkezi','A Salonu',5,10,50,5000,1;
exec SalonEkle 'ÝBB Baþakþehir Kültür Merkezi','B Salonu',8,10,80,6500,1;
exec SalonEkle 'ÝBB Baþakþehir Kültür Merkezi','C Salonu',6,30,180,7750,1;

exec SalonEkle 'ÝBB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)','A Salonu',5,70,350,10000,1;
exec SalonEkle 'ÝBB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)','B Salonu',8,20,160,8000,1;
exec SalonEkle 'ÝBB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)','C Salonu',5,20,100,6000,1;

exec SalonEkle 'Taksim Sanat','A Salonu',5,10,50,5000,1;
exec SalonEkle 'Taksim Sanat','B Salonu',8,30,160,8000,1;
exec SalonEkle 'Taksim Sanat','C Salonu',6,40,240,8500,1;

exec SalonEkle 'ÝBB Prof. Dr. Adem Baþtürk Kültür Merkezi','A Salonu',7,30,210,8250,1;
exec SalonEkle 'ÝBB Prof. Dr. Adem Baþtürk Kültür Merkezi','B Salonu',5,80,400,20000,1;
exec SalonEkle 'ÝBB Prof. Dr. Adem Baþtürk Kültür Merkezi','C Salonu',3,80,240,8500,1;

exec SalonEkle 'ÝBB Ali Emiri Efendi Kültür Merkezi','A Salonu',8,10,80,6500,1;
exec SalonEkle 'ÝBB Ali Emiri Efendi Kültür Merkezi','B Salonu',5,20,100,6000,1;
exec SalonEkle 'ÝBB Ali Emiri Efendi Kültür Merkezi','C Salonu',6,20,120,7500,1;

exec SalonEkle 'ÝBB Erdem Bayazýt Kültür Merkezi','A Salonu',6,20,120,7500,1;
exec SalonEkle 'ÝBB Erdem Bayazýt Kültür Merkezi','B Salonu',5,70,350,10000,1;
exec SalonEkle 'ÝBB Erdem Bayazýt Kültür Merkezi','C Salonu',8,10,80,6500,1;

exec SalonEkle 'ÝBB Bülent Ecevit Kültür Merkezi','A Salonu',5,20,100,6000,1;
exec SalonEkle 'ÝBB Bülent Ecevit Kültür Merkezi','B Salonu',5,70,350,10000,1;
exec SalonEkle 'ÝBB Bülent Ecevit Kültür Merkezi','C Salonu',8,10,80,6500,1;

exec SalonEkle 'ÝBB Þehit Kaymakam M. Fatih Safitürk Kültür Merkezi','A Salonu',8,10,80,6500,1;
exec SalonEkle 'ÝBB Þehit Kaymakam M. Fatih Safitürk Kültür Merkezi','B Salonu',5,10,50,5000,1;
exec SalonEkle 'ÝBB Þehit Kaymakam M. Fatih Safitürk Kültür Merkezi','C Salonu',6,20,120,7500,1;

exec SalonEkle 'ÝBB Sancaktepe Eyüp Sultan Kültür Merkezi','A Salonu',6,20,120,7500,1;
exec SalonEkle 'ÝBB Sancaktepe Eyüp Sultan Kültür Merkezi','B Salonu',5,70,350,10000,1;
exec SalonEkle 'ÝBB Sancaktepe Eyüp Sultan Kültür Merkezi','C Salonu',5,20,100,6000,1;

exec SalonEkle 'ÝBB Prof. Dr. Necmettin Erbakan Kültür Merkezi','A Salonu',5,10,50,5000,1;
exec SalonEkle 'ÝBB Prof. Dr. Necmettin Erbakan Kültür Merkezi','B Salonu',5,20,100,6000,1;
exec SalonEkle 'ÝBB Prof. Dr. Necmettin Erbakan Kültür Merkezi','C Salonu',4,30,120,7500,1;

exec SalonEkle 'ÝBB Þile Kültür Merkezi','A Salonu',8,10,80,6500,1;
exec SalonEkle 'ÝBB Þile Kültür Merkezi','B Salonu',6,20,120,7500,1;
exec SalonEkle 'ÝBB Þile Kültür Merkezi','C Salonu',4,30,120,7500,1;

exec SalonEkle 'Cemal Reþit Rey Konser Salonu (CRR)','A Salonu',5,10,50,5000,1;
exec SalonEkle 'Cemal Reþit Rey Konser Salonu (CRR)','B Salonu',8,10,80,6500,1;
exec SalonEkle 'Cemal Reþit Rey Konser Salonu (CRR)','C Salonu',5,70,350,10000,1;

exec SalonEkle 'ÝBB Ýdris Güllüce Kültür Merkezi','A Salonu',8,10,80,6500,1;
exec SalonEkle 'ÝBB Ýdris Güllüce Kültür Merkezi','B Salonu',5,70,350,10000,1;
exec SalonEkle 'ÝBB Ýdris Güllüce Kültür Merkezi','C Salonu',5,70,350,10000,1;
------------------------------
exec EtkinlikTuruEkle 'Pop'
exec EtkinlikTuruEkle 'Rock'
exec EtkinlikTuruEkle 'Caz'
exec EtkinlikTuruEkle 'Klasik'
exec EtkinlikTuruEkle 'Tiyatro'
exec EtkinlikTuruEkle 'Stand Up'
exec EtkinlikTuruEkle 'Söyleþi'
exec EtkinlikTuruEkle 'Futbol'
exec EtkinlikTuruEkle 'Voleybol'
exec EtkinlikTuruEkle 'Basketbol'
------------------------------
exec EtkinlikEkle 1,'Ýkiye On Kala','ÝBB Cem Karaca Kültür Merkezi','B Salonu','16.4.2022','20:00',120,60,'30.3.2022','15.4.2022',9000,1
exec EtkinlikEkle 2,'Vektor . Special Guest: Cryptosis','ÝBB Bülent Ecevit Kültür Merkezi','C Salonu','13.8.2022','20:30',80,100,'15.4.2022','10.8.2022',8000,1
exec EtkinlikEkle 3,'Ýstanbul Oda Orkestrasý','Cemal Reþit Rey Konser Salonu (CRR)','A Salonu','10.4.2022','20:00',50,50,'29.3.2022','9.4.2022',7000,1
exec EtkinlikEkle 4,'Venezuela Simon Bolivar Senfoni Orkestrasý','ÝBB Ýdris Güllüce Kültür Merkezi','C Salonu','10.4.2022','20:00',350,60,'29.3.2022','9.4.2022',12000,1
exec EtkinlikEkle 5,'1984 . Büyük Gözaltý','ÝBB Þehit Kaymakam M. Fatih Safitürk Kültür Merkezi','C Salonu','24.5.2022','19:00',120,80,'10.4.2022','20.5.2022',9000,1
exec EtkinlikEkle 6,'Uykusuzlar Kulübü','ÝBB Erdem Bayazýt Kültür Merkezi','B Salonu','1.6.2022','22:00',350,120,'1.4.2022','30.5.2022',15000,1
exec EtkinlikEkle 7,'Ýlber Ortaylý Ýle Gündem Ötesi','ÝBB Ali Emiri Efendi Kültür Merkezi','C Salonu','16.5.2022','16:00',120,120,'10.4.2022','15.5.2022',10000,1
exec EtkinlikEkle 8, 'Fenerbahçe.Galatasaray','Þükrü Saraçoðlu Stadý','A Salonu','6.6.2022','20:00',300,150,'4.4.2022','5.6.2022',17000,1
exec EtkinlikEkle 9, 'Fenerbahçe.Vakýfbank','Þükrü Saraçoðlu Stadý','B Salonu','12.5.2022','16:00',200,150,'6.4.2022','11.5.2022',16000,1
exec EtkinlikEkle 10, 'Fenerbahçe.FinansBank','Þükrü Saraçoðlu Stadý','C Salonu','3.7.2022','19:30',100,120,'5.4.2022','2.7.2022',15000,1
------------------------------
exec MuhasebeTuruEkle 'Hizmet'
exec MuhasebeTuruEkle 'Fatura'
exec MuhasebeTuruEkle 'Baðýþ'
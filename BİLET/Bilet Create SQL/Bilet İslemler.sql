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
exec PersonelEkle 'ASekerci','56789',3,'Ahmet','�ekerci','11122233366',7500,1
exec PersonelEkle 'GHasbal','98765',4,'G�khan','Hasbal','11122233377',6000,1
------------------------------
exec UyeEkle 'Helesa','12345',5,'Ayse','Semiz','as@gmail.com',1
------------------------------
exec MekanEkle '�stanbul','Bah�elievler','�BB Yenibosna Dr. Enver �ren K�lt�r Merkezi',1
exec MekanEkle '�stanbul','Bak�rk�y','�BB Cem Karaca K�lt�r Merkezi',1
exec MekanEkle '�stanbul','Ba�ak�ehir','�BB Ba�ak�ehir K�lt�r Merkezi',1
exec MekanEkle '�stanbul','Beyo�lu','�BB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)',1
exec MekanEkle '�stanbul','Beyo�lu','Taksim Sanat',1
exec MekanEkle '�stanbul','Esenler','�BB Prof. Dr. Adem Ba�t�rk K�lt�r Merkezi',1
exec MekanEkle '�stanbul','Fatih','�BB Ali Emiri Efendi K�lt�r Merkezi',1
exec MekanEkle '�stanbul','G�ng�ren','�BB Erdem Bayaz�t K�lt�r Merkezi',1
exec MekanEkle '�stanbul','Kartal','�BB B�lent Ecevit K�lt�r Merkezi',1
exec MekanEkle '�stanbul','�mraniye','�BB �ehit Kaymakam M. Fatih Safit�rk K�lt�r Merkezi',1
exec MekanEkle '�stanbul','Sancaktepe','�BB Sancaktepe Ey�p Sultan K�lt�r Merkezi',1
exec MekanEkle '�stanbul','Sultanbeyli','�BB Prof. Dr. Necmettin Erbakan K�lt�r Merkezi',1
exec MekanEkle '�stanbul','�ile','�BB �ile K�lt�r Merkezi',1
exec MekanEkle '�stanbul','�i�li','Cemal Re�it Rey Konser Salonu (CRR)',1
exec MekanEkle '�stanbul','Tuzla','�BB �dris G�ll�ce K�lt�r Merkezi',1
exec MekanEkle '�stanbul','Kad�k�y','��kr� Sara�o�lu Stad�',1
------------------------------
exec SalonEkle '��kr� Sara�o�lu Stad�','A Salonu',10,30,300,15000,1;
exec SalonEkle '��kr� Sara�o�lu Stad�','B Salonu',10,20,200,12000,1;
exec SalonEkle '��kr� Sara�o�lu Stad�','C Salonu',10,10,100,10000,1;

exec SalonEkle '�BB Yenibosna Dr. Enver �ren K�lt�r Merkezi','A Salonu',5,10,50,5000,1;
exec SalonEkle '�BB Yenibosna Dr. Enver �ren K�lt�r Merkezi','B Salonu',8,10,80,6500,1;
exec SalonEkle '�BB Yenibosna Dr. Enver �ren K�lt�r Merkezi','C Salonu',6,20,120,7500,1;

exec SalonEkle '�BB Cem Karaca K�lt�r Merkezi','A Salonu',3,10,30,3000,1;
exec SalonEkle '�BB Cem Karaca K�lt�r Merkezi','B Salonu',4,30,120,7500,1;
exec SalonEkle '�BB Cem Karaca K�lt�r Merkezi','C Salonu',10,20,200,8000,1;

exec SalonEkle '�BB Ba�ak�ehir K�lt�r Merkezi','A Salonu',5,10,50,5000,1;
exec SalonEkle '�BB Ba�ak�ehir K�lt�r Merkezi','B Salonu',8,10,80,6500,1;
exec SalonEkle '�BB Ba�ak�ehir K�lt�r Merkezi','C Salonu',6,30,180,7750,1;

exec SalonEkle '�BB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)','A Salonu',5,70,350,10000,1;
exec SalonEkle '�BB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)','B Salonu',8,20,160,8000,1;
exec SalonEkle '�BB Taksim Cumhuriyet Sanat Galerisi (MAKSEM)','C Salonu',5,20,100,6000,1;

exec SalonEkle 'Taksim Sanat','A Salonu',5,10,50,5000,1;
exec SalonEkle 'Taksim Sanat','B Salonu',8,30,160,8000,1;
exec SalonEkle 'Taksim Sanat','C Salonu',6,40,240,8500,1;

exec SalonEkle '�BB Prof. Dr. Adem Ba�t�rk K�lt�r Merkezi','A Salonu',7,30,210,8250,1;
exec SalonEkle '�BB Prof. Dr. Adem Ba�t�rk K�lt�r Merkezi','B Salonu',5,80,400,20000,1;
exec SalonEkle '�BB Prof. Dr. Adem Ba�t�rk K�lt�r Merkezi','C Salonu',3,80,240,8500,1;

exec SalonEkle '�BB Ali Emiri Efendi K�lt�r Merkezi','A Salonu',8,10,80,6500,1;
exec SalonEkle '�BB Ali Emiri Efendi K�lt�r Merkezi','B Salonu',5,20,100,6000,1;
exec SalonEkle '�BB Ali Emiri Efendi K�lt�r Merkezi','C Salonu',6,20,120,7500,1;

exec SalonEkle '�BB Erdem Bayaz�t K�lt�r Merkezi','A Salonu',6,20,120,7500,1;
exec SalonEkle '�BB Erdem Bayaz�t K�lt�r Merkezi','B Salonu',5,70,350,10000,1;
exec SalonEkle '�BB Erdem Bayaz�t K�lt�r Merkezi','C Salonu',8,10,80,6500,1;

exec SalonEkle '�BB B�lent Ecevit K�lt�r Merkezi','A Salonu',5,20,100,6000,1;
exec SalonEkle '�BB B�lent Ecevit K�lt�r Merkezi','B Salonu',5,70,350,10000,1;
exec SalonEkle '�BB B�lent Ecevit K�lt�r Merkezi','C Salonu',8,10,80,6500,1;

exec SalonEkle '�BB �ehit Kaymakam M. Fatih Safit�rk K�lt�r Merkezi','A Salonu',8,10,80,6500,1;
exec SalonEkle '�BB �ehit Kaymakam M. Fatih Safit�rk K�lt�r Merkezi','B Salonu',5,10,50,5000,1;
exec SalonEkle '�BB �ehit Kaymakam M. Fatih Safit�rk K�lt�r Merkezi','C Salonu',6,20,120,7500,1;

exec SalonEkle '�BB Sancaktepe Ey�p Sultan K�lt�r Merkezi','A Salonu',6,20,120,7500,1;
exec SalonEkle '�BB Sancaktepe Ey�p Sultan K�lt�r Merkezi','B Salonu',5,70,350,10000,1;
exec SalonEkle '�BB Sancaktepe Ey�p Sultan K�lt�r Merkezi','C Salonu',5,20,100,6000,1;

exec SalonEkle '�BB Prof. Dr. Necmettin Erbakan K�lt�r Merkezi','A Salonu',5,10,50,5000,1;
exec SalonEkle '�BB Prof. Dr. Necmettin Erbakan K�lt�r Merkezi','B Salonu',5,20,100,6000,1;
exec SalonEkle '�BB Prof. Dr. Necmettin Erbakan K�lt�r Merkezi','C Salonu',4,30,120,7500,1;

exec SalonEkle '�BB �ile K�lt�r Merkezi','A Salonu',8,10,80,6500,1;
exec SalonEkle '�BB �ile K�lt�r Merkezi','B Salonu',6,20,120,7500,1;
exec SalonEkle '�BB �ile K�lt�r Merkezi','C Salonu',4,30,120,7500,1;

exec SalonEkle 'Cemal Re�it Rey Konser Salonu (CRR)','A Salonu',5,10,50,5000,1;
exec SalonEkle 'Cemal Re�it Rey Konser Salonu (CRR)','B Salonu',8,10,80,6500,1;
exec SalonEkle 'Cemal Re�it Rey Konser Salonu (CRR)','C Salonu',5,70,350,10000,1;

exec SalonEkle '�BB �dris G�ll�ce K�lt�r Merkezi','A Salonu',8,10,80,6500,1;
exec SalonEkle '�BB �dris G�ll�ce K�lt�r Merkezi','B Salonu',5,70,350,10000,1;
exec SalonEkle '�BB �dris G�ll�ce K�lt�r Merkezi','C Salonu',5,70,350,10000,1;
------------------------------
exec EtkinlikTuruEkle 'Pop'
exec EtkinlikTuruEkle 'Rock'
exec EtkinlikTuruEkle 'Caz'
exec EtkinlikTuruEkle 'Klasik'
exec EtkinlikTuruEkle 'Tiyatro'
exec EtkinlikTuruEkle 'Stand Up'
exec EtkinlikTuruEkle 'S�yle�i'
exec EtkinlikTuruEkle 'Futbol'
exec EtkinlikTuruEkle 'Voleybol'
exec EtkinlikTuruEkle 'Basketbol'
------------------------------
exec EtkinlikEkle 1,'�kiye On Kala','�BB Cem Karaca K�lt�r Merkezi','B Salonu','16.4.2022','20:00',120,60,'30.3.2022','15.4.2022',9000,1
exec EtkinlikEkle 2,'Vektor . Special Guest: Cryptosis','�BB B�lent Ecevit K�lt�r Merkezi','C Salonu','13.8.2022','20:30',80,100,'15.4.2022','10.8.2022',8000,1
exec EtkinlikEkle 3,'�stanbul Oda Orkestras�','Cemal Re�it Rey Konser Salonu (CRR)','A Salonu','10.4.2022','20:00',50,50,'29.3.2022','9.4.2022',7000,1
exec EtkinlikEkle 4,'Venezuela Simon Bolivar Senfoni Orkestras�','�BB �dris G�ll�ce K�lt�r Merkezi','C Salonu','10.4.2022','20:00',350,60,'29.3.2022','9.4.2022',12000,1
exec EtkinlikEkle 5,'1984 . B�y�k G�zalt�','�BB �ehit Kaymakam M. Fatih Safit�rk K�lt�r Merkezi','C Salonu','24.5.2022','19:00',120,80,'10.4.2022','20.5.2022',9000,1
exec EtkinlikEkle 6,'Uykusuzlar Kul�b�','�BB Erdem Bayaz�t K�lt�r Merkezi','B Salonu','1.6.2022','22:00',350,120,'1.4.2022','30.5.2022',15000,1
exec EtkinlikEkle 7,'�lber Ortayl� �le G�ndem �tesi','�BB Ali Emiri Efendi K�lt�r Merkezi','C Salonu','16.5.2022','16:00',120,120,'10.4.2022','15.5.2022',10000,1
exec EtkinlikEkle 8, 'Fenerbah�e.Galatasaray','��kr� Sara�o�lu Stad�','A Salonu','6.6.2022','20:00',300,150,'4.4.2022','5.6.2022',17000,1
exec EtkinlikEkle 9, 'Fenerbah�e.Vak�fbank','��kr� Sara�o�lu Stad�','B Salonu','12.5.2022','16:00',200,150,'6.4.2022','11.5.2022',16000,1
exec EtkinlikEkle 10, 'Fenerbah�e.FinansBank','��kr� Sara�o�lu Stad�','C Salonu','3.7.2022','19:30',100,120,'5.4.2022','2.7.2022',15000,1
------------------------------
exec MuhasebeTuruEkle 'Hizmet'
exec MuhasebeTuruEkle 'Fatura'
exec MuhasebeTuruEkle 'Ba���'
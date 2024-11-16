-- Adres tablosu 
CREATE TABLE Adres ( 
AdresID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
Il VARCHAR(50) NOT NULL, 
Ilce VARCHAR(50) NOT NULL, 
Mahalle VARCHAR(50) NOT NULL, 
Cadde VARCHAR(50) NOT NULL, 
Sokak VARCHAR(50) NOT NULL, 
BinaNo INT NOT NULL, 
KatNo INT NULL, 
DaireNo INT NULL 

); -- Tur tablosu 
CREATE TABLE Tur ( 
TurID INT  IDENTITY(1,1) NOT NULL PRIMARY KEY, 
Tur_ad VARCHAR(50) NOT NULL 

); -- Çiçekçiler tablosu 
CREATE TABLE Cicekci ( 
CicekciID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
Cicekci_ad VARCHAR(100) NOT NULL, 
AdresID INT NOT NULL FOREIGN KEY (AdresID) REFERENCES Adres(AdresID) 

); -- Cicek tablosu 
CREATE TABLE Cicek ( 
CicekID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
Cicek_ad VARCHAR(100) NOT NULL, 
Cicek_bilgi TEXT NULL, 
Cicek_renk VARCHAR(20) NULL, 
Cicek_fiyat DECIMAL(10,2) NOT NULL, 
--Cicek_resim VARCHAR(100) NULL 

); -- Buket tablosu 
CREATE TABLE Buket ( 
BuketID INT  IDENTITY(1,1) NOT NULL PRIMARY KEY, 
Buket_ad VARCHAR(100) NOT NULL, 
Buket_bilgi TEXT NULL, 
Buket_fiyat DECIMAL(10,2) NOT NULL, 
--Buket_resim VARCHAR(100) NULL, 
TurID INT NOT NULL FOREIGN KEY (TurID) REFERENCES Tur(TurID), 
CicekciID INT NOT NULL FOREIGN KEY (CicekciID) REFERENCES Cicekci(CicekciID) 

); -- Diðer Ürünler tablosu 
CREATE TABLE DigerUrunler ( 
DigerUrunlerID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
DigerUrunler_Ad VARCHAR(100) NOT NULL, 
DigerUrunler_bilgi TEXT NULL, 
DigerUrunler_fiyat DECIMAL(10, 2) NOT NULL, 
--DigerUrunler_resim VARCHAR(255) NULL, 
TurID INT UNIQUE(DigerUrunler_Ad) FOREIGN KEY (TurID) REFERENCES Tur(TurID) 

); -- Musteri tablosu 
CREATE TABLE Musteri ( 
MusteriID INT  IDENTITY(1,1) NOT NULL PRIMARY KEY, 
Musteri_ad VARCHAR(50) NOT NULL, 
Musteri_soyad VARCHAR(50) NOT NULL, 
Musteri_tel VARCHAR(11) NOT NULL, 
Alici_ad VARCHAR(50) NOT NULL, 
Alici_soyad VARCHAR(50) NOT NULL, 
Alici_tel VARCHAR(11) NOT NULL, 
AdresID INT NOT NULL FOREIGN KEY (AdresID) REFERENCES Adres(AdresID) 

); -- Hizmet tablosu 
CREATE TABLE Hizmet ( 
HizmetID INT  IDENTITY(1,1) NOT NULL PRIMARY KEY, 
Hizmet_ad VARCHAR(100) NOT NULL, 
Hizmet_uzunluk INT NOT NULL, 
Hizmet_fiyat DECIMAL(10,2) NOT NULL, 
--Hizmet_resim VARCHAR(100) NULL, 
TurID INT NOT NULL FOREIGN KEY (TurID) REFERENCES Tur(TurID), 
CicekciID INT NOT NULL FOREIGN KEY (CicekciID) REFERENCES Cicekci(CicekciID) 

); -- Randevu tablosu 
CREATE TABLE CicekciRandevu ( 
RandevuID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
MusteriID INT NOT NULL FOREIGN KEY (MusteriID) REFERENCES Musteri(MusteriID), 
CicekciID INT NOT NULL FOREIGN KEY (CicekciID) REFERENCES Cicekci(CicekciID), 
Randevu_tarihi DATETIME NOT NULL, 
HizmetID INT NOT NULL FOREIGN KEY (HizmetID) REFERENCES Hizmet(HizmetID), 
Randevu_notu TEXT NULL, 

); -- BuketOlusturma tablosu 
CREATE TABLE BuketOlusturma ( 
BuketOlusturmaID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
BuketID INT FOREIGN KEY (BuketID) REFERENCES Buket(BuketID), 
CicekID INT FOREIGN KEY (CicekID) REFERENCES Cicek(CicekID), 
Miktar INT, 
TurID INT FOREIGN KEY (TurID) REFERENCES Tur(TurID), 
CicekciID INT NOT NULL FOREIGN KEY (CicekciID) REFERENCES Cicekci(CicekciID) 

); -- Satýs tablosu 
CREATE TABLE Satis ( 
SatisID INT  IDENTITY(1,1) NOT NULL PRIMARY KEY, 
MusteriID INT NOT NULL FOREIGN KEY (MusteriID) REFERENCES Musteri(MusteriID), 
TurID INT NOT NULL FOREIGN KEY (TurID) REFERENCES Tur(TurID), 
UrunKimligi INT NOT NULL, 
Urun_fiyat DECIMAL(10,2) NOT NULL, 
Satis_tarihi DATE NOT NULL, 
Satis_notu TEXT NULL,
SatisGerceklestiMi BIT NOT NULL
);
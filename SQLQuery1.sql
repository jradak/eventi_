create database Eventi_pma
GO
USE Eventi_pma
create table Korisnici(
ID_Korisnik int identity(1,1) NOT NULL,
Ime nvarchar(50) NOT NULL,
Prezime nvarchar(50) NOT NULL,
KorisnickoIme nvarchar(50) NOT NULL,
Lozinka nvarchar(50) NOT NULL,
Email nvarchar(50) NOT NULL,
Admin_ bit NOT NULL,

primary key(ID_Korisnik)
);
create table Mjesta(
ID_Mjesto int identity(1,1) NOT NULL,
Naziv nvarchar(50) NOT NULL,

primary key(ID_Mjesto)

);
create table VrsteEventa(
ID_Vrsta int identity(1,1) NOT NULL,
Naziv nvarchar(50) NOT NULL,

primary key(ID_Vrsta)

);
create table Eventi(
ID_Event int identity(1,1) NOT NULL,
Naziv nvarchar(50) NOT NULL,
Vrijeme datetime NOT NULL,
Mjesto int NOT NULL,
Adresa nvarchar(80) NOT NULL,
Cijena nvarchar(50),
VrstaEventa int NOT NULL,
Organizator int NOT NULL,
OgraniceniPosjetitelji bit NOT NULL

primary key(ID_Event),
foreign key (Organizator) REFERENCES Korisnici(ID_Korisnik),
foreign key (VrstaEventa) REFERENCES VrsteEventa(ID_Vrsta),
foreign key (Mjesto) REFERENCES Mjesta(ID_Mjesto)
);
create table KorisnikEvent(
ID_KorisnikEvent int identity(1,1) NOT NULL,
Event_ int NOT NULL,
Korisnik int NOT NULL,
Potvrdeno bit, 
Recenzija int,

primary key(ID_KorisnikEvent),
foreign key (Event_) REFERENCES Eventi(ID_Event),
foreign key (Korisnik) REFERENCES Korisnici(ID_Korisnik)
);
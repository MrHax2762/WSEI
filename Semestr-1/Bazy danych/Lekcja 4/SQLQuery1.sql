USE master;
IF EXISTS(select * from sys.databases where name='wu')
ALTER DATABASE wu SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE if exists wu
go
CREATE DATABASE wu
go
USE wu
go

/*instrukcje tworzace baze danych dla wyzszej uczelni BEZ DANYCH
skladnia T-SQL
*/

create table oceny (
ocena decimal(3,1) primary key);

Insert into oceny values (2),(2.5),(3),(3.5),(4),(4.5),(5.0)

create table grupy (
nr_grupy char(10) primary key);
Insert into grupy(nr_grupy) values ('DMIe1001')
Insert into grupy(nr_grupy) values ('DMZm1003')
Insert into grupy(nr_grupy) values ('ZMZm2001')

create table stopnie_tytuly (
stopien_tytul varchar(25) primary key,
stawka smallmoney not null);
Insert into  stopnie_tytuly values ('doktor',45),('doktor habilitowany',55),('profesor nadzwyczajny',60),('profesor zwyczajny',65)


create table pracownicy (
id_pracownika int identity primary key,
nazwisko varchar(30) not null,
imie varchar(25),
NIP char(13),
PESEL char(11));

Insert into pracownicy (imie,nazwisko) values ('Iwona','Halemba'),('Jacek','Nowak'),('Ireneusz','Janikowski'),('Jacek','Malinowski')

create table wykladowcy (
id_wykladowcy int primary key,
stopien_tytul varchar(25) not null,
katedra varchar(100)

);

alter table wykladowcy add constraint rpw foreign key (id_wykladowcy) references pracownicy (id_pracownika) on delete cascade;
alter table wykladowcy add constraint rwst foreign key (stopien_tytul) references stopnie_tytuly on delete no action on update cascade;

create table studenci (
id_studenta int identity primary key,
nazwisko varchar(30) not null,
imie varchar(25),
data_urodzenia date check(data_urodzenia<=dateAdd(year,-18,getdate())),
nr_grupy char(10) not null
);
alter table studenci add constraint rsg foreign key (nr_grupy) references grupy on delete no action on update cascade;

create table wyklady (
id_wykladu int identity primary key,
nazwa_wykladu varchar(50) not null,
liczba_godzin tinyint check(liczba_godzin<=60),
id_wykladowcy int,
foreign key (id_wykladowcy) references wykladowcy 
on delete no action on update cascade
);

create table studenci_wyklady (
id_studenta int,
id_wykladu int,
primary key (id_studenta, id_wykladu),
foreign key (id_wykladu) references wyklady on delete no action,
foreign key (id_studenta) references studenci on delete cascade
);

create table oceny_studentow (
id_studenta int,
id_wykladu int,
data_egzaminu date default getdate() check(data_egzaminu<=getdate()),
ocena decimal(3,1) not null,
primary key (id_studenta, id_wykladu, data_egzaminu),
foreign key (id_studenta, id_wykladu) references studenci_wyklady 
on delete no action on update cascade,
foreign key (ocena) references oceny on delete no action on update cascade
);
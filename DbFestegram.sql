go
create database DbFestegram
go
use DbFestegram

create table tbl_kullanici(
id int primary key identity(1,1),
kullanici_ad varchar(50),
sifre varchar(20),
eposta varchar(100),
gonderisayi int,
takipci int,
takip int,
profilfoto varchar(500),
biografi varchar(300),
sil_id int default 1
)
go
create table tbl_kullanicigönderi(
id int primary key identity(1,1),
kullanici_ad varchar(50),
post varchar(500),
aciklama varchar(200),
sil_id int default 1
)
go
create table tbl_geribildirim(
id int primary key identity(1,1),
kullanici_id int,
tip varchar(20),
gonderen varchar(50),
bildirim varchar(1000),
sil_id int default 1
)
create table tbl_takip(
id int primary key identity(1,1),
takipeden varchar(50),
takipedilen varchar(50),
sil_id int default 1
)
create table tbl_gyorum(
id int primary key identity(1,1),
kullanici_ad varchar(50),
post varchar(500),
gonderen varchar(50),
yorum varchar(200),
sil_id int default 1

)
insert into tbl_kullanici(kullanici_ad,eposta,sifre,sil_id)values ('admin','admin@gnail.com','12345',3)
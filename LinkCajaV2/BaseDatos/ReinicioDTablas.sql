--Iniciacion de linkcaja V2
DBCC FREESYSTEMCACHE ('LinkCaja');
go
delete from TransactionHistory
DBCC CHECKIDENT ('TransactionHistory', RESEED, 0);
go
delete from Categories
DBCC CHECKIDENT ('Categories', RESEED, 0);
go
delete from Cashfund
DBCC CHECKIDENT ('Cashfund', RESEED, 0);
go
delete from DetailsTicket
DBCC CHECKIDENT ('DetailsTicket', RESEED, 0);
go
DELETE FROM Tickets;
DBCC CHECKIDENT ('Tickets', RESEED, 0);
go
delete from PricesSuppliers
DBCC CHECKIDENT ('PricesSuppliers', RESEED, 0);
go
delete from Presentations
DBCC CHECKIDENT ('Presentations', RESEED, 0);
delete from Items
DBCC CHECKIDENT ('Items', RESEED, 0);
go
delete from Recipes
DBCC CHECKIDENT ('Recipes', RESEED, 0);
go
delete from Articles
DBCC CHECKIDENT ('Articles', RESEED, 0);
go
delete from Clients
DBCC CHECKIDENT ('Clients', RESEED, 0);
go
delete from Company
DBCC CHECKIDENT ('Company', RESEED, 0);
go
delete from Suppliers
DBCC CHECKIDENT ('Suppliers', RESEED, 0);
go
delete from TypesUsers
DBCC CHECKIDENT ('TypesUsers', RESEED, 0);
go
delete from Users
DBCC CHECKIDENT ('Users', RESEED, 0);
go
delete from ConfigBox
DBCC CHECKIDENT ('ConfigBox', RESEED, 0);
go
delete from ConfigImpressions
DBCC CHECKIDENT ('ConfigImpressions', RESEED, 0);
go
delete from Impressions from DetailsTicket
DBCC CHECKIDENT ('Impressions', RESEED, 0);
go
delete from Boxs from Boxs
DBCC CHECKIDENT ('Boxs', RESEED, 0);
go
delete from Impressions from Keys
DBCC CHECKIDENT ('Keys', RESEED, 0);
go
SET IDENTITY_INSERT TypesUsers ON;
insert into TypesUsers(Id,[Name])values(1,'Administrador')
insert into TypesUsers(Id,[Name])values(2,'Empleado')
insert into TypesUsers(Id,[Name])values(3,'Almacenista')
SET IDENTITY_INSERT TypesUsers OFF;
go
SET IDENTITY_INSERT Users ON;
insert into Users(Id,[User],[Password],[Status],[IdTypeUser],[Name],[Address])
values(1,'Administrador','Admin123',1,1,'Administrador','Administrador')
SET IDENTITY_INSERT Users OFF;
go
SET IDENTITY_INSERT Presentations ON;
insert into Presentations(Id,[Name],[Presentation],[Decimals],[Submeasurement],[UnitSAT])
Values(1,'Kilogramos','Kg',3, 'Gramos','KGM')
insert into Presentations(Id,[Name],[Presentation],[Decimals],[Submeasurement],[UnitSAT])
Values(2,'Litros','L',3,'Mililitros','LTR')
insert into Presentations(Id,[Name],[Presentation],[Decimals],[Submeasurement],[UnitSAT])
Values(3,'Metros','M',3,'Centimetros','MTR')
insert into Presentations(Id,[Name],[Presentation],[Decimals],[Submeasurement],[UnitSAT])
Values(4,'Piezas','pzs',0,'Piezas','H87')
insert into Presentations(Id,[Name],[Presentation],[Decimals],[Submeasurement],[UnitSAT])
Values(5,'Paquetes','paq',0,'Paquetes','XPK')
insert into Presentations(Id,[Name],[Presentation],[Decimals],[Submeasurement],[UnitSAT])
Values(6,'Cajas','caj',0,'Cajas','XBX')
SET IDENTITY_INSERT Presentations OFF;
go
SET IDENTITY_INSERT Impressions ON;
INSERT INTO [dbo].[Impressions](Id,[Name],[Page],[WidthPage],[HightPage])VALUES(1,'Lista de precios','A4',0,0)
INSERT INTO [dbo].[Impressions](Id,[Name],[Page],[WidthPage],[HightPage])VALUES(2,'Ticket','mm',80.00,60.00)
INSERT INTO [dbo].[Impressions](Id,[Name],[Page],[WidthPage],[HightPage])VALUES(3,'Etiquetas','A4',0,0)
SET IDENTITY_INSERT Impressions OFF;
go
SET IDENTITY_INSERT ConfigBox ON;
INSERT INTO [dbo].[ConfigBox](Id,[IdImpression],[Name],[Spacing],[Align],[Width],[HightLine]
,[ColorLine])
VALUES(1,1,'BoxPrecios',8,'AlignCenter',130,0.50,'Black')
SET IDENTITY_INSERT ConfigBox OFF;
go
SET IDENTITY_INSERT ConfigImpressions ON;
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(1,1,'Titulo',16,'SemiBold','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(2,1,'Fecha',16,'SemiBold','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(3,1,'Articulo',12,'Bold','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(4,1,'Precio',12,'Normal','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(5,2,'Titulo',12,'SemiBold','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(6,2,'Nombre de empresa',12,'SemiBold','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(7,2,'RFC',7,'Bold','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(8,2,'Fecha',12,'Normal','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(9,2,'Tabla',12,'Normal','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(10,2,'Total',12,'Normal','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(11,3,'Titulo',16,'SemiBold','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(12,3,'Fecha',16,'SemiBold','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(13,3,'Articulo',12,'Bold','Black')
INSERT INTO [dbo].[ConfigImpressions](Id,[IdImpression],[Name],[FontSize],[FontStyle],[FontColor])
VALUES(14,3,'Precio',12,'Normal','Black')
SET IDENTITY_INSERT ConfigImpressions OFF;
go
SET IDENTITY_INSERT Clients ON;
INSERT INTO [dbo].[Clients](Id,[Name],[Address],[Phone1],[Phone2],[Email],[Status])
VALUES(1,'ClienteGeneral','Conocida','1111111111','','',1)
SET IDENTITY_INSERT Clients OFF;

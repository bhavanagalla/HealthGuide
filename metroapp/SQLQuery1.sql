USE master;
CREATE DATABASE CalorieCalc
ON (NAME=projects_dat,
FILENAME = 'C:\Users\DELL\Documents\Visual Studio 2012\Projects\metroapp\CalorieCalc.mdf');

create table Fruits(Item char(20),Quantity integer);
alter table Fruits add Calories integer;
select * from Fruits;
alter table Fruits alter column Quantity varchar(30) NULL;
alter table Fruits alter column Item varchar(50) NULL;
alter table Fruits alter column Calories int NULL;

SET ANSI_WARNINGS OFF 
GO

insert into Fruits values('Apples','Medium 140 g','81');
INSERT INTO Fruits(Item,Quantity,Calories) VALUES (&1,&2,&3);
insert into Fruits values('','','');
INSERT INTO Fruits( Column1, Column2 ) VALUES( Value1, Value2 ), ( Value1, Value2 );
select count(*) from Fruits;
INSERT INTO Fruits(Item, Quantity, Calories)SELECT Item, Quantity, Calories FROM Fruits;
delete from Fruits where Calories='105';
insert into Fruits(Item, Quantity, Calories) select 1,2,3 from Fruits;
INSERT INTO Fruits( Item,Quantity, Calories) VALUES('Apricot','Medium 30 g',17),('Avocado','Half','162'),('Banana','Medium 100g',105);
INSERT INTO Fruits( Item,Quantity, Calories) VALUES('Black berry','One cup','117'),('Blueberry','One cup','122'),('Cherries','10 beads','49'),
('Fig','One, 40 g','37'),('Grapefruit','Half','38'),('Grapes','Half a cup','53'),('Guava','One, 85 g','45'),
('Kiwi','One, 76 g','46'),('Lemon','One, 60 g','17'),('Loquat','100 g','49'),('Mango','Half, 85 g','68'),
('Melon','Piece, 100 g','33'),('Nabq (rhamnus)','30 beads','9'),('Nectarine','Medium, 142 g','67'),('Orange','One, 110 g','62'),('Papaya','Medium','117'),('Peach','One, 85 g','37'),('Pear','Medium, 170 g','98'),
('Pineapple','Slice, 82 g','42'),('Plum','One, 60 g','36'),('Plum','100 g','52'),('Pomegranate','Medium, 150 g','110'),
('Quince','Medium','60'),('Rutab/ripe dates','10 beads','150'),('Strawberries','Half a cup','23'),('Sweet Lemon','Fruit size','53'),
('Tamarind','Half a cup','82'),('Tangerine','One, 85 g','37'),('Watermelon','Piece, 100 g','26');

create table Items(Category varchar(20));
Insert into Items(Category) Values('Fruits'),('vegetables'),('Beverages'),('Juices');
Select * from Items;

					




Create Database HR

USE [HR]
GO


CREATE TABLE empdetails
(
ccode char(5)primary key,
cname varchar(50),
caddress varchar(30),
cstate varchar(20) ,
ccountry varchar(30),
cDesignation char(20),
cDepartment char(10),
 )
GO

use hr
insert empdetails values('C001','Harry','1/2 Lone St','Kanas','USA','MANAGER','FINANCE')
insert empdetails values('C002','Roger','2 Cannon St','Texas','USA','MANAGER','MARKETING')
insert empdetails values('C003','Peter','155 James St','Gegoria','USA','ASST MANAGER','MARKETING')
insert empdetails values('C004','John','Street a','California','USA','TECHNICIAN','TECHNICAL')
insert empdetails values('C005','George','1/2 Lone St','Texas','USA','TEAM LEADER','FINANCE')
insert empdetails values('C006','Mathew','James corner','Kanas','USA','GROUP LEADER','MARKETING')
go

use ProdiTI;


--cereate table
create table Pembimbing_Akademik
   (NIK varchar (3) primary key,
   Nama_Pembimbing varchar (50),
   Keahlian varchar (20),
   Status int,
   Tes int
   )

insert into Pembimbing_Akademik (NIK, Nama_Pembimbing, Keahlian, Status, Tes)values 
('111', 'Djoko Purbohadi', 'Programming', 1, 1),
('222','Haris Setyawan', 'Database', 1,1),
('333','Laila Makrifatul', 'Database',1,3);

select * from Pembimbing_Akademik
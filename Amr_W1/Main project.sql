create table Userr(
userr_id int primary key not null,
userr_name varchar (100) not null,
user_password varchar (100) not null,
user_age int not null,
user_gender varchar (100) not null,
user_number int not null,
user_city varchar (100) not null,
);
--Insert into table userr--
insert into Userr(userr_id , userr_name , user_password , user_age , user_gender , user_number , user_city)
values
(101,'Ibrahim','123',23,'Male',0115336754,'Giza'),
(103,'Yara','223',22,'Femal',0103033131,'Zagazig'),
(104,'Yassmin','322',23,'Femal',0124244242,'Giza');
select * From Userr

create table Adminn(
user_namee varchar (100) not null,
phone_number int not null,
age int not null,
);
insert into Adminn(user_namee,phone_number,age)
values
('mohamed' , 0115443493 , 23),
('ali' , 0124546864 , 32);
select * from Adminn
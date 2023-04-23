/*create table Persons
(
PersonID int,
LastName varchar(255),
FirstName varchar(255),
Address varchar(255),
City varchar(255)
);*/

/*insert into Persons values(101,'Paul','Immanuvella','Ernakulam','Aluva');

insert into Persons values(101,'Kumar','Ram','Kerala','Aluva');

select * from Persons;
update Persons set PersonID='102' where FirstName='Ram';
create table Employee
(
Id int PRIMARY KEY NOT NULL,
Name varchar(20) ,
Desg varchar(50) NOT NULL,


);
create table Manager
(
Id int PRIMARY KEY NOT NULL,
Name varchar(20)
);
create table Employee
(
EmpId int PRIMARY KEY NOT NULL,
Name varchar(20) ,
Desg varchar(50) NOT NULL,
Id int ,
foreign key(Id) references Manager(Id)
);

alter table Employee add age int;

alter table Employee add check(age>=18);

insert into Manager values(101,'Arun');
insert into Manager values(102,'Tarun');
insert into Manager values(103,'Karun');


insert into Employee values(101,'Karan','Trainee',102,23);
insert into Employee values(102,'Kiran','Lead',101,25);
insert into Employee values(103,'Joseph','HR',103,28);


update Employee set Name='Kran Kumar' where Name='Karan';


select Employee.EmpId,Employee.Name,Employee.Desg,Employee.Id,Employee.age from Employee left join Manager on Employee.Id=Manager.Id;



select UPPER(Name) from Employee;

select count(EmpId) as 'NumberofEmployees' from Employee;
*/
select max(age) from Employee;


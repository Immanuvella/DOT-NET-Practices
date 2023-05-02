create procedure proceduredemo as
begin
select sum(Balance) as SumofBalance
from Acount;
end;



insert into Acount (AccountNo,Name,Balance)values(1000001,'Immanuvella',2000);
insert into Acount (AccountNo,Name,Balance)values(1000002,'Paul',3000);


Execute proceduredemo;

create procedure  sp_printDate as
begin
select getdate();
end;
execute sp_printDate;



create or alter procedure Acproceduredemo(@acno int)
as
begin
select * from Acount where AccountNo=@acno;
end;
execute Acproceduredemo 1000001;

--Even or Odd
create procedure CheckOddorEven(@number int)
as
begin
if(@number % 2 =0)
begin
  print 'Even number'
end
else
begin
   print 'Odd number'
end
end;


execute CheckOddorEven 20;

--voting eligibility
create procedure VotingEligibility(@age int)
as
begin
if(@age >=18)
begin
  print 'Eligible to Vote'
end
else
begin
   print 'Not eligible to Vote'
end
end;
execute VotingEligibility 13;
execute VotingEligibility 23;

insert into Employee(EmpId,Name,Desg,Id,age,salary) values(106,'arttt','gfgf',234,34,10000);
select * from Persons;

create or alter procedure getcity
@pid int,@city varchar output
as
begin
select @city=City from Persons
where PersonID=@pid
end;


create or alter procedure getSal
@empid int,@sal money output
as
begin
select @sal=salary from Employee
where EmpId=@empid
end;


create trigger Depttrg on Dept
after insert
as
select 'dept added';

insert into Dept values(102,'Finance');






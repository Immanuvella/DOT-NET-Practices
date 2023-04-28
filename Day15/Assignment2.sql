create table client_master
(
clientno varchar(6) Check (clientno LIKE 'C%') primary key not null,
name varchar(20) not null,
address1 varchar(30),
address2 varchar(30),
city varchar(15),
pincode numeric(8),
state varchar(15),
baldue numeric(10,2)

);


create table product_master
(
productno varchar(6) check (productno like 'P%') primary key ,
description varchar(15) not null,
profitperc numeric(4,2) not null,
unitmeasure varchar(10) not null,
qtyonhand numeric(8) not null,
reorderlvl numeric(8) not null,
sellprice numeric(8,2) check(sellprice!=0),
costprice numeric(8,2) check(costprice!=0)
);

create table salesman_master
(
salesmanno varchar(6) check(salesmanno like 'S%') primary key,
salesmanname varchar(20) not null,
address1 varchar(30) not null,
address2 varchar(30) not null,
city varchar(20),
pincode numeric(8),
state varchar(20),
salamt numeric(8,2) not null check(salamt!=0),
tgttoget numeric(6,2) not null,
ytdsales numeric(6,2) not null,
remarks varchar(60)
);
create table sales_order
(
orderno varchar(6) primary key check(orderno like 'O%'),
clientno varchar(6),
orderdate date,
delyaddr varchar(25),
salesmanno varchar(6),
delytype char(1) check (delytype='P' or delytype='F'),
billedyn char(1) check (billedyn='Y' or billedyn='N'),
delydate date,
orderstatus varchar(10) check (orderstatus='In Process' or orderstatus='Backorder' or orderstatus='Cancelled')
foreign key(clientno) references client_master(clientno),
foreign key(salesmanno) references salesman_master(salesmanno),

);

create table sales_order_details
(
orderno varchar(6) ,
productno varchar(6),
qtyordered numeric(8),
qtydisp numeric(8),
productrate numeric(10,2),
primary key(orderno,productno),
foreign key(orderno) references sales_order(orderno),
foreign key(productno) references product_master(productno)
);


insert into client_master (clientno,name,city,pincode,state,baldue)values('C00001','Ivan Bayross','Mumbai',400054,'Maharashtra',15000);
insert into client_master (clientno,name,city,pincode,state,baldue)values('C00002','Ram Kumar','Bangalore',400034,'Karnataka',20000);
insert into client_master (clientno,name,city,pincode,state,baldue)values('C00003','Hari P','Ernakulam',686754,'Kerala',35000);
insert into client_master (clientno,name,city,pincode,state,baldue)values('C00004','Immanuvella','Ernakulam',765678,'Kerala',18000);
insert into client_master (clientno,name,city,pincode,state,baldue)values('C00005','Krishna Kumar','Trissur',677876,'Kerala',10000);

insert into product_master values('P00001','T-Shirts',5,'Piece',200,50,350,250);
insert into product_master values('P00002','Pants',4,'Piece',400,30,450,150);
insert into product_master values('P00003','Shirts',6,'Piece',100,40,250,350);
insert into product_master values('P00004','Jeans',4,'Piece',250,40,5500,650);
insert into product_master values('P00005','Kurtas',5,'Piece',300,60,6500,550);


insert into salesman_master values('S00001','Aman','A/14','Worli','Mumbai',400002,'Maharashtra',3000,100,50,'Good');
insert into salesman_master values('S00002','Arun','A/12','Kochi','Kerala',400003,'Maharashtra',4000,300,40,'Bad');
insert into salesman_master values('S00003','Kiran','A/14','Thrisssur','Kerala',400004,'Maharashtra',5000,130,20,'Good');
insert into salesman_master values('S00004','Keshav','A/17','Bangalore','Karanataka',400005,'Maharashtra',6000,200,10,'Average');
insert into salesman_master values('S00005','Varun','A/11','Badhra','Mumbai',400001,'Maharashtra',3000,150,40,'Good');


insert into sales_order(orderno,orderdate,clientno,delytype,billedyn,salesmanno,delydate,orderstatus)values('O19001','12-june-02','C00001','F','N','S00001','20-jul-02','In Process');
insert into sales_order(orderno,orderdate,clientno,delytype,billedyn,salesmanno,delydate,orderstatus)values('O19002','15-january-04','C00002','P','Y','S00002','20-february-04','Cancelled');
insert into sales_order(orderno,orderdate,clientno,delytype,billedyn,salesmanno,delydate,orderstatus)values('O19003','20-march-02','C00003','F','N','S00003','20-april-02','In Process');
insert into sales_order(orderno,orderdate,clientno,delytype,billedyn,salesmanno,delydate,orderstatus)values('O19004','18-july-03','C00004','P','Y','S00004','20-aug-03','Cancelled');
insert into sales_order(orderno,orderdate,clientno,delytype,billedyn,salesmanno,delydate,orderstatus)values('O19005','06-february-06','C00005','F','N','S00005','20-march-06','Backorder');

insert into sales_order_details(orderno,productno,qtyordered,qtydisp,productrate)values('O19001','P00001',4,4,525);
insert into sales_order_details(orderno,productno,qtyordered,qtydisp,productrate)values('O19002','P00002',3,3,425);
insert into sales_order_details(orderno,productno,qtyordered,qtydisp,productrate)values('O19003','P00003',6,5,325);
insert into sales_order_details(orderno,productno,qtyordered,qtydisp,productrate)values('O19004','P00004',3,6,455);
insert into sales_order_details(orderno,productno,qtyordered,qtydisp,productrate)values('O19005','P00005',2,4,545);


-- Display the names of all the clients. 
select name from client_master;

--Display all the clients who are located in Mumbai. 
select * from client_master where city='Mumbai';

--Display all the products whose selling price is > 2000 and < 5000. 
select * from product_master where sellprice>200 and sellprice<5000;

--Display Name, City and State of Clients not in the state of Maharashtra. 
select name,city,state from client_master where state not in ('Maharashtra');

-- Display all the information of client_no C0001 and C0002.
select * from client_master where clientno in ('C00001','C00002');


--Change the selling price of '1.44 drive' to Rs. 1150.50
update product_master set sellprice=1150.50 where sellprice=1.44;

--Delete the record of client_no C0005. 
delete from client_master where clientno='C00005';

--Display the clients who stay in a city whose second letter is 'a'
select name from client_master where city like '_a%';

--Count the number of products having price greater than or equal to 1500. 
select count(productno) from product_master where sellprice>=1500;

--Display qtyordered, qtydisp and balancedqty (not in table)
select qtyordered,qtydisp,round(qtydisp,2) as BalancedQty from sales_order_details;


--Make Client_no as primary key in client_master
alter table client_master add primary key(clientno);

--Add a new column phone_no in the client_master table.
alter table client_master add phone_no numeric(10);

--Add the not null constraint in the product_master table with the column description, profit percent, sell price and cost price. 
alter table product_master alter column description varchar(15) not null;
alter table product_master alter column profitperc numeric(4,2) not null;
alter table product_master alter column sellprice numeric(8,2) not null;
alter table product_master alter column costprice numeric(8,2) not null;

-- Change size of name column to 60 in client_master table. 
alter table client_master alter column name varchar(60);

--Remove pincode column from table
alter table client_master drop column pincode;


--Find out the products, which have been sold to 'Ivan Bayross'. 
select * from product_master join 
sales_order_details on product_master.productno=sales_order_details.productno
join sales_order on sales_order.orderno=sales_order_details.orderno
join client_master on client_master.clientno=sales_order.clientno
where client_master.name='Ivan Bayross';

-- Finding out the products and their quantities that will have to be delivered in the current month. 
select product_master.productno,product_master.qtyonhand from product_master join 
sales_order_details on product_master.productno=sales_order_details.productno
join sales_order on sales_order.orderno=sales_order_details.orderno
where month(sales_order.delydate)='04';

--Listing the ProductNo and description of constantly sold (i.e. rapidly moving) products. 
select product_master.productno,product_master.description from product_master join sales_order_details on
product_master.productno=sales_order_details.productno
where sales_order_details.qtyordered>5;

--Finding the names of clients who have purchased 'Trousers'. 
select client_master.name from client_master join sales_order on
client_master.clientno=sales_order.clientno join
sales_order_details on sales_order.orderno=sales_order_details.orderno
join product_master on sales_order_details.productno=product_master.productno
where product_master.description='Trousers';

--Listing the products and orders from customers who have ordered less than 5 units of 'Pull Overs'
select * from client_master join sales_order on
client_master.clientno=sales_order.clientno join
sales_order_details on sales_order.orderno=sales_order_details.orderno
join product_master on sales_order_details.productno=product_master.productno
where sales_order_details.qtyordered<5 ;


-- Finding the non-moving products i.e. products not being sold. 
select * from product_master where productno not in(select productno from sales_order_details);

--Finding the name and complete address for the customer who has placed Order number 'O19001'. 
select name,city from client_master where clientno in (select clientno from sales_order where orderno='O19001');

-- Finding the clients who have placed orders before the month of May'02.
SELECT clientno, NAME FROM client_master WHERE clientno IN(SELECT clientno FROM SALES_ORDER WHERE  TO_CHAR(orderdate, 'MON,YY') < 'MAY,02');



--Display system date as Saturday, February 11, 2012 
select concat(datename(weekday,getdate()),', ',datename(month,getdate()),' ',day(current_timestamp),'  ',year(current_timestamp));

--Display Balance Due from Client master as $99,999.99 
select format(baldue,'C', 'en-US') from client_master ;

-- Display message as 'Salesman Aman sold goods of 50 while given target was 100. 
select concat(salesmanname,' sold goods of ',salamt,' while given target was ',tgttoget) from salesman_master;


--Write a PL/SQL block to check the given number is even or odd.
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

--Write a PL/SQL block to pass an age as parameter in procedure and decide person can vote or not. 
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










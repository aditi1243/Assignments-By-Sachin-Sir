use ABC_Company


create table Category(
c_id int not null Primary Key identity(1,1),
c_name varchar(64) not null,
tax decimal)
insert into Category values('Books Collection',15)
select * from Category


create table Product(
p_id int not null Primary Key identity(1,1),
p_name varchar(64) not null,
open_stock decimal not null,
cur_stock decimal not null,
sale_price decimal not null,
category int not null References category(c_id)
)
insert into Product values('Trousers',40,50,600,5)
select * from Product

create table Customer1(
cust_id int not null Primary key identity(1,1),
cust_name varchar(32) not null,
cust_mobile varchar(15) not null,
open_bal decimal not null default 0,
is_active BIT not null constraint defa default('True')
)
insert into Customer1 values('Aishwaraya',8823456787,default,default)
select * from Customer1

create table SalesHead(
sale_inv_no int not null Primary Key identity(1,1),
sale_date date not null,
customer int not null References Customer1(cust_id),
Ptype char(10),
constraint check_1 check(Ptype='Credit' or Ptype='Paid'))

select * from SalesHead
insert into SalesHead values('2020-12-12',5,'Credit')

---create proc insert_sales_inv_no(
---sales_inv_no int not null Primary Key)



create table SalesDetail
 (sale_inv_no int not null foreign key references SalesHead(sale_inv_no),
 product_id int not null foreign key references Product(p_id),
 qty decimal not null,
 rate decimal not null)
 
 insert into SalesDetail values( 2,2,5,6000)
 select * from SalesDetail

 ---Query 1
 select p.p_name,c.c_name,p.cur_stock from product as p,Category as c where p.category= c.c_id

 ---Quer 2
 select cust_name from Customer1 where is_active='True'

---Query 3
select cust_name,open_bal from Customer1

---Query 4
select  sum(sd.qty) as SALES from SalesDetail as sd , SalesHead as sh where sale_date >= '2020-06-01' and sale_date < '2020-07-01'

---Query 5
 select p_name ,sum(qty) QTY from Product as p, SalesDetail as sd where sd.product_id=p.p_id 
 group by p_name 
 order by (QTY) DESC

 ---Query 6
  select p_name ,sum(qty) QTY from Product as p, SalesDetail as sd where sd.product_id=p.p_id 
 group by p_name 
 order by (QTY) ASC

 ----Query 7
 select c.cust_name,s.
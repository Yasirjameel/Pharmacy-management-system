create database pharma


Go

create table employee
(q_id int identity(1,1) primary key,
Full_Name varchar(255) NOT NULL,
Age int NOT NULL,
[Address] varchar(255) NOT NULL,
Hiring_date date NOT NULL,
Contact varchar(255) NOT NULL
)
Go

create table customer
(w_id int identity(1,1) primary key,
Name varchar(255) NOT NULL,
[Address] varchar(255) NOT NULL,
Contact varchar(255) NOT NULL
)
Go
create table supplier
(a_id int identity(1,1) primary key,
Name varchar(255)NOT NULL,
[Address] varchar(255) NOT NULL,
Contact varchar(255)NOT NULL
)

Go
create table stock
(d_id int identity(1,1) primary key,
s_id int,
a_id int,
Batch_no varchar(255) NOT NULL,
[Product_name] varchar(255),
Quantity int NOT NULL,
[Buying_price_perunit] float NOT NULL,
[Selling_price_perunit] float NOT NULL,
[Bought_date] date NOT NULL,
foreign key (a_id) references supplier(a_id),
foreign key (s_id) references product(s_id),
)

Go
create table product
(s_id int identity(1,1) primary key,
t_id int,
[Drug_type] varchar(255) NOT NULL,
[Section_no] varchar(255) NOT NULL,
[Product_name] varchar(255) NOT NULL,
Potency varchar(255) NOT NULL,
foreign key (t_id) references section(t_id),
)
Go

create table section
(t_id int identity(1,1) primary key,
[Section_no] varchar(255),
[Section_detail] varchar(255)
) 
Go
create table expiry
(id int identity (1,1),
ex date,
)

Go
create table cato
(id int identity(1,1),
catogery varchar(255)
)
Go
create table opeaning
(id int identity (1,1),
[Opeaning] date,
[Opeaning_Time] varchar(255),
)
Go
create table closing
(id int identity (1,1),
Closing date,
[Closing_Time] varchar(255) 
)
Go
create table order_details
(id int identity(1,1) Primary key,
s_id int,
w_id int,
q_id int,
discount decimal,
price_per_unit decimal,
quantity int
foreign key (s_id) references product(s_id),
foreign key (w_id) references customer(w_id),
foreign key (q_id) references employee(q_id)
)
 create table receipt
 (id int identity (1,1),
 [customer_name] varchar(255),
 employee varchar(255),
 [product_name] varchar(255),
 [Price_per_unit] float,
 Quantity int
 )
 
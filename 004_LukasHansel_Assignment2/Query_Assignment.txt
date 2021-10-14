CREATE DATABASE db_Kantor;

CREATE TABLE tb_productlines(
	productline int identity(1,1) primary key,
	textdescription varchar(255),
	htmldescription varchar(255),
	image varchar(255)
);

CREATE TABLE tb_products(
	productcode int identity(1,1) primary key,
	productname varchar(255),
	productline int,
	productscale varchar(255),
	productvendor varchar(255),
	productdescription varchar(255),
	quantityinstock int,
	buyprice int,
	msrp int,
	FOREIGN KEY (productline) REFERENCES tb_productlines(productline)
);

CREATE TABLE tb_orderdetails(
	idorderdetails int identity(1,1) primary key,
	ordernumber int,
	productcode int,
	quantityordered int,
	priceeach int,
	orderlinenumber int,
	FOREIGN KEY (productcode) REFERENCES tb_products (productcode),
	FOREIGN KEY (ordernumber) REFERENCES tb_orders (ordernumber)
);

CREATE TABLE tb_orders(
	ordernumber int identity(1,1) primary key,
	orderdate date,
	requireddate date,
	shippeddate date,
	status varchar(10),
	comments varchar(255),
	customernumber int
	FOREIGN KEY (customernumber) REFERENCES tb_customers (customernumber)
);

CREATE TABLE tb_customers(
	customernumber int identity(1,1) primary key,
	customername varchar(255),
	contactlastname varchar(255),
	contactfirstname varchar(255),
	phone varchar(255),
	addressline1 varchar(255),
	addressline2 varchar(255),
	city varchar(255),
	state varchar(255),
	postalcode varchar(255),
	country varchar(255),
	salesrepemployeenumber int,
	creditlimit int
	FOREIGN KEY (salesrepemployeenumber) REFERENCES tb_employees (employeenumber)
);

CREATE TABLE tb_payments(
	checknumber int identity(1,1) primary key,
	customernumber int,
	paymentdate date,
	amount int
	FOREIGN KEY (customernumber) REFERENCES tb_customers (customernumber)
);

CREATE TABLE tb_employees(
	employeenumber int identity(1,1) primary key,
	lastname varchar(255),
	firstname varchar(255),
	extension varchar(255),
	email varchar(255),
	officecode int,
	reportsto int,
	jobtitle varchar(255),
	FOREIGN KEY (reportsto) REFERENCES tb_employees (employeeNumber),
	FOREIGN KEY (officecode) REFERENCES tb_offices (officecode)
);

CREATE TABLE tb_offices(
	officecode int identity(1,1) primary key,
	city varchar(20),
	phone varchar(20),
	addressline1 varchar(255),
	addressline2 varchar(255),
	state varchar(50),
	country varchar(50),
	postalcode varchar(20),
	territory varchar(30)
);

 -- Insert data productlines
INSERT INTO tb_productlines (textdescription, htmldescription, image) VALUES ('productlines1 txt', 'productlines1 html', 'productlines1 img');
INSERT INTO tb_productlines (textdescription, htmldescription, image) VALUES ('productlines2 txt', 'productlines2 html', 'productlines2 img');
INSERT INTO tb_productlines (textdescription, htmldescription, image) VALUES ('productlines3 txt', 'productlines3 html', 'productlines3 img');
INSERT INTO tb_productlines (textdescription, htmldescription, image) VALUES ('productlines4 txt', 'productlines4 html', 'productlines4 img');

-- Insert data products
INSERT INTO tb_products (productname, productline, productscale, productvendor, productdescription, quantityinstock, buyprice, msrp)
VALUES('Produk1', 1, 'Scale', 'Vendor', 'Description', 10, 100, 150);
INSERT INTO tb_products (productname, productline, productscale, productvendor, productdescription, quantityinstock, buyprice, msrp)
VALUES('Produk2', 2, 'Scale', 'Vendor', 'Description', 20, 200, 250);
INSERT INTO tb_products (productname, productline, productscale, productvendor, productdescription, quantityinstock, buyprice, msrp)
VALUES('Produk3', 3, 'Scale', 'Vendor', 'Description', 30, 300, 350);
INSERT INTO tb_products (productname, productline, productscale, productvendor, productdescription, quantityinstock, buyprice, msrp)
VALUES('Produk4', 4, 'Scale', 'Vendor', 'Description', 40, 400, 450);
INSERT INTO tb_products (productname, productline, productscale, productvendor, productdescription, quantityinstock, buyprice, msrp)
VALUES('Produk5', 1, 'Scale', 'Vendor', 'Description', 50, 500, 5550);
INSERT INTO tb_products (productname, productline, productscale, productvendor, productdescription, quantityinstock, buyprice, msrp)
VALUES('Produk6', 2, 'Scale', 'Vendor', 'Description', 60, 600, 650);
INSERT INTO tb_products (productname, productline, productscale, productvendor, productdescription, quantityinstock, buyprice, msrp)
VALUES('Produk7', 3, 'Scale', 'Vendor', 'Description', 70, 700, 750);
INSERT INTO tb_products (productname, productline, productscale, productvendor, productdescription, quantityinstock, buyprice, msrp)
VALUES('Produk8', 4, 'Scale', 'Vendor', 'Description', 80, 800, 850);

-- Insert order details
INSERT INTO tb_orderdetails (productcode, quantityordered, priceeach, orderlinenumber, ordernumber)
VALUES(1, 5, 200, 5758, 1);
INSERT INTO tb_orderdetails (productcode, quantityordered, priceeach, orderlinenumber, ordernumber)
VALUES(2, 10, 400, 5758, 2);
INSERT INTO tb_orderdetails (productcode, quantityordered, priceeach, orderlinenumber, ordernumber)
VALUES(4, 20, 800, 5758, 3);
INSERT INTO tb_orderdetails (productcode, quantityordered, priceeach, orderlinenumber, ordernumber)
VALUES(7, 35, 1400, 5758, 4);
INSERT INTO tb_orderdetails (productcode, quantityordered, priceeach, orderlinenumber, ordernumber)
VALUES(8, 40, 1600, 5758, 5);

-- Insert data orders
INSERT INTO tb_orders(orderdate, requireddate, shippeddate, status, comments, customernumber)
VALUES('2010-10-10', '2010-10-5', '2010-10-12', 'Done', 'Komen', 1);
INSERT INTO tb_orders(orderdate, requireddate, shippeddate, status, comments, customernumber)
VALUES('2020-10-10', '2010-10-5', '2010-10-12', 'Done', 'Komen', 2);
INSERT INTO tb_orders(orderdate, requireddate, shippeddate, status, comments, customernumber)
VALUES('2010-10-10', '2010-10-5', '2010-10-12', 'Done', 'Komen', 3);
INSERT INTO tb_orders(orderdate, requireddate, shippeddate, status, comments, customernumber)
VALUES('2010-10-10', '2010-10-5', '2010-10-12', 'Done', 'Komen', 4);
INSERT INTO tb_orders(orderdate, requireddate, shippeddate, status, comments, customernumber)
VALUES('2010-10-10', '2010-10-5', '2010-10-12', 'Done', 'Komen', 5);

-- Insert data customers
INSERT INTO tb_customers (customername, contactlastname, contactfirstname, phone, addressline1, addressline2, city, state, postalcode, country, salesrepemployeenumber, creditlimit)
VALUES ('Agus001', 'lastname', 'firstname', '08191236768', 'address1', 'address2', 'Jakarta', 'DKI Jakarta', '121001', 'Indonesia', 1, 850000);
INSERT INTO tb_customers (customername, contactlastname, contactfirstname, phone, addressline1, addressline2, city, state, postalcode, country, salesrepemployeenumber, creditlimit)
VALUES ('Zack002', 'lastname', 'firstname', '08191236768', 'address1', 'address2', 'Jakarta', 'DKI Jakarta', '121001', 'Indonesia', 2, 850000);
INSERT INTO tb_customers (customername, contactlastname, contactfirstname, phone, addressline1, addressline2, city, state, postalcode, country, salesrepemployeenumber, creditlimit)
VALUES ('Jennifer003', 'lastname', 'firstname', '08191236768', 'address1', 'address2', 'Jakarta', 'DKI Jakarta', '121001', 'Indonesia', 3, 850000);
INSERT INTO tb_customers (customername, contactlastname, contactfirstname, phone, addressline1, addressline2, city, state, postalcode, country, salesrepemployeenumber, creditlimit)
VALUES ('Tom Hardy004', 'lastname', 'firstname', '08191236768', 'address1', 'address2', 'Jakarta', 'DKI Jakarta', '121001', 'Indonesia', 1, 850000);
INSERT INTO tb_customers (customername, contactlastname, contactfirstname, phone, addressline1, addressline2, city, state, postalcode, country, salesrepemployeenumber, creditlimit)
VALUES ('Liana005', 'lastname', 'firstname', '08191236768', 'address1', 'address2', 'Jakarta', 'DKI Jakarta', '121001', 'Indonesia', 2, 850000);

-- Insert data payments
INSERT INTO tb_payments (customernumber, paymentdate, amount)
VALUES (1,'2010-10-11', 250000);
INSERT INTO tb_payments (customernumber, paymentdate, amount)
VALUES (2,'2010-10-11', 250000);
INSERT INTO tb_payments (customernumber, paymentdate, amount)
VALUES (3,'2010-10-11', 250000);
INSERT INTO tb_payments (customernumber, paymentdate, amount)
VALUES (1,'2010-10-11', 250000);
INSERT INTO tb_payments (customernumber, paymentdate, amount)
VALUES (2,'2010-10-11', 250000);

-- Insert data employees
INSERT INTO tb_employees (lastname, firstname, extension, email, officecode, jobtitle)
VALUES('Doe', 'Jon', 'extensionnih', 'jondoe@gmail.com', 1, 'CEO');
INSERT INTO tb_employees (lastname, firstname, extension, email, officecode, reportsto, jobtitle)
VALUES('Unj', 'Jen', 'extensionnih', 'jenunj@gmail.com', 2, 1, 'Officer');
INSERT INTO tb_employees (lastname, firstname, extension, email, officecode, reportsto, jobtitle)
VALUES('Uly', 'Feb', 'extensionnih', 'febuly@gmail.com', 3, 2, 'Internship');

-- Insert data offices
INSERT INTO tb_offices (city, phone, addressline1, addressline2, state, country, postalcode, territory)
VALUES('Jakarta', '021021', 'adline1', 'adline2', 'DKI Jakarta', 'Indonesia', '12001', '62');
INSERT INTO tb_offices (city, phone, addressline1, addressline2, state, country, postalcode, territory)
VALUES('Jakarta', '021021', 'adline1', 'adline2', 'DKI Jakarta', 'Indonesia', '12001', '62');
INSERT INTO tb_offices (city, phone, addressline1, addressline2, state, country, postalcode, territory)
VALUES('Jakarta', '021021', 'adline1', 'adline2', 'DKI Jakarta', 'Indonesia', '12001', '62');

-- Verivy tabel one by one
SELECT * FROM tb_customers;
SELECT * FROM tb_employees;
SELECT * FROM tb_offices;
SELECT * FROM tb_orderdetails;
SELECT * FROM tb_orders;
SELECT * FROM tb_payments;
SELECT * FROM tb_productlines;
SELECT * FROM tb_products;

-- Menampilkan data product dengan productlines
SELECT * FROM tb_products JOIN tb_productlines ON tb_products.productline = tb_productlines.productline;

-- Menampilkan order yang dilakukan customer serta payments yang dilakukan
SELECT a.ordernumber, a.status, b.customernumber, b.customername, c.paymentdate, c.amount
FROM tb_orders a JOIN tb_customers b ON a.customernumber = b.customernumber 
JOIN tb_payments c ON b.customernumber = c.customernumber;
--NOTE : Agus dan Zack melakukan 2 kali order.

-- Menampilkan data dengan FULL JOIN
SELECT a1.customernumber, a1.customername , a2.employeenumber, a2.firstname ,a3.officecode, a3.city , a4.checknumber, 
a5.ordernumber, a6.idorderdetails, a7.productcode, a8.productline  FROM tb_customers a1 
FULL JOIN tb_employees a2 ON a1.salesrepemployeenumber  = a2.employeenumber
FULL JOIN tb_offices a3 ON a3.officecode = a2.officecode
FULL JOIN tb_payments a4 ON a4.customernumber = a1.customernumber 
FULL JOIN tb_orders a5 ON a5.customernumber = a1.customernumber 
FULL JOIN tb_orderdetails a6 ON a6.ordernumber = a5.ordernumber 
FULL JOIN tb_products a7 ON a7.productcode = a6.productcode 
FULL JOIN tb_productlines a8 ON a8.productline = a7.productline;

-- Menampilkan data karyawan yang bertitle CEO serta data officenya
SELECT a.employeenumber, a.firstname, a.jobtitle, b.officecode, b.city 
FROM tb_employees a JOIN tb_offices b ON a.officecode = b.officecode
WHERE a.jobtitle = 'CEO';

-- Menampilkan produk yang laku
SELECT a.productcode, a.productname, b.ordernumber, b.quantityordered, b.priceeach 
FROM tb_products a RIGHT JOIN tb_orderdetails b ON a.productcode = b.productcode;







CREATE TABLE CALOGIN(LID INT PRIMARY KEY,Username varchar(20),Password varchar(20)); 
CREATE TABLE CAREG(USID INT primary key,Username varchar(20),Password varchar(20),Repassword varchar(20),Emailid varchar(20),Mobileno number(10));
drop table CALOGIN;
select * from CAREG;
INSERT INTO CALOGIN VALUES(2,'anbu','123');   
select * from CALOGIN;
SELECT count(*) from CALOGIN;
SELECT count(*) from CALOGIN where USERNAME ='anbu'AND PASSWORD ='123'; 
Select distinct vehicleid from transport;
select * from transport;
select * from shipment;
select transporttype,DRIVERNAME,DRIVERMOBILE,GOODSPRODUCT,STARTING,SHIPMENT,DELIVERY,ENDING,DESTINATIONADDRESS,SHIPMENTID from(select VEHICLEID,transporttype,DRIVERNAME,DRIVERMOBILE,GOODSPRODUCT,STARTING,shipment,DELIVERY,ENDING,DESTINATIONADDRESS,SHIPMENTID from transport left outer join shipment on VEHICLEID=VEHICLEID_FK)where  VEHICLEID='105'

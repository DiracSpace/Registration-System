create database basededatos2;
drop database basededatos2;
use basededatos2;
create table informacion (
	idcliente int not null auto_increment, 
    nomcliente text, 
    primeroA text, 
    segundoA text, 
    edad int, 
    correo text, 
    ruta text, 
    verify text, 
    truth boolean not null default '0', 
    primary key(idcliente)
); 
update informacion set truth = 1 where idcliente = 1;
select * from informacion;
select * from informacion where nomcliente = "Wes";
delete from informacion where idcliente = "1";
select max(idcliente) from informacion;
alter table informacion auto_increment = 0;
drop table informacion;
select nomcliente, primeroA, segundoA, edad from informacion where idcliente = 9; 
alter table informacion add column ruta text after correo;
alter table informacion add column correo text after edad;
alter table informacion add column imagenes mediumblob after ruta;
alter table informacion drop column imagenes;
alter table informacion add column verify text after ruta;
select verify from informacion where idcliente = 3;
/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     5/7/2022 6:28:30 PM                          */
/*==============================================================*/


drop table if exists Categoria;

drop table if exists CategoriaProducto;

drop table if exists Cliente;

drop table if exists Distribuidor;

drop table if exists Factura;

drop table if exists MetodoPago;

drop table if exists Trabajadores;

drop table if exists Usuario;

drop table if exists administrador;

drop table if exists carroCompra;

/*==============================================================*/
/* Table: Categoria                                             */
/*==============================================================*/
create table Categoria
(
   idCategoria          int not null auto_increment,
   nombre               varchar(254),
   primary key (idCategoria)
);

/*==============================================================*/
/* Table: CategoriaProducto                                     */
/*==============================================================*/
create table CategoriaProducto
(
   idCatProd            int not null auto_increment,
   idCategoria          int not null,
   primary key (idCatProd)
);

/*==============================================================*/
/* Table: Cliente                                               */
/*==============================================================*/
create table Cliente
(
   idCliente            int not null auto_increment,
   idCompra             int,
   nombre               varchar(255),
   apellido             varchar(255),
   tarjeta              varchar(255),
   primary key (idCliente)
);

/*==============================================================*/
/* Table: Distribuidor                                          */
/*==============================================================*/
create table Distribuidor
(
   rutDistribuidor      varchar(254) not null,
   nombreEmpresa        varchar(254),
   anioAntiguedad       int,
   calle                varchar(254),
   numero               varchar(254),
   comuna               varchar(254),
   pais                 varchar(254),
   fono                 int,
   primary key (rutDistribuidor)
);

/*==============================================================*/
/* Table: Factura                                               */
/*==============================================================*/
create table Factura
(
   folio                int not null auto_increment,
   rutDistribuidor      varchar(254) not null,
   idMetodo             int not null,
   precioNeto           float,
   precioIVA            float,
   costoIVA             float,
   fechaCompra          datetime,
   primary key (folio)
);

/*==============================================================*/
/* Table: MetodoPago                                            */
/*==============================================================*/
create table MetodoPago
(
   idMetodo             int not null auto_increment,
   nombre               varchar(254),
   primary key (idMetodo)
);

/*==============================================================*/
/* Table: Trabajadores                                          */
/*==============================================================*/
create table Trabajadores
(
   idTrabajador         int not null auto_increment,
   nombre               varchar(254),
   apaterno             varchar(254),
   amaterno             varchar(254),
   primary key (idTrabajador)
);

/*==============================================================*/
/* Table: Usuario                                               */
/*==============================================================*/
create table Usuario
(
   idUsuario            int not null auto_increment,
   idEstado             int,
   idCliente            varchar(254),
   contrasena           varchar(254),
   correo               varchar(255),
   primary key (idUsuario)
);

/*==============================================================*/
/* Table: administrador                                         */
/*==============================================================*/
create table administrador
(
   idAdmin              int not null auto_increment,
   idUsuario            int not null,
   contrasena           int not null,
   correo               int,
   primary key (idAdmin)
);

/*==============================================================*/
/* Table: carroCompra                                           */
/*==============================================================*/
create table carroCompra
(
   idCompra             int not null auto_increment,
   lista                int not null,
   nroSerie             int not null,
   precio               int,
   primary key (idCompra)
);

alter table CategoriaProducto add constraint FK_Association_6 foreign key (idCategoria)
      references Categoria (idCategoria) on delete restrict on update restrict;

alter table Cliente add constraint FK_Reference_10 foreign key (idCompra)
      references carroCompra (idCompra) on delete restrict on update restrict;

alter table Factura add constraint FK_Association_24 foreign key (rutDistribuidor)
      references Distribuidor (rutDistribuidor) on delete restrict on update restrict;

alter table Factura add constraint FK_Association_25 foreign key (idMetodo)
      references MetodoPago (idMetodo) on delete restrict on update restrict;

alter table Usuario add constraint FK_Reference_35 foreign key (idEstado)
      references Cliente (idCliente) on delete restrict on update restrict;

alter table administrador add constraint FK_Association_1 foreign key (contrasena)
      references Trabajadores (idTrabajador) on delete restrict on update restrict;

alter table administrador add constraint FK_Association_2 foreign key (idUsuario)
      references Usuario (idUsuario) on delete restrict on update restrict;

alter table administrador add constraint FK_Reference_9 foreign key (correo)
      references CategoriaProducto (idCatProd) on delete restrict on update restrict;

alter table carroCompra add constraint FK_Association_22 foreign key (nroSerie)
      references Usuario (idUsuario) on delete restrict on update restrict;

alter table carroCompra add constraint FK_Association_23 foreign key (lista)
      references Factura (folio) on delete restrict on update restrict;


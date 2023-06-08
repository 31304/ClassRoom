

--create table systemUser (username varchar(50) primary key(username),password varchar(20),role varchar(14));
create table ClassRoom(code varchar(50) primary key(code),username varchar(40) not null,name varchar(30)  not null, imagepath varchar(300));
create table StudentClassRoom (username varchar(50) foreign key(username) references systemUser(username) on delete cascade,code varchar(50) foreign key(code)references ClassRoom(code)  on delete cascade);
create table Assingment (id int IDENTITY(1,1) primary key(id), title varchar(100),discription varchar(500),date varchar(50), code varchar(50) foreign key(code) references ClassRoom(code) on delete cascade,filepath varchar(300));
create table ClassMaterial (id int IDENTITY(1,1) primary key(id), title varchar(100),discription varchar(500), code varchar(50) foreign key(code) references ClassRoom(code) on delete cascade,filepath varchar(300));
create table Announcement (id int IDENTITY(1,1) primary key(id), title varchar(100), discription varchar(500),code varchar(50) foreign key(code) references ClassRoom(code) on delete cascade);
Create table submitAssignment (id int IDENTITY(1,1) primary key(id), username varchar(50) foreign key(username) references systemUser(username) on delete cascade, assignmentid int foreign key(assignmentid) references Assingment(id)on delete cascade,submitTime varchar(50), submitDate varchar(50),filepath varchar(400) );
 Create table grade (id int IDENTITY(1,1) primary key (id) , username varchar(50) foreign key(username) references systemUser(username) on delete cascade,  assignmentno int ,assignmentid int ,text varchar(30));




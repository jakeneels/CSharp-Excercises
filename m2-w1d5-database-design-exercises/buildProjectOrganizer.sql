
CREATE TABLE department
(
	departmentID int identity(1,1) not null,
	name varchar(64) not null,

	constraint pk_ID1 primary key (departmentID),
);

CREATE TABLE project
(
	projectID int identity(1,1) not null,
	name varchar(128),
	start_date date not null,
	departmentID int not null,

	constraint pk_ID2 primary key (projectID),
	constraint fk_departmentID foreign key (departmentID) references department(departmentID),
);

CREATE TABLE employee
(
	ID int identity(1,1) not null,
	title varchar(128) not null,
	name_last varchar(32) not null,
	name_first varchar(32) not null,
	gender varchar(32),
	birthday date not null,
	hire_date date not null,
	departmentID int,
	projectID int,

	constraint pk_ID3 primary key (ID),
	constraint fk_departmentID2 foreign key (departmentID) references department(departmentID),
	constraint fk_projectID2 foreign key (projectID) references project(projectID),
	constraint chk_birthday2 check (birthday < getDate())
);

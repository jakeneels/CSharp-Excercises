
insert into department( name)
values('Human Relations')
insert into department( name)
values('Marketing')
insert into department( name)
values('Production')
insert into department( name)
values('Accounting')

insert into project( name, start_date, departmentID)
									values('Operation Wrath Hog', convert(date, '2014-08-21'), 2) -- 1
insert into project( name, start_date, departmentID)
										values('Operation Leprecorn Trap', convert(date, '2016-02-13'), 4) --2
insert into project( name, start_date, departmentID) 
									values('Operation Amish Jam', convert(date, '2014-03-29'), 4) -- 3
insert into project( name, start_date, departmentID)
										values('Operation Voodoo Clam', convert(date, '2017-10-01'), 3) --4
insert into project( name, start_date, departmentID)
										values('Operation Solar Cheese', convert(date, '2017-06-17'), 3) --5
insert into project( name, start_date, departmentID)
										values('Operation Florished Pinky', convert(date, '2011-06-17'), 1) --6

insert into employee(title, name_first, name_last, gender, birthday, hire_date, departmentID)
values('Reports Dress Code Violations', 'Alanis', 'Morisette', 'female', convert(date,'1976-05-20'), convert(date, '2016-09-10'), 1)
insert into employee(title, name_first, name_last, gender, birthday, hire_date, departmentID)
values('PowerPoint Guru', 'Seth', 'Rogan', 'male', convert(date,'1988-10-12'), convert(date, '2016-01-22'), 1)
insert into employee(title, name_first, name_last, gender, birthday, hire_date, departmentID)
values('Skin-Tight Neoprene Vest Wearer', 'Burt', 'Reynolds', 'manly', convert(date,'1969-03-22'),  convert(date, '2017-06-11'), 2)
insert into employee(title, name_first, name_last, gender, birthday, hire_date, departmentID)
values('Rolls Jean Legs Up', 'Reginald', 'HammerCock', 'male', convert(date,'1990-01-11'),  convert(date, '2013-12-22'), 2)
insert into employee(title, name_first, name_last, gender, birthday, hire_date, departmentID)
values('Spends Most of the Day on FB, Considered Leadership Material by Upper Management', 'Michael', 'Vick', 'male', convert(date,'1992-06-09'),  convert(date, '2016-09-10'), 3)
insert into employee(title, name_first, name_last, gender, birthday, hire_date, departmentID)
values('Sold Soul for Last Promotion', 'Harry', 'Potter', 'male', convert(date,'1970-02-04'), convert(date, '2016-09-10'), 3)
insert into employee(title, name_first, name_last, gender, birthday, hire_date, departmentID)
values('Was Absolutely Terrible in his Last Starwars Film', 'Harrison', 'Ford', 'male', convert(date,'1965-03-25'), convert(date, '2012-11-10'), 3)
insert into employee(title, name_first, name_last, gender, birthday, hire_date, departmentID)
values('Longs to Fulfil his Dream of being a SQL Admin', 'Jake', 'Neels', 'male', convert(date,'1990-05-20'), convert(date, '2014-6-10'), 3)
insert into employee(title, name_first, name_last, gender, birthday, hire_date, departmentID)
values('Married to Bosses Niece', 'Liam', 'Neeson', 'male', convert(date,'1981-06-19'), convert(date, '2013-05-10'), 4)
insert into employee(title, name_first, name_last, gender, birthday, hire_date, departmentID)
values('Dao of Bad Movies', 'Steven', 'Seagul', 'female', convert(date,'1970-02-04'), convert(date, '2014-02-10'), 4)
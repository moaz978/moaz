create database task 
use task

create table members
(

user_id int primary key,

user_name nvarchar(50),
user_password nvarchar (50),
user_gmail nvarchar(50) ,
user_role nvarchar (50)

)

create table Tasks 
(
taske_id int primary key ,
task_title nvarchar (50),
task_descrip nvarchar (50),
task_status nvarchar (50),
task_duedate datetime 
)

insert into members values(1,'moaz',972,'moaz@gmail.com','manager'),
(2, 'emp1' ,123,'emp1@gmail.com','employee'),
(3,'admin',972,'moaz@gmail.com','manager')
alter table tasks add employee_name nvarchar (50)

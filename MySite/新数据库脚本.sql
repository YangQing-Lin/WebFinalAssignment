create database StudentCourseManagementSystem
go
use StudentCourseManagementSystem
go
--create database test
--go
--use test
--go


--管理员信息
create table AdminInfo
(
id nvarchar(20) not null primary key,--编号
Name nvarchar(20) not null,--姓名
Pwd nvarchar(50) not null,--密码
)
go
insert into AdminInfo values('admin','admin','123')
go


--学生信息
create table StudentInfo
(
Sno int not null primary key,--学号
Name nvarchar(50) not null,--姓名
Sex nvarchar(5) not null,--性别
Sclass nvarchar(50) not null,--所在班级
Sdept nvarchar(50) not null,--所在院系
Stime int not null,--入学年份
)
go
insert into StudentInfo values(1,'林晴川','男','19计算机二班','大数据与人工智能学院',2019)
go


--课程信息表
create table CourseInfo
(
Cno int not null primary key,--课程号
CType nvarchar(50) not null,--课程类型
CName nvarchar(50) not null,--课程名称
TName nvarchar(50) not null,--教师
CTime int not null,--学时
CAchievement int not null,--课程成绩
)
go
insert into CourseInfo values(1,'工科','Web系统开发','lys',16,100)
go


--学生、课程组合表
create table SC
(
Sno int foreign key references StudentInfo(Sno),--学号(外键约束)
Cno int foreign key references CourseInfo(Cno),--课程号(外键约束)
Grade int,--课程等级
primary key(Sno, Cno),--设置Sno和Cno的属性组为主键
)
go
insert into SC values(1,1,3)
go
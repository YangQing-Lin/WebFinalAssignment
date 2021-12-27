create database MyDb
go
use MyDb
go
--用户信息
create table UserInfo
(
id nvarchar(20) not null primary key,--编号
Name nvarchar(20) not null,--姓名
Pwd nvarchar(50) not null,--密码
Sex nvarchar(5) not null--性别
)
go

insert into userInfo values('admin','admin','123456',N'男')
go

--电梯安全检修
create table SafeInfo
(
id int identity(1,1) not null primary key, --主键
Name nvarchar(100) not null,--电梯
Jxnr nvarchar(500) not null,--检修内容
Jxrq DATETIME not null,--检修日期
Jxr NVARCHAR(20) not null  --检修人
)
go


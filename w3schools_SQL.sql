--LessonCategories(LessonCateId,LessonCateName,DateCreated, DateModified, CreatedBy, ModifiedBy)

--Lessons(LessonId,LessonCateId, LessonName, DateCreated, DateModified, CreatedBy, ModifiedBy)

--LessonContents(LessonContentId,LessonContentName, ContentTypeId,Content, DateCreated,DateModified, CreatedBy, ModifiedBy)

--ContentTypes(ContentTypeId,ContentTypesName, DateCreated, DateModified, CreatedBy, ModifiedBy) 

--User(UserId, UserName, Password, Salt,RoleId, DateCreated, DateModified, CreatedBy, ModifiedBy)

--Roles(RoleId,RoleName, DateCreated, DateModified, CreatedBy, ModifiedBy)


create database W3schoolsCss
use W3schoolsCss
create table LessonCategories(
	LessonCateId int IDENTITY(1,1) primary key,
	LessonCateName nvarchar(100),
	DateCreated DateTime default GetDate(),
	DateModified datetime default GetDate(),
	CreatedBy nvarchar(50),
	ModifiedBy nvarchar(50)
)

create table Lessons(
	LessonId int Identity(1,1) primary key,
	LessonCateId int FOREIGN KEY (LessonCateId) REFERENCES LessonCategories(LessonCateId),
	LessonName nvarchar(100),
	DateCreated DateTime default GetDate(),
	DateModified datetime default GetDate(),
	CreatedBy nvarchar(50),
	ModifiedBy nvarchar(50)
	)

create table ContentTypes(
	ContentTypeId int Identity(1,1) primary key,
	LessonId int FOREIGN KEY (LessonId) REFERENCES Lessons(LessonId)
	ContentTypeName nvarchar(100),
	Descriptions nvarchar(200),
	DateCreated DateTime default GetDate(),
	DateModified datetime default GetDate(),
	CreatedBy nvarchar(50),
	ModifiedBy nvarchar(50)
)

create table LessonContents(
	LessonContentId int Identity(1,1) primary key,
	ContentTitle nvarchar(100),
	ContentTypeId int foreign key (ContentTypeId) references ContentTypes(ContentTypeId),
	Content nvarchar(max),
	ContentOrder int,
	DateCreated DateTime default GetDate(),
	DateModified datetime default GetDate(),
	CreatedBy nvarchar(50),
	ModifiedBy nvarchar(50)
)

create table Roles(
	RoleId int identity(1,1) primary key, 
	RoleName nvarchar(50),
	DateCreated DateTime default GetDate(),
	DateModified datetime default GetDate(),
	CreatedBy nvarchar(50),
	ModifiedBy nvarchar(50)
)

create table Users(
	UserId int identity(1,1) primary  key, 
	UserName nvarchar(100),
	RoleId int FOREIGN KEY (RoleId) REFERENCES Roles(RoleId),
	PassWord nvarchar(50),
	Salt nvarchar(100),
	DateCreated DateTime default GetDate(),
	DateModified datetime default GetDate(),
	CreatedBy nvarchar(50),
	ModifiedBy nvarchar(50)
)


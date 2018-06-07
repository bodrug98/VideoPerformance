
create database videoWorld
use videoWorld
go


create table producatori(
	id int primary key,
	name varchar(10)
)
create table cards(
	Id int not null primary key,
	Name varchar(50) not null,
	Descr text not null,
	GpuArhitecture varchar(20),
	FrameBufer     varchar(20),
	Memory int ,
	BoostClock int,
	img varchar(30) not null,
	idProd int foreign key references producatori(id),
	pret real default 0

)



create table users(
	Id int primary key identity,
	loginn varchar(15) not null,
	email varchar(30) not null,
	nickname varchar(15) not null,
	pass  varchar(10) not null,
	basket varchar(20) default '' ,
	foto varchar(50)
	
)

create table commands(
	Id int primary key identity,
	IdUser int foreign key references users(Id),
	Produse varchar(100) default '',
	Data date,
	Adresa varchar(150) default ''
)

insert into users(loginn,email,nickname,pass,foto) values ('bodrug123','bodrug-99@mail.ru','BodrugMihail','1234','FirtstApp.Properties.Resources.userAvatar1')


insert into producatori values(1,'nVidia')
insert into producatori values(2,'AMD')


insert into cards values(1,'Geforce GTX 1080 Ti', 'The GeForce GTX 1080 Ti Founders Edition is truly unique. Designed and built by NVIDIA. Crafted with premium materials and components, including a die-cast aluminum body and 7-phase dualFET power supply. And cooled by a radial fan with an advanced vapor chamber designed for consistent performance in even the most thermally challenging environments.',
							'Pascal','11 GB GDDR5X',11,1582,'Images/1.png',1,1000)
insert into cards values(2,'Geforce GTX 1080', 'GeForce GTX 10-series graphics cards are powered by Pascal to deliver up to 3x the performance of previous-generation graphics cards, plus innovative new gaming technologies and breakthrough VR experiences.',
							'Pascal','8 GB GDDR5X',10,1733,'Images/2.png',1,870)
							
insert into cards values(3,'Geforce GTX 1070 Ti', 'Take on today''s most challenging, graphics-intensive games without missing a beat. The GeForce GTX 1070 Ti and GeForce GTX 1070 graphics cards deliver the incredible speed and power of NVIDIA Pascal, the most advanced gaming GPU architecture ever created. This is the ultimate gaming platform. #GameReady.',
							'Pascal 2432','8 GB GDDR5',8,1683,'Images/3.png',1,800)		
insert into cards values(4,'Geforce GTX 1070', 'Take on today''s most challenging, graphics-intensive games without missing a beat. The GeForce GTX 1070 Ti and GeForce GTX 1070 graphics cards deliver the incredible speed and power of NVIDIA Pascal, the most advanced gaming GPU architecture ever created. This is the ultimate gaming platform. #GameReady.',
							'Pascal 1920','8 GB GDDR5',8,1683,'Images/4.png',1,815)	
insert into cards values(5,'Geforce GTX 1060', 'The GeForce GTX 1060 graphics card is loaded with innovative new gaming technologies, making it the perfect choice for the latest high-definition games. Powered by NVIDIA Pascal™—the most advanced GPU architecture ever created—the GeForce GTX 1060 delivers brilliant performance that opens the door to virtual reality and beyond. #GameReady',
							'Pascal 1280','6 GB GDDR5',8,1708,'Images/5.png',1,713)		
insert into cards values(6,'Geforce GTX 1050 Ti', 'Everyone deserves great gaming. That''s why we created the fast, powerful GeForce GTX 1050. Now, you can turn your PC into a true gaming rig, powered by NVIDIA Pascal™—the most advanced gaming GPU architecture ever created. It''s loaded with innovative NVIDIA Game Ready technologies that let every gamer experience the latest titles in their full glory. #GameReady.',
							'Pascal 768','4 GB GDDR5',7,1392,'Images/6.png',1,723)		
insert into cards values(7,'Geforce GTX 1050', 'Everyone deserves great gaming. That''s why we created the fast, powerful GeForce GTX 1050. Now, you can turn your PC into a true gaming rig, powered by NVIDIA Pascal™—the most advanced gaming GPU architecture ever created. It''s loaded with innovative NVIDIA Game Ready technologies that let every gamer experience the latest titles in their full glory. #GameReady.',
							'Pascal 640','2 GB GDDR5',7,1455,'Images/7.png',1,600)										
insert into cards values(8,'NVIDIA TITAN Xp Collector''s Edition', 'Harness the power of the ultimate GPUs for the ultimate Star Wars™ fans. Whether you choose the Jedi Order™ or Galactic Empire™, these Collector’s Edition NVIDIA TITAN Xp GPUs give you amazing performance, powered by the award-winning NVIDIA Pascal™ architecture.',
							'Pascal','12 GB GDDRX5',11,1582,'Images/8.png',1,613)	
							
insert into cards values(9,'Radeo RX Vega 64', 'Radeon™ RX Vega graphics are built to deliver exhilarating performance in the newest DirectX® 12 and Vulkan® games.Get the ultimate gaming experience with Radeon ™ RX Vega 64 and Radeon™ FreeSync Technology.',
							'HBM2','8 GB GDDR5',8,945,'Images/9.png',2,870)
							







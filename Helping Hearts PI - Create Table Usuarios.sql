use HelpingHearts

create table Usuarios(
	UsuarioID int identity(1,1) primary key,
	Nome nvarchar(64) not null,
	Telefone nvarchar(32) not null,
	Endereco nvarchar(128) not null,
	Tipo nvarchar(20) not null)

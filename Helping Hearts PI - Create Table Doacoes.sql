use HelpingHearts

create table Doacoes(
	UsuarioID int not null,
	DataDoacao DateTime not null,
	TipoDoacao nvarchar(64) not null,
	Entrega nvarchar(32) not null)
	

use HelpingHearts

alter table Doacoes
	add constraint FK_DOACOES_REFERENCES_USUARIOID foreign key (UsuarioID)
		references Usuarios (UsuarioID)
	go
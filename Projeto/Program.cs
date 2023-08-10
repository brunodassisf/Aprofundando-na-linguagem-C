//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A night at the opera");

//Musica musica1 = new Musica(queen, "Love of my live")
//{
//    Duracao = 213,
//    Disponivel = true
//};


//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false
//};

//musica1.ExibirDetalheMusica();
//musica2.ExibirDetalheMusica();

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);

//albumDoQueen.ExibirMusicasDoAlbum();
//queen.AdicionarAlbum(albumDoQueen);
//queen.ExibirDiscografia();


Episodio ep1 = new Episodio("Começando bem", 2, 200);

ep1.AdicionarConvidados("Bruno");
ep1.AdicionarConvidados("Fulano");

Episodio ep2 = new Episodio("Boas práticas", 1, 220);

ep2.AdicionarConvidados("Bruno");
ep2.AdicionarConvidados("Fulano");

Podcast pod1 = new Podcast("Papo de T.I", "Admin");

pod1.AdicionarEpsodio(ep1);
pod1.AdicionarEpsodio(ep2);
pod1.ExibirDetalhes();
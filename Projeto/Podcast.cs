class Podcast
{

    List<Episodio> listaEpisodios = new List<Episodio>();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpsodios => listaEpisodios.Count;

    public void AdicionarEpsodio(Episodio episodio)
    {
        listaEpisodios.Add(episodio);

    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        Console.WriteLine("Lista de episodios:\n");
        foreach (var ep in  listaEpisodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(ep.Resumo);
        }
        Console.WriteLine($"\n\nEste podcast possui {TotalEpsodios} episódios");
    }

}


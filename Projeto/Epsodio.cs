class Episodio
{

    List<string> convidadosDoEpisodio = new List<string>();

    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo =>  $"{Ordem}. {Titulo} ({Duracao} min) - Convidados: {string.Join(", ", convidadosDoEpisodio)} ";
        


    public void AdicionarConvidados(string convidado)
    {
        convidadosDoEpisodio.Add(convidado);
    }
}
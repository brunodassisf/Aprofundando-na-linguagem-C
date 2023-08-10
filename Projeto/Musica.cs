
class Musica
{
    public Musica(Banda artista, string? nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string? Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    
    // Arrow Function esta retornando apenas o valor como se houvesse um 'return', no C# isso se chama Lambda.
    public string DescricaoResumida => $"A música {Nome} pertence ao artista {Artista}";

    public void ExibirDetalheMusica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}s");
        if (Disponivel)
        {
            Console.WriteLine("Está música está disponível na playList\n");
        }
        else
        {
            Console.WriteLine("Está música Não está disponível na playList\n");
        }
    }
}
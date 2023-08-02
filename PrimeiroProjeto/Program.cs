// Screen Sound
// C# -> Fortemente tipado.

// variavel iniciando com letra minuscula, camelCase.
using Microsoft.Win32;

string msgBoasVindas = "Bem-vindo, Essa é uma API de bandas";
// List<string> listaDeBandas = new List<string> {"Capital Inicial", "Lergião Urbana"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 6, 8 });
bandasRegistradas.Add("AC/DC", new List<int>());

// nomes de funções usando PascalCase.
void ExibirLogo()
{
    // usar @ no inicio da string se chama Verbatim Literal, dando a possibilidade de colcoar a string do jeito que ela é.
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░");
    Console.WriteLine(msgBoasVindas);
    ExibirOpcoesDoMenu();
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDaBanda();
            break;
        case 0:
            Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;

    }

}

// 1
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirLogo();
}

// 2
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Mostrar Bandas registradas");
    foreach (var banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
}

// 3
void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma Banda");
    Console.WriteLine("Digite o nome da Banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        BandaNaoEncontrado(nomeDaBanda);
    }
}

// 4
void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Digite uma banda para saber a media  de avaliações");
    Console.WriteLine("\nDigite o nome da Banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        double mediaDaBanda = bandasRegistradas[nomeDaBanda].Average();
        Console.WriteLine($"\nA banda {nomeDaBanda} tem uma media de {mediaDaBanda}!");
        Console.WriteLine("\nDigite uma tecla para voltar para o menu... ");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();

    }
    else
    {
        BandaNaoEncontrado(nomeDaBanda);
    }
}

void BandaNaoEncontrado(string banda)
{
    Console.WriteLine($"A banda {banda} não foi encontrada.");
    Console.WriteLine("Digite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}


ExibirLogo();
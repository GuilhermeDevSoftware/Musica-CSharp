string mensagem = "Boas vindas ao Screen Sound";

//List<string> listaDasBandas = new List<string> { "The Beatles", "Nirvarna", "Link Park" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

bandasRegistradas.Add("The Doors", new List<int> { 9, 10});
bandasRegistradas.Add("Nirvana", new List<int>());

void ExibirLogo()
{
    Console.Clear();
    Console.WriteLine(@"
    
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensagem);
}


void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a media de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite sua opcao: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMediaDaBanda();
            break;
        case -1: Console.WriteLine(" Sair. \n Tchau tchau!");
            break;
        default: Console.WriteLine("Opcao inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear(); //Limpa tudo
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!; //Exclamação significa que não permite valor nulo
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); //Da uma pausa em milisegundos
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo Bandas registradas");
    /* for (int i = 0; i < listaDasBandas.Count; i++)
     {
         Console.WriteLine($"Banda: {listaDasBandas[i]}");
     } */

    foreach (string banda in bandasRegistradas.Keys)
        Console.WriteLine($"Banda: {banda}");

    Console.WriteLine();
    Console.WriteLine("Presione qualquer tecla para retornar ao menu. ");
    Console.ReadKey();
    ExibirOpcoesMenu();

}

void ExibirTituloDaOpcao (string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string setas = string.Empty.PadLeft(quantidadeDeLetras, '-'); //Pega o tamanho e coloca um caracter do lado
    Console.WriteLine(setas);
    Console.WriteLine(titulo);
    Console.WriteLine(setas + "\n");
}

void AvaliarUmaBanda()
{
    //digite uma banda que deseja avaliar
    //verificar se a banda existe > atribuir nota
    //Caso contrario, retornar ao menu

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda.");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda)) //Verifica se o nome digitado existe no dicionario
    {
        Console.Write($"Qual nota a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso!");
        Thread.Sleep(2000);
        ExibirOpcoesMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para retornar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesMenu();
    }
}

void ExibirMediaDaBanda(){
    Console.Clear();
    ExibirTituloDaOpcao("Média das bandas.");
    Console.Write("Digite o nome da banda que deseja verificar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDasBandas = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nMédia da banda {nomeDaBanda}: {notasDasBandas.Average()}");
        
        Console.WriteLine("Digite uma tecla para retornar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesMenu();
    }else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não está na lista de bandas!");
        Console.WriteLine("Digite uma tecla para retornar ao menu principal");
        Console.ReadKey();
        ExibirOpcoesMenu();
    }
}

ExibirOpcoesMenu();
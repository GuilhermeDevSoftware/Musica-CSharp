string mensagem = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>();

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
        case 3: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Voce escolheu a opção " + opcaoEscolhida);
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
    Console.WriteLine("Registro de Bandas.");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!; //Exclamação significa que não permite valor nulo
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); //Da uma pausa em milisegundos
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    ExibirLogo();
    Console.WriteLine("Exibindo bandas registradas.");
    for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }
    Console.WriteLine("Presione qualquer tecla para retornar ao menu. ");
    Console.ReadKey();
    ExibirOpcoesMenu();

}

ExibirOpcoesMenu();
void intro()
{   

    Console.Clear();

    System.Console.WriteLine("\nSeja bem vindo(a) ao");
    System.Console.WriteLine(@"
 
██████╗░███╗░░██╗░██████╗░  ██████╗░██████╗░░█████╗░░░░░░██╗███████╗░█████╗░████████╗
██╔══██╗████╗░██║██╔════╝░  ██╔══██╗██╔══██╗██╔══██╗░░░░░██║██╔════╝██╔══██╗╚══██╔══╝
██████╔╝██╔██╗██║██║░░██╗░  ██████╔╝██████╔╝██║░░██║░░░░░██║█████╗░░██║░░╚═╝░░░██║░░░
██╔══██╗██║╚████║██║░░╚██╗  ██╔═══╝░██╔══██╗██║░░██║██╗░░██║██╔══╝░░██║░░██╗░░░██║░░░
██║░░██║██║░╚███║╚██████╔╝  ██║░░░░░██║░░██║╚█████╔╝╚█████╔╝███████╗╚█████╔╝░░░██║░░░
╚═╝░░╚═╝╚═╝░░╚══╝░╚═════╝░  ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝░╚════╝░░░░╚═╝░░░
    ");
}

void menu()
{   
    intro();

    System.Console.WriteLine("Por favor escolha entre as seguintes opções:\n");
    System.Console.WriteLine("Digite 1 para - Jogo de adivinhação;");
    System.Console.WriteLine("Digite 2 para - Gerar números aleatórios;");
    System.Console.WriteLine("Digite 3 para SAIR;");

    System.Console.Write("\nDigite a sua opção agora: ");
    string impString = System.Console.ReadLine()!;
    int imp = int.Parse(impString);

    switch(imp)
    {
        case 1:System.Console.WriteLine("\nVocê escolheu a opção: " + imp);
            jogorng();
            break;
        case 2:System.Console.WriteLine("\nVocê escolheu a opção: " + imp);
            randomNums();
            break;
        case 3:System.Console.WriteLine("\nVocê escolheu a opção: " + imp + "\nMuito obrigado por entrar.\nAté a próxima!");
            break;
        default:System.Console.WriteLine("\nVocê escolheu a opção: " + imp +"\nEsta opção está fora do escopo. Sinto muito.");
            menu();
            break;
    }
}

void jogorng()
{
    Console.Clear();

    System.Console.WriteLine("Com quantos números você quer jogar?");
    int resp = int.Parse(System.Console.ReadLine()!);
    Random numero = new Random();
    int Num = numero.Next(1, resp+1);
    //System.Console.WriteLine("Para teste: O número é: "+Num);

    do
    {
        System.Console.WriteLine("\nDigite um número de 1 a " + resp);
        int chute = int.Parse(System.Console.ReadLine()!);

        if(chute == Num)
        {
            System.Console.WriteLine($"Isso o número era {Num} você venceu o jogo!");
            System.Console.WriteLine("\nPrecione qualquer tecla para continuar.");
            Console.ReadKey();
            break;
        }else if(chute < Num){
            System.Console.WriteLine($"O número é maior que {chute}\n");
        }else if(chute > Num){
            System.Console.WriteLine($"O número é menor que {chute}\n");
        }

    } while (true);

    Console.Clear();

    System.Console.WriteLine("Quer jogar novamente?\nDigite 1 para sim e 0 para não!");
    System.Console.WriteLine("Você está no Jogo da adivinhação.");
    int playAgain = int.Parse(System.Console.ReadLine()!);
    if(playAgain == 0)
    {
        menu();
    }else{
        jogorng();
    }

}

void randomNums()
{
    Console.Clear();

    System.Console.WriteLine("\nQuantos números aleatórios vamos gerar?");
    int resp = int.Parse(System.Console.ReadLine()!);

    System.Console.WriteLine("\nE é com o mínimo de quanto?");
    int min = int.Parse(System.Console.ReadLine()!);
    System.Console.WriteLine("\nE com o valor máximo de?");
    int max = int.Parse(System.Console.ReadLine()!);

    Random numero = new Random();
    System.Console.WriteLine("\nGerando "+resp+" números aleatórios!\n");
    for(int j = 0; j<resp; j++)
    {
        System.Console.WriteLine(numero.Next(min,max+1));
    }

    System.Console.WriteLine("Quer fazer novamente?\nDigite 1 para sim e 0 para não!");
    System.Console.WriteLine("Você está no Gerador de números.");
    int playAgain = int.Parse(System.Console.ReadLine()!);
    if(playAgain == 0)
    {
        menu();
    }else{
        randomNums();
    }
    
}

//intro();
menu();
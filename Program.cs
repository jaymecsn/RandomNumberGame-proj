void intro()
{
    System.Console.WriteLine("Seja bem vindo(a) ao");
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
    System.Console.WriteLine("Por favor escolha entre as seguintes opções:");
    System.Console.WriteLine("Digite 1 para - Jogo de adivinhação");
    System.Console.WriteLine("Digite 2 para - Gerar números aleatórios");
    System.Console.WriteLine("Digite 3 para SAIR\n\n");

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
            break;
    }
}

void jogorng()
{
    System.Console.WriteLine("Com quantos números você quer jogar?");
    int resp = int.Parse(System.Console.ReadLine()!);
    Random numero = new Random();
    int Num = numero.Next(1, resp+1);
    //System.Console.WriteLine("Para teste: O número é: "+Num);

    do
    {
        System.Console.WriteLine("Digite um número de 1 a " + resp);
        int chute = int.Parse(System.Console.ReadLine()!);

        if(chute == Num)
        {
            System.Console.WriteLine("Isso o número era " + Num + " você venceu o jogo!\nAté a próxima!\nTschuss!");
            break;
        }else if(chute < Num){
            System.Console.WriteLine("O número é maior que " + chute);
        }else if(chute > Num){
            System.Console.WriteLine("O número é menor que " + chute);
        }

    } while (true);
}

void randomNums()
{
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
    System.Console.WriteLine("\nObrigado por gerar números conosco.\nAté a próxima!\nTschuss!");
}

intro();
menu();
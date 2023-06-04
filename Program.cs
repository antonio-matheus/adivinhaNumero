﻿// See https://aka.ms/new-console-template for more information

Random aleatorio = new();
int numeroSecreto = aleatorio.Next(1,101);
int tentativas = 9;
int chute = 0;

Console.WriteLine(@"
**********************************************************************

        ███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░
        ████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗
        ██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║
        ██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║
        ██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝
        ╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░
");
Console.WriteLine(@"

                ░██████╗███████╗░█████╗░██████╗░███████╗████████╗░█████╗░
                ██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗
                ╚█████╗░█████╗░░██║░░╚═╝██████╔╝█████╗░░░░░██║░░░██║░░██║
                ░╚═══██╗██╔══╝░░██║░░██╗██╔══██╗██╔══╝░░░░░██║░░░██║░░██║
                ██████╔╝███████╗╚█████╔╝██║░░██║███████╗░░░██║░░░╚█████╔╝
                ╚═════╝░╚══════╝░╚════╝░╚═╝░░╚═╝╚══════╝░░░╚═╝░░░░╚════╝░

*************************************************************************************
");
Console.WriteLine($"\nJogo simples! \nUm número aleatório será sorteado e você precisará adivinhar qual é este número.\n");
Console.WriteLine("Digite -1 para sair");

do
{
    do
    {
        Console.Write("Digite um número de 1 a 100 e tecle [ENTER]: ");
        chute = int.Parse(Console.ReadLine()!);
    } while (chute < -2 && chute > 100);

        if (chute == -1)
    {
        tentativas -= tentativas;
    }
    else if (chute == numeroSecreto)
    {
        Console.WriteLine(@"

********************************  VOCÊ VENCEU   ***************************************

        ██████╗░░█████╗░██████╗░░█████╗░██████╗░███████╗███╗░░██╗░██████╗██╗
        ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝████╗░██║██╔════╝██║
        ██████╔╝███████║██████╔╝███████║██████╦╝█████╗░░██╔██╗██║╚█████╗░██║
        ██╔═══╝░██╔══██║██╔══██╗██╔══██║██╔══██╗██╔══╝░░██║╚████║░╚═══██╗╚═╝
        ██║░░░░░██║░░██║██║░░██║██║░░██║██████╦╝███████╗██║░╚███║██████╔╝██╗
        ╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝

**********************  Você acertou o número secreto!  ********************************

");
        break;
    } 
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior.");
        tentativas--;
        Console.WriteLine($"Você tem {tentativas} tentativas restantes!\n");
    } else
    {
        Console.WriteLine("O número secreto é menor.");
        tentativas--;
        Console.WriteLine($"Você tem {tentativas} tentativas restantes!\n");
    }

    if (tentativas == 0)
    {
        Console.WriteLine(@"
*************************************************************************************

    ███████╗██╗███╗░░░███╗  ██████╗░███████╗  ░░░░░██╗░█████╗░░██████╗░░█████╗░██╗
    ██╔════╝██║████╗░████║  ██╔══██╗██╔════╝  ░░░░░██║██╔══██╗██╔════╝░██╔══██╗██║
    █████╗░░██║██╔████╔██║  ██║░░██║█████╗░░  ░░░░░██║██║░░██║██║░░██╗░██║░░██║██║
    ██╔══╝░░██║██║╚██╔╝██║  ██║░░██║██╔══╝░░  ██╗░░██║██║░░██║██║░░╚██╗██║░░██║╚═╝
    ██║░░░░░██║██║░╚═╝░██║  ██████╔╝███████╗  ╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝██╗
    ╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝  ╚═════╝░╚══════╝  ░╚════╝░░╚════╝░░╚═════╝░░╚════╝░╚═╝

*************************************************************************************

    ");
        break;
    }

} while (true);


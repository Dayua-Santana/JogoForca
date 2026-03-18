/*
Requisitos
    1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
    2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
    assim como as letras erradas.
    3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
    acaba.
    4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
*/


using System;
using System.Security.Cryptography;

class Progam
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirCabecalho();

            string palavraAleatoria = EscolherPalavraAleatoria();

            char[] letrasAcertadas = PreencherLetrasAcertadas(palavraAleatoria);
        }
    }


    static void ExibirCabecalho()
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Jogo da Forca");
        Console.WriteLine("--------------------------------------");
    }

    static string EscolherPalavraAleatoria()
    {
        string[] palavras = [
            "ABACATE",
            "ABACAXI",
            "ACEROLA",
            "AÇAÍ",
            "ARAÇÁ",
            "ABACATE",
            "BACABA",
            "BACURI",
            "BANANA",
            "CAJÁ",
            "CAJU",
            "CARAMBOLA",
            "CUPUAÇU",
            "GRAVIOLA",
            "GOIABA",
            "JABUTICABA",
            "JENIPAPO",
            "MAÇÃ",
            "MANGABA",
            "MANGA",
            "MARACUJÁ",
            "MURICI",
            "PEQUI",
            "PITANGA",
            "PITAYA",
            "SAPOTI",
            "TANGERINA",
            "UMBU",
            "UVA",
            "UVAIA"
        ];

        int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

        string palavraAleatoria = palavras[indiceAleatorio];

        return palavraAleatoria;
    }


    static char[] PreencherLetrasAcertadas(string palavraAleatoria)
    {
        char[] letrasAcertadas = new char[palavraAleatoria.Length];

        for (int caractere = 0; caractere < letrasAcertadas.Length; caractere++)
        {
            letrasAcertadas[caractere] = '_';

        }
        return letrasAcertadas;
    }

    static void ExecutarTentativas(char[] letrasAcertadas, string palavraAleatoria)
    {
        bool jogadorAcertouPalavra = false;
        bool jogadorPerdeu = false;

        int quantidadeErros = 0;

        while (!jogadorAcertouPalavra && !jogadorPerdeu) // ! inverte o valor de um bool
        {
            DesenharForca(quantidadeErros);

            Console.WriteLine("Letras acertadas: " + string.Join("", letrasAcertadas));
            Console.WriteLine("Erros cometidos:" + quantidadeErros);

            Console.Write("\nDigite uma letra: ");
            string? strLetra = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(strLetra))
            {
                Console.WriteLine("Digite um caractere válido.");
                Console.ReadLine();
                continue;
            }

            char letraChute = char.ToUpper(Convert.ToChar(strLetra));
        }
    }
    static void DesenharForca(int quantidadeErros)
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Jogo da Forca");
        Console.WriteLine("---------------------------------");

        if (quantidadeErros == 0)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (quantidadeErros == 1)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (quantidadeErros == 2)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |         |        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (quantidadeErros == 3)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (quantidadeErros == 4)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        else if (quantidadeErros == 5)
        {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |        / \       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
        }

        Console.WriteLine("---------------------------------");
    }

}
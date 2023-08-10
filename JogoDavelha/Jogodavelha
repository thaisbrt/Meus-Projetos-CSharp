namespace jogodavelha
{
    // Projeto feito no inicio do curso sem utilizar matriz
    
    internal class Program
    {
        static void Main(string[] args)
        {
            char p1 = '1', p2 = '2', p3 = '3', p4 = '4', p5 = '5', p6 = '6', p7 = '7', p8 = '8', p9 = '9';
            char caracter;
            int valorjogada;
            string vencedor = "nenhum";
            bool FimDeJogo = false;

            Console.WriteLine("Jogador 1, digite o seu nome: ");
            string jogador1 = Console.ReadLine();

            Console.WriteLine("Jogador 2, digite o seu nome: ");
            string jogador2 = Console.ReadLine();

            while (FimDeJogo != true)
            {

                for (int contador = 1; contador <= 9; contador++)
                {
                    mapaJogo(p1, p2, p3, p4, p5, p6, p7, p8, p9);

                    if (contador % 2 == 1)
                    {
                        caracter = 'X';
                        Console.WriteLine(jogador1 + " escolha a posição que deseja jogar: ");
                        valorjogada = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }

                    else
                    {
                        caracter = 'O';
                        Console.WriteLine(jogador2 + " escolha a posição que deseja jogar: ");
                        valorjogada = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }

                    if (caracter == 'X')
                        switch (valorjogada)
                        {
                            case 1:
                                if (p1 == '1')
                                {
                                    p1 = 'X';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }
                                break;

                            case 2:
                                if (p2 == '2')
                                {
                                    p2 = 'X';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;

                                }
                                break;

                            case 3:

                                if (p3 == '3')
                                {
                                    p3 = 'X';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;

                            case 4:
                                if (p4 == '4')
                                {
                                    p4 = 'X';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;
                            case 5:
                                if (p5 == '5')
                                {
                                    p5 = 'X';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;
                            case 6:
                                if (p6 == '6')
                                {
                                    p6 = 'X';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;
                            case 7:
                                if (p7 == '7')
                                {
                                    p7 = 'X';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }


                                break;
                            case 8:
                                if (p8 == '8')
                                {
                                    p8 = 'X';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;

                            case 9:

                                if (p9 == '9')
                                {
                                    p9 = 'X';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;

                            default:
                                Console.WriteLine("Escreva um número válido.");
                                Console.ReadKey();
                                contador = contador - 1;
                                break;

                        }

                    if (caracter == 'O')
                        switch (valorjogada)
                        {
                            case 1:
                                if (p1 == '1')
                                {
                                    p1 = 'O';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }
                                break;

                            case 2:
                                if (p2 == '2')
                                {
                                    p2 = 'O';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }
                                break;

                            case 3:

                                if (p3 == '3')
                                {
                                    p3 = 'O';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;

                            case 4:
                                if (p4 == '4')
                                {
                                    p4 = 'O';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;
                            case 5:
                                if (p5 == '5')
                                {
                                    p5 = 'O';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;
                            case 6:
                                if (p6 == '6')
                                {
                                    p6 = 'O';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;
                            case 7:
                                if (p7 == '7')
                                {
                                    p7 = 'O';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }
                                break;
                            case 8:
                                if (p8 == '8')
                                {
                                    p8 = 'O';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;

                            case 9:

                                if (p9 == '9')
                                {
                                    p9 = 'O';
                                }
                                else
                                {
                                    retormarJogada(valorjogada);
                                    contador = contador - 1;
                                }

                                break;

                            default:
                                Console.WriteLine("Escreva um número válido.");
                                Console.ReadKey();
                                contador = contador - 1;
                                break;
                        }

                    if (QuemGanha(p1, p2, p3, p4, p5, p6, p7, p8, p9, jogador1, jogador2) == jogador1)
                    {
                        FimDeJogo = true;
                        contador = 9;
                        Console.WriteLine($"Parabéns, {jogador1}, você ganhou o jogo!!");
                        Console.ReadKey();

                    }

                    if (QuemGanha(p1, p2, p3, p4, p5, p6, p7, p8, p9, jogador1, jogador2) == jogador2)
                    {
                        FimDeJogo = true;
                        contador = 9;
                        Console.WriteLine($"Parabéns, {jogador2}, você ganhou o jogo!!");
                        Console.ReadKey();

                    }
                    if (contador == 9 && FimDeJogo == false)
                    {
                        Console.WriteLine("O jogo ficou empatado!!");
                        Console.ReadKey();
                    }

                    Console.Clear();
                }

            }
        }

        static void mapaJogo(char p1, char p2, char p3, char p4, char p5, char p6, char p7, char p8, char p9)
        {
            Console.WriteLine("                   ");
            Console.WriteLine(" " + p1 + " | " + p2 + " | " + p3 + " ");
            Console.WriteLine("----------");
            Console.WriteLine(" " + p4 + " | " + p5 + " | " + p6 + " ");
            Console.WriteLine("----------");
            Console.WriteLine(" " + p7 + " | " + p8 + " | " + p9 + " ");
            Console.WriteLine("                   ");
        }

        static void retormarJogada(int valorjogada)
        {
            Console.WriteLine("Posição já preenchida. Escolha uma casa disponível.");
            Console.ReadLine();
        }

        static string QuemGanha(char p1, char p2, char p3, char p4, char p5, char p6, char p7, char p8, char p9, string jogador1, string jogador2)
        {
            mapaJogo(p1, p2, p3, p4, p5, p6, p7, p8, p9);
            string vencedor = "nenhum";


            if (((p1 == 'X') && (p2 == 'X') && (p3 == 'X'))
        || ((p4 == 'X') && (p5 == 'X') && (p6 == 'X'))
        || ((p7 == 'X') && (p8 == 'X') && (p9 == 'X'))
        || ((p1 == 'X') && (p4 == 'X') && (p7 == 'X'))
        || ((p2 == 'X') && (p5 == 'X') && (p8 == 'X'))
        || ((p3 == 'X') && (p6 == 'X') && (p9 == 'X'))
        || ((p1 == 'X') && (p5 == 'X') && (p9 == 'X'))
        || ((p3 == 'X') && (p5 == 'X') && (p7 == 'X')))

            {
                vencedor = jogador1;
            }

            else if ((((p1 == 'O') && (p2 == 'O') && (p3 == 'O'))
           || ((p4 == 'O') && (p5 == 'O') && (p6 == 'O'))
           || ((p7 == 'O') && (p8 == 'O') && (p9 == 'O'))
           || ((p1 == 'O') && (p4 == 'O') && (p7 == 'O'))
           || ((p2 == 'O') && (p5 == 'O') && (p8 == 'O'))
           || ((p3 == 'O') && (p6 == 'O') && (p9 == 'O'))
           || ((p1 == 'O') && (p5 == 'O') && (p9 == 'O'))
           || ((p3 == 'O') && (p5 == 'O') && (p7 == 'O'))))

            {
                vencedor = jogador2;
            }

            return vencedor;
        }

    }
}




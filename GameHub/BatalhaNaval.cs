using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHub
{
    public class BatalhaNaval
    {

        public void JogoBatalhaNaval()
        {

            string[,] tabuleiro = new string[5, 5];
            int posicao1;
            int posicao2;
            int navios = 2;
            int coluna;
            int linha;
            int tentativa = 0;
            int jogador1 = 0;
            List<string> posicoesJogadas = new List<string>();

            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                posicao1 = rand.Next(5);
                posicao2 = rand.Next(5);
                tabuleiro[posicao1, posicao2] = "Acertou";
            }

            do
            {
                Console.Clear();
                Console.WriteLine("    GUIA  \n" +
                    "Onde C é para COLUNA e L para LINHA\n" +
                    "            C   C   C   C   C \n" +
                    "            0   1   2   3   4 \n" +
                    "           -------------------\n" +
                    "         L  1   1   1   1   1 \n" +
                    "           ---│---│---|---│---\n" +
                    "         L  2   2   2   2   2 \n" +
                    "           ---│---│---|---│---\n" +
                    "         L  3   3   3   3   3 \n" +
                    "           ---│---│---|---│---\n" +
                    "         L  4   4   4   4   4 \n");


                Console.WriteLine("Escolha uma das colunas 0, 1, 2, 3 ou 4 para atacar!");
                coluna = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha uma das linhas 0, 1, 2, 3, 4 para atacar!");
                linha = int.Parse(Console.ReadLine());

                if (posicoesJogadas.Contains(coluna.ToString() + linha.ToString()))
                {
                    try
                    {
                        throw new Exception("Esta posição já foi jogada anteriormente. Escolha outra posição.");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Erro: {e.Message}");
                    }
                }
                else
                {
                    posicoesJogadas.Add(coluna.ToString() + linha.ToString());
                    // Continuar verificando se a posição escolhida contém um navio
                }

                if (tabuleiro[coluna, linha] == "Acertou")
                {
                    navios--;
                    tentativa++;
                    Console.WriteLine($"Você acertou um navio!! Restam {navios} navios.");

                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    //tabuleiro[coluna, linha] = "u";
                }
                else
                {
                    Console.WriteLine($"Você errou! Restam {navios} navios.");
                    tentativa++;
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
            } while (navios > 0);

            Console.WriteLine($"Você destruiu todos os navios!! Total de tentativas: {tentativa}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu anterior e escolher novamente um jogo: ");
            Console.ReadKey();
            Console.Clear();


        }
    }
}

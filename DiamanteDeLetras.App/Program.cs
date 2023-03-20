using System;

namespace DiamanteAlfabeto.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'Z', 'Y', 'Z', 'X' };
            int posicao = 0, esquerda = 0, direita = 0;

            Console.WriteLine("Digite uma letra: ");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());

            // fiz um if pra ver se a entra que o usuario for escolher está no alfabeto, criei duas variaveis direita e esquerda que vao receber essa entra para começar a fazer o desenho
            //localiza qual a posicao da letra escolhida
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (letra == alfabeto[i])
                {
                    posicao = i;
                    direita = i;
                    esquerda = i;
                }
            }
            // parte de cima, linha e coluna 
            for (int linha = 0; linha < posicao; linha++)
            {
                for (int coluna = 0; coluna <= posicao + 26; coluna++)
                {
                    if (direita == coluna && esquerda == coluna)
                    {
                        Console.Write(alfabeto[linha]);
                    }
                    else if (direita == coluna)
                    {
                        Console.Write(alfabeto[linha]);
                    }
                    else if (esquerda == coluna)
                    {
                        Console.Write(alfabeto[linha]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                direita--; esquerda++;
                Console.WriteLine();
            }

            // parte de baixo, linha e coluna
            for (int linha = posicao; linha >= 0; linha--)
            {
                for (int coluna = 0; coluna <= posicao + 26; coluna++)
                {
                    if (direita == coluna && esquerda == coluna)
                    {
                        Console.Write(alfabeto[linha]);
                    }
                    else if (direita == coluna)
                    {
                        Console.Write(alfabeto[linha]);
                    }
                    else if (esquerda == coluna)
                    {
                        Console.Write(alfabeto[linha]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                direita++; esquerda--;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
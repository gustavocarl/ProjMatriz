using System;

namespace ProjMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int[,] matriz = new int[2, 5];
            //Para criar uma matriz é usado int [,] nomeMatriz new int[linha, coluna]
            //Primeira dimensão linha, segunda dimensão coluna

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {//Esse laço controla as linhas
                //Para verificar o tamanho da matriz é passado matriz.GetLength(dimensao), sendo 0 linha e 1 coluna
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {//Esse laço controla as colunas
                    matriz[linha, coluna] = linha * coluna;
                    //Multiplica os valores de linha * coluna;
                    Console.Write($"Matriz [{linha}, {coluna}]: = {matriz[linha, coluna]} ");
                    //Imprime os valores da linha e da coluna 
                }
                Console.WriteLine();
                //Pula linha
            }

            Console.ReadKey();

        }
    }
}

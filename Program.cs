using System;
using System.Linq;

namespace exercicio_logica_programacao8
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Ordenando números

            //    Construa uma função que receberá 10 números inteiros do usuário.Certifique - se de que todos os caracteres que 
            //    foram informados pelo usuário são números e não letras.

            //    Construa outra função que irá ordenar todos os números informados pelo usuário, e imprimir estes 
            //    números de forma ordenada.
            //


            int[] pilha = new int[10];
           
            int menor;
            string varInf;
            int p = 0;
            while (p < 10)
            {
                Console.WriteLine($"Favor informar valor da posição : {p}");
                varInf = Console.ReadLine();
                if (varInf.All(char.IsDigit))
                {
                    pilha[p] = Convert.ToInt32(varInf);
                    p++;
                }

                else
                    Console.WriteLine($"Favor informar somente números.");
            }

            int[] pilhaOrdenada = pilha.OrderByDescending(x => x).ToArray();

            for (int i = 0; i <= 9; i++)
            {
               Console.WriteLine($"Posição {i} ::: valor> {pilhaOrdenada[i]} .");
            }
        }
    }
}


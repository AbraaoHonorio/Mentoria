using System;
using System.Collections;

namespace ListaExerciciosMentoria.MentoriaDia1
{
    class NonoRequisito
    {
        public static void Executar()
        {
            Console.Write("Digite um número para verificar seus antecessores primos: ");
            uint.TryParse(Console.ReadLine(), out uint numero);

            ArrayList listaDivisores = new ArrayList();

            int divisores = 0;
            for (int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    divisores++;
                    listaDivisores.Add(i);
                } 
            }

            if (divisores == 2)
            {
                Console.WriteLine($"{numero} é primo");
            } else
                Console.WriteLine($"{numero} não é primo ");

            Console.Write($"Os divisores de {numero}: ");

            foreach (var num in listaDivisores)
            {
                Console.Write($"{num} ");
            }
        }
    }
}

//Exercício feito com referência no link: https://wagnergaspar.com/exercicio-3-leia-um-numero-x-e-diga-se-ele-e-primo-ou-nao-com-a-linguagem-portugol/

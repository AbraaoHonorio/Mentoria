using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosMentoria.MentoriaDia1
{
    class DecimoRequisito
    {
        public static void Executar()
        {
            static uint mdc (uint a, uint b)
            {
                while(b != 0)
                {
                    uint resto = a % b;
                    a = b;
                    b = resto;
                }
                return a;
            }

            static uint mmc(uint a, uint b)
            {
                return a * (b / mdc(a, b));
            }

            Console.Write("Digite o primeiro número: ");
            uint.TryParse(Console.ReadLine(), out uint numA);

            Console.Write("Digite o segundo número: ");
            uint.TryParse(Console.ReadLine(), out uint numB);

            var resposta = mmc(numA, numB);

            Console.WriteLine($"O MMC de ({numA},{numB}) é: {resposta}");
        }
    }
}

//Exercício feito com referência no link: https://www.blogcyberini.com/2018/03/algoritmo-para-calcular-o-mmc.html
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosMentoria.MentoriaDia1
{
    class SetimoRequisito
    {
        public static void Executar()
        {
            double optativaAvaliacao = 0;
            Console.Write("Você fará avaliação optativa (s/n)?");
            var resposta = Console.ReadLine();
            if (resposta == "s")
            {
                Console.Write("Digite a nota de sua avaliação optativa: ");
                optativaAvaliacao = double.Parse(Console.ReadLine());
            }

            Console.Write("Digite a nota de sua primeira avaliação normal: ");
            double.TryParse(Console.ReadLine(), out double primeiraAvaliacao);

            Console.Write("Digite a nota de sua segunda avaliação normal: ");
            double.TryParse(Console.ReadLine(), out double segundaAvaliacao);


            if (optativaAvaliacao > primeiraAvaliacao)
            {
                primeiraAvaliacao = optativaAvaliacao;
            }
            else
            {
                segundaAvaliacao = optativaAvaliacao;
            }
            
            double media = (primeiraAvaliacao + segundaAvaliacao) / 2;
            Console.WriteLine(media);

            if (media >= 6.0 )
            {
                Console.WriteLine("Aprovado");
            }
            else if (media > 3)
            {
                Console.WriteLine("Exame");
            } else
                Console.WriteLine("Reprovado");           
        }
    }
}

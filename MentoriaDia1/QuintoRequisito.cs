using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExerciciosMentoria.MentoriaDia1
{
    class QuintoRequisito
    {
        public static void Executar()
        {
            Console.Write("Quantas maçãs foram compradas? ");
            int.TryParse(Console.ReadLine(), out int quantidadeComprada);
            
            var valorUnidadeComprada = quantidadeComprada >= 12 ? 0.25 : 0.30;

            double valorTotalCompra = quantidadeComprada * valorUnidadeComprada;
                        
            Console.WriteLine($"Você comprou {quantidadeComprada} maçãs, a R$ {valorUnidadeComprada:F2} cada uma, dando um total de compra de R$ {valorTotalCompra:F2}.");

        }
    }
}

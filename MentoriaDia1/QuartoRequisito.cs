using System;

namespace ListaExerciciosMentoria.MentoriaDia1
{
    class QuartoRequisito
    {
        public static void Executar()
        {
            string resposta;
            Console.Write("Escreva um número: ");
            int.TryParse(Console.ReadLine(), out int num);

            resposta = Math.Abs(num) % 2 == 0 ? "par" : "ímpar";

            Console.WriteLine($"{Math.Abs(num)} é um número {resposta}");
        }
    }
}

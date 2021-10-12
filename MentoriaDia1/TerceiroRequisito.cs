using System;

namespace ListaExerciciosMentoria.MentoriaDia1
{
    class TerceiroRequisito
    {
        public static void Executar()
        {
            string resposta;
            Console.Write("Escreva um número: ");
            int.TryParse(Console.ReadLine(), out int num);
            
            if (num == 0)
            Console.WriteLine("zero");

            resposta = num > 0 ? "positivo" : "negativo";
            
            Console.WriteLine($"{num} é um número {resposta}");
        }
    }
}

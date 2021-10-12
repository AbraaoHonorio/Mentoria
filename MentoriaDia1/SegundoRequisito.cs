using System;

namespace ListaExerciciosMentoria.MentoriaDia1
{
    class SegundoRequisito
    {
        public static void Executar()
        {
            Console.Write("Escreva um número: ");
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine($"O antecessor do seu número escolhido é {num - 1}");
            Console.WriteLine($"O sucessor do seu número escolhido é {num + 1}");
        }
    }
}

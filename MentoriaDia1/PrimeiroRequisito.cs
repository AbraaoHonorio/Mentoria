using System;

namespace ListaExerciciosMentoria.MentoriaDia1
{
    class PrimeiroRequisito
    {
        public static void Executar()
        {
            // Não, um "se" (ou seja, um if) pode vir desacompanhado de um else,
            // como em situações que queira apenas uma única condição ou numa estrutura de ternário, por exemplo

            //Exemplo:

            Console.WriteLine("Digite sua idade");
            int.TryParse(Console.ReadLine(), out int num);

            if (num > 18)
            {
                Console.WriteLine("Você pode dirigir");
            }                
        }
    }
}

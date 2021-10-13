using System;
using System.Collections;

namespace ListaExerciciosMentoria.MentoriaDia1
{
    class SextoRequisito
    {
        public static void Executar()
        {
            Console.Write("Escreva o número de lados do seu polígono: ");
            int.TryParse(Console.ReadLine(), out int quantidadeLados);
            ArrayList lista = new ArrayList();
            double perimetro = 0.0;
            double area;

            for (int i = 1; i <= quantidadeLados; i++)
            {
                Console.Write($"Escreva o lado {i}: ");
                double.TryParse(Console.ReadLine(), out double lado);
                lista.Add(lado);
            }

            switch (quantidadeLados)
            {
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Você escolheu um Triângulo");
                    foreach (double lado in lista)
                    {
                        perimetro += lado;
                    }
                    Console.WriteLine($"O perímetro do Triângulo é: {perimetro}");
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Você escolheu um Quadrado");
                    area = Math.Pow((double)lista[0], 2);
                    Console.WriteLine($"A área do quadrado é: {area}");
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Você escolheu um Pentágono");
                    foreach (double lado in lista)
                    {
                        perimetro += lado;
                    }
                    Console.WriteLine($"O perímetro do Pentágono é: {perimetro}");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Polígono não identificado");
                    break;
            }
        }
    }
}

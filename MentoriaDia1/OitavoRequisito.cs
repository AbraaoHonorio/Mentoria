using System;
using System.Collections.Generic;
using HabitanteModel;
using System.Linq;

namespace ListaExerciciosMentoria.MentoriaDia1
{
    class OitavoRequisito
    {
        public static void Executar()
        {
            List<Habitante> habitantes;
            
            habitantes = new List<Habitante>();

            habitantes.Add(new Habitante("Zezinho", 300, (Enum.CodigoHabitante)1));
            habitantes.Add(new Habitante("Huguinho", 100, (Enum.CodigoHabitante)2));
            habitantes.Add(new Habitante("Lindinha", 250, (Enum.CodigoHabitante)3));
            habitantes.Add(new Habitante("Docinho", 700, (Enum.CodigoHabitante)3));
            habitantes.Add(new Habitante("Tom", 900, (Enum.CodigoHabitante)2));
            habitantes.Add(new Habitante("Jerry", 400, (Enum.CodigoHabitante)1));
            habitantes.Add(new Habitante("Mickey", 230, (Enum.CodigoHabitante)2));
            habitantes.Add(new Habitante("Zé Carioca", 780, (Enum.CodigoHabitante)3));
            habitantes.Add(new Habitante("Minney", 990, (Enum.CodigoHabitante)1));

            List<int> consumoHabitantes = new List<int>();

            var somatorio = 0;

            foreach (var consumo in habitantes)
            {
                consumoHabitantes.Add(consumo.Consumo);
                somatorio += consumo.Consumo;
            }

            List<int> consumoOrdenado = consumoHabitantes.OrderBy(x => x).ToList();
            List<int> consumoOrdenadoDecrescente = consumoHabitantes.OrderByDescending(x => x).ToList();
            var media = somatorio / habitantes.Count;

            Console.WriteLine($"O menor consumo é: {consumoOrdenado[0]}");
            Console.WriteLine($"O maior consumo é: {consumoOrdenadoDecrescente[0]}");
            Console.WriteLine($"A média do consumo é: {media}");
        }
    }
}

//Referências
//http://www.macoratti.net/20/10/c_sortobj3.htm

using System;
using System.Collections.Generic;

using ListaExerciciosMentoria.MentoriaDia1;

namespace ListaExerciciosMentoria
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Requisito 1", PrimeiroRequisito.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
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
                {"Requisito 2", SegundoRequisito.Executar},
                {"Requisito 3", TerceiroRequisito.Executar},
                {"Requisito 4", QuartoRequisito.Executar},
                {"Requisito 5", QuintoRequisito.Executar},
                {"Requisito 6", SextoRequisito.Executar},
                {"Requisito 7", SetimoRequisito.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
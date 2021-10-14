using System;
using Enum;

namespace HabitanteModel
{
    class Habitante
    {
        public Habitante(string nome, int consumo, CodigoHabitante codigo)
        {
            Nome = nome;
            Consumo = consumo;
            Codigo = codigo;
        }

        public string Nome { get; set; }
        public int Consumo { get; set; }
        public CodigoHabitante Codigo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaFormaticaS7
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Cargo { get; set; }

        public Empleado(string Nombre, int Edad, string cargo)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Cargo = cargo;
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre} edad: {Edad} cargo: {Cargo}";
        }


    }

    
}

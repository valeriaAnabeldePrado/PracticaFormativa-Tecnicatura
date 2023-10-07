using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practicaFormaticaS7
{
    internal class Empresa
    {
        public string Nombre { get; set; }
        private Empleado encargado;
        private LinkedList<Empleado> listaEmpleados;
        public Empresa(string nombre, Empleado encargado)
        {
            Nombre = nombre;
            this.encargado = encargado;
            this.listaEmpleados = new LinkedList<Empleado>();
        }

        public override string ToString()
        {
            return $"Nombre de la empresa: {Nombre} encargado: {encargado}";
        }

       public Empleado buscarEmpleado( string nombre, int edad)
        {
            Empleado empleadoOk = null;
           foreach(Empleado empleado in listaEmpleados)
            {
                if (empleado.Nombre.Equals(nombre) && empleado.Edad.Equals(edad)){
                    empleadoOk = empleado;
                    break;
                } 
            }
            
            return empleadoOk;
        }

        public void agregarEmpleado(string nombre, int edad)
        {
            Empleado empleadoAdd = buscarEmpleado(nombre, edad);
            if (empleadoAdd == null)
            {
                Empleado nuevoEmpleado = new Empleado(nombre, edad, "CargoPorDefecto");
                listaEmpleados.AddLast(nuevoEmpleado);
                Console.WriteLine(nuevoEmpleado.ToString());
                Console.WriteLine("Se agrego exitosamente");
            }
            else
            {
                Console.WriteLine("Ya existe no se agrego");
            }
        }

        public void listarEmpleados()
        {
            foreach(Empleado empleado in listaEmpleados)
            {
                Console.WriteLine(empleado.ToString());
            }
        }
    }
}

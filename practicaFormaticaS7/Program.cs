// See https://aka.ms/new-console-template for more information
using practicaFormaticaS7;

Empleado pepe = new Empleado("Pepe", 40, "Encargado");
Empresa textil = new Empresa("Textiles Cordoba", pepe);

Console.WriteLine(textil.ToString());
textil.agregarEmpleado("Marta", 30);
textil.agregarEmpleado("Jose", 45);
textil.agregarEmpleado("Jose", 45);
textil.agregarEmpleado("Josefa", 55);
Console.WriteLine("----------------------------------");
textil.listarEmpleados();
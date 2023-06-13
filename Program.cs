// See https://aka.ms/new-console-template for more information
/*using EspacioCalculadora;

int opcion=1, operacion;
double num;

Calculadora dato = new Calculadora();
while (opcion != 0)
{
    Console.WriteLine("\n Ingrese un numero: ");
    double.TryParse(Console.ReadLine(), out num);
    Console.WriteLine("\n Ingresar operacion: 1-Suma, 2-Resta, 3-Multiplicacion, 4-Division");
    int.TryParse(Console.ReadLine(), out operacion);
    switch (operacion)
    {
        case 1:
            dato.Sumar(num);
        break;
        case 2:
            dato.Restar(num);
        break;
        case 3:
            dato.Multiplicar(num);
        break;
        case 4:
            dato.Dividir(num);
        break;
    }
    Console.WriteLine("\n Desea realizar otra operacion? 1-SI, 0-NO");
    int.TryParse(Console.ReadLine(), out opcion);
}
Console.WriteLine("\n Resultado: "+ dato.Resultado);*/

//PUNTO 2
using DatosEmpleado;
Empleado emp1 = new Empleado();
Empleado emp2 = new Empleado();
Empleado emp3 = new Empleado();

emp1.nombre = "Jose";
emp1.apellido = "Garcia";
emp1.nacim = new DateTime(1997, 10, 5);
emp1.estadoCivil = 'C';
emp1.genero = 'H';
emp1.fecha = new DateTime(2018, 11, 5);
emp1.sueldo = 180500;
emp1.cargo = cargos.Ingeniero;

emp2.nombre = "Maria";
emp2.apellido = "Garcia";
emp2.nacim = new DateTime(1967, 10, 5);
emp2.estadoCivil = 'S';
emp2.genero = 'M';
emp2.fecha = new DateTime(2011, 11, 5);
emp2.sueldo = 10500;
emp2.cargo = cargos.Especialista;

emp3.nombre = "Laura";
emp3.apellido = "Garcia";
emp3.nacim = new DateTime(1965, 10, 5);
emp3.estadoCivil = 'C';
emp3.genero = 'M';
emp3.fecha = new DateTime(2009, 11, 5);
emp3.sueldo = 110500;
emp3.cargo = cargos.Auxiliar;


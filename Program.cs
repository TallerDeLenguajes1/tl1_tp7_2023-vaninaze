using EspacioCalculadora;

int i=1;
string? numStr, esNum;
double num;
int opcion;
Calculadora Dato = new Calculadora();

do{ 
    Console.WriteLine("Ingrese un numero:");
    numStr = Console.ReadLine();
    if(double.TryParse(numStr, out num)){
        Console.WriteLine("Seleccione una operacion: 1-SUMA, 2-RESTA, 3-MULTIPLICACION, 4-DIVISION, 5-LIMPIAR");
        esNum = Console.ReadLine();
        if(int.TryParse(esNum, out opcion)){
            switch (opcion)
            {
                case 1:
                    Dato.Sumar(num);
                    break;
                case 2:
                    Dato.Restar(num);
                    break;
                case 3:
                    Dato.Multiplicar(num);
                    break;
                case 4:
                    Dato.Dividir(num);
                    break;
                case 5:
                    Dato.Limpiar();
                    break;
            }
        } else {
            Console.WriteLine("Error! opcion incorrecta");
        }

    } else {
        Console.WriteLine("Error! No ingreso un numero");
    }
    Console.WriteLine("Resultado: "+Dato.Resultado);
    Console.WriteLine("Desea realizar otra operacion? 1-SI, 0-NO");
    esNum = Console.ReadLine();
}while(i!=0 && (int.TryParse(esNum, out i)));
Console.WriteLine("Resultado Final: "+Dato.Resultado);



namespace DatosEmpleado;
public enum cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado{
    public string? nombre;
    public string? apellido;
    public DateTime nacim;
    public char estadoCivil;
    public char genero;
    public DateTime fecha;
    public double sueldo;
    public cargos cargo;

 
    /*public TimeSpan Antiguedad{
        get {
            TimeSpan antiguedad = DateTime.Now - fecha; //si quiero solo el año pongo "DateTime.Year" devuelve entero
            return antiguedad;
        }
    }*/

    public int Antiguedad{
        get {
            int antiguedad = DateTime.Now.Year - fecha.Year; //si quiero solo el año pongo "DateTime.Year" devuelve entero
            return antiguedad;
        }
    }
    
    public int Edad {
        get {
            int edad = DateTime.Now.Year - nacim.Year;
            return edad;
        }
    }

    public int AniosParaJubilarse{
        get{
            int anios;
            if(genero == 'M'){ //M= mujer
                anios = 60 - Edad;
            } else {
                anios = 65 - Edad;
            }
            return anios;
        }
    }

    public double Salario(){
        double adicional=0;
        if (Antiguedad <= 20)
        {
            adicional = sueldo * (Antiguedad/100); //porcentaje
        } else {
            adicional = sueldo * 0.25;
        }

        if (cargo == cargos.Ingeniero || cargo == cargos.Especialista)
        {
            adicional = adicional * 1.5;
        }

        if (estadoCivil == 'C') //C=casado
        {
            adicional = adicional + 15000;
        }

        return (sueldo + adicional);
    }
}
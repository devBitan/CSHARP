namespace Introduccion
{
    public abstract class Empleado: Persona
    {
       public double Sueldo { get; set; }
       public int HorasExtras { get; set; }

       public abstract double calcularSalario(); // en los hijos de la clase Empleado, es donde se define el comportamiento
       
    }

    
}
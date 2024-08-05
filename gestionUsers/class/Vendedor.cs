namespace Introduccion
{
    public class Vendedor: Empleado, IGenerarReporte
    {
       public override double calcularSalario() //traer un metodo asbtracto
       {
         return this.Sueldo + (HorasExtras * 4);;
       }

        public void generarReporte()
        {
            Console.WriteLine("Generando reporte del Vendedor");
        }
    }

    
}
namespace Introduccion
{
    public class Gerente : Empleado, IGenerarReporte
    {
        public override double calcularSalario() //traer un metodo asbtracto
        {
            return this.Sueldo + (HorasExtras * 20);
        }

        public void generarReporte()
        {
            Console.WriteLine("Generando reporte del gerente");
        }


    }


}
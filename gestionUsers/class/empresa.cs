namespace Introduccion
{
    public class Empresa
    {
        // private string nombre;
        // public string Nombre 
        // { 
        //     get { return nombre; } 
        //     set { 
        //         if(string.IsNullOrEmpty(value))
        //             Console.WriteLine("Error, debes enviar el nombre");
        //         else
        //             nombre = value.ToUpper(); 
        //         } 
        // }
        public string Codigo { get; } = "BITXX123";
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Tel { get; set; } = string.Empty;
    }

    
}
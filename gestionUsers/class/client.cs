namespace Introduccion
{
    public class Client
    {
        public string nombre { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string tel { get; set; }
        public int edad { get; set; }

        public Client()
        {
            nombre = "sin parametros";
        }
        public Client(string nombre, string email, string direccion, string tel, int edad)
        {
            this.nombre = nombre;
            this.email = email;
            this.direccion = direccion;
            this.tel = tel;
            this.edad = edad;
        }

        public string MostrarInformacion(bool mayuscula, bool mostrarEdad)
        {
            var informacion = ContatenarInformación(mostrarEdad);
            if (mayuscula)
                informacion = ConvertirAMayusculas(informacion);
            else 
                informacion = ConvertirAMinusculas(informacion);
            return informacion;
        }

        private string ContatenarInformación(bool mostrarEdad)
        {
            var informacion = $"{nombre} - {email}";
            if (mostrarEdad)
                informacion += $" - {edad}";
            return informacion;
        }

        private string ConvertirAMinusculas(string texto)
        {
            return texto.ToLower();
        }
         private string ConvertirAMayusculas(string texto)
        {
            return texto.ToUpper();
        }
    }
}




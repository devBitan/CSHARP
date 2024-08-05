namespace Introduccion
{
    public abstract class Persona
    // public abstract class Persona asi puedo garantizar que es una clase abstracta, ahora Persona me sirve para crear otras clases hija, como vendedor, gerente
    {
       
        public string Nombre { get; set; } = string.Empty; //para que su valor por defecto no sea null, si no que sea un strign vacio
        public string Email { get; set; } = string.Empty;
        public string Tel { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;

        public string MostrarInformacion()
        {
            return $"Hola";
        }
    }
// Esta clase me permite crear otras, es como el molde 
    
}
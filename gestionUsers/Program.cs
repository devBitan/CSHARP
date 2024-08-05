using Introduccion;

// Client cliente = new Client();
// Client cliente = new Client("Juan","Juan@gmail.com","calle","sdadasde",23);
// Console.WriteLine(cliente.nombre);
// Console.WriteLine(cliente.MostrarInformacion(true, true));

// var empresa = new Empresa() 
// {
//     Nombre = "Juanito",
//     Email = "juan@gmail.com",
//     Direccion = "calle 123",
//     Tel = "1234567890",
 
// };
// // Empresa empresa = new Empresa();
// // empresa.Nombre = "DevBitan";
// Console.WriteLine(empresa.Nombre);

Empleado vendedor = new Vendedor(); // asói tambien se puede 
vendedor.Sueldo =  500;
vendedor.HorasExtras = 10;

var empleados = new List<Empleado>();
empleados.Add(vendedor);
empleados.Add(new Gerente(){Sueldo= 900, HorasExtras=20});

var total = empleados.Sum(x => x.calcularSalario());
Console.WriteLine($"Total: {total}");
Console.WriteLine(vendedor.MostrarInformacion());

// Interfaces
IGenerarReporte trabajador = new Gerente()
IGenerarReporte trabajador = new Gerente()
























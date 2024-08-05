using System;

// *1*
int numero = 1;
Console.WriteLine(numero);
numero = 3;
Console.WriteLine(numero);
const int CONST_NUMERO = 2;
Console.WriteLine(CONST_NUMERO);
List<string> lista = new List<string>();


namespace ClaseUno
{
    public class PrimerPrograma
    {
        //*2*
        int variableGlobal = 3;

        private void otraFuncion()
        { 
            int variableLocal = 4;
            Console.WriteLine(variableLocal);
        }
        public void global()
        {

            Console.WriteLine(variableGlobal);
        }
        // *3*
        public void Expresiones(){
            // arimetico
            int numero1 = 5;
            int numero2 = 3;
            int suma = numero1 + numero2;
            Console.WriteLine("AritmeticaLa suma es: " + suma);
            // relacional
            bool expresionRelacional = 10<11; // false
            Console.WriteLine("Relacional"+expresionRelacional);
            // logicos
            bool condicion1 = true;
            bool condicion2 = false;
            bool resultado = condicion1 && condicion2; // false
            Console.WriteLine("Logicos "+ resultado);
        }
    }
}




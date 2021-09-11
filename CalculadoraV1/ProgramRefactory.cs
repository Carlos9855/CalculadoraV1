using System;

namespace Calculadora
{
    class ProgramRefactory
    {
        private static void imprimir(int v1, int v2, int r2, string message, string simbol)
        {
            Console.WriteLine("el resultado de la {0} es", message);
            Console.WriteLine("{0}{3}{1}={2}", v1, v2, r2, simbol);
        }

        static void Main(string[] args)
        {
            int v1 = 0;
            int v2 = 0;
            string r;
            do
            {
                Console.WriteLine("+. sumar");
                Console.WriteLine("-. restar");
                Console.WriteLine("*. multiplicar");
                Console.WriteLine("/. dividir");
                Console.Write("elija una funcion");
                r = Console.ReadLine();
                Console.WriteLine("ingrese los numeros");
                Console.Write("v1 :");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("v2: ");
                v2 = int.Parse(Console.ReadLine());
                switch (r)
                {
                    case "+":
                        imprimir(v1, v2, v1 + v2, "suma", r);
                        break;
                    case "-":
                        imprimir(v1, v2, v1 - v2, "resta", r);
                        break;
                    case "*":
                        imprimir(v1, v2, v1 * v2, "multiplicacion", r);
                        break;
                    case "/":
                        imprimir(v1, v2, v1 / v2, "division", r);
                        break;
                }
                Console.Write("n¿Desea Continuar? s/n: ");
                r = Console.ReadLine();
            } while (r == "s");
        }
    }
}

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Practica_42057476_Fernandez_Cecilia_Parte_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1- Armar una función, a la que se le pase como parámetro un número N, 
             y muestre por pantalla N veces el mensaje: “Módulo ejecutándose”.
            2- Escribir una función que nos salude, pasándole un nombre por parámetro. 
            Su salida debe decir por ejemplo ”Hola Aristoteles, ¿cómo estás?”.
            3. Diseñar una función que tenga como parámetros dos números, y que calcule el máximo.
            4. Idem al anterior pero que calcule el máximo de 3 números.
            5. Idem al anterior pero que calcule el máximo de un array de n elementos.
            6. Se necesita crear una función a la que se le pasan por parámetro dos enteros 
            y muestra todos los números comprendidos entre ellos, inclusive.
            7. Armar una función que muestre en pantalla el doble del valor que se le pasa como parámetro.
            8. Se necesita una función que calcule y muestre en pantalla el área o el volumen de un cilindro, 
            según se especifique. Para distinguir un caso de otro, además de pasarle por parámetro el radio y la altura, 
            se le pasará el carácter ’a’ (para área) o ’v’ (para el volumen).
            9. Idem al anterior pero que devuelva un array con ambos cálculos: el área y el volumen.
            */

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===== MENU =====");
            Console.ResetColor();

            int option;
            do
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Ejecutar función 'Ejecutandose'");
                Console.WriteLine("2. Ejecutar función 'Saludo'");
                Console.WriteLine("3. Ejecutar función 'MasGrande'");
                Console.WriteLine("4. Ejecutar función 'MasGrandePart2'");
                Console.WriteLine("5. Ejecutar función 'MasGrandeArrayVersion'");
                Console.WriteLine("6. Ejecutar función 'NumerosEntre'");
                Console.WriteLine("7. Ejecutar función 'Doblete'");
                Console.WriteLine("8. Ejecutar función 'AreaOVolumen'");
                Console.WriteLine("9. Ejecutar función 'AreaOVolumenArrayVersion'");
                Console.WriteLine("0. Salir");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("====================");
                Console.ResetColor();

                Console.Write("Ingrese su opción: ");

                

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Ingrese un número: ");
                        int x = int.Parse(Console.ReadLine());
                        Ejecutandose(x);
                        break;

                    case 2:
                        Console.Write("Ingrese su nombre: ");
                        string nombre = Console.ReadLine();
                        Saludo(nombre);
                        break;

                    case 3:
                        Console.Write("Ingrese el primer número: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int b = int.Parse(Console.ReadLine());
                        MasGrande(a, b);
                        break;

                    case 4:
                        Console.Write("Ingrese el primer número: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el tercer número: ");
                        int num3 = int.Parse(Console.ReadLine());
                        MasGrandePart2(num1, num2, num3);
                        break;

                    case 5:
                        Console.Write("Ingrese la cantidad de elementos del array: ");
                        int size = int.Parse(Console.ReadLine());
                        int[] arr = null;
                        MasGrandeArrayVersion(ref arr, size);
                        break;

                    case 6:
                        Console.Write("Ingrese el primer número: ");
                        int start = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        int end = int.Parse(Console.ReadLine());
                        NumerosEntre(start, end);
                        break;

                    case 7:
                        Console.Write("Ingrese un número: ");
                        int num = int.Parse(Console.ReadLine());
                        Doblete(num);
                        break;

                    case 8:
                        Console.Write("Ingrese el radio del cilindro: ");
                        int radio = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del cilindro: ");
                        int altura = int.Parse(Console.ReadLine());
                        Console.Write("¿Qué desea calcular? (a para área, v para volumen): ");
                        string calculo = Console.ReadLine();
                        AreaOVolumen(radio, altura, calculo);
                        break;

                    case 9:
                        Console.Write("Ingrese el radio del cilindro: ");
                        int r = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del cilindro: ");
                        int h = int.Parse(Console.ReadLine());
                        AreaOVolumenArrayVersion(r, h);
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                        break;
                }

                Console.WriteLine();

            } while (option != 0);
        }
        public static void Ejecutandose(int x)
        {
            //Console.WriteLine("Ingrese un numero:");
            //x = int.Parse(Console.ReadLine());

            for(int i = 0; i < x; i++)
            {
                Console.WriteLine("Módulo ejecutándose");
            }
        }

        public static void Saludo(string nombre)
        {
            Console.WriteLine($"Hola {nombre}, ¿cómo estás? :)");
        }

        public static void MasGrande(int x, int y)
        {
            if(x > y)
            {
                Console.WriteLine($"El mayor es {x}");
            }
            else
            {
                Console.WriteLine($"El mayor es {y}");
            }
        }

        public static void MasGrandePart2(int x, int y, int z)
        {
            int max = Math.Max(x, Math.Max(y, z));
            Console.WriteLine($"El número más grande es: {max}");
        }

        public static void MasGrandeArrayVersion(ref int[] arr, int x)
        {
            arr = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr.Max();
            Console.WriteLine($"El número más grande en el array es: {max}");
        }

        public static void NumerosEntre(int x, int y)
        {
            Console.WriteLine($"Los numeros comprendidos entre {x} y {y} son:");
            for(int i = x; i <= y; i++)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void Doblete(int x)
        {
            int doble = x * 2;
            Console.WriteLine($"El doble de {x} es {doble}");
        }

        public static void AreaOVolumen(int radio, int altura, string calculo)
        {
            if(calculo == "a")
            {
                double area = Math.Round((2 * Math.PI * radio * altura + 2 * Math.PI * Math.Pow(radio, 2)), 2);
                Console.WriteLine($"El area del cilindro es {area}");
            }
            else
            {
                double volumen = Math.Round((Math.PI * Math.Pow(radio, 2) * altura), 2);
                Console.WriteLine($"El volumen del cilindro es {volumen}");
            }
        }

        public static void AreaOVolumenArrayVersion(int radio, int altura)
        {
            double area = Math.Round((2 * Math.PI * radio * altura + 2 * Math.PI * Math.Pow(radio, 2)), 2);
            double volumen = Math.Round((Math.PI * Math.Pow(radio, 2) * altura), 2);

            double[] arr = new double[2];
            arr[0] = area;
            arr[1] = volumen;

            Console.WriteLine($"El área del cilindro es: {arr[0]}");
            Console.WriteLine($"El volumen del cilindro es: {arr[1]}");
        }
    }
    
}

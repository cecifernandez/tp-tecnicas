using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica_42057476_Fernandez_Cecilia_Parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            10. Escribir una función que indique si un número es primo.
            11. Crear una función a la que se le pasa un número entero 
                y devuelve la cantidad de divisores primos que tiene.
            12. Crear una función a la que se le pasa un número entero y 
                devuelve un array con los divisores primos de dicho número.
            13. Escribir una función que calcule el máximo común divisor de dos números.
            14. Escribir una función que calcule el máximo común divisor de tres números
            15. Escribir una función que calcule el máximo común divisor de los números contenidos en un array
            16. Escribir una función que calcule el mínimo común múltiplo de dos números.
            17. Escribir una función que calcule el mínimo común múltiplo de tres números.
            18. Escribir una función que calcule el mínimo común múltiplo de los números contenidos en un array.
            19. Escribir una función que indique si dos números enteros positivos son amigos. 
                Dos números son amigos, si la suma de sus divisores (distintos de ellos mismos) son iguales.
            20. Escribir una función que reciba los parámetros a y n; y calcule la potencia n de a. (a n ).
            21. Escribir una función que muestre en binario un número entre 0 y 255.
            22. Escribir una función que sume los n primeros números impares
             */


            int option;
            do {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("===== MENU =====");

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("0- Salir");
                Console.WriteLine("1- Ejecutar función 'EsPrimo'");
                Console.WriteLine("2- Ejecutar función 'CuantosPrimos'");
                Console.WriteLine("3- Ejecutar función 'PrimoArray'");
                Console.WriteLine("4- Ejecutar función 'MaximoComunDivisor'");
                Console.WriteLine("5- Ejecutar función 'MCDAhoraSonTres'");
                Console.WriteLine("6- Ejecutar función 'MCDArrayVersion'");
                Console.WriteLine("7- Ejecutar función 'MinimoComunMultiplo'");
                Console.WriteLine("8- Ejecutar función 'MCMPorTres'");
                Console.WriteLine("9- Ejecutar función 'MCMArrayVersion'");
                Console.WriteLine("10- Ejecutar función 'NumerosAmigos'");
                Console.WriteLine("11- Ejecutar función 'PotenciaDeUnNumero'");
                Console.WriteLine("12- Ejecutar función 'NumeroABinario'");
                Console.WriteLine("13- Ejecutar función 'SumaImpar'");


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("===== MENU =====");
                Console.ResetColor();

                Console.Write("Ingrese una opción: ");

                option = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ingrese un numero");
                        int num = int.Parse(Console.ReadLine());
                        if (EsPrimo(num)){
                            Console.WriteLine($"El numero {num} es un numero primo");
                        }
                        else
                        {
                            Console.WriteLine($"{num} no es un numero primo");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un numero");
                        int num2 = int.Parse(Console.ReadLine());
                        int cantidad = CuantosPrimos(num2);
                        Console.WriteLine($"{num2} tiene {cantidad} primos");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese un numero");
                        int num3 = int.Parse(Console.ReadLine());
                        int[] array = PrimoArray(num3);
                        Console.WriteLine($"{num3} tiene {string.Join(", ", array)} como divisores primos");
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el primer numero");
                        int num4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int num5 = int.Parse(Console.ReadLine());
                        int mcd = MaximoComunDivisor(num4, num5);
                        Console.WriteLine($"El Maximo Comun Divisor entre {num4} y {num5} es {mcd}");
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el primer numero");
                        int num6 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int num7 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tercer numero");
                        int num8 = int.Parse(Console.ReadLine());
                        int mcd3 = MCDAhoraSonTres(num6, num7, num8);
                        Console.WriteLine($"El Maximo Comun Divisor entre {num6}, {num7} y {num8} es {mcd3}");
                        break;
                    case 6:
                        Console.WriteLine("Ingrese la cantidad de numeros del array");
                        int cant = int.Parse(Console.ReadLine());
                        int[] arr = new int[cant];
                        for (int i = 0; i < cant; i++)
                        {
                            Console.Write($"Ingrese el número {i + 1}: ");
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        int arraymcd = MCDArrayVersion(arr);
                        Console.WriteLine($"El MCD es {arraymcd}");
                        break;
                    case 7:
                        Console.WriteLine("Ingrese el primer numero");
                        int num9 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int num10 = int.Parse(Console.ReadLine());
                        int mcm = MinimoComunMultiplo(num9, num10);
                        Console.WriteLine($"El minimo común múltiplo de {num9} y {num10} es {mcm}");
                        break;
                    case 8:
                        Console.WriteLine("Ingrese el primer numero");
                        int num11 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int num12 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el tercer numero");
                        int num13 = int.Parse(Console.ReadLine());
                        int mcm3 = MCMPorTres(num11, num12, num13);
                        Console.WriteLine($"El MCM de {num11}, {num12} y {num13} es {mcm3}");
                        break;
                    case 9:
                        Console.WriteLine("Ingrese la cantidad de números del array:");
                        int cantidadNumeros = int.Parse(Console.ReadLine());
                        int[] arr1 = new int[cantidadNumeros];

                        for (int i = 0; i < cantidadNumeros; i++)
                        {
                            Console.Write($"Ingrese el número {i + 1}: ");
                            arr1[i] = int.Parse(Console.ReadLine());
                        }

                        int mcmarray = MCMArrayVersion(arr1);
                        Console.WriteLine($"El MCM es {mcmarray}");
                        break;
                    case 10:
                        Console.WriteLine("Ingrese el primer numero");
                        int num14 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int num15 = int.Parse(Console.ReadLine());
                        if(NumerosAmigos(num14, num15))
                        {
                            Console.WriteLine($"Los numeros {num14} y {num15} son amigos :)");
                        }
                        else
                        {
                            Console.WriteLine($"Los numeros {num14} y {num15} no son amigos :(");
                        }
                        break;
                    case 11:
                        Console.WriteLine("Ingrese un numero");
                        int num16 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la potencia");
                        int num17 = int.Parse(Console.ReadLine());
                        double potencia = PotenciaDeUnNumero(num16, num17);
                        Console.WriteLine($"El numero {num16} elevado a la {num17} da como resultado {potencia}");
                        break;
                    case 12:
                        Console.WriteLine("Ingrese un numero");
                        int num18 = int.Parse(Console.ReadLine());
                        string binario = NumeroABinario(num18);
                        Console.WriteLine($"El numero {num18} representado en binario es {binario}");
                        break;
                    case 13:
                        Console.WriteLine("Ingrese un numero");
                        int num19 = int.Parse(Console.ReadLine());
                        int suma = SumaImpar(num19);
                        Console.WriteLine($"La suma de los impares anteriores a {num19} es {suma}");
                        break;
                }
                

            } while (option != 0);

        }

        public static bool EsPrimo(int x)
        {
            if (x <= 1 || x % x != 0 || x % 1 != 0)
            {
                //Console.WriteLine($"{x} no es un numero primo");
                return false;
            }
            else
            {
                //Console.WriteLine($"{x} es un numero primo");
                return true;
            }
        }

        public static int CuantosPrimos(int x) 
        {
            int primosCount = 0;

            if (x < 2)
            {
                Console.WriteLine($"El número {x} no tiene divisores primos.");
                
            }

            for (int i = 1; i <= x; i++)
            {
                double resto = x % i;

                if(resto == 0 && EsPrimo(i))
                {
                    primosCount++;
                }
            }
           

            return primosCount;
        }

        public static int[] PrimoArray(int x)
        {
            int primosCount = CuantosPrimos(x);

            int[] result = new int[primosCount];
            int z = 0;

            for(int i = 1; i <= x; i++)
            {
                if (EsPrimo(i) && x % i == 0)
                {
                    result[z] = i;
                    z++;
                }    
            }

            return result;

            //Console.WriteLine($"Los divisores primos de {x} son: {string.Join(", ", result)}");
        }

        public static int MaximoComunDivisor(int x, int z)
        {
            while (z != 0)
            {
                int resto = x % z;
                x = z;
                z = resto;
            }

            int mcd = Math.Abs(x);

            //Console.WriteLine($"El MCD es {mcd}");

            return mcd;
        }

        public static int MCDAhoraSonTres(int x, int z, int y)
        {
            int mcdxz = MaximoComunDivisor(x, z);

            int mcdxzy = MaximoComunDivisor(mcdxz, y);

            return mcdxzy;

            //Console.WriteLine($"El MCD de {x},{z} y {y} es {mcdxzy}");
        }

        public static int MCDArrayVersion(int[] numeros)
        {
            if (numeros == null || numeros.Length == 0)
                Console.WriteLine("El array no puede estar vacio :(");

            int mcd = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                mcd = MaximoComunDivisor(mcd, numeros[i]);
                if (mcd == 1)
                    break;
            }

            return mcd;

            //Console.WriteLine($"El MCD es {mcd}");

        }

        public static int MinimoComunMultiplo(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                Console.WriteLine("El MCM no está definido para números que incluyan un 0.");
                return 0;
            }
            return (Math.Abs((x * y) / MaximoComunDivisor(x, y)));
        }

        public static int MCMPorTres(int x, int y, int z)
        {
            return MinimoComunMultiplo(MinimoComunMultiplo(x, y), z);
        }

        public static int MCMArrayVersion(int[] numeros)
        {
            if (numeros == null || numeros.Length == 0)
                Console.WriteLine("El array no puede estar vacio :(");

            int mcm = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                mcm = MinimoComunMultiplo(mcm, numeros[i]);
                if (mcm == 0)
                    break;
            }

            return mcm;
        }

        public static bool NumerosAmigos(int x, int y)
        {
            int sumaDivisoresX = SumaDivisores(x);
            int sumaDivisoresY = SumaDivisores(y);

            return sumaDivisoresX == sumaDivisoresY;
                
        }

        public static int SumaDivisores(int x)
        {
            int suma = 0;

            for(int i = 0; i < x; i++)
            {
                if(x % 1 == 0)
                {
                    suma++;
                }
            }

            return suma;
        }

        public static double PotenciaDeUnNumero(int x, int y)
        {
            return Math.Pow(x, y);
        }

        public static string NumeroABinario(int x)
        {

            if (x == 0)
            {
                return string.Empty; ;
            }

            return NumeroABinario(x / 2) + (x % 2).ToString();
        }

        public static bool EsPar(int x)
        {
            if ((x % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int SumaImpar(int x)
        {
            int suma = 0;

            for (int i = 0; i < x; i++)
            {
                if (!EsPar(i))
                {
                    suma += i;
                }
            }

            return suma;
        }
    }
}

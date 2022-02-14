int execute = 1;

while (execute == 1)
{
    Console.WriteLine("***************************************************************");
    Console.WriteLine("Ejercicio 1");
    Console.WriteLine("Ejercicio 2");
    Console.WriteLine("Ejercicio 3");
    Console.WriteLine("Ejercicio 4");

    Console.WriteLine("Por favor ingrese el número del ejercicio que desea ver o 0 para salir: ");
    int option = int.Parse(Console.ReadLine());
    Console.WriteLine("***************************************************************");

    switch (option)
    {
        //Salir
        case 0:
            execute = 0;
            break;

        case 1:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.");
            Console.WriteLine();

            Console.WriteLine("Por favor, introduzca un número entero positivo:");
            int n = int.Parse(Console.ReadLine());


            //Si es primo devuelve 1, sino devuelve 0
            static int esPrimo(int n)
            {
                int i;
                int contador = 0;
                for (i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (esPrimo(i) == 1)
                {
                    Console.WriteLine("El número {0} es primo", i);
                }
            }

            int contador = 0;
            for (int i = 1; i <= n; i++)
            {
                if (esPrimo(i) == 1)
                {
                    contador++;
                }
            }
            Console.WriteLine("Hay {0} números primos entre 1 y {1}", contador, n);

            break;

        case 2:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Usando ciclos y metodos");
            Console.WriteLine("Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.");
            Console.WriteLine();

            Console.WriteLine("Por favor, introduzca un número entero positivo: ");
            int sueldos = int.Parse(Console.ReadLine());
            double sueldoMaximo = 0;

            for (int i = 0; i < sueldos; i++)
            {
                Console.WriteLine("Introduzca un sueldo: ");
                int sueldo = int.Parse(Console.ReadLine());
                if (sueldo > sueldoMaximo)
                {
                    sueldoMaximo = sueldo;
                }
            }

            Console.WriteLine("El sueldo máximo es: " + sueldoMaximo);


            break;

        case 3:

			int num, unidad, decena;
			string uni = "", sobreD = "", dec = "";

			Console.WriteLine("Numero a texto");
			Console.Write("Ingresa un numero: ");
			num = int.Parse(Console.ReadLine());

			decena = num / 10;
			unidad = (num % 10) / 1;

			if (unidad == 1)
			{
				uni = "uno";
			}
			else if (unidad == 2)
			{
				uni = "dos";
			}
			else if (unidad == 3)
			{
				uni = "tres";
			}
			else if (unidad == 4)
			{
				uni = "cuatro";
			}
			else if (unidad == 5)
			{
				uni = "cinco";
			}
			else if (unidad == 6)
			{
				uni = "seis";
			}
			else if (unidad == 7)
			{
				uni = "siete";
			}
			else if (unidad == 8)
			{
				uni = "ocho";
			}
			else if (unidad == 9)
			{
				uni = "nueve";
			}

			if (decena == 1 && unidad == 0)
			{
				sobreD = "diez";
			}
			else if (decena == 1 && unidad == 1)
			{
				sobreD = "once";
			}
			else if (decena == 1 && unidad == 2)
			{
				sobreD = "doce";
			}
			else if (decena == 1 && unidad == 3)
			{
				sobreD = "trece";
			}
			else if (decena == 1 && unidad == 4)
			{
				sobreD = "catorce";
			}
			else if (decena == 1 && unidad == 5)
			{
				sobreD = "quince";
			}
			else if (decena == 1 && unidad == 6)
			{
				sobreD = "dieciseis";
			}
			else if (decena == 1 && unidad == 7)
			{
				sobreD = "diecisiete";
			}
			else if (decena == 1 && unidad == 8)
			{
				sobreD = "dieciocho";
			}
			else if (decena == 1 && unidad == 9)
			{
				sobreD = "diecinueve";
			}

			if (decena == 2)
			{
				dec = "veinte";
			}
			else if (decena == 3)
			{
				dec = "treinta";
			}
			else if (decena == 4)
			{
				dec = "cuarenta";
			}
			else if (decena == 5)
			{
				dec = "cincuenta";
			}
			else if (decena == 6)
			{
				dec = "sesenta";
			}
			else if (decena == 7)
			{
				dec = "setenta";
			}
			else if (decena == 8)
			{
				dec = "ochenta";
			}
			else if (decena == 9)
			{
				dec = "noventa";
			}

			if (num < 10)
			{
				Console.WriteLine("El numero es: " + uni);
			}
			else if (num < 20)
			{
				Console.WriteLine("El numero es: " + sobreD);
			}
			else if (num < 100)
			{
				if (num % 10 == 0)
				{
					Console.WriteLine("El numero es: " + dec);
				}
				else
				{
					Console.Write("El numero es: {0} y {1}", dec, uni);
				}
			}
			break;

		case 4:
			Console.WriteLine("***************************************************************");
			Console.WriteLine("ENUNCIADO:");
			Console.WriteLine("Usando ciclos y metodos");
			Console.WriteLine("Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por consola si se trata de un vocal o una consonante.");
			Console.WriteLine();

			Console.WriteLine("Por favor ingrese una letra del abecedario");
			string letra = Console.ReadLine();

			if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
			{
				Console.WriteLine("La letra es una vocal.");
			}
			else
			{
				Console.WriteLine("La letra es una consonante.");
		   }
			break;
    }
}
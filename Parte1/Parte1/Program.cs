int program = 1;

while (program == 1)
{
    Console.WriteLine("***************************************************************");
    Console.WriteLine("Ejercicio 1");
    Console.WriteLine("Ejercicio 2");
    Console.WriteLine("Ejercicio 3");
    Console.WriteLine("Ejercicio 4");
    Console.WriteLine("Ejercicio 5");
    Console.WriteLine("Ejercicio 6");
    Console.WriteLine("Ejercicio 7");
    Console.WriteLine("Ejercicio 8");
    Console.WriteLine("Ejercicio 9");
    Console.WriteLine("Ejercicio 10");
    Console.WriteLine("Ejercicio 11");
    Console.WriteLine("Ejercicio 12");
    Console.WriteLine("Ejercicio 13");
    Console.WriteLine("Ejercicio 14");
    Console.WriteLine("Ejercicio 15");

    Console.WriteLine("Por favor ingrese el número del ejercicio que desea ver o 0 para salir: ");
    int option = int.Parse(Console.ReadLine());
    Console.WriteLine("***************************************************************");

    switch (option)
    {
        //Salir
        case 0:
            program = 0;
            break;

        //Ejercicio 1
        case 1:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Leer un número e imprimir un mensaje en caso que sea par.");
            Console.WriteLine();
            Console.WriteLine("Por favor ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
            break;

        //Ejercicio 2
        case 2:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Elabore un algoritmo que lea un número y si este es mayor o igual a 10 devuelva el triple de este.");
            Console.WriteLine();
            Console.WriteLine("Por favor ingrese un número");
            double dato = double.Parse(Console.ReadLine());

            if (dato >= 10)
            {
                double datoPorTres = dato * 3;
                Console.WriteLine("El triple del número es: " + datoPorTres);
            }
            else
            {
                Console.WriteLine("El dato ingresado es: " + dato);
            }
            break;

        //Ejercicio 3
        case 3:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000 o más.Determinar cuánto pagará, con IVA incluido(19 %), un cliente si la compra cumple con esta condición.");
            double discountPercentage = 0.10;
            double iva = 0.12;


            Console.WriteLine("Por favor ingrese el precio del pc: ");
            double price = double.Parse(Console.ReadLine());
            if (price >= 1000000)
            {
                double totalPrice = price + price * discountPercentage;
                double totalPriceIva = totalPrice + totalPrice * iva;

                Console.WriteLine("El precio total a pagar con iva y descuento incluídos es de: " + totalPriceIva);
            }
            else
            {
                double totalIva = price + (price * iva / 100);
                Console.WriteLine("El precio a pagar con iva incluído es de: " + totalIva);

            }
            break;
    }
}
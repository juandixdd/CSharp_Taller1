int execute = 1;

while(execute == 1)
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
            execute = 0;
            break;

        case 1:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original y su precio con descuento.El descuento lo hace en base a la clave, si la clave es 01 el descuento es del 10 % y si la clave es 02 el descuento es del 20 % (solo existen dos claves).");
            Console.WriteLine();

            String nombreArticulo = "Play Station 5";
            double precioOriginal = 2500000;

            Console.WriteLine("Por favor ingrese la clave del articulo: ");
            double claveArticulo = double.Parse(Console.ReadLine());

            if(claveArticulo == 1)
            {
                double precioDescuento = precioOriginal - (precioOriginal * 0.10);
                Console.WriteLine("Articulo: ");
                Console.WriteLine("Nombre: " + nombreArticulo);
                Console.WriteLine("Clave: " + claveArticulo);
                Console.WriteLine("Precio: " + precioOriginal);
                Console.WriteLine("Precio con descuento: " + precioDescuento);
            }
            else if(claveArticulo == 2)
            {
                double precioDescuento = precioOriginal - (precioOriginal * 0.20);
                Console.WriteLine("Articulo: ");
                Console.WriteLine("Nombre: " + nombreArticulo);
                Console.WriteLine("Clave: " + claveArticulo);
                Console.WriteLine("Precio: " + precioOriginal);
                Console.WriteLine("Precio con descuento: " + precioDescuento);
            }
            else
            {
                Console.WriteLine("Clave inválida");
            }
            break;

        case 2:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Hacer un algoritmo que calcule el total a pagar por la compra de camisas. Si se compran tres camisas o más se aplica un descuento del 20 % sobre el total de la compra y si son menos de tres camisas un descuento del 10 % ");
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese la cantidad de camisetas: ");
            int cantidadCamisas = int.Parse(Console.ReadLine());

            if (cantidadCamisas >= 3)
            {
                Console.WriteLine("El descuento es del 20%");
            }
            else
            {
                Console.WriteLine("El descuento es del 10%");
            }

            break;

        case 3:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Elabore un algoritmo que lea un número y si este es mayor o igual a 10 devuelva el triple de este de lo contrario la cuarta parte de este ");
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese un número");
            double dato3 = double.Parse(Console.ReadLine());

            if(dato3 >= 10)
            {
                double tripleDato3 = dato3 * 3;
                Console.WriteLine("El triple es: " + tripleDato3);
            }
            else
            {
                double cuartaPArteDato3 = dato3 / 4;
                Console.WriteLine("La curta parte es: " + cuartaPArteDato3);
            }
            break;

        case 4:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Elabore un algoritmo que lea un número y si este es mayor o igual a 10 devuelva el triple de este de lo contrario la cuarta parte de este ");
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese un número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese un número: ");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine(num2);
                Console.WriteLine(num1);
            }
            else if(num1 < num2)
            {
                Console.WriteLine(num1);
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine("Los números son iguales");
            }

            break;

        case 5:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Determinar el precio de un pasaje de ida y vuelta por avión, conociendo la distancia a recorrer y sabiendo que que esta es superior a 1.000 km, la línea aérea le hace un descuento del 30 %.El precio por kilómetro es de $150. ");
            Console.WriteLine();

            Console.WriteLine("Por facor ingrese los km de ida");
            int kmIda = int.Parse(Console.ReadLine());

            Console.WriteLine("Por facor ingrese los km de vuelta");
            int kmVuelta = int.Parse(Console.ReadLine());

            int totalKm = kmIda + kmVuelta;
            int precioTotalKm = totalKm * 150;

            if (totalKm >= 1000)
            {
                double descuentoVuelo = precioTotalKm - (precioTotalKm * 0.30);
                Console.WriteLine("El precio del vuelo, con un descuento del 30% es de: " + descuentoVuelo);
            }
            else
            {
                Console.WriteLine("El precio del vuelo es de: " + precioTotalKm);
            }
            break;

        case 6:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Calcular e imprimir el salario de un empleado, teniendo en cuenta que si el salario bruto es igual o superior a $2.000.000, debe hacerse una retención del 10 %, si el salario es inferior, la retención será del 3 %.");
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario >= 2000000)
            {
                double retencion = salario * 0.10;
                double salarioNeto = salario - retencion;
                Console.WriteLine("Su salario neto es: " + salarioNeto);
            }
            else
            {
                double retencion = salario * 0.03;
                double salarioNeto = salario - retencion;
                Console.WriteLine("Su salario neto es: " + salarioNeto);
            }
            break;

        case 7:

            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Leer un número e imprimir un mensaje si es par o impar");
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese un número: ");
            int dato7 = int.Parse(Console.ReadLine());

            if (dato7 % 2 == 0)
            {
                Console.WriteLine("El número ingresado es par");
            }
            else
            {
                Console.WriteLine("El número ingresado es impar");
            }
            break;

        case 8:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Elaborar un algoritmo que permita calcular el número de pulsaciones que debe tener una persona por cada 10 segundos de ejercicio aeróbico; la fórmula que se aplica cuando el sexo es femenino, es: numpulsaciones = (220-edad)/10 y si el sexo es masculino: numpulsaciones = (210-edad)/10");
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese si es hombre o mujer (h/m)");
            string sexo = Console.ReadLine();

            Console.WriteLine("Por favor ingrese su edad.");
            int edad = int.Parse(Console.ReadLine());

            if (sexo == "h")
            {
                Console.WriteLine("El número de pulsaciones es: " + (210 - edad) / 10);
            }
            else
            {
                Console.WriteLine("El número de pulsaciones es: " + (220 - edad) / 10);
            }
            break;

        case 9:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera: Si trabaja 40 horas o menos, se le paga a $10.000 la hora Si trabaja más de 40 horas, se le paga $10.000 por cada una de las primeras 40 horas y $15.000 por cada una de las horas extras.");
            Console.WriteLine();

            Console.WriteLine("Por favor ingreses las horas trabajadas:");
            double horas = int.Parse(Console.ReadLine());

            if (horas <= 40)
            {
                double salarioEmpleado = horas * 10000;
                Console.WriteLine("El salario es: " + salarioEmpleado);
            }
            else
            {
                double salarioEmpleado = (40 * 10000) + ((horas - 40) * 15000);
                Console.WriteLine("El salario es: " + salarioEmpleado);
            }
            break;

        case 10:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Una persona enferma y cuyo peso es 70 kg, se encuentra en reposo y desea saber cuántas calorías consume su cuerpo durante el tiempo que realice una misma actividad. Las actividades que puede realizar son únicamente dormir o estar sentado. Los datos que tiene son que estando dormido consume 1.08 calorías por minuto y estando sentado en reposo consume 1.66 calorías por minuto.");
            Console.WriteLine();


            Console.WriteLine("Por favor ingrese el tiempo que desea realizar la actividad en horas:");
            double actividadHoras = double.Parse(Console.ReadLine());

            double minutos = actividadHoras * 60;

            Console.WriteLine("Por favor ingrese la actividad que desea realizar: (1) dormir o (2) sentarse");

            if (int.Parse(Console.ReadLine()) == 1)
            {
                double calorias = minutos * 1.08;
                Console.WriteLine("El consumo de calorías es de: " + calorias);
            }
            else
            {
                double calorias = minutos * 1.66;
                Console.WriteLine("El consumo de calorías es de: " + calorias);
            }
            break;

        case 11:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Una empresa desea hacer una compra de varias piezas de la misma clase a una fábrica. La empresa, dependiendo del valor de la compra, decidirá la forma en que le pagará al fabricante. Si el valor de la compra excede o es igual a $5.000.000, la empresa tendrá la capacidad de pagar con recursos propios el 55% del valor de la compra, pedirá prestado a un banco el 30% y el resto lo pagará solicitando un crédito al fabricante. Si el monto total de la compra no excede de $5.000.000, la empresa tendrá la capacidad de pagar con recursos propios un 70% y el 30% restante, lo pagará solicitando un crédito al fabricante. El fabricante cobra un 15% de interés sobre la cantidad que le pague a crédito.");
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese el valor de la compra:");
            double valorCompra = double.Parse(Console.ReadLine());

            if (valorCompra >= 5000000)
            {
                double valorPagar = valorCompra * 0.55;
                double valorPrestado = valorCompra * 0.3;
                double valorCredito = valorCompra * 0.15;
                double total = valorPagar + valorPrestado + valorCredito;

                Console.WriteLine("El valor a pagar por la empresa es de: " + valorPagar);
                Console.WriteLine("El valor prestado a un banco es de: " + valorPrestado);
                Console.WriteLine("El valor del crédito es de: " + valorCredito);
            
                Console.WriteLine("El valor a pagar es: " + total);
            }
            else
            {
                double valorPagar = valorCompra * 0.7;
                double valorPrestado = valorCompra * 0.3;
                double valorCredito = valorCompra * 0.15;
                double total = valorPagar + valorPrestado + valorCredito;

                Console.WriteLine("El valor a pagar por la empresa es de: " + valorPagar);
                Console.WriteLine("El valor prestado a un banco es de: " + valorPrestado);
                Console.WriteLine("El valor del crédito es de: " + valorCredito);
            
                Console.WriteLine("El valor a pagar es: " + total);
            }
            break;

        case 12:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Elaborar un algoritmo que permita calcular el valor total a pagar en una papelería teniendo en cuenta que, si lleva 5 cuadernos o más, se le cobrarán $2.000 por cada uno, mientras que, si lleva menos, se le cobrarán $2.500 por cada uno.");
            Console.WriteLine();

            Console.WriteLine("Por favor, ingrese la cantidad de cuadernos que lleva:");
            int cuadernos = int.Parse(Console.ReadLine());

            if (cuadernos >= 5)
            {
                Console.WriteLine("El valor total a pagar es de: $" + (cuadernos * 2000));
            }
            else
            {
                Console.WriteLine("El valor total a pagar es de: $" + (cuadernos * 2500));
            }
            break;

        case 13:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Una constructora ofrece vivienda de interés social, bajo las siguientes condiciones: Si los ingresos del comprador son iguales o superiores a $1.200.000, la cuota inicial será del 15% del valor de la vivienda y el resto, se distribuirá en 120 cuotas mensuales con un interés del 2% mensual. Si los ingresos del comprador son inferiores a $1.200.000, la cuota inicial será del 30% del valor de la vivienda y el resto, lo distribuirá en 84 cuotas mensuales con un interés del 1% mensual. La constructora desea saber cuánto debe pagar un comprador por concepto de cuota inicial y cuánto por cada cuota mensual.");
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese los ingresos del comprador:");
            double ingresos = double.Parse(Console.ReadLine());

            if (ingresos >= 1200000)
            {
                double cuotaInicial = (ingresos * 0.15);
                double cuotaMensual = (ingresos * 0.02);
                Console.WriteLine("El comprador debe pagar una cuota inicial de: $" + cuotaInicial);
                Console.WriteLine("El comprador debe pagar una cuota mensual de: $" + cuotaMensual);
            }
            else
            {
                double cuotaInicial = (ingresos * 0.3);
                double cuotaMensual = (ingresos * 0.01);
                Console.WriteLine("El comprador debe pagar una cuota inicial de: $" + cuotaInicial);
                Console.WriteLine("El comprador debe pagar una cuota mensual de: $" + cuotaMensual);
            }
            break;

        case 14:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("Elaborar un algoritmo que lea un número, si es par, que imprima el cubo y si es impar, que imprima el triple.");
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El cubo del número ingresado es: " + Math.Pow(numero, 3));
            }
            else
            {
                Console.WriteLine("El triple del número ingresado es: " + numero * 3);
            }
            break;

        case 15:
            Console.WriteLine("***************************************************************");
            Console.WriteLine("ENUNCIADO:");
            Console.WriteLine("En un almacén se hace un 17% de descuento a los clientes cuya compra sea superior a $200.000, para las compras inferiores, el descuento será del 5%. ¿Cuánto deberá pagar cada cliente?");
            Console.WriteLine();

            Console.WriteLine("Por favor ingrese el precio de la compra:");
            double precioCompra = double.Parse(Console.ReadLine());

            if (precioCompra > 200000)
            {
                double descuento = precioCompra * 0.17;
                double precioFinal = precioCompra - descuento;
                Console.WriteLine("El precio final es: " + precioFinal);
            }
            else
            {
                double descuento = precioCompra * 0.05;
                double precioFinal = precioCompra - descuento;
                Console.WriteLine("El precio final es: " + precioFinal);
            }

            break;
    }
}
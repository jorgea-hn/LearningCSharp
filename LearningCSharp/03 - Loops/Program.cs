// 13 ejercicio
// Usa un bucle for para imprimir numeros del 1 al 10

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// 15 ejercicio
// Escribe un programa que pida al usuario un numero y muestre su tabla de multiplicar del 1 al 10

Console.WriteLine("Enter number: ");
var numberM = Convert.ToInt16(Console.ReadLine());


for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} x {numberM} = {i * numberM}");
}

//ejercicio 2
// Escribe un programa que solicite al usuario un número entero positivo e imprime todos los
// números pares desde 1 hasta ese número usando un ciclo for.

// Console.WriteLine("Enter to number: ");
// int number42 = int.Parse(Console.ReadLine());
//
// if (number42 > 0)
// {
//     for (int i = 1; i <= number42; i++)
//     {
//         if (number42 / 2 == 0)
//         {
//             Console.WriteLine(i);
//         } 
//     }
// }
// else
// {
//     Console.WriteLine("Number not valid");
// }

// ejercicio 3
// Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de
// multiplicar de ese número del 1 al 10 usando un ciclo for.

// Console.WriteLine("Enter to number: ");
// int number43 = int.Parse(Console.ReadLine());
//
// if (number43 > 0)
// {
//     for (int i = 1; i <= 10; i++)
//     {
//         Console.WriteLine($"{i} x {number43} = {i* number43}");
//     }
// }
// else
// {
//     Console.WriteLine("Number not valid");
// }

// Ejercicio 4
// Escribe un programa que genere un número aleatorio entre 1 y 100. Pídele al usuario que
// adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado
// alto, demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que
// adivine correctamente usando un ciclo do-while.

// Random rnd = new Random();
// int numeroAleatorio = rnd.Next(100);

// Console.WriteLine(numeroAleatorio);

// int vidas = 5;
// int numero;
// do
// {
//     Console.WriteLine("Enter to number: ");
//     numero = Convert.ToInt32(Console.ReadLine());
//
//     if (numero == numeroAleatorio)
//     {
//         Console.WriteLine("You guessed the number");
//         break;
//     }
//     else
//     {
//         Console.WriteLine("You entered an incorrect number");
//         vidas -= 1;
//         Console.WriteLine(vidas);
//     }
// } while (vidas > 0);
// ejercicio 5
// Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
// números impares desde ese número hasta 1 usando un ciclo while.

// Console.WriteLine("You entered the number");
// int numero2 = Convert.ToInt32(Console.ReadLine());
//
// if (numero2 > 0)
// {
//     Console.WriteLine("The number is positive");
//     while (numero2>1)
//     {
//         numero2--;
//         if (numero2 % 2 == 1)
//         {
//             Console.WriteLine(numero2);
//         }
//     }
// }
// else
// {
//     Console.WriteLine("You entered an incorrect number");
// }


// Ejercicio 6
// Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no
// es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta
// usando un ciclo while.

// string password = "secreta";
// Console.WriteLine("Enter your password: ");
// string password2 = Console.ReadLine();
//
// while (password != password2)
// {
//     Console.WriteLine("Enter your password: ");
//     password2 = Console.ReadLine();
// }

// ejercicio 7
// Escribe un programa que solicite al usuario un número entero positivo e imprima la
// secuencia de Fibonacci hasta ese número usando un ciclo for.

// Console.WriteLine("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// int b = 1;
// int temp;
//
//
// if (number > 0)
// {
//     Console.WriteLine("Fibonacci Series");
//     for (int i = 1; i <= number; i++)
//     {
//         Console.Write(a + " ");
//         temp = a;
//         a = b;
//         b = temp + b;
//     }
// }
// else
// {
//     Console.WriteLine("Number is negative");
// }



// ejercicio 8
// Escribe un programa que solicite al usuario un número entero positivo e imprima si el
// número es primo o no usando un ciclo for.


// Console.WriteLine("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int contador = 0;
// if (number > 0)
// {
//     Console.WriteLine("-------------- Detector Cousin Numbers -----------------------------");
//     if (number == 1)
//     {
//         Console.WriteLine("Cousin Numbers");
//     }
//     else
//     {
//         for (int i = 1; i <= 10; i++)
//         {
//             if (number % i == 0)
//             {
//                 contador++;
//             };
//         }
//
//         if (contador > 2)
//         {
//             Console.WriteLine("Not Cousin Numbers");
//         }
//         else
//         {
//             Console.WriteLine("Cousin Numbers");
//         }
//     }
//     
// }
// else
// {
//     Console.WriteLine("Number is negative");
// }

// ejercicio 9
// Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la
// palabra en una línea separada usando un ciclo foreach.

// Console.WriteLine("Enter one word: ");
// string userInput = Console.ReadLine();
//
// foreach (var character in userInput)
// {
//     Console.WriteLine(character);
// }


// ejercicio 10
// Escribe un programa que solicite al usuario un número entero positivo e imprima la suma
// de todos los números desde 1 hasta ese número usando un ciclo for.


// Console.WriteLine("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sumador = 0;
//
// if (number > 1)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         sumador += i;
//     }
//     Console.WriteLine($"The sum of numbers is {sumador}");
// }
// else
// {
//     Console.WriteLine("Negative number");
// }
// See https://aka.ms/new-console-template for more information

// 12 ejercicio
// Escribe un programa que pida al usuario un numero y muestra si es positivo, negativo o cero

Console.WriteLine("Enter number: ");
var numeroUsuario = Convert.ToInt32(Console.ReadLine());

if (numeroUsuario > 0)
{
    Console.WriteLine("Numero mayor que 0");
}
else if (numeroUsuario < 0)
{
    Console.WriteLine("Numero menor que 0");
}
else
{
    Console.WriteLine("Numero igual a 0");
}



// Ejercicio 1
// Escribe un programa que pida al usuario un número y muestre si es par o impar usando
// una condición if.

Console.WriteLine("Enter to number of 1 to 10: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % 2 == 0 ? "The number is even" : "The number is odd");


// Ejercicio 2
// Escribe un programa que pida al usuario que ingrese su nombre. Luego, verifica si el
// nombre ingresado no es nulo ni está vacío. Si el nombre es válido, muestra un mensaje de
// bienvenida; de lo contrario, muestra un mensaje de error.

Console.WriteLine("Enter to name: ");
string? name = Console.ReadLine();

Console.WriteLine(string.IsNullOrWhiteSpace(name) ? "Sorry, you entered an invalid name" : $"Welcome to {name}");

// ejercicio 3
// Escribe un programa que pida al usuario su edad y muestre si es mayor o menor de edad
// usando if-else

Console.WriteLine("Enter to age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(age < 18 ? "Sorry, you are a minor" : "Welcome, you are a major");



// ejercicio 4
// Escribe un programa que pida al usuario un día de la semana (como número del 1 al 7) y
// muestre el nombre del día correspondiente usando switch.

Console.WriteLine("Enter to number of the week (1-7): ");
int week = Convert.ToInt32(Console.ReadLine());

switch (week)
{
 case 1:
     Console.WriteLine("Monday");
     break;
 case 2:
     Console.WriteLine("Tuesday");
     break;
 case 3:
     Console.WriteLine("Wednesday");
     break;
 case 4:
     Console.WriteLine("Thursday");
     break;
 case 5:
     Console.WriteLine("Friday");
     break;
 case 6:
     Console.WriteLine("Saturday");
     break;
 case 7:
     Console.WriteLine("Sunday");
     break;
 default:
     Console.WriteLine("Sorry, you entered an invalid week");
     break;
}

// ejercicio 5
// Escribe un programa que pida al usuario su equipo de nacionalidad, si es colombiana debe
// decirle que es nativo el país y si no lo es debe decir que es extranjero (hacer ejercicio con
// operador ternario)

Console.WriteLine("Enter your nationality: ");
string? nationality = Console.ReadLine();

Console.WriteLine(nationality?.ToLower()=="colombian" ? "Native" : "foreign");

// ejercicio 6
// Escribe un programa que pida al usuario tres números y muestre cuál es el mayor usando
// if-else.

Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine("The number 1 is major");
}
else if (number2 > number3 && number2 > number3)
{
    Console.WriteLine("The number 2 is major");
}
else
{
    Console.WriteLine("The number 3 is major");
}



// Ejercicio 7
// Escribe un programa que pida al usuario que ingrese una contraseña. Verifica si la
// contraseña no es nula ni está vacía. Si la contraseña es válida, muestra un mensaje
// indicando que la contraseña es aceptada; de lo contrario, muestra un mensaje indicando
// que la contraseña no puede estar en blanco.

Console.WriteLine("Enter a password: ");
string? password = Console.ReadLine();

Console.WriteLine(string.IsNullOrWhiteSpace(password)
    ? "Sorry, you entered an invalid password"
    : $"Password: {password}");


// ejercicio 8
// Escribe un programa que pida al usuario un número del 1 al 12 y muestre el nombre del
// mes correspondiente usando switch.


Console.WriteLine("Enter to number of the month (1-12): ");
int month = Convert.ToInt32(Console.ReadLine());

switch (month)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November");
        break;
    case 12:
        Console.WriteLine("December");
        break;
    default:
        Console.WriteLine("Sorry, you entered an invalid week");
        break;
}

// ejercicio 9
// Escribe un programa que pida al usuario una calificación numérica y muestre la letra
// correspondiente (A, B, C, D, F) usando if-else.

Console.WriteLine("Enter to number to qualification (1 - 5): ");
int qualification = Convert.ToInt32(Console.ReadLine());


if (qualification == 1)
{
    Console.WriteLine("A");
}
else if (qualification == 2)
{
    Console.WriteLine("B");
}
else if (qualification == 3)
{
    Console.WriteLine("C");
}
else if (qualification == 4)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("E");
}


// ejercicio 10
// Escribe un programa que pida al usuario un carácter y determine si es una vocal o una
// consonante usando switch.

Console.WriteLine("Enter to character: ");
char? character = Convert.ToChar(Console.ReadLine() ?? string.Empty);

switch (character)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("The character is a vowel");
        break;
    default:
        Console.WriteLine("The character is a Consonant");
        break;
}

// ejercicio 11
// Escribe un programa que pida al usuario dos números y muestre si son iguales o diferentes
// usando if-else

Console.WriteLine("Enter number 1: ");
int number11 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number22 = Convert.ToInt32(Console.ReadLine());

if (number11 > number22)
{
    Console.WriteLine($"The number {number11} is greater");
}
else if (number22 > number11)
{
    Console.WriteLine($"The number {number22} is greater");
}
else
{
    Console.WriteLine("Both numbers are equal");
}


// Ejercicio 12
// Escribe un programa que solicite al usuario que ingrese su dirección. Verifica si la dirección
// no es nula, no está vacía y no consiste solo en espacios en blanco. Si la dirección es válida,
// muestra un mensaje de confirmación; de lo contrario, muestra un mensaje de error.


Console.WriteLine("Enter to address: ");
string? address = Console.ReadLine();


if (string.IsNullOrWhiteSpace(address))
{
    Console.WriteLine("Sorry, you entered an invalid address");
}
else
{
    Console.WriteLine("Address: " + address);
}

// ejercicio 13
// Escribe un programa que pida al usuario un número y determine si es positivo, negativo o
// cero usando if-else.

Console.WriteLine("Enter to number: ");
int number33 = Convert.ToInt32(Console.ReadLine());

if (number33 < 0)
{
    Console.WriteLine("The number is negative");
}
else if (number33 > 0)
{
    Console.WriteLine("The number is positive");
}
else
{
    Console.WriteLine("The number is cero");
}


// ejercicio 14
// Escribe un programa que pida al usuario una letra y determine si es una vocal usando if-
// else.

Console.WriteLine("Enter to character: ");
char? character2 = Convert.ToChar(Console.ReadLine() ?? string.Empty);

if (character2 == 'a' || character2 == 'e' || character2 == 'i' || character2 == 'o' || character2 == 'u')
{
    Console.WriteLine("The character is a vowel");
}
else
{
    Console.WriteLine("The character is a Consonant");  
}

// ejercicio 15
// Escribe un programa que pida al usuario una temperatura en grados Celsius y determine si
// es caliente (mayor a 30), templada (entre 10 y 30) o fría (menor a 10) usando if-else

Console.WriteLine("Enter to temperature: ");
float temperature = float.Parse(Console.ReadLine() ?? string.Empty);

if (temperature < 10)
{
    Console.WriteLine("Cold");
}
else if (temperature >= 10 || temperature > 30)
{
    Console.WriteLine("mild");
}
else
{
    Console.WriteLine("Hot");
}

// ejercicio 16
// Escribe un programa que pida al usuario un año y determine si es un año bisiesto usando
// if-else
Console.WriteLine("Enter to year: ");
int year = Convert.ToInt32(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
    Console.WriteLine("Is leap year");
}
else
{
    Console.WriteLine("Not leap year");
}


// Ejercicio 17
// Escribe un programa que pida al usuario que ingrese un valor. Verifica si el valor ingresado
// no es nulo, no está vacío y no contiene solo espacios en blanco. Si la entrada es válida,
// muestra el valor; de lo contrario, pide al usuario que ingrese un valor válido.

Console.WriteLine("Enter to number: ");
string? number41 = Console.ReadLine();

if (string.IsNullOrWhiteSpace(number41))
{
    Console.WriteLine("Enter to valid number");
}
else
{
    Console.WriteLine("Number is valid: " + number41);
}


// ejercicio 18
// Escribe un programa que pida al usuario un número del 1 al 7 y determine si es un día
// laborable o de fin de semana usando switch

Console.WriteLine("Enter to number of the week (1-7): ");
int week1 = Convert.ToInt32(Console.ReadLine());

switch (week1)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("working day");
        break;
    case 6:
    case 7:
        Console.WriteLine("non-working day");
        break;
    default:
        Console.WriteLine("Sorry, you entered an invalid week");
        break;
}
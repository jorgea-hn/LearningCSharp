// 1 ejercicio 
// Escribe un programa que imprima "Hola mundo"

Console.WriteLine("Hello, World!");

// 2 Ejercicio
// Declara un int y un string, asignarles valores e imprimelos
int edad = 28;
Console.WriteLine($"Tu edad es{edad}");

string nombre = "jorge";
Console.WriteLine($"Tu nombre es {nombre}");

// 3 Ejercicio
// Convierte un string a mayuscula y a minuscula

string ciudad = "Barranquilla";
Console.WriteLine(ciudad);
Console.WriteLine(ciudad.ToLower());
Console.WriteLine(ciudad.ToUpper());

// 4 ejercicio
// Declara dos int, realiza suma, resta, multiplicacion y division y muestra los resultados

int number1 = 8;
int number2 = 6;

double suma = number1 + number2;
double resta = number1 - number2;
double multiplicacion = number1 * number2;
double division = number1 / number2;

Console.WriteLine($"suma {suma}");
Console.WriteLine($"resta {resta}");
Console.WriteLine($"multiplicacion {multiplicacion}");
Console.WriteLine($"division {division}");

// 5 ejercicio
// declara dos int, realiza comparaciones de igualdad, desigualdad, mayor que, menor que, y muestra los resultados

int valor1 = 10;
int valor2 = 12;

if (valor1 > valor2)
{
    Console.WriteLine("Valor 1 es mayor");
}
else if (valor1 == valor2)
{
    Console.WriteLine("Valores iguales");
}

// 6 ejercicio
// Busca una palabra especifica en un string y reemplazarla por otra

string frase = " El sol es negro";
Console.WriteLine(frase);

Console.WriteLine(frase.Replace("negro", "amarillo"));



// 7 ejercicio
// Pide al usuario su nombre y su edad, luego imprime un mensaje con esta informacion

Console.WriteLine("Enter username: ");
var userName = Console.ReadLine();

Console.WriteLine("Enter age: ");
var age = Console.ReadLine();

Console.WriteLine("Username is: " + userName + " age is " + age);

// 8 ejercicio
// Declara un int y escribe un programa que indique si es mayor , menor o igual a 10

int numero4 = 8;

if (numero4 > 10)
{
    Console.WriteLine($"Numero {numero4} es mayor que 10");
}
else if (numero4 < 10)
{
    Console.WriteLine($"Numero {numero4} es menor que 10");
}
else {
    Console.WriteLine($"Numero {numero4} es igaul que 10");
}


// 9 ejercicio
// declara dos variables double, realiza suma, resta, multiplicacion, division y muestra los resultados

double var1 = 12.5;
double var2 = 3.5;

double suma1 = var1 + var2;
Console.WriteLine(suma1);

double resta1 = var1 - var2;
Console.WriteLine(resta1);

double multiplicacion1 = var1 * var2;
Console.WriteLine(multiplicacion1);

double division1 = var1 / var2;
Console.WriteLine(division1);

// 10 ejercicio
// Declarar dos variables string, concatenarlas y mostrar el resultado

string name = "jorge";
string lastname = "henriquez";

Console.WriteLine(name + lastname);

// 11 ejercicio
// Declara una variable int, conviertela a double y muestra ambos valores

int variable10 = 10;
Console.WriteLine(variable10);
double variable11 = variable10;
Console.WriteLine(variable11);
Console.WriteLine(Convert.ToDouble(variable10));


// 16 ejercicio
// Concatena dos string y muestra la longitud de cada uno


string nombre3 = "Jorge";
string nombre4 = "Alberto";

string nombreCompleto = nombre3 + nombre4;
Console.WriteLine(nombreCompleto);
Console.WriteLine(nombre3.Length);
Console.WriteLine(nombre4.Length);



// 17 ejercicio
// Extrae una subcadena de un string y muestra la subcadena y su longitud

string frase1 = "Hola soy Coder Riwi";
Console.WriteLine(frase1);
string subcadena = frase1.Substring(9);
Console.WriteLine(subcadena);
Console.WriteLine(subcadena.Length);


// 14 ejercicio
// Elimina los espacios en blanco al inicio y al final de un string, y formatea el string para que empiece con mayuscula y el resto en minuscula

string ciudad2 = "  BaRRanquiLLa  ";

string cadenaLimpia = ciudad2.Trim().ToLower();
Console.WriteLine(char.ToUpper(cadenaLimpia[0])+ cadenaLimpia.Substring(1));
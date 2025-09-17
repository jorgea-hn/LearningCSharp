// Metodos linQ--------------------------------------------------------------------------------------------------------
// int[] numbers = {1,2,3,4,5};
//
// var result = numbers.Where(num => num >4 ).ToList();
//
// foreach (var num in result)
// {
//     Console.WriteLine(num);
// }


// string [] fruits = {"apple", "banana", "cherry"};
//
// var result = fruits.Select(fruit => fruit.ToUpper()).ToList();
//
// foreach (var fruit in result)
// {
//     Console.WriteLine(fruit);
// }



// Ejercicios 

// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

/*
    Filtrar y mostrar solo los números pares de la lista numbers.
    Usando LINQ, calcular la suma de todos los números impares en la lista numbers.
    Ordenar de manera descendente los números mayores que 5 en la lista numbers.
    Contar cuántos números son menores o iguales a 3 en la lista numbers.
    Seleccionar cada número en la lista numbers y multiplicarlo por 2.
 */

// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var result = numbers.Where(n => n % 2 == 0).ToList();
//
// Console.WriteLine("Resultado: ");
// foreach (var num in result)
// {
//     Console.WriteLine(num);
// }
 
// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var result = numbers.Where(n => n % 2 != 0).ToList();
// var suma = 0;
// Console.WriteLine("Resultado: ");
// foreach (var num in result)
// {   
//     suma += num;
//     
// }
// Console.WriteLine(suma);


// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var result = numbers.OrderByDescending(number => number)
//                      .Where(number => number > 5)
//                       .ToList();
//
// Console.WriteLine("Resultado: ");
// foreach (var num in result)
// {   
//     Console.WriteLine(num);
// }

// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var result = numbers.Where(number => number <= 3).ToList();
//
// var contador = 0;
//
// Console.WriteLine("Resultado: ");
// foreach (var num in result)
// {
//     contador++;
// }
//
// Console.WriteLine(contador);


// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// var result = numbers.Select(numbers => numbers * 2).ToList();
//
// Console.WriteLine("Resultado: ");
// foreach (var num in result)
// {
//     Console.WriteLine(num);
// }

 
 // List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David",
 // "Eve" };
 
 /*
    Ordenar los nombres en la lista names alfabéticamente.
    Seleccionar los nombres en la lista names que empiezan con la letra 'A'.
    Contar cuántos nombres en la lista names tienen más de 5 caracteres.
    Concatenar todos los nombres de la lista names en una sola cadena separada por
    espacios.
    Encontrar y mostrar el nombre más largo en la lista names.
 */

 // List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
 // var result = names.OrderBy(name => names ).ToList();
 //
 // foreach (var name in result)
 // {
 //     Console.WriteLine(name);
 // }


//  List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
//  var result = names.Where(name => name.StartsWith("A")).ToList();
// foreach (var name in result)
// {
//     Console.WriteLine(name);
// }

//  List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
// var result = names.Where(name => name.Length > 5).ToList();
//
// foreach (var name in result)
// {
//     Console.WriteLine(name);
// }

//  List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
//  var result = names.Select(name => name + " ").ToList();
//  string namesS = "";
//  
// foreach (var name in result)
// {
//     namesS += name;
// }
//
// Console.WriteLine(namesS.TrimEnd());

 // List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
 // var result = names.Where(name => name.Length > 0 ).ToList();
 // int contador = 0;
 //    foreach (var name in result)
 //    {
 //       if (name.Length > contador)
 //       {
 //          contador = name.Length;
 //       }
 //       
 //    }
 //
 //    foreach (var name in result)
 //    {
 //       if (name.Length == contador)
 //       {
 //          Console.WriteLine(name);
 //       }
 //    }
    
    

 // List<string> words = new List<string> { "apple", "banana", "cherry", "date",
 // "elderberry" };
 
 /*
    Verificar si todas las palabras en la lista words tienen más de 3 caracteres.
    Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.
    Contar cuántas palabras en la lista words contienen la letra 'e'.
    Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.
    Verificar si alguna palabra en la lista words termina con la letra 'y'.
  */


// List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };
//   
// var result = words.All(word => word.Length > 3);
// if (result)
// {
//     Console.WriteLine("satisfies the condition");
// }
// else
// {
// Console.WriteLine("doesn't satisfies the condition");
// }


 // List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry"};
 // var result = words.Where(word =>word.StartsWith("b")).ToList();
 // foreach (var word in result)
 // {
 //     Console.WriteLine(word);
 // }

 // List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };
 // var result = words.Count(word => word.Contains("e"));
 // Console.WriteLine(result);


 // List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };
 // var result = words.Select(word => word.ToUpper()).ToList();
 // foreach (var word in result)
 // {
 //    Console.WriteLine(word);
 // }

//  List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };
//  var result = words.Any(words => words.EndsWith("y"));
// Console.WriteLine(result ?  "yes" : "No");

  // List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
  // List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };
  
  // Combinar y ordenar las listas data y moreData de forma ascendente.
  //    Calcular la suma de todos los números pares en la lista data.
  //    Encontrar el número más grande en la lista data.
  //    Unir las listas data y moreData, eliminando los elementos duplicados.
  //    Calcular el promedio de la lista moreData y seleccionar los números en data que son
  //    mayores que ese promedio.
  //    Contar cuántos números en la lista moreData son números primos(te recomiendo crear
  //    una función independiente que valide si el número es primo o no lo es, luego esa funciona
  // pasala al método LINQ adecuado).

// --------------------------------------------------------------------------------------------------------------------
  // List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
  // List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };
  //
  // var result = data.Concat(moreData).OrderBy(x => x).ToList();
  // foreach (var item in result)
  // {
  //     Console.WriteLine(item);
  // }

// ---------------------------------------------------------------------------------------------------------------------
  // List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
  // List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };
  //
  // var result = data.Concat(moreData).OrderBy(x => x).Where(x => x % 2 == 0).Sum();
  // Console.WriteLine(result);

// ---------------------------------------------------------------------------------------------------------------------
//   List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
//   List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };
//
//   var result = data.Concat(moreData).OrderBy(x => x).Max();
// Console.WriteLine(result);
//     

// ---------------------------------------------------------------------------------------------------------------------
// List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
// List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };
// var result = data.Concat(moreData).OrderBy(x => x).Average();
// var result2 = data.Concat(moreData).OrderBy(x => x).Where(x => x > result).ToList();
//
// foreach (var item in result2)
// {
//     Console.WriteLine(item);
// }

// ---------------------------------------------------------------------------------------------------------------------
// List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
// List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };
//
// int numeroPrimo(int number)
// {
//     int contador = 0;
//     
//     if (number == 1)
//     {
//         return 1;
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
//         return contador > 1 ? 0 : 1;
//     }
// }
//
//
// var result = moreData.Where(x=>numeroPrimo(x)==1).ToList();
// foreach (var item in result)
// {
//     Console.WriteLine(item);
// }




  
  // ----------------------------------------------------------------------------------
  // ----------------------------- PROYECTO PRACTICO ----------------------------------
  // ----------------------------------------------------------------------------------
  
   //   Proyecto Práctico: Analizador de Ventas para una Tienda de
   // electrodomésticos
   // Debes hacer primeros los ejercicios y luego pasar al taller
   // El objetivo del proyecto es desarrollar un sistema de análisis de ventas para una tienda, que permita
   // registrar ventas, calcular sumas, promedios y totales de ventas por producto o por período de
   // tiempo.
   // Este proyecto debe ser realizado mediante la creación de una clase, aún no hemos visto clases por
   // lo tanto van a tener que hacer un poco de trabajo de investigación, sin embargo si realizaron los
   // ejercicios esto será pan comido.
   // Deberás crear la clase “Venta”, dicha clase debe tener estas propiedades:
   
   //
   // Id => ¿sera que C# tiene algún tipo de dato especial para los ID?
   // FechaDeVenta
   // ValorProducto
   // CantidadDeProductos
   // Vendedor
   // Comprador
   // TiempoGarantiaFuncionalidades
   //
   // Crear una interfaz de usuario simple que permita interactuar con las funcionalidades
   // implementadas

   // Permitir registrar nuevas ventas en una lista o otra estructura de datos si desean intentarlo.
   // Desarrollar funcion para calcular el valor total de una venta específica.
   // Desarrollar funcion para calcular el promedio de ventas diarias
   // Mostrar el empleado del Mes (empleado que tenga las mejores ventas)
   // Mostrar el cliente del Mes (cliente que haya comprado mas)
   // Filtrar una lista de ventas para obtener todas las ventas realizadas después de una fecha
   // específica.
   // Seleccionar los nombres de los vendedores que realizaron ventas por encima de cierto valor.
   // Agrupar las ventas por mes y calcular el total de ventas mensuales.
   // Encontrar el vendedor con el mayor número de ventas en un período específico.
   // Ordenar las ventas por valor total descendente y mostrar las primeras N ventas.
   // Encontrar los productos más vendidos por cantidad en un año determinado.
   // Validar si existe alguna venta con un valor específico.
   // Buscar todas las ventas realizadas a un cliente específico.
   // Calcular el total de ventas para cada vendedor y mostrar el promedio de ventas por
   // vendedor.
   // Encontrar el mes con el mayor número de ventas y mostrar las ventas de ese mes.

   using _05___LinQ.Models;

   Venta venta1 = new Venta(new DateOnly(2025, 9, 1), 1500.50f, 3, "Juan", "Pedro", new DateOnly(2025, 12, 1));
   Venta venta2 = new Venta(new DateOnly(2025, 9, 2), 800.75f, 1, "Ana", "Maria", new DateOnly(2025, 11, 2));
   Venta venta3 = new Venta(new DateOnly(2025, 9, 3), 320.00f, 5, "Juan", "Luis", new DateOnly(2025, 10, 3));
   Venta venta4 = new Venta(new DateOnly(2025, 9, 4), 129.99f, 8, "Sofia", "Pedro", new DateOnly(2025, 12, 4));
   Venta venta5 = new Venta(new DateOnly(2025, 9, 5), 2000.00f, 1, "Luis", "Maria", new DateOnly(2026, 1, 5));
   Venta venta6 = new Venta(new DateOnly(2025, 9, 6), 499.90f, 4, "Ana", "Veronica", new DateOnly(2025, 12, 6));
   Venta venta7 = new Venta(new DateOnly(2025, 9, 7), 600.00f, 2, "Sofia", "Roberto", new DateOnly(2025, 11, 7));
   Venta venta8 = new Venta(new DateOnly(2025, 9, 8), 75.25f, 10, "Laura", "Pedro", new DateOnly(2025, 10, 8));
   Venta venta9 = new Venta(new DateOnly(2025, 9, 10), 250.00f, 6, "Juan", "Maria", new DateOnly(2025, 11, 9));
   Venta venta10 = new Venta(new DateOnly(2025, 9, 10), 1100.30f, 2, "Luis", "Roberto", new DateOnly(2026, 1, 10));

   // Registrar ventas
   venta1.Registrar();
   venta2.Registrar();
   venta3.Registrar();
   venta4.Registrar();
   venta5.Registrar();
   venta6.Registrar();
   venta7.Registrar();
   venta8.Registrar();
   venta9.Registrar();
   venta10.Registrar();
    
   // Mostrar todas las ventas registradas
   Console.WriteLine("\nVentas registradas:");
   Venta.MostrarVentasRegistradas(); 
   
   // Mostrar valor total de una venta especifica
   Console.WriteLine("\nVentas registradas:");
   Console.WriteLine(Venta.VentaEspecifica(venta1.Id));




   
   

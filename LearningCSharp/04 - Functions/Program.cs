// void greeting(string name)
// {
//     System.Console.WriteLine($"Welcome {name}");
// }
//
//
// greeting("JORGE");

//
// int Suma(int a, int b)
// {
//     return a + b;
// }
//
// int resultado = Suma(3, 4);
// Console.WriteLine($"resultado: {resultado}");

Console.WriteLine("Array -------------------------------------");
int[] numbers = { 10, 20, 30, 40, 50 };
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"numbers at index {i}:  {numbers[i]}");
}

Console.WriteLine("List -------------------------------------");
List<int> numbers2 = new List<int> { 10, 20, 30, 40, 50 };
for (int i = 0; i < numbers2.Count; i++)
{
    Console.WriteLine($"numbers at index {i}:  {numbers2[i]}");
}
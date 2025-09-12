// Metodos linQ--------------------------------------------------------------------------------------------------------
int[] numbers = {1,2,3,4,5};

var result = numbers.Where(num => num >4 ).ToList();

foreach (var num in result)
{
    Console.WriteLine(num);
}


// string [] fruits = {"apple", "banana", "cherry"};
//
// var result = fruits.Select(fruit => fruit.ToUpper()).ToList();
//
// foreach (var fruit in result)
// {
//     Console.WriteLine(fruit);
// }
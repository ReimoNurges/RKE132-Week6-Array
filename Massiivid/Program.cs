//string[] fruits = { "apples", "bananas", "oranges" };
string[] fruits = new string[3];

fruits[0] = "apples";
fruits[1] = "bananas";
fruits[2] = "oranges";

int fruitarraylenght = fruits.Length;

Console.WriteLine(fruitarraylenght);

for (int i = 0; i < fruitarraylenght; i++)
{
    fruits[i] = fruits[i].Replace(fruits[i][0], char.ToUpper(fruits[i][0]));
    
    Console.WriteLine(fruits[i]);
}

foreach (string element in fruits)
{
    Console.WriteLine(element);
} 
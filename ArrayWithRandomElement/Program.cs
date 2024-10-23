string[] snack = { "sushi", "pizza", "burgesr" };

Random rnd = new Random();

int randomindex = rnd.Next(0, snack.Length);
 Console.WriteLine($"Thonight we are going to eat {snack[randomindex]}");



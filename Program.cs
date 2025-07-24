Random coin = new Random();

bool resultado = coin.Next(2) == 0;

Console.Clear();

if (resultado)
{
    Console.WriteLine("The coin show heads");
}
else
{
    Console.WriteLine("The coin shows tails");
}
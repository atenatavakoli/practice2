


char x;


do
{
    x = Console.ReadKey().KeyChar;

} while (!char.IsDigit(x));

Console.WriteLine("End");
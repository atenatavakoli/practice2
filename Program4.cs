


char x;


do
{
    x = Console.ReadKey().KeyChar;

} while (!char.IsLetter(x) );

Console.WriteLine("End");
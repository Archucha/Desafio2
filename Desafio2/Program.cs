int cantidad;
Console.WriteLine("ingrese de donde arrancar la piramide");
cantidad=int.Parse(Console.ReadLine());
Console.WriteLine(" ");
for (int i = 1; i <= cantidad; i++)
{
    Console.SetCursorPosition((Console.WindowWidth - cantidad) / 2, Console.CursorTop);
    for (int j = cantidad - i; j > 0; j--)
    {
        Console.Write(" ");
    }
    for (int j = 1; j < i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("*");
}
Console.ReadKey();

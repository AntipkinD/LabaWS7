using LabaWS7;

internal class Program
{
    private static void Main(string[] args)
    {
        SomeClass<double> somecl = new(7, 1, 88, 49.5, 11, 16, 12, 78);
        SomeClass<int> somecl1 = new(3, 43, 3);
        SomeClass<string> somecl2 = new(2, "f", "pay respect");

        SomeClass<double>.toAdd(somecl, 45);
        Console.WriteLine("Длина массива");
        Console.WriteLine(SomeClass<double>.getLength(somecl));
        Console.WriteLine("Массив с добавлением");
        SomeClass<double>.toAdd(somecl, 45);
        Console.WriteLine("Длина массива с добавлением");
        Console.WriteLine(SomeClass<double>.getLength(somecl));
        Console.WriteLine("Элемент массива номер 5");
        Console.WriteLine(SomeClass<double>.getByIndex(somecl, 5));
        Console.WriteLine("Массив с удалением");
        SomeClass<double>.toDelete(somecl, 5);
        Console.WriteLine("Элемент массива с удалением номер 5");
        Console.WriteLine(SomeClass<double>.getByIndex(somecl, 5));
    }
}
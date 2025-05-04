using System;
using System.Text;

class Trapezoid
{
    public int LowerBase { get; set; }
    public int UpperBase { get; set; }

    public Trapezoid(int lowerBase, int upperBase)
    {
        LowerBase = lowerBase;
        UpperBase = upperBase;
    }

    public string GetInfo()
    {
        Console.OutputEncoding = Encoding.UTF8;
        return $"Нижня основа: {LowerBase}, Верхня основа: {UpperBase}";
    }

    public double CalculateHalfSum()
    {
        return (LowerBase + UpperBase) / 2.0;
    }
}

// 🔽 Клас-нащадок з додатковим полем "Height"
class TrapezoidWithHeight : Trapezoid
{
    public double Height { get; set; }

    public TrapezoidWithHeight(int lowerBase, int upperBase, double height)
        : base(lowerBase, upperBase)
    {
        Height = height;
    }

    public double CalculateArea()
    {
        return CalculateHalfSum() * Height;
    }

    public string GetFullInfo()
    {
        return $"{GetInfo()}, Висота: {Height}, Площа: {CalculateArea()}";
    }
}

// 🔽 Демонстрація
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Об'єкт предка
        Trapezoid t1 = new Trapezoid(10, 14);
        Console.WriteLine("Обʼєкт базового класу:");
        Console.WriteLine(t1.GetInfo());
        Console.WriteLine($"Середнє значення основ: {t1.CalculateHalfSum()}");

        // Об'єкт нащадка
        TrapezoidWithHeight t2 = new TrapezoidWithHeight(10, 14, 5);
        Console.WriteLine("\nОбʼєкт нащадка:");
        Console.WriteLine(t2.GetFullInfo());
    }
}

using SquareLib;

Console.WriteLine($"Выберете фигуру для вычисления площади:\n 1.Круг \n 2.Треугольник");
int numberMenu = Convert.ToInt32(Console.ReadLine());

switch (numberMenu)
{
    case 1:

        Console.WriteLine("Введите значение радиуса:");
        double r = Convert.ToDouble(Console.ReadLine());

        Figure circle = new Сircle(r);
        circle.DisplayInfo();
    break;

    case 2:

        Console.WriteLine("Введите значение стороны A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение стороны B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение стороны C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Figure triangle = new Triangle(a, b, c);
        triangle.DisplayInfo();
    break;

    default:
        break;
}


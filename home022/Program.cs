// метод
double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    return result;
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// запрос координат
Console.WriteLine("Hello, World!");
int x1 = EnterData("Введите координату X1: ");
int y1 = EnterData("Введите координату Y1: ");
int z1 = EnterData("Введите координату Z1: ");
int x2 = EnterData("Введите координату X2: ");
int y2 = EnterData("Введите координату Y2: ");
int z2 = EnterData("Введите координату Z2: ");
//анализ данных
double resalt = FindDistance(x1, y1, z1, x2, y2, z2);
//Вывод результата
Console.WriteLine($"Расстояние между точками равно { resalt }");
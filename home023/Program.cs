// методы
void Table(int N)
{
    int i = 1;
    while (i <= N)
    {
        Console.Write(i*i*i+", ");
        i++;
    }   
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//запрос числа
int N = EnterData("Введите число: ");
//решение
Table(N);
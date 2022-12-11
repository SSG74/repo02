// metod
void rang(string str)
{
    if (str.Length ==5)
    {
        if (str[0] == str[4] && str[1] == str[3])
        {
            Console.WriteLine($"Число {str} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {str} не является палиндромом");
        }
    } 
    else  
    {  
        Console.WriteLine($"Число {str} не является пятизначным");
    }
}
string EnterData(string text)
{
    Console.Write(text);
    string number = Console.ReadLine();
    return number;
}
//запрос числа
string N = EnterData("Введите пятизначное число: ");
rang(N);
// Задача 41. Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввел пользователь.



Console.Write("Введите числа через запятую: ");
int[] numbers = StringNum(Console.ReadLine());
int SUMMA = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        SUMMA++;
    }
}

Console.WriteLine($"Вы ввели {SUMMA} чисел больше 0");

int[] StringNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int N = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }

        else
        {
            temp += input [i].ToString();

            break;
        }
        }
        numbers[N] = Convert.ToInt32(temp);

        N++;
    }
    return numbers;
}

// Задача 43. Напишите программу, которая найдет точку пересечения двух прямых, заданных
// уравнениями y=k1*x+b1, y=k2*x+b2, значения b1,k1,b2 и к2 задаются пользователем.

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"координаты точки пересечения двух прямых X: {x}, Y: {y}");

 

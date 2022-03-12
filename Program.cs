using System;
class Program
{

    static void Main(string[] args)
    {
        bool quit =true;
        float first = 0;
        float second = 0;
        float res = 0;
        string oper;
        do
        {
            do
            {
                Console.Write("Введите первое число:");
                if (float.TryParse(Console.ReadLine(), out first))
                {
                    break;
                }
            }
            while (true);
            Console.Write("Введите знак:");
            oper =Console.ReadLine();

            do
            {
                Console.Write("Введите второе число:");
                if (float.TryParse(Console.ReadLine(), out second))
                {
                    break;
                }
            }
            while (true);

            switch (oper)
            {
                case "+":
                    {
                        Console.WriteLine("Сумма чисел составляет: " + (res = Sum(first, second)));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine("Разность чисел состовляет: " + (res = Sub(first, second)));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine("Произведение чисел составляет: " + (res = Mult(first, second)));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("Отношение чисел составляет:" + (res = Div(first, second)));
                        break;
                    }
                case "L":
                    {
                        quit = false; break;
                    }

            }
        }
        while (quit);
    } 


    static float Sum(float first, float second)
    {
        return first + second;
    }
    static float Sub(float first, float second)
    {
        return first - second;
    }
    static float Div(float first, float second)
    {
        float result;
        if (second == 0)
        {
            Console.WriteLine("На ноль делить нельзя");
            result = 0;
        }
        else
        {
            result = (first / second);
        }
        return result;
    }
    static float Mult(float first, float second)
    {
        return first * second;
    }
}  
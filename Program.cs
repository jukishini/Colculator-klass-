using System;
class Program
{

    static void Main(string[] args)
    {

        double a;
        double b;
        double res = 0;
        char oper;
        do
        {
            do
            {
                Console.Write("Введите первое число:");
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    break;
                }
            }
            while (true);
            // a = Convert.ToDouble();
            Console.Write("Введите знак:");
            oper = Convert.ToChar(Console.ReadLine());

            do
            {
                Console.Write("Введите второе число:");
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    break;
                }
            }
            while (true);///b = Convert.ToDouble(Console.ReadLine());
            {
                if (oper == '+')
                {
                    res = Sum(a, b);
                }

                else if (oper == '-')
                {
                    res = Sub(a, b);
                }

                else if (oper == '*')
                {
                    res = Mult(a, b);
                }

                else if (oper == '/')
                {
                    res = Div(a, b);
                    
                } 
                else if (oper == 'L')
                
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неизвестный знак.");
                }
                Console.WriteLine("Результат: {0}", res);
                Console.WriteLine(); 
            }
        }
        while (true);
    } 


    static double Sum(double first,double second)
    {
        return first + second;
    }
    static double Sub(double first, double second)
    {
        return first - second;
    }
    static double Div(double first, double second)
    {
        double result;
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
    static double Mult(double first, double second)
    {
        return first * second;
    }
}
    




    
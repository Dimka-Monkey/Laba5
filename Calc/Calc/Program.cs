namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберете операцию: + - * / %");
            String c = Console.ReadLine();
            double res = 0;
            switch (c)
            {
                case "+": res = a+b; break;
                case "-": res = a-b; break;
                case "*": res = a*b; break;
                case "/": 
                    if (b == 0) 
                    { 
                        Console.WriteLine("Делить на ноль нельзя"); res = -99999999; 
                    }
                    else
                    {
                        res = a/b;
                    }
                    break;
                case "%":
                    res = (a/b)*100;
                    break;

            }
            Console.WriteLine("Ответ: {0}",res);
        }
    }
}
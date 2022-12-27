using System;

namespace PracaDomowaSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rozgrzewka
            //Zadanie 2
            //Console.WriteLine("Podaj swoje imię:");
            //var name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);
            //Zadanie 3
            int result = 5 + 9;
            Console.WriteLine(result);
            //Operatory Zadanie 1
            int number = 1;
            float money = 2.99f;
            string text = "Tekst";
            bool isLogged = true;
            char myChar = 'm';
            decimal price = 2.657M;
            Console.WriteLine(number);
            Console.WriteLine(money);
            Console.WriteLine(text);
            Console.WriteLine(isLogged);
            Console.WriteLine(myChar);
            Console.WriteLine(price);
            //Zadanie 2
            string myAge = "myAge: ";
            int wifeAge = 18;
            var result2 = myAge + wifeAge;
            Console.WriteLine(result2);
            //Zadanie 3
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;
            bool and = isTrue & isFalse;
            bool or = isTrue & isReallyTrue;
            bool negative = !isFalse;
            Console.WriteLine(and);
            Console.WriteLine(or);
            Console.WriteLine(negative);
            //Zadanie 4
            int a = 5;
            int b = 12;
            int add = a + b;
            int sub = a - b;
            int div = a / b;
            int mul = a * b;
            int mod = a % b;
            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.WriteLine(mod);
            //Zadanie 5
            string ax = "Ala ";
            string bx = "ma ";
            string cx = "kota";
            var result3 = ax + bx + cx;
            Console.WriteLine(result3);
            //Udało się pomyślnie złączyć 3 stringi uwzględniając spacje
            //Instrukcje i Pętle
            //Zadanie 1
            int n1 = 10;
            int n2 = 20;
            if (n2 > n1)
            {
                Console.WriteLine(n2 + " Jest wieksze niz " + n1);
            }
            else
            {
                Console.WriteLine(n2 + " jest rowne " + n1);
            }
            //Zadanie 2
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }
            int zed = 0;
            while (zed < 10)
            {
                Console.WriteLine("c#");
                zed++;
            }
            //Zadanie 3
            int n = 10;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " Przysta");
                }
                else
                {
                    Console.WriteLine(i + " Nieparzysta");
                }
            }
            //Zadanie 4*
            n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
            }
            //Zadanie 5*
            int exam = -1;
            switch (exam)
            {
                case > 100 || <1: Console.WriteLine("Wynik poza skala");
                    break;
                case < 90:
                    Console.WriteLine("dziala")
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace PracaDomowa
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
            int exam = 57;
            if(exam < 1||exam > 100)
            {
                Console.WriteLine("Wynik poza skala");
            }
            else if(exam <=100 &exam>=99)
            {
                Console.WriteLine("Ocena Celujaca");
            }
            else if (exam <=98 & exam >= 85)
            {
                Console.WriteLine("Ocena Bardzo dobra");
            }
            else if (exam <= 84 & exam >= 70)
            {
                Console.WriteLine("Ocena Dobra");
            }
            else if (exam <= 69 & exam >= 55)
            {
                Console.WriteLine("Ocena Dostateczna");
            }
            else if (exam <= 54 & exam >= 40)
            {
                Console.WriteLine("Ocena Dopuszczajaca");
            }
            else if (exam <= 39 & exam >= 0)
            {
                Console.WriteLine("Ocena Niedostateczna");
            }
          
            //Kolekcje
            //zadanie 1
            string[] colors = new string[] {"czarny","czerwony","bialy","niebieski" };
            Console.WriteLine("Moj pierwszy kolor to: "+colors[0]);
            Console.WriteLine("Moj drugi kolor to: "+colors[1]);
            //zadanie 2
            Console.WriteLine("Petla for");
            int[] tabliczby = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Liczba: "+tabliczby[i]);

            }
            Console.WriteLine("Petla foreach");
            foreach (int num in tabliczby) 
            {
                Console.WriteLine("Liczba: "+num);
            }
            Console.WriteLine("Petla while");
            int iterator = 0;
            while (iterator<10)
            {
                Console.WriteLine("Liczba: " + tabliczby[iterator]);
                iterator++;
            }
            //zadanie 3 w zadaniu jest błąd ponieważ w drugim podpunkcie jest dodawanie za pomoca metody remove?
            List<string> list = new List<string>();
            list.Add("Ananas");
            list.Add("Arbuz");
            list.Add("Papaja");
            list.Add("Smoczy owoc");
            foreach (string owoc in list)
            {
                Console.Write(owoc + ", ");
            }
            Console.WriteLine("Usuwany pierwszy i ostatni owoc");
            list.RemoveAt(0);
            list.Remove("Smoczy owoc");
            foreach (string owoc in list)
            {
                Console.Write(owoc + ", ");
            }

            Console.ReadKey();
        }
    }
}

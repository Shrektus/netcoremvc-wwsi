using Library.Domain;
using Library.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Zadanie 1
            Book book = new Book();
            BooksRepository repository = new BooksRepository();*/

            //Zadanie 2 
            /*
             * Console.WriteLine("Podaj Login");
            string login = Console.ReadLine();
            Console.WriteLine("Podaj haslo");
            string haslo = Console.ReadLine();
            if(login == "Admin"& haslo == "password")
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
            */
            //Zadanie 3
            BooksRepository repko = new BooksRepository();
            BookService bookserwis = new BookService(repko);
             string input = null;
            while(input!= "wyjdz")
            {
                Console.Clear();
                Console.WriteLine("Dostepne komendy: \ndodaj\nusun\nwypisz\ndodaj zamowienie\nlista zamowien");
                input = Console.ReadLine();
                if (input == "dodaj")
                {
                    Console.WriteLine("proba dodanie ksiazki");
                    bookserwis.AddBook();

                }
                else if (input == "usun")
                {
                    Console.WriteLine("proba usuniecia ksiazki");
                    bookserwis.RemoveBook();
                }
                else if (input == "wypisz")
                {
                    Console.WriteLine("proba wypisania wszystkich ksiazek");
                    bookserwis.ListBooks();
                }
                else if (input == "dodaj zamowienie")
                {
                    Console.WriteLine("Proba doadnie nowego zamowienia");
                }
                else if (input == "lista zamownien")
                {
                    Console.WriteLine("Proba proba wypisania wszyskich zamowien");
                }
                else
                {
                    Console.WriteLine("Komenda nie jest wspierana");
                }
                
                Console.WriteLine("Press anyKey to Continue");
                Console.ReadKey();
            }
            

            Console.ReadKey();
        }
    }
}

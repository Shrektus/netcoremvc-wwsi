using Library.Domain;
using Library.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    internal class BookService
    {
        public BookService() { }

        public BookService(BooksRepository _repository) 
        {
            this._repository = _repository;
        }
        public BooksRepository _repository;

        public void AddBook()
        {
            Console.WriteLine("Wprowadz tytul ksiazki");
            string tytul = Console.ReadLine();
            Console.WriteLine("Wprowadz autora ksiazki");
            string author = Console.ReadLine();
            Console.WriteLine("Wprowadz rok publikacji ksiazki");
            int rokPublikacji = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadz isbn ksiazki");
            string isbn = Console.ReadLine();
            Console.WriteLine("Wprowadz ilosc dostepnych egzemplarzy ksiazki");
            int sztuki = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadz rok publikacji ksiazki");
            decimal cena = Convert.ToDecimal(Console.ReadLine());
            Book komiks = new Book(tytul, author, rokPublikacji, isbn, sztuki, cena);
            _repository.Insert(komiks);
            
        }
        public void RemoveBook()
        {
            Console.WriteLine("Podaj Tytul ksiazki");
            string tytul = Console.ReadLine();
            Console.WriteLine("Pomyslnie usunieto");
        }
        public void ListBooks() 
        {
            Console.WriteLine("Lista ksiazek");
            foreach (Book book in _repository.GetAll()) 
            {
                Console.WriteLine(book.Title);
            } 
        }

        public void ChangeState() 
        {
            Console.WriteLine("Podaj Tytul ksiazki");
            string tytul = Console.ReadLine();
            Console.WriteLine("Podaj stan ksiazki");
            int stan =Convert.ToInt32(Console.ReadLine());

        }
    }
}

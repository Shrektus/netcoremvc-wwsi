﻿using Library.Domain;
using Library.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(/*uzupelnij parametry*/);
            BooksRepository repository = new BooksRepository();
        }
    }
}

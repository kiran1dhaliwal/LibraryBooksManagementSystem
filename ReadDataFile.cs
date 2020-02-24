using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class ReadDataFile
    {
        public List<Book> readBooks(string fileName)
        {
            List<Book> unchechedBooks = new List<Book>();
            StreamReader reader = new StreamReader(fileName);
            string line = "";

            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                int ArrayLength = words.Length;
                Book book = new Book();

                book.ISBN = int.Parse(words[0]);
                for (int i = 1; i < (ArrayLength - 4); i++)
                {
                    book.AuthorsName = line.Split(':');
                }
                book.BookName = words[ArrayLength - 4];
                book.Publisher = words[ArrayLength - 3];
                book.ReleasedYear = int.Parse(words[ArrayLength - 2]);
                book.Category = words[ArrayLength - 1];

                unchechedBooks.Add(book);
            }

            return unchechedBooks;
        }
        
    }
}

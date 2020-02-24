using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class ProcessBooksData
    {
        
        Queue<Book> allBooks = new Queue<Book>();
        Queue<Book> ComputerScienceBooks = new Queue<Book>();
        Queue<Book> NetworkingBooks = new Queue<Book>();
        Queue<Book> MathematicsBooks = new Queue<Book>();
        Queue<Book> SoftwareDevelopementBooks = new Queue<Book>();
        Book book = new Book();

        //getting computer science books
        public Queue<Book> getComputerSienceBooks(List<Book> books)
        {
            foreach (Book book in books)
            {
                if (book.Category == "Computer Science")
                {
                    ComputerScienceBooks.Enqueue(book);
                }
            }
            
            return ComputerScienceBooks;
        }

        //getting networking books
        public Queue<Book> getNetworkingBooks(List<Book> books)
        {
            foreach (Book book in books)
            {
                if (book.Category == "Networking")
                {
                    NetworkingBooks.Enqueue(book);
                }
            }
            
            return NetworkingBooks;
        }

        //getting Mathematics books
        public Queue<Book> getMathematicsBooks(List<Book> books)
        {
            foreach(Book book in books)
            {
                if (book.Category == "Mathematics")
                {
                    MathematicsBooks.Enqueue(book);
                }
            }   
            
            return MathematicsBooks;
        }

        //getting software developement books
        public Queue<Book> getSofwareDevelopementBooks(List<Book> books)
        {
            foreach (Book book in books)
            {
                if (book.Category == "Software Development")
                {
                    SoftwareDevelopementBooks.Enqueue(book);
                }
            }

            return SoftwareDevelopementBooks;
        }
        
    }
}

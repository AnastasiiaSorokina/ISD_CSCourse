using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Book
    {
        Title TitleName;
        Author AuthorName;
        Content ContentName;

        public Book(string title, string author, string content)
        {
            TitleName = new Title();
            TitleName.name = title;
            AuthorName = new Author();
            AuthorName.name = author;
            ContentName = new Content();
            ContentName.name = content;
        }

        public void PrintAll()
        {
            TitleName.Show();
            AuthorName.Show();
            ContentName.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class FictionBook : IBook
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsAvailable { get; private set; } = true;

        public FictionBook(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public bool CheckOut()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                return true;
            }
            return false;
        }

        public void Return()
        {
            IsAvailable = true;
        }
    }
}
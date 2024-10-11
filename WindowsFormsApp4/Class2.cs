using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public interface IBook
    {
        string Title { get; }
        string Author { get; }
        bool IsAvailable { get; }

        bool CheckOut();
        void Return();
    }

}

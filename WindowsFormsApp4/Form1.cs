using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private List<IBook> books = new List<IBook>();

        public Form1()
        {
            InitializeComponent();
            InitializeLibrary();
            UpdateAvailableBooks();
        }

        private void InitializeLibrary()
        {
            // Добавление книг в библиотеку
            books.Add(new FictionBook("Война и мир", "Лев Толстой"));
            books.Add(new FictionBook("1984", "Джордж Оруэлл"));
            books.Add(new NonFictionBook("Краткая история времени", "Стивен Хокинг"));
            books.Add(new NonFictionBook("Самый богатый человек в Вавилоне", "Джордж Клейсон"));
        }

        private void UpdateAvailableBooks()
        {
            listBoxAvailableBooks.Items.Clear();
            foreach (var book in books)
            {
                if (book.IsAvailable)
                {
                    listBoxAvailableBooks.Items.Add(book.Title);
                }
            }
        }

        private void UpdateCheckedOutBooks()
        {
            listBoxCheckedOutBooks.Items.Clear();
            foreach (var book in books)
            {
                if (!book.IsAvailable)
                {
                    listBoxCheckedOutBooks.Items.Add(book.Title);
                }
            }
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableBooks.SelectedItem != null)
            {
                var selectedTitle = listBoxAvailableBooks.SelectedItem.ToString();
                var book = books.Find(b => b.Title == selectedTitle);
                if (book.CheckOut())
                {
                    UpdateAvailableBooks();
                    UpdateCheckedOutBooks();
                }
                else
                {
                    MessageBox.Show("Книга недоступна.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (listBoxCheckedOutBooks.SelectedItem != null)
            {
                var selectedTitle = listBoxCheckedOutBooks.SelectedItem.ToString();
                var book = books.Find(b => b.Title == selectedTitle);
                book.Return();
                UpdateAvailableBooks();
                UpdateCheckedOutBooks();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        ListViewItem lvi;
        public Entities db = new Entities();
        public Form1()
        {
            InitializeComponent();

            SelectAllBooks();
        }

        public void SelectAllBooks()
        {
            listViewBooks.Items.Clear();
            foreach (Book book in db.Book)
            {
                string authorFullName = db.Author.FirstOrDefault(p => p.id_author == book.id_author).surname + " " + db.Author.FirstOrDefault(p => p.id_author == book.id_author).name.Substring(0, 1) + ". " + db.Author.FirstOrDefault(p => p.id_author == book.id_author).patronymic.Substring(0, 1) + ".";

                lvi = new ListViewItem(book.id_book.ToString());
                lvi.SubItems.Add(book.book_name);
                lvi.SubItems.Add(db.Publish.FirstOrDefault(p => p.id_publishing == book.id_publishing).publishing_name);
                lvi.SubItems.Add(book.year_of_publication.ToString());
                lvi.SubItems.Add(book.genre);
                lvi.SubItems.Add(authorFullName);
                listViewBooks.Items.Add(lvi);
            }
        }

        public void SelectSearchBook(int idbook)
        {
            listViewBooks.Items.Clear();

            var bookSearch = db.Book.FirstOrDefault(b => b.id_book == idbook);

            foreach (Book book in db.Book)
            {
                if (book.book_name == bookSearch.book_name)
                {
                    string authorFullName = db.Author.FirstOrDefault(p => p.id_author == book.id_author).surname + " " + db.Author.FirstOrDefault(p => p.id_author == book.id_author).name.Substring(0, 1) + ". " + db.Author.FirstOrDefault(p => p.id_author == book.id_author).patronymic.Substring(0, 1) + ".";

                    lvi = new ListViewItem(book.id_book.ToString());
                    lvi.SubItems.Add(book.book_name);
                    lvi.SubItems.Add(db.Publish.FirstOrDefault(p => p.id_publishing == book.id_publishing).publishing_name);
                    lvi.SubItems.Add(book.year_of_publication.ToString());
                    lvi.SubItems.Add(book.genre);
                    lvi.SubItems.Add(authorFullName);
                    listViewBooks.Items.Add(lvi);
                }
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            this.Hide();
        }

        private void textBoxSearchViaNameBook_TextChanged(object sender, EventArgs e)
        {
            var book = db.Book.FirstOrDefault(b => b.book_name == textBoxSearchViaNameBook.Text);

            if (book != null)
            {
                SelectSearchBook(book.id_book);
            }
            else
            {
                SelectAllBooks();
            }
        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            RemoveBook removeBook = new RemoveBook();
            removeBook.Show();
            this.Hide();
        }
    }
}

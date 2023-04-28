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
    public partial class AddBook : Form
    {
        public Entities db = new Entities();
        public AddBook()
        {
            InitializeComponent();
            InitComboboxes();
        }

        public void InitComboboxes()
        {
            comboBoxPublishing.Items.Clear();
            comboBoxAuthors.Items.Clear();

            foreach (var p in db.Publish)
            {
                comboBoxPublishing.Items.Add(p.publishing_name);
            }

            foreach (var p in db.Author)
            {
                comboBoxAuthors.Items.Add(p.surname + " " + p.name.Substring(0, 1) + ". " + p.patronymic.Substring(0, 1) + ".");
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book()
                {
                    book_name = textBoxNameBook.Text,
                    id_publishing = db.Publish.FirstOrDefault(pu => pu.publishing_name == comboBoxPublishing.Text).id_publishing,
                    year_of_publication = int.Parse(textBoxYearOfPublishing.Text),
                    genre = textBoxGenre.Text,
                    id_author = db.Author.FirstOrDefault(pu => pu.surname + " " + pu.name.Substring(0, 1) + ". " + pu.patronymic.Substring(0, 1) + "." == comboBoxAuthors.Text).id_author,
                };
                db.Book.Add(book);
                db.SaveChanges();
                MessageBox.Show("Книга успешно добавлена!", "NKC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NKC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form1 form1 = new Form1();
            form1.SelectAllBooks();
            form1.Show();
            this.Hide();
        }
    }
}

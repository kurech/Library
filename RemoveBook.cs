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
    public partial class RemoveBook : Form
    {
        public Entities db = new Entities();
        Book selectedBook = new Book();
        public RemoveBook()
        {
            InitializeComponent();
            BookList();
        }

        public void BookList()
        {
            listBox1.Items.Clear();
            foreach (var b in db.Book)
            {
                listBox1.Items.Add(b.book_name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBook = db.Book.FirstOrDefault(b => b.book_name == (string)listBox1.SelectedItem);

            label1.Text = $"Выбранная книга: {selectedBook.book_name}";
        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            try
            {
                db.Book.Remove(selectedBook);
                db.SaveChanges();
                MessageBox.Show("Книга успешно удалена!", "NKC", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

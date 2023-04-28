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
    public partial class ExtraditionAction : Form
    {
        public Entities db = new Entities();
        public Book book = new Book();
        public Reader reader = new Reader();
        public Employee employee = new Employee();
        public ExtraditionAction()
        {
            InitializeComponent();
            employee = db.Employee.FirstOrDefault();
            BookList();
            ReadersList();
        }

        public void BookList()
        {
            listBoxBooks.Items.Clear();
            foreach (var b in db.Book)
            {
                listBoxBooks.Items.Add(b.book_name);
            }
        }

        public void ReadersList()
        {
            listBoxReaders.Items.Clear();
            foreach (var r in db.Reader)
            {
                listBoxReaders.Items.Add(r.Surname + " " + r.Name);
            }
        }

        private void listBoxReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            reader = db.Reader.FirstOrDefault(b => b.Surname + " " + b.Name == (string)listBoxReaders.SelectedItem);
        }

        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            book = db.Book.FirstOrDefault(b => b.book_name == (string)listBoxBooks.SelectedItem);
        }

        private void buttonExtradition_Click(object sender, EventArgs e)
        {
            try
            {
                Extradition extradition = new Extradition()
                {
                    extradition_date = DateTime.Now.Date,
                    passed = false,
                    term = 14,
                    id_readerTicket = reader.id_readerTicket,
                    id_book = book.id_book,
                    id_staff = employee.id_employee
                };

                db.Extradition.Add(extradition);
                db.SaveChanges();

                MessageBox.Show("Книгу успешно выдали!", "NKC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NKC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

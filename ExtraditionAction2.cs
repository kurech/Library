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
    public partial class ExtraditionAction2 : Form
    {
        public Entities db = new Entities();
        public Reader reader = new Reader();
        public Extradition extradition = new Extradition();
        public ExtraditionAction2()
        {
            InitializeComponent();
            ReadersList();
        }

        public void ReadersList()
        {
            listBoxReaders.Items.Clear();
            foreach (var r in db.Reader)
            {
                listBoxReaders.Items.Add(r.Surname + " " + r.Name);
            }
        }

        public void ExtraditionsList(int idticket)
        {
            listBoxExtradions.Items.Clear();
            foreach (var r in db.Extradition)
            {
                if (idticket == r.id_readerTicket)
                {
                    if (r.passed == false)
                    {
                        var book = db.Book.FirstOrDefault(b => b.id_book == r.id_book);
                        listBoxExtradions.Items.Add(r.extradition_date + " " + book.book_name);
                    }
                }
            }
        }

        private void buttonExtraditionReturn_Click(object sender, EventArgs e)
        {
            try
            {
                extradition.refund_date = DateTime.Now.Date;
                extradition.passed = true;

                db.SaveChanges();

                MessageBox.Show("Книгу успешно вернули!", "NKC", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ReadersList();
                listBoxExtradions.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NKC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            reader = db.Reader.FirstOrDefault(b => b.Surname + " " + b.Name == (string)listBoxReaders.SelectedItem);
            ExtraditionsList(reader.id_readerTicket);
        }

        private void listBoxExtradions_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var r in db.Extradition)
            {
                var book = db.Book.FirstOrDefault(b => b.id_book == r.id_book);
                if (r.extradition_date + " " + book.book_name == (string)listBoxExtradions.SelectedItem)
                    extradition = r;
            }
        }
    }
}

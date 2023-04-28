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
    public partial class AddReader : Form
    {
        public Entities db = new Entities();
        public AddReader()
        {
            InitializeComponent();
        }

        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            try
            {
                Reader reader = new Reader()
                {
                    id_readerTicket = int.Parse(textBoxReaderTicket.Text),
                    Surname = textBoxSurname.Text,
                    Name = textBoxName.Text,
                    Patronymic = textBoxPatronymic.Text,
                    Adress = textBoxAddress.Text,
                    Phone = textBoxPhone.Text
                };
                db.Reader.Add(reader);
                db.SaveChanges();
                MessageBox.Show("Читатель успешно добавлен!", "NKC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NKC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ReaderAction readerAction = new ReaderAction();
            readerAction.SelectAllReader();
            readerAction.Show();
            this.Hide();
        }
    }
}

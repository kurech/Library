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
    public partial class ReaderAction : Form
    {
        public Entities db = new Entities();
        ListViewItem lvi;
        public ReaderAction()
        {
            InitializeComponent();
            SelectAllReader();
        }

        public void SelectAllReader()
        {
            listViewReaders.Items.Clear();
            foreach (Reader reader in db.Reader)
            {
                lvi = new ListViewItem(reader.id_readerTicket.ToString());
                lvi.SubItems.Add(reader.Surname);
                lvi.SubItems.Add(reader.Name);
                if (reader.Patronymic != null)
                    lvi.SubItems.Add(reader.Patronymic);
                else
                    lvi.SubItems.Add(string.Empty);
                lvi.SubItems.Add(reader.Adress);
                lvi.SubItems.Add(reader.Phone);
                listViewReaders.Items.Add(lvi);
            }
        }

        public void SelectSearchReader(int idreader)
        {
            listViewReaders.Items.Clear();

            var readerSearch = db.Reader.FirstOrDefault(b => b.id_readerTicket == idreader);

            foreach (Reader reader in db.Reader)
            {
                if (reader.id_readerTicket == idreader)
                {
                    lvi = new ListViewItem(reader.id_readerTicket.ToString());
                    lvi.SubItems.Add(reader.Surname);
                    lvi.SubItems.Add(reader.Name);
                    if (reader.Patronymic != null)
                        lvi.SubItems.Add(reader.Patronymic);
                    else
                        lvi.SubItems.Add(string.Empty);
                    lvi.SubItems.Add(reader.Adress);
                    lvi.SubItems.Add(reader.Phone);
                    listViewReaders.Items.Add(lvi);
                }
            }
        }

        private void listViewReaders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearchViaFullName_TextChanged(object sender, EventArgs e)
        {
            var reader = db.Reader.FirstOrDefault(b => b.Surname + " " + b.Name == textBoxSearchViaFullName.Text);

            if (reader != null)
            {
                SelectSearchReader(reader.id_readerTicket);
            }
            else
            {
                SelectAllReader();
            }
        }

        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            AddReader addReader = new AddReader();
            addReader.Show();
            this.Hide();
        }
    }
}

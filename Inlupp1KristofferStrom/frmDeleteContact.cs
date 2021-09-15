using System;
using System.Windows.Forms;

namespace Inlupp1KristofferStrom
{
    public partial class frmDeleteContact : Form
    {
        private readonly Contact _contactToDelete;
        private readonly AddressBook _addressBook;
        private readonly frmAdressbok _frmAdressbok;
        public frmDeleteContact(Contact contactToDelete, AddressBook addressBook, frmAdressbok frmAdressbok)
        {
            InitializeComponent();

            _frmAdressbok = frmAdressbok;
            _addressBook = addressBook;
            _contactToDelete = contactToDelete;

            labelContactName.Text = _contactToDelete.Name + "?";
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            _addressBook.Delete(_contactToDelete);

            _frmAdressbok.PrintAllContactsToListBox(_addressBook.GetAllContacts());
            _frmAdressbok.DisplayFirstPageLook();

            Close();
        }
    }
}

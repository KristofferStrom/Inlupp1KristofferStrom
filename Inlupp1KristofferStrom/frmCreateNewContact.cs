using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inlupp1KristofferStrom
{
    public partial class frmCreateNewContact : Form
    {
        private readonly frmAdressbok _addressbokForm;
        private readonly AddressBook _addressBook;

        public frmCreateNewContact(frmAdressbok addressbokForm, AddressBook addressBook)
        {
            InitializeComponent();

            _addressbokForm = addressbokForm;
            _addressBook = addressBook;
        }

        private void buttonRegistrerNewContact_Click(object sender, EventArgs e)
        {
            var validation = new InputValidation();
            var newContact = new Contact
            {
                Name = textBoxName.Text,
                StreetAddress = textBoxStreetAddress.Text,
                PostalCode = textBoxPostalCode.Text,
                City = textBoxCity.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                Email = textBoxEmail.Text,
                Id = _addressBook.CreateContactId()
            };

            List<string> incorrectInputList = validation.CheckForInputExceptions(newContact);
            if (incorrectInputList.Count > 0)
                MessageBox.Show(validation.GetExceptionMessage(incorrectInputList));
            else
            {
                _addressBook.SaveContact(newContact);
                _addressbokForm.PrintAllContactsToListBox(_addressBook.GetAllContacts());

                Close();
            }
        }
    }
}

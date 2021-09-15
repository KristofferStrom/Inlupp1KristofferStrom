using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inlupp1KristofferStrom
{
    public partial class frmAdressbok : Form
    {
        private readonly AddressBook _addressBook;
        public frmAdressbok()
        {
            InitializeComponent();

            _addressBook = new AddressBook();
            PrintAllContactsToListBox(_addressBook.GetAllContacts());
            DisplayFirstPageLook();
        }

        private void buttonCreateNewContact_Click(object sender, EventArgs e)
        {
            var createNewContact = new frmCreateNewContact(this, _addressBook);
            createNewContact.Show();
        }

        private void listBoxContacts_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxContacts.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var selectedId = Convert.ToInt32(listBoxContacts.SelectedValue);
                PrintContactDetails(selectedId);

                DisplayContactDetailsLook();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DisplayContactDetailsEditLook();
            MapLabelValueToTextboxValue();
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            DisplayContactDetailsLook();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            var validation = new InputValidation();
            
            Contact contactToChange = new Contact
            {
                Name = textBoxName.Text,
                City = textBoxCity.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                PostalCode = textBoxPostalCode.Text,
                StreetAddress = textBoxStreetAddress.Text
            };

            List<string> incorrectInputList = validation.CheckForInputExceptions(contactToChange);
             
            if (incorrectInputList.Count > 0)
                MessageBox.Show(validation.GetExceptionMessage(incorrectInputList));
            else
            {
                var updatedContactList = new List<Contact>();
                bool isChanged = false;
                foreach (var contact in _addressBook.GetAllContacts())
                {
                    if (contact.Id == Convert.ToInt32(labelContactId.Text))
                        isChanged = MapInputToProp(contact);
                    
                    updatedContactList.Add(contact);
                }

                if (isChanged)
                {
                    _addressBook.UpdateAddressBook(updatedContactList);
                    PrintAllContactsToListBox(updatedContactList);
                    MapTextBoxValueToLabelValue();
                }
                DisplayContactDetailsLook();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(listBoxContacts.SelectedValue);
            Contact contactToDelete = _addressBook.GetContactById(selectedId);
            frmDeleteContact frmDeleteContact = new frmDeleteContact(contactToDelete, _addressBook, this);

            frmDeleteContact.Show();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var q = textBoxSearch.Text.ToLower();
            var searchResultList = _addressBook.GetAllContacts().Where(c => c.Name.ToLower().Contains(q) || c.City.ToLower().Contains(q) || q == "").ToList();
            PrintAllContactsToListBox(searchResultList);
        }

        private bool MapInputToProp(Contact contact)
        {
            bool isChanged = false;

            if (contact.Name != textBoxName.Text)
            {
                isChanged = true;
                contact.Name = textBoxName.Text;
            }

            if (contact.StreetAddress != textBoxStreetAddress.Text)
            {
                isChanged = true;
                contact.StreetAddress = textBoxStreetAddress.Text;
            }

            if (contact.PostalCode != textBoxPostalCode.Text)
            {
                isChanged = true;
                contact.PostalCode = textBoxPostalCode.Text;
            }

            if (contact.City != textBoxCity.Text)
            {
                isChanged = true;
                contact.City = textBoxCity.Text;
            }

            if (contact.PhoneNumber != textBoxPhoneNumber.Text)
            {
                isChanged = true;
                contact.PhoneNumber = textBoxPhoneNumber.Text;
            }

            if (contact.Email != textBoxEmail.Text)
            {
                isChanged = true;
                contact.Email = textBoxEmail.Text;
            }
            return isChanged;
        }
        private void PrintContactDetails(int selectedId)
        {
            Contact contact = _addressBook.GetAllContacts().FirstOrDefault(c=>c.Id == selectedId);
            if (contact != null)
            {
                labelContactId.Text = contact.Id.ToString();
                labelContactName.Text = contact.Name;
                labelContactStreetAddress.Text = contact.StreetAddress;
                labelContactPostalCode.Text = contact.PostalCode;
                labelContactCity.Text = contact.City;
                labelContactPhoneNumber.Text = contact.PhoneNumber;
                labelContactEmail.Text = contact.Email;
            }
        }
        public void PrintAllContactsToListBox(List<Contact> contactList)
        {
            listBoxContacts.DataSource = null;
            listBoxContacts.DataSource = contactList;
            listBoxContacts.DisplayMember = "Name";
            listBoxContacts.ValueMember = "Id";
            listBoxContacts.SelectedValue = "";
        }
        private void MapTextBoxValueToLabelValue()
        {
            labelContactName.Text = textBoxName.Text;
            labelContactStreetAddress.Text = textBoxStreetAddress.Text;
            labelContactCity.Text = textBoxCity.Text;
            labelContactPostalCode.Text = textBoxPostalCode.Text;
            labelContactPhoneNumber.Text = textBoxPhoneNumber.Text;
            labelContactEmail.Text = textBoxEmail.Text;
        }
        private void MapLabelValueToTextboxValue()
        {
            textBoxName.Text = labelContactName.Text;
            textBoxStreetAddress.Text = labelContactStreetAddress.Text;
            textBoxCity.Text = labelContactCity.Text;
            textBoxPostalCode.Text = labelContactPostalCode.Text;
            textBoxPhoneNumber.Text = labelContactPhoneNumber.Text;
            textBoxEmail.Text = labelContactEmail.Text;
        }
        private void HideAllLabels()
        {
            foreach (Control item in Controls)
            {
                if (item is Label)
                    item.Hide();
            }
        }
        public void DisplayFirstPageLook()
        {
            HideAllContactDetailsTextBoxes();
            HideAllLabels();

            buttonEdit.Hide();
            buttonSaveChanges.Hide();
            buttonAbort.Hide();
            buttonDelete.Hide();
        }
        private void DisplayContactDetailsLook()
        {
            buttonEdit.Show();
            buttonDelete.Show();
            buttonSaveChanges.Hide();
            buttonAbort.Hide();
            HideAllContactDetailsTextBoxes();
            ShowAllLabels();
        }
        private void DisplayContactDetailsEditLook()
        {
            buttonEdit.Hide();
            buttonDelete.Hide();
            buttonSaveChanges.Show();
            buttonAbort.Show();
            labelContactName.Hide();
            labelContactStreetAddress.Hide();
            labelContactPostalCode.Hide();
            labelContactCity.Hide();
            labelContactPhoneNumber.Hide();
            labelContactEmail.Hide();
            ShowAllTextBoxes();
        }
        private void ShowAllLabels()
        {
            foreach (Control item in Controls)
            {
                if (item is Label && item.Name != "labelContactId")
                    item.Show();
            }
        }
        private void HideAllContactDetailsTextBoxes()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox && item.Name != "textBoxSearch")
                    item.Hide();
            }
        }
        private void ShowAllTextBoxes()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Show();
            }
        }
    }
}

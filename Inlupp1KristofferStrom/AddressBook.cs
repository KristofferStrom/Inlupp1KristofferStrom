using System.Collections.Generic;
using System.Linq;

namespace Inlupp1KristofferStrom
{
    public class AddressBook
    {
        private List<Contact> _allContactsList;
        private readonly FileRepository _repository;

        public AddressBook()
        {
            _repository = new FileRepository();
            _allContactsList = _repository.GetAllContactsFromFile();
        }

        public List<Contact> GetAllContacts()
        {
            return _allContactsList;
        }

        public void UpdateAddressBook(List<Contact> updatedContactList)
        {
            _allContactsList = updatedContactList;
            _repository.UpdateContactFile(_allContactsList);
        }

        public void SaveContact(Contact newContact)
        {
            _allContactsList.Add(newContact);
            _repository.UpdateContactFile(_allContactsList);
        }

        public Contact GetContactById(int selectedId)
        {
            return _allContactsList.First(c => c.Id == selectedId);
        }

        public void Delete(Contact contactToDelete)
        {
           _allContactsList.Remove(contactToDelete);
           _repository.UpdateContactFile(_allContactsList);
        }

        public int CreateContactId()
        {
            if (_allContactsList.Count == 0)
                return 1;

            int highestId = 1;
            foreach (var contact in _allContactsList)
            {
                if (highestId < contact.Id)
                    highestId = contact.Id;
            }

            return highestId + 1;
        }
    }
}

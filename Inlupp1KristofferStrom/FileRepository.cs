using System;
using System.Collections.Generic;
using System.IO;

namespace Inlupp1KristofferStrom
{
    
    class FileRepository
    {
        private readonly string _path = "Addressbok.txt";
        
        internal List<Contact> GetAllContactsFromFile()
        {
            var contactList = new List<Contact>();

            if (File.Exists(_path))
            {
                using (StreamReader sr = File.OpenText(_path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    { 
                        string[] contactDetailsArray = line.Split(',');
                        var contact = new Contact
                        {
                            Id = Convert.ToInt32(contactDetailsArray[0]),
                            Name = contactDetailsArray[1],
                            StreetAddress = contactDetailsArray[2],
                            PostalCode = contactDetailsArray[3],
                            City = contactDetailsArray[4],
                            PhoneNumber = contactDetailsArray[5],
                            Email = contactDetailsArray[6]
                        };
                        contactList.Add(contact);
                    }
                }
            }
            return contactList;
        }

        public void UpdateContactFile(List<Contact> updatedContactList)
        {
            if (File.Exists(_path))
                File.Delete(_path);
            
            using (StreamWriter sw = File.CreateText(_path))
            {
                foreach (var contact in updatedContactList)
                {
                    string line = $"{contact.Id},{contact.Name},{contact.StreetAddress},{contact.PostalCode},{contact.City},{contact.PhoneNumber},{contact.Email}";
                    sw.WriteLine(line);
                }
            }
        }
    }
}

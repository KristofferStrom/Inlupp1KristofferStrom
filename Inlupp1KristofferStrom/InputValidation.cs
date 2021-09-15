using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Inlupp1KristofferStrom
{
    public class InputValidation
    {
        public List<string> CheckForInputExceptions(Contact contact)
        {
            List<string> exceptionMessageList = new List<string>();
            if (!Regex.IsMatch(contact.Name, @"^[A-Öa-ö ]*$"))
                exceptionMessageList.Add("Namn");
            if (!Regex.IsMatch(contact.City, @"^[A-Öa-ö ]*$"))
                exceptionMessageList.Add("Postort");
            if (!Regex.IsMatch(contact.StreetAddress, @"^[A-Öa-ö0-9 ]*$"))
                exceptionMessageList.Add("Gatuadress");
            if (!Regex.IsMatch(contact.PhoneNumber, @"^[0-9\s]*$"))
                exceptionMessageList.Add("Telefon");
            if (!Regex.IsMatch(contact.PostalCode, @"^[0-9\s]*$"))
                exceptionMessageList.Add("Postnummer");
            if (!Regex.IsMatch(contact.Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                exceptionMessageList.Add("Email");

            return exceptionMessageList;
        }

        public string GetExceptionMessage(List<string> incorrectInputList)
        {
            string message = "Dessa fält är fel:\n";
            foreach (var incorrectInput in incorrectInputList)
            {
                message += incorrectInput + "\n";
            }

            return message;
        }
    }
}

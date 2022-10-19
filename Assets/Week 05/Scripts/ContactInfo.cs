using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DomanikCummings
{
    public enum People { Undefined, Bob, Frank, John}
    public class ContactInfo : MonoBehaviour
    {
        [SerializeField] private People chosenPerson = People.Undefined;
        [SerializeField] private string firstName;
        [SerializeField] private string preferedName;
        [SerializeField] private string phoneNumber;
        [SerializeField] private string address;
        [SerializeField] private string email;

        public void Initialise()
        {
            switch (chosenPerson)
            {
                case People.Undefined:
                    break;
                case People.Bob:
                    Setup("Bob Ross", "Bob", "01 38594763", "35 park Lane", "First@email.com");
                    break;
                case People.Frank:
                    Setup("Frank Man", "Frank", "02 884658365", "45 Old Kent Road", "Second@email.com");
                    break;
                case People.John:
                    Setup("John Smith", "John", "03 2758573486", "90 Whitehall", "Third@email.com");
                    break;
                default:
                    break;
            }
            

            //if (chosenPerson == People.Bob)
            //{
            //    Setup("Bob Ross", "Bob", "01 38594763", "35 park Lane", "First@email.com");
            //}
            //if (chosenPerson == People.Frank)
            //{
            //    Setup("Frank Man", "Frank", "02 884658365", "45 Old Kent Road", "Second@email.com");
            //}
            //if (chosenPerson == People.John)
            //{
            //    Setup("John Smith", "John", "03 2758573486", "90 Whitehall", "Third@email.com");
            //}
        }

        private void Setup(string newfirstName,
                           string newpreferedName, 
                           string newphoneNumber, 
                           string newaddress, 
                           string newemail)
        {
            firstName = newfirstName;
            preferedName = newpreferedName;
            phoneNumber = newphoneNumber;
            address = newaddress;
            email = newemail;
        }
    }
}

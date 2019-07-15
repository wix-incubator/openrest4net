using System;
using System.Collections.Generic;

namespace wixrest.v2_0
{
    public class Contact
    {
        public string firstName;
        public string lastName;
        public string email;
        public string phone;
        public string fax;

        public Contact(string firstName, string lastName, string email, string phone, string fax)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.fax = fax;
        }

        /** Empty constructor required for initialization from JSON-encoded string. */
        public Contact() { }
    }
}

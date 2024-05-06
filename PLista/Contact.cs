using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLista
{
    internal class Contact
    {
        string name;
        string phone;
        Contact next;

        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public string getName()
        {
            return this.name;
        }
        public void setNext(Contact next)
        {
            this.next = next;
        }
        public Contact getNext()
        {
            return this.next;
        }
    }
}

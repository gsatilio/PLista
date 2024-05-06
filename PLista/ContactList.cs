using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PLista
{
    internal class ContactList
    {
        Contact head;
        Contact tail;

        public ContactList()
        {
            this.head = null;
            this.tail = null;
        }

        public void Add(Contact contact)
        {
            int compare;
            if (isEmpty())
            {
                this.head = this.tail = contact;
            }
            else
            {
                compare = String.Compare(contact.getName(), head.getName(), comparisonType: StringComparison.OrdinalIgnoreCase); // método comparador de tamanho de string sem case sensitive
                if (compare <= 0)
                {
                    Contact aux = head;
                    aux = head;
                    head = contact;
                    head.setNext(aux);
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;
                    do
                    {
                        compare = String.Compare(contact.getName(), aux.getName(), comparisonType: StringComparison.OrdinalIgnoreCase); // método comparador de tamanho de string sem case sensitive
                        if (compare > 0)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                    } while (compare > 0 && aux != null);
                    prev.setNext(contact);
                    contact.setNext(aux);
                    if (aux == null)
                    {
                        tail = contact;
                    }
                }
            }
        }
        public void RemoveByName(string name)
        {
            if (!isEmpty())
            {
                if (name == this.head.getName())
                {
                    if (head == tail)
                    {
                        head = tail = null;
                    }
                    else
                    {
                        head = head.getNext();
                    }
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;
                    bool compare;
                    do
                    {
                        compare = name.Equals(aux.getName());
                        if (!compare)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                        else
                        {
                            prev.setNext(aux.getNext());
                            if (prev.getNext() == null)
                            {
                                tail = prev;
                            }
                        }
                    } while (!compare && aux != null);
                    if (aux == null)
                    {
                        Console.WriteLine("Nome não existe na lista");
                    }
                }
            }
        }
        bool isEmpty()
        {
            if (this.head == null && this.tail == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

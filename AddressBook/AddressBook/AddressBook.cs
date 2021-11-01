using System;
using System.Collections.Generic;


class AddressBook
{
    List<Address> address1;

    public AddressBook()
    {
        address1 = new List<Address>();
    }

    public bool add(string name, string address, string city, string state, string zip, string phoneNumber, string email)
    {
        Address addr = new Address(name, address, city, state, zip, phoneNumber, email);
        Address result = find(name);
        //if (book.add(name, address, city, state, zip, phoneNumber, email))

            if (result == null)
        {
            address1.Add(addr);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool remove(string name)
    {
        Address addr = find(name);

        if (addr != null)
        {
            address1.Remove(addr);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void list(Action<Address> action)
    {
        address1.ForEach(action);
    }

    public bool isEmpty()
    {
        return (address1.Count == 0);
    }

    public Address find(string name)
    {
        Address addr = address1.Find(
          delegate (Address a) {
              return a.name == name;
          }
        );
        return addr;
    }


}
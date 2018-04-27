using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthLinksV2
{
    class Customer
    {
        private int ID;
        private String firstName;
        private String lastName;
        private String phoneNo;
        private String email;
        private Address address;
        
        public Customer() {
            address = new Address();
            ID = -1;
        }

        public Customer(int id, String firstName, String lastName, String phoneNo, String email, Address address)
        {
            this.ID = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNo = phoneNo;
            this.email = email;
            this.address = address;
        }

        public int setId(int i)
        {
            ID = i;
            return ID;
        }

        public int getId()
        {
            return ID;
        }

        public String setFirstName(String name)
        {
            firstName = name;
            return firstName;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public String setLastName(String name)
        {
            lastName = name;
            return lastName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public String setPhoneNo(String phone)
        {
            phoneNo = phone;
            return phoneNo;
        }

        public String getPhoneNo()
        {
            return phoneNo;
        }

        public String setEmail(String e)
        {
            email = e;
            return email;
        }

        public String getEmail()
        {
            return email;
        }

        public Address setAddress(Address a)
        {
            address = a;
            return address;
        }

        public Address getAddress()
        {
            return address;
        }
    }
}

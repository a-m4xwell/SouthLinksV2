using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthLinksV2
{
    class Address
    {
        private int ID;
        private String houseNo;
        private String street;
        private String city;
        private String postcode;

        public Address() {
            ID = -1;
        }

        public Address(int id, String houseNo, String street, String city, String postcode)
        {
            this.ID = id;
            this.houseNo = houseNo;
            this.street = street;
            this.city = city;
            this.postcode = postcode;
        }

        public int getId()
        {
            return ID;
        }

        public int setId(int i)
        {
            ID = i;
            return ID;
        }

        public String getHouseNo()
        {
            return houseNo;
        }

        public String setHouseNo(String no)
        {
            houseNo = no;
            return houseNo;
        }

        public String getStreet()
        {
            return street;
        }

        public String setStreet(String st)
        {
            street = st;
            return street;
        }

        public String getCity()
        {
            return city;
        }

        public String setCity(String ci)
        {
            city = ci;
            return city;
        }

        public String getPostcode()
        {
            return postcode;
        }

        public String setPostcode(String po)
        {
            postcode = po;
            return postcode;
        }
    }
}

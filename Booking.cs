using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthLinksV2
{
    class Booking
    {
        private int referenceNo;
        private DateTime from = DateTime.Now;
        private DateTime to;
        private double price;
        private Boolean paid;
        private string liscencePlate;
        private string takenBy;
        private Accomodation accomodation;
        private Pitch pitch;
        private Customer customer;
        private Boolean toSet = false; //to flag for calculating the cost
        private Boolean accomodationSet = false; //accomodation flag for calculating the cost

        public Booking() {
            accomodation = new Accomodation();
            pitch = new Pitch();
            customer = new Customer();
        }

        public void calculateCost()
        {
            if(!toSet || !accomodationSet)
            {
                //throw an exception
                throw new CustomException("\nCannot calculate the cost as one or more of the nessessasery values is blank!\n");
            }
            int days = to.Subtract(from).Days; // calcute the days between arriving and leaving 
            price = accomodation.getRate() * days; //calculate the cost    
        }

        public int setReferenceNo(int refno)
        {
            referenceNo = refno;
            return referenceNo;
        }

        public int getReferenceNo()
        {
            return referenceNo;
        }

        public DateTime setFrom(DateTime f)
        {
            from = f;
            return from;
        }

        public DateTime getFrom()
        {
            return from;
        }

        public DateTime setTo(DateTime t)
        {
            to = t;
            toSet = true;
            return to;
        }

        public DateTime getTo()
        {
            return to;
        }

        public double getPrice()
        {
            return price;
        }

        public Boolean setPaid(Boolean p)
        {
            paid = p;
            return paid;
        }

        public Boolean getPaid()
        {
            return paid;
        }

        public String setLiscence(String l)
        {
            liscencePlate = l;
            return liscencePlate;
        }

        public String getLiscecne()
        {
            return liscencePlate;
        }

        public String setTakenBy(String t)
        {
            takenBy = t;
            return takenBy;
        }

        public String getTakenBy()
        {
            return takenBy;
        }

        public Accomodation setAccomodaton(Accomodation a)
        {
            accomodation = a;
            accomodationSet = true;
            return accomodation;
        }

        public Accomodation getAccomodation()
        {
            return accomodation;
        }

        public Pitch setPitch(Pitch p)
        {
            pitch = p;
            return pitch; 
        }

        public Pitch getPitch()
        {
            return pitch;
        }

        public Customer setCustomer(Customer c)
        {
            customer = c;
            return customer;
        }

        public Customer getCustomer()
        {
            return customer;
        }
    }
}

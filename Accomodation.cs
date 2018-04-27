using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthLinksV2
{
    class Accomodation
    {
        private int id;
        private String accomType;
        private double rate;

        public Accomodation(){ }

        public Accomodation(int id, String Accom, double rate)
        {
            this.id = id;
            this.accomType = Accom;
            this.rate = rate;
        }

        public int getId()
        {
            return id;
        }

        public int setId(int i)
        {
            id = i;
            return id;
        }

        public String getAccomType()
        {
            return accomType;
        }

        public String setAccomType(String type)
        {
            accomType = type;
            return accomType;
        }

        public double getRate()
        {
            return rate;
        }

        public double setRate(double r)
        {
            rate = r;
            return rate;
        }

    }
}

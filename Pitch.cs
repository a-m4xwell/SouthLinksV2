using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthLinksV2
{
    class Pitch
    {
        private String area;
        private int number;
        private int reffNo;

        public Pitch()
        {

        }

        public Pitch(String area, int number, int reffNo)
        {
            this.area = area;
            this.number = number;
            this.reffNo = reffNo;
        }

        //get refference no
        public int getReffNo()
        {
            return this.reffNo;
        }

        //set refference number
        public int setReffNo(int no)
        {
            this.reffNo = no;
            return this.reffNo;
        }

        //Get area
        public String getArea()
        {
            return area;
        }
        
        //Set area
         public String setArea(String area)
        {
            this.area = area;
            return this.area;
        }

        //Get number
        public int getNumber()
        {
            return number;
        }

        //Set number
        public int setNumber(int number)
        {
            this.number = number;
            return this.number;
        }
    }
}

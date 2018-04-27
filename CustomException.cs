using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouthLinksV2
{
    class CustomException : Exception
    {
        public CustomException()
        {

        }

        public CustomException(String message)
            : base(message)
        {
        }
    }
}

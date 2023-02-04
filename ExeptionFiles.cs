using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
   public class ExeptionFiles: Exception
    {
        public ExeptionFiles() { }
        public ExeptionFiles (string errMessage) :base(errMessage)
        {
        
        }
        public ExeptionFiles(string errMessage, Exception name) : base(errMessage, name)
        {

        }



    }
}

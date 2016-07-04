using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
        public abstract class Page
    {
        private List<Element> list = new List<Element>();
        public abstract Page LoadPage();
        public abstract List<Element> getAllElement();
    }

  
   
}

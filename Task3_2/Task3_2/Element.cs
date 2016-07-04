using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task3_2
{
    abstract class Element : ILoggable
    {
        public string Name { get; private set; }
        public abstract bool Click();
        public abstract bool SetText(string str);

        public override string ToString()
        {
            return this.Name;
        }

        public bool Log()
        {
            return true;
        }
    }
}

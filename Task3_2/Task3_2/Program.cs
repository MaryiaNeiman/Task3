﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassForWebDriver wb = new ClassForWebDriver();
            wb.ReadBrowser();
            Console.ReadLine();
        }
    }
}

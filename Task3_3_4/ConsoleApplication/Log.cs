using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication
{
    class Log
    {

       public bool CheckIsLogFileExist()
        {

            if (!File.Exists(ResourceFile.Path))
            {
                try
                {
                    using (StreamWriter sw = File.CreateText(ResourceFile.Path))
                    {
                        sw.WriteLine("");
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.StackTrace);
                    return false;
                }
            }
           // else
                File.WriteAllText(ResourceFile.Path, "");
            return true;
        }
      public static void WriteInFile(String inputStr)
        {
            try
            {
                File.AppendAllText(ResourceFile.Path, inputStr + "\r\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

    }
}

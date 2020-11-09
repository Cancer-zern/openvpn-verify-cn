using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verify_cn
{
    class Program
    {
        static int Main(string[] args)

        {

            string uidFile = args[0];
            string depth = args[1];
            string uidInput = args[2];
            uidInput = uidInput.Substring(3);

            //debug to console
            //File.AppendAllText("C:\\tmp\\CN_debug.txt", $"{args[0]} {args[1]} {args[2]}");

            if (depth == "1")
            {
                //Console.WriteLine("0");
                return 0;
            }

            if (depth == "0")
            {
                                                
                var text = File.ReadAllLines(uidFile);
                foreach (var uids in text)
                {
                    
                    if (uids == uidInput)
                    {
                        //Console.WriteLine("0");
                        return 0;
                    }
                }
            }

            //Console.WriteLine("1");
            return 1;
        }
    }



}

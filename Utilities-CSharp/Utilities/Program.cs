using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parameters = Console.ReadLine();
            string[] tokens = parameters.Split(' ');
            if (tokens.Length != 0)
            {
                switch (tokens[0])
                {
                    case "SendMail":
                        string result = EMails.SendMail(tokens[1], tokens[2], tokens[3]);
                        Console.WriteLine("{0} {1}", result, tokens[1]);
                        break;
                    default :
                        Console.WriteLine("Function not exits");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

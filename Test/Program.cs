using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ds.test.impl;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Plugins a = new Plugins();
            a.Info();
            Console.WriteLine("Press enter to start");
            while (1== 1)
            {
                
                string check = Console.ReadLine();
                
                if (check == "stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter two numbers");
                    try
                    {
                        
                        int x = Convert.ToInt32(Console.ReadLine());
                        int y = Convert.ToInt32(Console.ReadLine());


                        a.Run(x, y);
                    }
                    catch
                    {
                        Console.WriteLine("Incorrect format");

                    }
                }
               
                    
               
            }
                    
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door
{
    class Program
    {
        static void Main(string[] args)
        {

            int resp;
            bool doorOpen = false;
            bool doorClosed = false;
            bool doorLocked = false;
            bool doorUnlocked = false;

            Console.WriteLine("The door");
            resp = int.Parse(Console.ReadLine());

            if (resp == 1)
            {
                doorOpen = true;
                Console.WriteLine("Door Open");
                if (doorLocked = true)
                {
                    Console.WriteLine("error");
                }
            }
            if (resp == 2)
            {
                doorClosed = true;
                Console.WriteLine("Door Closed");
            }
            if (resp == 3)
            {
                doorLocked = true;
                Console.WriteLine("Door Locked");
            }
            if (resp == 4)
            {
                doorUnlocked = true;
                Console.WriteLine("Door Unlocked");
            }

            
            
            
            



        }
    }
}

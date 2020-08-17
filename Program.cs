using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;
using Hotel;

namespace Check_In_Check_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Room_For_Two _For_Two = new Room_For_Two(1, 50);
            Family_Room family = new Family_Room(2, 100);
            Suite suite = new Suite(3, 150);
            Guest Israel = new Guest(313613648, "Israel");
            Console.WriteLine(Reception.Is_Room_Free(_For_Two));
            Reception.Check_In(Israel);
            Console.WriteLine(_For_Two);

        }
    }
}

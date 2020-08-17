using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
    internal class Roon_Service
    {
        internal void Clean_Room(Room_For_Two room_For_Two)
        {
            room_For_Two.Set_Guest(null);
            Console.WriteLine(room_For_Two.Get_Features() + "Are Clean");
        }
        internal void Clean_Room(Family_Room family_Room)
        {
            family_Room.Set_Guest(null);
            Console.WriteLine(family_Room.Get_Features() + "Are Clean");
        }
        internal void Clean_Room(Suite suite)
        {
            suite.Set_Guest(null);
            Console.WriteLine(suite.Get_Features() + "Are Clean");
        }
    }
}

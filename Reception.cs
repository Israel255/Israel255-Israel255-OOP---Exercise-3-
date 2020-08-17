using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
    public static class Reception
    {
        private const int _NUMBER_OF_ROOMS = 3;
        static private int _number_of_guests;
        static private Room[] _rooms = new Room[_NUMBER_OF_ROOMS];
        static private Roon_Service _room_service;
        static private Room _the_room;
        static private int _count = 0;

        static public Room Check_In(Guest guest)
        {
            for (int i = 0; i < _rooms.Length; i++)
            {
                if (_rooms[i].Is_Clean() == true)
                {
                    _rooms[i].Set_Guest(guest);
                    _number_of_guests++;
                    _the_room = _rooms[i];
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry We Are Full");
                }
            }
            return _the_room;
        }
        static public void Check_Out(Room room)
        {
            room.Set_Guest(null);
            if (_number_of_guests > 0)
            {
                _number_of_guests--;
                _count--;
            }
        }
        static public bool Is_Room_Free(Room room)
        {
            if (room.Is_Clean() == true)
            {
                _rooms[_count] = room;
                _count++;
                return true;
            }
            else
            {
                return false;
            }
        }
        static private void Send_Room_Service(Room room)
        {
            if (room.Get_Room_Number() == 1)
            {
                _room_service.Clean_Room((Room_For_Two)room);
            }
            else if (room.Get_Room_Number() == 2)
            {
                _room_service.Clean_Room((Family_Room)room);
            }
            else if (room.Get_Room_Number() == 3)
            {
                _room_service.Clean_Room((Suite)room);
            }
            else
            {
                Console.WriteLine("Wrong Room");
            }
        }
    }
}

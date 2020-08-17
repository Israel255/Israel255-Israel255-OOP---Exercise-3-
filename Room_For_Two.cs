using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
    public class Room_For_Two : Room
    {
        public Room_For_Two(int room_number,float price) : base(room_number, price)
        {
            if (room_number == 1 && price == 50)
            {
                _room_number = room_number;
                Set_Features();
                _price += price;
                Set_Price();
            }
            else
            {
                Console.WriteLine("No Room Like That In Here!");
            }
        }
        protected override void Set_Features()
        {
            if (_room_number == 1)
            {
                _features = "Tv,Minibar";
            }
            else
            {
                Console.WriteLine("No Room Like That In Here!");
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}

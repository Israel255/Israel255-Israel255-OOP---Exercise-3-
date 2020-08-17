using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
    public class Family_Room : Room
    {
        public Family_Room (int room_number, float price) : base(room_number, price)
        {
            if (room_number == 2 && price == 100)
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
            if (_room_number == 2)
            {
                _features = "Tv,Minibar,Shower";
            }
            else
            {
                Console.WriteLine("No Room Like That In Here!");
            }
        }

        protected override void Set_Price()
        {
            if (_price == 100)
            {
                int base_price = 100;
                if (Convert.ToInt32(DateTime.Now.Month) == 7 || Convert.ToInt32(DateTime.Now.Month) == 8)
                {
                    base_price += 25;
                }
                _price = base_price;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

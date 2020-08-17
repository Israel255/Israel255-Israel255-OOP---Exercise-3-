using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
    public abstract class Room
    {
        protected int _room_number;
        protected float _price;
        protected Guest _guest;
        protected bool _is_clean = true;
        protected string _features;

        protected Room(int room_number, float price)
        {

        }

        internal void Set_Guest(Guest guest)
        {
            _guest = guest;
            _is_clean = false;
            if (guest == null)
            {
                _is_clean = true;
            }
        }
        protected virtual void Set_Price()
        {
            if (_price == 50)
            {
                int base_price = 50;
                if (Convert.ToInt32(DateTime.Now.Month) == 7 || Convert.ToInt32(DateTime.Now.Month) == 8)
                {
                    base_price += 25;
                }
                _price = base_price;
            }
        }
        protected abstract void Set_Features();

        public int Get_Room_Number()
        {
            return _room_number;
        }
        public float Get_Price()
        {
            return _price;
        }
        public Guest Get_Guest()
        {
            return _guest;
        }
        public bool Is_Clean()
        {
            return _is_clean;
        }
        public string Get_Features()
        {
            return _features;
        }

        public override string ToString()
        {
            return "Room Number: " + _room_number + " The Room Is Clean?: " + _is_clean + " Room Price: " + _price + " Room Features: " + _features +" " + _guest.ToString();
        }
    }
}

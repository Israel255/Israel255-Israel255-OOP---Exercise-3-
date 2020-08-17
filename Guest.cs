using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    public class Guest
    {
        private int _id;
        private string _name;

        public Guest(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Get_Id()
        {
            return _id;
        }
        public string Get_Name()
        {
            return _name;
        }

        public override string ToString()
        {
            return "Guest Name: " + _name + " Guest Id: " + _id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    public class Address
    {
        public string Street_Name {  get; set; }
        public string Suburb { get; set; }
        public int PostCode { get; set; }
        public string Street { get; }
        public string State { get; set; }

        public Address( string sn, string sub, int pc,string state) 
        {
            Street_Name = sn;
            Suburb = sub;
            PostCode = pc;
            State = state;

        }

        public Address(string street)
        {
            Street = street;
        }

        public void setAddress(string  address)
        {
            Street_Name = address;
        }
    }
}

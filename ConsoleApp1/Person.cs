﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment2
{
    public class Person
    {
            public string Name { get; set; }
            public string Email { get; set; }
            public string TelNum { get; set; }
        
        public Person(string name, string email, string telNum)

        {
            Name = name;
            Email = email;
            TelNum = telNum;
        }

        
        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone Number: {TelNum}";
        }



    }
    
}

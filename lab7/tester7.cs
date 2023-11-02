using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab7
{
    
    internal class tester7
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow
            {
                Country = "USA",
                HideFromOtherAnimals = "Green Pastures",
                Name = "Bessie",
                WhatAnimal = "Cow"
            };
            XmlSerializer serializer = new XmlSerializer(typeof(Cow));
            using (StreamWriter writer = new StreamWriter("D:\\consol\\lab7\\Cow.xml"))
            {
                serializer.Serialize(writer, cow);
            }
        }
    }
}

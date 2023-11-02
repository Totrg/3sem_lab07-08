using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace lab7
{
    public enum eFavoriteFood { Meat, Plants, Everything }
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class CommentAttribute : Attribute
    {
        public string Comment { get; set; }

        public CommentAttribute(string comment)
        {
            Comment = comment;
        }
    }

    [Comment("Реализация абстрактного класса животного")]
    public abstract class Animal
    {
        private string Country { get; set; }
        private string HideFromOtherAnimals { get; set; }
        private string Name { get; set; }
        private string WhatAnimal { get; set; }
        private enum eClassificationAnimal
        {
            Hebivores, Carnivores, Omnivores
        }
        public Animal(string country, string hidefromanimals, string name, string whatanimal)
        {
            Country = country;
            HideFromOtherAnimals = hidefromanimals;
            Name = name;
            WhatAnimal = whatanimal;
        }
        public string GetClassificationAnimal() { return "Undef"; }
        public abstract eFavoriteFood GetFavoriteFood();
        public abstract void SayHello();

    }

    [Comment("Реализация класса коровы на основе животного")]
    public class Cow : Animal
    {
        public Cow() : base("", "", "", "") { }
        public string Country { get; set; }
        public string HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public string WhatAnimal { get; set; }
        public Cow(string country, string hidefromanimals, string name, string whatanimal) : base(country, hidefromanimals, name, whatanimal) { }
        public override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.Plants;
        }
        public override void SayHello() { Console.WriteLine("MOOOOOOOOOOOOOOOOOOOO!!!(!)!"); }
    }

    [Comment("Реализация класса льва на основе животного")]
    public class Lion : Animal
    {
        public Lion() : base("", "", "", "") { } 
        public string Country { get; set; }
        public string HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public string WhatAnimal { get; set; }
        public Lion(string country, string hidefromanimals, string name, string whatanimal) : base(country, hidefromanimals, name, whatanimal) { }
        public override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.Meat;
        }
        public override void SayHello() { Console.WriteLine("ROARRRRRRRRRRRR!!!(!)!"); }
    }

    [Comment("Реализация класса свиньи на основе животного")]
    public class Pig : Animal
    {
        public Pig() : base("", "", "", "") { }
        public string Country { get; set; }
        public string HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public string WhatAnimal { get; set; }
        public Pig(string country, string hidefromanimals, string name, string whatanimal) : base(country, hidefromanimals, name, whatanimal) { }

        public override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.Everything;
        }
        public override void SayHello() { Console.WriteLine("WHGHGHGHHHGHGH!!!(!)!"); }

    }
    
}

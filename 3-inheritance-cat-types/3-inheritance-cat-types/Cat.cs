using _3_inheritance_cat_types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace _3_inheritance_cat_types
{
    internal class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public Cat(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }
    }

    class HouseCat : Cat
    {
        public string breed { get; set; }

        public HouseCat(string name, string color, int age, string breed) : base(name, color, age)
        {
            this.breed = breed;
        }

        public void DisplayProfile()
        {
            Console.WriteLine($"Name:   {Name}\nColor:  {Color}\nAge:   {Age}\nBreed:   {breed}");
        }
    }
    
    class StrayCat : HouseCat
    {
        public string territory { get; set; }

        public StrayCat(string name, string color, int age, string breed, string territory) : base(name, color, age, breed)
        {
            this.territory = territory;
        }

        public void Fight()
        {
            Console.WriteLine($"{Name} is fighting.");
        }

        public void DisplayProfile()
        {
            base.DisplayProfile();
            Console.WriteLine($"Territory:  {territory}");
        }
    }

    class RescueCat : HouseCat
    {
        public string shelter { get; set; }
        public bool isVaccinated { get; set; }

        public RescueCat(string name, string color, int age, string breed, string shelter, bool isVaccinated) : base(name, color, age, breed)
        {
            this.shelter = shelter;
            this.isVaccinated = isVaccinated;
        }

        public void DisplayProfile()
        {
            base.DisplayProfile();
            Console.Write($"Shelter:    {shelter}\nVaccine status:  ");
            Console.WriteLine(isVaccinated ? "Vaccinated" : "Not vaccinated");
        }
    }
}

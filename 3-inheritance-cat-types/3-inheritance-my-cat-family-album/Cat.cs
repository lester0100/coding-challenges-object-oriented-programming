using _3_inheritance_my_cat_family_album;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_inheritance_my_cat_family_album
{
    class Cat
    {
        public string name { get; set; }
        public string color { get; set; }
        public int age { get; set; }

        public Cat(string name, string color, int age)
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }

        public virtual void CatProfile()
        {
            Console.WriteLine($"Name:   {name}\nColor:  {color}\nAge:   {age}");
        }
    }

    class HouseCat : Cat
    {
        public string breed { get; set; }

        public HouseCat(string name, string color, int age, string breed) : base(name, color, age)
        {
            this.breed = breed;
        }

        public void HouseCatProfile()
        {
            base.CatProfile();
            Console.WriteLine($"Breed:  {breed}");
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
            Console.WriteLine($"{name} is fighting.");
        }

        public void StrayCatProfile()
        {
            base.HouseCatProfile();
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

        public void RescueCatProfile()
        {
            base.HouseCatProfile();
            Console.Write($"Shelter:    {shelter}\nVaccine status:  ");
            Console.WriteLine(isVaccinated ? "Vaccinated" : "Not vaccinated");
        }
    }
}

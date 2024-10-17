using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NoasArkInheritance
{
    class Animal
    {
        public DateTime Birthdate { get; }
        public Gender Gender { get; }
        //public string AnimalType { get; }
        public Animal(DateTime birthdate, Gender gender) 
        {
            //AnimalType = animalType;
            Birthdate = birthdate;
            Gender = gender;
        }
        // I virtual kan ge standard beetende men vi kan overrida den i ärvande klassen.
        // I abstract metoden, vi ger inte standard beetende men vi måste overrida den.
        public virtual void Speak()
        {
            WriteLine($"I'm a {Gender} animal and my birthdate is {Birthdate}");

        }
        public virtual void Eat()
        {
            WriteLine("Animal is eating....");
        }
    }

    // Vi har skapat upp en ny typ Gender som innehåller Male eller Female
    enum Gender
    {
        Female,
        Male
    }
}

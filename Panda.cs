using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace NoasArkInheritance
{
    class Panda : Animal
    {
        public Panda(DateTime birthdate, Gender gender)
            : base(birthdate, gender)
        {

        }
        public override void Speak()
        {
            WriteLine($"I'm a {Gender} panda and my birthdate is {Birthdate}");
        }
    }

}
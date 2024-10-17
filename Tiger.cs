using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace NoasArkInheritance
{
    class Tiger : Animal
    {
        public byte StripeCount { get; }
        public Tiger(byte stripeCount, DateTime birthdate, Gender gender) : base(birthdate, gender)
        {
            //Birthdate = birthdate;
            //Gender = gender;
            StripeCount = stripeCount;

        }
        public override void Speak()
        {
            WriteLine($"I'm a {Gender} animal and my birthdate is {Birthdate}");

        }
    }
}


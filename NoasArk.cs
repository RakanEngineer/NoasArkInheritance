using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NoasArkInheritance
{
    class NoasArk
    {
        // Här har vi Array av lista med till Animal eller lista med reference till animal 
        private Animal[] animalList = new Animal[10];
        private ushort nextAvailableCage;

        // Här vi skapar upp NoasArk, hur många numberOfCages har vi på botten
        // då skapar vi upp här många referenser till här listan---> numberOfCages.
        public NoasArk(ushort numberOfCages)
        {
            animalList = new Animal[numberOfCages];
        }

        public void Load(Animal animal)
        {
            animalList[nextAvailableCage++] = animal;
        }
        public void RollCall()
        {
            foreach (Animal animal in animalList)
            {
                if (animal == null) continue;

                animal.Speak();

                WriteLine(animal.GetType());

            }
        }
    }
}

using System;
using static System.Console;

namespace NoasArkInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NoasArk noasArk = new NoasArk(numberOfCages: 20);

            //Animal animal = new Animal("Tiger", birthdate: new DateTime(2010, 1, 1), gender: Gender.Female);
            //noasArk.Load(animal);

            //Tiger tiger = new Tiger(birthdate: new DateTime(2010, 1, 1), gender: Gender.Female);
            Tiger tiger = new Tiger(stripeCount: 10, birthdate: new DateTime(2010, 11, 10), gender: Gender.Female);

            Panda panda = new Panda(birthdate: new DateTime(2016, 1, 1), gender: Gender.Male);

            Rabbit rabbit = new Rabbit(birthdate: new DateTime(2016, 1, 1), gender: Gender.Male);

            noasArk.Load(tiger);

            noasArk.Load(panda);

            noasArk.Load(rabbit);

            noasArk.RollCall();

            tiger.Eat();

            rabbit.Eat();

            //bool shouldNotExit = true;

            //while (shouldNotExit)
            //{
            //    WriteLine("1. Show registry");
            //    WriteLine("2. Exit");

            //    ConsoleKeyInfo keyPressed = ReadKey(true);

            //    Clear();

            //    switch (keyPressed.Key)
            //    {
            //        case ConsoleKey.D1:
            //        case ConsoleKey.NumPad1:

            //            break;

            //        case ConsoleKey.D2:
            //        case ConsoleKey.NumPad2:

            //            shouldNotExit = false;

            //            break;
            //    }

            //    Clear();
            //}
        }
    }
}

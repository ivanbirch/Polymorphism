using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Colour { get; set; }

        public Car(int hp, string colour)
        {
            this.HP = hp;
            this.Colour = colour;
        }
        // default constructor
        public Car()
        {

        }
        public void ShowDetails()
        {
            Console.WriteLine("HP:" + HP + "colour: " + Colour);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}

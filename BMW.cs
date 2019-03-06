using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class BMW:Car
    {
        private string brand = "BMW";
        public string Model { get; set; }

        public BMW(int hp, string colour, string model):base(hp, colour)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand " + brand + "HP:" + HP + "colour: " + Colour);
        }
        public override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired", Model);
        }
        
    }
}

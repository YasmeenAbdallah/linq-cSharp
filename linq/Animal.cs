using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Animal
    {
        
        public string Name { get; set; }
        public double Height { get; set; }
        public double weight { get; set; }
        public int AnimalId { get; set; }
        public  Animal(string name = "no name", double h = 0, double w = 0)
        {
            Name = name;
            Height = h;
            weight = w;
        }
        public override string ToString()
        {
            return string.Format("{0} weight {1}lbs and is {2} inches tall", Name, weight, Height);
        }
    }
}


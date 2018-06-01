using System;

namespace ContainerSchipNew.Models
{
    public class Container
    {
        public double Weight { get; set; }
        public bool Valuable { get; set; }
        public bool Cooled { get; set; }

        public Container() { }

        public Container(double weight, bool valuable, bool cooled)
        {
            Weight = weight;
            Valuable = valuable;
            Cooled = cooled;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}, V: {Valuable}, C: {Cooled}";
        }
    }
}
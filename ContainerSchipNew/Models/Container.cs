using System;

namespace ContainerSchipNew.Models
{
    public class Container
    {
        public double Weight { get; set; }
        public bool Valuable { get; set; }
        public bool Cooled { get; set; }

        public Container() { }

        /// <summary>
        /// New container constructor
        /// </summary>
        /// <param name="weight">Weight of the container</param>
        /// <param name="valuable">Bool if item is checked true, if true the container is cooled</param>
        /// <param name="cooled">Bool if item is checked true, if true the item is cooled</param>
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
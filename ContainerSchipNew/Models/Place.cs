using System.Collections.Generic;

namespace ContainerSchipNew.Models
{
    public class Place
    {
        public double Weight { get; set; }
        public double MaxWeight { get; set; }
        public List<Container> Containers { get; set; } = new List<Container>();
        public int Position { get; set; }

        public Place() { }

        public Place(int position, double weight)
        {
            Position = position;
            MaxWeight = weight / 6;
        }

        public bool AddContainer(Container container)
        {
            //Check if there already is a valuable container in the list
            if (container.Valuable && Containers.Find(c => c.Valuable) != null)
            {
                return false;
            }
            if (!CheckWeight(container.Weight))
            {
                return false;
            }
            Containers.Add(container);
            return true;
        }

        private bool CheckWeight(double containerWeight)
        {
            //Check if the Max Weight of one place is not exceeded
            if (!(Weight + containerWeight <= MaxWeight))
            {
                return false;
            }
            Weight = Weight + containerWeight;
            return true;
        }

        public void RemoveContainer(Container container)
        {
            Containers.Remove(container);
            Weight = Weight - container.Weight;
        }
    }
}
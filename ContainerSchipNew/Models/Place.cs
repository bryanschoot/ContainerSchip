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

        /// <summary>
        /// Create a place
        /// </summary>
        /// <param name="position">The position of a place for example: 1/2/3/4/5</param>
        /// <param name="weight">Weight of the ship</param>
        public Place(int position, double weight)
        {
            Position = position;
            MaxWeight = weight / 6;
        }

        /// <summary>
        /// Add a container to the container list
        /// </summary>
        /// <param name="container">Container object to fill the list of containers</param>
        /// <returns></returns>
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

        /// <summary>
        /// Check the weight of the container. (To know if it will fit in a place.)
        /// </summary>
        /// <param name="containerWeight">Weight of the container object</param>
        /// <returns></returns>
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

        /// <summary>
        /// Remove a container used to balance the ship
        /// </summary>
        /// <param name="container">Container object (the to be deleted)</param>
        public void RemoveContainer(Container container)
        {
            Containers.Remove(container);
            Weight = Weight - container.Weight;
        }
    }
}
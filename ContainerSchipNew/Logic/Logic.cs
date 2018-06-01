using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ContainerSchipNew.Models;
using Enum = ContainerSchipNew.Models.Enum;

namespace ContainerSchipNew.Logic
{
    public class Logic
    {
        private List<Container> containers = new List<Container>();
        private Ship Ship;
        private Container container;

        /// <summary>
        /// Does nothing
        /// </summary>
        public Logic()
        {
        }

        /// <summary>
        /// The addship method initilizes the ship. 
        /// </summary>
        /// <param name="weight">Max weight of the ship</param>
        /// <param name="places">Amount of places</param>
        /// <returns>ship model</returns>
        public Ship AddShip(double weight, int places)
        {
            var place = new List<Place>();
            for (int i = 0; i < places; i++)
            {
                place.Add(new Place(i, weight));
            }
            return this.Ship = new Ship(weight, place);
        }

        /// <summary>
        /// The addcontainer methods adds a new container to a list
        /// </summary>
        /// <param name="_enum">Value of weight 30000 of 4000</param>
        /// <param name="_valuable"></param>
        /// <param name="_cooled"></param>
        /// <returns></returns>
        public List<Container> AddContainer(double _enum, bool _valuable, bool _cooled)
        {
            container = new Container
            {
                Weight = _enum,
                Valuable = _valuable,
                Cooled = _cooled,
            };
            containers.Add(container);
            return containers;
        }

        /// <summary>
        /// TrySort will check if the ship can be made.
        /// </summary>
        /// TODO optimize TrySort()
        public void TrySort()
        {
            var valuable = 0;
            double _cooled = 0;
            double _max = 300000; //this.Ship.Places[3].MaxWeight + this.Ship.Places[6].MaxWeight; //Gets the front side of the ships and count them;

            foreach (var container in containers)
            {
                if (container.Valuable)
                {
                    valuable = valuable + 1;
                    if (valuable <= 2) { _max = _max - container.Weight; }
                }
                if (container.Cooled) { _cooled = _cooled + container.Weight; }
            }

            //Custom exceptions
            if (containers.Select(c => c.Weight).Sum() < this.Ship.MinWeight || containers.Select(c => c.Weight).Sum() > this.Ship.MaxWeight)
            {
                throw new ExceptionHandler($"Please take a closer look to the ships min and max weight!");
            }
            if (containers.Where(x => x.Valuable == true).Count() > 4)
            {
                throw new ExceptionHandler($"The amount of valuable containers need to be under 4!");
            }
            if (_cooled > _max)
            {
                throw new ExceptionHandler($"The weight of the cooled container is over the max capacity and will not fit on the front of the ship");
            }
        }

        /// <summary>
        /// The placecontainer method places the container in a list.
        /// </summary>
        /// <returns></returns>
        public bool PlaceContainer()
        {
            int _counter = 0;
            bool placement = true;

            foreach (var container in OrderContainers())
            {
                if (_counter > 5)
                {
                    _counter = 0;
                }
                if (container.Valuable)
                {
                    //Add container to location where valuables containers are permitted
                    if (this.Ship.Places[0].AddContainer(container) || this.Ship.Places[2].AddContainer(container) || this.Ship.Places[3].AddContainer(container) || this.Ship.Places[5].AddContainer(container))
                    {
                        continue;
                    }
                }
                if (container.Cooled)
                {
                    // Simple true and false checker to switch between the two front sides
                    if (placement)
                    {
                        if (this.Ship.Places[2].AddContainer(container))
                        {
                            placement = false;
                            continue;
                        }
                    }
                    else
                    {
                        if (this.Ship.Places[5].AddContainer(container))
                        {
                            placement = true;
                            continue;
                        }
                    }
                }
                else
                {
                    //Counter to reset and let each container try a different list
                    for (int i = _counter; i < 6; i++)
                    {
                        if (this.Ship.Places[i].AddContainer(container))
                        {
                            _counter++;
                            break;
                        }
                    }
                }
            }

            // Calculates the weight of upper row and lower row
            this.Ship.UpperRow = this.Ship.Places[0].Weight + this.Ship.Places[1].Weight + this.Ship.Places[2].Weight;
            this.Ship.LowerRow = this.Ship.Places[3].Weight + this.Ship.Places[4].Weight + this.Ship.Places[5].Weight;

            while (this.Ship.CalculateBalance() < -20)
            {
                this.Ship.BalanceShip();
            }
            return true;
        }

        /// <summary>
        /// Order the container list First Valuable then cooled and last normal;
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Container> OrderContainers()
        {
            var _cooled = new List<Container>();
            var _valuable = new List<Container>();
            var _normal = new List<Container>();
            var _ordendContainers = new List<Container>();

            // Assigning new list to certain containers
            foreach (var container in containers)
            {
                if (container.Valuable)
                    _valuable.Add(container);
                else if (container.Cooled)
                    _cooled.Add(container);
                else
                    _normal.Add(container);
            }

            //Add all sperate lists to one list.
            _ordendContainers.AddRange(_valuable);
            _ordendContainers.AddRange(_cooled);
            _ordendContainers.AddRange(_normal);
            return _ordendContainers;
        }
        
        public List<Place> GetPlace()
        {
            return this.Ship.Places;
        }
    }
}
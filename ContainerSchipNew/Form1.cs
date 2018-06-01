using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContainerSchipNew.Logic;

namespace ContainerSchipNew
{
    public partial class ContainerShip : Form
    {
        private Logic.Logic logic;
        private Models.Ship ship;

        public ContainerShip()
        {
            InitializeComponent();
            StartUp();

            this.logic = new Logic.Logic();
        }

        /// <summary>
        /// Fill the basic items with some value in this one we are filling the Enum to the Dropdown textbox
        /// </summary>
        private void StartUp()
        {
            var values = Enum.GetValues(typeof(Models.Enum));
            foreach (var type in values)
            {
                WeightContainerDropdown.Items.Add(type);
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void AddShipButton_Click(object sender, EventArgs e)
        {
            double _weight = Convert.ToDouble(ShipNummeric.Value);
            ship = this.logic.AddShip(_weight, 6);

            ShipLabel.Text = ship.ToString();

            AddShipButton.Enabled = false;
            AddContainerButton.Enabled = true;
        }

        /// <summary>
        /// Add container button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContainerButton_Click(object sender, EventArgs e)
        {
            //Check if input is not empty
            if (WeightContainerDropdown.Text != String.Empty)
            {
                //parse enum to usable int
                var _enum = (Models.Enum)Enum.Parse(typeof(Models.Enum), WeightContainerDropdown.Text);
                var _valuable = ValuableRadio.Checked;
                var _cooled = CooledRadio.Checked;
                var containers = this.logic.AddContainer((int)_enum, _valuable, _cooled);

                UpdateContainerList(containers);
                MessagesRichbox.Clear();
                SortButton.Enabled = true;
            }
            else
            {
                //show messagebox when text is empty
                MessageBox.Show("Please choose a container weight!");
            }
        }

        /// <summary>
        /// Update the list of containers
        /// </summary>
        /// <param name="containers">List of containers</param>
        private void UpdateContainerList(List<Models.Container> containers)
        {
            double _weight = containers.Select(c => c.Weight).Sum();
            int _valuable = containers.Count(c => c.Valuable == true);
            int _cooled = containers.Count(c => c.Cooled == true);
            int _normal = containers.Count(c => c.Cooled == false && c.Valuable == false);

            containerList.Items.Clear();

            foreach (var container in containers)
            {
                containerList.Items.Add(container.ToString());
            }

            ContainerLabel.Text = $"Weight: {_weight}\nValuable: {_valuable}\nCooled: {_cooled}\nNormal: {_normal}";
        }

        /// <summary>
        /// This button will fire the algorithm!
        /// </summary>
        /// <param name="sender">Form submit</param>
        /// <param name="e"></param>
        private void SortButton_Click(object sender, EventArgs e)
        {
            //QuickSort (Checking if all the containers can be used)
            try { this.logic.TrySort(); }
            catch (ExceptionHandler exception) { MessagesRichbox.Text = exception.Message; return; }

            //Place the containers
            try { this.logic.PlaceContainer(); }
            catch (ExceptionHandler exception) { MessagesRichbox.Text = exception.Message; return; }

            //If there is no custom exception then continue
            //Assign the already sorted containers to the right list
            placeList1.DataSource = this.logic.GetPlace()[0].Containers;
            placeList2.DataSource = this.logic.GetPlace()[1].Containers;
            placeList3.DataSource = this.logic.GetPlace()[2].Containers;
            placeList4.DataSource = this.logic.GetPlace()[3].Containers;
            placeList5.DataSource = this.logic.GetPlace()[4].Containers;
            placeList6.DataSource = this.logic.GetPlace()[5].Containers;

            //Info about containerlist after sort
            ContainerRow1Label.Text = $"Weight first row: {this.logic.GetPlace()[0].Containers.Select(c => c.Weight).Sum() + this.logic.GetPlace()[1].Containers.Select(c => c.Weight).Sum() + this.logic.GetPlace()[2].Containers.Select(c => c.Weight).Sum()}";
            ContainerRow2Label.Text = $"Weight second row: {this.logic.GetPlace()[3].Containers.Select(c => c.Weight).Sum() + this.logic.GetPlace()[4].Containers.Select(c => c.Weight).Sum() + this.logic.GetPlace()[5].Containers.Select(c => c.Weight).Sum()}";
            ShipLabel.Text = $"{ship.ToString()}\nBalance: {ship.CalculateBalance()}%";

            //Disable all buttons when done
            SortButton.Enabled = false;
            DeleteButton.Enabled = false;
        }
    }
}

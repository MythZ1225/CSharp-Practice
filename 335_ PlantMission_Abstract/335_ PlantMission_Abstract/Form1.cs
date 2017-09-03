using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _335__PlantMission_Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PlanetMission PM = new PlanetMission();

            Venus VM = new Venus();

            Mars MM = new Mars();

            // MessageBox.Show("PM" + PM.FuelNeeded());
            MessageBox.Show("VM" + VM.FuelNeeded());
            MessageBox.Show("MM" + MM.FuelNeeded());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Bill : Form
    {
        private readonly Random _random = new Random();
        public Bill()
        {
            InitializeComponent();
            
        }
        public int RandomNumber(int min, int max)
        {  
            return _random.Next(min, max);
        }

        public double EnergyBill()
        {
            double bill, green = 5.108, blue = 7.658, red = 15.330;
        
            int spentEnergy = Convert.ToInt32(textBoxSpentEnergy.Text);
            if (spentEnergy <= 350)
            {
                bill = spentEnergy * green;
            }
            else if (spentEnergy <= 1600)
            {
                int diff = spentEnergy - 350;
                bill = diff * blue + 350 * green;
            }
            else
            {
                int x = spentEnergy - 1600;
                bill = x * red + 1250 * blue + 350 * green;
            }
            return bill;
        }

        public double WaterBill()
        {
            int spentWater = Convert.ToInt32(textBoxSpentWater.Text);
            double bill, first = 53.8, second= 110.23;
            if (spentWater <= 10)
            {
                bill = spentWater * first;
            }
            else
            {
                int diff = spentWater - 10;
                bill = diff * second + 10 * first;
            }
            return bill;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            //ElectricalEnergy
            int randomEnergy = RandomNumber(0, 3000);
            textBoxSpentEnergy.Text = randomEnergy.ToString();
            textBoxEnergyBill.Text = EnergyBill().ToString();

            //Balance
            int balance = RandomNumber(1000, 50000);
            textBoxBalance.Text = balance.ToString();

            //Water
            int randomWater = RandomNumber(0, 40);
            textBoxSpentWater.Text = randomWater.ToString();
            textBoxWaterBill.Text = WaterBill().ToString();

            //Internet
            int randomInternet = RandomNumber(1000, 2000);
            textBoxInternetBill.Text = randomInternet.ToString(); 
        }

        private void buttonPayEnergy_Click(object sender, EventArgs e)
        {
            double current = Convert.ToDouble(textBoxBalance.Text);
            double bill = Convert.ToDouble(textBoxEnergyBill.Text);

            double newBalance = current - bill;
            if (newBalance <= 0)
                MessageBox.Show("You don't have enough money!!!");
            else
            textBoxBalance.Text = newBalance.ToString();

            buttonPayEnergy.Enabled = false;
            MessageBox.Show("Pay was successful!");
        }

        private void buttonPayWater_Click(object sender, EventArgs e)
        {
            double current = Convert.ToDouble(textBoxBalance.Text);
            double bill = Convert.ToDouble(textBoxWaterBill.Text);

            double newBalance = current - bill;
            if (newBalance <= 0)
                MessageBox.Show("You don't have enough money!!!");
            else
            textBoxBalance.Text = newBalance.ToString();
            buttonPayWater.Enabled = false;
            MessageBox.Show("Pay was successful!");

        }

        private void buttonPayInternet_Click(object sender, EventArgs e)
        {
            double current = Convert.ToDouble(textBoxBalance.Text);
            double bill = Convert.ToDouble(textBoxInternetBill.Text);

            double newBalance = current - bill;
            if (newBalance <= 0)
                MessageBox.Show("You don't have enough money!!!");
            else
            textBoxBalance.Text = newBalance.ToString();
            buttonPayInternet.Enabled = false;
            MessageBox.Show("Pay was successful!");

        }

        private void buttonHelpBill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! You can only one time pay one bill! If you don't have enough money, we're sorry!", "Information");
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HockeyButton_Click(object sender, EventArgs e)
        {
            int wayneGretzky = 99;
            string hockeyName = "Wayne Gretzky is number";
            outputLabel.Text = $"{hockeyName} {wayneGretzky}";

        }

        private void AreaButton_Click(object sender, EventArgs e)
        {      
            double radius = 15;
            double pi = 3.14;
            double totalRadius = radius * radius;
            double area = totalRadius * pi;

            outputLabel.Text = $"The area of circle with a radius of {radius} is {area}^2";

        }

        private void CarpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;

            outputLabel.Text = $"The area of a room with dimensions {length}m x {width}m is {area}m^2";
            outputLabel.Text += $"\n\nThe cost to carpet this area at {costPerMeter} per square metre is {totalCost}";
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            double shirtPrice = 12.49;
            double tendered = 20.00;
            double tax = 1.62;
            double total = tax + shirtPrice;
            double charge = tendered - total;

            outputLabel.Text = "Bill of Sale";
            outputLabel.Text += $"\n\nShirt:      {shirtPrice}";
            outputLabel.Text += $"\n\nTax:         {tax}";
            outputLabel.Text += $"\nTotal:      {total}";
            outputLabel.Text += $"\n\nTendered:      {tendered}";
            outputLabel.Text += $"\nChange:      {charge}";
        }  
    }
}

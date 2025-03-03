﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoapClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var client = new MyServiceReference.CalculatorWebServiceSoapClient();
            var result = await client.AddAsync(Convert.ToInt32(textBoxA.Text), Convert.ToInt32(textBoxB.Text));
            MessageBox.Show("Result: " + result);
        }

        private async void buttonSub_Click(object sender, EventArgs e)
        {
            var client = new MyServiceReference.CalculatorWebServiceSoapClient();
            var result = await client.SubAsync(Convert.ToInt32(textBoxA.Text), Convert.ToInt32(textBoxB.Text));
            MessageBox.Show("Result: " + result);
        }

        private async void buttonMul_Click(object sender, EventArgs e)
        {
            var client = new MyServiceReference.CalculatorWebServiceSoapClient();
            var result = await client.MulAsync(Convert.ToInt32(textBoxA.Text), Convert.ToInt32(textBoxB.Text));
            MessageBox.Show("Result: " + result);
        }

        private async void buttonDiv_Click(object sender, EventArgs e)
        {
            var client = new MyServiceReference.CalculatorWebServiceSoapClient();
            var result = await client.DivAsync(Convert.ToInt32(textBoxA.Text), Convert.ToInt32(textBoxB.Text));
            MessageBox.Show("Result: " + result);
        }
    }
}

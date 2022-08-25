using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btn0.Clicked += Btn0_Clicked;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;
            btn6.Clicked += Btn6_Clicked;
            btn7.Clicked += Btn7_Clicked;
            btn8.Clicked += Btn8_Clicked;
            btn9.Clicked += Btn9_Clicked;

            decimalButton.Clicked += DecimalButton_Clicked;
        }

        private void DecimalButton_Clicked(object sender, EventArgs e)
        {
            if(!labelDisplay.Text.Contains("."))
            {
                labelDisplay.Text += ".";
            }
        }

        private void Btn0_Clicked(object sender, EventArgs e)
        {
            if(labelDisplay.Text != "0")
            {
                labelDisplay.Text = labelDisplay.Text + "0";
            }
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            updateDisplay("1");
        }

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            updateDisplay("2");
        }

        private void Btn3_Clicked(object sender, EventArgs e)
        {
            updateDisplay("3");
        }

        private void Btn4_Clicked(object sender, EventArgs e)
        {
            updateDisplay("4");
        }

        private void Btn5_Clicked(object sender, EventArgs e)
        {
            updateDisplay("5");
        }

        private void Btn6_Clicked(object sender, EventArgs e)
        {
            updateDisplay("6");
        }

        private void Btn7_Clicked(object sender, EventArgs e)
        {
            updateDisplay("7");
        }

        private void Btn8_Clicked(object sender, EventArgs e)
        {
            updateDisplay("8");
        }

        private void Btn9_Clicked(object sender, EventArgs e)
        {
            updateDisplay("9");
        }

        private void updateDisplay(string s)
        {
            if(labelDisplay.Text == "0")
            {
                labelDisplay.Text = s;
            }
            else
            {
                labelDisplay.Text = labelDisplay.Text + s;
            }
        }

    }
}

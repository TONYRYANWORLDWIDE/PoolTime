using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PoolTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CalcTime()
        {
            if (tbInches.Text != "")
            {
                double height = double.Parse(tbInches.Text);
                double volume = (Math.PI * (96 * 96) * height) / 231;
                double secgal = double.Parse(tbSecGal.Text);
                double Timeleft = (volume * secgal) / 3600;
                tbTimeLeft.Text = Math.Round(Timeleft,2).ToString();
            }
            else
            {
                tbTimeLeft.Text = "NA";
                if(tbMessage.Text.Length > 0)
                {
                    tbMessage.Text = tbMessage.Text + Environment.NewLine  + "\r\n" + "Need Inches Entered to Calculate Time Left";
                }
                else
                {
                    tbMessage.Text =  "Need Inches Entered to Calculate Time Left";
                }
                
            }
        }
        private void CalcInches()
        {
            if (tbTime.Text != "" && tbSecGal.Text != "")
            {
                double secgal = double.Parse(tbSecGal.Text);
                double minutes = double.Parse(tbTime.Text);
                double gallons = (minutes * 60) / secgal;
                tbglns.Text = gallons.ToString();
                double inches = (gallons * 231) / (Math.PI * 96 * 96);
                tbInchesRaised.Text = Math.Round(inches,2).ToString();
            }
            else
            {
                tbglns.Text = "NA";
                tbInchesRaised.Text = "NA";
                if (tbMessage.Text.Length > 0)
                {
                    tbMessage.Text = tbMessage.Text + Environment.NewLine + "\r\n" + "Need Time Entered to Calculate Inches and Gallons";
                }
                else
                {
                    tbMessage.Text = tbMessage.Text  + "Need Time Entered to Calculate Inches and Gallons";
                }
               
            }
        }
        private void BtCalcTime_Click(object sender, EventArgs e)
        {
            CalcTime();
            CalcInches();
        }
        private void BtClear_Click(object sender, EventArgs e)
        {
            //tbglns.Text = "";
            //tbInchesRaised.Text = "";
            foreach(Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            tbSecGal.Text = "12.5";
        }


    }
}

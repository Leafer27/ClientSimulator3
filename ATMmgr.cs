using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSimulator3
{
    public partial class ATMmgr : Form
    {
        public ATMmgr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mgrInput.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mgrInput.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mgrInput.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mgrInput.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mgrInput.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mgrInput.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mgrInput.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mgrInput.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mgrInput.AppendText("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            mgrInput.AppendText("0");
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            mgrInput.Text += ".";
            Decimal.Enabled = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            mgrInput.Clear();
            Decimal.Enabled = true;

        }

        private void payInt_Click(object sender, EventArgs e)
        {

        }

        private void RefillAtm_Click(object sender, EventArgs e)
        {
            var date1 = DateTime.Now.ToString(@"MM\/dd\/yyyy H\:mm tt");
            int bal = 20000;
            using StreamWriter file = new(@"C:\Users\ryan9\OneDrive\Documents\CDI\CA-PRFND-C#\ClientSimulator3\Files\DailyBalances.txt", append: true);
            file.Write(date1 + ",");
            file.WriteLine(bal);
            file.Close();
            this.mgrScreen.Text += "Balance Refilled!";

        }

        private void OutOfService_Click(object sender, EventArgs e)
        {

        }

        private void printAccounts_Click(object sender, EventArgs e)
        {

        }

        private void mainScreen_Click(object sender, EventArgs e)
        {

        }

        private void mgrInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void mgrScreen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

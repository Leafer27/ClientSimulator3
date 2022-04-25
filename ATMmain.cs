using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace ClientSimulator3
{
    public partial class ATMmain : Form
    {
        public ATMmain()
        {
            InitializeComponent();
            string userAccount = Login.userAccount;
        }

        public string UserAmount()
        {
            string Amount = this.Amount.Text;
            return Amount;
        }


        public static bool VerifRegex(string Amount)
        {
            string strRegex = @"^\d+(?:\.\d{0,2})?$";
            Regex rx = new Regex(strRegex);

            if (rx.IsMatch(Amount))
                return true;
            else
                MessageBox.Show("Enter amount as 0.00");
            return false;


        }
        private void Deposit_CheckedChanged(object sender, EventArgs e)
        {
            depAccount();
        }

        private void PayBills_CheckedChanged(object sender, EventArgs e)
        {
            if (PayBills.Checked == true)
            {
                MessageBox.Show("You will be charged a $1.25 fee for this transaction");
            }

        }

        private void Transfer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Withdrawal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Chequing_CheckedChanged(object sender, EventArgs e)
        {
            if (PayBills.Checked == true)
            {
                Chequing.Checked = true;
            }

        }

        private void Savings_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Amount.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amount.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Amount.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Amount.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Amount.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Amount.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Amount.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Amount.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Amount.AppendText("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Amount.AppendText("0");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Amount.Clear();
            Point.Enabled = true;
        }

        private void Point_Click(object sender, EventArgs e)
        {
            Amount.Text += ".";
            Point.Enabled = false;

        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            UserAmount();

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            VerifRegex(Amount.Text);

            if (true)
            {

                if (Deposit.Checked == true)
                {
                    //MessageBox.Show("Deposit");
                    depAccount();
                }
                else if (PayBills.Checked == true)
                {
                    payBills();

                }
                else if (Withdrawal.Checked == true)
                {
                    MessageBox.Show("Withdrawal");

                }
                else if (Transfer.Checked == true)
                {
                    MessageBox.Show("Transfer");

                }


            }
            else if (false)
            {
                MessageBox.Show("Enter amount as 0.00");

            }
        }

        private void depAccount()
        {

            string[] lines = File.ReadAllLines(@"C:\Users\ryan9\OneDrive\Documents\CDI\CA-PRFND-C#\ClientSimulator3\Files\Accounts.txt");

            //acctype = line1[0];
            //accnum = line1[2];
            //accbal = line1[3];
            StringBuilder newBal = new StringBuilder();

            foreach (var line in lines)
            {

                var line1 = line.Split(",");

                if ((Chequing.Checked == true) && (Login.userAccount == line1[1]) && (line1[0] == "c"))
                {
                    string calcBal = (line1[3] + this.Amount.Text);
                    newBal.AppendLine(calcBal);
                    MessageBox.Show(calcBal);

                }

                else if ((Savings.Checked == true) && (Login.userAccount == line1[1]) && (line1[0] == "s"))
                {
                    string calcBal = (line1[3] + this.Amount.Text);
                    newBal.AppendLine(calcBal);

                    MessageBox.Show(calcBal);
                }




                using StreamWriter file = new(@"C:\Users\ryan9\OneDrive\Documents\CDI\CA-PRFND-C#\ClientSimulator3\Files\temp.txt");
                foreach (var line0 in lines)
                {
                    var line2 = line0.Split(",");
                    if (!line2[1].Contains(Login.userAccount))
                    {
                        file.Write(line2[0] + ",");
                        file.Write(line2[1] + ",");
                        file.Write(line2[2] + ",");
                        file.WriteLine(line2[3]);
                    }
                    else if (line2[1].Contains(Login.userAccount))
                    {
                        file.Write(line2[0] + ",");
                        file.Write(line2[1] + ",");
                        file.Write(line2[2] + ",");
                        file.WriteLine(newBal.ToString());
                    }
                }

            }
            MessageBox.Show(newBal.ToString());
        }

        private void payBills()
        {
            if (balVerify() == true)
            {
                string[] lines = File.ReadAllLines(@"C:\Users\ryan9\OneDrive\Documents\CDI\CA-PRFND-C#\ClientSimulator3\Files\Accounts.txt");

                foreach (var line in lines)
                {

                    var line1 = line.Split(",");

                    if ((Chequing.Checked == true) && (Login.userAccount == line1[1]) && (line1[0] == "c"))
                    {
                        string ab = line1[3];
                        Single accBal = Single.Parse(ab);
                        string amt = this.Amount.Text;
                        Single cheAmt = Single.Parse(amt);
                        Double feeAmt = cheAmt + 1.25;

                        Double nb = (accBal - feeAmt);
                        string newBal = nb.ToString();

                        using StreamWriter file = new(@"C:\Users\ryan9\OneDrive\Documents\CDI\CA-PRFND-C#\ClientSimulator3\Files\temp.txt");
                        foreach (var line0 in lines)
                        {
                            var line2 = line0.Split(",");
                            if (!line2[1].Contains(Login.userAccount))
                            {
                                file.Write(line2[0] + ",");
                                file.Write(line2[1] + ",");
                                file.Write(line2[2] + ",");
                                file.WriteLine(newBal);
                            }




                        }
                    }
                }
            }
        }

        private bool balVerify()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\ryan9\OneDrive\Documents\CDI\CA-PRFND-C#\ClientSimulator3\Files\Accounts.txt");
            foreach (var line in lines)
            {

                var line1 = line.Split(",");

                if ((Chequing.Checked == true) && (Login.userAccount == line1[1]) && (line1[0] == "c"))
                {
                    string cb = line1[3];
                    Single cheBal = Single.Parse(cb);
                    string amt = this.Amount.Text;
                    Single cheAmt = Single.Parse(amt);

                    if (cheAmt > cheBal)
                    {
                        return false;
                    }

                }

                else if ((Savings.Checked == true) && (Login.userAccount == line1[1]) && (line1[0] == "s"))
                {
                    string sb = line1[3];
                    Single savBal = Single.Parse(sb);
                    string amt = this.Amount.Text;
                    Single savAmt = Single.Parse(amt);

                    if (savAmt > savBal)
                    {
                        return false;
                    }

                }


            }
            return true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

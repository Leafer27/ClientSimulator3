namespace ClientSimulator3
{
    public partial class Login : Form
    {
        public static string userAccount = "";
        public Login()
        {
            InitializeComponent();

        }
        public string UserName()
        {
            string Name = this.NameEntry.Text;
            return Name;
        }

        public static string atmManager()
        {
            string MgrName = "atmmgr";
            return MgrName;
            string MgrPass = "0000";
            return MgrPass;
        }

        public string UserVerify()
        {
            var m = new ATMmain();
            var q = new ATMmgr();
            string Pin = this.textBox1.Text;
            string Name = this.NameEntry.Text;
            bool userfound = false;
            bool adminfound = false;
            int i = 0;
            var user = "";

            string[] lines = File.ReadAllLines(@"C:\Users\ryan9\OneDrive\Documents\CDI\CA-PRFND-C#\ClientSimulator3\Files\Customers.txt");
            
            
            if (Name == "atmmgr" && Pin == "0000")
            {
                q.Show();
                adminfound = true;
                // break;

            }

            foreach (var line in lines)
            {
                var line1 = line.Split(",");


                if (Name.Equals(line1[0]) && Pin.Equals(line1[1]))
                {

                    user = Pin;
                    m.Show();
                    userfound = true;                    
                    //MessageBox.Show();
                    //break;
                }

            }

            if ((adminfound = false) || (userfound = false) && (i <= 3))
            {
                MessageBox.Show("Wrong Name/PIN Combination. Please Try Again");
                
            }

            else if (i >3)
            {
                MessageBox.Show("Too Many Attempts.Please Try Again Later");
                i += 1;                       
            }    
                      
            return user;
        }

        static string userInfo(string user)
        {
            
            return user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }   

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.AppendText("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");

        }

        private void Point_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //PIN();
        }

        private void NameEntry_TextChanged(object sender, EventArgs e)
        {
            UserName();
        }

        private void Enter_Click(object sender, EventArgs e) 
        {
            userAccount = textBox1.Text;
            UserVerify();
            BalanceRefill();




        }

        private void BalanceRefill()
        {

            string[] lines = File.ReadAllLines(@"C:\Users\ryan9\OneDrive\Documents\CDI\CA-PRFND-C#\ClientSimulator3\Files\DailyBalances.txt");

            foreach (var line in lines)
            {
                var line1 = line.Split(",");
                string ld = line1[0];
                DateTime lastDate = DateTime.Parse(ld);

                if (lastDate == DateTime.Today)
                {
                    continue;
                }
                else
                {
                    var date1 = DateTime.Now.ToString(@"MM\/dd\/yyyy H\:mm tt");
                    int bal = 20000;
                    using StreamWriter file = new(@"C:\Users\ryan9\OneDrive\Documents\CDI\CA-PRFND-C#\ClientSimulator3\Files\DailyBalances.txt", append: true);
                    file.Write(date1 + ",");
                    file.WriteLine(bal);
                    file.Close();

                }
                
            }


        }

        private void ExitBalance()
        {

            var date1 = DateTime.Now.ToString(@"MM\/dd\/yyyy H\:mm tt");
            int bal = 15555;
            using StreamWriter file = new(@"C:\Users\ryan9\OneDrive\Documents\CDI\CA-PRFND-C#\ClientSimulator3\Files\DailyBalances.txt", append: true);
            file.Write(date1 + ",");
            file.WriteLine(bal);


        }


        private void Del_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ExitBalance();
            Application.Exit();
        }


    }
}
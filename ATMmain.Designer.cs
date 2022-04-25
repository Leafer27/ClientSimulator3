namespace ClientSimulator3
{
    partial class ATMmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Point = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Chequing = new System.Windows.Forms.RadioButton();
            this.Savings = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Deposit = new System.Windows.Forms.RadioButton();
            this.Withdrawal = new System.Windows.Forms.RadioButton();
            this.Transfer = new System.Windows.Forms.RadioButton();
            this.PayBills = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(650, 359);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 55);
            this.Exit.TabIndex = 17;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(498, 359);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(112, 55);
            this.Enter.TabIndex = 16;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(9, 295);
            this.Amount.MaxLength = 4;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(258, 27);
            this.Amount.TabIndex = 13;
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Amount.TextChanged += new System.EventHandler(this.Amount_TextChanged);
            // 
            // Point
            // 
            this.Point.Location = new System.Drawing.Point(184, 224);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(83, 60);
            this.Point.TabIndex = 11;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(95, 224);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(83, 60);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(95, 158);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 60);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(6, 224);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(83, 60);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(184, 158);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 60);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 158);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 60);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(184, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 60);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(95, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chequing
            // 
            this.Chequing.AutoSize = true;
            this.Chequing.Checked = true;
            this.Chequing.Location = new System.Drawing.Point(82, 23);
            this.Chequing.Name = "Chequing";
            this.Chequing.Size = new System.Drawing.Size(93, 24);
            this.Chequing.TabIndex = 23;
            this.Chequing.TabStop = true;
            this.Chequing.Text = "Chequing\r\n";
            this.Chequing.UseVisualStyleBackColor = true;
            this.Chequing.CheckedChanged += new System.EventHandler(this.Chequing_CheckedChanged);
            // 
            // Savings
            // 
            this.Savings.AutoSize = true;
            this.Savings.Location = new System.Drawing.Point(82, 59);
            this.Savings.Name = "Savings";
            this.Savings.Size = new System.Drawing.Size(80, 24);
            this.Savings.TabIndex = 24;
            this.Savings.Text = "Savings";
            this.Savings.UseVisualStyleBackColor = true;
            this.Savings.CheckedChanged += new System.EventHandler(this.Savings_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Savings);
            this.groupBox1.Controls.Add(this.Chequing);
            this.groupBox1.Location = new System.Drawing.Point(448, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 97);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Account";
            // 
            // Deposit
            // 
            this.Deposit.AutoSize = true;
            this.Deposit.Checked = true;
            this.Deposit.Location = new System.Drawing.Point(101, 25);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(82, 24);
            this.Deposit.TabIndex = 18;
            this.Deposit.TabStop = true;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.CheckedChanged += new System.EventHandler(this.Deposit_CheckedChanged);
            // 
            // Withdrawal
            // 
            this.Withdrawal.AutoSize = true;
            this.Withdrawal.Location = new System.Drawing.Point(101, 58);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(106, 24);
            this.Withdrawal.TabIndex = 19;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.UseVisualStyleBackColor = true;
            this.Withdrawal.CheckedChanged += new System.EventHandler(this.Withdrawal_CheckedChanged);
            // 
            // Transfer
            // 
            this.Transfer.AutoSize = true;
            this.Transfer.Location = new System.Drawing.Point(101, 88);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(82, 24);
            this.Transfer.TabIndex = 20;
            this.Transfer.Text = "Transfer";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.CheckedChanged += new System.EventHandler(this.Transfer_CheckedChanged);
            // 
            // PayBills
            // 
            this.PayBills.AutoSize = true;
            this.PayBills.Location = new System.Drawing.Point(101, 118);
            this.PayBills.Name = "PayBills";
            this.PayBills.Size = new System.Drawing.Size(79, 24);
            this.PayBills.TabIndex = 21;
            this.PayBills.Text = "PayBills";
            this.PayBills.UseVisualStyleBackColor = true;
            this.PayBills.CheckedChanged += new System.EventHandler(this.PayBills_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Deposit);
            this.groupBox2.Controls.Add(this.PayBills);
            this.groupBox2.Controls.Add(this.Transfer);
            this.groupBox2.Controls.Add(this.Withdrawal);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(429, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 156);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Transaction";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Amount);
            this.groupBox3.Controls.Add(this.Point);
            this.groupBox3.Controls.Add(this.Clear);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button0);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Location = new System.Drawing.Point(122, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 328);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keypad";
            // 
            // ATMmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Enter);
            this.Name = "ATMmain";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Exit;
        private Button Enter;
        private TextBox Amount;
        private Button Point;
        private Button button0;
        private Button button8;
        private Button Clear;
        private Button button9;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private RadioButton Chequing;
        private RadioButton Savings;
        private GroupBox groupBox1;
        private RadioButton Deposit;
        private RadioButton Withdrawal;
        private RadioButton Transfer;
        private RadioButton PayBills;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
namespace ClientSimulator3
{
    partial class ATMmgr
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.mainScreen = new System.Windows.Forms.Button();
            this.printAccounts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OutOfService = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.RefillAtm = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.payInt = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.mgrInput = new System.Windows.Forms.TextBox();
            this.mgrScreen = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Controls.Add(this.mainScreen);
            this.groupBox3.Controls.Add(this.printAccounts);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.OutOfService);
            this.groupBox3.Controls.Add(this.Decimal);
            this.groupBox3.Controls.Add(this.RefillAtm);
            this.groupBox3.Controls.Add(this.Clear);
            this.groupBox3.Controls.Add(this.payInt);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button0);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 426);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keypad";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(184, 356);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(83, 60);
            this.button15.TabIndex = 35;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // mainScreen
            // 
            this.mainScreen.Location = new System.Drawing.Point(95, 356);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.Size = new System.Drawing.Size(83, 60);
            this.mainScreen.TabIndex = 34;
            this.mainScreen.Text = "Main Screen";
            this.mainScreen.UseVisualStyleBackColor = true;
            this.mainScreen.Click += new System.EventHandler(this.mainScreen_Click);
            // 
            // printAccounts
            // 
            this.printAccounts.Location = new System.Drawing.Point(6, 356);
            this.printAccounts.Name = "printAccounts";
            this.printAccounts.Size = new System.Drawing.Size(83, 60);
            this.printAccounts.TabIndex = 33;
            this.printAccounts.Text = "Print Accounts";
            this.printAccounts.UseVisualStyleBackColor = true;
            this.printAccounts.Click += new System.EventHandler(this.printAccounts_Click);
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
            // OutOfService
            // 
            this.OutOfService.Location = new System.Drawing.Point(184, 290);
            this.OutOfService.Name = "OutOfService";
            this.OutOfService.Size = new System.Drawing.Size(83, 60);
            this.OutOfService.TabIndex = 32;
            this.OutOfService.Text = "Out Of Service";
            this.OutOfService.UseVisualStyleBackColor = true;
            this.OutOfService.Click += new System.EventHandler(this.OutOfService_Click);
            // 
            // Decimal
            // 
            this.Decimal.Location = new System.Drawing.Point(184, 224);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(83, 60);
            this.Decimal.TabIndex = 11;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // RefillAtm
            // 
            this.RefillAtm.Location = new System.Drawing.Point(95, 290);
            this.RefillAtm.Name = "RefillAtm";
            this.RefillAtm.Size = new System.Drawing.Size(83, 60);
            this.RefillAtm.TabIndex = 31;
            this.RefillAtm.Text = "Refill ATM";
            this.RefillAtm.UseVisualStyleBackColor = true;
            this.RefillAtm.Click += new System.EventHandler(this.RefillAtm_Click);
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
            // payInt
            // 
            this.payInt.Location = new System.Drawing.Point(6, 290);
            this.payInt.Name = "payInt";
            this.payInt.Size = new System.Drawing.Size(83, 60);
            this.payInt.TabIndex = 30;
            this.payInt.Text = "Pay Interest";
            this.payInt.UseVisualStyleBackColor = true;
            this.payInt.Click += new System.EventHandler(this.payInt_Click);
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
            // mgrInput
            // 
            this.mgrInput.Location = new System.Drawing.Point(513, 68);
            this.mgrInput.MaxLength = 4;
            this.mgrInput.Name = "mgrInput";
            this.mgrInput.Size = new System.Drawing.Size(258, 27);
            this.mgrInput.TabIndex = 13;
            this.mgrInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mgrInput.TextChanged += new System.EventHandler(this.mgrInput_TextChanged);
            // 
            // mgrScreen
            // 
            this.mgrScreen.Location = new System.Drawing.Point(513, 111);
            this.mgrScreen.Name = "mgrScreen";
            this.mgrScreen.Size = new System.Drawing.Size(258, 242);
            this.mgrScreen.TabIndex = 29;
            this.mgrScreen.Tag = "";
            this.mgrScreen.Text = "";
            this.mgrScreen.TextChanged += new System.EventHandler(this.mgrScreen_TextChanged);
            // 
            // ATMmgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mgrScreen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.mgrInput);
            this.Name = "ATMmgr";
            this.Text = "Manager";
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox3;
        private Button button1;
        private TextBox mgrInput;
        private Button Decimal;
        private Button Clear;
        private Button button9;
        private Button button2;
        private Button button3;
        private Button button0;
        private Button button4;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
        private RichTextBox mgrScreen;
        private Button payInt;
        private Button RefillAtm;
        private Button OutOfService;
        private Button printAccounts;
        private Button button15;
        private Button mainScreen;
    }
}
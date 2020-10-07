using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public enum operators { Add, Sub, Multi, Div }



namespace calculator
{
    public partial class Form1 : Form
    {
        private Button NumButton1;
        private Label NumScreen;
        private Button Add;
        private Button NumBotton3;
        private Button NumBotton4;
        private Button NumBotton5;
        private Button NumBotton6;
        private Button NumBotton7;
        private Button NumBotton8;
        private Button NumBotton9;
        private Button NumBotton0;
        private Button button1;
        private Button button2;
        private Button Clear;
        private Button button4;
        private Button button5;
        private Button NumBotton2;

        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.NumButton1 = new System.Windows.Forms.Button();
            this.NumBotton2 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.NumBotton3 = new System.Windows.Forms.Button();
            this.NumBotton4 = new System.Windows.Forms.Button();
            this.NumBotton5 = new System.Windows.Forms.Button();
            this.NumBotton6 = new System.Windows.Forms.Button();
            this.NumBotton7 = new System.Windows.Forms.Button();
            this.NumBotton8 = new System.Windows.Forms.Button();
            this.NumBotton9 = new System.Windows.Forms.Button();
            this.NumBotton0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(27, 172);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(52, 47);
            this.NumButton1.TabIndex = 0;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumBotton2
            // 
            this.NumBotton2.Location = new System.Drawing.Point(88, 172);
            this.NumBotton2.Name = "NumBotton2";
            this.NumBotton2.Size = new System.Drawing.Size(54, 47);
            this.NumBotton2.TabIndex = 1;
            this.NumBotton2.Text = "2";
            this.NumBotton2.UseVisualStyleBackColor = true;
            this.NumBotton2.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NumScreen.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumScreen.Location = new System.Drawing.Point(27, 9);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(245, 50);
            this.NumScreen.TabIndex = 2;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(213, 74);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(50, 44);
            this.Add.TabIndex = 3;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // NumBotton3
            // 
            this.NumBotton3.Location = new System.Drawing.Point(148, 172);
            this.NumBotton3.Name = "NumBotton3";
            this.NumBotton3.Size = new System.Drawing.Size(50, 48);
            this.NumBotton3.TabIndex = 4;
            this.NumBotton3.Text = "3";
            this.NumBotton3.UseVisualStyleBackColor = true;
            this.NumBotton3.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumBotton4
            // 
            this.NumBotton4.Location = new System.Drawing.Point(27, 124);
            this.NumBotton4.Name = "NumBotton4";
            this.NumBotton4.Size = new System.Drawing.Size(52, 42);
            this.NumBotton4.TabIndex = 5;
            this.NumBotton4.Text = "4";
            this.NumBotton4.UseVisualStyleBackColor = true;
            this.NumBotton4.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumBotton5
            // 
            this.NumBotton5.Location = new System.Drawing.Point(88, 124);
            this.NumBotton5.Name = "NumBotton5";
            this.NumBotton5.Size = new System.Drawing.Size(50, 42);
            this.NumBotton5.TabIndex = 6;
            this.NumBotton5.Text = "5";
            this.NumBotton5.UseVisualStyleBackColor = true;
            this.NumBotton5.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumBotton6
            // 
            this.NumBotton6.Location = new System.Drawing.Point(146, 125);
            this.NumBotton6.Name = "NumBotton6";
            this.NumBotton6.Size = new System.Drawing.Size(52, 41);
            this.NumBotton6.TabIndex = 7;
            this.NumBotton6.Text = "6";
            this.NumBotton6.UseVisualStyleBackColor = true;
            this.NumBotton6.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumBotton7
            // 
            this.NumBotton7.Location = new System.Drawing.Point(27, 74);
            this.NumBotton7.Name = "NumBotton7";
            this.NumBotton7.Size = new System.Drawing.Size(53, 44);
            this.NumBotton7.TabIndex = 8;
            this.NumBotton7.Text = "7";
            this.NumBotton7.UseVisualStyleBackColor = true;
            this.NumBotton7.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumBotton8
            // 
            this.NumBotton8.Location = new System.Drawing.Point(88, 74);
            this.NumBotton8.Name = "NumBotton8";
            this.NumBotton8.Size = new System.Drawing.Size(52, 44);
            this.NumBotton8.TabIndex = 9;
            this.NumBotton8.Text = "8";
            this.NumBotton8.UseVisualStyleBackColor = true;
            this.NumBotton8.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumBotton9
            // 
            this.NumBotton9.Location = new System.Drawing.Point(146, 74);
            this.NumBotton9.Name = "NumBotton9";
            this.NumBotton9.Size = new System.Drawing.Size(52, 44);
            this.NumBotton9.TabIndex = 10;
            this.NumBotton9.Text = "9";
            this.NumBotton9.UseVisualStyleBackColor = true;
            this.NumBotton9.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumBotton0
            // 
            this.NumBotton0.Location = new System.Drawing.Point(87, 226);
            this.NumBotton0.Name = "NumBotton0";
            this.NumBotton0.Size = new System.Drawing.Size(55, 47);
            this.NumBotton0.TabIndex = 11;
            this.NumBotton0.Text = "0";
            this.NumBotton0.UseVisualStyleBackColor = true;
            this.NumBotton0.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Add_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(27, 227);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(53, 46);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(213, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 46);
            this.button4.TabIndex = 15;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Add_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(213, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 47);
            this.button5.TabIndex = 16;
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(332, 308);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumBotton0);
            this.Controls.Add(this.NumBotton9);
            this.Controls.Add(this.NumBotton8);
            this.Controls.Add(this.NumBotton7);
            this.Controls.Add(this.NumBotton6);
            this.Controls.Add(this.NumBotton5);
            this.Controls.Add(this.NumBotton4);
            this.Controls.Add(this.NumBotton3);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.NumBotton2);
            this.Controls.Add(this.NumButton1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        public float Result = 0; // 숫자 저장하는곳
        public bool isNewNum = true; 
        public operators opt = operators.Add;
        private void NumButton1_Click(object sender, EventArgs e)
        {

            Button numButton = (Button)sender; 
                Setnum(numButton.Text);
        }

        
        public void Setnum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else
            {
                if (NumScreen.Text == "0")
                {
                    NumScreen.Text = num;
                }
                else
                {
                    NumScreen.Text = NumScreen.Text + num;
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                float num = int.Parse(NumScreen.Text);
                if (opt == operators.Add)
                {
                    Result = sum(Result,num);
                }
                else if (opt == operators.Sub)
                {
                    Result = sub(Result,num);
                }
                else if(opt==operators.Multi)
                {
                    Result = multi(Result, num);
                }
                else if (opt == operators.Div)
                {
                    Result = division(Result,num);
                }
                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }
            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                opt = operators.Add;
            else if (optButton.Text == "-")
                opt = operators.Sub;
            else if (optButton.Text == "*")
                opt = operators.Multi;
            else if (optButton.Text == "/")
                opt = operators.Div;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            opt = operators.Add; // 기본값

            NumScreen.Text = "0";
        }
        public float sum(float number1, float number2)
        {
            float num = number1 + number2;
            return num;
        }
        public float sub(float number1, float number2)
        {
            float num = number1 - number2;
            return num;
        }
        public float multi(float number1, float number2)
        {
            float num = number1 * number2;
            return num;
        }
        public float division(float number1, float number2)
        {
            float num = number1 / number2;
            return num;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Calculator
{
    public partial class Program : Form
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox1;
        public int num1 = 1;
        public int num2 = 1;


        public Program()
        {
            InitializeComponent();
        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
            // Declare variables and then initialize to zero

            //    // Display title as the C# console calculator app
            //    // Display title as the C# console calculator app
            //    Console.WriteLine("Console Calculator in C#\r");
            //    Console.WriteLine("------------------------\n");

            //    // Ask the user to type the first number
            //    Console.WriteLine("Type a number, and then press Enter");
            //    this.num1 = Convert.ToInt32(Console.ReadLine());

            //    // Ask the user to type the second number
            //    Console.WriteLine("Type another number, and then press Enter");
            //    this.num2 = Convert.ToInt32(Console.ReadLine());

            //    // Ask the user to choose an option
            //    Console.WriteLine("Choose an option from the following list:");
            //    Console.WriteLine("\ta - Add");
            //    Console.WriteLine("\ts - Subtract");
            //    Console.WriteLine("\tm - Multiply");
            //    Console.WriteLine("\td - Divide");
            //    Console.Write("Your option? ");

            //    // Use a switch statement to do the math
            //    switch (Console.ReadLine())
            //    {
            //        case "a":
            //            Console.WriteLine($"Your result: {this.num1} + {this.num2} = " + (this.num1 + this.num2));
            //            break;
            //        case "s":
            //            Console.WriteLine($"Your result: {this.num1} - {this.num2} = " + (this.num1 - this.num2));
            //            break;
            //        case "m":
            //            Console.WriteLine($"Your result: {this.num1} * {this.num2} = " + (this.num1 * this.num2));
            //            break;
            //        case "d":
            //            Console.WriteLine($"Your result: {this.num1} / {this.num2} = " + (this.num1 / this.num2));
            //            break;
            //    }
            //    // Wait for the user to respond before closing
            //    Console.Write("Press any key to close the Calculator console app...");
            //    Console.ReadKey();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 114);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(219, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 114);
            this.button2.TabIndex = 2;
            this.button2.Text = "Subtract";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(65, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 114);
            this.button3.TabIndex = 6;
            this.button3.Text = "Multiply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(219, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 114);
            this.button4.TabIndex = 7;
            this.button4.Text = "Devide";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Num1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Num2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 26);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 218);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 26);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(428, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Program_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void ADD_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("you clicked Me", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        // add
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You have clicked the add buttom.", "add Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (String.IsNullOrEmpty(textBox1.Text))
            //{
            //   this.num1 = Convert.ToInt32(textBox1.Text);
            //}
            //else
            //{
            //    this.num1 = 1;  // default is 1
            //}

            int sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }

        // subtract
        private void button2_Click(object sender, EventArgs e)
        {
            int sum = num1 - num2;
            textBox3.Text = sum.ToString();
        }

        // multiply
        private void button3_Click(object sender, EventArgs e)
        {
            int sum = num1 * num2;
            textBox3.Text = sum.ToString();
        }

        // divide
        private void button4_Click(object sender, EventArgs e)
        {
            int sum = num1 / num2;
            textBox3.Text = sum.ToString();
        }

        // this.num1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                this.num1 = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                this.num1 = 1;  // default is 1
            }

            //this.num1 = Convert.ToInt32(textBox1.Text); ;
        }

        // this.num2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                this.num2 = Convert.ToInt32(textBox2.Text);
            }
            else
            {
                this.num2 = 1;  // default is 1
            }

            //this.num2 = Convert.ToInt32(textBox2.Text); 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Program_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Please insert the first number.");
        }
    }
}
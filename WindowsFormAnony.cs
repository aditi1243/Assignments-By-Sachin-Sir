using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm__Del
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Hello world!!");
            Button b = new Button();//Reference to the byutton
            b.Text = "Click Me!";//Text implemted as "clik me" on the button appearence
            b.Size = new Size(100, 50);//size mentained for button
            b.Location = new Point(250, 200);//point located on the button created
            this.Controls.Add(b);//contolling mechanism of button shoould go the center

            //Show Message
            b.Click += new EventHandler(button1_Click1);
            b.Click += new EventHandler(button2_Click2);
            b.Click += new EventHandler(button3_Click3);
            b.Click += new EventHandler(button4_Click4);
            b.Click += new EventHandler(button5_Click5);
            b.Click += new EventHandler(button6_Click6);



        }

        //////Method creation

        private void button1_Click1(object sender1, EventArgs e1)
        {
            MessageBox.Show("Hello World");

        }

        private void button2_Click2(object sender1, EventArgs e1)
        {
            MessageBox.Show("Programming is fun");

        }
        private void button3_Click3(object sender1, EventArgs e1)
        {
            MessageBox.Show("This is printing");

        }
        private void button4_Click4(object sender1, EventArgs e1)
        {
            MessageBox.Show("This is printing again");

        }
        private void button5_Click5(object sender1, EventArgs e1)
        {
            MessageBox.Show("Yey! This is Crazy");

        }
        private void button6_Click6(object sender1, EventArgs e1)
        {
            MessageBox.Show("Yey! This is printing again");

        }


        //Delegate with Anonymous method.

         ////b.Click += delegate (object sender1, EventArgs e1)
         // // {
         //       MessageBox.Show("Hello World");

         //   };

         // b.Click += delegate (object sender2, EventArgs e2)
         //   {
         //       MessageBox.Show("Programming is fun");

         //   };

         //   b.Click += delegate (object sender3, EventArgs e3)
         //   {
         //       MessageBox.Show("This is printing ");

         //   };

         //   b.Click += delegate (object sender4, EventArgs e4)
         //   {
         //       MessageBox.Show("This is printing again");

         //   };

         //    b.Click += delegate (object sender5, EventArgs e5)
         //   {
         //       MessageBox.Show("Yey! This is Crazy");

         //   };

         //    b.Click += delegate (object sender6, EventArgs e6)
         //   {
         //       MessageBox.Show("Yeyy! This is printing crazy");

         //   };


}
    }









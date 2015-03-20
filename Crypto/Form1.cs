using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alphaSlicer(alpha1.Text);
        }

        private async void alphaSlicer(string alpha1)
        {
            string[] numbers = alpha1.Replace(" ", "").Split(',');

            int topPosition = 40;
            int leftPosition = 10;
            int count = 1;
            int postCount = 51;

            foreach (string myString in numbers)
            {
                Label label = new Label();
                label.Name = "label_" + myString;
                if (myString.Length == 1)
                {
                    label.Text = "00" + myString;
                }
                else if (myString.Length == 2)
                {
                    label.Text = "0" + myString;
                }
                //else if (myString.Length == 3)
                //{
                //    label.Text = "0" + myString;
                //}
                else
                {
                    label.Text = myString;
                }

                label.AutoSize = true;

                label.Top = topPosition;
                label.Left = leftPosition;
                leftPosition += 23;

                this.Controls.Add(label);

                TextBox textbox = new TextBox();
                textbox.Name = "textbox_" + myString;
                textbox.Top = topPosition - 20;
                textbox.Left = leftPosition - 18;
                textbox.Width = 14;

                this.Controls.Add(textbox);

                if (count == postCount)
                {
                    topPosition += 45;
                    leftPosition = 10;
                    postCount = postCount + 51;
                }


                count++;

                await Task.Delay(1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

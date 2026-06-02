using System;
using System.Windows.Forms;

namespace Triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates user input to ensure it is a valid integer and within the acceptable spatial boundaries.
        /// </summary>
        private bool TryGetValidInput(out int numAsterisks)
        {
            // Prevents application crash if the user enters letters or symbols
            if (!int.TryParse(textBox1.Text, out numAsterisks))
            {
                label6.Text = "Invalid input. Please enter a numerical value.";
                return false;
            }

            // Enforces the form boundary limit
            if (numAsterisks > 15)
            {
                label6.Text = "The number entered is not correct. Enter a number less than or equal to 15.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Resets the canvas UI state by clearing error messages and previous pattern renders.
        /// </summary>
        private void ResetCanvas()
        {
            label6.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TryGetValidInput(out int numAsterisks)) return;
            ResetCanvas();

            // Pattern A: Standard Right Triangle
            for (int row = 1; row <= numAsterisks; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    label2.Text += "*";
                }
                label2.Text += "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!TryGetValidInput(out int numAsterisks)) return;
            ResetCanvas();

            // Pattern B: Inverted Right Triangle
            for (int row = numAsterisks; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    label3.Text += "*";
                }
                label3.Text += "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!TryGetValidInput(out int numAsterisks)) return;
            ResetCanvas();

            // Pattern C: Right-Aligned Inverted Triangle
            for (int row = 1; row <= numAsterisks; row++)
            {
                for (int col = 1; col < row; col++)
                {
                    label4.Text += " ";
                }
                for (int col = 1; col <= numAsterisks - row + 1; col++)
                {
                    label4.Text += "*";
                }
                label4.Text += "\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!TryGetValidInput(out int numAsterisks)) return;
            ResetCanvas();

            // Pattern D: Right-Aligned Standard Triangle
            for (int row = 1; row <= numAsterisks; row++)
            {
                for (int col = row; col < numAsterisks; col++)
                {
                    label5.Text += " ";
                }
                for (int col = 1; col <= row; col++)
                {
                    label5.Text += "*";
                }
                label5.Text += "\n";
            }
        }
    }
}

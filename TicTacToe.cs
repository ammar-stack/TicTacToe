using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTaeToe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
                if (radioButton1.Checked == true)
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton1.Checked = true;
                }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==  true)
            {
                button1.Text = "0";
            }
            else
            {
                button1.Text = "X";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button2.Text = "0";
            }
            else
            {
                button2.Text = "X";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button3.Text = "0";
            }
            else
            {
                button3.Text = "X";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button4.Text = "0";
            }
            else
            {
                button4.Text = "X";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button5.Text = "0";
            }
            else
            {
                button5.Text = "X";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button6.Text = "0";
            }
            else
            {
                button6.Text = "X";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button7.Text = "0";
            }
            else
            {
                button7.Text = "X";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button8.Text = "0";
            }
            else
            {
                button8.Text = "X";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button9.Text = "0";
            }
            else
            {
                button9.Text = "X";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button1.Text == "0" && button2.Text=="0" && button3.Text == "0")
            {
                MessageBox.Show("Player 1 won");
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Player 2 won");
            }
            if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                MessageBox.Show("Player 1 won");
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Player 2 won");
            }
            if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                MessageBox.Show("Player 1 won");
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player 2 won");
            }
            if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                MessageBox.Show("Player 1 won");
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player 2 won");
            }
            if (button2.Text == "0" && button5.Text == "0" && button8.Text == "0")
            {
                MessageBox.Show("Player 1 won");
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Player 2 won");
            }
            if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                MessageBox.Show("Player 1 won");
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player 2 won");
            }
            if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                MessageBox.Show("Player 1 won");
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player 2 won");
            }
            if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                MessageBox.Show("Player 1 won");
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player 2 won");
            }
        }
    }
}

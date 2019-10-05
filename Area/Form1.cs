//Student: Monique Sullivan 
//Instructor: Dr. Jerry Mamo 
//Class: CIST 2341 – C# Programming – 60485 – Summer 2019 
//Lab #6
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "What do you want to calculate?";
            lbl_Input_top.Visible = false;
            txt_Input_top.Visible = false;
            lbl_Input_bottom.Visible = false;
            txt_Input_bottom.Visible = false;
            lblArea.Visible = false;
            txtArea.Visible = false;
        }

        //Function to Clear all selections
        public void Clear()
        {
            txtArea.ResetText();
            txt_Input_top.ResetText();
            txt_Input_bottom.ResetText();
            rdoCirc.Checked = false;
            rdoSqr.Checked = false;
            rdoRect.Checked = false;
        }

        //Function to Exit the program
        public void Exit()
        {
            String exitmsg = "Are you sure you want to Exit?";
            String exittitle = "Exit Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(exitmsg, exittitle, buttons, icon);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Function to calculate the Area of a Circle
        public void Circle(double radius)
        {
            double circleArea = (3.14159) * radius * radius;
            lblArea.Visible = true;
            txtArea.Text = circleArea.ToString("0.##");
            txtArea.Visible = true;
        }

        //Function to calculate the Area of a Square
        public void Square(double side)
        {
            double squareArea = side * side;
            lblArea.Visible = true;
            txtArea.Text = squareArea.ToString();
            txtArea.Visible = true;
        }

        //Function to calculate the Area of a Rectangle
        public void Rectangle(double lenght, double width)
        {
            double rectangleArea = width * lenght;
            lblArea.Visible = true;
            txtArea.Text = rectangleArea.ToString();
            txtArea.Visible = true;
        }

        //Show the appropriate Title and display the labels to be used
        private void CircRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Calculating the Area of a Circle";
            lbl_Input_top.Text = "Radius";
            lbl_Input_top.Visible = true;
            txt_Input_top.Visible = true;
            lbl_Input_bottom.Visible = false;
            txt_Input_bottom.Visible = false;
            lblArea.Visible = false;
            txtArea.Visible = false;
        }

        private void SqrRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Calculating the Area of a Square";
            lbl_Input_top.Text = "Side";
            lbl_Input_top.Visible = true;
            txt_Input_top.Visible = true;
            lbl_Input_bottom.Visible = false;
            txt_Input_bottom.Visible = false;
            lblArea.Visible = false;
            txtArea.Visible = false;
        }

        private void RectRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Calculating the Area of a Rectangle";
            lbl_Input_top.Text = "Height";
            lbl_Input_top.Visible = true;
            txt_Input_top.Visible = true;
            lbl_Input_bottom.Text = "Width";
            lbl_Input_bottom.Visible = true;
            txt_Input_bottom.Visible = true;
            lblArea.Visible = false;
            txtArea.Visible = false;
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            //Show a MessageBox asking user to enter a value on TextBox, when empty.
            if (txt_Input_top.Text == string.Empty && txt_Input_bottom.Text == string.Empty)
            {
                MessageBox.Show("Please, enter a value to calculate Area");
                return;
            }
           
            //Calculate the area of a circle when user clicks "Calc Area" and display on Area TextBox
            if (rdoCirc.Checked)
                {
                    Circle(double.Parse(txt_Input_top.Text));
                }
                //Calculate the area of a square when user clicks "Calc Area" and display on Area TextBox
                else if (rdoSqr.Checked)
                {
                    Square(double.Parse(txt_Input_top.Text));
                }
                //Calculate the area of a rectangle when user clicks "Calc Area" and display on Area TextBox
                else if (rdoRect.Checked)
                {
                    Rectangle(double.Parse(txt_Input_top.Text), double.Parse(txt_Input_bottom.Text));
                }
            
        }

        //Ask the user to confirm they want to close the program
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Exit();
        }

        //Clear all textboxes when user clicks clear button
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Clear all textboxes when user clicks clear on menu and uncheck all Radio Buttons
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Ask the user to confirm they want to close the program, if "yes", then close.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        //Select geometric figure Circle Radio Button when click on Menu Choice
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdoCirc.Checked = true;
        }

        //Select geometric figure Square Radio Button when click on Menu Choice
        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdoSqr.Checked = true;
        }

        //Select geometric figure Rectangle Radio Button when click on Menu Choice
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdoRect.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, EventArgs e)
        {

        }

        //Select the correct RadioButton for shape selected from ComboBox
        private void shapesCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String shape = cbShapes.SelectedItem.ToString();
            if (shape == "Circle")
            {
                rdoCirc.Checked = true;
            }
            else if (shape == "Square")
            {
                rdoSqr.Checked = true;
            }
            else if (shape == "Rectangle")
            {
                rdoRect.Checked = true;
            }
        }

        //Select the correct RadioButton for shape selected from ListBox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String shape = lstShapes.SelectedItem.ToString();
            if (shape == "Circle")
            {
                rdoCirc.Checked = true;
            }
            else if (shape == "Square")
            {
                rdoSqr.Checked = true;
            }
            else if (shape == "Rectangle")
            {
                rdoRect.Checked = true;
            }
        }

        //Restrict users to input Caracters on TextBoxes
        private void txt_Input_top_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
        private void txt_Input_bottom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }
    }
}

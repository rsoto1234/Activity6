using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (textBoxSeconds.Text == "")
            {
                MessageBox.Show("Please Enter Value.");
            }
            else
            {
                //Adding Exceintption Handling
                try
                {
                    int seconds = Convert.ToInt32(textBoxSeconds.Text);
                    if (seconds >= 86400)
                    {
                        int days = seconds / 86400;
                        //Formatting to three decimal places
                        textBoxResult.Text = String.Format("{0:0.000}", days) + " days";
                    }
                    else if (seconds >= 3600)
                    {
                        int hours = seconds / 3600;
                        //Formatting to three decimal places
                        textBoxResult.Text = String.Format("{0:0.000}", hours) + " hours";
                    }
                    else if (seconds >= 60)
                    {
                        int minutes = seconds / 60;
                        //Formatting to three decimal places
                        textBoxResult.Text = String.Format("{0:0.000}", minutes) + " minutes";
                    }
                    else
                    {
                        //Formatting to three decimal places
                        textBoxResult.Text = String.Format("{0:0.000}", seconds) + " seconds";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
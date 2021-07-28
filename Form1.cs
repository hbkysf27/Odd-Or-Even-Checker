using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppEx4Lect8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)
        {

            try
            {
                if (oddoreven() == 0)
                {
                    MessageBox.Show(txtinput.Text+" is a Even Number ");
                }
                else if(oddoreven()==1)
                {
                    MessageBox.Show(txtinput.Text+" is a odd Number");
                }            
            }
            catch
            {
                
                    {
                    MessageBox.Show("invalid number");
                }

            }
    
        }
        public int oddoreven()
        {
            int number;
            number = int.Parse(txtinput.Text);
            if(number%2==0)
            {
                return 0;

            }
            else
            {
                return 1;
            }

        }
    }
}

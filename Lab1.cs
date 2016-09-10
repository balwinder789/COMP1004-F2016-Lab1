using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lab1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

       
      
        private void ClickMeButton_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("HIII");
        }
        private void ExitButton_Click(object sender, EventArgs e)
         { 
             Application.Exit(); 
      }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello woRLD!");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("good bye!");
        }
    }
}

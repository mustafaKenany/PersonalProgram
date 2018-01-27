using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class boxMoney : Form
    {
        public boxMoney()
        {
            InitializeComponent ();
        }

        private void labelEXT_Click(object sender , EventArgs e)
        {
            this.Close ();
        }

        private void labelEXT_MouseEnter(object sender , EventArgs e)
        {
            labelEXT.ForeColor = Color.FromArgb ( 255 , 255 , 255 );
           
        }

        private void labelEXT_MouseLeave(object sender , EventArgs e)
        {
            labelEXT.ForeColor = Color.FromArgb ( 70 , 70 , 70 );
        }

        private void button_AllMoney_Click(object sender , EventArgs e)
        {
            if ( radioButtonAllMoney.Checked )
            {
                MessageBox.Show ( "True" );
            }
            else
            {
                MessageBox.Show ( "false" );
            }
        }

        private void radioButtonMoneyForUser_CheckedChanged(object sender , EventArgs e)
        {
            if ( radioButtonMoneyForUser.Checked )
            {
                comboBoxUserName.Enabled = true;
            }
            else
            {
                comboBoxUserName.Enabled = false;
            }
        }
    }
}

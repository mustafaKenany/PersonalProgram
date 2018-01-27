using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class ChoosePaid : Form
    {
        public ChoosePaid()
        {
            InitializeComponent ();
            if ( BasicClass.PaidOrGet==true )
            {
                labelTitleForm.Text = "نوع المدفوعات/سندات االصرف";
            }
            else
            {
                labelTitleForm.Text = "نوع المقبوضات/سندات القبض";
            }
        }

        private void labelEXT_Click(object sender , EventArgs e)
        {
            this.Close ();
        }

        private void labelEXT_MouseEnter(object sender , EventArgs e)
        {
            labelEXT.ForeColor = Color.FromArgb ( 70 , 70 , 70 );
        }

        private void labelEXT_MouseLeave(object sender , EventArgs e)
        {
            labelEXT.ForeColor = Color.FromArgb ( 255 , 255 , 255 );
        }

        private void buttonUSMoney_Click(object sender , EventArgs e)
        {
            BasicClass.USorIQ = true;
            var form = new PaidGetMoney ();
            form.ShowDialog ();
            this.Close ();
        }

        private void buttonIQMoney_Click(object sender , EventArgs e)
        {
            var form = new PaidGetMoney ();
            form.ShowDialog ();
            this.Close ();
        }
    }
}

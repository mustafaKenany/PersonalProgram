﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class ControlingForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport ( "User32.dll" )]
        public static extern bool ReleaseCapture();

        [DllImport ( "User32.dll" )]
        public static extern int SendMessage(IntPtr hWnd , int Msg , int wParam , int lParam);
        public ControlingForm()
        {
            InitializeComponent ();
        }



        private void btn_CasherForm_Click(object sender , EventArgs e)
        {

            var form = new View.CacherForm ();
            form.ShowDialog ();

        }

        private void btn_SettingForm_Click(object sender , EventArgs e)
        {

            var form = new View.SettingsForm ();
            form.ShowDialog ();
        }

        private void btn_PurshaceForm_Click(object sender , EventArgs e)
        {
            var form = new View.PurshaceForm ();
            form.ShowDialog ();

        }



        private void button_for_prices_Click(object sender , EventArgs e)
        {
            prices_form form = new prices_form ();
            form.ShowDialog ();
        }



        private void btn_ReportingForm_Click(object sender , EventArgs e)
        {

            var form = new ReportingMiniForm ();
            form.ShowDialog ();
        }

        private void buttonSavePurshaceInvoice_Click(object sender , EventArgs e)
        {
            var form = new View.SavedInvoicesForm ();
            form.LoadSaveInvoices ( "شراء" );
            form.ShowDialog ();
        }

        private void buttonSaveSaleInvoice_Click(object sender , EventArgs e)
        {
            var form = new View.SavedInvoicesForm ();
            form.LoadSaveInvoices ( "بيع" );
            form.ShowDialog ();
        }

        private void label6_Click(object sender , EventArgs e)
        {
            Application.Exit ();
        }

        private void btn_SettingForm_MouseEnter(object sender , EventArgs e)
        {
            btn_SettingForm.ForeColor = Color.FromArgb ( 70 , 70 , 70 );
        }

        private void btn_SettingForm_MouseLeave(object sender , EventArgs e)
        {
            btn_SettingForm.ForeColor = Color.FromArgb ( 255 , 255 , 255 );
        }

        private void labelFormTitle_MouseMove(object sender , MouseEventArgs e)
        {
            if ( e.Button == MouseButtons.Left )
            {
                ReleaseCapture ();
                SendMessage ( Handle , WM_NCLBUTTONDOWN , HTCAPTION , 0 );
            }
        }

        private void labelaboutCompany_MouseEnter(object sender , EventArgs e)
        {
            labelaboutCompany.ForeColor = Color.FromArgb ( 70 , 70 , 70 );
        }

        private void labelaboutCompany_MouseLeave(object sender , EventArgs e)
        {
            labelaboutCompany.ForeColor = Color.FromArgb ( 255 , 255 , 255 );
        }

        private void labelExit_Click(object sender , EventArgs e)
        {
            Application.Exit ();
        }

        private void labelExit_MouseEnter(object sender , EventArgs e)
        {
            labelExit.ForeColor = Color.FromArgb ( 70 , 70 , 70 );
        }

        private void labelExit_MouseLeave(object sender , EventArgs e)
        {
            labelExit.ForeColor = Color.FromArgb ( 255 , 255 , 255 );
        }

        private void buttonboxMoney_Click(object sender , EventArgs e)
        {
            var form = new boxMoney ();
            form.ShowDialog ();
        }

        private void buttonPaidMoney_Click(object sender , EventArgs e)
        {
            BasicClass.PaidOrGet = true;
            var form = new ChoosePaid ();
            form.ShowDialog ();
           
        }

        private void buttonGetMoney_Click(object sender , EventArgs e)
        {
            var form = new ChoosePaid ();
            form.ShowDialog ();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Rresturant
{
    public partial class PaidGetMoney : Form
    {

        public PaidGetMoney()
        {
            InitializeComponent ();


            dataGridViewMoney.Columns["ColumnTotal"].DefaultCellStyle.Format = "N2";
            dataGridViewMoney.Columns["ColumnMoneyAmount"].DefaultCellStyle.Format = "N2";
            dataGridViewMoney.Columns["ColumnTansferPercentage"].DefaultCellStyle.Format = "N2";
            initializeFunction ();
            if ( dataGridViewMoney.Rows.Count < 0 )
            {
                buttonDeleteallTransaction.Enabled = false;
                buttonModifeTransaction.Enabled = false;
            }

            buttonAddTransaction.Enabled = false;

            buttondeleteTransaction.Enabled = false;
            buttonSaveTransaction.Enabled = false;
            check_button_visability ();

        }

        private void check_button_visability()
        {
            List<Button> lstBtnCalc = new List<Button>
            {
                buttonNewTransaction,buttonModifeTransaction,buttonDeleteallTransaction,
                buttonSaveTransaction,buttonAddTransaction,buttondeleteTransaction
            };

            foreach ( var item in lstBtnCalc )
            {
                if ( item.Enabled )
                {
                    item.BackColor = Color.FromName ( "ActiveCaption" );
                }
                else
                {
                    item.BackColor = Color.FromName ( "white" );
                }
            }

        }

        private void initializeFunction()
        {
            labelUserName.Text = BasicClass.UserName;
            var date = dateTimePickerTransaction.Value.Date.ToString ( "yyyy-MM-dd" );
            if ( BasicClass.PaidOrGet )
            {
                if ( BasicClass.USorIQ )
                {
                    labelTitleForm.Text = "المدفوعات بالدولار/سندات الدفع بالدولار";
                    getAllTransaction ( "مدفوعات دولار" , date );
                }
                else
                {
                    labelTitleForm.Text = "المدفوعات بالدينار/سندات الدفع بالدينار";
                    getAllTransaction ( "مدفوعات دينار" , date );
                }
            }
            else
            {
                if ( BasicClass.USorIQ )
                {
                    labelTitleForm.Text = "المقبوضات بالدولار/سندات القبض بالدولار";
                    getAllTransaction ( "مقبوضات دولار" , date );
                }
                else
                {
                    labelTitleForm.Text = "المقبوضات بالدينار/سندات القبض بالدينار";
                    getAllTransaction ( "مقبوضات دينار" , date );
                }

            }
        }

        private void get_TransactionID()
        {
            var dt = new DataTable ();
            var UsedClass = new BasicClass ();
            dt = UsedClass.selectdata ( "Casher_select_all_IDs" , null );
            if ( dt.Rows.Count > 0 )
            {
                dataGridViewMoney.Rows[dataGridViewMoney.Rows.Count - 1].Cells["ColumnTransactionID"].Value = Convert.ToInt64 ( dt.Rows[0]["TransactionID"].ToString () );
                dataGridViewMoney.Rows[dataGridViewMoney.Rows.Count - 1].Cells["ColumnTransactionID"].Selected = true;
            }
            UsedClass.ExecuteCommand ( "Casher_IncreaseTrnasactionID" , null );
        }

        private void labelEXT_Click(object sender , EventArgs e)
        {
            this.Close ();
            BasicClass.PaidOrGet = false;
            BasicClass.USorIQ = false;
        }

        private void labelEXT_MouseEnter(object sender , EventArgs e)
        {
            labelEXT.ForeColor = Color.FromArgb ( 70 , 70 , 70 );
        }

        private void labelEXT_MouseLeave(object sender , EventArgs e)
        {
            labelEXT.ForeColor = Color.FromArgb ( 255 , 255 , 255 );
        }

        private void buttonNewTransaction_Click(object sender , EventArgs e)
        {

            dateTimePickerTransaction.Enabled = false;
            buttonNewTransaction.Enabled = false;
            buttonModifeTransaction.Enabled = false;
            buttonDeleteallTransaction.Enabled = false;
            buttonAddTransaction.Enabled = true;

            buttondeleteTransaction.Enabled = true;
            buttonSaveTransaction.Enabled = true;
            
            int idx = dataGridViewMoney.Rows.Add ();
            dataGridViewMoney.ReadOnly = false;
            DataGridViewRow row = dataGridViewMoney.Rows[idx];
            get_TransactionID ();
            check_button_visability ();

        }

        private void buttonModifeTransaction_Click(object sender , EventArgs e)
        {
            dataGridViewMoney.ReadOnly = false;
            buttonNewTransaction.Enabled = true;
            buttonAddTransaction.Enabled = true;
            buttondeleteTransaction.Enabled = true;
            buttonSaveTransaction.Enabled = true;
            check_button_visability ();
        }

        private void buttonAddTransaction_Click(object sender , EventArgs e)
        {

            if ( Check_if_cell_Empty () )
            {
                if ( dataGridViewMoney.Rows.Count > 0 )
                {
                    int idx = dataGridViewMoney.Rows.Add ();
                    DataGridViewRow row = dataGridViewMoney.Rows[idx];
                    dataGridViewMoney.CurrentCell = dataGridViewMoney[dataGridViewMoney.CurrentCell.ColumnIndex , dataGridViewMoney.CurrentCell.RowIndex + 1];
                    dataGridViewMoney.Focus ();
                    dataGridViewMoney.Enabled = true;
                    get_TransactionID ();
                }
            }
            else
            {
                MessageBox.Show ( "يجب ملئ معلومات السطر السابق قبل البدء بجديد" , "MESSAGE" );
            }
        }

        private void buttonSaveTransaction_Click(object sender , EventArgs e)
        {
            for ( int i = 0 ; i <= dataGridViewMoney.Rows.Count ; i++ )
            {
                deleteEmptyRows ();
            }
            deleteEmptyRows ();
            //dataGridViewMoney.Enabled = false;
            if ( Check_if_cell_Empty () )
            {
                delete_Transaction ();
                save_Transaction ();
                buttonNewTransaction.Enabled = true;
                dateTimePickerTransaction.Enabled = true;
                buttonDeleteallTransaction.Enabled = true;
                buttonModifeTransaction.Enabled = true;
                buttonAddTransaction.Enabled = false;
                buttondeleteTransaction.Enabled = false;
                dataGridViewMoney.Rows[dataGridViewMoney.CurrentCell.RowIndex].Selected = false;
                check_button_visability ();
                dataGridViewMoney.Rows.Clear ();
                initializeFunction ();
            }
            else
            {
                MessageBox.Show ( "يجب اكمال معلومات السطر" , "MESSAGE" );
            }
        }

        private void delete_Transaction()
        {
            SqlParameter[] param = new SqlParameter[2];
            var UsedClass = new BasicClass ();
            param[0] = new SqlParameter ( "@ID" , SqlDbType.BigInt );
            param[1] = new SqlParameter ( "@date" , SqlDbType.Date );
            param[1].Value = dateTimePickerTransaction.Value.Date.ToString ( "yyyy-MM-dd" );
            for ( int i = 0 ; i < dataGridViewMoney.Rows.Count ; i++ )
            {
                param[0].Value = Int64.Parse ( dataGridViewMoney.Rows[i].Cells["ColumnTransactionID"].Value.ToString () );
                UsedClass.ExecuteCommand ( "Casher_DeleteTransaction" , param );
            }
        }

        private void dataGridViewMoney_KeyPress(object sender , KeyPressEventArgs e)
        {

            if ( dataGridViewMoney.Rows.Count > 0 )
            {

                if ( e.KeyChar == (char) 13 )
                {
                    int cellColumnIndex = dataGridViewMoney.CurrentCell.ColumnIndex;


                    if ( cellColumnIndex < dataGridViewMoney.Columns.Count - 1 )
                    {
                        dataGridViewMoney.CurrentCell = dataGridViewMoney[cellColumnIndex + 1 , dataGridViewMoney.CurrentCell.RowIndex];
                    }
                    else
                    {
                        buttonAddTransaction_Click ( sender , e );
                        dataGridViewMoney.CurrentCell = dataGridViewMoney[0 , dataGridViewMoney.CurrentCell.RowIndex];

                    }



                }
            }
        }

        private void dataGridViewMoney_CellValueChanged(object sender , DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex >= 0 )
            {

                switch ( dataGridViewMoney.Columns[e.ColumnIndex].Name )
                {
                    case "ColumnmoneyType":
                        if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnmoneyType"].Value.ToString () == "دولار" )
                        {
                            if ( BasicClass.USorIQ )
                            {
                                dataGridViewMoney.Columns["ColumnTansferPercentage"].ReadOnly = true;
                                dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value = 1;
                                if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value != null )
                                {
                                    dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTotal"].Value = dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value;
                                }
                            }
                            else
                            {
                                dataGridViewMoney.Columns["ColumnTansferPercentage"].ReadOnly = false;
                                if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value != null && dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value != null )
                                {
                                    var Money = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value.ToString () );
                                    var TransferRate = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value.ToString () );
                                    var TotalPaid = Money * TransferRate;
                                    dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTotal"].Value = TotalPaid;
                                }
                            }
                        }
                        else
                        {
                            if ( BasicClass.USorIQ )
                            {
                                dataGridViewMoney.Columns["ColumnTansferPercentage"].ReadOnly = false;
                                if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value != null && dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value != null )
                                {
                                    var Money = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value.ToString () );
                                    var TransferRate = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value.ToString () );
                                    var TotalPaid = Money / TransferRate;
                                    dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTotal"].Value = TotalPaid;
                                }
                            }
                            else
                            {
                                dataGridViewMoney.Columns["ColumnTansferPercentage"].ReadOnly = true;
                                dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value = 1;
                                if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value != null )
                                {
                                    dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTotal"].Value = dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value;
                                }
                            }

                        }
                        break;

                    case "ColumnMoneyAmount":
                        dataGridViewMoney.Columns["ColumnMoneyAmount"].DefaultCellStyle.Format = "N2";
                        if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnmoneyType"].Value == null )
                        {
                            dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnmoneyType"].Selected = true;
                            MessageBox.Show ( "يجب تحديد نوع العملة" , "MESSAGE" );
                        }
                        else
                        {
                            if ( BasicClass.USorIQ )
                            {
                                //دولار
                                if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnmoneyType"].Value.ToString () == "دولار" )
                                {
                                    dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTotal"].Value = dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value;
                                }
                                else
                                {
                                    if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value != null && dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value != null )
                                    {
                                        var Money = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value.ToString () );
                                        var TransferRate = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value.ToString () );
                                        var TotalPaid = Money / TransferRate;
                                        dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTotal"].Value = TotalPaid;

                                    }
                                }
                            }
                            else
                            {
                                //دينار
                                if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnmoneyType"].Value.ToString () == "دينار" )
                                {
                                    dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTotal"].Value = dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value;
                                }
                                else
                                {
                                    if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value != null && dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value != null )
                                    {
                                        var Money = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value.ToString () );
                                        var TransferRate = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value.ToString () );
                                        var TotalPaid = Money * TransferRate;
                                        dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTotal"].Value = TotalPaid;

                                    }
                                }

                            }
                        }

                        break;

                    case "ColumnTansferPercentage":
                        if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value == null )
                        {
                            dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Selected = true;
                            //MessageBox.Show ( "يجب ادخال المبلغ" , "MESSAGE" );
                        }
                        else
                        {
                            if ( BasicClass.USorIQ )
                            {
                                if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnmoneyType"].Value.ToString () == "دينار" )
                                {
                                    var Money = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value.ToString () );
                                    var TransferRate = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value.ToString () );
                                    var TotalPaid = Money / TransferRate;
                                    dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTotal"].Value = TotalPaid;
                                }
                            }
                            else
                            {
                                if ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnmoneyType"].Value.ToString () == "دولار" )
                                {
                                    var Money = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnMoneyAmount"].Value.ToString () );
                                    var TransferRate = Convert.ToDecimal ( dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTansferPercentage"].Value.ToString () );
                                    var TotalPaid = Money * TransferRate;
                                    dataGridViewMoney.Rows[e.RowIndex].Cells["ColumnTotal"].Value = TotalPaid;
                                }
                            }
                        }
                        break;
                    default:
                        break;

                }
            }

        }

        private void dateTimePickerTransaction_KeyPress(object sender , KeyPressEventArgs e)
        {
            if ( e.KeyChar == (char) 13 )
            {
                dataGridViewMoney.Rows.Clear ();
                initializeFunction ();
                if ( Check_if_Data_Found () )
                {
                    buttonModifeTransaction.Enabled = true;
                }
                else
                {

                }

            }
        }

        private void dataGridViewMoney_SelectionChanged(object sender , EventArgs e)
        {
            if ( dataGridViewMoney.Rows.Count>0 )
            {
                if ( dataGridViewMoney.CurrentCell.RowIndex>=0 )
                {

                }
            }
        }

        private void buttonDeleteallTransaction_Click(object sender , EventArgs e)
        {
            if ( dataGridViewMoney.Rows.Count > 0 )
            {
                DialogResult deleteMSG = MessageBox.Show ( "سيتم حذف كل الحركات بهذا التاريخ" , "MESSAGE" , MessageBoxButtons.OKCancel );
                if ( deleteMSG == DialogResult.OK )
                {
                    delete_Transaction ();
                    MessageBox.Show ( "DONE" , "MESSAGE" );
                    buttonModifeTransaction.Enabled = false;
                    var date = dateTimePickerTransaction.Value.Date.ToString ( "yyyy-MM-dd" );
                    initializeFunction ();
                    dataGridViewMoney.Rows.Clear ();
                }
            }
            else
            {
                //deleteEmptyRows ();
            }
            check_button_visability ();
        }

        private void getAllTransaction(string TransactionType , string TransactionDate)
        {
            var dt = new DataTable ();
            var UsedClass = new BasicClass ();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter ( "@TransactionType" , SqlDbType.NVarChar , 150 );
            param[1] = new SqlParameter ( "@TransactionDate" , SqlDbType.NVarChar , 100 );
            param[0].Value = TransactionType;
            param[1].Value = TransactionDate;
            dt = UsedClass.selectdata ( "Casher_SelectTransaction" , param );
            if ( dt.Rows.Count > 0 )
            {
                for ( int i = 0 ; i < dt.Rows.Count ; i++ )
                {
                    var ID = dt.Rows[i]["TransactionID"].ToString ();
                    var currencyType = dt.Rows[i]["CurrecncyType"].ToString ();
                    var payment = Convert.ToDecimal ( dt.Rows[i]["Payment"].ToString () );
                    var RateTransfer = Convert.ToDecimal ( dt.Rows[i]["TransferPercentage"].ToString () );
                    var Total = Convert.ToDecimal ( dt.Rows[i]["PaymentTotal"].ToString () );
                    var Customer = dt.Rows[i]["CutomerPaid"].ToString ();
                    var Details = dt.Rows[i]["TransactionDetails"].ToString ();
                    dataGridViewMoney.Rows.Add ( ID , currencyType , payment , RateTransfer , Total , Customer , Details );

                }
                dataGridViewMoney.ReadOnly = true;
                
            }
        }

        private bool Check_if_cell_Empty()
        {
            if ( dataGridViewMoney.Rows.Count > 0 )
            {
                for ( int i = 0 ; i < dataGridViewMoney.Rows.Count ; i++ )
                {
                    for ( int j = 1 ; j < dataGridViewMoney.Columns.Count ; j++ )
                    {
                        if ( dataGridViewMoney.Rows[i].Cells[j].Value == null )
                        {
                            dataGridViewMoney.Rows[i].Selected = true;
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void deleteEmptyRows()
        {
            for ( int i = 0 ; i < dataGridViewMoney.Rows.Count ; i++ )
            {
                if ( dataGridViewMoney.Rows[i].Cells["ColumnTransactionID"].Value == null )
                {
                    if ( dataGridViewMoney.Rows[i].Cells["ColumnMoneyAmount"].Value == null )
                    {
                        if ( dataGridViewMoney.Rows[i].Cells["ColumnmoneyType"].Value == null )
                        {
                            if ( dataGridViewMoney.Rows[i].Cells["ColumnTansferPercentage"].Value == null )
                            {
                                if ( dataGridViewMoney.Rows[i].Cells["ColumnCutomerName"].Value == null )
                                {
                                    dataGridViewMoney.Rows.RemoveAt ( i );
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool Check_if_Data_Found()
        {
            if ( dataGridViewMoney.Rows.Count > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void save_Transaction()
        {
            SqlParameter[] param = new SqlParameter[10];
            var UsedClass = new BasicClass ();
            param[0] = new SqlParameter ( "@TransactionID" , SqlDbType.BigInt );
            param[1] = new SqlParameter ( "@TransactionType" , SqlDbType.NVarChar , 100 );
            param[2] = new SqlParameter ( "@currencyType" , SqlDbType.NVarChar , 100 );
            param[3] = new SqlParameter ( "@Payment" , SqlDbType.Money );
            param[4] = new SqlParameter ( "@paymentTotal" , SqlDbType.Money );
            param[5] = new SqlParameter ( "@TransferRate" , SqlDbType.Money );
            param[6] = new SqlParameter ( "@Customer" , SqlDbType.NVarChar , 150 );
            param[7] = new SqlParameter ( "@Details" , SqlDbType.Text );
            param[8] = new SqlParameter ( "@Date" , SqlDbType.Date );
            param[9] = new SqlParameter ( "@EnteredUser" , SqlDbType.NVarChar , 150 );
            for ( int rowindex = 0 ; rowindex < dataGridViewMoney.Rows.Count ; rowindex++ )
            {
                param[0].Value = Convert.ToInt64 ( dataGridViewMoney.Rows[rowindex].Cells["ColumnTransactionID"].Value.ToString () );
                if ( BasicClass.PaidOrGet )
                {
                    if ( BasicClass.USorIQ )
                    {
                        param[1].Value = "مدفوعات دولار";
                    }
                    else
                    {
                        param[1].Value = "مدفوعات دينار";
                    }

                }
                else
                {
                    if ( BasicClass.USorIQ )
                    {
                        param[1].Value = "مقبوضات دولار";
                    }
                    else
                    {
                        param[1].Value = "مقبوضات دينار";
                    }
                }
                param[2].Value = dataGridViewMoney.Rows[rowindex].Cells["ColumnmoneyType"].Value.ToString ();
                param[3].Value = dataGridViewMoney.Rows[rowindex].Cells["ColumnMoneyAmount"].Value;
                param[4].Value = dataGridViewMoney.Rows[rowindex].Cells["ColumnTotal"].Value;
                param[5].Value = dataGridViewMoney.Rows[rowindex].Cells["ColumnTansferPercentage"].Value.ToString ();
                param[6].Value = dataGridViewMoney.Rows[rowindex].Cells["ColumnCutomerName"].Value.ToString ();
                param[7].Value = dataGridViewMoney.Rows[rowindex].Cells["ColumnNotes"].Value.ToString ();
                param[8].Value = dateTimePickerTransaction.Value.Date;
                param[9].Value = "Mustafa";
                UsedClass.ExecuteCommand ( "Casher_InsertNewTransaction" , param );
            }


            MessageBox.Show ( "DONE" , "MESSAGE" );
        }

        private void dataGridViewMoney_EditingControlShowing(object sender , DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler ( AlphabetwithDigits );
        }

        private void AlphabetwithDigits(object sender , KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char) Keys.Back && !char.IsSeparator ( e.KeyChar ) && !char.IsLetter ( e.KeyChar ) && !char.IsDigit ( e.KeyChar );
        }

        private void buttondeleteTransaction_Click(object sender , EventArgs e)
        {
            if ( dataGridViewMoney.CurrentCell.RowIndex >= 0 )
            {
                var UsedClass = new BasicClass ();
                if ( Check_if_cell_Empty () )
                {
                    DialogResult deleteMSG = MessageBox.Show ( "سيتم حذف هذه الحركة" , "MESSAGE" , MessageBoxButtons.OKCancel );
                    SqlParameter[] param = new SqlParameter[2];
                    param[0] = new SqlParameter ( "@ID" , SqlDbType.BigInt );
                    param[1] = new SqlParameter ( "@date" , SqlDbType.Date );
                    var date = dateTimePickerTransaction.Value.Date.ToString ( "yyyy-MM-dd" );
                    param[0].Value = dataGridViewMoney.Rows[dataGridViewMoney.CurrentCell.RowIndex].Cells["ColumnTransactionID"].Value;
                    param[1].Value = date;
                    UsedClass.ExecuteCommand ( "Casher_DeleteTransaction" , param );
                    //MessageBox.Show ( "DONE" , "MESSAGE" );
                    dataGridViewMoney.Rows.Clear ();
                    initializeFunction ();
                    dataGridViewMoney.Enabled = true;
                }
                else
                {
                    dataGridViewMoney.Rows.RemoveAt ( dataGridViewMoney.CurrentCell.RowIndex );
                }
            }
            else
            {
                MessageBox.Show ( "يجب تحديد السطر الذي تريد حذفه" , "MESSAGE" );
            }
        }
    }
}

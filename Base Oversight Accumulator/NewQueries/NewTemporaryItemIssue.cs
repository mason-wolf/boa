﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_Oversight_Accumulator
{
    public partial class NewTemporaryItemIssue : Form
    {
        public string IssuedBy { get; set; }
        public NewTemporaryItemIssue()
        {
            InitializeComponent();
        }

        private void IssueButton_Click(object sender, EventArgs e)
        {

            string IssuedTo = IssuedToField.Text;
            string FromAccount = FromAccountField.Text;
            string DSN = DutyPhoneField.Text;
            string DateOfIssue = DateOfIssueField.Value.ToString();
            string DateOfReturn = DateOfReturnField.Value.ToString();
            string items = ItemsField.Text;
            string Notes = NotesField.Text;
            string Returned = "NO";

            dbconnect mysql = new dbconnect();

                string query = "INSERT INTO issued (issuedto, issuedby, account, dsn, dateofissue, dateofreturn, items, notes, returned) VALUES ('" + IssuedTo + "','" +
                IssuedBy + "','" + FromAccount + "','" + DSN + "','"+ DateOfIssue + "','" + DateOfReturn + "','" + items + "','" + Notes + "','" + Returned + "')";

            string TransferLog = "INSERT INTO log (date, who, action) VALUES('" + DateTime.Now.ToString() + "','" + IssuedBy + "','TEMPORARILY ISSUED ITEMS TO " + IssuedTo + "')";
            mysql.InsertQuery(query);
            mysql.InsertQuery(TransferLog);
            this.Close();
            

        }

        private void TemporaryItemIssue_Load(object sender, EventArgs e)
        {

        }
    }
}

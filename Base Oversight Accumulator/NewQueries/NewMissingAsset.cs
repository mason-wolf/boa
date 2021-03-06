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
    public partial class NewMissingAsset : Form
    {
        public string UserCreatingROS { get; set; }
        public bool ROSItemSelected { get; set; }
        public string ItemDescription { get; set; }
        public string ItemSerialNumber { get; set; }
        public string ItemValue { get; set; }
        public string ItemAccount { get; set; }

        public NewMissingAsset()
        {
            InitializeComponent();
        }

        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            string doc = DocNumberField.Text;
            string poc = POCField.Text;
            string serialnumber = SerialNumberField.Text;
            string value = ValueField.Text;
            string account = AccountField.Text;
            string surveyofficer = SurveyOfficerField.Text;
            string remarks = RemarksField.Text;

            dbconnect mysql = new dbconnect();
            mysql.InsertQuery("INSERT into ros (doc, poc, serialnumber, value, account, surveyofficer, remarks, date) VALUES('" +
                doc.ToUpper() + "','" + poc.ToUpper() + "','" + serialnumber.ToUpper() + "','" + value.ToUpper() + "','" + account.ToUpper() + "','" + surveyofficer.ToUpper() + "','" + remarks.ToUpper() + "','" + DateTime.Now.ToString() + "')");
            MessageBox.Show("Report of Survey created for: " + account);

            mysql.InsertQuery("INSERT INTO log (date, who, action, account) VALUES('" + DateTime.Now.ToString() + "','" + UserCreatingROS +
                "','INITIATED ROS ON ACCOUNT " + account.ToUpper() + " FOR ITEM " + serialnumber + "','" + account.ToUpper() + "')");

            this.Close();
        }

        private void ROSWindow_Load(object sender, EventArgs e)
        {

            if (ROSItemSelected == true)
            {
                SerialNumberField.Text = ItemSerialNumber;
                ValueField.Text = ItemValue;
                AccountField.Text = ItemAccount;

            }
        }
    }
}

﻿namespace Base_Oversight_Accumulator
{
    partial class AccountDetailView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccountDetailsBox = new System.Windows.Forms.GroupBox();
            this.TotalAssetsLabel = new System.Windows.Forms.Label();
            this.TotalAssetsField = new System.Windows.Forms.TextBox();
            this.TotalValueLabel = new System.Windows.Forms.Label();
            this.TotalValueField = new System.Windows.Forms.TextBox();
            this.AccountAssets = new System.Windows.Forms.ListBox();
            this.EquipmentCustodianLabel = new System.Windows.Forms.Label();
            this.ECField = new System.Windows.Forms.TextBox();
            this.AccountDRMO = new System.Windows.Forms.ListBox();
            this.AccountROS = new System.Windows.Forms.ListBox();
            this.AccountActionLog = new System.Windows.Forms.ListBox();
            this.AccountActionsBox = new System.Windows.Forms.GroupBox();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.FreezeAccountButton = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.NoteBox = new System.Windows.Forms.GroupBox();
            this.AccountNotesField = new System.Windows.Forms.RichTextBox();
            this.AccountAssetsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumDRMOItems = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NumROSItems = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountNumberField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OrganizationField = new System.Windows.Forms.TextBox();
            this.AccountDetailsBox.SuspendLayout();
            this.AccountActionsBox.SuspendLayout();
            this.NoteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountDetailsBox
            // 
            this.AccountDetailsBox.Controls.Add(this.OrganizationField);
            this.AccountDetailsBox.Controls.Add(this.label7);
            this.AccountDetailsBox.Controls.Add(this.AccountNumberField);
            this.AccountDetailsBox.Controls.Add(this.label6);
            this.AccountDetailsBox.Controls.Add(this.NumROSItems);
            this.AccountDetailsBox.Controls.Add(this.label5);
            this.AccountDetailsBox.Controls.Add(this.NumDRMOItems);
            this.AccountDetailsBox.Controls.Add(this.label4);
            this.AccountDetailsBox.Controls.Add(this.ECField);
            this.AccountDetailsBox.Controls.Add(this.EquipmentCustodianLabel);
            this.AccountDetailsBox.Controls.Add(this.TotalValueField);
            this.AccountDetailsBox.Controls.Add(this.TotalValueLabel);
            this.AccountDetailsBox.Controls.Add(this.TotalAssetsField);
            this.AccountDetailsBox.Controls.Add(this.TotalAssetsLabel);
            this.AccountDetailsBox.Location = new System.Drawing.Point(40, 36);
            this.AccountDetailsBox.Name = "AccountDetailsBox";
            this.AccountDetailsBox.Size = new System.Drawing.Size(907, 860);
            this.AccountDetailsBox.TabIndex = 0;
            this.AccountDetailsBox.TabStop = false;
            this.AccountDetailsBox.Text = "Account Details";
            // 
            // TotalAssetsLabel
            // 
            this.TotalAssetsLabel.AutoSize = true;
            this.TotalAssetsLabel.Location = new System.Drawing.Point(160, 111);
            this.TotalAssetsLabel.Name = "TotalAssetsLabel";
            this.TotalAssetsLabel.Size = new System.Drawing.Size(179, 32);
            this.TotalAssetsLabel.TabIndex = 0;
            this.TotalAssetsLabel.Text = "Total Assets:";
            // 
            // TotalAssetsField
            // 
            this.TotalAssetsField.BackColor = System.Drawing.SystemColors.Control;
            this.TotalAssetsField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalAssetsField.Location = new System.Drawing.Point(379, 111);
            this.TotalAssetsField.Name = "TotalAssetsField";
            this.TotalAssetsField.ReadOnly = true;
            this.TotalAssetsField.Size = new System.Drawing.Size(400, 31);
            this.TotalAssetsField.TabIndex = 1;
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.AutoSize = true;
            this.TotalValueLabel.Location = new System.Drawing.Point(23, 204);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.Size = new System.Drawing.Size(317, 32);
            this.TotalValueLabel.TabIndex = 2;
            this.TotalValueLabel.Text = "Total Value (estimated):";
            // 
            // TotalValueField
            // 
            this.TotalValueField.BackColor = System.Drawing.SystemColors.Control;
            this.TotalValueField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalValueField.Location = new System.Drawing.Point(379, 204);
            this.TotalValueField.Name = "TotalValueField";
            this.TotalValueField.ReadOnly = true;
            this.TotalValueField.Size = new System.Drawing.Size(400, 31);
            this.TotalValueField.TabIndex = 3;
            // 
            // AccountAssets
            // 
            this.AccountAssets.FormattingEnabled = true;
            this.AccountAssets.ItemHeight = 31;
            this.AccountAssets.Location = new System.Drawing.Point(40, 990);
            this.AccountAssets.Name = "AccountAssets";
            this.AccountAssets.Size = new System.Drawing.Size(700, 779);
            this.AccountAssets.TabIndex = 1;
            // 
            // EquipmentCustodianLabel
            // 
            this.EquipmentCustodianLabel.AutoSize = true;
            this.EquipmentCustodianLabel.Location = new System.Drawing.Point(43, 295);
            this.EquipmentCustodianLabel.Name = "EquipmentCustodianLabel";
            this.EquipmentCustodianLabel.Size = new System.Drawing.Size(296, 32);
            this.EquipmentCustodianLabel.TabIndex = 4;
            this.EquipmentCustodianLabel.Text = "Equipment Custodian:";
            // 
            // ECField
            // 
            this.ECField.BackColor = System.Drawing.SystemColors.Control;
            this.ECField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ECField.Location = new System.Drawing.Point(379, 296);
            this.ECField.Name = "ECField";
            this.ECField.ReadOnly = true;
            this.ECField.Size = new System.Drawing.Size(400, 31);
            this.ECField.TabIndex = 5;
            // 
            // AccountDRMO
            // 
            this.AccountDRMO.FormattingEnabled = true;
            this.AccountDRMO.ItemHeight = 31;
            this.AccountDRMO.Location = new System.Drawing.Point(789, 990);
            this.AccountDRMO.Name = "AccountDRMO";
            this.AccountDRMO.Size = new System.Drawing.Size(700, 779);
            this.AccountDRMO.TabIndex = 2;
            // 
            // AccountROS
            // 
            this.AccountROS.FormattingEnabled = true;
            this.AccountROS.ItemHeight = 31;
            this.AccountROS.Location = new System.Drawing.Point(1537, 990);
            this.AccountROS.Name = "AccountROS";
            this.AccountROS.Size = new System.Drawing.Size(700, 779);
            this.AccountROS.TabIndex = 3;
            this.AccountROS.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AccountActionLog
            // 
            this.AccountActionLog.FormattingEnabled = true;
            this.AccountActionLog.ItemHeight = 31;
            this.AccountActionLog.Location = new System.Drawing.Point(2294, 990);
            this.AccountActionLog.Name = "AccountActionLog";
            this.AccountActionLog.Size = new System.Drawing.Size(700, 779);
            this.AccountActionLog.TabIndex = 4;
            // 
            // AccountActionsBox
            // 
            this.AccountActionsBox.Controls.Add(this.DeleteAccountButton);
            this.AccountActionsBox.Controls.Add(this.FreezeAccountButton);
            this.AccountActionsBox.Controls.Add(this.AddNoteButton);
            this.AccountActionsBox.Controls.Add(this.GenerateReportButton);
            this.AccountActionsBox.Location = new System.Drawing.Point(1023, 36);
            this.AccountActionsBox.Name = "AccountActionsBox";
            this.AccountActionsBox.Size = new System.Drawing.Size(903, 849);
            this.AccountActionsBox.TabIndex = 5;
            this.AccountActionsBox.TabStop = false;
            this.AccountActionsBox.Text = "Account Actions";
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(113, 94);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(698, 93);
            this.GenerateReportButton.TabIndex = 0;
            this.GenerateReportButton.Text = "Generate Report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Location = new System.Drawing.Point(113, 281);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(698, 93);
            this.AddNoteButton.TabIndex = 1;
            this.AddNoteButton.Text = "Add Note";
            this.AddNoteButton.UseVisualStyleBackColor = true;
            // 
            // FreezeAccountButton
            // 
            this.FreezeAccountButton.Location = new System.Drawing.Point(113, 463);
            this.FreezeAccountButton.Name = "FreezeAccountButton";
            this.FreezeAccountButton.Size = new System.Drawing.Size(698, 93);
            this.FreezeAccountButton.TabIndex = 6;
            this.FreezeAccountButton.Text = "Freeze";
            this.FreezeAccountButton.UseVisualStyleBackColor = true;
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(113, 657);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(698, 93);
            this.DeleteAccountButton.TabIndex = 7;
            this.DeleteAccountButton.Text = "Delete";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            // 
            // NoteBox
            // 
            this.NoteBox.Controls.Add(this.AccountNotesField);
            this.NoteBox.Location = new System.Drawing.Point(2017, 36);
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(993, 849);
            this.NoteBox.TabIndex = 6;
            this.NoteBox.TabStop = false;
            this.NoteBox.Text = "Notes";
            // 
            // AccountNotesField
            // 
            this.AccountNotesField.Location = new System.Drawing.Point(26, 38);
            this.AccountNotesField.Name = "AccountNotesField";
            this.AccountNotesField.Size = new System.Drawing.Size(943, 789);
            this.AccountNotesField.TabIndex = 0;
            this.AccountNotesField.Text = "";
            // 
            // AccountAssetsLabel
            // 
            this.AccountAssetsLabel.AutoSize = true;
            this.AccountAssetsLabel.Location = new System.Drawing.Point(34, 930);
            this.AccountAssetsLabel.Name = "AccountAssetsLabel";
            this.AccountAssetsLabel.Size = new System.Drawing.Size(108, 32);
            this.AccountAssetsLabel.TabIndex = 7;
            this.AccountAssetsLabel.Text = "Assets:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 930);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "DRMO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1537, 930);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "ROS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2294, 930);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Action Log:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of DRMO Items:";
            // 
            // NumDRMOItems
            // 
            this.NumDRMOItems.BackColor = System.Drawing.SystemColors.Control;
            this.NumDRMOItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumDRMOItems.Location = new System.Drawing.Point(379, 382);
            this.NumDRMOItems.Name = "NumDRMOItems";
            this.NumDRMOItems.ReadOnly = true;
            this.NumDRMOItems.Size = new System.Drawing.Size(400, 31);
            this.NumDRMOItems.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of ROS Items:";
            // 
            // NumROSItems
            // 
            this.NumROSItems.BackColor = System.Drawing.SystemColors.Control;
            this.NumROSItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumROSItems.Location = new System.Drawing.Point(379, 464);
            this.NumROSItems.Name = "NumROSItems";
            this.NumROSItems.ReadOnly = true;
            this.NumROSItems.Size = new System.Drawing.Size(400, 31);
            this.NumROSItems.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Acct#:";
            // 
            // AccountNumberField
            // 
            this.AccountNumberField.BackColor = System.Drawing.SystemColors.Control;
            this.AccountNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountNumberField.Location = new System.Drawing.Point(379, 547);
            this.AccountNumberField.Name = "AccountNumberField";
            this.AccountNumberField.ReadOnly = true;
            this.AccountNumberField.Size = new System.Drawing.Size(400, 31);
            this.AccountNumberField.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 627);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Organization:";
            // 
            // OrganizationField
            // 
            this.OrganizationField.BackColor = System.Drawing.SystemColors.Control;
            this.OrganizationField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrganizationField.Location = new System.Drawing.Point(379, 627);
            this.OrganizationField.Name = "OrganizationField";
            this.OrganizationField.ReadOnly = true;
            this.OrganizationField.Size = new System.Drawing.Size(400, 31);
            this.OrganizationField.TabIndex = 13;
            // 
            // AccountDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(3286, 1822);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountAssetsLabel);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.AccountActionsBox);
            this.Controls.Add(this.AccountActionLog);
            this.Controls.Add(this.AccountROS);
            this.Controls.Add(this.AccountDRMO);
            this.Controls.Add(this.AccountAssets);
            this.Controls.Add(this.AccountDetailsBox);
            this.Name = "AccountDetailView";
            this.Text = "Account Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccountDetailView_Load);
            this.AccountDetailsBox.ResumeLayout(false);
            this.AccountDetailsBox.PerformLayout();
            this.AccountActionsBox.ResumeLayout(false);
            this.NoteBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AccountDetailsBox;
        private System.Windows.Forms.TextBox TotalValueField;
        private System.Windows.Forms.Label TotalValueLabel;
        private System.Windows.Forms.TextBox TotalAssetsField;
        private System.Windows.Forms.Label TotalAssetsLabel;
        private System.Windows.Forms.ListBox AccountAssets;
        private System.Windows.Forms.TextBox ECField;
        private System.Windows.Forms.Label EquipmentCustodianLabel;
        private System.Windows.Forms.ListBox AccountDRMO;
        private System.Windows.Forms.ListBox AccountROS;
        private System.Windows.Forms.ListBox AccountActionLog;
        private System.Windows.Forms.GroupBox AccountActionsBox;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.Button FreezeAccountButton;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.GroupBox NoteBox;
        private System.Windows.Forms.RichTextBox AccountNotesField;
        private System.Windows.Forms.Label AccountAssetsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumROSItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumDRMOItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrganizationField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AccountNumberField;
        private System.Windows.Forms.Label label6;
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CarConfig
{
    partial class MainWindow : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        ///		Required method for Designer support - do not modify
        ///		the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboSalesPerson = new System.Windows.Forms.ComboBox();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioPink = new System.Windows.Forms.RadioButton();
            this.radioYellow = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.infoLabel = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.checkedBoxRadioOptions = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.carMakeList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkFloorMats = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calendarTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboSalesPerson
            // 
            this.comboSalesPerson.FormattingEnabled = true;
            this.comboSalesPerson.Items.AddRange(new object[] {
            "Baby Ry-Ry",
            "Dan \'the Machine\'",
            "Cowboy Dan",
            "Tom \'the Style\' "});
            this.comboSalesPerson.Location = new System.Drawing.Point(16, 81);
            this.comboSalesPerson.Name = "comboSalesPerson";
            this.comboSalesPerson.Size = new System.Drawing.Size(128, 21);
            this.comboSalesPerson.TabIndex = 1;
            // 
            // radioRed
            // 
            this.radioRed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioRed.Location = new System.Drawing.Point(264, 24);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(64, 23);
            this.radioRed.TabIndex = 2;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = false;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioPink);
            this.groupBoxColor.Controls.Add(this.radioYellow);
            this.groupBoxColor.Controls.Add(this.radioRed);
            this.groupBoxColor.Controls.Add(this.radioGreen);
            this.groupBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxColor.Location = new System.Drawing.Point(16, 121);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(435, 56);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Exterior Color";
            this.groupBoxColor.Enter += new System.EventHandler(this.groupBoxColor_Enter);
            this.groupBoxColor.Leave += new System.EventHandler(this.groupBoxColor_Leave);
            // 
            // radioPink
            // 
            this.radioPink.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioPink.Location = new System.Drawing.Point(176, 24);
            this.radioPink.Name = "radioPink";
            this.radioPink.Size = new System.Drawing.Size(56, 23);
            this.radioPink.TabIndex = 3;
            this.radioPink.Text = "Pink";
            this.radioPink.UseVisualStyleBackColor = false;
            // 
            // radioYellow
            // 
            this.radioYellow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioYellow.Location = new System.Drawing.Point(96, 24);
            this.radioYellow.Name = "radioYellow";
            this.radioYellow.Size = new System.Drawing.Size(56, 23);
            this.radioYellow.TabIndex = 1;
            this.radioYellow.Text = "Yellow";
            this.radioYellow.UseVisualStyleBackColor = false;
            // 
            // radioGreen
            // 
            this.radioGreen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.radioGreen.Location = new System.Drawing.Point(16, 24);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(64, 23);
            this.radioGreen.TabIndex = 0;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = false;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.OldLace;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 8F);
            this.infoLabel.Location = new System.Drawing.Point(16, 234);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(224, 200);
            this.infoLabel.TabIndex = 5;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(273, 234);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.Size = new System.Drawing.Size(178, 155);
            this.monthCalendar.TabIndex = 10;
            // 
            // checkedBoxRadioOptions
            // 
            this.checkedBoxRadioOptions.CheckOnClick = true;
            this.checkedBoxRadioOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedBoxRadioOptions.FormattingEnabled = true;
            this.checkedBoxRadioOptions.Items.AddRange(new object[] {
            "Front Speakers",
            "8-Track Tape Player",
            "CD Player",
            "Cassette Player",
            "Rear Speakers",
            "Ultra Base Thumper"});
            this.checkedBoxRadioOptions.Location = new System.Drawing.Point(165, 47);
            this.checkedBoxRadioOptions.Name = "checkedBoxRadioOptions";
            this.checkedBoxRadioOptions.Size = new System.Drawing.Size(157, 55);
            this.checkedBoxRadioOptions.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(271, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Delivery Date:";
            // 
            // carMakeList
            // 
            this.carMakeList.FormattingEnabled = true;
            this.carMakeList.Items.AddRange(new object[] {
            "BMW",
            "Caravan",
            "Ford",
            "Grand Am",
            "Jeep",
            "Jetta",
            "Saab",
            "Viper",
            "Yugo"});
            this.carMakeList.Location = new System.Drawing.Point(339, 47);
            this.carMakeList.Name = "carMakeList";
            this.carMakeList.ScrollAlwaysVisible = true;
            this.carMakeList.Size = new System.Drawing.Size(112, 56);
            this.carMakeList.Sorted = true;
            this.carMakeList.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order Stats:";
            // 
            // checkFloorMats
            // 
            this.checkFloorMats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkFloorMats.Location = new System.Drawing.Point(16, 16);
            this.checkFloorMats.Name = "checkFloorMats";
            this.checkFloorMats.Size = new System.Drawing.Size(112, 24);
            this.checkFloorMats.TabIndex = 0;
            this.checkFloorMats.Text = "Extra Floor Mats";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(339, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Make:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(273, 412);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(120, 22);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Confirm Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sales Person";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(163, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Radio Options:";
            // 
            // calendarTip
            // 
            this.calendarTip.IsBalloon = true;
            this.calendarTip.ShowAlways = true;
            this.calendarTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(469, 458);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSalesPerson);
            this.Controls.Add(this.carMakeList);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.checkedBoxRadioOptions);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.checkFloorMats);
            this.Controls.Add(this.groupBoxColor);
            this.Name = "MainWindow";
            this.Text = "Buy a New Car!";
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion


        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.MonthCalendar monthCalendar;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox comboSalesPerson;
        protected System.Windows.Forms.ListBox carMakeList;
        protected System.Windows.Forms.Label infoLabel;
        protected System.Windows.Forms.CheckedListBox checkedBoxRadioOptions;
        protected System.Windows.Forms.Button btnOrder;
        protected System.Windows.Forms.CheckBox checkFloorMats;
        protected System.Windows.Forms.RadioButton radioPink;
        protected System.Windows.Forms.RadioButton radioYellow;
        protected System.Windows.Forms.RadioButton radioRed;
        protected System.Windows.Forms.RadioButton radioGreen;
        protected System.Windows.Forms.GroupBox groupBoxColor;
        private ToolTip calendarTip;
    }
}

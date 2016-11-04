using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CarConfig
{
	public partial class MainWindow : System.Windows.Forms.Form
	{
		public MainWindow()
		{
			InitializeComponent();
			CenterToScreen();
		}

		private void btnOrder_Click (object sender, System.EventArgs e)
		{
			// Build a string to display information.
			string orderInfo = "";

			if(comboSalesPerson.Text != "")
				orderInfo += "Sales Person: " + comboSalesPerson.Text + "\n";
			else
				orderInfo += "You did not select a sales person!" + "\n";

			if(carMakeList.SelectedItem != null)
				orderInfo += "Make: " + carMakeList.SelectedItem + "\n";

			if(checkFloorMats.Checked)
				orderInfo += "You want floor mats.\n";	

			if(radioRed.Checked)
				orderInfo += "You want a red exterior.\n";
			
			if(radioYellow.Checked)
				orderInfo += "You want a yellow exterior.\n";
			
			if(radioGreen.Checked)
				orderInfo += "You want a green exterior.\n";

			if(radioPink.Checked)
				orderInfo += "Why do you want a PINK exterior?\n";
			
			orderInfo += "--------------------------------\n";
			
			// For each item in the CheckedListBox...
			for(int i = 0; i < checkedBoxRadioOptions.Items.Count; i++)
			{
				// Is the current item checked?
				if(checkedBoxRadioOptions.GetItemChecked(i))
				{
					// Get text of current item.
					orderInfo += "Radio Item: ";
					orderInfo += checkedBoxRadioOptions.Items[i];
					orderInfo += "\n";
				}								
			}
			orderInfo += "--------------------------------\n";

			// Get ship date.
			DateTime startD = monthCalendar.SelectionStart;
			DateTime endD = monthCalendar.SelectionEnd;
			
			// Get correct string representation.
			//
			string dateStartStr = startD.Date.ToShortDateString();
			string dateEndStr = endD.Date.ToShortDateString();
			
			if(dateStartStr != dateEndStr)
			{
				orderInfo += "Car will be sent between\n" 
					+ dateStartStr + " and\n" + dateEndStr;			
			}
			else // they picked a single date.
				orderInfo += "Car will be sent on\n" 
					+ dateStartStr;

			// Set order info.
			infoLabel.Text = orderInfo;
		}

        private void groupBoxColor_Leave(object sender, System.EventArgs e)
		{
			groupBoxColor.Text = "Exterior Color: Thanks for visiting the group...";
		}

        private void groupBoxColor_Enter(object sender, System.EventArgs e)
		{
			groupBoxColor.Text = "Exterior Color: You are in the group...";
		}
	}
}

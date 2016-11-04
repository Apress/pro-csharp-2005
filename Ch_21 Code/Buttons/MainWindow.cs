using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Buttons
{
    partial class MainForm : System.Windows.Forms.Form
	{
		// Hold the current text alignment
		ContentAlignment currAlignment = ContentAlignment.MiddleCenter;
		int currEnumPos = 0;
    
		public MainForm()
		{
			InitializeComponent();
			CenterToScreen();
		}

		protected void btnStandard_Click (object sender, System.EventArgs e)
		{			
			// Get all possible values
			// of the ContentAlignment enum.
			Array values = Enum.GetValues(currAlignment.GetType());
		
			// Bump the current position in the enum.
			// & check for wrap around.
			currEnumPos++;
			if(currEnumPos >= values.Length)
				currEnumPos = 0;
			
			// Bump the current enum value.
			currAlignment = (ContentAlignment)Enum.Parse(currAlignment.GetType(), 
							values.GetValue(currEnumPos).ToString());
			btnStandard.TextAlign = currAlignment;

			// Paint enum value name on button.
			btnStandard.Text = currAlignment.ToString();

			// Now assign the location of the icon on
			// btnImage...
			btnImage.ImageAlign = currAlignment;
		}
	}
}

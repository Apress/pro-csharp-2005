using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleModalDialog
{
    public partial class UserMessageDialog : Form
    {
        public UserMessageDialog()
        {
            InitializeComponent();
        }

        public string Message
        {
            set { txtUserInput.Text = value; }
            get { return txtUserInput.Text; }
        }
    }
}
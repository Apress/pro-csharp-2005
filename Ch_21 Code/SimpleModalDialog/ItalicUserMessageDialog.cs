using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleModalDialog
{
    public partial class ItalicUserMessageDialog : SimpleModalDialog.UserMessageDialog
    {
        public ItalicUserMessageDialog()
        {
            InitializeComponent();
        }

        public bool Italic
        {
            set { checkBoxItalic.Checked = value; }
            get { return checkBoxItalic.Checked; }
        }
    }
}
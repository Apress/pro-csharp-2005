using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleModalDialog
{
    public partial class MainWindow : Form
    {
        private string userMessage = "Default Message";
        private bool textIsItalic = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of UserMessageDialog.
            ItalicUserMessageDialog dlg = new ItalicUserMessageDialog();

            // Place the current message in the TextBox.
            dlg.Message = userMessage;
            dlg.Italic = textIsItalic;

            // If user clicked OK button, render their message.
            if (DialogResult.OK == dlg.ShowDialog())
            {
                userMessage = dlg.Message;
                textIsItalic = dlg.Italic;
                Invalidate();
            }
            // Have dialog clean up internal widgets now, rather 
            // then when the GC destroys the object.
            dlg.Dispose();
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = null;
            if(textIsItalic)
                f = new Font("Times New Roman", 24, FontStyle.Italic);
            else
                f = new Font("Times New Roman", 24);
            g.DrawString(userMessage, f, Brushes.DarkBlue,
                50, 50);
        }
    }
}
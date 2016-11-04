#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

using CommonSnappableTypes;
using System.Reflection;

namespace MyExtendableApp
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool LoadExternalModule(string path)
        {
            bool foundSnapIn = false;
            IAppFunctionality itfAppFx;

            // Dynamically load the selected assembly.
            Assembly theSnapInAsm = Assembly.LoadFrom(path);

            // Get all types in assembly.
            Type[] theTypes = theSnapInAsm.GetTypes();

            // See if a type implement IAppFunctionality.
            for (int i = 0; i < theTypes.Length; i++)
            {
                Type t = theTypes[i].GetInterface("IAppFunctionality");
                if (t != null)
                {
                    foundSnapIn = true;
                    
                    // Use late binding to create the type.
                    object o =
                       theSnapInAsm.CreateInstance(theTypes[i].FullName);

                    // Call DoIt() off the interface.
                    itfAppFx = o as IAppFunctionality;
                    itfAppFx.DoIt();
                    lstLoadedSnapIns.Items.Add(theTypes[i].FullName);

                    // Show company info.
                    DisplayCompanyData(theTypes[i]);
                }
            }
            return foundSnapIn;
        }

        private void DisplayCompanyData(Type t)
        {
            // Get [CompanyInfo] data.
            object[] customAtts = t.GetCustomAttributes(false);

            // Show data. 
            foreach (CompanyInfoAttribute c in customAtts)
            {
                MessageBox.Show(c.Url,
                    string.Format("More info about {0} can be found at", c.Name));
            }
        }

        private void snapInModuleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Allow user to select an assembly to load.
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (LoadExternalModule(dlg.FileName) == false)
                    MessageBox.Show("Nothing implements IAppFunctionality!");
            }
        }
    }
}
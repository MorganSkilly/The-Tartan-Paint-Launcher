using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Tartan_Paint_Launcher
{
    public partial class Form1 : Form
    {
        NameValueCollection appSettings;

        public Form1(NameValueCollection appSettings)
        {
            InitializeComponent();

            this.appSettings = appSettings;
            string output = "";

            foreach(string setting in appSettings.AllKeys)
            {
                output = (output + setting + " - " + appSettings.Get(setting) + "\n");
            }

            consoleOut.Text = output;
        }

        private void setupbutton_Click(object sender, EventArgs e)
        {
            Setup.FirstTimeSetup();
        }
    }
}

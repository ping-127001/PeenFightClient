using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace PeenFightClient.GUI
{
    public partial class CFrm : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public string Link = "http://144.172.120.112:8080";

        public CFrm()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void CFrm_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Cef.Shutdown();
            Close();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public void InitializeChromium()
        {
            try
            {
                CefSettings settings = new CefSettings();
                // Initialize cef with the provided settings
                Cef.Initialize(settings);
                // Create a browser component
                chromeBrowser = new ChromiumWebBrowser(Link);
                // Add it to the form and fill it to the form window.
                gamePnl.Controls.Add(chromeBrowser);
                chromeBrowser.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem initializing chromium, error: {ex.Message}", Application.ProductName);
            }
        }

        private void consoleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                chromeBrowser.ShowDevTools();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem showing console, error: {ex.Message}", Application.ProductName);
            }
        }

        private void refreshPage_Click(object sender, EventArgs e)
        {
            try
            {
                //there use to be a Navigate function that was more optimized but I can't find it anymore?
                chromeBrowser.Load(Link);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem refreshing the page, error: {ex.Message}", Application.ProductName);
            }
        }

        private void antiaimBtn_Click(object sender, EventArgs e)
        {
            chromeBrowser.ExecuteScriptAsync(("alert('anti aim test');"));
            //will basically change the position on an interval
        }

        private void invisCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (invisCheckBox.Checked)
                {
                    chromeBrowser.ExecuteScriptAsync("Client.eAngle = 0.283185307179586");
                }
                else
                {
                    chromeBrowser.ExecuteScriptAsync("Client.eAngle = 6.283185307179586"); //normal eAngle value
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was a problem running invis javascript, error: {ex.Message}", Application.ProductName);
            }
        }

        private void teleportBtn_Click(object sender, EventArgs e)
        {
            chromeBrowser.ExecuteScriptAsync($"Client.x = {tpX.Text}");
            chromeBrowser.ExecuteScriptAsync($"Client.x = {tpY.Text}");
            //yes, I know. This can be on the same line. I don't care.
        }
    }
}

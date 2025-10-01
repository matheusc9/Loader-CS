using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LoaderC_
{
    public partial class Launcher : Form
    {
        string username;
        string gameSelected = "";

        public Launcher(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = username;
        }

        private async void launchBtn_Click(object sender, EventArgs e)
        {
            if (gameSelect.SelectedItem == null)
            {
                MessageBox.Show("Please select a game to launch.",
                                "No Game Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            gameSelected = gameSelect.SelectedItem.ToString();

            if (gameSelected == "Load Steam game")
            {
                await Inject();
            }
            else if (gameSelected == "Overlay")
            {
                showOverlay();
            }
        }

        private async Task Inject()
        {
            Process.Start(
                @"C:\Program Files (x86)\Steam\steam.exe",
                "-applaunch appID" // change to app id
            );

            showLoadscreen();

            Process? oarProcess = null;

            while (oarProcess == null || oarProcess.HasExited)
            {
                oarProcess = Process.GetProcessesByName("example").FirstOrDefault(); // procces name (without extension)
                await Task.Delay(1000);
            }

            await Task.Delay(5000);
            Process.Start(
                @"C:\Users\Injector.exe" // path to injector executable
            );

            await Task.Delay(2000);
            WindowHelper.FocusProcess(oarProcess);

            Application.Exit();
        }

        void showOverlay()
        {
            Overlay overlay = new();
            overlay.Show();
            this.Hide();
        }

        private void showLoadscreen()
        {
            var loadscreen = new loadscreen("Launching...", 50);
            loadscreen.Show();
            this.Hide();
        }

        private void gameSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            launchBtn.Enabled = true;
        }
    }
}

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

            if (gameSelected == "The Forest")
            {
                await InjectTF();
            }
            else if (gameSelected == "One-Armed Robber")
            {
                await InjectOAR();
            }
            else if (gameSelected == "Overlay")
            {
                showOverlay();
            }
        }

        private async Task InjectTF()
        {
            Process.Start(
                @"C:\Program Files (x86)\Steam\steam.exe",
                "-applaunch 242760"
            );

            showLoadscreen();

            Process? forestProcess = null;

            while (forestProcess == null || forestProcess.HasExited)
            {
                forestProcess = Process.GetProcessesByName("TheForest").FirstOrDefault();
                await Task.Delay(1000);
            }

            while (string.IsNullOrEmpty(forestProcess.MainWindowTitle) ||
                   forestProcess.MainWindowTitle.Contains("Configuration"))
            {
                await Task.Delay(1000);
                forestProcess.Refresh();
            }

            await Task.Delay(10000);
            Process.Start(
                @"C:\Users\mathe\Documents\Codes\Loaders\Injector\x64\Release\Injector.exe"
            );

            await Task.Delay(10000);
            WindowHelper.FocusProcess(forestProcess);

            Application.Exit();
        }

        private async Task InjectOAR()
        {
            Process.Start(
                @"C:\Program Files (x86)\Steam\steam.exe",
                "-applaunch 2551020"
            );

            showLoadscreen();

            Process? oarProcess = null;

            while (oarProcess == null || oarProcess.HasExited)
            {
                oarProcess = Process.GetProcessesByName("OAR-Win64-Shipping").FirstOrDefault();
                await Task.Delay(1000);
            }

            await Task.Delay(5000);
            Process.Start(
                @"C:\Users\mathe\Documents\Codes\Loaders\Injector\x64\Release\Injector.exe"
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

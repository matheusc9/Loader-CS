using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoaderC_
{
    public partial class loadscreen : Form
    {
        string text;
        int time;

        public loadscreen(string text, int time)
        {
            InitializeComponent();
            this.text = text;
            this.time = time * 1000;
        }

        private async void loadscreen_Load(object sender, EventArgs e)
        {
            center(loadGif);
            center(loadLabel, true, false);

            loadLabel.Text = text;

            await Task.Delay(time);

            this.Hide();
        }

        private void center(Control c, bool x = true, bool y = true)
        {
            if (x)
            {
                c.Left = (this.ClientSize.Width - c.Width) / 2;
            }
            else
            {
                c.Top = (this.ClientSize.Height - c.Height) / 2;
            }
        }
    }
}

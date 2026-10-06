using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_Jevický
{
    public partial class AppWindow : Form
    {
        int timelimit = 2500;

        Image panacek = Image.FromFile("panacek1.png");

        public AppWindow()
        {
            InitializeComponent();         
        }

        private void AppWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Chcete  ukončit program ?", "Dotaz", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Panel_IMG_Paint(object sender, PaintEventArgs e)
        {
            Graphics paint_plane;
            paint_plane = e.Graphics;

 
            paint_plane.DrawImage(panacek, 0, 0, 300, 300);
        }

        private void Button_change_Click(object sender, EventArgs e)
        {
            panacek = Image.FromFile("panacek2.png");

            timer.Start();

            panel_IMG.Refresh();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            panacek = Image.FromFile("panacek1.png");

            timer.Stop();
            panel_IMG.Refresh();
        }

        private void Button_diff_Click(object sender, EventArgs e)
        {
            int diff = Convert.ToInt32(numericUpDown_eror.Value);

            if (4 == diff)
            {
                MessageBox.Show("Správně - nešel jsi 4 rozdíly");
            }
            else
            {
                MessageBox.Show("Špatně");
            }
        }

        private void Button_time_Click(object sender, EventArgs e)
        { 
                timelimit = 1000 * Convert.ToInt32(numericUpDown_time.Value);
                timer.Interval = timelimit;
        }
    }
}

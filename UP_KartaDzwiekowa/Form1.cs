using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace UP_KartaDzwiekowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PLAYSOUND();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void buttonReadData_Click(object sender, EventArgs e)
        {

        }
    }
}

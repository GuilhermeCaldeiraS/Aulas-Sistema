using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proejto_Video
{
    public partial class frm_video : Form
    {
        public frm_video()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_video_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"video\Michael Jackson - Rock With You.mp4";
        }
    }
}

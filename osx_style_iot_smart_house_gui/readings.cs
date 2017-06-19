using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osx_style_iot_smart_house_gui
{
    public partial class readings : UserControl
    {
        public readings()
        {
            InitializeComponent();
        }


        public string title
        {
            get
            {
                return lbltitle.Text;

            }
            set
            {
                lbltitle.Text = value;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuiOSSwitch1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bunifuiOSSwitch1.Value)
            {
                bunifuTransition1.ShowSync(slide1);
            }
        }

        private void bunifuiOSSwitch2_MouseMove(object sender, MouseEventArgs e)
        {
            if (bunifuiOSSwitch2.Value)
            {
                bunifuTransition1.ShowSync(slider2);
            }

        }

        private void readings_MouseMove(object sender, MouseEventArgs e)
        {
            slide1.Visible = slider2.Visible = false;
        }
    }
}

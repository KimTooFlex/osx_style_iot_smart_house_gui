using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osx_style_iot_smart_house_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            readings1.title = "Bathroom";
            animate();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            readings1.title = "Kitchen";
            animate();
        }

        private void readings1_Load(object sender, EventArgs e)
        {

        }



        public void animate()
        {
            readings1.Visible = false;
            bunifuTransition1.ShowSync(readings1);

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            readings1.title = "Living Room";
            animate();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            readings1.title = "Study";
            animate();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            readings1.title = "Backyard";
            animate();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace InnApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refeshHouse();


        }

        public void refeshHouse()
        {
            panel1.Controls.Clear();

            House house = new House();

            int i = 0 ;

            foreach (House h in house.getHouseList())
            {
                HouseControl hc = new HouseControl();


                hc.Name = h.KFID;
                hc.KFID = h.KFID;
                hc.FJH = h.FJH;

                hc.BZ = h.BZ;

                hc.Top = 24 + 140 * (i/8);
                hc.Left = 37 + 130 * (i%8);

                panel1.Controls.Add(hc);

                i += 1;

            }

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new frmHouseManager();
            f.ShowDialog();

            refeshHouse();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f = new  frmAboutBox1();
            f.ShowDialog();
        }

        private void 报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form f = new frmReport();
            f.ShowDialog();
        }

    }
}

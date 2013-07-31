using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnApp
{
    public partial class frmHouseAdd : Form
    {
        public frmHouseAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            House h = new House();

            h.FJH = txt_FJH.Text;
            h.SZC = txt_SZC.Text;
            h.KFJG = int.Parse(txt_KFJG.Text);

            h.BZ = "";

            if (chk_BJ.Checked) h.BZ = h.BZ + "标间";
            if (chk_DRJ.Checked) h.BZ = h.BZ + "单人间";

            if (chk_SCF.Checked) h.BZ = h.BZ + ",双床房";
            if (chk_DCF.Checked) h.BZ = h.BZ + ",大床房";

            if (chk_KD.Checked) h.BZ = h.BZ + ",宽带";
            if (chk_WQ.Checked) h.BZ = h.BZ + ",温泉";

            if (h.Add())
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                Loger.ShowMessage("添加失败");
            }
        }
    }
}

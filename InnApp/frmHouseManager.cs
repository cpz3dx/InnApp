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
    public partial class frmHouseManager : Form
    {
        public frmHouseManager()
        {
            InitializeComponent();
        }

        private void HouseManager_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“inndataDataSet.KF”中。您可以根据需要移动或删除它。
            this.kFTableAdapter.Fill(this.inndataDataSet.KF);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new frmHouseAdd();

            f.Show();
             
        }
    }
}

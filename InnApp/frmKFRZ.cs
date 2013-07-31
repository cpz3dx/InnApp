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
    public partial class frmKFRZ : Form
    {

        private string s_KFID;
        private string s_LSH;

        public frmKFRZ(string KFID)
        {
            InitializeComponent();

            s_KFID = KFID;
        }

        private void frmKFRZ_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            KFRZ rz = new KFRZ();

            string lsh = rz.getRZLSH(s_KFID);

            if (lsh.Length > 0)
            {
                rz.LSH = lsh;

                s_LSH = rz.LSH;

                lbl_LSH.Text = rz.LSH;
                lbl_FJH.Text = rz.FJH;
                txt_XM.Text = rz.XM;
                txt_ZJHM.Text = rz.ZJHM;

                txt_RZSJ.Text = System.DateTime.ParseExact(rz.RZSJ, "yyyyMMddHHmmss", null).ToString();
                txt_RZSJ.ReadOnly = true;

                txt_RZTS.Text = getDays(txt_RZSJ.Text);

                txt_KFJG.Text = rz.KFJG.ToString();

                txt_YSK.Text = rz.YSK.ToString();
                txt_YJ.Text = rz.YJ.ToString();

                btn_KF.Visible = false;
            }
            else
            {
                House h = new House(s_KFID);

                lbl_FJH.Text = h.FJH;
                
                txt_KFJG.Text = h.KFJG.ToString();

                btn_TF.Visible = false;


                lbl_LSH.Text = "";

            }
        }

        private void btn_KF_Click(object sender, EventArgs e)
        {
            KFRZ rz = new KFRZ();

            rz.FJH = lbl_FJH.Text;
            rz.KFID = s_KFID;
            rz.XM = txt_XM.Text;
            rz.ZJHM = txt_ZJHM.Text;
            rz.KFJG = int.Parse(txt_KFJG.Text);
            rz.YSK = int.Parse(txt_YSK.Text);
            rz.YJ = int.Parse(txt_YJ.Text);

            if (rz.KF())
            {
                MessageBox.Show(lbl_FJH.Text + "已开房!");
                this.Close();
            }
            else
            {
                Loger.ShowMessage("开房失败！");   
            }
        }

        private string  getDays(string day)
        {
            TimeSpan t = System.DateTime.Now - System.DateTime.Parse(day);

            return Math.Ceiling(t.TotalDays).ToString();
        }

        private void btn_TF_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            txt_YSKQR.Text = txt_YSK.Text;
            txt_RZTSQR.Text = getDays(txt_RZSJ.Text);
            txt_ZFK.Text =( int.Parse(txt_KFJG.Text) * int.Parse(txt_RZTSQR.Text)).ToString();
            txt_YJQR.Text = (int.Parse(txt_YSKQR.Text) - int.Parse(txt_ZFK.Text)).ToString();
        }

        private void btn_TFQR_Click(object sender, EventArgs e)
        {
            KFRZ rz = new KFRZ(s_LSH);

            rz.YSK = int.Parse(txt_YSKQR.Text);
            rz.ZFK = int.Parse(txt_ZFK.Text);
            rz.RZTS = int.Parse(txt_RZTSQR.Text);
            rz.YJ = int.Parse(txt_YJQR.Text);

            if (rz.TF())
            {
                MessageBox.Show(lbl_FJH.Text + "退房成功");

                this.Close();
            }
            else
            {
                Loger.ShowMessage("退房失败！");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}

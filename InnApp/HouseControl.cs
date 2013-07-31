using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnApp
{


    public partial class HouseControl : UserControl
    {

        public HouseControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 客房ID
        /// </summary>
        public string KFID
        {
            get 
            { 
                return label1.Tag.ToString(); 
            }
            set
            {
                label1.Tag = value;



                KFRZ rz = new KFRZ();

                string lsh = rz.getRZLSH(value);

                if (lsh.Length > 0)
                {
                    IsSelled = true;
                }
                else
                {
                    IsSelled = false;
                }
            }
        }

        /// <summary>
        /// 是否已售
        /// </summary>
        private  bool IsSelled
        {
            set
            {
                if (value)
                {
                    panel1.BackColor = System.Drawing.Color.Tomato;
                }
                else
                {
                    panel1.BackColor = System.Drawing.Color.MintCream;
                }
            }
        }

        /// <summary>
        /// 房间号
        /// </summary>
        public string FJH
        {
            get
            { return label1.Text; }
            set
            {
                label1.Text = value;
            }
        }


        /// <summary>
        /// 客房备注
        /// </summary>
        public string BZ
        {
            get
            { return lbl_BZ.Text; }
            set
            { lbl_BZ.Text = value; }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmKFRZ f = new frmKFRZ(label1.Tag.ToString());
            f.ShowDialog();


            KFRZ rz = new KFRZ();

            string lsh = rz.getRZLSH(label1.Tag.ToString());

            if (lsh.Length > 0)
            {
                IsSelled = true;
            }
            else
            {
                IsSelled = false;
            }
        }
    }
}

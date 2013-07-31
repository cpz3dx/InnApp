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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            this.printDialog1.Document = this.printDocument1;//必要的
            this.printPreviewDialog1.Document = this.printDocument1;
            this.pageSetupDialog1.Document = this.printDocument1; 
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
                this.printDocument1.Print(); 
        }

        private void btn_Pre_Click(object sender, EventArgs e)
        {
            //打印预览
            this.printPreviewDialog1.ShowDialog(); 
        }

        private void btn_PrintSet_Click(object sender, EventArgs e)
        {
            //打印设置
            this.pageSetupDialog1.ShowDialog(); 
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Tahoma", 12, FontStyle.Underline);//设置画笔
            Brush bru = Brushes.Blue;
            Pen pen = new Pen(bru);
            pen.Width = 5;
            //设置各边距
            int nLeft = this.pageSetupDialog1.PageSettings.Margins.Left;
            int nTop = this.pageSetupDialog1.PageSettings.Margins.Top;
            int nRight = this.pageSetupDialog1.PageSettings.Margins.Right;
            int nBottom = this.pageSetupDialog1.PageSettings.Margins.Bottom;
            int nWidth = this.pageSetupDialog1.PageSettings.PaperSize.Width - nRight - nLeft;
            int nHeight = this.pageSetupDialog1.PageSettings.PaperSize.Height - nTop - nBottom;
            //打印各边距
            e.Graphics.DrawLine(pen, nLeft, nTop, nLeft, nTop + nHeight);
            e.Graphics.DrawLine(pen, nLeft + nWidth, nTop, nLeft + nWidth, nTop + nHeight);
            e.Graphics.DrawLine(pen, nLeft, nTop, nLeft + nWidth, nTop);
            e.Graphics.DrawLine(pen, nLeft, nTop + nHeight, nLeft + nWidth, nTop + nHeight);
            //在离左边距20,右边距20的位置打印haha xixi
            e.Graphics.DrawString("haha xixi", font, bru, nLeft + 20, nTop + 20);//如果要打印
        }
    }
}

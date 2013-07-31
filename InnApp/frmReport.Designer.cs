namespace InnApp
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_PrintSet = new System.Windows.Forms.Button();
            this.btn_Pre = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(76, 37);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 0;
            this.btn_Print.Text = "打印";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_PrintSet
            // 
            this.btn_PrintSet.Location = new System.Drawing.Point(197, 37);
            this.btn_PrintSet.Name = "btn_PrintSet";
            this.btn_PrintSet.Size = new System.Drawing.Size(75, 23);
            this.btn_PrintSet.TabIndex = 1;
            this.btn_PrintSet.Text = "打印设置";
            this.btn_PrintSet.UseVisualStyleBackColor = true;
            this.btn_PrintSet.Click += new System.EventHandler(this.btn_PrintSet_Click);
            // 
            // btn_Pre
            // 
            this.btn_Pre.Location = new System.Drawing.Point(336, 37);
            this.btn_Pre.Name = "btn_Pre";
            this.btn_Pre.Size = new System.Drawing.Size(75, 23);
            this.btn_Pre.TabIndex = 2;
            this.btn_Pre.Text = "打印预览";
            this.btn_Pre.UseVisualStyleBackColor = true;
            this.btn_Pre.Click += new System.EventHandler(this.btn_Pre_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 439);
            this.Controls.Add(this.btn_Pre);
            this.Controls.Add(this.btn_PrintSet);
            this.Controls.Add(this.btn_Print);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_PrintSet;
        private System.Windows.Forms.Button btn_Pre;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;

        

    }
}
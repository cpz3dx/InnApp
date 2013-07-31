namespace InnApp
{
    partial class frmHouseManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHouseManager));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fJHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kFJGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sZCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cJSJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inndataDataSet = new InnApp.inndataDataSet();
            this.kFTableAdapter = new InnApp.inndataDataSetTableAdapters.KFTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inndataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kFIDDataGridViewTextBoxColumn,
            this.fJHDataGridViewTextBoxColumn,
            this.kFJGDataGridViewTextBoxColumn,
            this.sZCDataGridViewTextBoxColumn,
            this.bZDataGridViewTextBoxColumn,
            this.cJSJDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kFBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(695, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // kFIDDataGridViewTextBoxColumn
            // 
            this.kFIDDataGridViewTextBoxColumn.DataPropertyName = "KFID";
            this.kFIDDataGridViewTextBoxColumn.HeaderText = "编号";
            this.kFIDDataGridViewTextBoxColumn.Name = "kFIDDataGridViewTextBoxColumn";
            // 
            // fJHDataGridViewTextBoxColumn
            // 
            this.fJHDataGridViewTextBoxColumn.DataPropertyName = "FJH";
            this.fJHDataGridViewTextBoxColumn.HeaderText = "房间号";
            this.fJHDataGridViewTextBoxColumn.Name = "fJHDataGridViewTextBoxColumn";
            // 
            // kFJGDataGridViewTextBoxColumn
            // 
            this.kFJGDataGridViewTextBoxColumn.DataPropertyName = "KFJG";
            this.kFJGDataGridViewTextBoxColumn.HeaderText = "价格";
            this.kFJGDataGridViewTextBoxColumn.Name = "kFJGDataGridViewTextBoxColumn";
            // 
            // sZCDataGridViewTextBoxColumn
            // 
            this.sZCDataGridViewTextBoxColumn.DataPropertyName = "SZC";
            this.sZCDataGridViewTextBoxColumn.HeaderText = "所在层";
            this.sZCDataGridViewTextBoxColumn.Name = "sZCDataGridViewTextBoxColumn";
            // 
            // bZDataGridViewTextBoxColumn
            // 
            this.bZDataGridViewTextBoxColumn.DataPropertyName = "BZ";
            this.bZDataGridViewTextBoxColumn.HeaderText = "备注";
            this.bZDataGridViewTextBoxColumn.Name = "bZDataGridViewTextBoxColumn";
            // 
            // cJSJDataGridViewTextBoxColumn
            // 
            this.cJSJDataGridViewTextBoxColumn.DataPropertyName = "CJSJ";
            this.cJSJDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.cJSJDataGridViewTextBoxColumn.Name = "cJSJDataGridViewTextBoxColumn";
            // 
            // kFBindingSource
            // 
            this.kFBindingSource.DataMember = "KF";
            this.kFBindingSource.DataSource = this.inndataDataSet;
            // 
            // inndataDataSet
            // 
            this.inndataDataSet.DataSetName = "inndataDataSet";
            this.inndataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kFTableAdapter
            // 
            this.kFTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHouseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 241);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHouseManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "客房基本信息";
            this.Load += new System.EventHandler(this.HouseManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inndataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private inndataDataSet inndataDataSet;
        private System.Windows.Forms.BindingSource kFBindingSource;
        private inndataDataSetTableAdapters.KFTableAdapter kFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fJHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kFJGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sZCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cJSJDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}
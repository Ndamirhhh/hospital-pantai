namespace PROJECTVISUALPROGRAMMING_TSE2473_
{
    partial class asset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(asset));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSSETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKASSETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assetnametxt = new System.Windows.Forms.TextBox();
            this.assetdetailtxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.hospitalDataSet = new PROJECTVISUALPROGRAMMING_TSE2473_.hospitalDataSet();
            this.assetcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetcategoryTableAdapter = new PROJECTVISUALPROGRAMMING_TSE2473_.hospitalDataSetTableAdapters.assetcategoryTableAdapter();
            this.dataGridAssetView = new System.Windows.Forms.DataGridView();
            this.assetidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetdetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetdatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetTableAdapter = new PROJECTVISUALPROGRAMMING_TSE2473_.hospitalDataSetTableAdapters.assetTableAdapter();
            this.fKTableToTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssetView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTableToTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGOUTToolStripMenuItem,
            this.lOGOUTToolStripMenuItem1,
            this.hOMEToolStripMenuItem,
            this.aSSETToolStripMenuItem,
            this.bOOKASSETToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(980, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lOGOUTToolStripMenuItem.Image")));
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.lOGOUTToolStripMenuItem.Text = "EXIT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem1
            // 
            this.lOGOUTToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("lOGOUTToolStripMenuItem1.Image")));
            this.lOGOUTToolStripMenuItem1.Name = "lOGOUTToolStripMenuItem1";
            this.lOGOUTToolStripMenuItem1.Size = new System.Drawing.Size(103, 24);
            this.lOGOUTToolStripMenuItem1.Text = "LOG OUT";
            this.lOGOUTToolStripMenuItem1.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem1_Click);
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hOMEToolStripMenuItem.Image")));
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // aSSETToolStripMenuItem
            // 
            this.aSSETToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aSSETToolStripMenuItem.Image")));
            this.aSSETToolStripMenuItem.Name = "aSSETToolStripMenuItem";
            this.aSSETToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.aSSETToolStripMenuItem.Text = "ASSET";
            this.aSSETToolStripMenuItem.Click += new System.EventHandler(this.aSSETToolStripMenuItem_Click);
            // 
            // bOOKASSETToolStripMenuItem
            // 
            this.bOOKASSETToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bOOKASSETToolStripMenuItem.Image")));
            this.bOOKASSETToolStripMenuItem.Name = "bOOKASSETToolStripMenuItem";
            this.bOOKASSETToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.bOOKASSETToolStripMenuItem.Text = "VIEW BOOKED ASSET";
            this.bOOKASSETToolStripMenuItem.Click += new System.EventHandler(this.bOOKASSETToolStripMenuItem_Click);
            // 
            // logo
            // 
            this.logo.Image = global::PROJECTVISUALPROGRAMMING_TSE2473_.Properties.Resources.pantai_logo;
            this.logo.Location = new System.Drawing.Point(293, 41);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(332, 61);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 17;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(319, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "- ASSET MANAGEMENT -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // assetnametxt
            // 
            this.assetnametxt.Location = new System.Drawing.Point(166, 172);
            this.assetnametxt.Name = "assetnametxt";
            this.assetnametxt.Size = new System.Drawing.Size(268, 22);
            this.assetnametxt.TabIndex = 19;
            this.assetnametxt.TextChanged += new System.EventHandler(this.assetnametxt_TextChanged);
            // 
            // assetdetailtxt
            // 
            this.assetdetailtxt.Location = new System.Drawing.Point(177, 232);
            this.assetdetailtxt.Name = "assetdetailtxt";
            this.assetdetailtxt.Size = new System.Drawing.Size(268, 22);
            this.assetdetailtxt.TabIndex = 20;
            this.assetdetailtxt.TextChanged += new System.EventHandler(this.assetdetailtxt_TextChanged);
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(845, 203);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(88, 22);
            this.quantitytxt.TabIndex = 21;
            this.quantitytxt.TextChanged += new System.EventHandler(this.quantitytxt_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(563, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "ASSET NAME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "ASSET DETAIL :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(831, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "QUANTITY  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "DATETIME :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "ASSET CATEGORY :";
            // 
            // comboBox
            // 
            this.comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hospitalDataSet, "assetcategory.cat_type", true));
            this.comboBox.DataSource = this.assetcategoryBindingSource;
            this.comboBox.DisplayMember = "cat_type";
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(632, 170);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(137, 24);
            this.comboBox.TabIndex = 28;
            this.comboBox.ValueMember = "cat_id";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetcategoryBindingSource
            // 
            this.assetcategoryBindingSource.DataMember = "assetcategory";
            this.assetcategoryBindingSource.DataSource = this.hospitalDataSet;
            // 
            // assetcategoryTableAdapter
            // 
            this.assetcategoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridAssetView
            // 
            this.dataGridAssetView.AutoGenerateColumns = false;
            this.dataGridAssetView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridAssetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAssetView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assetidDataGridViewTextBoxColumn,
            this.assetnameDataGridViewTextBoxColumn,
            this.assetquantityDataGridViewTextBoxColumn,
            this.assetdetailDataGridViewTextBoxColumn,
            this.assetdatetimeDataGridViewTextBoxColumn,
            this.catidDataGridViewTextBoxColumn});
            this.dataGridAssetView.DataSource = this.assetBindingSource1;
            this.dataGridAssetView.Location = new System.Drawing.Point(46, 316);
            this.dataGridAssetView.Name = "dataGridAssetView";
            this.dataGridAssetView.ReadOnly = true;
            this.dataGridAssetView.RowHeadersWidth = 51;
            this.dataGridAssetView.RowTemplate.Height = 24;
            this.dataGridAssetView.Size = new System.Drawing.Size(896, 164);
            this.dataGridAssetView.TabIndex = 29;
            this.dataGridAssetView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAssetView_CellContentClick);
            // 
            // assetidDataGridViewTextBoxColumn
            // 
            this.assetidDataGridViewTextBoxColumn.DataPropertyName = "asset_id";
            this.assetidDataGridViewTextBoxColumn.HeaderText = "asset_id";
            this.assetidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assetidDataGridViewTextBoxColumn.Name = "assetidDataGridViewTextBoxColumn";
            this.assetidDataGridViewTextBoxColumn.ReadOnly = true;
            this.assetidDataGridViewTextBoxColumn.Width = 125;
            // 
            // assetnameDataGridViewTextBoxColumn
            // 
            this.assetnameDataGridViewTextBoxColumn.DataPropertyName = "asset_name";
            this.assetnameDataGridViewTextBoxColumn.HeaderText = "asset_name";
            this.assetnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assetnameDataGridViewTextBoxColumn.Name = "assetnameDataGridViewTextBoxColumn";
            this.assetnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.assetnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // assetquantityDataGridViewTextBoxColumn
            // 
            this.assetquantityDataGridViewTextBoxColumn.DataPropertyName = "asset_quantity";
            this.assetquantityDataGridViewTextBoxColumn.HeaderText = "asset_quantity";
            this.assetquantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assetquantityDataGridViewTextBoxColumn.Name = "assetquantityDataGridViewTextBoxColumn";
            this.assetquantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.assetquantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // assetdetailDataGridViewTextBoxColumn
            // 
            this.assetdetailDataGridViewTextBoxColumn.DataPropertyName = "asset_detail ";
            this.assetdetailDataGridViewTextBoxColumn.HeaderText = "asset_detail ";
            this.assetdetailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assetdetailDataGridViewTextBoxColumn.Name = "assetdetailDataGridViewTextBoxColumn";
            this.assetdetailDataGridViewTextBoxColumn.ReadOnly = true;
            this.assetdetailDataGridViewTextBoxColumn.Width = 300;
            // 
            // assetdatetimeDataGridViewTextBoxColumn
            // 
            this.assetdatetimeDataGridViewTextBoxColumn.DataPropertyName = "asset_datetime";
            this.assetdatetimeDataGridViewTextBoxColumn.HeaderText = "asset_datetime";
            this.assetdatetimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assetdatetimeDataGridViewTextBoxColumn.Name = "assetdatetimeDataGridViewTextBoxColumn";
            this.assetdatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.assetdatetimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // catidDataGridViewTextBoxColumn
            // 
            this.catidDataGridViewTextBoxColumn.DataPropertyName = "cat_id";
            this.catidDataGridViewTextBoxColumn.HeaderText = "cat_id";
            this.catidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catidDataGridViewTextBoxColumn.Name = "catidDataGridViewTextBoxColumn";
            this.catidDataGridViewTextBoxColumn.ReadOnly = true;
            this.catidDataGridViewTextBoxColumn.Width = 125;
            // 
            // assetBindingSource1
            // 
            this.assetBindingSource1.DataMember = "asset";
            this.assetBindingSource1.DataSource = this.hospitalDataSet;
            // 
            // assetBindingSource
            // 
            this.assetBindingSource.DataMember = "asset";
            this.assetBindingSource.DataSource = this.hospitalDataSet;
            // 
            // assetTableAdapter
            // 
            this.assetTableAdapter.ClearBeforeFill = true;
            // 
            // fKTableToTableBindingSource
            // 
            this.fKTableToTableBindingSource.DataMember = "FK_Table_ToTable";
            this.fKTableToTableBindingSource.DataSource = this.assetBindingSource;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Silver;
            this.addbtn.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(86, 272);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(116, 38);
            this.addbtn.TabIndex = 30;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.Silver;
            this.resetbtn.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.Location = new System.Drawing.Point(397, 272);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(116, 38);
            this.resetbtn.TabIndex = 31;
            this.resetbtn.Text = "RESET";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Silver;
            this.deletebtn.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(733, 272);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(116, 38);
            this.deletebtn.TabIndex = 32;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 515);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.dataGridAssetView);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.assetdetailtxt);
            this.Controls.Add(this.assetnametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "asset";
            this.Text = "asset";
            this.Load += new System.EventHandler(this.asset_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssetView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTableToTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSSETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKASSETToolStripMenuItem;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox assetnametxt;
        private System.Windows.Forms.TextBox assetdetailtxt;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox;
        private hospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource assetcategoryBindingSource;
        private hospitalDataSetTableAdapters.assetcategoryTableAdapter assetcategoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridAssetView;
        private System.Windows.Forms.BindingSource assetBindingSource;
        private hospitalDataSetTableAdapters.assetTableAdapter assetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetdetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetdatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource assetBindingSource1;
        private System.Windows.Forms.BindingSource fKTableToTableBindingSource;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button deletebtn;
    }
}
namespace PROJECTVISUALPROGRAMMING_TSE2473_
{
    partial class assetbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assetbook));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomavaibilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet7 = new PROJECTVISUALPROGRAMMING_TSE2473_.hospitalDataSet7();
            this.operationroomTableAdapter = new PROJECTVISUALPROGRAMMING_TSE2473_.hospitalDataSet7TableAdapters.operationroomTableAdapter();
            this.resetbtn = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.dateTimePickerBookingDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSurgeon = new System.Windows.Forms.ComboBox();
            this.comboBoxOperationRoom = new System.Windows.Forms.ComboBox();
            this.comboBoxAnesthesia = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGOUTToolStripMenuItem,
            this.lOGOUTToolStripMenuItem1,
            this.hOMEToolStripMenuItem,
            this.bOOKToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(833, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lOGOUTToolStripMenuItem.Image")));
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.lOGOUTToolStripMenuItem.Text = "EXIT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click_1);
            // 
            // lOGOUTToolStripMenuItem1
            // 
            this.lOGOUTToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("lOGOUTToolStripMenuItem1.Image")));
            this.lOGOUTToolStripMenuItem1.Name = "lOGOUTToolStripMenuItem1";
            this.lOGOUTToolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.lOGOUTToolStripMenuItem1.Text = "LOG OUT";
            this.lOGOUTToolStripMenuItem1.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem1_Click);
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hOMEToolStripMenuItem.Image")));
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // bOOKToolStripMenuItem
            // 
            this.bOOKToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bOOKToolStripMenuItem.Image")));
            this.bOOKToolStripMenuItem.Name = "bOOKToolStripMenuItem";
            this.bOOKToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.bOOKToolStripMenuItem.Text = "BOOKED OPERATION ROOM";
            this.bOOKToolStripMenuItem.Click += new System.EventHandler(this.bOOKToolStripMenuItem_Click);
            // 
            // logo
            // 
            this.logo.Image = global::PROJECTVISUALPROGRAMMING_TSE2473_.Properties.Resources.pantai_logo;
            this.logo.Location = new System.Drawing.Point(251, 40);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(332, 61);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 16;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(295, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 55);
            this.label1.TabIndex = 19;
            this.label1.Text = "- OPERATION BOOK -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "DATE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "SURGEON :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "ROOM :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "ANESTHESIA :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomidDataGridViewTextBoxColumn,
            this.roomavaibilityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operationroomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(304, 164);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "room_id";
            this.roomidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            this.roomidDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomavaibilityDataGridViewTextBoxColumn
            // 
            this.roomavaibilityDataGridViewTextBoxColumn.DataPropertyName = "room_avaibility";
            this.roomavaibilityDataGridViewTextBoxColumn.HeaderText = "room_avaibility";
            this.roomavaibilityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomavaibilityDataGridViewTextBoxColumn.Name = "roomavaibilityDataGridViewTextBoxColumn";
            this.roomavaibilityDataGridViewTextBoxColumn.Width = 125;
            // 
            // operationroomBindingSource
            // 
            this.operationroomBindingSource.DataMember = "operationroom";
            this.operationroomBindingSource.DataSource = this.hospitalDataSet7;
            // 
            // hospitalDataSet7
            // 
            this.hospitalDataSet7.DataSetName = "hospitalDataSet7";
            this.hospitalDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operationroomTableAdapter
            // 
            this.operationroomTableAdapter.ClearBeforeFill = true;
            // 
            // resetbtn
            // 
            this.resetbtn.BackColor = System.Drawing.Color.Silver;
            this.resetbtn.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.Location = new System.Drawing.Point(445, 399);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(116, 38);
            this.resetbtn.TabIndex = 32;
            this.resetbtn.Text = "RESET";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.Color.Silver;
            this.btnbook.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.Location = new System.Drawing.Point(609, 399);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(116, 38);
            this.btnbook.TabIndex = 33;
            this.btnbook.Text = "BOOK";
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // dateTimePickerBookingDate
            // 
            this.dateTimePickerBookingDate.Location = new System.Drawing.Point(157, 174);
            this.dateTimePickerBookingDate.Name = "dateTimePickerBookingDate";
            this.dateTimePickerBookingDate.Size = new System.Drawing.Size(210, 22);
            this.dateTimePickerBookingDate.TabIndex = 34;
            this.dateTimePickerBookingDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxSurgeon
            // 
            this.comboBoxSurgeon.FormattingEnabled = true;
            this.comboBoxSurgeon.Items.AddRange(new object[] {
            "NADIA AMIRAH",
            "NURIN AINA",
            "ADINA HAZIRAH"});
            this.comboBoxSurgeon.Location = new System.Drawing.Point(152, 250);
            this.comboBoxSurgeon.Name = "comboBoxSurgeon";
            this.comboBoxSurgeon.Size = new System.Drawing.Size(214, 24);
            this.comboBoxSurgeon.TabIndex = 35;
            this.comboBoxSurgeon.SelectedIndexChanged += new System.EventHandler(this.comboBoxSurgeon_SelectedIndexChanged);
            // 
            // comboBoxOperationRoom
            // 
            this.comboBoxOperationRoom.FormattingEnabled = true;
            this.comboBoxOperationRoom.Items.AddRange(new object[] {
            "ROOM 101",
            "ROOM 102",
            "ROOM 103",
            "ROOM 104",
            "ROOM 105",
            "ROOM 106"});
            this.comboBoxOperationRoom.Location = new System.Drawing.Point(609, 174);
            this.comboBoxOperationRoom.Name = "comboBoxOperationRoom";
            this.comboBoxOperationRoom.Size = new System.Drawing.Size(214, 24);
            this.comboBoxOperationRoom.TabIndex = 36;
            this.comboBoxOperationRoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperationRoom_SelectedIndexChanged);
            // 
            // comboBoxAnesthesia
            // 
            this.comboBoxAnesthesia.FormattingEnabled = true;
            this.comboBoxAnesthesia.Items.AddRange(new object[] {
            "General Anesthesia",
            "Regional Anesthesia",
            "Local Anesthesia"});
            this.comboBoxAnesthesia.Location = new System.Drawing.Point(607, 254);
            this.comboBoxAnesthesia.Name = "comboBoxAnesthesia";
            this.comboBoxAnesthesia.Size = new System.Drawing.Size(214, 24);
            this.comboBoxAnesthesia.TabIndex = 37;
            this.comboBoxAnesthesia.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnesthesia_SelectedIndexChanged);
            // 
            // assetbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 468);
            this.Controls.Add(this.comboBoxAnesthesia);
            this.Controls.Add(this.comboBoxOperationRoom);
            this.Controls.Add(this.comboBoxSurgeon);
            this.Controls.Add(this.dateTimePickerBookingDate);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "assetbook";
            this.Text = "assetbook";
            this.Load += new System.EventHandler(this.assetbook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKToolStripMenuItem;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hospitalDataSet7 hospitalDataSet7;
        private System.Windows.Forms.BindingSource operationroomBindingSource;
        private hospitalDataSet7TableAdapters.operationroomTableAdapter operationroomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomavaibilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookingDate;
        private System.Windows.Forms.ComboBox comboBoxSurgeon;
        private System.Windows.Forms.ComboBox comboBoxOperationRoom;
        private System.Windows.Forms.ComboBox comboBoxAnesthesia;
    }
}
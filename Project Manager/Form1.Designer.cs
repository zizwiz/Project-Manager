
namespace Project_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpbx_data_tab = new System.Windows.Forms.GroupBox();
            this.btn_add_csv_column = new System.Windows.Forms.Button();
            this.btn_add_csv_row = new System.Windows.Forms.Button();
            this.btn_write_csv_file = new System.Windows.Forms.Button();
            this.btn_open_csv = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab_data = new System.Windows.Forms.TabPage();
            this.dgv_csv_data = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpbx_data_tab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_csv_data)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1122, 802);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 796);
            this.panel1.TabIndex = 0;
            // 
            // grpbx_data_tab
            // 
            this.grpbx_data_tab.Controls.Add(this.btn_add_csv_column);
            this.grpbx_data_tab.Controls.Add(this.btn_add_csv_row);
            this.grpbx_data_tab.Controls.Add(this.btn_write_csv_file);
            this.grpbx_data_tab.Controls.Add(this.btn_open_csv);
            this.grpbx_data_tab.Location = new System.Drawing.Point(1, 48);
            this.grpbx_data_tab.Name = "grpbx_data_tab";
            this.grpbx_data_tab.Size = new System.Drawing.Size(137, 201);
            this.grpbx_data_tab.TabIndex = 11;
            this.grpbx_data_tab.TabStop = false;
            // 
            // btn_add_csv_column
            // 
            this.btn_add_csv_column.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_csv_column.Location = new System.Drawing.Point(7, 59);
            this.btn_add_csv_column.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add_csv_column.Name = "btn_add_csv_column";
            this.btn_add_csv_column.Size = new System.Drawing.Size(112, 35);
            this.btn_add_csv_column.TabIndex = 10;
            this.btn_add_csv_column.Text = "Add Col";
            this.btn_add_csv_column.UseVisualStyleBackColor = true;
            this.btn_add_csv_column.Click += new System.EventHandler(this.btn_add_csv_column_Click);
            // 
            // btn_add_csv_row
            // 
            this.btn_add_csv_row.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_csv_row.Location = new System.Drawing.Point(7, 104);
            this.btn_add_csv_row.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add_csv_row.Name = "btn_add_csv_row";
            this.btn_add_csv_row.Size = new System.Drawing.Size(112, 35);
            this.btn_add_csv_row.TabIndex = 9;
            this.btn_add_csv_row.Text = "Add Row";
            this.btn_add_csv_row.UseVisualStyleBackColor = true;
            this.btn_add_csv_row.Click += new System.EventHandler(this.btn_add_csv_row_Click);
            // 
            // btn_write_csv_file
            // 
            this.btn_write_csv_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_write_csv_file.Location = new System.Drawing.Point(8, 149);
            this.btn_write_csv_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_write_csv_file.Name = "btn_write_csv_file";
            this.btn_write_csv_file.Size = new System.Drawing.Size(112, 35);
            this.btn_write_csv_file.TabIndex = 8;
            this.btn_write_csv_file.Text = "Write";
            this.btn_write_csv_file.UseVisualStyleBackColor = true;
            this.btn_write_csv_file.Click += new System.EventHandler(this.btn_write_csv_file_Click);
            // 
            // btn_open_csv
            // 
            this.btn_open_csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open_csv.Location = new System.Drawing.Point(8, 14);
            this.btn_open_csv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_open_csv.Name = "btn_open_csv";
            this.btn_open_csv.Size = new System.Drawing.Size(112, 35);
            this.btn_open_csv.TabIndex = 7;
            this.btn_open_csv.Text = "Open";
            this.btn_open_csv.UseVisualStyleBackColor = true;
            this.btn_open_csv.Click += new System.EventHandler(this.btn_open_csv_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(13, 8);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(112, 39);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(153, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 796);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tab_data);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 796);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 763);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab_data
            // 
            this.tab_data.Controls.Add(this.dgv_csv_data);
            this.tab_data.Location = new System.Drawing.Point(4, 29);
            this.tab_data.Name = "tab_data";
            this.tab_data.Padding = new System.Windows.Forms.Padding(3);
            this.tab_data.Size = new System.Drawing.Size(958, 763);
            this.tab_data.TabIndex = 1;
            this.tab_data.Text = "Data";
            this.tab_data.UseVisualStyleBackColor = true;
            // 
            // dgv_csv_data
            // 
            this.dgv_csv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_csv_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_csv_data.Location = new System.Drawing.Point(3, 3);
            this.dgv_csv_data.Name = "dgv_csv_data";
            this.dgv_csv_data.RowHeadersWidth = 62;
            this.dgv_csv_data.RowTemplate.Height = 28;
            this.dgv_csv_data.Size = new System.Drawing.Size(952, 757);
            this.dgv_csv_data.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(958, 763);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(958, 763);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(958, 763);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 796);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpbx_data_tab);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 730);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_exit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 739);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 54);
            this.panel4.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 802);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Project Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpbx_data_tab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_csv_data)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab_data;
        private System.Windows.Forms.DataGridView dgv_csv_data;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_add_csv_column;
        private System.Windows.Forms.Button btn_add_csv_row;
        private System.Windows.Forms.Button btn_write_csv_file;
        private System.Windows.Forms.Button btn_open_csv;
        private System.Windows.Forms.GroupBox grpbx_data_tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}


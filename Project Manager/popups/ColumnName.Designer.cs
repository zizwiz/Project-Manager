
namespace Project_Manager
{
    partial class ColumnName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnName));
            this.btn_column_name = new System.Windows.Forms.Button();
            this.txtbx_column_name = new System.Windows.Forms.TextBox();
            this.lbl_column_name = new System.Windows.Forms.Label();
            this.btn_popup_use_date = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_column_name
            // 
            this.btn_column_name.Location = new System.Drawing.Point(670, 179);
            this.btn_column_name.Name = "btn_column_name";
            this.btn_column_name.Size = new System.Drawing.Size(118, 50);
            this.btn_column_name.TabIndex = 0;
            this.btn_column_name.Text = "OK";
            this.btn_column_name.UseVisualStyleBackColor = true;
            this.btn_column_name.Click += new System.EventHandler(this.btn_column_name_Click);
            // 
            // txtbx_column_name
            // 
            this.txtbx_column_name.Location = new System.Drawing.Point(12, 86);
            this.txtbx_column_name.Name = "txtbx_column_name";
            this.txtbx_column_name.Size = new System.Drawing.Size(776, 26);
            this.txtbx_column_name.TabIndex = 1;
            // 
            // lbl_column_name
            // 
            this.lbl_column_name.AutoSize = true;
            this.lbl_column_name.Location = new System.Drawing.Point(12, 40);
            this.lbl_column_name.Name = "lbl_column_name";
            this.lbl_column_name.Size = new System.Drawing.Size(239, 20);
            this.lbl_column_name.TabIndex = 2;
            this.lbl_column_name.Text = "What name will the column have:";
            // 
            // btn_popup_use_date
            // 
            this.btn_popup_use_date.Location = new System.Drawing.Point(16, 179);
            this.btn_popup_use_date.Name = "btn_popup_use_date";
            this.btn_popup_use_date.Size = new System.Drawing.Size(118, 50);
            this.btn_popup_use_date.TabIndex = 3;
            this.btn_popup_use_date.Text = "Use Date";
            this.btn_popup_use_date.UseVisualStyleBackColor = true;
            this.btn_popup_use_date.Click += new System.EventHandler(this.btn_popup_use_date_Click);
            // 
            // ColumnName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.btn_popup_use_date);
            this.Controls.Add(this.lbl_column_name);
            this.Controls.Add(this.txtbx_column_name);
            this.Controls.Add(this.btn_column_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColumnName";
            this.Text = "Column Name";
            this.Load += new System.EventHandler(this.ColumnName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_column_name;
        private System.Windows.Forms.TextBox txtbx_column_name;
        private System.Windows.Forms.Label lbl_column_name;
        private System.Windows.Forms.Button btn_popup_use_date;
    }
}
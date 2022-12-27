
namespace Project_Manager
{
    partial class AdditionalNames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
      //  private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalNames));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_additional_name = new System.Windows.Forms.TextBox();
            this.txtbx_additional_ID = new System.Windows.Forms.TextBox();
            this.btn_additional_name_add = new System.Windows.Forms.Button();
            this.btn_additional_name_clear = new System.Windows.Forms.Button();
            this.btn_additional_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID: ";
            // 
            // txtbx_additional_name
            // 
            this.txtbx_additional_name.Location = new System.Drawing.Point(167, 60);
            this.txtbx_additional_name.Name = "txtbx_additional_name";
            this.txtbx_additional_name.Size = new System.Drawing.Size(610, 26);
            this.txtbx_additional_name.TabIndex = 2;
            // 
            // txtbx_additional_ID
            // 
            this.txtbx_additional_ID.Location = new System.Drawing.Point(167, 96);
            this.txtbx_additional_ID.Name = "txtbx_additional_ID";
            this.txtbx_additional_ID.Size = new System.Drawing.Size(106, 26);
            this.txtbx_additional_ID.TabIndex = 3;
            // 
            // btn_additional_name_add
            // 
            this.btn_additional_name_add.Location = new System.Drawing.Point(663, 152);
            this.btn_additional_name_add.Name = "btn_additional_name_add";
            this.btn_additional_name_add.Size = new System.Drawing.Size(114, 43);
            this.btn_additional_name_add.TabIndex = 4;
            this.btn_additional_name_add.Text = "Add";
            this.btn_additional_name_add.UseVisualStyleBackColor = true;
            this.btn_additional_name_add.Click += new System.EventHandler(this.btn_additional_name_add_Click);
            // 
            // btn_additional_name_clear
            // 
            this.btn_additional_name_clear.Location = new System.Drawing.Point(520, 152);
            this.btn_additional_name_clear.Name = "btn_additional_name_clear";
            this.btn_additional_name_clear.Size = new System.Drawing.Size(114, 43);
            this.btn_additional_name_clear.TabIndex = 5;
            this.btn_additional_name_clear.Text = "Clear";
            this.btn_additional_name_clear.UseVisualStyleBackColor = true;
            this.btn_additional_name_clear.Click += new System.EventHandler(this.btn_additional_name_clear_Click);
            // 
            // btn_additional_exit
            // 
            this.btn_additional_exit.Location = new System.Drawing.Point(77, 152);
            this.btn_additional_exit.Name = "btn_additional_exit";
            this.btn_additional_exit.Size = new System.Drawing.Size(114, 43);
            this.btn_additional_exit.TabIndex = 6;
            this.btn_additional_exit.Text = "Exit";
            this.btn_additional_exit.UseVisualStyleBackColor = true;
            this.btn_additional_exit.Click += new System.EventHandler(this.btn_additional_exit_Click);
            // 
            // AdditionalNames
            // 
            this.ClientSize = new System.Drawing.Size(905, 234);
            this.Controls.Add(this.btn_additional_exit);
            this.Controls.Add(this.btn_additional_name_clear);
            this.Controls.Add(this.btn_additional_name_add);
            this.Controls.Add(this.txtbx_additional_ID);
            this.Controls.Add(this.txtbx_additional_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdditionalNames";
            this.Text = "Additional Names";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdditionalNames_FormClosing);
            this.Load += new System.EventHandler(this.AdditionalNames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_additional_name;
        private System.Windows.Forms.TextBox txtbx_additional_ID;
        private System.Windows.Forms.Button btn_additional_name_add;
        private System.Windows.Forms.Button btn_additional_name_clear;
        private System.Windows.Forms.Button btn_additional_exit;
    }
}
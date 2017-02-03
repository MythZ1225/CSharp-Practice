namespace BeeHive_Management
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AssignJobBtn = new System.Windows.Forms.Button();
            this.shift = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.workBeeJob = new System.Windows.Forms.ComboBox();
            this.NextShiftBtn = new System.Windows.Forms.Button();
            this.reportCum = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shift)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Bee Job";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AssignJobBtn);
            this.groupBox1.Controls.Add(this.shift);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.workBeeJob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Job Assignments";
            // 
            // AssignJobBtn
            // 
            this.AssignJobBtn.Location = new System.Drawing.Point(8, 75);
            this.AssignJobBtn.Name = "AssignJobBtn";
            this.AssignJobBtn.Size = new System.Drawing.Size(262, 23);
            this.AssignJobBtn.TabIndex = 4;
            this.AssignJobBtn.Text = "Assign Job";
            this.AssignJobBtn.UseVisualStyleBackColor = true;
            this.AssignJobBtn.Click += new System.EventHandler(this.AssignJobBtn_Click_1);
            // 
            // shift
            // 
            this.shift.Location = new System.Drawing.Point(84, 47);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(186, 22);
            this.shift.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shift";
            // 
            // workBeeJob
            // 
            this.workBeeJob.FormattingEnabled = true;
            this.workBeeJob.Items.AddRange(new object[] {
            "採花粉",
            "做花蜜",
            "照顧蛋",
            "托嬰",
            "清理窩",
            "巡邏"});
            this.workBeeJob.Location = new System.Drawing.Point(84, 21);
            this.workBeeJob.Name = "workBeeJob";
            this.workBeeJob.Size = new System.Drawing.Size(186, 20);
            this.workBeeJob.TabIndex = 1;
            // 
            // NextShiftBtn
            // 
            this.NextShiftBtn.Location = new System.Drawing.Point(303, 25);
            this.NextShiftBtn.Name = "NextShiftBtn";
            this.NextShiftBtn.Size = new System.Drawing.Size(164, 92);
            this.NextShiftBtn.TabIndex = 5;
            this.NextShiftBtn.Text = "Next Shift";
            this.NextShiftBtn.UseVisualStyleBackColor = true;
            this.NextShiftBtn.Click += new System.EventHandler(this.NextShiftBtn_Click);
            // 
            // reportCum
            // 
            this.reportCum.Location = new System.Drawing.Point(12, 123);
            this.reportCum.Name = "reportCum";
            this.reportCum.Size = new System.Drawing.Size(455, 96);
            this.reportCum.TabIndex = 7;
            this.reportCum.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 271);
            this.Controls.Add(this.reportCum);
            this.Controls.Add(this.NextShiftBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hive Bee Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AssignJobBtn;
        private System.Windows.Forms.NumericUpDown shift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox workBeeJob;
        private System.Windows.Forms.Button NextShiftBtn;
        private System.Windows.Forms.RichTextBox reportCum;
    }
}


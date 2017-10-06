namespace _467_Excuse_UsingDispose
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExcuseBox = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FolderBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.RandomBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.LastUsedTime = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(485, 175);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DateBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ResultBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExcuseBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastUsedTime, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 129);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Used";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(3, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 33);
            this.label7.TabIndex = 8;
            this.label7.Text = "File date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExcuseBox
            // 
            this.ExcuseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExcuseBox.Location = new System.Drawing.Point(103, 3);
            this.ExcuseBox.Multiline = true;
            this.ExcuseBox.Name = "ExcuseBox";
            this.ExcuseBox.Size = new System.Drawing.Size(373, 26);
            this.ExcuseBox.TabIndex = 9;
            this.ExcuseBox.UseWaitCursor = true;
            this.ExcuseBox.TextChanged += new System.EventHandler(this.ExcuseBox_TextChanged);
            // 
            // ResultBox
            // 
            this.ResultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultBox.Location = new System.Drawing.Point(103, 35);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(373, 26);
            this.ResultBox.TabIndex = 10;
            this.ResultBox.UseWaitCursor = true;
            this.ResultBox.TextChanged += new System.EventHandler(this.ResultBox_TextChanged);
            // 
            // DateBox
            // 
            this.DateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateBox.Location = new System.Drawing.Point(103, 99);
            this.DateBox.Multiline = true;
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(373, 27);
            this.DateBox.TabIndex = 12;
            this.DateBox.UseWaitCursor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FolderBtn);
            this.flowLayoutPanel1.Controls.Add(this.SaveBtn);
            this.flowLayoutPanel1.Controls.Add(this.OpenBtn);
            this.flowLayoutPanel1.Controls.Add(this.RandomBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(479, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FolderBtn
            // 
            this.FolderBtn.Location = new System.Drawing.Point(3, 3);
            this.FolderBtn.Name = "FolderBtn";
            this.FolderBtn.Size = new System.Drawing.Size(100, 23);
            this.FolderBtn.TabIndex = 0;
            this.FolderBtn.Text = "Folder";
            this.FolderBtn.UseVisualStyleBackColor = true;
            this.FolderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Location = new System.Drawing.Point(109, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 23);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Enabled = false;
            this.OpenBtn.Location = new System.Drawing.Point(215, 3);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(100, 23);
            this.OpenBtn.TabIndex = 2;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // RandomBtn
            // 
            this.RandomBtn.Enabled = false;
            this.RandomBtn.Location = new System.Drawing.Point(321, 3);
            this.RandomBtn.Name = "RandomBtn";
            this.RandomBtn.Size = new System.Drawing.Size(155, 23);
            this.RandomBtn.TabIndex = 3;
            this.RandomBtn.Text = "Random";
            this.RandomBtn.UseVisualStyleBackColor = true;
            this.RandomBtn.Click += new System.EventHandler(this.RandomBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LastUsedTime
            // 
            this.LastUsedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LastUsedTime.Location = new System.Drawing.Point(103, 67);
            this.LastUsedTime.Name = "LastUsedTime";
            this.LastUsedTime.Size = new System.Drawing.Size(373, 22);
            this.LastUsedTime.TabIndex = 13;
            this.LastUsedTime.ValueChanged += new System.EventHandler(this.LastUsedTime_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 175);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExcuseBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button FolderBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DateTimePicker LastUsedTime;
    }
}


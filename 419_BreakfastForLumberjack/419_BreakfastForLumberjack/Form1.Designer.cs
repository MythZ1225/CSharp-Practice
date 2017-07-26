namespace _419_BreakfastForLumberjack
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.Crispy = new System.Windows.Forms.RadioButton();
            this.Soggy = new System.Windows.Forms.RadioButton();
            this.Banana = new System.Windows.Forms.RadioButton();
            this.Browned = new System.Windows.Forms.RadioButton();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextInLine = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "伐木工名";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(81, 17);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(192, 22);
            this.nameText.TabIndex = 1;
            // 
            // addLumberjack
            // 
            this.addLumberjack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addLumberjack.Location = new System.Drawing.Point(12, 45);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(261, 23);
            this.addLumberjack.TabIndex = 2;
            this.addLumberjack.Text = "增加伐木工";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            // 
            // Line
            // 
            this.Line.FormattingEnabled = true;
            this.Line.ItemHeight = 12;
            this.Line.Location = new System.Drawing.Point(12, 102);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(103, 268);
            this.Line.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "早餐對列";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(131, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 5;
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(6, 21);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(120, 22);
            this.howMany.TabIndex = 6;
            // 
            // Crispy
            // 
            this.Crispy.AutoSize = true;
            this.Crispy.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crispy.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Crispy.Location = new System.Drawing.Point(6, 49);
            this.Crispy.Name = "Crispy";
            this.Crispy.Size = new System.Drawing.Size(61, 18);
            this.Crispy.TabIndex = 7;
            this.Crispy.TabStop = true;
            this.Crispy.Text = "Crispy";
            this.Crispy.UseVisualStyleBackColor = true;
            // 
            // Soggy
            // 
            this.Soggy.AutoSize = true;
            this.Soggy.Cursor = System.Windows.Forms.Cursors.Default;
            this.Soggy.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Soggy.Location = new System.Drawing.Point(6, 73);
            this.Soggy.Name = "Soggy";
            this.Soggy.Size = new System.Drawing.Size(60, 18);
            this.Soggy.TabIndex = 8;
            this.Soggy.TabStop = true;
            this.Soggy.Text = "Soggy";
            this.Soggy.UseVisualStyleBackColor = true;
            // 
            // Banana
            // 
            this.Banana.AutoSize = true;
            this.Banana.Cursor = System.Windows.Forms.Cursors.Default;
            this.Banana.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Banana.Location = new System.Drawing.Point(5, 121);
            this.Banana.Name = "Banana";
            this.Banana.Size = new System.Drawing.Size(66, 18);
            this.Banana.TabIndex = 10;
            this.Banana.TabStop = true;
            this.Banana.Text = "Banana";
            this.Banana.UseVisualStyleBackColor = true;
            // 
            // Browned
            // 
            this.Browned.AutoSize = true;
            this.Browned.Cursor = System.Windows.Forms.Cursors.Default;
            this.Browned.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Browned.Location = new System.Drawing.Point(5, 97);
            this.Browned.Name = "Browned";
            this.Browned.Size = new System.Drawing.Size(74, 18);
            this.Browned.TabIndex = 9;
            this.Browned.TabStop = true;
            this.Browned.Text = "Browned";
            this.Browned.UseVisualStyleBackColor = true;
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addFlapjacks.Location = new System.Drawing.Point(134, 239);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(121, 23);
            this.addFlapjacks.TabIndex = 11;
            this.addFlapjacks.Text = "增加到隊列";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Controls.Add(this.Crispy);
            this.groupBox1.Controls.Add(this.Banana);
            this.groupBox1.Controls.Add(this.Soggy);
            this.groupBox1.Controls.Add(this.Browned);
            this.groupBox1.Location = new System.Drawing.Point(137, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 148);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "餵飽一個伐木工";
            // 
            // nextInLine
            // 
            this.nextInLine.Location = new System.Drawing.Point(134, 268);
            this.nextInLine.Multiline = true;
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(121, 55);
            this.nextInLine.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(137, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "下一個伐木工";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextInLine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addFlapjacks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.ListBox Line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.RadioButton Crispy;
        private System.Windows.Forms.RadioButton Soggy;
        private System.Windows.Forms.RadioButton Banana;
        private System.Windows.Forms.RadioButton Browned;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nextInLine;
        private System.Windows.Forms.Button button1;
    }
}


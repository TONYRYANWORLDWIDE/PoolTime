namespace PoolTime
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
            this.tbInches = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimeLeft = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCalcTime = new System.Windows.Forms.Button();
            this.tbSecGal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInchesRaised = new System.Windows.Forms.TextBox();
            this.tbGallons = new System.Windows.Forms.Label();
            this.tbglns = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbInches
            // 
            this.tbInches.Location = new System.Drawing.Point(65, 127);
            this.tbInches.Name = "tbInches";
            this.tbInches.Size = new System.Drawing.Size(145, 22);
            this.tbInches.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inches Left";
            // 
            // tbTimeLeft
            // 
            this.tbTimeLeft.Location = new System.Drawing.Point(62, 203);
            this.tbTimeLeft.Name = "tbTimeLeft";
            this.tbTimeLeft.Size = new System.Drawing.Size(145, 22);
            this.tbTimeLeft.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "time left";
            // 
            // btCalcTime
            // 
            this.btCalcTime.Location = new System.Drawing.Point(281, 373);
            this.btCalcTime.Name = "btCalcTime";
            this.btCalcTime.Size = new System.Drawing.Size(108, 53);
            this.btCalcTime.TabIndex = 3;
            this.btCalcTime.Text = "Calculate Time";
            this.btCalcTime.UseVisualStyleBackColor = true;
            this.btCalcTime.Click += new System.EventHandler(this.BtCalcTime_Click);
            // 
            // tbSecGal
            // 
            this.tbSecGal.Location = new System.Drawing.Point(62, 52);
            this.tbSecGal.Name = "tbSecGal";
            this.tbSecGal.Size = new System.Drawing.Size(145, 22);
            this.tbSecGal.TabIndex = 1;
            this.tbSecGal.Text = "12.5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seconds For 1 Gallon";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(269, 52);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(120, 22);
            this.tbTime.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Inches";
            // 
            // tbInchesRaised
            // 
            this.tbInchesRaised.Location = new System.Drawing.Point(269, 127);
            this.tbInchesRaised.Name = "tbInchesRaised";
            this.tbInchesRaised.Size = new System.Drawing.Size(120, 22);
            this.tbInchesRaised.TabIndex = 11;
            // 
            // tbGallons
            // 
            this.tbGallons.AutoSize = true;
            this.tbGallons.Location = new System.Drawing.Point(266, 183);
            this.tbGallons.Name = "tbGallons";
            this.tbGallons.Size = new System.Drawing.Size(56, 17);
            this.tbGallons.TabIndex = 14;
            this.tbGallons.Text = "Gallons";
            // 
            // tbglns
            // 
            this.tbglns.Location = new System.Drawing.Point(269, 205);
            this.tbglns.Name = "tbglns";
            this.tbglns.Size = new System.Drawing.Size(120, 22);
            this.tbglns.TabIndex = 13;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(62, 373);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(99, 61);
            this.btClear.TabIndex = 15;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(62, 279);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(327, 70);
            this.tbMessage.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbGallons);
            this.Controls.Add(this.tbglns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbInchesRaised);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSecGal);
            this.Controls.Add(this.btCalcTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTimeLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInches);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pool Time Excellent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimeLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalcTime;
        private System.Windows.Forms.TextBox tbSecGal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInchesRaised;
        private System.Windows.Forms.Label tbGallons;
        private System.Windows.Forms.TextBox tbglns;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbMessage;
    }
}


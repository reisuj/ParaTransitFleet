namespace ParaTransitFleet
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
            this.lblSearchString = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblVehTitle = new System.Windows.Forms.Label();
            this.lblTagTitle = new System.Windows.Forms.Label();
            this.lblProviderTitle = new System.Windows.Forms.Label();
            this.lblProviderName = new System.Windows.Forms.Label();
            this.lblTagNum = new System.Windows.Forms.Label();
            this.lblVehicleNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSearchString
            // 
            this.lblSearchString.AutoSize = true;
            this.lblSearchString.Location = new System.Drawing.Point(11, 9);
            this.lblSearchString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchString.Name = "lblSearchString";
            this.lblSearchString.Size = new System.Drawing.Size(172, 13);
            this.lblSearchString.TabIndex = 2;
            this.lblSearchString.Text = "Enter Vehicle \"P\" number or Tag #\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(151, 38);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(56, 19);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblVehTitle
            // 
            this.lblVehTitle.AutoSize = true;
            this.lblVehTitle.Location = new System.Drawing.Point(15, 79);
            this.lblVehTitle.Name = "lblVehTitle";
            this.lblVehTitle.Size = new System.Drawing.Size(52, 13);
            this.lblVehTitle.TabIndex = 5;
            this.lblVehTitle.Text = "Vehicle #";
            // 
            // lblTagTitle
            // 
            this.lblTagTitle.AutoSize = true;
            this.lblTagTitle.Location = new System.Drawing.Point(110, 79);
            this.lblTagTitle.Name = "lblTagTitle";
            this.lblTagTitle.Size = new System.Drawing.Size(36, 13);
            this.lblTagTitle.TabIndex = 6;
            this.lblTagTitle.Text = "Tag #";
            // 
            // lblProviderTitle
            // 
            this.lblProviderTitle.AutoSize = true;
            this.lblProviderTitle.Location = new System.Drawing.Point(214, 79);
            this.lblProviderTitle.Name = "lblProviderTitle";
            this.lblProviderTitle.Size = new System.Drawing.Size(46, 13);
            this.lblProviderTitle.TabIndex = 7;
            this.lblProviderTitle.Text = "Provider";
            // 
            // lblProviderName
            // 
            this.lblProviderName.AutoSize = true;
            this.lblProviderName.Location = new System.Drawing.Point(214, 101);
            this.lblProviderName.Name = "lblProviderName";
            this.lblProviderName.Size = new System.Drawing.Size(0, 13);
            this.lblProviderName.TabIndex = 10;
            // 
            // lblTagNum
            // 
            this.lblTagNum.AutoSize = true;
            this.lblTagNum.Location = new System.Drawing.Point(110, 101);
            this.lblTagNum.Name = "lblTagNum";
            this.lblTagNum.Size = new System.Drawing.Size(0, 13);
            this.lblTagNum.TabIndex = 9;
            // 
            // lblVehicleNum
            // 
            this.lblVehicleNum.AutoSize = true;
            this.lblVehicleNum.Location = new System.Drawing.Point(15, 101);
            this.lblVehicleNum.Name = "lblVehicleNum";
            this.lblVehicleNum.Size = new System.Drawing.Size(0, 13);
            this.lblVehicleNum.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 141);
            this.Controls.Add(this.lblProviderName);
            this.Controls.Add(this.lblTagNum);
            this.Controls.Add(this.lblVehicleNum);
            this.Controls.Add(this.lblProviderTitle);
            this.Controls.Add(this.lblTagTitle);
            this.Controls.Add(this.lblVehTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSearchString);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearchString;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblVehTitle;
        private System.Windows.Forms.Label lblTagTitle;
        private System.Windows.Forms.Label lblProviderTitle;
        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.Label lblTagNum;
        private System.Windows.Forms.Label lblVehicleNum;
    }
}


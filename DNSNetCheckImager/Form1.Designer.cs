namespace DNSNetCheckImager
{
    partial class DNSNetCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNSNetCheck));
            this.screenShotBtn = new System.Windows.Forms.Button();
            this.storeNumberLabel = new System.Windows.Forms.Label();
            this.storeNumberInput = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screenShotBtn
            // 
            this.screenShotBtn.Location = new System.Drawing.Point(253, 12);
            this.screenShotBtn.Name = "screenShotBtn";
            this.screenShotBtn.Size = new System.Drawing.Size(123, 40);
            this.screenShotBtn.TabIndex = 0;
            this.screenShotBtn.Text = "Make Screenshot";
            this.screenShotBtn.UseVisualStyleBackColor = true;
            this.screenShotBtn.Click += new System.EventHandler(this.screenShotBtn_Click);
            // 
            // storeNumberLabel
            // 
            this.storeNumberLabel.AutoSize = true;
            this.storeNumberLabel.Location = new System.Drawing.Point(23, 26);
            this.storeNumberLabel.Name = "storeNumberLabel";
            this.storeNumberLabel.Size = new System.Drawing.Size(39, 13);
            this.storeNumberLabel.TabIndex = 1;
            this.storeNumberLabel.Text = "Store#";
            // 
            // storeNumberInput
            // 
            this.storeNumberInput.Location = new System.Drawing.Point(68, 23);
            this.storeNumberInput.Name = "storeNumberInput";
            this.storeNumberInput.Size = new System.Drawing.Size(100, 20);
            this.storeNumberInput.TabIndex = 2;
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(167, 22);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(36, 20);
            this.goBtn.TabIndex = 3;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // DNSNetCheck
            // 
            this.AccessibleName = "DNSNetCheck";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 558);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.storeNumberInput);
            this.Controls.Add(this.storeNumberLabel);
            this.Controls.Add(this.screenShotBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DNSNetCheck";
            this.Text = " DNSNetCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button screenShotBtn;
        private System.Windows.Forms.Label storeNumberLabel;
        private System.Windows.Forms.TextBox storeNumberInput;
        private System.Windows.Forms.Button goBtn;
    }
}


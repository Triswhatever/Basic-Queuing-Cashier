namespace Basic_Queuing_Cashier
{
    partial class CustomerView
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
            this.ServingLabel = new System.Windows.Forms.Label();
            this.CurrentServe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ServingLabel
            // 
            this.ServingLabel.AutoSize = true;
            this.ServingLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServingLabel.Location = new System.Drawing.Point(177, 41);
            this.ServingLabel.Name = "ServingLabel";
            this.ServingLabel.Size = new System.Drawing.Size(213, 45);
            this.ServingLabel.TabIndex = 0;
            this.ServingLabel.Text = "*Now Serving";
            // 
            // CurrentServe
            // 
            this.CurrentServe.AutoSize = true;
            this.CurrentServe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentServe.Location = new System.Drawing.Point(214, 157);
            this.CurrentServe.Name = "CurrentServe";
            this.CurrentServe.Size = new System.Drawing.Size(121, 48);
            this.CurrentServe.TabIndex = 1;
            this.CurrentServe.Text = "label2";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 345);
            this.Controls.Add(this.CurrentServe);
            this.Controls.Add(this.ServingLabel);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ServingLabel;
        public Label CurrentServe;
    }
}
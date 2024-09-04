namespace QueueingApplication
{
    partial class QueuingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCashier = new Button();
            lblClickGuide = new Label();
            lblPosQueue = new Label();
            lblQueue = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Segoe UI", 15F);
            btnCashier.Location = new Point(12, 41);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(126, 120);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblClickGuide
            // 
            lblClickGuide.AutoSize = true;
            lblClickGuide.Font = new Font("Segoe UI", 7F);
            lblClickGuide.ForeColor = Color.Red;
            lblClickGuide.Location = new Point(12, 179);
            lblClickGuide.Name = "lblClickGuide";
            lblClickGuide.Size = new Size(126, 15);
            lblClickGuide.TabIndex = 1;
            lblClickGuide.Text = "*Click to get a number";
            // 
            // lblPosQueue
            // 
            lblPosQueue.AutoSize = true;
            lblPosQueue.Font = new Font("Segoe UI", 13F);
            lblPosQueue.Location = new Point(209, 53);
            lblPosQueue.Name = "lblPosQueue";
            lblPosQueue.Size = new Size(182, 30);
            lblPosQueue.TabIndex = 2;
            lblPosQueue.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            lblQueue.Location = new Point(171, 83);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(288, 78);
            lblQueue.TabIndex = 3;
            lblQueue.Text = "P - 00000";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 217);
            Controls.Add(lblQueue);
            Controls.Add(lblPosQueue);
            Controls.Add(lblClickGuide);
            Controls.Add(btnCashier);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "QueuingForm";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label lblClickGuide;
        private Label lblPosQueue;
        private Label lblQueue;
    }
}

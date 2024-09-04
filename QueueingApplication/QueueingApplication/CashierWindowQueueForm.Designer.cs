namespace QueueingApplication
{
    partial class CashierWindowQueue
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
            btnRefresh = new Button();
            btnNext = new Button();
            listCashierQueue = new ListView();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 13F);
            btnRefresh.Location = new Point(12, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(123, 42);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 13F);
            btnNext.Location = new Point(12, 60);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(123, 39);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.BorderStyle = BorderStyle.FixedSingle;
            listCashierQueue.Font = new Font("Segoe UI", 15F);
            listCashierQueue.GridLines = true;
            listCashierQueue.HeaderStyle = ColumnHeaderStyle.None;
            listCashierQueue.HideSelection = true;
            listCashierQueue.Location = new Point(141, 12);
            listCashierQueue.MultiSelect = false;
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(252, 356);
            listCashierQueue.TabIndex = 2;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            listCashierQueue.View = View.List;
            listCashierQueue.SelectedIndexChanged += listCashierQueue_SelectedIndexChanged;
            // 
            // CashierWindowQueue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 380);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CashierWindowQueue";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnNext;
        private ListView listCashierQueue;
    }
}
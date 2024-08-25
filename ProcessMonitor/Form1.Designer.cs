namespace ProcessMonitor
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelElapsedTime = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button(); // Add this line
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.ProcessName,
            this.Status,
            this.LastActivity});
            this.dataGridView1.Location = new System.Drawing.Point(12, 100); // Adjusted to make space for the button
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.MinimumWidth = 6;
            this.PID.Name = "PID";
            this.PID.Width = 80;
            this.PID.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "Name";
            this.ProcessName.MinimumWidth = 6;
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Width = 350;
            this.ProcessName.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            this.Status.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // LastActivity
            // 
            this.LastActivity.HeaderText = "Last Activity";
            this.LastActivity.MinimumWidth = 6;
            this.LastActivity.Name = "LastActivity";
            this.LastActivity.Width = 176;
            this.LastActivity.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // labelHeader
            // 
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(576, 40);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Process Monitor";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelElapsedTime
            // 
            this.labelElapsedTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElapsedTime.Location = new System.Drawing.Point(594, 9);
            this.labelElapsedTime.Name = "labelElapsedTime";
            this.labelElapsedTime.Size = new System.Drawing.Size(194, 40);
            this.labelElapsedTime.TabIndex = 2;
            this.labelElapsedTime.Text = "Elapsed Time: 0s";
            this.labelElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartStop.Location = new System.Drawing.Point(12, 55);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(100, 30);
            this.buttonStartStop.TabIndex = 3;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.labelElapsedTime);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Process Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastActivity;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelElapsedTime;
        private System.Windows.Forms.Button buttonStartStop; // Add this line
    }
}

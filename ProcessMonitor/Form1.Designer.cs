namespace ProcessMonitor
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            PID = new DataGridViewTextBoxColumn();
            ProcessName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            LastActivity = new DataGridViewTextBoxColumn();
            labelHeader = new Label();
            labelElapsedTime = new Label();
            buttonStartStop = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PID, ProcessName, Status, LastActivity });
            dataGridView1.Location = new Point(12, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 338);
            dataGridView1.TabIndex = 0;
            // 
            // PID
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PID.DefaultCellStyle = dataGridViewCellStyle2;
            PID.HeaderText = "PID";
            PID.MinimumWidth = 6;
            PID.Name = "PID";
            PID.Width = 80;
            // 
            // ProcessName
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProcessName.DefaultCellStyle = dataGridViewCellStyle3;
            ProcessName.HeaderText = "Name";
            ProcessName.MinimumWidth = 6;
            ProcessName.Name = "ProcessName";
            ProcessName.Width = 350;
            // 
            // Status
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Status.DefaultCellStyle = dataGridViewCellStyle4;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // LastActivity
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LastActivity.DefaultCellStyle = dataGridViewCellStyle5;
            LastActivity.HeaderText = "Last Activity";
            LastActivity.MinimumWidth = 6;
            LastActivity.Name = "LastActivity";
            LastActivity.Width = 176;
            // 
            // labelHeader
            // 
            labelHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.ForeColor = Color.Firebrick;
            labelHeader.Location = new Point(12, 9);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(576, 40);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Process Monitor";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelElapsedTime
            // 
            labelElapsedTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelElapsedTime.Location = new Point(594, 9);
            labelElapsedTime.Name = "labelElapsedTime";
            labelElapsedTime.Size = new Size(194, 40);
            labelElapsedTime.TabIndex = 2;
            labelElapsedTime.Text = "Elapsed Time: 0s";
            labelElapsedTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonStartStop
            // 
            buttonStartStop.BackColor = SystemColors.Info;
            buttonStartStop.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStartStop.ForeColor = SystemColors.Desktop;
            buttonStartStop.Location = new Point(12, 55);
            buttonStartStop.Name = "buttonStartStop";
            buttonStartStop.Size = new Size(100, 30);
            buttonStartStop.TabIndex = 3;
            buttonStartStop.Text = "Start";
            buttonStartStop.UseVisualStyleBackColor = false;
            buttonStartStop.Click += buttonStartStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStartStop);
            Controls.Add(labelElapsedTime);
            Controls.Add(labelHeader);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Process Monitor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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

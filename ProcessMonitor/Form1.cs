using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ProcessMonitor
{
    public partial class Form1 : Form
    {
        private Dictionary<int, ProcessInfo> monitoredProcesses;
        private HashSet<int> initialPids;

        public Form1()
        {
            InitializeComponent();
            monitoredProcesses = new Dictionary<int, ProcessInfo>();
            initialPids = new HashSet<int>(Process.GetProcesses().Select(p => p.Id));

            var timer = new System.Windows.Forms.Timer { Interval = 2000 };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            UpdateProcesses();
            DisplayProcesses();
        }

        private void UpdateProcesses()
        {
            var currentProcesses = Process.GetProcesses().ToDictionary(p => p.Id, p => p);

            foreach (var proc in currentProcesses.Values)
            {
                if (!initialPids.Contains(proc.Id) && !monitoredProcesses.ContainsKey(proc.Id))
                {
                    monitoredProcesses[proc.Id] = new ProcessInfo
                    {
                        PID = proc.Id,
                        ProcessName = proc.ProcessName ?? "Unknown",
                        Status = "Running",
                        LastActivity = DateTime.Now.ToString("HH:mm:ss")
                    };
                    AddProcessToGrid(monitoredProcesses[proc.Id]);
                }
            }

            foreach (var pid in monitoredProcesses.Keys.ToList())
            {
                if (!ProcessExists(pid) && monitoredProcesses[pid].Status != "Terminated")
                {
                    monitoredProcesses[pid].Status = "Terminated";
                    monitoredProcesses[pid].LastActivity = DateTime.Now.ToString("HH:mm:ss");
                    UpdateProcessInGrid(pid);
                }
            }
        }

        private void DisplayProcesses()
        {
            dataGridView1.Rows.Clear();

            var sortedProcesses = monitoredProcesses.Values
                .OrderByDescending(p => p.Status == "Running")
                .ThenByDescending(p => DateTime.Parse(p.LastActivity))
                .ToList();

            foreach (var process in sortedProcesses)
            {
                dataGridView1.Rows.Add(process.PID, process.ProcessName, process.Status, process.LastActivity);
            }
        }

        private bool ProcessExists(int pid)
        {
            return Process.GetProcesses().Any(p => p.Id == pid);
        }

        private void AddProcessToGrid(ProcessInfo process)
        {
            dataGridView1.Rows.Add(process.PID, process.ProcessName, process.Status, process.LastActivity);
        }

        private void UpdateProcessInGrid(int pid)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((int)row.Cells["PID"].Value == pid)
                {
                    row.Cells["Status"].Value = "Terminated";
                    row.Cells["LastActivity"].Value = monitoredProcesses[pid].LastActivity;
                    break;
                }
            }
        }
    }

    public class ProcessInfo
    {
        public int PID { get; set; }
        public string ProcessName { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string LastActivity { get; set; } = string.Empty;
    }
}

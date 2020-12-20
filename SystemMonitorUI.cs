using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using SystemInfoTransfer.SystemMonitor;

namespace SystemInfoTransfer {
    public partial class SystemMonitorUI : Form {
        private string[] ports;
        private SerialPort port;
        private bool isConnect;
        private ISystemMonitor systemMonitor;

        private Dictionary<string, float> systemInfoData = new Dictionary<string, float> ();

        public SystemMonitorUI () {
            InitializeComponent ();
        }

        protected override void OnLoad (EventArgs e) {
            base.OnLoad (e);
            systemMonitor = new OpenHardwareSystemMonitor ();
            ports = SerialPort.GetPortNames ();
            foreach (var portSeria in ports) {
                SerialPortCb.Items.Add (portSeria);
            }
            if (SerialPortCb.Items.Count > 0)
                ConnectBtn.Enabled = true;
            systemMonitor.GetSystemInfo ();
        }

        private void SetupSystemInfoDataGrid () {
            SystemInfoDg.ColumnCount = 2;

            SystemInfoDg.Dock = DockStyle.Fill;

            SystemInfoDg.Columns[0].Name = "Hardware Type";
            SystemInfoDg.Columns[1].Name = "Temperature";

            SystemInfoDg.Columns[0].DisplayIndex = 0;
            SystemInfoDg.Columns[1].DisplayIndex = 1;
        }

        private void PopulateDataGridView () {
            while (true) {
                systemMonitor.GetSystemInfo ();
            }
        }

        private void ConnectBtn_Click (object sender, EventArgs e) {
            try {
                if (!isConnect && SerialPortCb.SelectedItem != null) {
                    ConnectToArduino ();
                }
                else {
                    DisconnectFromArduino ();
                }
            }
            catch (Exception ex) when (
                ex is IOException ||
                ex is UnauthorizedAccessException ||
                ex is ArgumentOutOfRangeException ||
                ex is ArgumentException ||
                ex is InvalidOperationException
            ) {
                ErrorLb.Text = ex.Message;
                ErrorLb.Enabled = true;
            }
        }

        private void ConnectToArduino () {
            OpenSelectedPort ();
            if (port.IsOpen) {
                ConnectBtn.Text = @"Disconnect";
                isConnect = true;
                SerialPortCb.Enabled = false;
                port.Write ("#STAR\n");
            }
        }
        private void DisconnectFromArduino () {
            if (port.IsOpen) {
                port.Write ("#STOP\n");
                port.Close ();
                isConnect = false;
                SerialPortCb.Enabled = true;
                ConnectBtn.Text = @"Connect";
            }
        }

        private void OpenSelectedPort () {
            string selectedPort = SerialPortCb.GetItemText (SerialPortCb.SelectedItem);
            port = new SerialPort (selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open ();
        }
    }
}

using System;
using OpenHardwareMonitor.Hardware;

namespace SystemInfoTransfer.SystemMonitor {
    public class OpenHardwareSystemMonitor : ISystemMonitor, IVisitor {
        public void VisitComputer (IComputer computer) {
            computer.Traverse (this);
        }

        public void VisitHardware (IHardware hardware) {
            hardware.Update ();
            foreach (IHardware subHardware in hardware.SubHardware)
                subHardware.Accept (this);
        }

        public void VisitSensor (ISensor sensor) { }

        public void VisitParameter (IParameter parameter) { }

        public void GetSystemInfo () {
            Computer computer = new Computer ();
            computer.Open ();
            computer.CPUEnabled = true;
            computer.Accept (this);
            foreach (var hardware in computer.Hardware) {
                if (hardware.HardwareType != HardwareType.CPU) continue;
                foreach (var sensor in hardware.Sensors) {
                    if (sensor.SensorType == SensorType.Temperature)
                        Console.WriteLine ($@"{sensor.Name}: {sensor.Value}°C\r");
                }
            }
            Console.WriteLine(@"\r");
            computer.Close ();
        }
    }
}

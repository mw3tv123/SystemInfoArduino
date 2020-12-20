using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemInfoTransfer.SystemMonitor;

namespace SystemInfoTransfer {
    public class Program {
        public static void Main (string[] args) {
            Task uiTask = new Task(RunUI);
            uiTask.Start();
            Console.ReadKey ();
        }

        static void RunUI () {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new SystemMonitorUI ());
        }
    }
}
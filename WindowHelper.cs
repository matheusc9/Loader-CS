using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace LoaderC_
{
    class WindowHelper
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public static void FocusProcess(Process process)
        {
            if (process == null || process.MainWindowHandle == IntPtr.Zero)
                return;

            SetForegroundWindow(process.MainWindowHandle);
        }
    }
}

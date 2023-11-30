using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AIProofGen
{
    internal static class HotKeyHook
    {
        private const int WhKeyboardLl = 13;
        private const int WmKeydown = 0x0100;
        internal static readonly LowLevelKeyboardProc Proc = HookCallback;
        internal static  IntPtr HookId = IntPtr.Zero;
        internal delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);
        internal static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using var curProcess = Process.GetCurrentProcess();
            using var curModule = curProcess.MainModule;
            return SetWindowsHookEx(WhKeyboardLl, proc,
                GetModuleHandle(curModule?.ModuleName ?? string.Empty), 0);
        }
        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == WmKeydown)
            {
                var vkCode = Marshal.ReadInt32(lParam);
                var key = (Keys)vkCode;
                Console.WriteLine((Keys)vkCode);
                switch (key)
                {
                    case Keys.Next or Keys.PageDown or Keys.PageUp or Keys.Play or Keys.MediaPlayPause:
                    {
                        SendKeys.SendWait("^{a}");
                        SendKeys.SendWait("^{x}");
                        ConversionForm.ConvertClipboardTextToImage();
                        SendKeys.Send("^{v}");
                        var randomText= ConversionForm.GetRandomString();
                        Clipboard.SetText(randomText);
                        SendKeys.Send("^{v}");
                        break;
                    }
               
                    case Keys.Next or Keys.Insert or Keys.Delete:
                    {
                        SendKeys.SendWait("^{a}");
                        SendKeys.SendWait("^{x}");
                        var randomText= ConversionForm.GetRandomString();
                        Clipboard.SetText(randomText);
                        SendKeys.Send("^{v}");
                        break;
                    }
                }
            }
            return CallNextHookEx(HookId, nCode, wParam, lParam);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}

namespace AIProofGen
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            HotKeyHook.HookId = HotKeyHook.SetHook(HotKeyHook.Proc);
            ApplicationConfiguration.Initialize();
            Application.Run(ConversionForm.Instance);
            HotKeyHook.UnhookWindowsHookEx(HotKeyHook.HookId);
        }

    }
}
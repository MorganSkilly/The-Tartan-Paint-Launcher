using System;
using Microsoft.Win32;
using System.IO;
using System.Reflection;

namespace The_Tartan_Paint_Launcher
{
    class Setup
    {
        public static void FirstTimeSetup()
        {
            AddKeys();
        }
        public static void Uninstaller()
        {
            RemoveKeys();
        }

        private static void AddKeys()
        {
            RegistryKey key;
            key = Registry.ClassesRoot.CreateSubKey("tartanpaint");
            key.SetValue("", "Tartan Paint Launcher");
            key.SetValue("URL Protocol", "");

            RegistryKey icon = key.CreateSubKey("DefaultIcon");
            icon.SetValue("", "TartanPaintLauncher.exe", 0);
            key = key.CreateSubKey("Shell");
            key = key.CreateSubKey("open");
            key = key.CreateSubKey("command");
            //key.SetValue("", "\"C:\\The Kraken\\Kraken Launcher.exe\" \"%1\"");

            string path = Path.GetFullPath(Assembly.GetEntryAssembly().Location).Replace("dll", "exe");

            key.SetValue("", path);
        }

        private static void RemoveKeys()
        {
            Registry.ClassesRoot.DeleteSubKeyTree("tartanpaint");
        }
    }
}
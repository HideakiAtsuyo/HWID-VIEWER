using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace HWID_CONSOLE_VIEWER
{
    class Program
    {
        private static string GetHWID()
        {
            string location = @"SOFTWARE\Microsoft\Cryptography";string name = "MachineGuid";

            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey rk = localMachineX64View.OpenSubKey(location))
                {
                    if (rk == null)throw new KeyNotFoundException(string.Format("Clé de registre non trouvé: {0}", location));
                    object HWID = rk.GetValue(name);
                    if (HWID == null) throw new IndexOutOfRangeException(string.Format("Index non trouvé: {0}", name));
                    return HWID.ToString();
                }
            }
        }
        static void Main()
        {
            //Console.SetWindowPosition(0, 0);
            Console.Title = "HWID-VIEWER";Console.Write("Your HWID: ");Console.WriteLine(GetHWID()); Console.WriteLine("Veuillez appuyer sur 'Entrée' pour quitter");Console.ReadLine();
        }
    }
}
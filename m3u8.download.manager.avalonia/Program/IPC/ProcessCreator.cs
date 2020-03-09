﻿using System;
using System.Runtime.InteropServices;

namespace m3u8.download.manager.ipc
{
    /// <summary>
    /// 
    /// </summary>
    internal static class ProcessCreator
    {
        public static bool CreateAsBreakawayFromJob( string commandLine )
        {
            var si = new STARTUPINFO() { cb = Marshal.SizeOf(typeof(STARTUPINFO)) };

            var r = CreateProcess( null, //Process.GetCurrentProcess().MainModule.FileName, 
                                   commandLine,
                                   IntPtr.Zero,
                                   IntPtr.Zero,
                                   false, 
                                   CREATE_BREAKAWAY_FROM_JOB, 
                                   IntPtr.Zero, 
                                   null, //Environment.CurrentDirectory, 
                                   ref si, 
                                   out var processInformation );
            return (r);
        }


        private const uint CREATE_BREAKAWAY_FROM_JOB = 0x01000000;

        #region comm
        /*[StructLayout(LayoutKind.Sequential)] private struct SECURITY_ATTRIBUTES
        {
            public int nLength;
            public IntPtr lpSecurityDescriptor;
            public int bInheritHandle;
        }*/ 
        #endregion

        [StructLayout(LayoutKind.Sequential)]
        private struct PROCESS_INFORMATION 
        {
           public IntPtr hProcess;
           public IntPtr hThread;
           public int    dwProcessId;
           public int    dwThreadId;
        }

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
        private struct STARTUPINFO
        {
             public Int32  cb;
             public string lpReserved;
             public string lpDesktop;
             public string lpTitle;
             public Int32  dwX;
             public Int32  dwY;
             public Int32  dwXSize;
             public Int32  dwYSize;
             public Int32  dwXCountChars;
             public Int32  dwYCountChars;
             public Int32  dwFillAttribute;
             public Int32  dwFlags;
             public Int16  wShowWindow;
             public Int16  cbReserved2;
             public IntPtr lpReserved2;
             public IntPtr hStdInput;
             public IntPtr hStdOutput;
             public IntPtr hStdError;
        }

        [DllImport("kernel32.dll", SetLastError=true, CharSet=CharSet.Auto)]
        private static extern bool CreateProcess( string lpApplicationName,
                                                  string lpCommandLine,
                                                  IntPtr lpProcessAttributes, //ref SECURITY_ATTRIBUTES lpProcessAttributes,
                                                  IntPtr lpThreadAttributes, //ref SECURITY_ATTRIBUTES lpThreadAttributes,
                                                  bool bInheritHandles,
                                                  uint dwCreationFlags,
                                                  IntPtr lpEnvironment,
                                                  string lpCurrentDirectory,
                                                  [In] ref STARTUPINFO lpStartupInfo,
                                                  out PROCESS_INFORMATION lpProcessInformation );
    }
}

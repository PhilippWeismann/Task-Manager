using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    public static class CpuRamPerformance
    {

        #region Settings to get Ram-usage
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalMemoryStatusEx(ref MEMORY_INFO mi);

        //Define the information structure of memory
        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_INFO
        {
            public uint dwLength; //Current structure size
            public uint dwMemoryLoad; //Current memory utilization
            public ulong ullTotalPhys; //Total physical memory size
            public ulong ullAvailPhys; //Available physical memory size
            public ulong ullTotalPageFile; //Total Exchange File Size
            public ulong ullAvailPageFile; //Total Exchange File Size
            public ulong ullTotalVirtual; //Total virtual memory size
            public ulong ullAvailVirtual; //Available virtual memory size
            public ulong ullAvailExtendedVirtual; //Keep this value always zero
        }
        #endregion

        #region Members
        private static PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        #endregion


        #region Methods
        public static int GetCurrentCPUPercentage()     //get CPU useage in int
        {        
            return Convert.ToInt32(Math.Round(cpuCounter.NextValue()));
        }


        public static int GetCurrentRAMPercentage()
        {
            MEMORY_INFO mi = GetMemoryStatus();

            ulong totalRam = mi.ullTotalPhys;
            ulong usedRam = (mi.ullTotalPhys - mi.ullAvailPhys);

            double portion = ((usedRam * 1.0) / totalRam);
            return Convert.ToInt16(portion * 100);
        }

        public static MEMORY_INFO GetMemoryStatus()
        {
            MEMORY_INFO mi = new MEMORY_INFO();
            mi.dwLength = (uint)System.Runtime.InteropServices.Marshal.SizeOf(mi);
            GlobalMemoryStatusEx(ref mi);
            return mi;
        }


        #endregion
    }
}

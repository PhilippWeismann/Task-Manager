using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
    public static class CpuRamPerformance // static class -> no object must be initialized
    {

        #region Settings to get Ram-usage (online source)
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
        private static PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"); //new Performance Counter Object gets initialized for CPU measurement
        #endregion


        #region Methods
        public static int GetCurrentCPUPercentage()     //get CPU useage in int
        {        
            return Convert.ToInt32(Math.Round(cpuCounter.NextValue()));
        }


        public static int GetCurrentRAMPercentage() //get RAM usage in int
        {
            MEMORY_INFO mi = GetMemoryStatus(); //get the current memory status from struct MEMORY_INFO (online source)

            //Calculate percentage of used memory
            ulong totalRam = mi.ullTotalPhys;
            ulong usedRam = (mi.ullTotalPhys - mi.ullAvailPhys);

            double portion = ((usedRam * 1.0) / totalRam);
            return Convert.ToInt16(portion * 100);
        }

        public static MEMORY_INFO GetMemoryStatus() //get the current memory status from struct MEMORY_INFO (online source)
        {
            MEMORY_INFO mi = new MEMORY_INFO();
            mi.dwLength = (uint)System.Runtime.InteropServices.Marshal.SizeOf(mi);
            GlobalMemoryStatusEx(ref mi);
            return mi;
        }


        #endregion
    }
}
